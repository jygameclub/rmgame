using UnityEngine;

namespace Royal.Scenes.Home.Context.Units
{
    public class DisableTouchesAfterWin : ATouchesAfterWin
    {
        // Fields
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public DisableTouchesAfterWin(bool isAfterMadnessAnimations, int type)
        {
            val_1 = new Royal.Scenes.Start.Context.Units.Flow.FlowAction();
            mem[1152921519552607384] = isAfterMadnessAnimations;
            this.<Type>k__BackingField = type;
        }
        public override void Execute()
        {
            if(this.ShouldDisable() != false)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_2.disabler.DisableTouch();
            }
            
            this.Complete();
        }
    
    }

}
