using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Sfx
{
    public class GameSfxManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private int matchExplodeIndex;
        private bool noGameSound;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 22;
        }
        public void Bind()
        {
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void PlayFallHit()
        {
            if(this.noGameSound == true)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 - (this.audioManager.GetClipLastPlayedTime(type:  116));
            if(val_3 <= 0.1f)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - (this.audioManager.GetClipLastPlayedTime(type:  117));
            if(val_4 <= 0.1f)
            {
                    return;
            }
            
            this.audioManager.PlaySound(type:  ((this.randomManager.Next(min:  0, max:  2)) != 0) ? (116 + 1) : 116, offset:  0.04f);
        }
        public void PlayMatchExplode(bool userSwipe = False)
        {
            int val_5;
            if(this.noGameSound != false)
            {
                    return;
            }
            
            if(userSwipe != false)
            {
                    val_5 = 0;
            }
            else
            {
                    int val_1 = this.matchExplodeIndex + 1;
                this.matchExplodeIndex = val_1;
                val_5 = val_1;
            }
            
            this.matchExplodeIndex = UnityEngine.Mathf.Clamp(value:  val_5, min:  0, max:  (UnityEngine.AudioClip[].__il2cppRuntimeField_namespaze - 1)>>0&0xFFFFFFFF);
            this.audioManager.PlaySound(type:  Royal.Scenes.Start.Context.Units.Audio.AudioAssets.<GameSfxAssets>k__BackingField.GetRandomSfxTypeForMatchExplode(), offset:  0.04f);
        }
        public Royal.Scenes.Start.Context.Units.Audio.AudioClipType SelectRandomClip(Royal.Scenes.Start.Context.Units.Audio.AudioClipType from, Royal.Scenes.Start.Context.Units.Audio.AudioClipType to)
        {
            if(this.randomManager != null)
            {
                    to = to + 1;
                return this.randomManager.Next(min:  from, max:  to);
            }
            
            throw new NullReferenceException();
        }
        public bool CanPlay(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type1, Royal.Scenes.Start.Context.Units.Audio.AudioClipType type2, float offset = 0.04)
        {
            Royal.Scenes.Start.Context.Units.Audio.AudioManager val_3 = this.audioManager;
            bool val_2 = val_3.CanPlayAudio(type:  type2, offset:  offset);
            val_3 = (this.audioManager.CanPlayAudio(type:  type1, offset:  offset)) & val_2;
            val_2 = val_3;
            return (bool)val_2;
        }
        public bool CanPlay(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type1, Royal.Scenes.Start.Context.Units.Audio.AudioClipType type2, Royal.Scenes.Start.Context.Units.Audio.AudioClipType type3, float offset = 0.04)
        {
            bool val_3 = this.audioManager.CanPlayAudio(type:  type3, offset:  offset);
            bool val_4 = (this.audioManager.CanPlayAudio(type:  type1, offset:  offset)) & (this.audioManager.CanPlayAudio(type:  type2, offset:  offset));
            val_4 = val_4 & val_3;
            val_3 = val_4;
            return (bool)val_3;
        }
        public void PlaySfx(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type, float offset = 0.04)
        {
            if(this.noGameSound != false)
            {
                    return;
            }
            
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  type, offset:  offset);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlaySfxInLoop(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            if(this.noGameSound != false)
            {
                    return;
            }
            
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySoundInLoop(type:  type);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void StopSoundInLoop(Royal.Scenes.Start.Context.Units.Audio.AudioClipType type)
        {
            if(this.audioManager != null)
            {
                    this.audioManager.StopSoundInLoop(type:  type);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Clear(bool gameExit)
        {
            this.noGameSound = false;
            this.matchExplodeIndex = 0;
        }
        public void StopAllForThisLevel()
        {
            this.noGameSound = true;
            this.audioManager.StopSoundInLoop(type:  220);
            this.audioManager.StopSoundInLoop(type:  157);
            this.audioManager.StopSoundInLoop(type:  217);
        }
        public GameSfxManager()
        {
        
        }
    
    }

}
