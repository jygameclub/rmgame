using UnityEngine;
private sealed class Area03ServingsView.<>c__DisplayClass22_1
{
    // Fields
    public UnityEngine.GameObject topFood;
    public UnityEngine.Vector3 topInitialPos;
    public UnityEngine.GameObject bottomFood;
    public UnityEngine.Vector3 bottomInitialPos;
    public Royal.Scenes.Home.Areas.Area03.Tasks.Servings.Area03ServingsView.<>c__DisplayClass22_0 CS$<>8__locals1;
    
    // Methods
    public Area03ServingsView.<>c__DisplayClass22_1()
    {
    
    }
    internal void <PlayFoods>b__1()
    {
        this.topFood.SetActive(value:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.topFood.transform, endValue:  new UnityEngine.Vector3() {x = this.topInitialPos}, duration:  this.CS$<>8__locals1.<>4__this.duration, snapping:  false), ease:  this.CS$<>8__locals1.<>4__this.easing);
        this.bottomFood.SetActive(value:  true);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.bottomFood.transform, endValue:  new UnityEngine.Vector3() {x = this.bottomInitialPos}, duration:  this.CS$<>8__locals1.<>4__this.duration, snapping:  false), ease:  this.CS$<>8__locals1.<>4__this.easing);
    }

}
