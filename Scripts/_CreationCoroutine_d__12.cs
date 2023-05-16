using UnityEngine;
private sealed class PlayRewardedItemAnimationAction.<CreationCoroutine>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Player.Context.Data.Session.AnimationData animationData;
    public Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayRewardedItemAnimationAction <>4__this;
    private int <count>5__2;
    private System.Collections.Generic.IEnumerator<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> <>7__wrap2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayRewardedItemAnimationAction.<CreationCoroutine>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 3)
        {
                return;
        }
        
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        Royal.Player.Context.Data.Session.AnimationData val_9;
        var val_10;
        System.Collections.Generic.IEnumerator<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_11;
        var val_12;
        System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_14;
        System.Func<TSource, TKey> val_15;
        var val_18;
        int val_19;
        val_9 = 39123;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
            goto label_47;
        }
        
        val_10 = this;
        val_11 = this.<>7__wrap2;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        this.<count>5__2 = 0;
        if(this.animationData == null)
        {
                throw new NullReferenceException();
        }
        
        val_12 = null;
        val_12 = null;
        val_14 = PlayRewardedItemAnimationAction.<>c.<>9__12_0;
        if(val_14 == null)
        {
                System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_2 = null;
            val_14 = val_2;
            val_2 = new System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(object:  PlayRewardedItemAnimationAction.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PlayRewardedItemAnimationAction.<>c::<CreationCoroutine>b__12_0(Royal.Scenes.Game.Mechanics.Boosters.BoosterType b));
            PlayRewardedItemAnimationAction.<>c.<>9__12_0 = val_14;
        }
        
        val_15 = val_14;
        System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderByDescending<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(source:  new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(collection:  this.animationData.boosters), keySelector:  val_2);
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_11 = 0;
        if(mem[1152921504767746048] != null)
        {
                val_11 = val_11 + 1;
        }
        else
        {
                System.Linq.IOrderedEnumerable<TSource> val_4 = 1152921504767709184 + ((mem[1152921504767746056]) << 4);
        }
        
        val_15 = public System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>::GetEnumerator();
        val_9 = val_3;
        System.Collections.Generic.IEnumerator<T> val_5 = val_9.GetEnumerator();
        val_10 = this;
        val_11 = val_5;
        this.<>7__wrap2 = val_5;
        label_3:
        this.<>1__state = -3;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_12 = 0;
        if(mem[1152921504684732416] != null)
        {
                val_12 = val_12 + 1;
        }
        else
        {
                System.Collections.Generic.IEnumerator<T> val_6 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
        }
        
        val_15 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        val_9 = val_11;
        if(val_9.MoveNext() == false)
        {
            goto label_20;
        }
        
        if((this.<>7__wrap2) == null)
        {
                throw new NullReferenceException();
        }
        
        var val_15 = mem[val_5];
        if((mem[val_5] + 294) == 0)
        {
            goto label_25;
        }
        
        var val_13 = mem[val_5] + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_24:
        if(((mem[val_5] + 176 + 8) + -8) == null)
        {
            goto label_23;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (mem[val_5] + 294))
        {
            goto label_24;
        }
        
        goto label_25;
        label_20:
        this.<>m__Finally1();
        val_9 = this.animationData;
        this.<>7__wrap2 = 0;
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        val_9.ConsumeBoosters();
        label_47:
        val_19 = 0;
        return (bool)val_19;
        label_23:
        val_15 = val_15 + (((mem[val_5] + 176 + 8)) << 4);
        val_18 = val_15 + 304;
        label_25:
        T val_8 = this.<>7__wrap2.Current;
        UnityEngine.Vector2 val_9 = val_8.GetOffsetForCount(count:  this.<count>5__2);
        val_8.CreateItem(boosterType:  val_8, offset:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, count:  this.<count>5__2);
        int val_16 = this.<count>5__2;
        val_16 = val_16 + 1;
        this.<count>5__2 = val_16;
        val_19 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.<>1__state = val_19;
        return (bool)val_19;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<>7__wrap2) == null)
        {
                return;
        }
        
        var val_2 = 0;
        if(mem[1152921504684732416] != null)
        {
                val_2 = val_2 + 1;
        }
        else
        {
                System.Collections.Generic.IEnumerator<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_1 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
        }
        
        this.<>7__wrap2.Dispose();
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
