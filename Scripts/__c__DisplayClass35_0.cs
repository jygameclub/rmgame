using UnityEngine;
private sealed class Area03ServingsView.<>c__DisplayClass35_0
{
    // Fields
    public Royal.Scenes.Home.Areas.Area03.Tasks.Servings.Area03ServingsView <>4__this;
    public UnityEngine.Vector3 foodInitialPos;
    public DG.Tweening.TweenCallback <>9__3;
    
    // Methods
    public Area03ServingsView.<>c__DisplayClass35_0()
    {
    
    }
    internal void <PlayCart>b__0()
    {
        this.<>4__this.cart.SetActive(value:  true);
    }
    internal void <PlayCart>b__1()
    {
        this.<>4__this.food.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.food.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  this.<>4__this.foodScaleDuration), ease:  this.<>4__this.foodScaler);
    }
    internal void <PlayCart>b__2()
    {
        DG.Tweening.TweenCallback val_6 = this.<>9__3;
        if(val_6 == null)
        {
                DG.Tweening.TweenCallback val_4 = null;
            val_6 = val_4;
            val_4 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void Area03ServingsView.<>c__DisplayClass35_0::<PlayCart>b__3());
            this.<>9__3 = val_6;
        }
        
        System.Delegate val_5 = System.Delegate.Combine(a:  X21, b:  val_4);
        if(val_5 != null)
        {
                if(null != val_6)
        {
            goto label_8;
        }
        
        }
        
        DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>4__this.food.transform, endValue:  new UnityEngine.Vector3() {x = this.foodInitialPos}, duration:  this.<>4__this.foodDuration, snapping:  false), ease:  this.<>4__this.foodmover) = val_5;
        return;
        label_8:
    }
    internal void <PlayCart>b__3()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(spriteRenderer:  this.<>4__this.food, xScale:  1.1f, yScale:  0.9f);
            return;
        }
        
        throw new NullReferenceException();
    }

}
