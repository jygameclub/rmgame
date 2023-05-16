using UnityEngine;
private sealed class Area02StatuesView.<>c__DisplayClass11_0
{
    // Fields
    public UnityEngine.GameObject statueItem;
    public UnityEngine.Vector3 initialScale;
    
    // Methods
    public Area02StatuesView.<>c__DisplayClass11_0()
    {
    
    }
    internal void <PlayStatueItemAnimation>b__0()
    {
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.statueItem.transform, endValue:  new UnityEngine.Vector3() {x = this.initialScale}, duration:  0.1f), ease:  4);
    }

}
