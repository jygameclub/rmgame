using UnityEngine;
private sealed class SpendStarView.<PlayAnimation>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.Area.SpendStarView <>4__this;
    public UnityEngine.Vector2 endPosition;
    private float <elapsed>5__2;
    private float <duration>5__3;
    private bool <isHitAnimationPlayed>5__4;
    private UnityEngine.Vector3 <start>5__5;
    private float <totalRotate>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpendStarView.<PlayAnimation>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_44;
        UnityEngine.Object val_48;
        val_44 = this;
        if((this.<>1__state) <= 4)
        {
                var val_42 = 36587144 + (this.<>1__state) << 2;
            val_42 = val_42 + 36587144;
        }
        else
        {
                val_48 = 0;
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
