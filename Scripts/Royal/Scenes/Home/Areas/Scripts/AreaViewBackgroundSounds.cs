using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaViewBackgroundSounds
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private readonly Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private readonly System.Collections.Generic.List<long> soundKeys;
        private readonly System.Collections.Generic.List<long> replaySoundKeys;
        public Royal.Scenes.Home.Areas.Scripts.AreaTaskView[] taskViews;
        
        // Methods
        public AreaViewBackgroundSounds()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.soundKeys = new System.Collections.Generic.List<System.Int64>();
            this.replaySoundKeys = new System.Collections.Generic.List<System.Int64>();
        }
        public bool CanPlayBackgroundSound()
        {
            null = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) != 0)
            {
                    if(this.soundKeys == null)
            {
                goto label_10;
            }
            
            }
            
            return (bool)0 & 1;
            label_10:
            bool val_4 = this.audioManager.IsMusicActive() ^ 1;
            return (bool)0 & 1;
        }
        public void PlayIdleSounds()
        {
            if(this.taskViews == null)
            {
                    return;
            }
            
            var val_8 = 0;
            do
            {
                if((0 & 0) != 0)
            {
                    return;
            }
            
                if(val_8 >= 0)
            {
                    return;
            }
            
                Royal.Scenes.Home.Areas.Scripts.AreaTaskView val_7 = this.taskViews[val_8];
                if((val_7 != 0) && (val_7.gameObject != 0))
            {
                    if(val_7.gameObject.activeSelf != false)
            {
                    val_7.PlayIdleSound();
            }
            
            }
            
                val_8 = val_8 + 1;
                var val_6 = (this.taskViews == null) ? this.taskViews : this.taskViews;
            }
            while(this.taskViews != null);
        
        }
        public void StopIdleSounds()
        {
            System.Collections.Generic.List<System.Int64> val_1;
            bool val_1 = true;
            val_1 = this.soundKeys;
            var val_2 = 0;
            label_5:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            val_1 = val_1 & 4294967295;
            if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            this.audioManager.StopSound(key:  ((true & 4294967295) + 0) + 32);
            val_1 = this.soundKeys;
            val_2 = val_2 + 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1.Clear();
        }
        public void StopReplaySounds()
        {
            System.Collections.Generic.List<System.Int64> val_1;
            bool val_1 = true;
            val_1 = this.replaySoundKeys;
            var val_2 = 0;
            label_5:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            val_1 = val_1 & 4294967295;
            if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            this.audioManager.StopSound(key:  ((true & 4294967295) + 0) + 32);
            val_1 = this.replaySoundKeys;
            val_2 = val_2 + 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1.Clear();
        }
        public void PlayRandomStoppableSound(UnityEngine.AudioClip[] clips, bool loop = False, float volume = 1)
        {
            this.PlayStoppableSound(clip:  this.randomManager.RandomFromArray<UnityEngine.AudioClip>(array:  clips), loop:  loop, volume:  volume);
        }
        public void PlayStoppableSound(UnityEngine.AudioClip clip, bool loop = False, float volume = 1)
        {
            loop = loop;
            this.soundKeys.Add(item:  this.audioManager.PlayStoppableSound(audioClip:  clip, loop:  loop, volume:  volume));
        }
        public void PlayStoppableSound(string clipName, bool loop = False, float volume = 1)
        {
            if((System.String.IsNullOrEmpty(value:  clipName)) != false)
            {
                    return;
            }
            
            this.PlayStoppableSound(clip:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/"("Audio/") + clipName), loop:  loop, volume:  volume);
        }
        public void PlayOneShotSound(string clipName)
        {
            if((System.String.IsNullOrEmpty(value:  clipName)) != false)
            {
                    return;
            }
            
            this.audioManager.PlayAudioClip(audioClip:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/"("Audio/") + clipName));
        }
        public void PlayOneShotSound(UnityEngine.AudioClip clip)
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlayAudioClip(audioClip:  clip);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlayReplaySound(string clipName)
        {
            if((System.String.IsNullOrEmpty(value:  clipName)) != false)
            {
                    return;
            }
            
            this.replaySoundKeys.Add(item:  this.audioManager.PlayStoppableSound(audioClip:  UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Audio/"("Audio/") + clipName), loop:  false, volume:  1f));
        }
        public void PlayReplaySound(UnityEngine.AudioClip clip)
        {
            this.replaySoundKeys.Add(item:  this.audioManager.PlayStoppableSound(audioClip:  clip, loop:  false, volume:  1f));
        }
    
    }

}
