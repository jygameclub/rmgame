using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Actions
{
    public abstract class AMadnessFlowAction : FlowAction
    {
        // Fields
        protected int eventId;
        protected readonly Royal.Player.Context.Units.MadnessManager manager;
        protected readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener touchListener;
        
        // Methods
        protected AMadnessFlowAction(int eventId)
        {
            this.eventId = eventId;
            this.manager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            this.touchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
        }
        protected bool ShouldPlayAnimation()
        {
            var val_3;
            if(this.manager.ShouldShowIcon != false)
            {
                    var val_2 = (this.eventId == this.manager.eventId) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        protected bool DisableTouchesIfNecessary(bool force = False)
        {
            var val_3;
            if(force != true)
            {
                    if(this.manager.WillClaim() == false)
            {
                goto label_3;
            }
            
            }
            
            this.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.AMadnessFlowAction::<DisableTouchesIfNecessary>b__5_0()));
            val_3 = 1;
            return (bool)val_3;
            label_3:
            val_3 = 0;
            return (bool)val_3;
        }
        private void <DisableTouchesIfNecessary>b__5_0()
        {
            throw new NullReferenceException();
        }
    
    }

}
