using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MediumChest
{
    public class MadnessMediumChestView : MadnessChestRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView jester;
        
        // Methods
        protected override void AnimateRewards()
        {
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
            float val_13 = 0f;
            val_13 = val_1 * val_13;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_13, t:  this.hammer.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.arrow.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.cannon.SendGiftToButton(duration:  0.69f));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 * 3f, t:  this.jester.SendGiftToButton(duration:  0.71f));
            return val_2;
        }
        public MadnessMediumChestView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
