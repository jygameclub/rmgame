using UnityEngine;
private sealed class CurvedTextAnimator.<AnimateCharacter>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Utils.Text.CurvedSingleText textMesh;
    public int index;
    private float <startScale>5__2;
    private float <endScale>5__3;
    private float <elapsed>5__4;
    private float <totalDur>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CurvedTextAnimator.<AnimateCharacter>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_23;
        if((this.<>1__state) <= 3)
        {
                var val_16 = 36600848 + (this.<>1__state) << 2;
            val_16 = val_16 + 36600848;
        }
        else
        {
                val_23 = 0;
            return (bool);
        }
    
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
