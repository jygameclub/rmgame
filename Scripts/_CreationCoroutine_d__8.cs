using UnityEngine;
private sealed class PlayShopRewardItemAnimationAction.<CreationCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Player.Context.Data.Session.AnimationData animationData;
    public Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.PlayShopRewardItemAnimationAction <>4__this;
    private int <count>5__2;
    private int <boosterCount>5__3;
    private int <boosterTypeCount>5__4;
    private int <unlimitedBoosterMin>5__5;
    private int <unlimitedCount>5__6;
    private System.Collections.Generic.IEnumerator<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> <>7__wrap6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayShopRewardItemAnimationAction.<CreationCoroutine>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.<>1__state;
        val_1 = val_1 + 4;
        if(val_1 > 6)
        {
                return;
        }
        
        var val_2 = 36597736 + ((this.<>1__state + 4)) << 2;
        val_2 = val_2 + 36597736;
        goto (36597736 + ((this.<>1__state + 4)) << 2 + 36597736);
    }
    private bool MoveNext()
    {
        Royal.Player.Context.Data.Session.AnimationData val_21;
        var val_22;
        System.Collections.Generic.IEnumerator<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_23;
        System.Collections.Generic.IEnumerator<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_24;
        System.Collections.Generic.IEnumerable<T> val_25;
        var val_26;
        System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_28;
        var val_30;
        var val_33;
        var val_34;
        System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_36;
        var val_37;
        int val_39;
        var val_41;
        val_21 = 39128;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 2)
        {
            goto label_93;
        }
        
        val_22 = this;
        val_23 = this.<>7__wrap6;
        goto label_4;
        label_2:
        val_22 = this;
        val_24 = this.<>7__wrap6;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        this.<count>5__2 = 0;
        if(this.animationData == null)
        {
                throw new NullReferenceException();
        }
        
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_1 = null;
        val_25 = this.animationData.boosters;
        val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(collection:  val_25);
        if(this.animationData == null)
        {
                throw new NullReferenceException();
        }
        
        this.<boosterCount>5__3 = this.animationData.boosterCount;
        val_26 = null;
        val_26 = null;
        val_28 = PlayShopRewardItemAnimationAction.<>c.<>9__8_0;
        if(val_28 == null)
        {
                System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_2 = null;
            val_28 = val_2;
            val_2 = new System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(object:  PlayShopRewardItemAnimationAction.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PlayShopRewardItemAnimationAction.<>c::<CreationCoroutine>b__8_0(Royal.Scenes.Game.Mechanics.Boosters.BoosterType b));
            PlayShopRewardItemAnimationAction.<>c.<>9__8_0 = val_28;
        }
        
        val_30 = public static System.Linq.IOrderedEnumerable<TSource> System.Linq.Enumerable::OrderByDescending<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector);
        System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderByDescending<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(source:  val_1, keySelector:  val_2);
        val_25 = public static System.Int32 System.Linq.Enumerable::Count<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(System.Collections.Generic.IEnumerable<TSource> source);
        this.<boosterTypeCount>5__4 = System.Linq.Enumerable.Count<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(source:  val_3);
        if(val_3 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_25 = 0;
        if(mem[1152921504767746048] != null)
        {
                val_25 = val_25 + 1;
            val_30 = 0;
        }
        else
        {
                System.Linq.IOrderedEnumerable<TSource> val_5 = 1152921504767709184 + ((mem[1152921504767746056]) << 4);
        }
        
        val_25 = public System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>::GetEnumerator();
        val_21 = val_3;
        System.Collections.Generic.IEnumerator<T> val_6 = val_21.GetEnumerator();
        val_22 = this;
        val_24 = val_6;
        this.<>7__wrap6 = val_6;
        label_5:
        this.<>1__state = -3;
        if(val_24 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_26 = 0;
        if(mem[1152921504684732416] != null)
        {
                val_26 = val_26 + 1;
            val_30 = 0;
        }
        else
        {
                System.Collections.Generic.IEnumerator<T> val_7 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
        }
        
        val_25 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        val_21 = val_24;
        if(val_21.MoveNext() == false)
        {
            goto label_23;
        }
        
        if((this.<>7__wrap6) == null)
        {
                throw new NullReferenceException();
        }
        
        var val_30 = mem[val_6];
        if((mem[val_6] + 294) == 0)
        {
            goto label_25;
        }
        
        var val_27 = mem[val_6] + 176;
        var val_28 = 0;
        val_27 = val_27 + 8;
        label_27:
        if(((mem[val_6] + 176 + 8) + -8) == null)
        {
            goto label_26;
        }
        
        val_28 = val_28 + 1;
        val_27 = val_27 + 16;
        if(val_28 < (mem[val_6] + 294))
        {
            goto label_27;
        }
        
        label_25:
        val_30 = 0;
        goto label_28;
        label_23:
        val_21 = this;
        this.<>m__Finally1();
        this.<>7__wrap6 = 0;
        if(this.animationData == null)
        {
                throw new NullReferenceException();
        }
        
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType> val_9 = null;
        val_25 = this.animationData.unlimitedBoosters;
        val_9 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(collection:  val_25);
        if(this.animationData == null)
        {
                throw new NullReferenceException();
        }
        
        this.<unlimitedBoosterMin>5__5 = this.animationData.boosterMinutes;
        val_34 = null;
        val_34 = null;
        val_36 = PlayShopRewardItemAnimationAction.<>c.<>9__8_1;
        if(val_36 == null)
        {
                System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32> val_10 = null;
            val_36 = val_10;
            val_10 = new System.Func<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(object:  PlayShopRewardItemAnimationAction.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PlayShopRewardItemAnimationAction.<>c::<CreationCoroutine>b__8_1(Royal.Scenes.Game.Mechanics.Boosters.BoosterType b));
            PlayShopRewardItemAnimationAction.<>c.<>9__8_1 = val_36;
        }
        
        val_37 = public static System.Linq.IOrderedEnumerable<TSource> System.Linq.Enumerable::OrderByDescending<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector);
        System.Linq.IOrderedEnumerable<TSource> val_11 = System.Linq.Enumerable.OrderByDescending<Royal.Scenes.Game.Mechanics.Boosters.BoosterType, System.Int32>(source:  val_9, keySelector:  val_10);
        this.<unlimitedCount>5__6 = System.Linq.Enumerable.Count<Royal.Scenes.Game.Mechanics.Boosters.BoosterType>(source:  val_11);
        var val_29 = 0;
        if(mem[1152921504767746048] == null)
        {
            goto label_38;
        }
        
        val_29 = val_29 + 1;
        val_37 = 0;
        goto label_40;
        label_26:
        val_30 = val_30 + (((mem[val_6] + 176 + 8)) << 4);
        val_33 = val_30 + 304;
        label_28:
        val_25 = public T System.Collections.Generic.IEnumerator<T>::get_Current();
        val_21 = this.<>7__wrap6;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = val_21.Current;
        UnityEngine.Vector2 val_14 = this.<>4__this.GetOffsetForCount(count:  this.<count>5__2);
        int val_15 = (this.<boosterTypeCount>5__4) + (~(this.<count>5__2));
        int val_31 = this.<count>5__2;
        val_31 = val_31 + 1;
        this.<count>5__2 = val_31;
        val_39 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.<>1__state = val_39;
        return (bool)val_39;
        label_38:
        System.Linq.IOrderedEnumerable<TSource> val_17 = 1152921504767709184 + ((mem[1152921504767746056]) << 4);
        label_40:
        val_25 = public System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>::GetEnumerator();
        val_21 = val_11;
        System.Collections.Generic.IEnumerator<T> val_18 = val_21.GetEnumerator();
        val_23 = val_18;
        this.<>7__wrap6 = val_18;
        label_4:
        this.<>1__state = -4;
        if(val_23 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_32 = 0;
        if(mem[1152921504684732416] != null)
        {
                val_32 = val_32 + 1;
            val_37 = 0;
        }
        else
        {
                System.Collections.Generic.IEnumerator<T> val_19 = 1152921504684695552 + ((mem[1152921504684732424]) << 4);
        }
        
        val_25 = public System.Boolean System.Collections.IEnumerator::MoveNext();
        val_21 = val_23;
        if(val_21.MoveNext() == false)
        {
            goto label_48;
        }
        
        if((this.<>7__wrap6) == null)
        {
                throw new NullReferenceException();
        }
        
        var val_35 = mem[val_18];
        if((mem[val_18] + 294) == 0)
        {
            goto label_50;
        }
        
        var val_33 = mem[val_18] + 176;
        var val_34 = 0;
        val_33 = val_33 + 8;
        label_52:
        if(((mem[val_18] + 176 + 8) + -8) == null)
        {
            goto label_51;
        }
        
        val_34 = val_34 + 1;
        val_33 = val_33 + 16;
        if(val_34 < (mem[val_18] + 294))
        {
            goto label_52;
        }
        
        label_50:
        val_37 = 0;
        goto label_53;
        label_48:
        this.<>m__Finally2();
        val_21 = this.animationData;
        this.<>7__wrap6 = 0;
        if(val_21 == null)
        {
                throw new NullReferenceException();
        }
        
        val_21.ConsumeBoosters();
        label_93:
        val_39 = 0;
        return (bool)val_39;
        label_51:
        val_35 = val_35 + (((mem[val_18] + 176 + 8)) << 4);
        val_41 = val_35 + 304;
        label_53:
        val_25 = public T System.Collections.Generic.IEnumerator<T>::get_Current();
        val_21 = this.<>7__wrap6;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = val_21.Current;
        UnityEngine.Vector2 val_22 = this.<>4__this.GetOffsetForCount(count:  this.<count>5__2);
        int val_36 = this.<boosterTypeCount>5__4;
        val_36 = val_36 + (~(this.<count>5__2));
        this.<>4__this.CreateUnlimitedItem(boosterType:  val_23, offset:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, minutes:  this.<unlimitedBoosterMin>5__5, count:  this.<count>5__2, delayCount:  val_36 + (this.<unlimitedCount>5__6));
        int val_37 = this.<count>5__2;
        val_37 = val_37 + 1;
        this.<count>5__2 = val_37;
        val_39 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.15f);
        this.<>1__state = 2;
        return (bool)val_39;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        if((this.<>7__wrap6) == null)
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
        
        this.<>7__wrap6.Dispose();
    }
    private void <>m__Finally2()
    {
        this.<>1__state = 0;
        if((this.<>7__wrap6) == null)
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
        
        this.<>7__wrap6.Dispose();
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
