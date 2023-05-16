using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim
{
    public class KingsCupGiftLifeRewardView : KingsCupGiftRewardView
    {
        // Fields
        private const float Scale1 = 1.3;
        private const float Scale2 = 0.7;
        private UnityEngine.Transform shadowsParent;
        private UnityEngine.Transform hitTransform;
        private int unlimitedMinutes;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Transform val_2 = this.transform.Find(n:  "ShadowsParent");
            if(val_2 == 0)
            {
                    return;
            }
            
            this.shadowsParent = val_2;
        }
        public void SetLife(int minutes, bool prepareTextForAnimation = True)
        {
            object val_11;
            var val_13;
            this.unlimitedMinutes = minutes;
            UnityEngine.Transform val_2 = 21404.transform.Find(n:  "Text");
            if(val_2 != 0)
            {
                    var val_11 = 0;
                val_11 = val_11 + minutes;
                int val_6 = (val_11 >> 5) + (val_11 >> 31);
                if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    val_11 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h");
            }
            else
            {
                    val_11 = val_6;
            }
            
                val_2.GetComponent<TMPro.TextMeshPro>().text = val_6 + Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h")(Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h"));
            }
            
            if(prepareTextForAnimation == false)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_10 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  this.unlimitedMinutes, count:  0);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_10.lifeCount, unlimitedMinutes = val_10.lifeCount});
        }
        public DG.Tweening.Sequence SendToLifePanel()
        {
            var val_29;
            mem[1152921519476787688] = 1;
            if(21403 != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  21403, complete:  true);
                mem[1152921519476787656] = 0;
            }
            
            if(21403 != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  21403, complete:  false);
                mem[1152921519476787664] = 0;
            }
            
            if(21403 != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  21403, complete:  false);
                mem[1152921519476787672] = 0;
            }
            
            val_29 = null;
            val_29 = null;
            this.hitTransform = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform;
            UnityEngine.Vector3 val_3 = this.shadowsParent.transform.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = 0f}, d:  1.3f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = 0f}, d:  0.7f);
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.4f), ease:  3));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.shadowsParent, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.4f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0.4f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.3f), ease:  8));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0.4f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.shadowsParent, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f, snapping:  false), ease:  8));
            UnityEngine.Vector3 val_23 = this.hitTransform.position;
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.7f, snapping:  false), ease:  11));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_7, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftLifeRewardView::<SendToLifePanel>b__7_0()));
            return val_7;
        }
        private void PlayItemHitAnimation()
        {
            var val_14;
            KingsCupGiftLifeRewardView.<>c__DisplayClass8_0 val_1 = new KingsCupGiftLifeRewardView.<>c__DisplayClass8_0();
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished.PlaySound(type:  23, offset:  0.04f);
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LifeHitParticles"));
            .hitParticles = val_4;
            UnityEngine.Vector3 val_7 = this.hitTransform.transform.position;
            val_4.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftLifeRewardView.<>c__DisplayClass8_0::<PlayItemHitAnimation>b__0()));
            val_14 = null;
            val_14 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_10 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  this.unlimitedMinutes, count:  0);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PlayHitAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_10.lifeCount, unlimitedMinutes = val_10.lifeCount});
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  2f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void KingsCupGiftLifeRewardView.<>c__DisplayClass8_0::<PlayItemHitAnimation>b__1()));
        }
        public KingsCupGiftLifeRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private void <SendToLifePanel>b__7_0()
        {
            this.PlayItemHitAnimation();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
