using UnityEngine;
private sealed class HoneyItemView.<ExplodeWithAnimation>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData data;
    public System.Action onComplete;
    private float <duration>5__2;
    private float <elapsed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HoneyItemView.<ExplodeWithAnimation>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        float val_6;
        var val_7;
        float val_8;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        val_5 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.ExpandSprites();
        var val_1 = (0 == 6) ? 1 : 0;
        this.<duration>5__2 = 36604876 + 0 == 0x6 ? 1 : 0;
        val_6 = this.<duration>5__2;
        this.onComplete.Invoke();
        val_7 = this;
        this.<elapsed>5__3 = 0f;
        val_8 = 0f;
        goto label_7;
        label_1:
        val_7 = this;
        val_8 = this.<elapsed>5__3;
        val_6 = -1.117757E-24f;
        this.<>1__state = 0;
        label_7:
        if(val_8 < 0)
        {
            goto label_8;
        }
        
        this.<>4__this.RecycleSelf();
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_8:
        val_8 = val_8 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__3 = val_8;
        this.<>4__this.SetTransparency(alpha:  UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  val_8 / (this.<duration>5__2)));
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_5 = 1;
        return (bool)val_5;
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
