using UnityEngine;

namespace Royal.Infrastructure.Services.Analytics
{
    public class EventWriter
    {
        // Fields
        private static readonly System.Uri AnalyticsUri;
        private const int MaxFileSize = 5120;
        private const string WriterThreadName = "EventWriterThread";
        private const string EventsFileName = "royal.events";
        private const string DateFormat = ".yyMMddHHmmss";
        private readonly string path1;
        private static readonly string DirectoryPath;
        private System.Threading.Thread writerThread;
        private bool shouldCheckTempUser;
        private bool isRunning;
        private bool isWriting;
        private bool shouldPause;
        private bool shouldClear;
        private int sendTryCount;
        private string sendingFile;
        private string killEvent;
        private readonly System.Text.StringBuilder eventBuilder;
        private readonly System.Collections.Concurrent.ConcurrentQueue<Royal.Infrastructure.Services.Analytics.EventData> eventQueue;
        private readonly System.Net.Http.HttpClient httpClient;
        
        // Methods
        public EventWriter()
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = null;
            val_9 = null;
            this.path1 = System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath, path2:  "royal.events");
            this.eventQueue = new System.Collections.Concurrent.ConcurrentQueue<Royal.Infrastructure.Services.Analytics.EventData>();
            this.eventBuilder = new System.Text.StringBuilder();
            this.httpClient = Royal.Infrastructure.Services.Analytics.EventWriter.CreateHttpClient();
            if((System.IO.Directory.Exists(path:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath)) != true)
            {
                    val_10 = null;
                val_10 = null;
                System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath);
            }
            
            this.shouldCheckTempUser = true;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) != true)
            {
                    val_11 = null;
                val_11 = null;
                System.String[] val_7 = System.IO.Directory.GetFiles(path:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath);
                if(val_7.Length == 0)
            {
                    this.shouldCheckTempUser = false;
            }
            
            }
            
            this.killEvent = UnityEngine.PlayerPrefs.GetString(key:  "TempLevelKill", defaultValue:  0);
            UnityEngine.PlayerPrefs.DeleteKey(key:  "TempLevelKill");
        }
        private static System.Net.Http.HttpClient CreateHttpClient()
        {
            System.Net.Http.HttpClient val_1 = new System.Net.Http.HttpClient();
            System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  10);
            val_1.Timeout = new System.TimeSpan() {_ticks = val_2._ticks};
            val_1.DefaultRequestHeaders.Accept.Add(item:  new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType:  "application/vnd.kafka.v2+json"));
            val_1.DefaultRequestHeaders.Accept.Add(item:  new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType:  "application/vnd.kafka+json"));
            val_1.DefaultRequestHeaders.Accept.Add(item:  new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType:  "application/json"));
            return val_1;
        }
        public void Start()
        {
            this.shouldPause = false;
            if(this.isRunning != false)
            {
                    return;
            }
            
            this.sendTryCount = 0;
            this.sendingFile = 0;
            this.isRunning = true;
            this.isWriting = false;
            System.Threading.Thread val_2 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  this, method:  System.Void Royal.Infrastructure.Services.Analytics.EventWriter::WriterLoop()));
            val_2.Name = "EventWriterThread";
            val_2.IsBackground = true;
            this.writerThread = val_2;
            val_2.Start();
        }
        public void CallClear()
        {
            this.shouldClear = true;
            BestHTTP.Extensions.Extensions.Clear<Royal.Infrastructure.Services.Analytics.EventData>(queue:  this.eventQueue);
            this.shouldCheckTempUser = false;
        }
        public void Stop()
        {
            var val_1;
            this.shouldPause = true;
            this.Pause();
            this.Write();
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  19, log:  "Quit EventWriter thread.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        private void Pause()
        {
            var val_1;
            this.isRunning = false;
            this.writerThread = 0;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  19, log:  "Pause EventWriter thread.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public void CallPause()
        {
            this.shouldPause = true;
        }
        public void AddEventData(Royal.Infrastructure.Services.Analytics.EventData data)
        {
            this.eventQueue.Enqueue(item:  data);
        }
        private void WriterLoop()
        {
            if(this.isRunning == false)
            {
                    return;
            }
            
            do
            {
                this.Write();
                this.Send();
                System.Threading.Thread.Sleep(millisecondsTimeout:  232);
            }
            while(this.isRunning == true);
        
        }
        private void Write()
        {
            var val_4;
            if(this.isWriting == true)
            {
                    return;
            }
            
            this.isWriting = true;
            if(this.shouldClear != false)
            {
                    val_4 = null;
                val_4 = null;
                if(val_2.Length >= 1)
            {
                    var val_5 = 0;
                do
            {
                System.IO.FileInfo val_4 = new System.IO.DirectoryInfo(path:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath).GetFiles()[val_5];
                val_5 = val_5 + 1;
            }
            while(val_5 < val_2.Length);
            
            }
            
                this.shouldClear = false;
            }
            
            if(this.BuildString() != false)
            {
                    this.WriteToFile(shouldMoveFile:  this.shouldPause);
            }
            
            this.isWriting = false;
        }
        private bool BuildString()
        {
            var val_3;
            if((this.eventQueue.TryDequeue(result: out  0)) != false)
            {
                    val_1.ToString(builder:  this.eventBuilder);
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        private void WriteToFile(bool shouldMoveFile)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            System.Text.StringBuilder val_14;
            object val_16;
            var val_18;
            val_10 = shouldMoveFile;
            System.IO.StreamWriter val_1 = System.IO.File.AppendText(path:  this.path1);
            val_11 = val_10;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_12 = ",";
            var val_2 = (val_1 == 0) ? "{\"records\":[" : (val_12);
            if(this.eventBuilder == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_10 != true) && (val_1 < 5120))
            {
                    val_11 = 0;
            }
            else
            {
                    if((System.String.IsNullOrEmpty(value:  this.killEvent)) != true)
            {
                    this.killEvent = 0;
            }
            
                val_13 = "]}";
                val_11 = 1;
            }
            
            val_14 = this.eventBuilder;
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_12 = 0;
            System.Text.StringBuilder val_4 = val_14.Clear();
            var val_9 = 0;
            if(mem[1152921504640323584] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    System.IO.StreamWriter val_5 = 1152921504640286720 + ((mem[1152921504640323592]) << 4);
            }
            
            val_1.Dispose();
            if(val_12 != 0)
            {
                goto label_14;
            }
            
            if(val_11 != 0)
            {
                goto label_15;
            }
            
            return;
            label_14:
            val_14 = X22;
            val_13 = 0;
            throw val_14;
            label_43:
            val_16 = val_14;
            if(val_13 != 1)
            {
                goto label_34;
            }
            
            if((null & 1) == 0)
            {
                goto label_35;
            }
            
            val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  19, log:  "EventWriter.WriteFile: "("EventWriter.WriteFile: ") + val_16, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(val_10 == false)
            {
                    return;
            }
            
            label_15:
            this.MoveFile(path:  this.path1, isOnException:  false);
            return;
            label_35:
            mem[8] = val_16;
            goto label_43;
            label_34:
        }
        private void MoveFile(string path, bool isOnException = False)
        {
            var val_6;
            string val_7;
            var val_8;
            var val_9;
            if(isOnException != false)
            {
                    val_6 = null;
                val_6 = null;
                val_7 = System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath, path2:  "skipped.royal.events");
                val_8 = null;
            }
            else
            {
                    val_7 = this.path1;
                val_8 = null;
            }
            
            System.DateTime val_2 = System.DateTime.Now;
            System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  19, log:  "EventWriter.Move: "("EventWriter.Move: ") + path, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            System.IO.File.Move(sourceFileName:  path, destFileName:  val_7 + val_2.dateData);
        }
        private void DeleteFile(string path)
        {
            var val_2;
            this.sendTryCount = 0;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  19, log:  "EventWriter.Delete: "("EventWriter.Delete: ") + this.sendingFile, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            System.IO.File.Delete(path:  path);
        }
        private void Send()
        {
            var val_11;
            System.Func<TSource, TKey> val_12;
            var val_13;
            System.Collections.Generic.IEnumerable<TSource> val_14;
            var val_15;
            System.Func<System.String, System.String> val_17;
            int val_20;
            if(this.sendingFile != null)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = 0;
            val_14 = System.IO.Directory.GetFiles(path:  Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath);
            val_13 = 41186;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<IsTemp>k__BackingField) == false)
            {
                goto label_6;
            }
            
            label_9:
            if(this.shouldPause == false)
            {
                    return;
            }
            
            this.Pause();
            return;
            label_6:
            if(val_14 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1.Length == 0)
            {
                goto label_9;
            }
            
            val_15 = null;
            val_15 = null;
            val_17 = EventWriter.<>c.<>9__33_0;
            if(val_17 == null)
            {
                    System.Func<System.String, System.String> val_2 = null;
                val_17 = val_2;
                val_2 = new System.Func<System.String, System.String>(object:  EventWriter.<>c.__il2cppRuntimeField_static_fields, method:  System.String EventWriter.<>c::<Send>b__33_0(string name));
                EventWriter.<>c.<>9__33_0 = val_17;
            }
            
            val_12 = val_17;
            System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  val_14, keySelector:  val_2);
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_14 = 0;
            if(mem[1152921504767746048] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    System.Linq.IOrderedEnumerable<TSource> val_4 = 1152921504767709184 + ((mem[1152921504767746056]) << 4);
            }
            
            val_14 = val_3.GetEnumerator();
            label_33:
            var val_15 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_6 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            if(val_14.MoveNext() == false)
            {
                goto label_25;
            }
            
            var val_16 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_16 = val_16 + 1;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_8 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            T val_9 = val_14.Current;
            System.IO.FileInfo val_10 = null;
            val_12 = val_9;
            val_10 = new System.IO.FileInfo(fileName:  val_12);
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((System.String.op_Equality(a:  val_10, b:  "royal.events")) == true)
            {
                goto label_33;
            }
            
            val_13 = val_10;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_10.Contains(value:  "royal.events")) == false)
            {
                goto label_33;
            }
            
            this.sendingFile = val_10;
            val_20 = this.sendTryCount + 1;
            this.sendTryCount = val_20;
            if(val_20 < 4)
            {
                goto label_44;
            }
            
            if(this.shouldPause == false)
            {
                goto label_35;
            }
            
            this.Pause();
            label_44:
            this.UploadFile(filePath:  val_9);
            label_25:
            if(val_14 == null)
            {
                goto label_61;
            }
            
            label_60:
            var val_17 = 0;
            if(mem[1152921504684732416] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    System.Collections.Generic.IEnumerator<T> val_13 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
            }
            
            val_14.Dispose();
            label_61:
            if(0 == 0)
            {
                    return;
            }
            
            throw 0;
            label_35:
            if((public System.Void System.IDisposable::Dispose()) <= 99)
            {
                goto label_42;
            }
            
            if((public System.Void System.IDisposable::Dispose()) == 100)
            {
                goto label_44;
            }
            
            this.sendTryCount = 0;
            goto label_44;
            label_42:
            this.sendingFile = 0;
            if(val_14 != null)
            {
                goto label_60;
            }
            
            goto label_61;
        }
        private void UploadFile(string filePath)
        {
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder val_1 = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
        }
        private static EventWriter()
        {
            var val_4;
            Royal.Infrastructure.Services.Analytics.EventWriter.DateFormat = new System.UriBuilder(uri:  "http://prod-analytics.royal.drmgms.com/topics/event").Uri;
            val_4 = null;
            val_4 = null;
            Royal.Infrastructure.Services.Analytics.EventWriter.DirectoryPath = System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "Events");
        }
    
    }

}
