using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Combo
{
    public interface ICombo
    {
        // Properties
        public abstract Royal.Scenes.Game.Levels.Units.Combo.ComboType ComboType { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Levels.Units.Combo.ComboType get_ComboType(); // 0
    
    }

}
