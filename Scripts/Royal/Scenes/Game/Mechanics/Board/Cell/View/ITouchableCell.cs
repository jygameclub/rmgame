using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public interface ITouchableCell
    {
        // Properties
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint CellPoint { get; }
        public abstract UnityEngine.Vector2 Position { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint get_CellPoint(); // 0
        public abstract UnityEngine.Vector2 get_Position(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView HighlightMatchItem(bool enable); // 0
        public abstract bool IsTouchEnabled(); // 0
    
    }

}
