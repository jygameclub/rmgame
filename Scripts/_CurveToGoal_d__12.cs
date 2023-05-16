using UnityEngine;
private sealed class PearlGoalView.<CurveToGoal>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView <>4__this;
    private float <duration>5__2;
    private float <elapsed>5__3;
    private UnityEngine.Vector3 <p0>5__4;
    private UnityEngine.Vector3 <p3>5__5;
    private UnityEngine.Vector3 <p1>5__6;
    private UnityEngine.Vector3 <p2>5__7;
    private float <speed>5__8;
    private UnityEngine.Vector3 <shadowStartPos>5__9;
    private UnityEngine.Vector3 <shadowMaxPos>5__10;
    private bool <isGoingDown>5__11;
    private UnityEngine.Vector3 <minPos>5__12;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <cubeIn>5__13;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PearlGoalView.<CurveToGoal>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate val_38;
        int val_39;
        float val_40;
        float val_41;
        float val_42;
        float val_43;
        float val_44;
        var val_51;
        val_38 = this;
        if((this.<>1__state) != 1)
        {
                val_39 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_39;
        }
        
            this.<>1__state = 0;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPearlCollectSorting(offset:  1000 - (this.<>4__this.stateManager.GetOperationCount(animationId:  5)));
            this.<>4__this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.<>4__this.goalManager.FlyingToBeCollected(goalType:  28);
            this.<>4__this.stateManager.OperationStart(animationId:  5);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  1.3f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.1f), ease:  27);
            val_40 = val_38;
            this.<duration>5__2 = 0.5f;
            UnityEngine.Vector3 val_10 = this.<>4__this.goalManager.GetGoalPosition(goalType:  28);
            val_41 = val_38;
            val_42 = val_10.y;
            this.<elapsed>5__3 = 0f;
            UnityEngine.Vector3 val_12 = this.<>4__this.transform.position;
            this.<p0>5__4 = val_12;
            mem[1152921520211633508] = val_12.y;
            mem[1152921520211633512] = val_12.z;
            this.<p3>5__5 = val_10;
            mem[1152921520211633520] = val_42;
            mem[1152921520211633524] = val_10.z;
            val_43 = val_12.x;
            val_12.x = val_10.x - val_43;
            UnityEngine.Vector3 val_16 = this.<>4__this.transform.position;
            float val_38 = -1f;
            float val_17 = (UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  val_12.x, b:  0.5f), b:  -0.5f)) + val_16.x;
            val_38 = val_16.y + val_38;
            mem[1152921520211633536] = val_16.z;
            this.<p2>5__7 = val_17;
            this.<p1>5__6 = val_17;
            mem[1152921520211633532] = val_38;
            mem[1152921520211633544] = val_38;
            mem[1152921520211633548] = val_16.z;
            val_16.z = (Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateArcLength(p0:  new UnityEngine.Vector3() {x = this.<p0>5__4, y = V6.16B, z = val_16.z}, p1:  new UnityEngine.Vector3() {x = val_17, y = val_38, z = val_16.z}, p2:  new UnityEngine.Vector3() {x = val_17, y = val_16.z, z = this.<p3>5__5}, p3:  new UnityEngine.Vector3() {x = val_16.y})) / 15f;
            float val_19 = UnityEngine.Mathf.Lerp(a:  1f, b:  1.5f, t:  val_16.z);
            this.<speed>5__8 = 1f;
            val_19 = val_19 * (this.<duration>5__2);
            this.<duration>5__2 = val_19;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            float val_21 = val_20.x + 0.1f;
            this.<shadowStartPos>5__9 = val_20;
            mem[1152921520211633560] = val_20.y;
            mem[1152921520211633564] = val_20.z;
            this.<shadowMaxPos>5__10 = val_21;
            val_20.y = val_20.y + (-0.3f);
            mem[1152921520211633572] = val_20.y;
            mem[1152921520211633576] = val_20.z;
            this.<isGoingDown>5__11 = true;
            UnityEngine.Vector3 val_22 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateMin(duration:  this.<duration>5__2, p0:  new UnityEngine.Vector3() {x = this.<p0>5__4, y = V16.16B, z = val_17}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__6, y = val_21}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__7, y = -0.3f, z = this.<p3>5__5}, p3:  new UnityEngine.Vector3() {x = ???, y = 50f}, precision:  0f);
            this.<minPos>5__12 = val_22;
            mem[1152921520211633588] = val_22.y;
            mem[1152921520211633592] = val_22.z;
            this.<cubeIn>5__13 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  8);
        }
        else
        {
                val_41 = this.<elapsed>5__3;
            val_40 = this.<duration>5__2;
            this.<>1__state = 0;
        }
        
        val_44 = mem[this.<elapsed>5__3];
        val_44 = val_41;
        if(val_44 < 0)
        {
            goto label_17;
        }
        
        this.<>4__this.stateManager.OperationFinish(animationId:  5);
        val_38 = this.<>4__this.viewDelegate;
        var val_39 = 0;
        if(mem[1152921505096286208] == null)
        {
            goto label_22;
        }
        
        val_39 = val_39 + 1;
        goto label_24;
        label_17:
        float val_24 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_24 = val_24 * (this.<speed>5__8);
        val_44 = val_44 + val_24;
        this.<elapsed>5__3 = val_44;
        val_40 = 1152921504781234176;
        val_24 = val_44 / (this.<duration>5__2);
        UnityEngine.Vector3 val_26 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  UnityEngine.Mathf.Clamp01(value:  val_24), p0:  new UnityEngine.Vector3() {x = this.<p0>5__4}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__6}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__7, y = ???, z = this.<p3>5__5}, p3:  new UnityEngine.Vector3() {x = ???, y = 50f});
        if((this.<isGoingDown>5__11) == false)
        {
            goto label_27;
        }
        
        UnityEngine.Vector3 val_28 = this.<>4__this.transform.position;
        if(val_26.y <= val_28.y)
        {
            goto label_31;
        }
        
        this.<isGoingDown>5__11 = false;
        goto label_31;
        label_27:
        label_31:
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__5, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        float val_31 = val_30.x / 5f;
        float val_32 = UnityEngine.Mathf.Lerp(a:  0.6f, b:  1f, t:  val_31);
        this.<speed>5__8 = val_32;
        if((this.<isGoingDown>5__11) != false)
        {
                val_31 = val_32 - val_26.y;
            val_32 = val_32 - 1f;
            val_44 = val_31 / val_32;
            val_42 = this.<shadowMaxPos>5__10;
            val_51 = this.<>4__this.pearlShadow.transform;
        }
        else
        {
                val_31 = val_26.y - val_32;
            val_32 = 1f - val_32;
            val_32 = val_31 / val_32;
            val_44 = this.<cubeIn>5__13.Invoke(t:  val_32);
            val_43 = this.<shadowStartPos>5__9;
            val_51 = this.<>4__this.pearlShadow.transform;
        }
        
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__10, y = this.<p3>5__5, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_43, y = val_26.z, z = val_30.x}, t:  val_44);
        val_51.localPosition = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
        val_39 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_39;
        return (bool)val_39;
        label_22:
        Royal.Scenes.Game.Mechanics.Items.OysterItem.View.IOysterItemViewDelegate val_37 = 1152921505096249344 + ((mem[1152921505096286216]) << 4);
        label_24:
        val_38.CollectCompleted();
        this.<>4__this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.PearlGoalView>(go:  this.<>4__this);
        val_39 = 0;
        return (bool)val_39;
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
