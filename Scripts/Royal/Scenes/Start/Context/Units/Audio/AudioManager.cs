using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Audio
{
    public class AudioManager : IContextUnit
    {
        // Fields
        private const string HomeMusic1 = "home/Home_1";
        private const string GameplayMusic1 = "gameplay/Gameplay_1";
        private const string KingDrillMusic = "KingDrillMusic";
        public static readonly string[] RemoteGameMusics;
        private const int MaxSameTypeSoundsPlayedParallel = 5;
        private readonly System.Collections.Generic.Dictionary<long, Royal.Infrastructure.Utils.Pooling.PoolableAudioSource> keyAudioSourceDictionary;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, int> audioCounterDictionary;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>> audioSourcesDictionary;
        private Royal.Infrastructure.Utils.Pooling.GameObjectPool audioSourcePool;
        private string currentMusic;
        private string lastGameMusic;
        private bool sfxMute;
        private UnityEngine.AudioSource musicSource;
        private UnityEngine.AudioSource soundSource;
        private bool playingGameMusic;
        private System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, float> audioStartTimeDictionary;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private Royal.Infrastructure.Services.AssetDownload.AudioDownloadManager audioDownloadManager;
        private int nextStoppableKeyId;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 16;
        }
        public void Bind()
        {
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.audioDownloadManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.AssetDownload.AudioDownloadManager>(id:  24);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Audio.AudioManager::PlayGameMusic()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Audio.AudioManager::PlayHomeMusic()));
            Royal.Scenes.Start.Context.Units.Audio.AudioAssets.LoadGameAssets();
            Royal.Infrastructure.Utils.Pooling.GameObjectPool val_8 = new Royal.Infrastructure.Utils.Pooling.GameObjectPool(poolIdType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.audioSourcePool = val_8;
            val_8.CreatePool<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(go:  UnityEngine.Resources.Load<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(path:  "PoolableAudioSource"), amount:  7);
            this.audioStartTimeDictionary = new System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Single>(capacity:  10);
            this.musicSource = Royal.Scenes.Start.Context.ApplicationContext.controller.musicSource;
            UnityEngine.Object.DontDestroyOnLoad(target:  gameObject);
            this.soundSource = Royal.Scenes.Start.Context.ApplicationContext.controller.soundSource;
            UnityEngine.Object.DontDestroyOnLoad(target:  gameObject);
            bool val_13 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Sfx", defaultValue:  true);
            bool val_18 = ~val_13;
            val_18 = val_18 & 1;
            this.sfxMute = val_18;
            this.musicSource.mute = (~val_13.IsMusicActive()) & 1;
            this.soundSource.mute = (~this.musicSource.IsSfxActive()) & 1;
        }
        private void PlayHomeMusic()
        {
            UnityEngine.AudioSource val_3 = this.musicSource;
            this.playingGameMusic = false;
            val_3.Stop();
            val_3 = 5387;
            this.currentMusic = "home/Home_1";
            if(this.IsMusicActive() == false)
            {
                    return;
            }
            
            this.musicSource.clip = this.LoadMusic();
            this.musicSource.Play();
        }
        public void ResumeHomeMusic()
        {
            bool val_1 = this.musicSource.isPlaying;
            if(val_1 == true)
            {
                    return;
            }
            
            if(val_1.IsMusicActive() == false)
            {
                    return;
            }
            
            if(this.musicSource.clip == 0)
            {
                    this.currentMusic = "home/Home_1";
                this.musicSource.clip = this.LoadMusic();
            }
            
            this.musicSource.Play();
        }
        public void StopHomeMusic()
        {
            if(this.musicSource != null)
            {
                    this.musicSource.Stop();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void SelectHomeMusic()
        {
            this.currentMusic = "home/Home_1";
        }
        public void PlayGameMusic()
        {
            this.SelectGameMusic();
            if(this.IsMusicActive() == false)
            {
                    return;
            }
            
            this.musicSource.Pause();
            this.musicSource.clip = this.LoadMusic();
            this.playingGameMusic = true;
            this.musicSource.Play();
        }
        public void ResumeGameMusic()
        {
            if(this.playingGameMusic == true)
            {
                    return;
            }
            
            if(this.IsMusicActive() == false)
            {
                    return;
            }
            
            if(this.musicSource.clip == 0)
            {
                    this.SelectGameMusic();
                this.musicSource.clip = this.LoadMusic();
            }
            
            this.playingGameMusic = true;
            this.musicSource.Play();
        }
        public void StopGameMusic()
        {
            if((Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Sfx", defaultValue:  true)) == false)
            {
                    return;
            }
            
            this.playingGameMusic = false;
            this.musicSource.Stop();
        }
        private void SelectGameMusic()
        {
            string val_8 = "gameplay/Gameplay_1";
            this.currentMusic = ;
            this.lastGameMusic = ;
        }
        private UnityEngine.AudioClip LoadMusic()
        {
            var val_12;
            var val_13;
            UnityEngine.Object val_14;
            string val_15;
            val_12 = this;
            if((System.String.op_Equality(a:  this.currentMusic, b:  "KingDrillMusic")) != false)
            {
                    Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
                val_12 = ???;
            }
            else
            {
                    val_13 = null;
                val_13 = null;
                if((System.Linq.Enumerable.Contains<System.String>(source:  Royal.Scenes.Start.Context.Units.Audio.AudioManager.MaxSameTypeSoundsPlayedParallel, value:  val_12 + 48)) != false)
            {
                    val_14 = val_12 + 112.LoadMusicFromFile(musicName:  val_12 + 48, audioType:  14);
                if(val_14 != 0)
            {
                    return (UnityEngine.AudioClip)val_14;
            }
            
                val_15 = "gameplay/Gameplay_1";
                val_12 = val_15;
            }
            else
            {
                    val_15 = mem[val_12 + 48];
                val_15 = val_12 + 48;
            }
            
                val_14 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  val_15);
                return (UnityEngine.AudioClip)val_14;
            }
        
        }
        public void MuteMusic()
        {
            this.musicSource.mute = true;
            this.musicSource.Pause();
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetBool(key:  "Music", value:  false);
        }
        public void UnmuteMusic()
        {
            if(this.musicSource.clip == 0)
            {
                    this.musicSource.clip = this.LoadMusic();
            }
            
            this.musicSource.mute = false;
            this.musicSource.time = 0f;
            this.musicSource.Play();
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetBool(key:  "Music", value:  true);
        }
        public bool IsMusicActive()
        {
            return Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Music", defaultValue:  true);
        }
        public void MuteSfx()
        {
            this.sfxMute = true;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetBool(key:  "Sfx", value:  false);
            this.soundSource.mute = this.sfxMute;
            System.Collections.Generic.IEnumerable<TSource> val_6 = 0;
            do
            {
                if(val_6 >= this.audioSourcesDictionary.Count)
            {
                    return;
            }
            
                System.Collections.Generic.KeyValuePair<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>> val_3 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>>>(source:  this.audioSourcesDictionary, index:  0);
                if(64 >= 1)
            {
                    var val_5 = 0;
                do
            {
                Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_4 = System.Linq.Enumerable.ElementAt<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(source:  val_6, index:  0);
                val_4.audioSource.mute = this.sfxMute;
                val_5 = val_5 + 1;
            }
            while(val_5 < 64);
            
            }
            
                val_6 = val_6 + 1;
            }
            while(this.audioSourcesDictionary != null);
            
            throw new NullReferenceException();
        }
        public void UnmuteSfx()
        {
            this.sfxMute = false;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.SetBool(key:  "Sfx", value:  true);
            this.soundSource.mute = this.sfxMute;
            System.Collections.Generic.IEnumerable<TSource> val_6 = 0;
            do
            {
                if(val_6 >= this.audioSourcesDictionary.Count)
            {
                    return;
            }
            
                System.Collections.Generic.KeyValuePair<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>> val_3 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>>>(source:  this.audioSourcesDictionary, index:  0);
                if(64 >= 1)
            {
                    var val_5 = 0;
                do
            {
                Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_4 = System.Linq.Enumerable.ElementAt<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(source:  val_6, index:  0);
                val_4.audioSource.mute = this.sfxMute;
                val_5 = val_5 + 1;
            }
            while(val_5 < 64);
            
            }
            
                val_6 = val_6 + 1;
            }
            while(this.audioSourcesDictionary != null);
            
            throw new NullReferenceException();
        }
        public bool IsSfxActive()
        {
            return Royal.Infrastructure.Services.Storage.Tables.AppKeyValue.GetBool(key:  "Sfx", defaultValue:  true);
        }
        public void PlaySound(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type, float offset = 0.04)
        {
            UnityEngine.Object val_6;
            if((this.CanPlayAudio(type:  type, offset:  offset)) == false)
            {
                    return;
            }
            
            this.audioStartTimeDictionary.set_Item(key:  type, value:  UnityEngine.Time.time);
            val_6 = Royal.Scenes.Start.Context.Units.Audio.AudioAssets.GetAudioClip(type:  type);
            if(val_6 == 0)
            {
                    object[] val_5 = new object[1];
                val_5[0] = type;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  17, log:  "Clip is null: {0}", values:  val_5);
            }
            
            this.soundSource.PlayOneShot(clip:  val_6);
        }
        public void PlayAudioClip(UnityEngine.AudioClip audioClip)
        {
            if(this.sfxMute == true)
            {
                    return;
            }
            
            if(audioClip == 0)
            {
                    return;
            }
            
            this.soundSource.PlayOneShot(clip:  audioClip);
        }
        public void PlaySoundInLoop(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Int32> val_13;
            var val_14;
            var val_15;
            if(this.sfxMute == true)
            {
                    return;
            }
            
            val_13 = this.audioCounterDictionary;
            if((this.audioCounterDictionary.ContainsKey(key:  type)) != false)
            {
                    val_14 = 1152921518936596960;
                val_15 = val_13.Item[type] + 1;
            }
            else
            {
                    val_14 = 1152921518936596960;
                val_15 = 1;
            }
            
            val_13.set_Item(key:  type, value:  1);
            if(this.audioCounterDictionary.Item[type] > 5)
            {
                    return;
            }
            
            this.audioStartTimeDictionary.set_Item(key:  type, value:  UnityEngine.Time.time);
            UnityEngine.AudioClip val_5 = Royal.Scenes.Start.Context.Units.Audio.AudioAssets.GetAudioClip(type:  type);
            if(val_5 == 0)
            {
                    object[] val_7 = new object[1];
                val_13 = val_7;
                val_13[0] = type;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  17, log:  "Clip is null: {0}", values:  val_7);
                return;
            }
            
            if((this.audioSourcesDictionary.ContainsKey(key:  type)) != true)
            {
                    this.audioSourcesDictionary.set_Item(key:  type, value:  new System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>());
            }
            
            this.audioSourcesDictionary.Item[type].Enqueue(item:  this.audioSourcePool.Spawn<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(poolId:  0, activate:  true));
            val_8.audioSource.loop = true;
            val_8.audioSource.clip = val_5;
            val_8.audioSource.Play();
        }
        public long PlayStoppableSound(Royal.Scenes.Start.Context.Units.Audio.AudioClipType audioClipType, bool loop = False, float volume = 1)
        {
            loop = loop;
            return this.PlayStoppableSound(audioClip:  Royal.Scenes.Start.Context.Units.Audio.AudioAssets.GetAudioClip(type:  audioClipType), loop:  loop, volume:  volume);
        }
        public long PlayStoppableSound(UnityEngine.AudioClip audioClip, bool loop = False, float volume = 1)
        {
            bool val_8;
            int val_9;
            val_8 = loop;
            if(this.sfxMute != false)
            {
                    val_9 = 0;
                return (long)val_9;
            }
            
            val_9 = 0;
            if(audioClip == 0)
            {
                    return (long)val_9;
            }
            
            val_9 = this.nextStoppableKeyId;
            this.nextStoppableKeyId = val_9 + 1;
            this.keyAudioSourceDictionary.set_Item(key:  val_9, value:  this.audioSourcePool.Spawn<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(poolId:  0, activate:  true));
            val_2.audioSource.loop = val_8;
            val_2.audioSource.volume = (volume == 0f) ? 1f : volume;
            val_2.audioSource.clip = audioClip;
            val_2.audioSource.Play();
            if(val_8 == true)
            {
                    return (long)val_9;
            }
            
            val_8 = this.ReleasePoolableAudioSourceWhenPlayIsOver(key:  val_9);
            UnityEngine.Coroutine val_7 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  val_8);
            return (long)val_9;
        }
        public void StopSound(long key)
        {
            Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_1 = 0;
            if((this.keyAudioSourceDictionary.TryGetValue(key:  key, value: out  val_1)) == false)
            {
                    return;
            }
            
            if(val_1 != 0)
            {
                    10360992.Stop();
                this.audioSourcePool.Recycle<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(go:  val_1);
            }
            
            bool val_4 = this.keyAudioSourceDictionary.Remove(key:  key);
        }
        private System.Collections.IEnumerator ReleasePoolableAudioSourceWhenPlayIsOver(long key)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .key = key;
            return (System.Collections.IEnumerator)new AudioManager.<ReleasePoolableAudioSourceWhenPlayIsOver>d__43();
        }
        public void StopSoundInLoop(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            int val_8;
            if((this.audioCounterDictionary.ContainsKey(key:  type)) == false)
            {
                    return;
            }
            
            int val_2 = this.audioCounterDictionary.Item[type];
            val_8 = val_2 - 1;
            if()
            {
                    return;
            }
            
            if(val_2 <= 5)
            {
                    Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_4 = this.audioSourcesDictionary.Item[type].Dequeue();
                if(val_4 != 0)
            {
                    this.audioSourcePool.Recycle<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>(go:  val_4);
            }
            
            }
            
            this.audioCounterDictionary.set_Item(key:  type, value:  val_8);
            if(val_8 != 0)
            {
                    return;
            }
            
            bool val_6 = this.audioCounterDictionary.Remove(key:  type);
        }
        public float GetClipLastPlayedTime(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            return (float)((this.audioStartTimeDictionary.TryGetValue(key:  type, value: out  float val_1 = 4.782203E+13f)) != true) ? 0 : 0f;
        }
        public bool CanPlayAudio(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type, float offset)
        {
            var val_4;
            if(this.sfxMute == false)
            {
                goto label_1;
            }
            
            label_6:
            val_4 = 0;
            return (bool)val_4;
            label_1:
            if((this.audioStartTimeDictionary.ContainsKey(key:  type)) == false)
            {
                goto label_4;
            }
            
            float val_3 = this.audioStartTimeDictionary.Item[type];
            val_3 = val_3 + offset;
            if(UnityEngine.Time.time < 0)
            {
                goto label_6;
            }
            
            label_4:
            val_4 = 1;
            return (bool)val_4;
        }
        public AudioManager()
        {
            this.keyAudioSourceDictionary = new System.Collections.Generic.Dictionary<System.Int64, Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>();
            this.audioCounterDictionary = new System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Int32>();
            this.audioSourcesDictionary = new System.Collections.Generic.Dictionary<Royal.Scenes.Start.Context.Units.Audio.AudioClipType, System.Collections.Generic.Queue<Royal.Infrastructure.Utils.Pooling.PoolableAudioSource>>();
            this.nextStoppableKeyId = 1;
        }
        private static AudioManager()
        {
            int val_2;
            string[] val_1 = new string[3];
            val_2 = val_1.Length;
            val_1[0] = "Gameplay_2.ogg";
            val_2 = val_1.Length;
            val_1[1] = "Gameplay_3.ogg";
            val_2 = val_1.Length;
            val_1[2] = "Gameplay_4.ogg";
            Royal.Scenes.Start.Context.Units.Audio.AudioManager.MaxSameTypeSoundsPlayedParallel = val_1;
        }
    
    }

}
