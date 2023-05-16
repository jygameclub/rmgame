using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.FirstGift
{
    public class KingsCupFirstGiftRewards : KingsCupGiftRewards
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView jester;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView rocket;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView tnt;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView lightball;
        
        // Properties
        protected override int BoosterRevealSoundAmount { get; }
        
        // Methods
        protected override int get_BoosterRevealSoundAmount()
        {
            return 4;
        }
        public override void SetPackage(Royal.Player.Context.Data.InventoryPackage inventoryPackage)
        {
            this.life.SetLife(minutes:  inventoryPackage.unlimitedLifetimeMin, prepareTextForAnimation:  true);
            this.rocket.SetAmount(amount:  inventoryPackage.boosters.Item[1]);
            this.tnt.SetAmount(amount:  inventoryPackage.boosters.Item[2]);
            this.lightball.SetAmount(amount:  inventoryPackage.boosters.Item[3]);
        }
        public override void ShowRewards()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_2 = val_1 * 0f;
            float val_13 = 3f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  val_13);
            float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f);
            float val_5 = val_1 + val_1;
            float val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f);
            val_13 = val_1 * val_13;
            float val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  9f);
            float val_8 = val_1 * 4f;
            float val_9 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f);
            float val_11 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            float val_12 = val_1 * 5f;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_21 = 3f;
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  val_21);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_20 = 0f;
            val_20 = val_1 * val_20;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_20, t:  this.hammer.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.rocket.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.arrow.SendGiftToButton(duration:  0.69f));
            val_21 = val_1 * val_21;
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_21, t:  this.tnt.SendGiftToButton(duration:  0.71f));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_21, t:  this.life.SendToLifePanel());
            float val_22 = 4f;
            val_22 = val_1 * val_22;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_22, t:  this.lightball.SendGiftToButton(duration:  0.73f));
            float val_23 = 5f;
            val_23 = val_1 * val_23;
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_23, t:  this.cannon.SendGiftToButton(duration:  0.75f));
            float val_24 = 6f;
            val_24 = val_1 * val_24;
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_24, t:  this.jester.SendGiftToButton(duration:  0.77f));
            return val_2;
        }
        public KingsCupFirstGiftRewards()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
