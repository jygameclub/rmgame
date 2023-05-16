using UnityEngine;
private sealed class DynamiteBoxItemView.<ExplodeWithDelay>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamiteBoxItemView.<ExplodeWithDelay>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.IDynamiteBoxItemDelegate val_4;
        int val_5;
        val_4 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_5 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = val_5;
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.dynamiteBoxAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteBoxExplode, layer:  0, normalizedTime:  0f);
        this.<>4__this.dynamiteBoxAnimator.PlaySfx(type:  108, offset:  0.04f);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = 2;
        val_5 = 1;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        val_4 = this.<>4__this.viewDelegate;
        var val_4 = 0;
        if(mem[1152921505102143488] != null)
        {
                val_4 = val_4 + 1;
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.IDynamiteBoxItemDelegate val_3 = 1152921505102106624 + ((mem[1152921505102143496]) << 4);
        }
        
        val_4.Explode();
        val_4.PlaySfx(type:  109, offset:  0.04f);
        label_3:
        val_5 = 0;
        return (bool)val_5;
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
