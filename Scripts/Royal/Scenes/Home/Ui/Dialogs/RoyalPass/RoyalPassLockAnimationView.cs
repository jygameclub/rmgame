using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassLockAnimationView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView royalPassRewardContainerView;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView royalPassLastRowView;
        
        // Methods
        public void PlayOpenLockParticles()
        {
            if(this.royalPassRewardContainerView != 0)
            {
                    this.royalPassRewardContainerView.PlayOpenLockParticles();
                return;
            }
            
            if(this.royalPassLastRowView == 0)
            {
                    return;
            }
            
            this.royalPassLastRowView.PlayOpenLockParticles();
        }
        public RoyalPassLockAnimationView()
        {
        
        }
    
    }

}
