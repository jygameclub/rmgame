using UnityEngine;
private sealed class UiVerticalScroll.<PrepareContentWithAnimation>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll <>4__this;
    public float current;
    public float piece;
    public float final;
    private int <counter>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UiVerticalScroll.<PrepareContentWithAnimation>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        int val_4;
        if((this.<>1__state) == 0)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_8;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        if(this.piece > 0f)
        {
                if(val_2.y >= this.final)
        {
            goto label_8;
        }
        
        }
        
        if(this.piece < 0)
        {
                if(val_2.y <= this.final)
        {
            goto label_8;
        }
        
        }
        
        int val_3 = this.<counter>5__2;
        val_3 = val_3 + 1;
        val_3 = (float)val_3;
        this.<counter>5__2 = val_3;
        goto label_9;
        label_8:
        val_4 = 0;
        return (bool)val_4;
        label_0:
        this.<>1__state = 0;
        this.<counter>5__2 = 1;
        val_3 = 1f;
        label_9:
        val_3 = this.piece * val_3;
        val_3 = this.current + val_3;
        val_4 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_4;
        return (bool)val_4;
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
