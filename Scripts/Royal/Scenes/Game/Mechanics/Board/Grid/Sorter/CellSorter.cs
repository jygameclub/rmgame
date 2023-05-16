using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Sorter
{
    public static class CellSorter
    {
        // Fields
        public static readonly Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.TopLeftHorizontalCellSorter TopLeftHorizontalCellSorter;
        public static readonly Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomLeftHorizontalCellSorter BottomLeftHorizontalCellSorter;
        public static readonly Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomRightHorizontalCellSorter BottomRightHorizontalSorter;
        
        // Methods
        private static CellSorter()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.CellSorter.TopLeftHorizontalCellSorter = new Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.TopLeftHorizontalCellSorter();
            Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.CellSorter.BottomLeftHorizontalCellSorter = new Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomLeftHorizontalCellSorter();
            Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.CellSorter.BottomRightHorizontalSorter = new Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomRightHorizontalCellSorter();
        }
    
    }

}
