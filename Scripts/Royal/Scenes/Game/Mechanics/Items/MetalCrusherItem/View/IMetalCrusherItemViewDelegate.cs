using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View
{
    public interface IMetalCrusherItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract void FinalExplode(); // 0
        public abstract void UnfreezeLayer(int layer); // 0
        public abstract bool IsVertical(); // 0
    
    }

}
