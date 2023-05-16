using UnityEngine;
private sealed class Area03ChairView.<>c__DisplayClass11_1
{
    // Fields
    public UnityEngine.GameObject rightChair;
    public Royal.Scenes.Home.Areas.Area03.Tasks.Chair.Area03ChairView <>4__this;
    
    // Methods
    public Area03ChairView.<>c__DisplayClass11_1()
    {
    
    }
    internal void <ScaleChairs>b__2()
    {
        this.rightChair.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.rightChair.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  this.<>4__this.scaleDuration), ease:  27);
    }

}
