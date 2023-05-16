using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Sfx
{
    public class GameSfxAssets : ScriptableObject
    {
        // Fields
        public UnityEngine.AudioClip[] fallHits;
        public UnityEngine.AudioClip[] matchExplodes;
        public UnityEngine.AudioClip matchSwipe;
        public UnityEngine.AudioClip impossibleMove;
        public UnityEngine.AudioClip wrongMove;
        public Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary assetsLibrary;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        
        // Methods
        public UnityEngine.AudioClip GetClip(Royal.Scenes.Start.Context.Units.Audio.AudioClipType sfxType)
        {
            var val_700 = 0;
            if((sfxType - 7) > 258)
            {
                    return (UnityEngine.AudioClip)UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  null);
            }
            
            var val_700 = 36588572 + ((sfxType - 7)) << 2;
            val_700 = val_700 + 36588572;
            goto (36588572 + ((sfxType - 7)) << 2 + 36588572);
        }
        public Royal.Scenes.Start.Context.Units.Audio.AudioClipType GetRandomSfxTypeForMatchExplode()
        {
            Royal.Scenes.Game.Levels.Units.LevelRandomManager val_6 = this.randomManager;
            if(val_6 == null)
            {
                    Royal.Scenes.Game.Levels.Units.LevelRandomManager val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  val_6 = this.randomManager);
                this.randomManager = val_1;
                System.DateTime val_2 = System.DateTime.Now;
                val_1.SetSeed(seed:  val_2.dateData.Millisecond);
                val_6 = this.randomManager;
            }
            
            int val_4 = val_6.Next(min:  0, max:  6);
            val_4 = (val_4 < 6) ? (val_4 + 179) : 0;
            return (Royal.Scenes.Start.Context.Units.Audio.AudioClipType)val_4;
        }
        public GameSfxAssets()
        {
        
        }
    
    }

}
