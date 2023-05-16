using UnityEngine;

namespace Royal.Scenes.Home.Context.Units
{
    public class EnableTouchesAfterWin : ATouchesAfterWin
    {
        // Methods
        public EnableTouchesAfterWin(bool isAfterMadnessAnimations)
        {
            val_1 = new Royal.Scenes.Start.Context.Units.Flow.FlowAction();
            mem[1152921519552263192] = isAfterMadnessAnimations;
        }
        public override void Execute()
        {
            if(this.ShouldDisable() != false)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
                val_2.disabler.EnableTouch();
            }
            
            this.Complete();
        }
    
    }

}
