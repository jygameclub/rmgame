using UnityEngine;

namespace Royal.Levels.Config
{
    public struct LevelEpisodeConfig
    {
        // Fields
        public int id;
        public int levelStart;
        public int levelEnd;
        
        // Methods
        public static System.Collections.Generic.Dictionary<int, Royal.Levels.Config.LevelEpisodeConfig> CreateDefaultConfigs()
        {
            System.Collections.Generic.Dictionary<System.Int32, Royal.Levels.Config.LevelEpisodeConfig> val_1 = new System.Collections.Generic.Dictionary<System.Int32, Royal.Levels.Config.LevelEpisodeConfig>();
            val_1.Add(key:  1, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 1, levelStart = 1, levelEnd = 20});
            val_1.Add(key:  2, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 2, levelStart = 21, levelEnd = 40});
            val_1.Add(key:  3, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 3, levelStart = 41, levelEnd = 60});
            val_1.Add(key:  4, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 4, levelStart = 61, levelEnd = 80});
            val_1.Add(key:  5, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 5, levelStart = 81, levelEnd = 100});
            val_1.Add(key:  6, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 6, levelStart = 101, levelEnd = 120});
            val_1.Add(key:  7, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 7, levelStart = 121, levelEnd = 140});
            val_1.Add(key:  8, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 8, levelStart = 141, levelEnd = 160});
            val_1.Add(key:  9, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 9, levelStart = 161, levelEnd = 180});
            val_1.Add(key:  10, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 10, levelStart = 181, levelEnd = 200});
            val_1.Add(key:  11, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 11, levelStart = 201, levelEnd = 230});
            val_1.Add(key:  12, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 12, levelStart = 231, levelEnd = 4});
            val_1.Add(key:  13, value:  new Royal.Levels.Config.LevelEpisodeConfig() {id = 13, levelStart = 261, levelEnd = 44});
            return val_1;
        }
    
    }

}
