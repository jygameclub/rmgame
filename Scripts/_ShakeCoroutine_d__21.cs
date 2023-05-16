using UnityEngine;
private sealed class PumpkinItemView.<ShakeCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.Pumpkin.View.PumpkinItemView <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData data;
    private float <randomAngle>5__2;
    private float <randomTime>5__3;
    private UnityEngine.Transform <pivot1>5__4;
    private UnityEngine.Transform <pivot2>5__5;
    private float <randomDur>5__6;
    private float <time>5__7;
    private UnityEngine.Quaternion <startRotation>5__8;
    private UnityEngine.Quaternion <endRotation>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PumpkinItemView.<ShakeCoroutine>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_43 = 0;
        if((this.<>1__state) > 7)
        {
                return (bool);
        }
        
        var val_43 = 36613952;
        val_43 = (36613952 + (this.<>1__state) << 2) + val_43;
        goto (36613952 + (this.<>1__state) << 2 + 36613952);
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
