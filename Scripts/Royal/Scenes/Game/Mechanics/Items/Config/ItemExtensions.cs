using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public static class ItemExtensions
    {
        // Fields
        public const int PropellerDefaultItemScore = 1000;
        
        // Methods
        public static Royal.Scenes.Game.Mechanics.Matches.MatchType ToMatchType(Royal.Scenes.Game.Utils.LevelParser.TiledId itemType)
        {
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)((itemType - 1) < 6) ? itemType : 0;
        }
        public static Royal.Scenes.Game.Utils.LevelParser.TiledId ToTiledId(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)((matchType - 1) < 6) ? matchType : 0;
        }
        public static Royal.Scenes.Game.Mechanics.Goal.GoalType ToGoalType(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType)
        {
            if(itemType > 4)
            {
                    return 0;
            }
            
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)36616656 + (itemType) << 2;
        }
        public static Royal.Scenes.Game.Mechanics.Goal.GoalType ToGoalType(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            if((itemType - 2) > 34)
            {
                    return 0;
            }
            
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)36616688 + ((itemType - 2)) << 2;
        }
        public static Royal.Scenes.Game.Mechanics.Goal.GoalType ToGoalType(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            if((matchType - 1) > 5)
            {
                    return 0;
            }
            
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)36616832 + ((matchType - 1)) << 2;
        }
        public static bool IsSpecialItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            return (bool)((itemType - 2) < 4) ? 1 : 0;
        }
        public static bool IsFillingObstacle(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            if(itemType <= 31)
            {
                    var val_3 = 1;
                val_3 = val_3 << itemType;
                if((val_3 & (-2001632640)) == 0)
            {
                    return true;
            }
            
            }
            
            itemType = ((itemType == 34) ? 1 : 0) | ((itemType == 36) ? 1 : 0);
            return (bool)itemType;
        }
        public static int ExplodeScore(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            if((itemType - 1) > 35)
            {
                    return 0;
            }
            
            return (int)36616864 + ((itemType - 1)) << 2;
        }
        public static int ExplodeScore(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType)
        {
            if(itemType < 3)
            {
                    return 1000;
            }
            
            return (int)(itemType == 4) ? 1000 : 0;
        }
        public static bool IsObstacle(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            if((itemType - 1) < 5)
            {
                    return false;
            }
            
            if(itemType == 16)
            {
                    return false;
            }
            
            return (bool)(itemType != 31) ? 1 : 0;
        }
        public static bool IsIndestructible(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            var val_3;
            var val_4;
            if(itemType <= 17)
            {
                    val_3 = itemType - 11;
                if(val_3 >= 7)
            {
                    return false;
            }
            
                val_4 = 97;
            }
            else
            {
                    val_3 = itemType - 22;
                if(val_3 >= 14)
            {
                    return false;
            }
            
                val_4 = 8705;
            }
            
            val_3 = 8705 >> val_3;
            itemType = val_3 & 1;
            return (bool)itemType;
        }
        public static int GoalFactor(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            if(goalType <= 19)
            {
                    goalType = (goalType == 15) ? 10 : ((goalType == 19) ? 4 : (0 + 1));
                return (int)goalType;
            }
            
            if(goalType == 21)
            {
                    return 0;
            }
            
            if(goalType == 31)
            {
                    return 8;
            }
            
            if(goalType != 36)
            {
                    return 1;
            }
            
            return 9;
        }
        public static bool ShouldPlayParticleOnCollect(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            var val_3;
            var val_4;
            if(goalType <= 21)
            {
                    val_3 = goalType - 1;
                if(val_3 >= 21)
            {
                    return false;
            }
            
                val_4 = 1179648;
                val_4 = 18;
            }
            else
            {
                    val_3 = goalType - 23;
                if(val_3 >= 18)
            {
                    return false;
            }
            
                val_4 = 196608;
                val_4 = 3;
            }
            
            val_3 = 215073 >> val_3;
            goalType = val_3 & 1;
            return (bool)goalType;
        }
    
    }

}
