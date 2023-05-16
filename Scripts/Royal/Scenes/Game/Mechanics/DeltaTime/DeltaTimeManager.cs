using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.DeltaTime
{
    public class DeltaTimeManager : IDeltaTimeManager
    {
        // Fields
        private int <FrameCount>k__BackingField;
        private float <Time>k__BackingField;
        private float timeScale;
        private int lastDeltaCalculatedFrame;
        private float lastDelta;
        
        // Properties
        public int FrameCount { get; set; }
        public virtual float DeltaTime { get; }
        public float Time { get; set; }
        public float TimeScale { get; }
        
        // Methods
        public int get_FrameCount()
        {
            return (int)this.<FrameCount>k__BackingField;
        }
        private void set_FrameCount(int value)
        {
            this.<FrameCount>k__BackingField = value;
        }
        public virtual float get_DeltaTime()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 * 10000f;
            float val_3 = (float)UnityEngine.Mathf.FloorToInt(f:  val_1);
            val_3 = val_3 / 10000f;
            return (float)val_3;
        }
        public float get_Time()
        {
            return (float)this.<Time>k__BackingField;
        }
        private void set_Time(float value)
        {
            this.<Time>k__BackingField = value;
        }
        public float get_TimeScale()
        {
            return (float)this.timeScale;
        }
        public DeltaTimeManager()
        {
            Royal.Scenes.Game.Context.GameContext.RegisterToLateUpdate(lateUpdate:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.DeltaTime.DeltaTimeManager::ManualLateUpdate()));
        }
        public void SetTimeScale(float timeScale)
        {
            this.timeScale = timeScale;
            UnityEngine.Time.timeScale = timeScale;
        }
        private void ManualLateUpdate()
        {
            int val_2 = this.<FrameCount>k__BackingField;
            this.<Time>k__BackingField = (this.<Time>k__BackingField) + S0;
            val_2 = val_2 + 1;
            this.<FrameCount>k__BackingField = val_2;
        }
    
    }

}
