using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Grid.Sorter
{
    public static class ItemSorter
    {
        // Fields
        public static readonly Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.TopLeftHorizontalSorter TopLeftHorizontalSorter;
        public static readonly Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomLeftHorizontalSorter BottomLeftHorizontalSorter;
        public static readonly Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomRightHorizontalSorter BottomRightHorizontalSorter;
        
        // Methods
        private static ItemSorter()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.ItemSorter.TopLeftHorizontalSorter = new Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.TopLeftHorizontalSorter();
            Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.ItemSorter.BottomLeftHorizontalSorter = new Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomLeftHorizontalSorter();
            Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.ItemSorter.BottomRightHorizontalSorter = new Royal.Scenes.Game.Mechanics.Board.Grid.Sorter.BottomRightHorizontalSorter();
        }
    
    }

}
