using UnityEngine;
private sealed class LightBulbItemView.<ChangeColorCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView <>4__this;
    public Royal.Scenes.Game.Mechanics.Matches.MatchType newColor;
    public Royal.Scenes.Game.Mechanics.Matches.MatchType oldColor;
    private UnityEngine.AnimationCurve <alternativeBulbAnimationCurve>5__2;
    private float <elapsed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LightBulbItemView.<ChangeColorCoroutine>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_10;
        float val_11;
        var val_12;
        int val_13;
        float val_14;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_10 = this;
        this.<elapsed>5__3 = 0f;
        this.<>1__state = 0;
        mem[1152921520271091376] = 0;
        var val_16 = 0;
        var val_15 = 0;
        label_20:
        if(val_15 >= (this.<>4__this.lightBulbs.Length))
        {
            goto label_5;
        }
        
        if((this.<>4__this.isDestroyed[val_15]) != true)
        {
                this.<>4__this.SetFrontAttachment(index:  0, color:  this.newColor);
            this.<>4__this.SetBackAttachment(index:  0, color:  this.oldColor);
            this.<>4__this.lightBulbs[val_16] = 0;
            this.<>4__this.lightBulbs[val_16] = 1065353216;
            this.<>4__this.lightBulbs[val_16] = 0;
            this.<alternativeBulbAnimationCurve>5__2 = this.<>4__this.InitAlternativeBulbForColorChange(oldColor:  this.oldColor, newColor:  this.newColor, alternativeBulb:  this.<>4__this.lightBulbs[val_16], index:  0);
        }
        
        val_15 = val_15 + 1;
        val_16 = val_16 + 48;
        if((this.<>4__this.lightBulbs) != null)
        {
            goto label_20;
        }
        
        label_1:
        val_10 = this.<elapsed>5__3;
        this.<>1__state = 0;
        label_5:
        float val_24 = val_10;
        val_11 = 0.4f;
        if(val_24 < 0)
        {
            goto label_22;
        }
        
        var val_23 = 0;
        val_12 = 0;
        label_43:
        if(val_12 >= ((this.<>4__this.lightBulbs.Length) << ))
        {
            goto label_25;
        }
        
        if((this.<>4__this.isDestroyed[val_12]) != true)
        {
                this.<>4__this.lightBulbs[val_23].Attachment = 0;
            this.<>4__this.lightBulbs[val_23].Attachment = 0;
            this.<>4__this.lightBulbs[val_23] = 1065353216;
            this.<>4__this.lightBulbs[val_23] = 0;
            this.<>4__this.lightBulbs[val_23] = 0;
        }
        
        val_12 = val_12 + 1;
        val_23 = val_23 + 48;
        if((this.<>4__this.lightBulbs) != null)
        {
            goto label_43;
        }
        
        label_2:
        val_13 = 0;
        return (bool)val_13;
        label_22:
        float val_2 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_24 = val_24 + val_2;
        val_10 = val_24;
        val_12 = 1152921504781234176;
        val_2 = val_24 / val_11;
        float val_3 = UnityEngine.Mathf.Clamp01(value:  val_2);
        val_11 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3).Invoke(t:  val_3);
        if((this.<alternativeBulbAnimationCurve>5__2) == null)
        {
            goto label_50;
        }
        
        val_14 = this.<alternativeBulbAnimationCurve>5__2.Evaluate(time:  val_3);
        float val_9 = UnityEngine.Mathf.Clamp01(value:  val_14);
        if((this.<>4__this) != null)
        {
            goto label_53;
        }
        
        label_25:
        val_13 = 0;
        this.<>4__this = 0;
        return (bool)val_13;
        label_50:
        val_14 = 0f;
        label_53:
        float val_25 = 1f;
        var val_31 = 0;
        var val_30 = 0;
        val_25 = val_25 - (Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  2).Invoke(t:  val_3));
        label_70:
        if(val_30 >= ((this.<>4__this.lightBulbs.Length) << ))
        {
            goto label_58;
        }
        
        if((this.<>4__this.isDestroyed[val_30]) != true)
        {
                this.<>4__this.lightBulbs[val_31] = val_11;
            this.<>4__this.lightBulbs[val_31] = val_25;
            this.<>4__this.lightBulbs[val_31] = val_14;
        }
        
        val_30 = val_30 + 1;
        val_31 = val_31 + 48;
        if((this.<>4__this.lightBulbs) != null)
        {
            goto label_70;
        }
        
        throw new NullReferenceException();
        label_58:
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
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
