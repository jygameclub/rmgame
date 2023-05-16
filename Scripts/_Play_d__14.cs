using UnityEngine;
private sealed class MTween.<Play>d__14<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Utils.Animation.Tween.MTween<T> <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MTween.<Play>d__14<T>(int <>1__state)
    {
        mem[1152921527494945648] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        if(true < 2)
        {
                mem[1152921527495169648] = 0;
            float val_2 = mem[47620136];
            val_2 = mem[47620168];
            if(val_2 == 0)
        {
                return (bool);
        }
        
            val_2.Invoke();
        }
        
        val_2 = 0;
        return (bool);
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this;
    }

}
