using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.BigGiftBox
{
    public class MadnessBigGiftBoxView : MadnessGiftBoxRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView jester;
        
        // Methods
        public override void SetPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
            this.life.SetLife(minutes:  inventoryPackage.unlimitedLifetimeMin, prepareTextForAnimation:  false);
        }
        protected override void AnimateRewards()
        {
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
            float val_15 = 0f;
            val_15 = val_1 * val_15;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_15, t:  this.hammer.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.arrow.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.life.SendToLifePanel());
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 * 3f, t:  this.cannon.SendGiftToButton(duration:  0.69f));
            float val_16 = 4f;
            val_16 = val_1 * val_16;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_16, t:  this.jester.SendGiftToButton(duration:  0.71f));
            return val_2;
        }
        public MadnessBigGiftBoxView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
