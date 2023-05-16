using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LogItem.View
{
    public interface IIceCrusherItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract void FinalExplode(); // 0
        public abstract void UnfreezeLayer(int layer); // 0
    
    }

}
