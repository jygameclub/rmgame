using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions
{
    public abstract class ALadderFlowAction : FlowAction
    {
        // Fields
        private readonly int eventId;
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener touchListener;
        private Royal.Player.Context.Units.LadderOfferManager ladderOfferManager;
        
        // Methods
        protected ALadderFlowAction(int eventId)
        {
            this.eventId = eventId;
            this.touchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.ladderOfferManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
        }
        protected bool ShouldPlayAnimation()
        {
            var val_3;
            if(this.ladderOfferManager.ShouldShowIcon != false)
            {
                    var val_2 = (this.eventId == (this.ladderOfferManager.<EventId>k__BackingField)) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public override void Complete()
        {
            this.Complete();
        }
    
    }

}
