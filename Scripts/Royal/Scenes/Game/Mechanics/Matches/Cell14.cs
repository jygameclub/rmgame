using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Matches
{
    public struct Cell14
    {
        // Fields
        private static readonly Royal.Scenes.Game.Mechanics.Matches.Cell14 <Null>k__BackingField;
        public const int Capacity = 14;
        private int <Count>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell0;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell1;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell2;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell3;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell4;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell5;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell6;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell7;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell8;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell9;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell10;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell11;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell12;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell13;
        
        // Properties
        public static Royal.Scenes.Game.Mechanics.Matches.Cell14 Null { get; }
        public int Count { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Item { get; set; }
        
        // Methods
        public static Royal.Scenes.Game.Mechanics.Matches.Cell14 get_Null()
        {
            var val_1;
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_0;
            val_1 = null;
            val_1 = null;
            return val_0;
        }
        public int get_Count()
        {
            return (int)this.cell1;
        }
        private void set_Count(int value)
        {
            this.cell1 = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_Item(int i)
        {
        
        }
        public void set_Item(int i, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel value)
        {
        
        }
        public void Add(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.cell1;
            val_1 = val_1 + 1;
            this.cell1 = val_1;
        }
        public void Remove()
        {
            this.cell1 = this.cell1 - 1;
        }
        public void Clear()
        {
        
        }
        public bool Contains(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_1;
            if(this.cell1 < 1)
            {
                goto label_0;
            }
            
            var val_1 = 0;
            label_2:
            if(1152921519991388720 == cell)
            {
                goto label_1;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < this.cell1)
            {
                goto label_2;
            }
            
            label_0:
            val_1 = 0;
            return (bool)val_1;
            label_1:
            val_1 = 1;
            return (bool)val_1;
        }
        public bool IsFull()
        {
            return (bool)(this.cell1 > 13) ? 1 : 0;
        }
        private static Cell14()
        {
        
        }
    
    }

}
