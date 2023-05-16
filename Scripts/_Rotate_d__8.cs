using UnityEngine;
private sealed class UiSpinner.<Rotate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.UiComponents.UiSpinner <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UiSpinner.<Rotate>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) <= 1)
        {
                this.<>1__state = 0;
            this.<>4__this.transform.Rotate(xAngle:  0f, yAngle:  0f, zAngle:  -60f);
            val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = this.<>4__this.waitForSeconds;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
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
