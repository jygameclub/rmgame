using UnityEngine;
private sealed class Area09View.<ShowOceanCaustics>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area09.Area09View <>4__this;
    private int <frame>5__2;
    private float[] <lastDeltaTimes>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area09View.<ShowOceanCaustics>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        val_6 = this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return false;
        }
        
            val_7 = val_6;
            this.<frame>5__2 = 0;
            this.<>1__state = 0;
            mem[1152921519678857776] = new float[3];
        }
        else
        {
                val_7 = this.<frame>5__2;
            this.<>1__state = 0;
        }
        
        if(val_7 >= 10)
        {
                if((this.<>4__this) != null)
        {
            goto label_5;
        }
        
        }
        
        int val_3 = val_7 / (this.<lastDeltaTimes>5__3.Length);
        val_3 = val_7 - (val_3 * (this.<lastDeltaTimes>5__3.Length));
        this.<lastDeltaTimes>5__3[val_3] = UnityEngine.Time.deltaTime;
        int val_6 = val_7;
        val_6 = val_6 + 1;
        val_7 = val_6;
        if(((0.GetAverageOfDeltaTimes(lastFloats:  this.<lastDeltaTimes>5__3)) >= 0) || (val_7 < (this.<lastDeltaTimes>5__3.Length)))
        {
            goto label_12;
        }
        
        label_5:
        var val_8 = 0;
        label_16:
        if(val_8 >= ((this.<>4__this.oceansCaustics.Length) << ))
        {
            goto label_14;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.<>4__this.oceansCaustics[val_8], endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  1f);
        val_8 = val_8 + 1;
        if((this.<>4__this.oceansCaustics) != null)
        {
            goto label_16;
        }
        
        label_14:
        val_6 = 0;
        do
        {
            if(val_6 >= (this.<>4__this.distortionAnimations.Length))
        {
                return false;
        }
        
            this.<>4__this.distortionAnimations[val_6].PlayDistortion();
            val_6 = val_6 + 1;
        }
        while((this.<>4__this.distortionAnimations) != null);
        
        throw new NullReferenceException();
        label_12:
        this.<>2__current = 0;
        this.<>1__state = 1;
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
