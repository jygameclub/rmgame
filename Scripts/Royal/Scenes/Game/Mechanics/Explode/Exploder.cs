using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Explode
{
    public static class Exploder
    {
        // Fields
        private static int Id;
        
        // Methods
        public static void Reset()
        {
            Royal.Scenes.Game.Mechanics.Explode.Exploder.Id = 0;
        }
        public static Royal.Scenes.Game.Mechanics.Explode.ExplodeData Next(Royal.Scenes.Game.Mechanics.Explode.Trigger trigger)
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_0;
            int val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Id + 1;
            Royal.Scenes.Game.Mechanics.Explode.Exploder.Id = val_1;
            val_2 = null;
            val_2 = null;
            val_0.trigger = trigger;
            mem[1152921523888220092] = val_1;
            val_0.id = 0;
            val_0.point.x = Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default;
            return val_0;
        }
        public static Royal.Scenes.Game.Mechanics.Explode.ExplodeData Next(Royal.Scenes.Game.Mechanics.Explode.Trigger trigger, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_0;
            int val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Id;
            val_1 = val_1 + 1;
            Royal.Scenes.Game.Mechanics.Explode.Exploder.Id = val_1;
            val_0.point.x = point.x;
            val_0.point.y = point.y;
            val_0.trigger = trigger;
            mem[1152921523888364668] = val_1;
            val_0.id = 0;
            return val_0;
        }
        public static Royal.Scenes.Game.Mechanics.Explode.ExplodeData Next(Royal.Scenes.Game.Mechanics.Explode.Trigger trigger, Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            var val_2;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_0;
            int val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Id + 1;
            Royal.Scenes.Game.Mechanics.Explode.Exploder.Id = val_1;
            val_2 = null;
            val_2 = null;
            val_0.trigger = trigger;
            mem[1152921523888517436] = val_1;
            val_0.id = matchType;
            val_0.point.x = Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint.Default;
            return val_0;
        }
    
    }

}
