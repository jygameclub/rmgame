using UnityEngine;
private sealed class AnimationAction.<CompleteAfterDelay>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Start.Context.Units.Flow.AnimationAction <>4__this;
    private float <duration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimationAction.<CompleteAfterDelay>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Start.Context.Units.Flow.AnimationAction val_8;
        System.Object[] val_9;
        int val_10;
        int val_11;
        int val_12;
        val_8 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<duration>5__2 = ;
        object[] val_1 = new object[4];
        val_9 = val_1;
        val_9[0] = "Duration for next action: ";
        val_10 = val_1.Length;
        val_9[1] = this.<duration>5__2;
        val_10 = val_1.Length;
        val_9[2] = " - action: ";
        val_9[3] = val_8.GetType();
        UnityEngine.Debug.Log(message:  +val_1);
        UnityEngine.WaitForSeconds val_4 = null;
        val_8 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  this.<duration>5__2);
        val_11 = 1;
        this.<>2__current = val_8;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        object[] val_5 = new object[4];
        val_9 = val_5;
        val_9[0] = "Duration completed: ";
        val_12 = val_5.Length;
        val_9[1] = this.<duration>5__2;
        val_12 = val_5.Length;
        val_9[2] = " - action: ";
        val_9[3] = val_8.GetType();
        UnityEngine.Debug.Log(message:  +val_5);
        label_2:
        val_11 = 0;
        return (bool)val_11;
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
