using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupGiftCoinRewardView : KingsCupGiftRewardView
    {
        // Fields
        public TMPro.TextMeshPro coinText;
        public UnityEngine.ParticleSystem coinParticles;
        private int coinAmount;
        
        // Methods
        public void SetCoinAmount(int coinAmount)
        {
            this.coinAmount = coinAmount;
        }
        public override void Show(float delay, float hoverDelay, UnityEngine.Vector3 middlePoint, float middleDuration = 0)
        {
            this.coinText.enabled = false;
            this.coinText.text = "";
            this.Show(delay:  delay, hoverDelay:  hoverDelay, middlePoint:  new UnityEngine.Vector3() {x = middlePoint.x, y = middlePoint.y, z = middlePoint.z}, middleDuration:  middleDuration);
            this.PlayCoinTextAnimation();
        }
        public void SendToCoinPanel(DG.Tweening.Sequence seq)
        {
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView::<SendToCoinPanel>b__5_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  0.25f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView::<SendToCoinPanel>b__5_1()));
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  1.55f);
        }
        private void PlayCoinTextAnimation()
        {
            KingsCupGiftCoinRewardView.<>c__DisplayClass6_0 val_1 = new KingsCupGiftCoinRewardView.<>c__DisplayClass6_0();
            .<>4__this = this;
            this.coinText.enabled = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.7f);
            .startScale = val_3;
            mem[1152921519475151232] = val_3.y;
            mem[1152921519475151236] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.2f);
            .firstTargetScale = val_5;
            mem[1152921519475151244] = val_5.y;
            mem[1152921519475151248] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.9f);
            .finalScale = val_7;
            mem[1152921519475151220] = val_7.y;
            mem[1152921519475151224] = val_7.z;
            this.coinText.transform.localScale = new UnityEngine.Vector3() {x = (KingsCupGiftCoinRewardView.<>c__DisplayClass6_0)[1152921519475151184].startScale, y = val_7.y, z = val_7.z};
            .balance = 0;
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_9, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 KingsCupGiftCoinRewardView.<>c__DisplayClass6_0::<PlayCoinTextAnimation>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void KingsCupGiftCoinRewardView.<>c__DisplayClass6_0::<PlayCoinTextAnimation>b__1(int x)), endValue:  this.coinAmount, duration:  0.8f), ease:  6));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_9, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftCoinRewardView.<>c__DisplayClass6_0::<PlayCoinTextAnimation>b__2()));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_9, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  40f));
        }
        public KingsCupGiftCoinRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <SendToCoinPanel>b__5_0()
        {
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        private void <SendToCoinPanel>b__5_1()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.15f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftCoinRewardView::<SendToCoinPanel>b__5_2()));
        }
        private void <SendToCoinPanel>b__5_2()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
