using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions
{
    public abstract class ARoyalPassFlowAction : FlowAction
    {
        // Fields
        protected int eventId;
        protected readonly Royal.Player.Context.Units.RoyalPassManager manager;
        protected readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener touchListener;
        
        // Methods
        protected ARoyalPassFlowAction()
        {
            this.manager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.touchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.eventId = this.manager.<EventId>k__BackingField;
        }
        protected bool ShouldPlayAnimation()
        {
            var val_3;
            if(this.manager.IsEventActive != false)
            {
                    var val_2 = (this.eventId == (this.manager.<EventId>k__BackingField)) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        protected void DisableTouchesIfNecessary()
        {
            if(this.manager.WillStepUp() == false)
            {
                    return;
            }
            
            this.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ARoyalPassFlowAction::<DisableTouchesIfNecessary>b__5_0()));
        }
        private void <DisableTouchesIfNecessary>b__5_0()
        {
            throw new NullReferenceException();
        }
    
    }

}
