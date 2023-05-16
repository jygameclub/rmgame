using UnityEngine;

namespace Royal.Scenes.Home.Episodes.Scripts
{
    public class EpisodeAtlasAssets : ScriptableObject
    {
        // Fields
        public UnityEngine.Sprite[] emptySprites;
        public UnityEngine.Sprite[] fullSprites;
        
        // Methods
        public UnityEngine.Sprite GetEmptySpriteForEpisode(int episodeNo)
        {
            var val_2 = (episodeNo < 0) ? (episodeNo + 3) : episodeNo;
            val_2 = val_2 & 4294967292;
            val_2 = episodeNo - val_2;
            val_2 = val_2 - 1;
            return (UnityEngine.Sprite)this.emptySprites[(val_2 < 3) ? (val_2) : ((episodeNo == 0) ? 3 : 0)];
        }
        public UnityEngine.Sprite GetFullSpriteForEpisode(int episodeNo)
        {
            var val_2 = (episodeNo < 0) ? (episodeNo + 3) : episodeNo;
            val_2 = val_2 & 4294967292;
            val_2 = episodeNo - val_2;
            val_2 = val_2 - 1;
            return (UnityEngine.Sprite)this.fullSprites[(val_2 < 3) ? (val_2) : ((episodeNo == 0) ? 3 : 0)];
        }
        private int GetIndexForEpisode(int episodeNo)
        {
            var val_5;
            var val_2 = (episodeNo < 0) ? (episodeNo + 3) : episodeNo;
            val_2 = val_2 & 4294967292;
            val_2 = episodeNo - val_2;
            val_5 = val_2 - 1;
            if(val_5 < 3)
            {
                    return (int)(val_2 == 0) ? 3 : 0;
            }
            
            return (int)(val_2 == 0) ? 3 : 0;
        }
        public EpisodeAtlasAssets()
        {
        
        }
    
    }

}
