using UnityEngine;
private sealed class DynamiteBoxItemModel.<ExplodeCells>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel <>4__this;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel centerCell;
    private System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> <cellByRadius>5__2;
    private int <maxDist>5__3;
    private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator <iterator>5__4;
    private Royal.Scenes.Game.Mechanics.Explode.ExplodeData <explodeData>5__5;
    private int <keyIndex>5__6;
    private float <keyDuration>5__7;
    private float <startTime>5__8;
    private System.Collections.Generic.SortedDictionary.KeyCollection.Enumerator<int, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> <>7__wrap8;
    private int <key>5__10;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamiteBoxItemModel.<ExplodeCells>d__26(int <>1__state)
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
        float val_2;
        float val_3;
        var val_6;
        Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_7;
        var val_23;
        var val_35;
        var val_36;
        Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView val_37;
        int val_38;
        var val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        var val_47;
        int val_48;
        int val_49;
        var val_50;
        var val_51;
        val_35 = this;
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_15 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_36 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_49;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        val_37 = 0;
        Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_1 = Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig.BallBallConfig;
        if(==0)
        {
                throw new NullReferenceException();
        }
        
        ShakeGrid(config:  new Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig() {delay = val_3, duration = val_3, minVibrate = val_3, midVibrate = val_3, maxVibrate = val_2, shouldScale = val_2, shouldVisitCenter = val_2});
        System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> val_4 = null;
        val_38 = public System.Void System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>::.ctor();
        val_4 = new System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>();
        this.<cellByRadius>5__2 = val_4;
        this.<maxDist>5__3 = 0;
        if(val_4 == null)
        {
                throw new NullReferenceException();
        }
        
        val_39 = 0;
        Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_5 = val_4.GetIterator(iteratorType:  0);
        mem[1152921520335146928] = val_6;
        this.<iterator>5__4 = val_7;
        val_37 = this.<iterator>5__4;
        val_38 = 0;
        if(this.centerCell == null)
        {
                throw new NullReferenceException();
        }
        
        val_37 = this.centerCell.<CellView>k__BackingField;
        if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.Vector2 val_8 = val_37.Position;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
        val_40 = val_9.x;
        val_41 = val_8.x;
        val_42 = val_8.y;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_41, y = val_42}, b:  new UnityEngine.Vector2() {x = val_40, y = val_9.y});
        val_43 = val_10.x;
        goto label_23;
        label_24:
        if(X21 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_38 = 0;
        UnityEngine.Vector3 val_11 = X21.GetViewPosition();
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_40 = val_12.x;
        val_42 = val_10.y;
        val_44 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_43, y = val_42}, b:  new UnityEngine.Vector2() {x = val_40, y = val_12.y});
        val_41 = val_44 + val_44;
        int val_14 = UnityEngine.Mathf.RoundToInt(f:  val_41);
        val_37 = this.<cellByRadius>5__2;
        if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
        bool val_16 = val_37.TryGetValue(key:  val_14, value: out  val_15);
        if(val_15 == 0)
        {
                System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_17 = null;
            val_38 = public System.Void System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>::.ctor();
            val_17 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            val_37 = this.<cellByRadius>5__2;
            if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
            val_38 = val_14;
            val_37.Add(key:  val_38, value:  val_17);
            val_37 = val_17;
            if(val_37 == 0)
        {
                throw new NullReferenceException();
        }
        
        }
        
        val_38 = mem[X21 + 24];
        val_38 = X21 + 24;
        val_17.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_38, y = val_38});
        if(val_37 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_38 = mem[X21 + 24];
        val_38 = X21 + 24;
        val_39 = 0;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_18 = val_17.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_38, y = val_38}];
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        val_18.FreezeFall();
        if(val_14 > (this.<maxDist>5__3))
        {
                this.<maxDist>5__3 = val_14;
        }
        
        label_23:
        if((this.<iterator>5__4) != 0)
        {
            goto label_24;
        }
        
        val_38 = 0;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_19 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  23);
        mem[1152921520335146952] = val_2;
        this.<explodeData>5__5 = val_3;
        if((Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField) != true)
        {
                Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField.__il2cppRuntimeField_14 = this.<explodeData>5__5.matchType;
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField = this.<explodeData>5__5.point;
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField = true;
        }
        
        this.<keyIndex>5__6 = 0;
        this.<keyDuration>5__7 = 0.04f;
        val_37 = this.<cellByRadius>5__2;
        this.<startTime>5__8 = UnityEngine.Time.time;
        if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
        val_38 = public SortedDictionary.KeyCollection<TKey, TValue> System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>::get_Keys();
        SortedDictionary.KeyCollection<TKey, TValue> val_21 = val_37.Keys;
        if(val_21 == null)
        {
                throw new NullReferenceException();
        }
        
        SortedDictionary.KeyCollection.Enumerator<TKey, TValue> val_22 = val_21.GetEnumerator();
        val_47 = 0;
        mem[1152921520335147000] = val_23;
        mem[1152921520335146984] = val_2;
        this.<>7__wrap8 = val_3;
        this.<>1__state = -3;
        goto label_94;
        label_2:
        val_47 = 0;
        val_48 = this.<key>5__10;
        this.<>1__state = -3;
        goto label_32;
        label_1:
        this.<>1__state = 0;
        label_35:
        val_38 = 0;
        if((this.<iterator>5__4) == 0)
        {
            goto label_33;
        }
        
        if((this.<iterator>5__4) == 0)
        {
                throw new NullReferenceException();
        }
        
        this.<iterator>5__4.UnFreezeFall();
        goto label_35;
        label_33:
        val_38 = public static Royal.Scenes.Game.Levels.Units.State.GameStateManager Royal.Scenes.Game.Levels.LevelContext::Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(Royal.Scenes.Game.Levels.LevelContextId contextId);
        Royal.Scenes.Game.Levels.Units.State.GameStateManager val_24 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        if(val_24 == null)
        {
                throw new NullReferenceException();
        }
        
        val_38 = 0;
        val_24.FinishSpecialOperation();
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        val_37 = this.<>4__this.moveManager;
        if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
        val_37.CompleteMoveByType(moveType:  3);
        val_49 = 0;
        return (bool)val_49;
        label_94:
        if(((this.<>7__wrap8) & 1) == 0)
        {
            goto label_82;
        }
        
        val_38 = public System.Int32 SortedDictionary.KeyCollection.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>::get_Current();
        val_50 = val_35;
        this.<key>5__10 = this.<>7__wrap8;
        val_43 = UnityEngine.Time.time - (this.<startTime>5__8);
        float val_35 = (float)this.<keyIndex>5__6;
        if(val_43 < 0)
        {
            goto label_83;
        }
        
        label_32:
        val_37 = this.<cellByRadius>5__2;
        if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
        val_38 = this.<key>5__10;
        if(val_37.Item[val_38] == null)
        {
                throw new NullReferenceException();
        }
        
        if(1152921520335092128 >= 1)
        {
                var val_33 = 0;
            do
        {
            if(val_33 >= 1152921520335092128)
        {
                val_37 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
            if(val_37 == 0)
        {
                throw new NullReferenceException();
        }
        
            val_38 = public System.Void System.Reflection.EventInfo::RemoveEventHandler(object target, System.Delegate handler);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_28 = val_37.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = -1451618912, y = 268435459}];
            var val_29 = (val_28 == 0) ? (val_47) : (val_28);
            if(val_28 != null)
        {
                val_2 = this.<explodeData>5__5.matchType;
            val_3 = this.<explodeData>5__5.point;
            if(val_29 == 0)
        {
                throw new NullReferenceException();
        }
        
            val_29.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2});
        }
        
            val_33 = val_33 + 1;
        }
        while(val_33 < val_2);
        
        }
        
        if((this.<maxDist>5__3) <= (this.<key>5__10))
        {
            goto label_94;
        }
        
        int val_34 = this.<keyIndex>5__6;
        val_34 = val_34 + 1;
        this.<keyIndex>5__6 = val_34;
        goto label_94;
        label_82:
        this.<>m__Finally1();
        this.<>7__wrap8 = 0;
        this.<>7__wrap8 = 0;
        this.<>7__wrap8 = 0;
        val_2 = Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.__il2cppRuntimeField_static_fields;
        val_3 = this.<explodeData>5__5;
        val_51 = Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField;
        if((Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_38 = val_3;
        Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField.System.IDisposable.Dispose();
        if((Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<ExplodeData>k__BackingField.Equals(obj:  val_3)) != false)
        {
                val_37 = this.centerCell;
            if(val_37 == null)
        {
                throw new NullReferenceException();
        }
        
            val_38 = 0;
            UnityEngine.Vector3 val_31 = val_37.GetViewPosition();
            val_43 = val_31.x;
            val_44 = val_31.z;
            val_37 = 41167;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
        {
                throw new NullReferenceException();
        }
        
            if(null == 0)
        {
                throw new NullReferenceException();
        }
        
            val_2 = this.<explodeData>5__5.matchType;
            val_3 = this.<explodeData>5__5.point;
            TryCollectMadnessForExploder(originPosition:  new UnityEngine.Vector3() {x = val_43, y = val_31.y, z = val_44}, explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2}, animationDelayInFrames:  0);
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField = false;
        }
        
        val_49 = 1;
        this.<>2__current = 0;
        this.<>1__state = 2;
        return (bool)val_49;
        label_83:
        Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_32 = null;
        val_35 = ((this.<keyDuration>5__7) * val_35) - val_43;
        val_32 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_35);
        val_49 = 1;
        this.<>2__current = val_32;
        this.<>1__state = val_49;
        return (bool)val_49;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
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
