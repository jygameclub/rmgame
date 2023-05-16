using UnityEngine;
private sealed class LoadingTipView.<FadeRoutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public Royal.Scenes.Start.Context.Units.Loading.View.LoadingTipView <>4__this;
    public float targetAlpha;
    public float duration;
    public System.Action onComplete;
    private float <elapsed>5__2;
    private float <startAlpha>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingTipView.<FadeRoutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if((this.<>1__state) <= 3)
        {
                var val_7 = 36531916 + (this.<>1__state) << 2;
            val_7 = val_7 + 36531916;
        }
        else
        {
                val_7 = 0;
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
