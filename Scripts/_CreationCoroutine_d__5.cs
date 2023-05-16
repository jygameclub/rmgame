using UnityEngine;
private sealed class PlayBoosterUnlockAnimationAction.<CreationCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayBoosterUnlockAnimationAction <>4__this;
    private int <count>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayBoosterUnlockAnimationAction.<CreationCoroutine>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<count>5__2 = 0;
        this.<i>5__3 = 0;
        goto label_4;
        label_1:
        int val_3 = this.<i>5__3;
        this.<>1__state = 0;
        val_3 = val_3 + 1;
        this.<i>5__3 = val_3;
        if(val_3 < 3)
        {
            goto label_4;
        }
        
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_4:
        UnityEngine.Vector2 val_1 = 39126.GetOffsetForCount(count:  this.<count>5__2);
        this.<>4__this.CreateItem(offset:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, count:  this.<count>5__2);
        int val_4 = this.<count>5__2;
        val_4 = val_4 + 1;
        this.<count>5__2 = val_4;
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.<>1__state = val_3;
        return (bool)val_3;
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
