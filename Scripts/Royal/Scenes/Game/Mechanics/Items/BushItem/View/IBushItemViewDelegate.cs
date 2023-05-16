using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem.View
{
    public interface IBushItemViewDelegate : IItemViewDelegate
    {
        // Methods
        public abstract void CreateGrasses(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point); // 0
        public abstract int GetLayerCount(); // 0
    
    }

}
