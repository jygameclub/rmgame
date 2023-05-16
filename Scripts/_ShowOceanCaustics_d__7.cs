using UnityEngine;
private sealed class Area11PoolsView.<ShowOceanCaustics>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area11.Tasks.Pools.Area11PoolsView <>4__this;
    private int <frame>5__2;
    private float[] <lastDeltaTimes>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area11PoolsView.<ShowOceanCaustics>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Home.Areas.Area11.Tasks.Pools.Area11PoolsView val_9;
        int val_10;
        val_9 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        var val_10 = 0;
        label_9:
        if(val_10 >= (this.<>4__this.poolCaustics.Length))
        {
            goto label_5;
        }
        
        UnityEngine.SpriteRenderer val_9 = this.<>4__this.poolCaustics[val_10];
        val_9.gameObject.SetActive(value:  true);
        UnityEngine.Color val_2 = UnityEngine.Color.black;
        val_9.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        val_10 = val_10 + 1;
        if((this.<>4__this.poolCaustics) != null)
        {
            goto label_9;
        }
        
        label_1:
        val_10 = this.<frame>5__2;
        this.<>1__state = 0;
        goto label_11;
        label_5:
        val_10 = this;
        this.<frame>5__2 = 0;
        mem[1152921519672133488] = new float[3];
        label_11:
        if((this.<frame>5__2) >= 10)
        {
                if(val_9 != null)
        {
            goto label_13;
        }
        
        }
        
        int val_5 = (this.<frame>5__2) / (this.<lastDeltaTimes>5__3.Length);
        val_5 = (this.<frame>5__2) - (val_5 * (this.<lastDeltaTimes>5__3.Length));
        this.<lastDeltaTimes>5__3[val_5] = UnityEngine.Time.deltaTime;
        this.<frame>5__2 = 1;
        if(((0.GetAverageOfDeltaTimes(lastFloats:  this.<lastDeltaTimes>5__3)) >= 0) || ((this.<frame>5__2) < (this.<lastDeltaTimes>5__3.Length)))
        {
            goto label_20;
        }
        
        label_13:
        var val_12 = 0;
        label_24:
        if(val_12 >= ((this.<>4__this.poolCaustics.Length) << ))
        {
            goto label_22;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_7 = DG.Tweening.DOTweenModuleSprite.DOColor(target:  this.<>4__this.poolCaustics[val_12], endValue:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, duration:  1f);
        val_12 = val_12 + 1;
        if((this.<>4__this.poolCaustics) != null)
        {
            goto label_24;
        }
        
        label_22:
        val_9 = val_9.GetComponentsInChildren<Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation>();
        if(val_8.Length < 1)
        {
                return false;
        }
        
        var val_14 = 0;
        do
        {
            val_9[val_14].PlayDistortion();
            val_14 = val_14 + 1;
        }
        while(val_14 < val_8.Length);
        
        return false;
        label_20:
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
