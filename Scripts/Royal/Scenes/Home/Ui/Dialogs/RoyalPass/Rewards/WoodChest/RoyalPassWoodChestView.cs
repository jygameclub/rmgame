using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest
{
    public class RoyalPassWoodChestView : RoyalPassChestRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest.RoyalPassWoodChestRewards royalPassWoodChestRewards;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest.RoyalPassWoodChestRewards val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  40472.GetFreeChestRewardsPrefabName()), parent:  this.gameObject.transform).GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest.RoyalPassWoodChestRewards>();
            this.royalPassWoodChestRewards = val_6;
            mem[1152921519296628928] = val_6.transform;
        }
        protected override void AnimateRewards()
        {
            if(this.royalPassWoodChestRewards != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            if(this.royalPassWoodChestRewards != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public RoyalPassWoodChestView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
