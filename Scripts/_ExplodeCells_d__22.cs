using UnityEngine;
private sealed class BallBallCombo.<ExplodeCells>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo <>4__this;
    private int <maxDist>5__2;
    private System.Collections.Generic.SortedDictionary.KeyCollection.Enumerator<int, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> <>7__wrap2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BallBallCombo.<ExplodeCells>d__22(int <>1__state)
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
        Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo val_8;
        Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo val_9;
        Royal.Scenes.Game.Mechanics.Matches.MatchType val_12;
        var val_13;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_14;
        int val_24;
        BallBallCombo.<ExplodeCells>d__22 val_25;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_26;
        Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo val_27;
        int val_28;
        int val_29;
        Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_30;
        System.Collections.Generic.SortedDictionary<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> val_31;
        Royal.Scenes.Game.Levels.Units.CellGridManager val_32;
        var val_33;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_35;
        SortedDictionary.KeyCollection.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>> val_36;
        float val_38;
        var val_39;
        int val_40;
        val_25 = this;
        val_26 = 39212;
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_3 = 0;
        val_27 = this.<>4__this;
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
            goto label_109;
        }
        
        this.<>1__state = 0;
        if(val_27 == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = this.<>4__this.cellTo;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_28 = 0;
        val_26.UnFreezeFall();
        val_26 = this.<>4__this.cellFrom;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_26.UnFreezeFall();
        val_29 = val_25;
        this.<maxDist>5__2 = 0;
        val_30 = this.<>4__this.iterator;
        val_31 = this.<>4__this.cellByRadius;
        val_32 = this.<>4__this.gridManager;
        goto label_19;
        label_20:
        if((this.<>4__this.cellFrom) == null)
        {
                throw new NullReferenceException();
        }
        
        if(X23 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_28 = mem[X23 + 24];
        val_28 = X23 + 24;
        int val_2 = UnityEngine.Mathf.RoundToInt(f:  V0.16B + V0.16B);
        val_26 = mem[this.<>4__this.cellByRadius];
        val_26 = this.<>4__this.cellByRadius._set;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        bool val_4 = val_26.TryGetValue(key:  val_2, value: out  val_3);
        val_26 = val_3;
        if(val_26 == 0)
        {
                System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_5 = null;
            val_28 = public System.Void System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>::.ctor();
            val_5 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>();
            val_26 = mem[this.<>4__this.cellByRadius];
            val_26 = this.<>4__this.cellByRadius._set;
            if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
            val_28 = val_2;
            val_26.Add(key:  val_28, value:  val_5);
            val_26 = val_5;
            val_30 = val_30;
            val_29 = 1152921524111001208;
            val_27 = val_27;
            if(val_26 == 0)
        {
                throw new NullReferenceException();
        }
        
        }
        
        val_28 = mem[X23 + 24];
        val_28 = X23 + 24;
        val_5.Add(item:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_28, y = val_28});
        if((mem[this.<>4__this.gridManager]) == 0)
        {
                throw new NullReferenceException();
        }
        
        val_26 = mem[mem[this.<>4__this.gridManager] + 40];
        val_26 = mem[this.<>4__this.gridManager] + 40;
        if(val_26 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_28 = mem[X23 + 24];
        val_28 = X23 + 24;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = val_26.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_28, y = val_28});
        if(val_6 == null)
        {
                throw new NullReferenceException();
        }
        
        val_6.FreezeFall();
        if(val_2 > (this.<maxDist>5__2))
        {
                mem[1152921524111001208] = val_2;
        }
        
        label_19:
        if(val_30 != 0)
        {
            goto label_20;
        }
        
        val_27 = 1;
        val_28 = 0;
        Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_7 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  16);
        val_26 = mem[this.<>4__this + 80];
        val_26 = this.<>4__this + 80;
        val_27 = val_8;
        val_27 = val_9;
        if(val_26 == 0)
        {
                throw new NullReferenceException();
        }
        
        SortedDictionary.KeyCollection.Enumerator<TKey, TValue> val_11 = val_26.Keys.GetEnumerator();
        val_35 = val_27 + 92;
        val_36 = 1152921524111001216;
        mem[1152921524111001232] = val_12;
        mem[1152921524111001248] = val_13;
        mem[1152921524111001216] = val_14;
        this.<>1__state = -3;
        goto label_23;
        label_2:
        val_36 = this.<>7__wrap2;
        val_31 = this.<>4__this.cellByRadius;
        val_32 = this.<>4__this.gridManager;
        val_35 = this.<>4__this.<ExplodeData>k__BackingField;
        val_29 = this.<maxDist>5__2;
        this.<>1__state = -3;
        label_23:
        label_35:
        val_28 = public System.Boolean SortedDictionary.KeyCollection.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>::MoveNext();
        if((val_36 & 1) == 0)
        {
            goto label_24;
        }
        
        val_28 = public System.Int32 SortedDictionary.KeyCollection.Enumerator<System.Int32, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint>>::get_Current();
        val_26 = val_36;
        if(val_27 == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = mem[this.<>4__this.cellByRadius];
        val_26 = this.<>4__this.cellByRadius._set;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_28 = val_26;
        System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint> val_15 = val_26.Item[val_28];
        val_33 = val_15;
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        if(1152921520335092128 >= 1)
        {
                var val_23 = 0;
            do
        {
            if(val_23 >= 1152921520335092128)
        {
                val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_22 = mem[this.<>4__this.gridManager];
            if(val_22 == 0)
        {
                throw new NullReferenceException();
        }
        
            val_26 = mem[mem[this.<>4__this.gridManager] + 40];
            val_26 = mem[this.<>4__this.gridManager] + 40;
            if(val_26 == 0)
        {
                throw new NullReferenceException();
        }
        
            val_22 = val_22 + 0;
            val_28 = mem[(mem[this.<>4__this.gridManager] + 0) + 32];
            val_28 = (mem[this.<>4__this.gridManager] + 0) + 32;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_16 = val_26.GetCell(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_28, y = val_28});
            var val_17 = (val_16 == 0) ? 0 : (val_16);
            if(val_16 != null)
        {
                val_12 = this.<>4__this.<ExplodeData>k__BackingField.matchType;
            val_14 = this.<>4__this.<ExplodeData>k__BackingField.point;
            if(val_17 == 0)
        {
                throw new NullReferenceException();
        }
        
            val_17.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_14, y = val_14}, trigger = val_14, id = val_12});
        }
        
            val_23 = val_23 + 1;
        }
        while(val_23 < val_12);
        
        }
        
        if(val_29 <= val_26)
        {
            goto label_35;
        }
        
        float val_24 = 0.01f;
        float val_25 = (float)val_26;
        val_24 = val_25 * val_24;
        val_25 = val_24 * val_25;
        val_25 = val_25;
        val_38 = UnityEngine.Mathf.Min(a:  1.5f, b:  val_25);
        val_39 = null;
        val_39 = null;
        val_24 = Royal.Scenes.Game.Levels.Units.Combo.BallBallCombo.ExplosionSpeed;
        Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_19 = null;
        float val_26 = 6f;
        val_26 = val_26 - val_38;
        val_26 = val_26 / (float)val_24;
        val_19 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_26);
        val_40 = 1;
        mem[1152921524111001192] = val_19;
        this.<>1__state = val_40;
        return (bool)val_40;
        label_24:
        val_25 = val_25;
        val_26 = val_25;
        this.<>m__Finally1();
        val_36 = 0;
        val_36 = 0;
        val_36 = 0;
        if(val_27 == null)
        {
                throw new NullReferenceException();
        }
        
        val_26 = this.<>4__this.cellFrom;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_28 = 0;
        UnityEngine.Vector3 val_20 = val_26.GetViewPosition();
        val_38 = val_20.x;
        val_26 = 41163;
        if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField) == null)
        {
                throw new NullReferenceException();
        }
        
        if(null == 0)
        {
                throw new NullReferenceException();
        }
        
        val_12 = this.<>4__this.<ExplodeData>k__BackingField.matchType;
        val_14 = this.<>4__this.<ExplodeData>k__BackingField.point;
        if(Royal.Player.Context.Data.Session == null)
        {
                throw new NullReferenceException();
        }
        
        TryCollectMadnessForExploder(originPosition:  new UnityEngine.Vector3() {x = val_38, y = val_20.y, z = val_20.z}, explodeData:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_14, y = val_14}, trigger = val_14, id = val_12}, animationDelayInFrames:  0);
        val_40 = 1;
        val_27 = 0;
        mem[1152921524111001192] = 0;
        this.<>1__state = 2;
        return (bool)val_40;
        label_1:
        this.<>1__state = 0;
        if(val_27 == null)
        {
                throw new NullReferenceException();
        }
        
        label_51:
        val_28 = 0;
        if((this.<>4__this.iterator) == 0)
        {
            goto label_49;
        }
        
        if((this.<>4__this.iterator) == 0)
        {
                throw new NullReferenceException();
        }
        
        this.<>4__this.iterator.UnFreezeFall();
        goto label_51;
        label_49:
        val_28 = public static Royal.Scenes.Game.Levels.Units.State.GameStateManager Royal.Scenes.Game.Levels.LevelContext::Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(Royal.Scenes.Game.Levels.LevelContextId contextId);
        Royal.Scenes.Game.Levels.Units.State.GameStateManager val_21 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        if(val_21 == null)
        {
                throw new NullReferenceException();
        }
        
        val_28 = 0;
        val_21.FinishSpecialOperation();
        val_26 = this.<>4__this.touchManager;
        if(val_26 == null)
        {
                throw new NullReferenceException();
        }
        
        val_26.EnableTouch();
        do
        {
            label_109:
            val_40 = 0;
            return (bool)val_40;
        }
        while(val_26 == 0);
        
        throw val_26;
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
