using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SwitchItem.View
{
    public interface ISwitchableDelegate : IItemViewDelegate
    {
        // Methods
        public abstract bool GetState(); // 0
        public abstract void SetState(bool state); // 0
        public abstract void CollectCompleted(); // 0
        public abstract bool HasCurrentCellAboveItem(); // 0
        public abstract bool HasNextCellAboveItem(); // 0
    
    }

}
