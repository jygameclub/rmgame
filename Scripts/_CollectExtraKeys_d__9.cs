using UnityEngine;
private sealed class PlayRoyalPassCollectAnimation.<CollectExtraKeys>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int count;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCollectAnimation <>4__this;
    private UnityEngine.WaitForSeconds <delay>5__2;
    private Royal.Infrastructure.Utils.Randoming.RandomManager <random>5__3;
    private int <maxCount>5__4;
    private int <i>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayRoyalPassCollectAnimation.<CollectExtraKeys>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_14;
        int val_15;
        var val_17;
        System.Delegate val_18;
        int val_19;
        int val_20;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_17;
        }
        
        this.<>1__state = 0;
        this.<delay>5__2 = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.<random>5__3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        int val_3 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCollectAnimation.GetMaximumCountForAnimation(count:  this.count);
        val_14 = val_3;
        val_15 = 0;
        this.<maxCount>5__4 = val_3;
        this.<i>5__5 = 0;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        int val_13 = this.<maxCount>5__4;
        val_17 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.RoyalPassCollect.RoyalPassCollectAnimation>(path:  "RoyalPassCollectAnimation"));
        val_13 = val_13 - 2;
        if((this.<i>5__5) == val_13)
        {
                val_18 = this.count + 1;
        }
        else
        {
                val_18 = 0;
        }
        
        int val_14 = this.<i>5__5;
        val_14 = val_14 + 1;
        val_14 = this.<maxCount>5__4;
        val_19 = this.<i>5__5;
        if(val_19 == (val_14 - 1))
        {
                val_17 = val_17.Play(amount:  0, xOffset:  this.<random>5__3.SymmetricNext(min:  0.1f, max:  0.3f), yOffset:  this.<random>5__3.SymmetricNext(min:  0.1f, max:  0.3f), shouldPlayParticles:  (val_14 == (this.<maxCount>5__4)) ? 1 : 0);
            System.Delegate val_12 = System.Delegate.Combine(a:  val_18, b:  new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.PlayRoyalPassCollectAnimation::AnimateIcon()));
            if(val_12 != null)
        {
                if(null != null)
        {
            goto label_16;
        }
        
        }
        
            val_17 = val_12;
            val_14 = this.<maxCount>5__4;
            val_19 = this.<i>5__5;
        }
        
        val_15 = val_19 + 1;
        this.<i>5__5 = val_15;
        label_5:
        if(val_15 < val_14)
        {
                val_20 = 1;
            this.<>1__state = val_20;
            this.<>2__current = this.<delay>5__2;
            return (bool)val_20;
        }
        
        label_17:
        val_20 = 0;
        return (bool)val_20;
        label_16:
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
