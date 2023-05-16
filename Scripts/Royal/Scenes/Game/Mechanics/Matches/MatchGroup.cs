using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Matches
{
    public struct MatchGroup
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<int, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel> topItems;
        private static readonly Royal.Scenes.Game.Mechanics.Matches.MatchGroup <Null>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Matches.PatternType <PatternType>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType <MatchType>k__BackingField;
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 cell14;
        private byte <Id>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel specialItemCreationCell;
        private bool explosionCalculated;
        private bool canExplode;
        public bool exists;
        
        // Properties
        public static Royal.Scenes.Game.Mechanics.Matches.MatchGroup Null { get; }
        public Royal.Scenes.Game.Mechanics.Matches.PatternType PatternType { get; set; }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType MatchType { get; set; }
        public int CellCount { get; }
        public bool IsFull { get; }
        public byte Id { get; set; }
        
        // Methods
        public static Royal.Scenes.Game.Mechanics.Matches.MatchGroup get_Null()
        {
            var val_1;
            Royal.Scenes.Game.Mechanics.Matches.MatchGroup val_0;
            val_1 = null;
            val_1 = null;
            return val_0;
        }
        public Royal.Scenes.Game.Mechanics.Matches.PatternType get_PatternType()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.PatternType)this;
        }
        private void set_PatternType(Royal.Scenes.Game.Mechanics.Matches.PatternType value)
        {
            mem[1152921519992452464] = value;
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType get_MatchType()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)this;
        }
        private void set_MatchType(Royal.Scenes.Game.Mechanics.Matches.MatchType value)
        {
            mem[1152921519992684660] = value;
        }
        public int get_CellCount()
        {
            return (int)this;
        }
        public bool get_IsFull()
        {
        
        }
        public byte get_Id()
        {
            return (byte)this.explosionCalculated;
        }
        private void set_Id(byte value)
        {
            this.explosionCalculated = value;
        }
        private MatchGroup(bool alive)
        {
        
        }
        public MatchGroup(byte id, Royal.Scenes.Game.Mechanics.Matches.PatternType patternType, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            this.explosionCalculated = id;
            mem[1152921519993369090] = 1;
            mem[1152921519993368944] = patternType;
            mem[1152921519993368948] = matchType;
            mem[1152921519993369088] = 0;
            mem[1152921519993369080] = 0;
        }
        public void Init(byte id, Royal.Scenes.Game.Mechanics.Matches.PatternType patternType, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, Royal.Scenes.Game.Mechanics.Matches.Cell14 cell14)
        {
            this.explosionCalculated = id;
            mem[1152921519993558832] = patternType;
            mem[1152921519993558836] = matchType;
            mem[1152921519993558976] = 0;
            mem[1152921519993558968] = 0;
        }
        public void Reset()
        {
            mem[1152921519993740528] = 0;
            this.explosionCalculated = false;
            mem[1152921519993740674] = 0;
            mem[1152921519993740672] = 0;
            mem[1152921519993740664] = 0;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetCell(int i)
        {
        
        }
        public void AddCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
        
        }
        public bool ContainsCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
        
        }
        public void SetSpecialItemCreationCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            mem[1152921519994209144] = cell;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GetSpecialItemCell()
        {
            if(this != 0)
            {
                    return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)1152921519994325104;
            }
            
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)1152921519994325104;
        }
        private void SelectItemCreationCell()
        {
        
        }
        private void ShuffleCells()
        {
        
        }
        public bool ContainsItem(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel item)
        {
            if(W8 == 0)
            {
                    return false;
            }
            
            if(item != null)
            {
                    return (bool)(this.explosionCalculated == W9) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public bool CanAutoExplode()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchGroup val_2;
            if(W8 != 0)
            {
                    return (bool)(val_2 != 0) ? 1 : 0;
            }
            
            val_2 = 0;
            mem[1152921519994781441] = val_2;
            mem[1152921519994781440] = 1;
            return (bool)(val_2 != 0) ? 1 : 0;
        }
        private bool AllCellsReadyForExplode()
        {
        
        }
        public void FreezeCells()
        {
        
        }
        public void UnFreezeCells()
        {
        
        }
        public override string ToString()
        {
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            return (string)1152921519995229296;
        }
        private static MatchGroup()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchGroup.topItems = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>(capacity:  14);
        }
    
    }

}
