using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Fall
{
    public interface IFallComponent
    {
        // Properties
        public abstract float CurrentSpeed { get; set; }
        public abstract float StateChangedTime { get; set; }
        
        // Methods
        public abstract bool IsItemSteady(); // 0
        public abstract float get_CurrentSpeed(); // 0
        public abstract void set_CurrentSpeed(float value); // 0
        public abstract float get_StateChangedTime(); // 0
        public abstract void set_StateChangedTime(float value); // 0
        public abstract void ManualUpdate(); // 0
        public abstract void SetFillingCell(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell); // 0
    
    }

}
