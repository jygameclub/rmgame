using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions
{
    public class ShowLadderOfferPopupViewAction : FlowAction
    {
        // Fields
        private readonly bool enableTouches;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowLadderOfferPopupViewAction(bool setTouches, bool isAuto = False)
        {
            this.<Type>k__BackingField = (isAuto != true) ? 3 : 0;
            this.enableTouches = setTouches;
        }
        public override void Execute()
        {
            if(this.enableTouches != false)
            {
                    Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            }
            
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPopupView val_2 = Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPopupView>(assetName:  "LadderOfferPopup", action:  this);
            this.SendAnalyticsEvent();
        }
        private void SendAnalyticsEvent()
        {
            var val_4;
            if(this == 3)
            {
                    val_4 = 0;
            }
            
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_2 = GetLadderOffer();
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).OfferOpen(eventId:  val_2.eventId, isClick:  (this.enableTouches == false) ? 1 : 0);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
