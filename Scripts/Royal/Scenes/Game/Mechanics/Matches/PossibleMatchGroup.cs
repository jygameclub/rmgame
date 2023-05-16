using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Matches
{
    public class PossibleMatchGroup
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Matches.PatternType patternType;
        public Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        public Royal.Scenes.Game.Mechanics.Matches.TempMatch tempMatch1;
        public Royal.Scenes.Game.Mechanics.Matches.TempMatch tempMatch2;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel firstIntersect;
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel secondIntersect;
        
        // Methods
        public PossibleMatchGroup()
        {
        
        }
    
    }

}
