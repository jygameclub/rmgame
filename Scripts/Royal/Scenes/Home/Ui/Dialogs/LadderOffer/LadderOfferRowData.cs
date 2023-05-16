using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferRowData : IUiScrollContentData
    {
        // Fields
        public readonly Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep;
        public readonly Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferScrollView ladderOfferScrollView;
        
        // Methods
        public LadderOfferRowData(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep, Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferScrollView ladderOfferScrollView)
        {
            this.ladderOfferStep = ladderOfferStep;
            this.ladderOfferScrollView = ladderOfferScrollView;
        }
    
    }

}
