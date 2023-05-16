using UnityEngine;
private sealed class Area03ServingsView.<>c__DisplayClass21_1
{
    // Fields
    public UnityEngine.GameObject leftPlateBottom;
    public UnityEngine.Vector3 leftInitialPosition;
    public UnityEngine.GameObject rightPlateBottom;
    public UnityEngine.Vector3 rightInitialPosition;
    public UnityEngine.GameObject leftPlateTop;
    public UnityEngine.Vector3 leftTopInitialPosition;
    public UnityEngine.GameObject rightPlateTop;
    public UnityEngine.Vector3 rightTopInitialPosition;
    public Royal.Scenes.Home.Areas.Area03.Tasks.Servings.Area03ServingsView.<>c__DisplayClass21_0 CS$<>8__locals1;
    
    // Methods
    public Area03ServingsView.<>c__DisplayClass21_1()
    {
    
    }
    internal void <PlayPlates>b__2()
    {
        this.leftPlateBottom.SetActive(value:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.leftPlateBottom.transform, endValue:  new UnityEngine.Vector3() {x = this.leftInitialPosition}, duration:  this.CS$<>8__locals1.<>4__this.duration, snapping:  false), ease:  this.CS$<>8__locals1.<>4__this.easing);
        this.rightPlateBottom.SetActive(value:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.rightPlateBottom.transform, endValue:  new UnityEngine.Vector3() {x = this.rightInitialPosition}, duration:  this.CS$<>8__locals1.<>4__this.duration, snapping:  false), ease:  this.CS$<>8__locals1.<>4__this.easing);
        this.leftPlateTop.SetActive(value:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.leftPlateTop.transform, endValue:  new UnityEngine.Vector3() {x = this.leftTopInitialPosition}, duration:  this.CS$<>8__locals1.<>4__this.duration, snapping:  false), ease:  this.CS$<>8__locals1.<>4__this.easing);
        this.rightPlateTop.SetActive(value:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.rightPlateTop.transform, endValue:  new UnityEngine.Vector3() {x = this.rightTopInitialPosition}, duration:  this.CS$<>8__locals1.<>4__this.duration, snapping:  false), ease:  this.CS$<>8__locals1.<>4__this.easing);
    }

}
