using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.MediumChest
{
    public class RoyalPassMediumChestView : RoyalPassChestRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView rocket;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView coin;
        private int coinAmount;
        private int unLimitedLifeTimeMin;
        
        // Methods
        protected override void AnimateRewards()
        {
            this.coin = this.coinAmount;
            this.life.SetLife(minutes:  this.unLimitedLifeTimeMin, prepareTextForAnimation:  false);
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_2 = val_1 * 0f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f);
            float val_4 = val_1 + val_1;
            float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f);
            float val_7 = 3f;
            val_7 = val_1 * val_7;
            float val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f);
            float val_8 = 4f;
            val_8 = val_1 * val_8;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_10 = 0f;
            val_10 = val_1 * val_10;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_10, t:  this.rocket.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.life.SendToLifePanel());
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.cannon.SendGiftToButton(duration:  0.67f));
            this.coin.SendToCoinPanel(seq:  val_2);
            return val_2;
        }
        public RoyalPassMediumChestView()
        {
            this.coinAmount = 300;
            this.unLimitedLifeTimeMin = 60;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
