using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest
{
    public class RoyalPassWoodChestFifthRewardsView : RoyalPassWoodChestRewards
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView lightball;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        private int unLimitedLifeTimeMin;
        
        // Methods
        public override void AnimateRewards()
        {
            this.life.SetLife(minutes:  this.unLimitedLifeTimeMin, prepareTextForAnimation:  false);
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_2 = val_1 * 0f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            float val_5 = val_1 + val_1;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_10 = 0f;
            val_10 = val_1 * val_10;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_10, t:  this.lightball.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.life.SendToLifePanel());
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.hammer.SendGiftToButton(duration:  0.67f));
            return val_2;
        }
        public RoyalPassWoodChestFifthRewardsView()
        {
            this.unLimitedLifeTimeMin = 30;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
