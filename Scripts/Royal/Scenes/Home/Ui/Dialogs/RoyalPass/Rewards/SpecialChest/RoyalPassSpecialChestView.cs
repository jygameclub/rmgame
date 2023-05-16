using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.SpecialChest
{
    public class RoyalPassSpecialChestView : RoyalPassChestRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView tnt;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView lightball;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView rocket;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView coin;
        private int coinAmount;
        private int unLimitedLifeTimeMin;
        
        // Properties
        public override UnityEngine.Vector3 SpawnOffset { get; }
        
        // Methods
        public override UnityEngine.Vector3 get_SpawnOffset()
        {
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected override void AnimateRewards()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            this.coin = this.coinAmount;
            this.life.SetLife(minutes:  this.unLimitedLifeTimeMin, prepareTextForAnimation:  false);
            float val_2 = val_1 * 0f;
            float val_3 = val_1 + val_1;
            float val_4 = 3f;
            val_4 = val_1 * val_4;
            float val_5 = 4f;
            val_5 = val_1 * val_5;
            float val_6 = 5f;
            val_6 = val_1 * val_6;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_15 = 0f;
            val_15 = val_1 * val_15;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_15, t:  this.rocket.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.tnt.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 * 3f, t:  this.life.SendToLifePanel());
            float val_16 = 4f;
            val_16 = val_1 * val_16;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_16, t:  this.lightball.SendGiftToButton(duration:  0.65f));
            float val_17 = 5f;
            val_17 = val_1 * val_17;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_17, t:  this.hammer.SendGiftToButton(duration:  0.65f));
            this.coin.SendToCoinPanel(seq:  val_2);
            return val_2;
        }
        public RoyalPassSpecialChestView()
        {
            this.coinAmount = 1000;
            this.unLimitedLifeTimeMin = 60;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
