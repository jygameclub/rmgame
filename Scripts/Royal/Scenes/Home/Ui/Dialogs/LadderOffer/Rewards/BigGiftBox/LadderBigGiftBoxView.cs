using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.BigGiftBox
{
    public class LadderBigGiftBoxView : LadderGiftBoxRewardView
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView hammer;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView arrow;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView cannon;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView jester;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView coin;
        public UnityEngine.Transform coinTransform;
        public TMPro.TextMeshPro coinText;
        public UnityEngine.ParticleSystem coinParticles;
        
        // Methods
        protected override void AnimateRewards()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            float val_2 = val_1 * 0f;
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            float val_4 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f);
            float val_5 = val_1 + val_1;
            float val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  9f);
            float val_7 = val_1 * 3f;
            this.coinText.enabled = false;
            this.coinText.text = "";
            float val_8 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  12f);
            float val_9 = 4f;
            val_9 = val_1 * val_9;
            this.PlayCoinTextAnimation();
        }
        private void PlayCoinTextAnimation()
        {
            LadderBigGiftBoxView.<>c__DisplayClass9_0 val_1 = new LadderBigGiftBoxView.<>c__DisplayClass9_0();
            .<>4__this = this;
            this.coinText.enabled = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.7f);
            .startScale = val_3;
            mem[1152921519443172224] = val_3.y;
            mem[1152921519443172228] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.2f);
            .firstTargetScale = val_5;
            mem[1152921519443172236] = val_5.y;
            mem[1152921519443172240] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.9f);
            .finalScale = val_7;
            mem[1152921519443172212] = val_7.y;
            mem[1152921519443172216] = val_7.z;
            this.coinText.transform.localScale = new UnityEngine.Vector3() {x = (LadderBigGiftBoxView.<>c__DisplayClass9_0)[1152921519443172176].startScale, y = val_7.y, z = val_7.z};
            .balance = 0;
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 LadderBigGiftBoxView.<>c__DisplayClass9_0::<PlayCoinTextAnimation>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void LadderBigGiftBoxView.<>c__DisplayClass9_0::<PlayCoinTextAnimation>b__1(int x)), endValue:  1951340688, duration:  0.8f), ease:  6));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_9, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void LadderBigGiftBoxView.<>c__DisplayClass9_0::<PlayCoinTextAnimation>b__2()));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_9, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  40f));
        }
        public override DG.Tweening.Sequence SendRewardsToButton()
        {
            float val_1 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            float val_18 = 0f;
            val_18 = val_1 * val_18;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_18, t:  this.hammer.SendGiftToButton(duration:  0.65f));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1, t:  this.arrow.SendGiftToButton(duration:  0.67f));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 + val_1, t:  this.cannon.SendGiftToButton(duration:  0.69f));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_1 * 3f, t:  this.jester.SendGiftToButton(duration:  0.71f));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.BigGiftBox.LadderBigGiftBoxView::<SendRewardsToButton>b__10_0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.25f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.BigGiftBox.LadderBigGiftBoxView::<SendRewardsToButton>b__10_1()));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  2f);
            return val_2;
        }
        public LadderBigGiftBoxView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <SendRewardsToButton>b__10_0()
        {
            UnityEngine.Vector3 val_4 = this.coin.transform.position;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        private void <SendRewardsToButton>b__10_1()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coinTransform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.15f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.BigGiftBox.LadderBigGiftBoxView::<SendRewardsToButton>b__10_2()));
        }
        private void <SendRewardsToButton>b__10_2()
        {
            UnityEngine.Object.Destroy(obj:  this.coin.gameObject);
        }
    
    }

}
