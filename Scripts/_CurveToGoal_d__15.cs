using UnityEngine;
private sealed class CookieGoalView.<CurveToGoal>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView <>4__this;
    public UnityEngine.Vector3 targetPos;
    public float duration;
    public System.Action onComplete;
    private float <sortingDelay>5__2;
    private float <elapsed>5__3;
    private UnityEngine.Vector3 <p0>5__4;
    private UnityEngine.Vector3 <p3>5__5;
    private UnityEngine.Vector3 <p1>5__6;
    private UnityEngine.Vector3 <p2>5__7;
    private float <speed>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CookieGoalView.<CurveToGoal>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_34;
        if((this.<>1__state) <= 4)
        {
                var val_32 = 36616604 + (this.<>1__state) << 2;
            val_32 = val_32 + 36616604;
        }
        else
        {
                val_34 = 0;
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
