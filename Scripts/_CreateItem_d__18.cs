using UnityEngine;
private sealed class SpecialItemCreator.<CreateItem>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel model;
    public Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator <>4__this;
    public Royal.Scenes.Game.Mechanics.Matches.MatchGroup group;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpecialItemCreator.<CreateItem>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
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
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  this.delay);
        val_10 = 1;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        this.model.gameObject.SetActive(value:  true);
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSpecialItemCreationSorting(negativeOffset:  0);
        bool val_4 = val_3.sortEverything & 4294967295;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.model.CurrentCell, isReverseSort:  false);
        bool val_7 = val_6.sortEverything & 4294967295;
        this.model.SetSpecialItemActive(active:  true);
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView val_8 = this.model.GetSpecialItemView();
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = 2;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.PlayAppearParticle(specialItemTransform:  this.model.transform);
        label_3:
        val_10 = 0;
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
