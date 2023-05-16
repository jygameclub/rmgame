using UnityEngine;
private sealed class SplashView.<FadeRoutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Start.Context.Units.Loading.View.SplashView <>4__this;
    public float targetAlpha;
    public float duration;
    public System.Action onComplete;
    private float <elapsed>5__2;
    private UnityEngine.Color <color>5__3;
    private float <startAlpha>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SplashView.<FadeRoutine>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        if((this.<>1__state) <= 5)
        {
                var val_9 = 36614064 + (this.<>1__state) << 2;
            val_9 = val_9 + 36614064;
        }
        else
        {
                val_9 = 0;
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
