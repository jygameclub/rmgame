using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Explode
{
    public struct ExplodeData
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point;
        public readonly Royal.Scenes.Game.Mechanics.Explode.Trigger trigger;
        public readonly int id;
        public readonly Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        
        // Methods
        public ExplodeData(Royal.Scenes.Game.Mechanics.Explode.Trigger trigger, int id, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point, Royal.Scenes.Game.Mechanics.Matches.MatchType type)
        {
            this.matchType = point.x;
            mem[1152921523887711528] = trigger;
            mem[1152921523887711532] = id;
            mem[1152921523887711536] = type;
        }
        public bool ShouldExplodeAll()
        {
            return (bool)(W8 == 24) ? 1 : 0;
        }
        public override string ToString()
        {
            var val_1 = X1;
            val_1 = this.matchType;
            val_1 = this.matchType + 4;
            val_1 = this.matchType + 8;
            val_1 = 16;
            val_1 = this.matchType + 24;
            val_1 = this.matchType + 28;
            val_1 = this.matchType + 32;
            val_1 = this.matchType + 40;
            return (string)this.matchType + 40;
        }
    
    }

}
