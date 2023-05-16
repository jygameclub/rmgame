using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Goal.Conditions
{
    public class GrassGoalCondition : IGoalCondition
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        
        // Methods
        public GrassGoalCondition()
        {
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public bool IsSatisfied()
        {
            bool val_1 = this.gameStateManager.HasOperation(animationId:  10);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
    
    }

}
