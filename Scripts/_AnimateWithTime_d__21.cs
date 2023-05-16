using UnityEngine;
private sealed class TntRocketCombo.<AnimateWithTime>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Levels.Units.Combo.TntRocketCombo <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TntRocketCombo.<AnimateWithTime>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_136;
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        TntRocketCombo.<>c__DisplayClass21_0 val_1 = null;
        val_136 = val_1;
        val_1 = new TntRocketCombo.<>c__DisplayClass21_0();
        .<>4__this = this.<>4__this;
        int val_136 = this.<>4__this.touchListener.isTouchDisabled;
        val_136 = val_136 + 1;
        this.<>4__this.touchListener = val_136;
        this.<>4__this = 1;
        this.<>4__this = this.<>4__this.swipeType;
        this.<>4__this.fromCell.FreezeFall();
        this.<>4__this.toCell.FreezeFall();
        this.<>4__this.ArrangeSorting();
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView val_2 = this.<>4__this.fromItem.GetSpecialItemView();
        .fromBaseView = val_2.baseView;
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView val_3 = this.<>4__this.toItem.GetSpecialItemView();
        .toBaseView = val_3.baseView;
        UnityEngine.Transform val_5 = this.<>4__this.fromItem.GetSpecialItemView().transform;
        UnityEngine.Transform val_7 = this.<>4__this.toItem.GetSpecialItemView().transform;
        UnityEngine.Vector3 val_9 = this.<>4__this.toItem.transform.localPosition;
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles val_10 = this.<>4__this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo.TntRocketComboUseParticles>(poolId:  20, activate:  true);
        .tntRocketUseParticles = val_10;
        val_10.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        (TntRocketCombo.<>c__DisplayClass21_0)[1152921524122071408].tntRocketUseParticles.Init(itemFactory:  this.<>4__this.itemFactory, isHorizontal:  ((this.<>4__this.swipeType) > 1) ? 1 : 0);
        (TntRocketCombo.<>c__DisplayClass21_0)[1152921524122071408].tntRocketUseParticles.Play();
        if((this.<>4__this.swipeType) <= 1)
        {
                var val_13 = ((this.<>4__this.swipeType) == 0) ? 1 : 0;
            float val_137 = 36587984 + this.<>4__this.swipeType == null ? 1 : 0;
            float val_14 = val_137 + val_9.y;
            val_137 = val_9.y - val_137;
            float val_15 = (36587992 + this.<>4__this.swipeType == null ? 1 : 0) + val_9.y;
            float val_16 = val_9.y - (36587992 + this.<>4__this.swipeType == null ? 1 : 0);
        }
        else
        {
                var val_17 = ((this.<>4__this.swipeType) == 3) ? 1 : 0;
            float val_138 = 36587984 + this.<>4__this.swipeType == 0x3 ? 1 : 0;
            val_138 = val_9.x - val_138;
        }
        
        UnityEngine.Color val_21 = UnityEngine.Color.white;
        UnityEngine.Vector3 val_22 = val_5.localScale;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  1.35f);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  1.2f);
        UnityEngine.Vector3 val_25 = val_7.localScale;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  0.85f);
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  1.35f);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  1.2f);
        var val_30 = ((this.<>4__this.swipeType) < 2) ? 0f : 4f;
        DG.Tweening.Sequence val_31 = DG.Tweening.DOTween.Sequence();
        var val_33 = ((this.<>4__this.swipeType) == 3) ? (-val_30) : (val_30);
        var val_34 = ((this.<>4__this.swipeType) == 3) ? (val_30) : (-val_30);
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_31, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.098f, mode:  0), ease:  3));
        DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_31, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.119f, mode:  0), ease:  3));
        DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_31, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.042f, mode:  0), ease:  3));
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_31, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, duration:  0.07f, mode:  0), ease:  2));
        DG.Tweening.Sequence val_51 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_51, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.098f, mode:  0), ease:  3));
        DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_51, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.119f, mode:  0), ease:  3));
        DG.Tweening.Sequence val_63 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_51, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.042f, mode:  0), ease:  3));
        UnityEngine.Vector3 val_65 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_68 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_51, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z}, duration:  0.07f, mode:  0), ease:  2));
        DG.Tweening.Sequence val_69 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_73 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_69, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_138 + val_9.x, y = val_9.y, z = val_9.z}, duration:  0.14f, snapping:  false), animCurve:  this.<>4__this.rotateAnimationEasing));
        DG.Tweening.Sequence val_75 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_69, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TntRocketCombo.<>c__DisplayClass21_0::<AnimateWithTime>b__0()));
        DG.Tweening.Sequence val_79 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_69, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = (36587992 + this.<>4__this.swipeType == 0x3 ? 1 : 0) + val_9.x, y = val_9.y, z = val_9.z}, duration:  0.17f, snapping:  false), animCurve:  this.<>4__this.rotateAnimationEasing));
        DG.Tweening.Sequence val_81 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_69, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TntRocketCombo.<>c__DisplayClass21_0::<AnimateWithTime>b__1()));
        DG.Tweening.Sequence val_85 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_69, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.07f, snapping:  false), ease:  14));
        DG.Tweening.Sequence val_86 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_90 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_86, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_138, y = val_9.y, z = val_9.z}, duration:  0.14f, snapping:  false), animCurve:  this.<>4__this.rotateAnimationEasing));
        DG.Tweening.Sequence val_94 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_86, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x - (36587992 + this.<>4__this.swipeType == 0x3 ? 1 : 0), y = val_9.y, z = val_9.z}, duration:  0.17f, snapping:  false), animCurve:  this.<>4__this.rotateAnimationEasing));
        DG.Tweening.Sequence val_98 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_86, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.07f, snapping:  false), ease:  14));
        DG.Tweening.Sequence val_99 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_102 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_99, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.07f));
        DG.Tweening.Sequence val_105 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_99, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, duration:  0.07f));
        DG.Tweening.Sequence val_108 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_99, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.085f));
        DG.Tweening.Sequence val_111 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_99, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_5.transform, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  0.085f));
        DG.Tweening.Sequence val_112 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_115 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_112, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.07f));
        DG.Tweening.Sequence val_118 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_112, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, duration:  0.07f));
        DG.Tweening.Sequence val_121 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_112, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.085f));
        DG.Tweening.Sequence val_124 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_112, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_7.transform, endValue:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, duration:  0.085f));
        DG.Tweening.Sequence val_125 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_127 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_125, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  (TntRocketCombo.<>c__DisplayClass21_0)[1152921524122071408].toBaseView, endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  0.07f));
        DG.Tweening.Sequence val_129 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_125, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  (TntRocketCombo.<>c__DisplayClass21_0)[1152921524122071408].toBaseView, endValue:  new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a}, duration:  0.07f));
        DG.Tweening.Sequence val_131 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_125, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  (TntRocketCombo.<>c__DisplayClass21_0)[1152921524122071408].fromBaseView, endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  0.085f));
        DG.Tweening.Sequence val_133 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_125, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  (TntRocketCombo.<>c__DisplayClass21_0)[1152921524122071408].fromBaseView, endValue:  new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a}, duration:  0.085f));
        DG.Tweening.Sequence val_135 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_69, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TntRocketCombo.<>c__DisplayClass21_0::<AnimateWithTime>b__2()));
        return false;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
