using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.Warning
{
    public class RoyalPassClaimWarn : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassExtraWarnBarProgress royalPassProgress;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassExtraWarnBarRewardView royalPassRewardView;
        
        // Methods
        public void Show(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep royalPassStep, bool hasRoyalPass, float totalLeftBarSize)
        {
            royalPassStep = this.royalPassRewardView.SetupForSmallDisplay(royalPassStep:  royalPassStep, hasRoyalPass:  hasRoyalPass);
            this.royalPassProgress.FakeInit(totalLeftBarSize:  totalLeftBarSize, isShortBar:  royalPassStep);
        }
        public RoyalPassClaimWarn()
        {
        
        }
    
    }

}
