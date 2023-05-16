using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Explode
{
    public interface IGoalDependedExplodeTarget
    {
        // Properties
        public abstract Royal.Scenes.Game.Mechanics.Goal.GoalType GoalType { get; }
        
        // Methods
        public abstract Royal.Scenes.Game.Mechanics.Goal.GoalType get_GoalType(); // 0
    
    }

}
