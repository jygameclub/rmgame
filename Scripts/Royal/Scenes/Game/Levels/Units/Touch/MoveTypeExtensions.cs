using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Touch
{
    internal static class MoveTypeExtensions
    {
        // Methods
        public static bool IsLightBulbMove(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            Royal.Scenes.Game.Levels.Units.Touch.MoveType val_1 = moveType - 1;
            if(val_1 > 13)
            {
                    return false;
            }
            
            val_1 = 16017 >> val_1;
            moveType = val_1 & 1;
            return (bool)moveType;
        }
        public static bool IsFrogMove(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            return (bool)((moveType - 1) < 14) ? 1 : 0;
        }
    
    }

}
