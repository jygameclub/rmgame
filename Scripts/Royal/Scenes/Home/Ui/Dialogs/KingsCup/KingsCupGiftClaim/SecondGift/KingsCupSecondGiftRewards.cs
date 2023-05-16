using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.SecondGift
{
    public class KingsCupSecondGiftRewards : KingsCupGiftRewards
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView jester;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView rocket;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView tnt;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView lightball;
        
        // Properties
        protected override int BoosterRevealSoundAmount { get; }
        
        // Methods
        protected override int get_BoosterRevealSoundAmount()
        {
            return 3;
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
            float val_10 = 0f;
            val_10 = val_1 * val_10;
            float val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f);
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  9f);
            float val_4 = val_1 * 3f;
            float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f);
            float val_7 = val_1 * 4f;
            float val_8 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            float val_9 = val_1 * 5f;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView).__il2cppRuntimeField_180;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_17 = 0f;
            val_17 = val_1 * val_17;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_17, t:  this.hammer.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.rocket.SendGiftToButton(duration:  0.67f));
            float val_8 = val_1 + val_1;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_8, t:  this.tnt.SendGiftToButton(duration:  0.71f));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_8, t:  this.life.SendToLifePanel());
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 * 3f, t:  this.lightball.SendGiftToButton(duration:  0.73f));
            float val_18 = 4f;
            val_18 = val_1 * val_18;
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_18, t:  this.jester.SendGiftToButton(duration:  0.77f));
            return val_2;
        }
        public KingsCupSecondGiftRewards()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
