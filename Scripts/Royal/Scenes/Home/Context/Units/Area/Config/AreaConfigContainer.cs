using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Area.Config
{
    public class AreaConfigContainer
    {
        // Fields
        public const int EpisodeCount = 28;
        private readonly System.Collections.Generic.Dictionary<int, Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig> configs;
        public static readonly Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig[] RowConfigs;
        
        // Methods
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig LoadAreaConfig(int id)
        {
            if((this.configs.TryGetValue(key:  id, value: out  0)) == true)
            {
                    return val_3;
            }
            
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig val_3 = Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer.CreateAreaConfig(id:  id);
            this.configs.Add(key:  id, value:  val_3);
            return val_3;
        }
        public Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig LoadAreaLeagueConfig()
        {
            return this.LoadAreaConfig(id:  0);
        }
        private static Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig CreateAreaConfig(int id)
        {
            return (Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig)UnityEngine.Resources.Load<Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig>(path:  "Area" + id.ToString(format:  "00")(id.ToString(format:  "00")) + "AreaConfig");
        }
        public AreaConfigContainer()
        {
            this.configs = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig>();
        }
        private static AreaConfigContainer()
        {
            Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig[] val_1 = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig[28];
            .areaId = 1;
            .areaName = "Castle";
            val_1[0] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 2;
            .areaName = "ThroneRoom";
            val_1[1] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 3;
            .areaName = "DiningRoom";
            val_1[2] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 4;
            .areaName = "Garden";
            val_1[3] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 5;
            .areaName = "Library";
            val_1[4] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 6;
            .areaName = "Pool";
            val_1[5] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 7;
            .areaName = "Bedroom";
            val_1[6] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 8;
            .areaName = "MusicRoom";
            val_1[7] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 9;
            .areaName = "Dock";
            val_1[8] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 10;
            .areaName = "Kitchen";
            val_1[9] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 11;
            .areaName = "Bathroom";
            val_1[10] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 12;
            .areaName = "Living Room";
            val_1[11] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 13;
            .areaName = "Japanese Garden";
            val_1[12] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 14;
            .areaName = "Clock Tower";
            val_1[13] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 15;
            .areaName = "Museum";
            val_1[14] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 16;
            .areaName = "Observatory";
            val_1[15] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 17;
            .areaName = "Garage";
            val_1[16] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 18;
            .areaName = "Chess Garden";
            val_1[17] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 19;
            .areaName = "Tea Room";
            val_1[18] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 20;
            .areaName = "AquaRoom";
            val_1[19] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 21;
            .areaName = "TailorRoom";
            val_1[20] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 22;
            .areaName = "MonumentGarden";
            .fontSizeMax = 12f;
            .curveScale = 0.95f;
            val_1[21] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 23;
            .areaName = "BarberShop";
            val_1[22] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 24;
            .areaName = "Spa";
            val_1[23] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 25;
            .areaName = "Gym";
            val_1[24] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 26;
            .areaName = "SkatingPark";
            val_1[25] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 27;
            .areaName = "Cafe";
            val_1[26] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            .areaId = 28;
            .areaName = "Beach";
            val_1[27] = new Royal.Scenes.Home.Context.Units.Area.Config.EpisodeRowConfig();
            Royal.Scenes.Home.Context.Units.Area.Config.AreaConfigContainer.RowConfigs = val_1;
        }
    
    }

}
