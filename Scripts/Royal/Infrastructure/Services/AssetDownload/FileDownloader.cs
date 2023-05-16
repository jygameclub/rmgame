using UnityEngine;

namespace Royal.Infrastructure.Services.AssetDownload
{
    public class FileDownloader
    {
        // Fields
        private const string TempPrefix = "temp_";
        private BestHTTP.HTTPRequest httpRequest;
        private System.Action<bool> onComplete;
        private bool <IsDownloading>k__BackingField;
        private bool <IsSuccess>k__BackingField;
        
        // Properties
        public bool IsDownloading { get; set; }
        public bool IsSuccess { get; set; }
        
        // Methods
        public bool get_IsDownloading()
        {
            return (bool)this.<IsDownloading>k__BackingField;
        }
        private void set_IsDownloading(bool value)
        {
            this.<IsDownloading>k__BackingField = value;
        }
        public bool get_IsSuccess()
        {
            return (bool)this.<IsSuccess>k__BackingField;
        }
        private void set_IsSuccess(bool value)
        {
            this.<IsSuccess>k__BackingField = value;
        }
        public void Abort()
        {
            if(this.httpRequest == null)
            {
                    return;
            }
            
            this.httpRequest.Abort();
        }
        public void Download(string fileName, string url, string saveDirectory, System.Action<bool> onSaveComplete)
        {
            string val_15;
            BestHTTP.HTTPRequest val_16;
            string val_17;
            var val_18;
            var val_19;
            .<>4__this = this;
            .fileName = fileName;
            .url = url;
            .saveDirectory = saveDirectory;
            object[] val_2 = new object[1];
            val_15 = (FileDownloader.<>c__DisplayClass12_0)[1152921528676519312].fileName;
            val_2[0] = val_15;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Download file started: {0}", values:  val_2);
            this.onComplete = onSaveComplete;
            this.<IsDownloading>k__BackingField = true;
            this.<IsSuccess>k__BackingField = false;
            FileDownloader.<>c__DisplayClass12_1 val_3 = null;
            val_17 = 0;
            val_3 = new FileDownloader.<>c__DisplayClass12_1();
            if(val_3 == null)
            {
                    throw new NullReferenceException();
            }
            
            .CS$<>8__locals1 = new FileDownloader.<>c__DisplayClass12_0();
            val_15 = (FileDownloader.<>c__DisplayClass12_0)[1152921528676519312].url;
            System.UriBuilder val_4 = null;
            val_17 = val_15;
            val_4 = new System.UriBuilder(uri:  val_17);
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17 = 0;
            if(((FileDownloader.<>c__DisplayClass12_1)[1152921528676531616].CS$<>8__locals1) == null)
            {
                    throw new NullReferenceException();
            }
            
            .filePath = System.IO.Path.Combine(path1:  (FileDownloader.<>c__DisplayClass12_1)[1152921528676531616].CS$<>8__locals1.saveDirectory, path2:  "temp_" + (FileDownloader.<>c__DisplayClass12_1)[1152921528676531616].CS$<>8__locals1.fileName((FileDownloader.<>c__DisplayClass12_1)[1152921528676531616].CS$<>8__locals1.fileName));
            BestHTTP.HTTPRequest val_9 = null;
            val_15 = val_9;
            val_17 = val_4.Uri;
            val_9 = new BestHTTP.HTTPRequest(uri:  val_17, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  val_3, method:  System.Void FileDownloader.<>c__DisplayClass12_1::<Download>b__0(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response)));
            this.httpRequest = val_15;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            BestHTTP.OnStreamingDataDelegate val_10 = new BestHTTP.OnStreamingDataDelegate(object:  val_3, method:  System.Boolean FileDownloader.<>c__DisplayClass12_1::<Download>b__1(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response, byte[] dataFragment, int dataFragmentLength));
            val_17 = val_10;
            System.Delegate val_11 = System.Delegate.Combine(a:  (BestHTTP.HTTPRequest)[1152921528676572576].OnStreamingData, b:  val_10);
            if(val_11 != null)
            {
                    val_17 = null;
                if(null != val_17)
            {
                goto label_35;
            }
            
            }
            
            .OnStreamingData = val_11;
            System.TimeSpan val_12 = System.TimeSpan.FromMinutes(value:  5);
            if(this.httpRequest == null)
            {
                    throw new NullReferenceException();
            }
            
            this.httpRequest = val_12._ticks;
            if(this.httpRequest == null)
            {
                    throw new NullReferenceException();
            }
            
            this.httpRequest = 1;
            val_16 = this.httpRequest;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_17 = 1;
            val_16.DisableCache = true;
            val_16 = this.httpRequest;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            BestHTTP.HTTPRequest val_13 = val_16.Send();
            return;
            label_35:
            val_18 = val_3;
            if(val_17 == 1)
            {
                    if((null & 1) != 0)
            {
                    val_19 = 2;
                object[] val_14 = new object[2];
                val_14[0] = (FileDownloader.<>c__DisplayClass12_0)[1152921528676519312].fileName;
                val_14[1] = mem[(FileDownloader.<>c__DisplayClass12_1)[1152921528676531616]..ctor()];
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  22, log:  "Download file failed: {0}, exception: {1}", values:  val_14);
                this.DownloadCompleted(success:  false);
                return;
            }
            
                mem[8] = ???;
                val_18 = 8;
            }
        
        }
        private static void MoveTempFile(string filePath)
        {
            if((System.IO.File.Exists(path:  filePath)) == false)
            {
                    return;
            }
            
            System.IO.File.Move(sourceFileName:  filePath, destFileName:  filePath.Replace(oldValue:  "temp_", newValue:  System.String.alignConst));
        }
        public static void RemoveDownloadedFile(string filePath)
        {
            if((System.IO.File.Exists(path:  filePath)) == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  filePath);
            object[] val_3 = new object[1];
            val_3[0] = filePath;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Remove File: {0}", values:  val_3);
        }
        public void DontDownload()
        {
            this.onComplete = 0;
            this.<IsDownloading>k__BackingField = true;
            this.<IsSuccess>k__BackingField = true;
        }
        private void StartDownload(System.Action<bool> onSaveComplete)
        {
            this.<IsDownloading>k__BackingField = true;
            this.<IsSuccess>k__BackingField = false;
            this.onComplete = onSaveComplete;
        }
        private void DownloadCompleted(bool success)
        {
            success = success;
            this.<IsSuccess>k__BackingField = success;
            this.<IsDownloading>k__BackingField = false;
            this.onComplete.Invoke(obj:  success);
        }
        private static string GetStreamingAssetsDir()
        {
            return System.IO.Path.Combine(path1:  UnityEngine.Application.streamingAssetsPath, path2:  "android");
        }
        public static void CopyFileFromStreamingAssetsDir(string fileName, string destinationPath)
        {
            Royal.Infrastructure.Services.AssetDownload.FileDownloader.CopyFile(sourcePath:  System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.AssetDownload.FileDownloader.GetStreamingAssetsDir(), path2:  fileName), destinationPath:  destinationPath);
        }
        public static void CopyFile(string sourcePath, string destinationPath)
        {
            System.Type val_13;
            var val_14;
            int val_15;
            System.IO.FileInfo val_1 = null;
            val_13 = val_1;
            val_1 = new System.IO.FileInfo(fileName:  destinationPath);
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((val_13 & 1) != 0)
            {
                    if(val_1.Length >= 1)
            {
                    return;
            }
            
            }
            
            val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            object[] val_4 = new object[2];
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(sourcePath != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_15 = val_4.Length;
            if(val_15 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_4[0] = sourcePath;
            if(destinationPath != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
                val_15 = val_4.Length;
            }
            
            if(val_15 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_4[1] = destinationPath;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  val_13, logTag:  22, log:  "Copy file {0} -> {1}", values:  val_4);
            UnityEngine.WWW val_5 = null;
            val_13 = val_5;
            val_5 = new UnityEngine.WWW(url:  sourcePath);
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            do
            {
            
            }
            while(val_5.isDone == false);
            
            if(val_5.error == null)
            {
                    System.IO.File.WriteAllBytes(path:  destinationPath, bytes:  val_5.bytes);
                val_5.Dispose();
                return;
            }
            
            val_14 = new System.IO.FileNotFoundException(message:  val_1.error);
            throw val_14;
        }
        public FileDownloader()
        {
        
        }
    
    }

}
