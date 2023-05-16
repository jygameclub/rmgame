using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class ItemModelFactory
    {
        // Methods
        public static Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CreateItem(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
            var val_56 = 1152921524089629088;
            if(268435460 > 36)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_57 = 36598372;
            val_57 = mem[1110340212] + val_57;
            goto (mem[1110340212] + 36598372);
        }
        private static bool IsPotionBL(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = tiledId - 53;
            if(val_1 > 22)
            {
                    return (bool)((tiledId | 2) == 79) ? 1 : 0;
            }
            
            val_1 = 1 << val_1;
            if((val_1 & 5505025) != 0)
            {
                    return (bool)((tiledId | 2) == 79) ? 1 : 0;
            }
            
            return true;
        }
        private static bool IsLightBulbBL(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = tiledId - 126;
            if(val_1 > 10)
            {
                    return (bool)((tiledId - 137) < 2) ? 1 : 0;
            }
            
            val_1 = 1 << val_1;
            if((val_1 & 1027) != 0)
            {
                    return (bool)((tiledId - 137) < 2) ? 1 : 0;
            }
            
            return true;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel CreateStaticItem(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings settings)
        {
            var val_7 = mem[1152921524090351204];
            val_7 = val_7 + 1;
            if(val_7 > 5)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_8 = 36598348 + ((mem[1152921524090351204] + 1)) << 2;
            val_8 = val_8 + 36598348;
            goto (36598348 + ((mem[1152921524090351204] + 1)) << 2 + 36598348);
        }
        public ItemModelFactory()
        {
        
        }
    
    }

}
