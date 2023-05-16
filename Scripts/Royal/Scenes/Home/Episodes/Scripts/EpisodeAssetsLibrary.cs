using UnityEngine;

namespace Royal.Scenes.Home.Episodes.Scripts
{
    public class EpisodeAssetsLibrary
    {
        // Fields
        private static Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary instance;
        private readonly System.Collections.Generic.Dictionary<string, Royal.Scenes.Home.Episodes.Scripts.EpisodeAtlasAssets> assets;
        private readonly System.Text.StringBuilder nameBuilder;
        
        // Properties
        public static Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary Instance { get; }
        
        // Methods
        public static Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary get_Instance()
        {
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary val_2;
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary val_3 = Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary.instance;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary val_1 = null;
            val_2 = val_1;
            val_1 = new Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary();
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary.instance = val_2;
            val_3 = Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary.instance;
            return val_3;
        }
        public void Clear()
        {
            this.assets.Clear();
        }
        public UnityEngine.Sprite GetEmptySpriteForEpisode(int episodeNo)
        {
            string val_3;
            if(episodeNo != 32766)
            {
                    if(episodeNo != 32767)
            {
                    return this.LoadAtlasAsset(episodeNo:  episodeNo).GetEmptySpriteForEpisode(episodeNo:  episodeNo);
            }
            
                val_3 = "royal_league_episode";
                return Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  val_3 = "area_coming_soon"), width:  52, height:  512, format:  4);
            }
            
            return Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  UnityEngine.Resources.Load<UnityEngine.TextAsset>(path:  val_3), width:  52, height:  512, format:  4);
        }
        public UnityEngine.Sprite GetFullSpriteForEpisode(int episodeNo)
        {
            return this.LoadAtlasAsset(episodeNo:  episodeNo).GetFullSpriteForEpisode(episodeNo:  episodeNo);
        }
        private Royal.Scenes.Home.Episodes.Scripts.EpisodeAtlasAssets LoadAtlasAsset(int episodeNo)
        {
            string val_1 = this.GetEpisodeAtlasName(episodeNo:  episodeNo);
            if((this.assets.TryGetValue(key:  val_1, value: out  0)) == true)
            {
                    return val_4;
            }
            
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAtlasAssets val_4 = UnityEngine.Resources.Load<Royal.Scenes.Home.Episodes.Scripts.EpisodeAtlasAssets>(path:  val_1);
            this.assets.set_Item(key:  val_1, value:  val_4);
            return val_4;
        }
        private string GetEpisodeAtlasName(int episodeNo)
        {
            var val_9;
            var val_2 = (episodeNo < 0) ? (episodeNo + 3) : episodeNo;
            System.Text.StringBuilder val_3 = this.nameBuilder.Clear();
            val_2 = episodeNo - (val_2 & 4294967292);
            System.Text.StringBuilder val_5 = this.nameBuilder.Append(value:  "Episodes");
            if(val_2 <= 3)
            {
                    val_9 = mem[36587164 + ((episodeNo - (episodeNo < 0 ? (episodeNo + 3) : episodeNo & 4294967292))) << 2];
                val_9 = 36587164 + ((episodeNo - (episodeNo < 0 ? (episodeNo + 3) : episodeNo & 4294967292))) << 2;
            }
            else
            {
                    val_9 = 0;
            }
            
            do
            {
                System.Text.StringBuilder val_9 = this.nameBuilder.Append(value:  "_" + episodeNo + val_9(episodeNo + val_9));
                val_9 = val_9 + 1;
            }
            while(val_9 < (val_9 + 3));
            
            return (string)this.nameBuilder;
        }
        public EpisodeAssetsLibrary()
        {
            this.assets = new System.Collections.Generic.Dictionary<System.String, Royal.Scenes.Home.Episodes.Scripts.EpisodeAtlasAssets>(capacity:  50);
            this.nameBuilder = new System.Text.StringBuilder();
        }
    
    }

}
