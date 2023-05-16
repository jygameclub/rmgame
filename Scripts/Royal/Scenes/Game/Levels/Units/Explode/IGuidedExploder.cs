using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Explode
{
    public interface IGuidedExploder
    {
        // Properties
        public abstract Royal.Scenes.Game.Mechanics.Explode.ExplodeData TargetExplodeData { get; }
        public abstract Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget TargetItem { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Explode.ExplodeData get_TargetExplodeData(); // 0
        public abstract Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget get_TargetItem(); // 0
        public abstract void TargetFound(Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget targetItem); // 0
    
    }

}
