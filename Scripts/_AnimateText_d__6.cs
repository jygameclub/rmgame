using UnityEngine;
private sealed class CurvedTextAnimator.<AnimateText>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isReversed;
    public Royal.Infrastructure.Utils.Text.CurvedTextAnimator <>4__this;
    public Royal.Infrastructure.Utils.Text.CurvedSingleText textMesh;
    private int <i>5__2;
    private int <j>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CurvedTextAnimator.<AnimateText>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_5;
        int val_6;
        int val_7;
        Royal.Infrastructure.Utils.Text.CurvedSingleText val_8;
        int val_9;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_14;
        }
        
        val_5 = this.isReversed;
        this.<>1__state = 0;
        if(val_5 == false)
        {
            goto label_3;
        }
        
        val_6 = this.textMesh.<CharCount>k__BackingField;
        goto label_5;
        label_1:
        int val_5 = this.<j>5__3;
        this.<>1__state = 0;
        val_5 = val_5 + 1;
        this.<j>5__3 = val_5;
        if((this.<>4__this) != null)
        {
            goto label_15;
        }
        
        label_0:
        this.<>1__state = 0;
        val_7 = (this.<j>5__3) + 1;
        this.<j>5__3 = val_7;
        if((this.<>4__this) != null)
        {
            goto label_8;
        }
        
        label_3:
        this.<i>5__2 = 0;
        val_8 = this.textMesh;
        goto label_10;
        label_12:
        val_9 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_15:
        if(val_5 < (this.<>4__this.frameDelay))
        {
            goto label_12;
        }
        
        val_8 = this;
        val_5 = 1;
        mem[1152921527446570712] = val_5;
        label_10:
        if(val_5 >= (this.textMesh.<CharCount>k__BackingField))
        {
            goto label_14;
        }
        
        this.<j>5__3 = 0;
        if((this.<>4__this) != null)
        {
            goto label_15;
        }
        
        label_19:
        val_7 = 0;
        this.<j>5__3 = 0;
        label_8:
        if(val_7 < (this.<>4__this.frameDelay))
        {
            goto label_18;
        }
        
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.StartCoroutine(routine:  this.AnimateCharacter(textMesh:  this.textMesh, index:  0)).AnimateCharacter(textMesh:  this.textMesh, index:  this.<i>5__2));
        val_6 = this.<i>5__2;
        label_5:
        val_6 = val_6 - 1;
        this.<i>5__2 = val_6;
        if((val_6 & 2147483648) == 0)
        {
            goto label_19;
        }
        
        label_14:
        val_9 = 0;
        return (bool)val_9;
        label_18:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_9 = 1;
        return (bool)val_9;
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
