using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FrogItem.View
{
    public interface IFrogItemViewDelegate : IBirdItem, IItemViewDelegate
    {
        // Methods
        public abstract UnityEngine.Vector3 GetGoalPosition(); // 0
        public abstract void CollectAnimationCompleted(); // 0
        public abstract void TryCollect(); // 0
        public abstract bool HasCurrentCellAboveItem(); // 0
        public abstract bool HasNextCellAboveItem(); // 0
    
    }

}
