using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.MatchHint
{
    public interface IHintable
    {
        // Properties
        public abstract bool IsSelectedAsHint { get; }
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; }
        
        // Methods
        public abstract bool get_IsSelectedAsHint(); // 0
        public abstract Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell(); // 0
        public abstract void StartHintAnimation(bool changeSorting); // 0
        public abstract void StopHintAnimation(); // 0
        public abstract void SetHighlightRatio(float ratio); // 0
        public abstract float GetHighlightRatio(); // 0
        public abstract float GetMaxHighlightRatio(); // 0
    
    }

}
