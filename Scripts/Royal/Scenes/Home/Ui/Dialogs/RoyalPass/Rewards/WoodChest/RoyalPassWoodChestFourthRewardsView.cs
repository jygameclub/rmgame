using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Rewards.WoodChest
{
    public class RoyalPassWoodChestFourthRewardsView : RoyalPassWoodChestRewards
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView rocket;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView tnt;
        
        // Methods
        public override void AnimateRewards()
        {
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
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_10, t:  this.rocket.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.cannon.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.tnt.SendGiftToButton(duration:  0.69f));
            return val_2;
        }
        public RoyalPassWoodChestFourthRewardsView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
