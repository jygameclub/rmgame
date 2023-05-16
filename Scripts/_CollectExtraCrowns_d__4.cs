using UnityEngine;
private sealed class LeagueCrownCollectAction.<CollectExtraCrowns>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int count;
    private UnityEngine.WaitForSeconds <delay>5__2;
    private Royal.Infrastructure.Utils.Randoming.RandomManager <random>5__3;
    private int <maxAnimationCount>5__4;
    private int <i>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeagueCrownCollectAction.<CollectExtraCrowns>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        int val_12;
        var val_13;
        int val_14;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_13;
        }
        
        this.<>1__state = 0;
        this.<delay>5__2 = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.<random>5__3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        val_11 = this.count;
        val_12 = 0;
        this.<maxAnimationCount>5__4 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectAction.GetMaximumCountForAnimation(count:  val_11);
        this.<i>5__5 = 0;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        int val_10 = this.<maxAnimationCount>5__4;
        val_10 = val_10 - 2;
        if((this.<i>5__5) == val_10)
        {
                val_13 = this.count + 1;
        }
        else
        {
                val_13 = 0;
        }
        
        int val_11 = this.<i>5__5;
        val_11 = val_11 + 1;
        float val_9 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView>(path:  "LeagueCrownCollect")).Play(index:  this.<i>5__5, amount:  0, xOffset:  this.<random>5__3.SymmetricNext(min:  0.1f, max:  0.5f), yOffset:  this.<random>5__3.SymmetricNext(min:  0.1f, max:  0.4f), playInitialParticle:  false, playFinalParticle:  (val_11 == (this.<maxAnimationCount>5__4)) ? 1 : 0);
        val_11 = this.<maxAnimationCount>5__4;
        val_12 = (this.<i>5__5) + 1;
        this.<i>5__5 = val_12;
        label_5:
        if(val_12 < val_11)
        {
                val_14 = 1;
            this.<>1__state = val_14;
            this.<>2__current = this.<delay>5__2;
            return (bool)val_14;
        }
        
        label_13:
        val_14 = 0;
        return (bool)val_14;
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
