using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdItem
{
    public interface IBirdItem : IItemViewDelegate
    {
        // Methods
        public abstract bool IsInSameColumn(int column); // 0
        public abstract bool IsAbove(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point); // 0
    
    }

}
