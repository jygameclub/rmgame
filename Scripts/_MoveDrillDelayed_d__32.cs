using UnityEngine;
private sealed class DrillItemView.<MoveDrillDelayed>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool haveWaited;
    public Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    public Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnPath;
    public Royal.Scenes.Game.Mechanics.Matches.Cell14 cellsOnDrill;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DrillItemView.<MoveDrillDelayed>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView val_6;
        int val_7;
        val_6 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(this.haveWaited == false)
        {
            goto label_3;
        }
        
        if(val_6 != null)
        {
            goto label_7;
        }
        
        label_1:
        this.<>1__state = 0;
        label_3:
        if((this.<>4__this.playingStartAnimation) != false)
        {
                val_7 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        label_7:
        this.<>4__this.counter.FadeOutCountText();
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDrillAnimationSorting();
        val_6.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
        Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles val_3 = val_6.CreateDrillTracerParticles();
        val_6 = this.<>4__this.viewDelegate;
        var val_5 = 0;
        if(mem[1152921505103314944] != null)
        {
                val_5 = val_5 + 1;
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.DrillItem.View.IDrillItemViewDelegate val_4 = 1152921505103278080 + ((mem[1152921505103314952]) << 4);
        }
        
        val_6.FinalExplode();
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
