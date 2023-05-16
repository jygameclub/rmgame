using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.BigChest
{
    public class RoyalPassBigChestView : RoyalPassChestRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView tnt;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView lightball;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView coin;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView jester;
        private int cointAmount;
        
        // Methods
        protected override void AnimateRewards()
        {
            this.coin = this.cointAmount;
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_2 = val_1 * 0f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f);
            float val_5 = val_1 + val_1;
            float val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f);
            float val_7 = val_1 * 3f;
            float val_8 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  9f);
            float val_9 = 4f;
            val_9 = val_1 * val_9;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_13 = 0f;
            val_13 = val_1 * val_13;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_13, t:  this.tnt.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.lightball.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.arrow.SendGiftToButton(duration:  0.69f));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 * 3f, t:  this.jester.SendGiftToButton(duration:  0.71f));
            this.coin.SendToCoinPanel(seq:  val_2);
            return val_2;
        }
        public RoyalPassBigChestView()
        {
            this.cointAmount = 400;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
