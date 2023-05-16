using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Replay
{
    public class WaitForGameplaySeconds : CustomYieldInstruction
    {
        // Fields
        private readonly float targetSeconds;
        private float passedSeconds;
        
        // Properties
        public override bool keepWaiting { get; }
        
        // Methods
        public override bool get_keepWaiting()
        {
            float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_1 = this.passedSeconds + val_1;
            this.passedSeconds = val_1;
            return (bool)(val_1 < this.targetSeconds) ? 1 : 0;
        }
        public WaitForGameplaySeconds(float targetSeconds = 1)
        {
            this.targetSeconds = targetSeconds;
        }
    
    }

}
