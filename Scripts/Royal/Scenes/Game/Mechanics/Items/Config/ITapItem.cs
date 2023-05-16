using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public interface ITapItem
    {
        // Properties
        public abstract Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        public abstract bool IsTapDisabled { get; set; }
        
        // Methods
        public abstract Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType(); // 0
        public abstract bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
        public abstract bool get_IsTapDisabled(); // 0
        public abstract void set_IsTapDisabled(bool value); // 0
    
    }

}
