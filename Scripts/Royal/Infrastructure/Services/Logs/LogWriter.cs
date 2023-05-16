using UnityEngine;

namespace Royal.Infrastructure.Services.Logs
{
    public class LogWriter
    {
        // Fields
        private const int MaxFileSize = 1048576;
        private const int BufferLineCount = 100;
        private const int InitialBufferSize = 100;
        private const string WriterThreadName = "LogWriterThread";
        private readonly object lockObject;
        private static readonly string DirectoryPath;
        private readonly string path1;
        private readonly string path2;
        private readonly string zipPath;
        private System.Threading.Thread writerThread;
        private readonly System.Text.StringBuilder logBuilder;
        private bool isRunning;
        private bool saveCall;
        private bool shouldCompress;
        private bool shouldPause;
        public bool fileCompressed;
        private System.Collections.Generic.List<Royal.Infrastructure.Services.Logs.LogLine> currentLogList;
        private System.Collections.Generic.List<Royal.Infrastructure.Services.Logs.LogLine> bufferLogList;
        
        // Methods
        public LogWriter()
        {
            var val_10;
            var val_11;
            var val_12;
            this.lockObject = new System.Object();
            val_10 = null;
            val_10 = null;
            this.path1 = System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.Logs.LogWriter.DirectoryPath, path2:  "royal.log");
            this.path2 = System.IO.Path.Combine(path1:  Royal.Infrastructure.Services.Logs.LogWriter.DirectoryPath, path2:  "royal_old.log");
            val_11 = null;
            val_11 = null;
            this.zipPath = System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "Logs.zip");
            this.currentLogList = new System.Collections.Generic.List<Royal.Infrastructure.Services.Logs.LogLine>(capacity:  100);
            this.bufferLogList = new System.Collections.Generic.List<Royal.Infrastructure.Services.Logs.LogLine>(capacity:  100);
            this.logBuilder = new System.Text.StringBuilder();
            if((System.IO.Directory.Exists(path:  Royal.Infrastructure.Services.Logs.LogWriter.DirectoryPath)) != true)
            {
                    val_12 = null;
                val_12 = null;
                System.IO.DirectoryInfo val_9 = System.IO.Directory.CreateDirectory(path:  Royal.Infrastructure.Services.Logs.LogWriter.DirectoryPath);
            }
            
            this.Start();
        }
        public void Start()
        {
            this.shouldPause = false;
            if(this.isRunning != false)
            {
                    return;
            }
            
            this.isRunning = true;
            System.Threading.Thread val_2 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  this, method:  System.Void Royal.Infrastructure.Services.Logs.LogWriter::WriterLoop()));
            val_2.Name = "LogWriterThread";
            val_2.IsBackground = true;
            this.writerThread = val_2;
            val_2.Start();
        }
        public void Stop()
        {
            this.shouldPause = true;
            this.Pause();
            this.BufferWrite();
            UnityEngine.Debug.Log(message:  "Quit LogWriter thread.");
        }
        public void CallSave()
        {
            this.saveCall = true;
        }
        public void CallPause()
        {
            this.saveCall = true;
            this.shouldPause = true;
        }
        private void Pause()
        {
            this.isRunning = false;
            this.writerThread = 0;
            UnityEngine.Debug.Log(message:  "Pause LogWriter thread.");
        }
        public void CallSaveAndCompress()
        {
            this.saveCall = true;
            this.shouldCompress = true;
            this.fileCompressed = false;
        }
        public void AddLine(Royal.Infrastructure.Services.Logs.LogLine line)
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.lockObject, lockTaken: ref  val_1);
            this.currentLogList.Add(item:  new Royal.Infrastructure.Services.Logs.LogLine() {dateTime = new System.DateTime() {dateData = line.dateTime.dateData}, logLevel = line.logLevel, logTag = line.logLevel, classType = line.classType, message = line.classType, Params = line.Params});
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.lockObject);
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
        
        }
        private void WriterLoop()
        {
            var val_1;
            if(this.isRunning == false)
            {
                    return;
            }
            
            label_9:
            if(this.currentLogList <= 99)
            {
                    if(this.saveCall == false)
            {
                goto label_5;
            }
            
            }
            
            this.BufferWrite();
            this.saveCall = false;
            if(this.shouldCompress != false)
            {
                    val_1 = null;
                val_1 = null;
                Royal.Infrastructure.Utils.Compressing.Compressor.Compress(inputPath:  Royal.Infrastructure.Services.Logs.LogWriter.DirectoryPath, outputPath:  this.zipPath);
                this.shouldCompress = false;
                this.fileCompressed = true;
            }
            
            label_5:
            if(this.shouldPause != false)
            {
                    this.Pause();
            }
            
            System.Threading.Thread.Sleep(millisecondsTimeout:  232);
            if(this.isRunning == true)
            {
                goto label_9;
            }
        
        }
        private void BufferWrite()
        {
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this.lockObject, lockTaken: ref  val_1);
            this.SwapBuffer();
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this.lockObject);
            }
            
            if(0 != 0)
            {
                    throw 0;
            }
            
            this.BuildString();
            this.WriteToFile();
        }
        private void WriteProcess()
        {
            this.BuildString();
            this.WriteToFile();
        }
        private void BuildString()
        {
            var val_1;
            bool val_1 = true;
            var val_2 = 0;
            val_1 = 32;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                val_1 = val_1 & 4294967295;
                if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + val_1;
                val_2 = val_2 + 1;
                val_1 = val_1 + 56;
            }
            while(this.bufferLogList != null);
            
            throw new NullReferenceException();
        }
        private void WriteToFile()
        {
            var val_8;
            System.IO.StreamWriter val_1 = System.IO.File.AppendText(path:  this.path1);
            if(this.logBuilder == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = 0;
            System.Text.StringBuilder val_3 = this.logBuilder.Clear();
            var val_8 = 0;
            if(mem[1152921504640323584] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    System.IO.StreamWriter val_4 = 1152921504640286720 + ((mem[1152921504640323592]) << 4);
            }
            
            val_1.Dispose();
            if(val_8 != 0)
            {
                    throw X21;
            }
            
            if(((val_1 >= 1048576) ? 1 : 0) == 0)
            {
                    return;
            }
            
            this.MoveFile();
        }
        private void MoveFile()
        {
            if((System.IO.File.Exists(path:  this.path2)) != false)
            {
                    0 = 0;
                System.IO.File.Delete(path:  this.path2);
            }
            
            System.IO.File.Move(sourceFileName:  this.path1, destFileName:  this.path2);
        }
        private void SwapBuffer()
        {
            this.currentLogList = this.bufferLogList;
            this.bufferLogList = this.currentLogList;
            this.bufferLogList.Clear();
        }
        private static LogWriter()
        {
            null = null;
            Royal.Infrastructure.Services.Logs.LogWriter.DirectoryPath = System.IO.Path.Combine(path1:  Royal.Infrastructure.Utils.Native.FileHelper.ApplicationDataPath, path2:  "Logs");
        }
    
    }

}
