using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions
{
    public class PlayLadderOfferRewardItemAnimationAction : PlayShopRewardItemAnimationAction
    {
        // Fields
        private readonly float delay;
        
        // Methods
        public PlayLadderOfferRewardItemAnimationAction(float delay)
        {
            float val_1 = this.delay;
            val_1 = val_1 + delay;
            this.delay = val_1;
        }
        protected override float GetDurationForNextAction()
        {
            return (float)S0 + this.delay;
        }
    
    }

}
