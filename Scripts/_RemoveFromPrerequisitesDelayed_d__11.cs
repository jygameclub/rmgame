using UnityEngine;
private sealed class FlowerPotItemModel.<RemoveFromPrerequisitesDelayed>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.FlowerPotItemModel <>4__this;
    public int createdGrassCount;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FlowerPotItemModel.<RemoveFromPrerequisitesDelayed>d__11(int <>1__state)
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
            goto label_8;
        }
        
        this.<>1__state = 0;
        val_3 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.2f);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        39499.RemoveFromPrerequisite(goalType:  30);
        int val_2 = 39499.GetGoalLeftCount(goalType:  29);
        if((val_2 == 0) && (this.createdGrassCount == 0))
        {
                val_2.ForceUpdateGoal(goalType:  30);
        }
        
        label_8:
        val_3 = 0;
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
