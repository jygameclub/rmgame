using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.PinkChest
{
    public class RoyalPassBoneChestView : RoyalPassChestRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView coin;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView unlimitedTnt;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        private int coinAmount;
        
        // Methods
        protected override void AnimateRewards()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            this.coin = this.coinAmount;
            float val_2 = val_1 * 0f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f);
            float val_4 = val_1 + val_1;
            float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f);
            float val_6 = 3f;
            val_6 = val_1 * val_6;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_7 = 0f;
            val_7 = val_1 * val_7;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_7, t:  this.unlimitedTnt.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.hammer.SendGiftToButton(duration:  0.67f));
            this.coin.SendToCoinPanel(seq:  val_2);
            return val_2;
        }
        public RoyalPassBoneChestView()
        {
            this.coinAmount = 200;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
