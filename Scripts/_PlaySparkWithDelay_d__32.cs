using UnityEngine;
private sealed class DynamiteBoxItemView.<PlaySparkWithDelay>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView <>4__this;
    public int dynamiteIndex;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamiteBoxItemView.<PlaySparkWithDelay>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView val_9;
        int val_10;
        val_9 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        int val_9 = this.dynamiteIndex;
        var val_1 = (val_9 < 0) ? (val_9 + 1) : (val_9);
        val_1 = val_1 & 4294967294;
        val_9 = val_9 - val_1;
        var val_2 = (val_9 == 1) ? 1 : 0;
        UnityEngine.WaitForSeconds val_3 = null;
        val_9 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  36597280 + this.dynamiteIndex == 1 ? 1 : 0);
        val_10 = 1;
        this.<>2__current = val_9;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        UnityEngine.SpriteRenderer val_10 = this.<>4__this.wicks[this.dynamiteIndex];
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  val_10);
        val_9 = val_9.PlaySparks(wickParent:  val_10.transform.parent, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295});
        val_10 = 0;
        this.<>4__this.sparkParticles[this.dynamiteIndex] = val_9;
        return (bool)val_10;
        label_2:
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
