using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public interface ICellViewDelegate
    {
        // Properties
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint Point { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Neighbors { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellType Type { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType FillType { get; }
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CurrentItem { get; }
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemModel NextItem { get; }
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemModel TargetItem { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator StaticMediator { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint get_Point(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors get_Neighbors(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellType get_Type(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType get_FillType(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_CurrentItem(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_NextItem(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_TargetItem(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator get_StaticMediator(); // 0
        public abstract bool IsFallFrozen(); // 0
        public abstract bool IsFillingCell(); // 0
        public abstract void UnFreezeFall(); // 0
        public abstract bool IsTouchEnabled(); // 0
    
    }

}
