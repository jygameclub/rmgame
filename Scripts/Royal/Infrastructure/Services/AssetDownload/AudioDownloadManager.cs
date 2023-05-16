using UnityEngine;

namespace Royal.Infrastructure.Services.AssetDownload
{
    public class AudioDownloadManager : IContextBehaviour, IContextUnit
    {
        // Fields
        private readonly string musicsDirectory;
        private const string AudioDownloadUrl = "http://cdn.royal.drmgms.com/prod/audio";
        private readonly System.Collections.Generic.Queue<string> musicsToDownload;
        private Royal.Infrastructure.Services.AssetDownload.FileDownloader fileDownloader;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 24;
        }
        public void Bind()
        {
            if((System.IO.Directory.Exists(path:  this.musicsDirectory)) != true)
            {
                    System.IO.DirectoryInfo val_2 = System.IO.Directory.CreateDirectory(path:  this.musicsDirectory);
            }
            
            this.DownloadMusics();
            System.Action val_4 = static_value_02DC1B30;
            val_4 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.Services.AssetDownload.AudioDownloadManager::DownloadMusics());
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).add_OnApplicationResume(value:  val_4);
        }
        private void DownloadMusics()
        {
            var val_5;
            if(this.fileDownloader != null)
            {
                    if((this.fileDownloader.<IsDownloading>k__BackingField) == true)
            {
                    return;
            }
            
            }
            
            val_5 = null;
            val_5 = null;
            var val_5 = Royal.Scenes.Start.Context.Units.Audio.AudioManager.MaxSameTypeSoundsPlayedParallel + 24;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            int val_2 = Royal.Scenes.Start.Context.Units.Audio.AudioManager.MaxSameTypeSoundsPlayedParallel + 32;
            do
            {
                if((System.Linq.Enumerable.Contains<System.String>(source:  this.GetDownloadedMusicFileNames(), value:  1152921504619413504)) != true)
            {
                    if((this.musicsToDownload.Contains(item:  1152921504619413504)) != true)
            {
                    this.musicsToDownload.Enqueue(item:  1152921504619413504);
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < ((Royal.Scenes.Start.Context.Units.Audio.AudioManager.MaxSameTypeSoundsPlayedParallel + 24) << ));
        
        }
        public void ManualUpdate()
        {
            int val_1 = UnityEngine.Time.frameCount;
            if(0 != 0)
            {
                    return;
            }
            
            if(this.fileDownloader != null)
            {
                    if((this.fileDownloader.<IsDownloading>k__BackingField) == true)
            {
                    return;
            }
            
            }
            
            if((this.fileDownloader.<IsDownloading>k__BackingField) < true)
            {
                    return;
            }
            
            this.DownloadMusic(musicToDownload:  this.musicsToDownload.Dequeue());
        }
        private void DownloadMusic(string musicToDownload)
        {
            Royal.Infrastructure.Services.AssetDownload.FileDownloader val_5;
            var val_6;
            System.Action<System.Boolean> val_8;
            if(UnityEngine.Application.internetReachability == 0)
            {
                    return;
            }
            
            val_5 = this.fileDownloader;
            if(val_5 == null)
            {
                    Royal.Infrastructure.Services.AssetDownload.FileDownloader val_2 = null;
                val_5 = val_2;
                val_2 = new Royal.Infrastructure.Services.AssetDownload.FileDownloader();
                this.fileDownloader = val_5;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = AudioDownloadManager.<>c.<>9__9_0;
            if(val_8 == null)
            {
                    System.Action<System.Boolean> val_4 = null;
                val_8 = val_4;
                val_4 = new System.Action<System.Boolean>(object:  AudioDownloadManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void AudioDownloadManager.<>c::<DownloadMusic>b__9_0(bool downloaded));
                AudioDownloadManager.<>c.<>9__9_0 = val_8;
            }
            
            val_2.Download(fileName:  musicToDownload, url:  "http://cdn.royal.drmgms.com/prod/audio/musics/"("http://cdn.royal.drmgms.com/prod/audio/musics/") + musicToDownload, saveDirectory:  this.musicsDirectory, onSaveComplete:  val_4);
        }
        public string[] GetDownloadedMusicFileNames()
        {
            var val_5;
            System.Func<System.IO.FileInfo, System.String> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = AudioDownloadManager.<>c.<>9__10_0;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.IO.FileInfo, System.String>(source:  new System.IO.DirectoryInfo(path:  this.musicsDirectory).GetFiles(), selector:  System.Func<System.IO.FileInfo, System.String> val_3 = null));
            }
            
            val_7 = val_3;
            val_3 = new System.Func<System.IO.FileInfo, System.String>(object:  AudioDownloadManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String AudioDownloadManager.<>c::<GetDownloadedMusicFileNames>b__10_0(System.IO.FileInfo t));
            AudioDownloadManager.<>c.<>9__10_0 = val_7;
            return System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.IO.FileInfo, System.String>(source:  new System.IO.DirectoryInfo(path:  this.musicsDirectory).GetFiles(), selector:  val_3));
        }
        private static string[] GetMusicFileNamesToDownload()
        {
            null = null;
            return (System.String[])Royal.Scenes.Start.Context.Units.Audio.AudioManager.MaxSameTypeSoundsPlayedParallel;
        }
        public UnityEngine.AudioClip LoadMusicFromFile(string musicName, UnityEngine.AudioType audioType = 13)
        {
            string val_13;
            UnityEngine.Object val_14;
            var val_15;
            val_13 = musicName;
            string val_1 = System.IO.Path.Combine(path1:  this.musicsDirectory, path2:  val_13);
            val_14 = 0;
            if((System.IO.File.Exists(path:  val_1)) == false)
            {
                    return (UnityEngine.AudioClip)val_14;
            }
            
            UnityEngine.WWW val_4 = new UnityEngine.WWW(url:  "file://"("file://") + val_1);
            val_15 = 0;
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            label_6:
            if(val_4.isDone == true)
            {
                goto label_5;
            }
            
            float val_7 = UnityEngine.Time.time;
            val_7 = val_7 - UnityEngine.Time.time;
            if(val_7 < 0)
            {
                goto label_6;
            }
            
            label_5:
            if(val_4.isDone != false)
            {
                    val_14 = val_4.GetAudioClip(threeD:  true, stream:  true, audioType:  audioType);
                if(val_14 != 0)
            {
                    return (UnityEngine.AudioClip)val_14;
            }
            
                object[] val_11 = new object[1];
                if(val_11 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_13 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
                if(val_11.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_11[0] = val_13;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  22, log:  "Can\'t load music {0} with www.", values:  val_11);
                System.IO.File.Delete(path:  val_1);
                val_14 = 0;
                return (UnityEngine.AudioClip)val_14;
            }
            
            val_14 = 0;
            return (UnityEngine.AudioClip)val_14;
        }
        public AudioDownloadManager()
        {
            this.musicsDirectory = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  "Audio/Musics");
            this.musicsToDownload = new System.Collections.Generic.Queue<System.String>();
        }
    
    }

}
