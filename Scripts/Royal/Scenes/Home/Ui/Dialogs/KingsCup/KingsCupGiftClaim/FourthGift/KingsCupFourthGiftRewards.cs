using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.FourthGift
{
    public class KingsCupFourthGiftRewards : KingsCupGiftRewards
    {
        // Fields
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
            this.rocket.SetAmount(amount:  inventoryPackage.boosters.Item[1]);
            this.tnt.SetAmount(amount:  inventoryPackage.boosters.Item[2]);
            this.lightball.SetAmount(amount:  inventoryPackage.boosters.Item[3]);
        }
        public override void ShowRewards()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            float val_2 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_3 = val_1 * 0f;
            float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f);
            float val_5 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            float val_6 = val_1 + val_1;
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_10 = 0f;
            val_10 = val_1 * val_10;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_10, t:  this.rocket.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.tnt.SendGiftToButton(duration:  0.69f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.lightball.SendGiftToButton(duration:  0.71f));
            return val_2;
        }
        public KingsCupFourthGiftRewards()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
