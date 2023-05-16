using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public interface IItemViewDelegate
    {
        // Properties
        public abstract int Id { get; }
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public abstract Royal.Scenes.Game.Mechanics.Matches.MatchType MatchType { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; }
        
        // Methods
        public abstract int get_Id(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Matches.MatchType get_MatchType(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell(); // 0
        public abstract bool IsUnderHoney(); // 0
        public abstract bool IsUnderCurtain(); // 0
        public abstract bool IsUnderChain(); // 0
        public abstract bool IsUnderOneLayeredChain(); // 0
    
    }

}
