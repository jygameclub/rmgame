using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.ThirdGift
{
    public class KingsCupThirdGiftRewards : KingsCupGiftRewards
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView life;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView rocket;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView tnt;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView lightball;
        
        // Properties
        protected override int BoosterRevealSoundAmount { get; }
        
        // Methods
        protected override int get_BoosterRevealSoundAmount()
        {
            return 2;
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
            float val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            float val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_6 = 0f;
            val_6 = val_7 * val_6;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f);
            float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            val_7 = val_7 + val_7;
            float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView).__il2cppRuntimeField_180;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_12 = 3f;
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  val_12);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.rocket.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.tnt.SendGiftToButton(duration:  0.69f));
            val_12 = val_1 * val_12;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_12, t:  this.lightball.SendGiftToButton(duration:  0.71f));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_12, t:  this.life.SendToLifePanel());
            return val_2;
        }
        public KingsCupThirdGiftRewards()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
