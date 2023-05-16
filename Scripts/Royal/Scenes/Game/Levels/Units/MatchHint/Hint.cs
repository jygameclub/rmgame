using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.MatchHint
{
    public struct Hint
    {
        // Fields
        private static readonly Royal.Scenes.Game.Levels.Units.Combo.ComboType[] ComboTypes;
        public readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel firstCell;
        public readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellModel secondCell;
        public readonly Royal.Scenes.Game.Mechanics.Matches.MatchGroup matchGroup;
        public readonly bool isCombo;
        public int uniqueCode;
        
        // Methods
        public Hint(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel first, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel second, Royal.Scenes.Game.Mechanics.Matches.MatchGroup group)
        {
            this.matchGroup = first;
            mem[1152921524016503992] = second;
            mem[1152921524016504152] = 0;
            mem[1152921524016504156] = 0;
        }
        public Hint(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel first, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel second, bool combo)
        {
            bool val_1 = combo;
        }
        public int GetUniqueHintCode()
        {
        
        }
        public bool HasSingleSpecialItem()
        {
        
        }
        public bool IsComboAboveRocketRocket()
        {
        
        }
        public int GetScore()
        {
            throw 36589791;
        }
        public static int PatternScore(Royal.Scenes.Game.Mechanics.Matches.PatternType type)
        {
            if((type - 1) > 6)
            {
                    return 0;
            }
            
            return (int)36589952 + ((type - 1)) << 2;
        }
        private static int ComboScore(Royal.Scenes.Game.Levels.Units.Combo.ComboType type)
        {
            if((type - 1) > 9)
            {
                    return 0;
            }
            
            return (int)36589904 + ((type - 1)) << 2;
        }
        private static Hint()
        {
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            System.Array val_2 = System.Enum.GetValues(enumType:  val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_2 == null)
            {
                goto label_5;
            }
            
            val_3 = val_2;
            if(X0 == false)
            {
                goto label_6;
            }
            
            label_5:
            Royal.Scenes.Game.Levels.Units.MatchHint.Hint.ComboTypes = null;
            return;
            label_6:
        }
    
    }

}
