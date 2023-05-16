using UnityEngine;
private sealed class SoilItemView.<RecycleCoroutine>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SoilItemView.<RecycleCoroutine>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if((this.<>1__state) == 2)
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
        this.<i>5__2 = 0;
        goto label_4;
        label_1:
        int val_1 = this.<i>5__2;
        this.<>1__state = 0;
        val_1 = val_1 + 1;
        this.<i>5__2 = val_1;
        if(val_1 >= 5)
        {
                this.<>4__this.HideSpritesInCellBounds();
            this.<>2__current = 0;
            this.<>1__state = 2;
            val_1 = 1;
            return (bool)val_1;
        }
        
        label_4:
        val_1 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_1;
        return (bool)val_1;
        label_0:
        this.<>1__state = 0;
        this.<>4__this.RecycleDelayed();
        label_2:
        val_1 = 0;
        return (bool)val_1;
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
