using UnityEngine;
private sealed class JSONClass.<GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public com.adjust.sdk.JSONClass <>4__this;
    private System.Collections.Generic.Dictionary.Enumerator<string, com.adjust.sdk.JSONNode> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONClass.<GetEnumerator>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        Dictionary.Enumerator<System.String, com.adjust.sdk.JSONNode> val_4;
        Dictionary.Enumerator<System.String, com.adjust.sdk.JSONNode> val_7;
        int val_8;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        Dictionary.Enumerator<TKey, TValue> val_1 = this.<>4__this.m_Dict.GetEnumerator();
        val_7 = this.<>7__wrap1;
        mem[1152921528951001976] = val_2;
        mem[1152921528951001960] = val_3;
        this.<>7__wrap1 = val_4;
        this.<>1__state = -3;
        goto label_5;
        label_1:
        val_7 = this.<>7__wrap1;
        this.<>1__state = -3;
        label_5:
        if((val_7 & 1) != 0)
        {
                val_4 = 1152921528948819760;
            this.<>2__current = val_4;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        this.<>m__Finally1();
        val_8 = 0;
        val_7 = 0;
        val_7 = 0;
        val_7 = 0;
        return (bool)val_8;
        label_2:
        val_8 = 0;
        return (bool)val_8;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
