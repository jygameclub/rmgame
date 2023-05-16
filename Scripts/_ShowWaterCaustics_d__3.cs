using UnityEngine;
private sealed class Area26PrepareIceRinkView.<ShowWaterCaustics>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area26.Tasks.PrepareIceRink.Area26PrepareIceRinkView <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area26PrepareIceRinkView.<ShowWaterCaustics>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.SpriteRenderer val_5;
        int val_6;
        val_5 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_1 = DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.<>4__this.waterCaustics, endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  0.2f);
        val_6 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  60f));
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        val_5 = this.<>4__this.waterCaustics;
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTweenModuleSprite.DOColor(target:  val_5, endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  1.6f);
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
