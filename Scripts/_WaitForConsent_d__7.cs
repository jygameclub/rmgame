using UnityEngine;
private sealed class ConsentHelper.<WaitForConsent>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Contexts.Units.App.ConsentHelper <>4__this;
    public System.Action onConsentGiven;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ConsentHelper.<WaitForConsent>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if((this.<>1__state) < 2)
        {
                this.<>1__state = 0;
            if((this.<>4__this.requiresConsent) != false)
        {
                val_1 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_1;
            return (bool)val_1;
        }
        
            this.onConsentGiven.Invoke();
        }
        
        val_1 = 0;
        return (bool)val_1;
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
