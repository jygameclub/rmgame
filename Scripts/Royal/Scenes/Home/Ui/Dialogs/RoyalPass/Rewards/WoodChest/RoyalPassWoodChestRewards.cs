using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest
{
    public class RoyalPassWoodChestRewards : MonoBehaviour
    {
        // Methods
        public virtual void AnimateRewards()
        {
        
        }
        public virtual DG.Tweening.Sequence SendRewardsToButton()
        {
            return DG.Tweening.DOTween.Sequence();
        }
        public RoyalPassWoodChestRewards()
        {
        
        }
    
    }

}
