using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness
{
    public class MadnessLifeRewardView : MadnessRewardView
    {
        // Fields
        private int unlimitedMinutes;
        
        // Methods
        public override DG.Tweening.Sequence PlayCollectAnimation(Royal.Player.Context.Units.MadnessStep stepConfig)
        {
            if(stepConfig == null)
            {
                    throw new NullReferenceException();
            }
            
            if(stepConfig.r == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Player.Context.Units.MadnessReward val_1 = stepConfig.r[0];
            this.unlimitedMinutes = stepConfig.r[0].a;
            return this.SendToLifePanel();
        }
        private DG.Tweening.Sequence SendToLifePanel()
        {
            var val_23;
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.transform.localScale;
            val_23 = null;
            val_23 = null;
            .hitTransform = Royal.Scenes.Home.Ui.__il2cppRuntimeField_38 + 64.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.3f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.7f);
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.3f), ease:  3));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0.3f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.3f), ease:  8));
            UnityEngine.Vector3 val_17 = (MadnessLifeRewardView.<>c__DisplayClass2_0)[1152921519349190496].hitTransform.position;
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_7, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, duration:  0.6f, snapping:  false), ease:  11));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_7, action:  new DG.Tweening.TweenCallback(object:  new MadnessLifeRewardView.<>c__DisplayClass2_0(), method:  System.Void MadnessLifeRewardView.<>c__DisplayClass2_0::<SendToLifePanel>b__0()));
            return val_7;
        }
        private void PlayLifeHitParticles(UnityEngine.Transform hitTransform)
        {
            var val_14;
            MadnessLifeRewardView.<>c__DisplayClass3_0 val_1 = new MadnessLifeRewardView.<>c__DisplayClass3_0();
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.DOTween.__il2cppRuntimeField_cctor_finished.PlaySound(type:  23, offset:  0.04f);
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LifeHitParticles"));
            .hitParticles = val_4;
            UnityEngine.Vector3 val_7 = hitTransform.transform.position;
            val_4.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessLifeRewardView.<>c__DisplayClass3_0::<PlayLifeHitParticles>b__0()));
            val_14 = null;
            val_14 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_10 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  this.unlimitedMinutes, count:  0);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PlayHitAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_10.lifeCount, unlimitedMinutes = val_10.lifeCount});
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  2f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessLifeRewardView.<>c__DisplayClass3_0::<PlayLifeHitParticles>b__1()));
        }
        public MadnessLifeRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
