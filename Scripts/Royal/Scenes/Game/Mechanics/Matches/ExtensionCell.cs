using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Matches
{
    public struct ExtensionCell
    {
        // Fields
        private static readonly Royal.Scenes.Game.Mechanics.Matches.ExtensionCell nullCell;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        public int neighborType;
        
        // Properties
        public static Royal.Scenes.Game.Mechanics.Matches.ExtensionCell Null { get; }
        
        // Methods
        public static Royal.Scenes.Game.Mechanics.Matches.ExtensionCell get_Null()
        {
            null = null;
            return new Royal.Scenes.Game.Mechanics.Matches.ExtensionCell() {cell = Royal.Scenes.Game.Mechanics.Matches.ExtensionCell.nullCell, neighborType = Royal.Scenes.Game.Mechanics.Matches.ExtensionCell.nullCell.__il2cppRuntimeField_8>>0&0xFFFFFFFF};
        }
        public ExtensionCell(bool exists)
        {
            mem[1152921519991853104] = 0;
            mem[1152921519991853112] = 0;
        }
        private static ExtensionCell()
        {
            Royal.Scenes.Game.Mechanics.Matches.ExtensionCell.nullCell = 0;
            Royal.Scenes.Game.Mechanics.Matches.ExtensionCell.nullCell.__il2cppRuntimeField_8 = 0;
        }
    
    }

}
