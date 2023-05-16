using UnityEngine;
private sealed class ShuffleManager.<MoveAllItems>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Levels.Units.Shuffle.ShuffleManager <>4__this;
    public float duration;
    private UnityEngine.Vector3[] <startPositions>5__2;
    private UnityEngine.Vector3[] <endPositions>5__3;
    private float <elapsed>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShuffleManager.<MoveAllItems>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_23;
        Royal.Scenes.Game.Levels.Units.State.GameStateManager val_24;
        int val_25;
        Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_26;
        var val_27;
        UnityEngine.Vector3[] val_28;
        var val_29;
        float val_30;
        val_23 = this;
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
        val_24 = this.<>4__this.gameState;
        if((this.<>4__this.gameState.gameState) != 1)
        {
            goto label_6;
        }
        
        val_25 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.35f);
        this.<>1__state = val_25;
        return (bool)val_25;
        label_2:
        this.<>1__state = 0;
        val_26 = 1152921506446946720;
        int val_4 = (this.<>4__this.gridManager.Height) * (this.<>4__this.gridManager.Width);
        this.<startPositions>5__2 = new UnityEngine.Vector3[0];
        int val_8 = (this.<>4__this.gridManager.Height) * (this.<>4__this.gridManager.Width);
        this.<endPositions>5__3 = new UnityEngine.Vector3[0];
        val_27 = mem[this.<>4__this.gridIterator.strategy + 368 + 8];
        this.<>4__this = this.<>4__this.gridIterator;
        this.<>4__this = 0;
        if((this.<>4__this + 112) != 0)
        {
                var val_25 = 0;
            do
        {
            if((this.<>4__this + 112.IsItemInCellShufflable(cell:  val_26)) != false)
        {
                public System.Void System.Collections.Generic.List<UnityEngine.Color32>::Add(UnityEngine.Color32 item).__il2cppRuntimeField_10 + 24 + 128.SetSortingForCollect(offset:  0);
            val_28 = this.<startPositions>5__2;
            UnityEngine.Vector3 val_12 = public System.Void System.Collections.Generic.List<UnityEngine.Color32>::Add(UnityEngine.Color32 item).__il2cppRuntimeField_10 + 24 + 128.transform.position;
            var val_13 = val_28 + (0 * 12);
            val_13 = val_12.x;
            val_13 = val_12.y;
            val_13 = val_12.z;
            val_26 = this.<endPositions>5__3;
            val_27 = 0;
            UnityEngine.Vector3 val_15 = transform.position;
            var val_16 = val_26 + (0 * 12);
            val_16 = val_15.x;
            val_16 = val_15.y;
            val_16 = val_15.z;
        }
        else
        {
                val_26 = "Item Is Not In Shufflable: "("Item Is Not In Shufflable: ") + val_26;
            val_27 = 0;
            UnityEngine.Debug.Log(message:  val_26);
        }
        
            val_25 = val_25 + 1;
        }
        while((this.<>4__this + 112) != 0);
        
        }
        
        val_29 = val_23;
        this.<elapsed>5__4 = 0f;
        val_30 = 0f;
        goto label_34;
        label_1:
        val_29 = val_23;
        val_30 = this.<elapsed>5__4;
        this.<>1__state = 0;
        label_34:
        if(val_30 < 0)
        {
            goto label_35;
        }
        
        val_23 = this.<>4__this;
        this.<>4__this = this.<>4__this.gridIterator;
        this.<>4__this = 0;
        if((this.<>4__this + 112) != 0)
        {
                do
        {
            if((mem[this.<>4__this.gridIterator.strategy + 32] + 16 + 24) != 0)
        {
                val_26 = mem[this.<>4__this.gridIterator.strategy + 28];
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_18 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  val_26, isReverseSort:  false);
            bool val_19 = val_18.sortEverything & 4294967295;
        }
        
        }
        while((this.<>4__this + 112) != 0);
        
        }
        
        val_24 = this.<>4__this.gameState;
        label_6:
        this.<>4__this.gameState.operations.Reset(operationType:  6);
        label_3:
        val_25 = 0;
        return (bool)val_25;
        label_35:
        float val_20 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_20 = val_30 + val_20;
        this.<elapsed>5__4 = val_20;
        this.<>4__this = this.<>4__this.gridIterator;
        this.<>4__this = 0;
        float val_26 = this.<elapsed>5__4;
        val_26 = val_26 / this.duration;
        if((this.<>4__this + 112) != 0)
        {
                var val_29 = 0;
            val_28 = 12;
            do
        {
            if((X26 + 16) == 1)
        {
                val_26 = mem[X26 + 32];
            val_26 = X26 + 32;
            if(((X26 + 32 + 16 + 24) != 0) && (((X26 + 32 + 16 + 24) & 1) != 0))
        {
                if((X26 + 64.HasTouchBlockingItem()) != true)
        {
                UnityEngine.Vector3[] val_27 = this.<startPositions>5__2;
            UnityEngine.Vector3[] val_28 = this.<endPositions>5__3;
            val_27 = val_27 + (0 * val_28);
            val_28 = val_28 + (0 * val_28);
            val_26 = X26 + 32 + 16 + 24.transform;
            UnityEngine.Vector3 val_24 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = (0 * val_28) + this.<startPositions>5__2 + 32, y = (0 * val_28) + this.<startPositions>5__2 + 32 + 4, z = (0 * val_28) + this.<startPositions>5__2 + 40}, b:  new UnityEngine.Vector3() {x = (0 * val_28) + this.<endPositions>5__3 + 32, y = (0 * val_28) + this.<endPositions>5__3 + 32 + 4, z = (0 * val_28) + this.<endPositions>5__3 + 40}, t:  ManualEasing.Back.InOut(t:  val_26, overshootAmplitude:  0.5f), extrapolate:  true);
            val_26.position = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
        }
        
        }
        
        }
        
            val_29 = val_29 + 1;
        }
        while((this.<>4__this + 112) != 0);
        
        }
        
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_25 = 1;
        return (bool)val_25;
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
