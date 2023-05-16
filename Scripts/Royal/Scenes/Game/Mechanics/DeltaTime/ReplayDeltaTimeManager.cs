using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.DeltaTime
{
    public class ReplayDeltaTimeManager : DeltaTimeManager
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.Replay.ReplayManager replayManager;
        
        // Properties
        public override float DeltaTime { get; }
        
        // Methods
        public override float get_DeltaTime()
        {
            if(this.replayManager != null)
            {
                    return this.replayManager.GetDeltaTime();
            }
            
            throw new NullReferenceException();
        }
        public ReplayDeltaTimeManager(Royal.Scenes.Game.Levels.Units.Replay.ReplayManager manager)
        {
            this.replayManager = manager;
        }
    
    }

}
