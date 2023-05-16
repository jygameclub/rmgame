using UnityEngine;
private sealed class DynamiteBoxItemView.<DamageWithDelay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool isNearMatch;
    public Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView <>4__this;
    public int dynamiteIndex;
    public int layer;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamiteBoxItemView.<DamageWithDelay>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        var val_13;
        var val_14;
        int val_15;
        var val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        var val_1 = (this.isNearMatch == false) ? 1 : 0;
        val_12 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  36532592 + this.isNearMatch == false ? 1 : 0);
        this.<>1__state = val_12;
        return (bool)val_12;
        label_1:
        this.<>1__state = 0;
        X21.PlaySfx(type:  X21.SelectRandomClip(from:  104, to:  105), offset:  0.04f);
        int val_13 = this.dynamiteIndex;
        UnityEngine.Animator val_12 = this.<>4__this.dynamiteAnimators[val_13];
        val_13 = null;
        val_13 = val_13 - (((val_13 < 0) ? (val_13 + 1) : (val_13)) & 4294967294);
        if(val_13 != 1)
        {
            goto label_8;
        }
        
        val_14 = null;
        val_15 = 1152921505102270480;
        if(val_12 != null)
        {
            goto label_11;
        }
        
        label_8:
        val_16 = null;
        val_15 = 1152921505102270496;
        label_11:
        val_12.Play(stateNameHash:  val_15, layer:  0, normalizedTime:  0f);
        UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.PlaySparkWithDelay(dynamiteIndex:  this.dynamiteIndex));
        val_12 = 0;
        if(this.layer != 0)
        {
                return (bool)val_12;
        }
        
        this.<>4__this.moveManager.CompleteMoveByType(moveType:  2);
        UnityEngine.Coroutine val_9 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.ExplodeWithDelay());
        UnityEngine.Coroutine val_11 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.PlayBigParticles());
        label_2:
        val_12 = 0;
        return (bool)val_12;
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
