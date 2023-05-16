using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View
{
    public interface IRocketItemViewDelegate : IItemViewDelegate
    {
        // Properties
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation Orientation { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation get_Orientation(); // 0
    
    }

}
