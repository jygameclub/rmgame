using UnityEngine;
private sealed class JesterHatBooster.<MoveAllItems>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Boosters.JesterHat.JesterHatBooster <>4__this;
    public float duration;
    private UnityEngine.Vector3[] <startPositions>5__2;
    private UnityEngine.Vector3[] <endPositions>5__3;
    private float <elapsed>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JesterHatBooster.<MoveAllItems>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_23;
        UnityEngine.Vector3[] val_24;
        var val_25;
        float val_26;
        int val_27;
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
        val_23 = 1152921506446946720;
        this.<startPositions>5__2 = new UnityEngine.Vector3[0];
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[0];
        this.<endPositions>5__3 = val_2;
        if((this.<>4__this.originalItemsCount) >= 1)
        {
                var val_24 = 0;
            do
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_23 = this.<>4__this.cells[val_24];
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.CurrentItem;
            val_24 = this.<startPositions>5__2;
            val_23 = val_3;
            UnityEngine.Transform val_4 = val_3.transform;
            UnityEngine.Vector3 val_5 = val_4.position;
            val_24[0] = val_5;
            val_24[0] = val_5.y;
            val_24[0] = val_5.z;
            UnityEngine.Vector3 val_7 = val_4.transform.position;
            this.<endPositions>5__3[0] = val_7;
            this.<endPositions>5__3[0] = val_7.y;
            this.<endPositions>5__3[0] = val_7.z;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetMatchItemCollectSorting(offset:  0);
            val_24 = val_9.sortEverything;
            bool val_10 = val_24 & 4294967295;
            val_24 = val_24 + 1;
            val_25 = 0 + 12;
        }
        while(val_24 < (this.<>4__this.originalItemsCount));
        
        }
        
        this.<elapsed>5__4 = 0f;
        val_26 = 0f;
        goto label_29;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.gameTouchListener.EnableTouch();
        this.<>4__this.ClearState();
        label_3:
        val_27 = 0;
        return (bool)val_27;
        label_2:
        val_26 = this.<elapsed>5__4;
        this.<>1__state = 0;
        label_29:
        if(val_26 >= 0)
        {
                if((this.<>4__this.originalItemsCount) >= 1)
        {
                val_25 = 1152921505085652992;
            var val_26 = 0;
            do
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11 = 39350.CurrentItem;
            val_23 = val_11;
            val_24 = val_11;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.<>4__this.cells[val_26], isReverseSort:  val_24 & 1);
            bool val_14 = val_13.sortEverything & 4294967295;
            val_26 = val_26 + 1;
        }
        while(val_26 < (this.<>4__this.originalItemsCount));
        
        }
        
            this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.25f);
            this.<>1__state = 2;
            val_27 = 1;
            return (bool)val_27;
        }
        
        float val_16 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_16 = val_26 + val_16;
        this.<elapsed>5__4 = val_16;
        val_16 = val_16 / this.duration;
        if((this.<>4__this.originalItemsCount) >= 1)
        {
                val_26 = ManualEasing.Back.InOut(t:  val_16, overshootAmplitude:  0.5f);
            var val_30 = 0;
            val_24 = 12;
            do
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_27 = this.<>4__this.cells[0];
            UnityEngine.Vector3[] val_28 = this.<startPositions>5__2;
            UnityEngine.Vector3[] val_29 = this.<endPositions>5__3;
            val_28 = val_28 + (0 * val_24);
            val_29 = val_29 + (0 * val_24);
            UnityEngine.Transform val_19 = 0.CurrentItem.transform;
            val_23 = val_19;
            UnityEngine.Vector3 val_20 = val_19.position;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(v1:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, v2:  new UnityEngine.Vector3() {x = (0 * val_24) + this.<endPositions>5__3 + 32, y = (0 * val_24) + this.<endPositions>5__3 + 32 + 4, z = (0 * val_24) + this.<endPositions>5__3 + 40})) != true)
        {
                UnityEngine.Vector3 val_22 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = (0 * val_24) + this.<startPositions>5__2 + 32, y = (0 * val_24) + this.<startPositions>5__2 + 32 + 4, z = (0 * val_24) + this.<startPositions>5__2 + 40}, b:  new UnityEngine.Vector3() {x = (0 * val_24) + this.<endPositions>5__3 + 32, y = (0 * val_24) + this.<endPositions>5__3 + 32 + 4, z = (0 * val_24) + this.<endPositions>5__3 + 40}, t:  val_26, extrapolate:  true);
            val_23.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        }
        
            val_30 = val_30 + 1;
        }
        while(val_30 < (this.<>4__this.originalItemsCount));
        
        }
        
        val_27 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_27;
        return (bool)val_27;
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
