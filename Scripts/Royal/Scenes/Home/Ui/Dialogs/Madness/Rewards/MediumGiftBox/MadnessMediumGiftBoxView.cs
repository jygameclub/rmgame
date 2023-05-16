using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MediumGiftBox
{
    public class MadnessMediumGiftBoxView : MadnessGiftBoxRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        
        // Methods
        protected override void AnimateRewards()
        {
            float val_2 = (Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)) * 0f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_7 = 0f;
            val_7 = val_1 * val_7;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_7, t:  this.arrow.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.cannon.SendGiftToButton(duration:  0.67f));
            return val_2;
        }
        public MadnessMediumGiftBoxView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
