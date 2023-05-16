using UnityEngine;
private sealed class Area04SandboxView.<UpdateForAnimation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area04.Tasks.DogHouse.Area04SandboxView <>4__this;
    private UnityEngine.AnimatorStateInfo <stateInfo>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area04SandboxView.<UpdateForAnimation>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AnimatorStateInfo val_3;
        float val_4;
        UnityEngine.AnimatorStateInfo val_5;
        UnityEngine.AnimatorStateInfo val_9;
        var val_10;
        int val_11;
        if(((this.<>1__state) - 2) < 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.AnimatorStateInfo val_2 = this.<>4__this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_9 = this.<stateInfo>5__2;
        mem[1152921519756997480] = val_3;
        mem[1152921519756997464] = val_4;
        this.<stateInfo>5__2 = val_5;
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_4, b:  0f, precision:  0.001f)) == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_0:
        val_9 = this.<stateInfo>5__2;
        this.<>1__state = 0;
        label_6:
        if(S0 <= 1f)
        {
            goto label_8;
        }
        
        this.<>4__this.CompleteAnimation();
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_8:
        UnityEngine.AnimatorStateInfo val_7 = this.<>4__this.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_9 = val_3;
        val_9 = val_5;
        val_9 = val_4;
        this.<>4__this.SetDissolveValue(dissolveValue:  this.<>4__this.elapsed);
        this.<>2__current = 0;
        val_11 = 3;
        goto label_11;
        label_1:
        val_11 = 2;
        this.<>2__current = 0;
        label_11:
        this.<>1__state = val_11;
        val_10 = 1;
        return (bool)val_10;
        label_5:
        this.<>2__current = 0;
        this.<>1__state = 1;
        return (bool)val_10;
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
