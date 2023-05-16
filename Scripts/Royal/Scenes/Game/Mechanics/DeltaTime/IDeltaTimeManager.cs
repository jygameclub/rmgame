using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.DeltaTime
{
    public interface IDeltaTimeManager
    {
        // Properties
        public abstract int FrameCount { get; }
        public abstract float DeltaTime { get; }
        public abstract float Time { get; }
        public abstract float TimeScale { get; }
        
        // Methods
        public abstract int get_FrameCount(); // 0
        public abstract float get_DeltaTime(); // 0
        public abstract float get_Time(); // 0
        public abstract float get_TimeScale(); // 0
        public abstract void SetTimeScale(float timeScale); // 0
    
    }

}
