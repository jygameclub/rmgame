using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public class IntervalAction : AnimationAction
    {
        // Fields
        private readonly float duration;
        private readonly bool disableUiTouch;
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener touchListener;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public IntervalAction(float duration, bool disableUiTouch = False, int flowType = 0)
        {
            this = new System.Object();
            this.<Type>k__BackingField = flowType;
            this.duration = duration;
            this.disableUiTouch = disableUiTouch;
            this.touchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
        }
        public override void Execute()
        {
            if(this.disableUiTouch != false)
            {
                    this.touchListener.disabler.DisableTouch();
            }
            
            this.Execute();
        }
        public override void Complete()
        {
            if(this.disableUiTouch != false)
            {
                    this.touchListener.disabler.EnableTouch();
            }
            
            if(this.touchListener.disabler == 0)
            {
                    return;
            }
            
            this.touchListener.disabler.Invoke();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        protected override float GetDurationForNextAction()
        {
            return (float)this.duration;
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
    
    }

}
