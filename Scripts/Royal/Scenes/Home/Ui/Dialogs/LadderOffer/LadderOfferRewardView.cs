using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferRewardView : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro itemAmountOrDurationText;
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep;
        
        // Methods
        public void SetItemAmountText(string text)
        {
            if(this.itemAmountOrDurationText == 0)
            {
                    return;
            }
            
            this.itemAmountOrDurationText.text = text;
        }
        public LadderOfferRewardView()
        {
        
        }
    
    }

}
