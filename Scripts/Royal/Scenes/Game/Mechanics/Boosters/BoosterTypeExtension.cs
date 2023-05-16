using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Boosters
{
    public static class BoosterTypeExtension
    {
        // Fields
        public const int HighestLevelForBoosterUnlock = 19;
        public const int PrelevelBoosterUnlockLevel = 7;
        
        // Methods
        public static bool IsPrelevel(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            return (bool)((boosterType - 1) < 3) ? 1 : 0;
        }
        public static bool IsInGame(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            return (bool)((boosterType & 4294967292) == 4) ? 1 : 0;
        }
        public static int Price(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            if((boosterType - 1) > 6)
            {
                    return 0;
            }
            
            return (int)36611584 + ((boosterType - 1)) << 2;
        }
        public static int GetUnlockLevel(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            if((boosterType - 4) > 3)
            {
                    return 7;
            }
            
            return (int)36611612 + ((boosterType - 4)) << 2;
        }
        public static bool IsUnlocked(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_3;
            if((boosterType - 4) <= 3)
            {
                    val_3 = mem[36611612 + ((boosterType - 4)) << 2];
                val_3 = 36611612 + ((boosterType - 4)) << 2;
                return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 >= val_3) ? 1 : 0;
            }
            
            val_3 = 7;
            return (bool)(typeof(Royal.Player.Context.Data.Persistent.BasicUserData).__il2cppRuntimeField_14 >= val_3) ? 1 : 0;
        }
        public static int RemainingTime(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            return RemainingTime(type:  boosterType);
        }
        public static int Amount(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            return 3;
        }
        public static int ShopAnimationOrder(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            if(boosterType != 5)
            {
                    return (int)(boosterType == 7) ? 5 : boosterType;
            }
            
            return 7;
        }
        public static string Localize(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            if((boosterType - 1) > 6)
            {
                    return (string)System.String.alignConst;
            }
            
            var val_6 = 36611220 + ((boosterType - 1)) << 2;
            val_6 = val_6 + 36611220;
            goto (36611220 + ((boosterType - 1)) << 2 + 36611220);
        }
    
    }

}
