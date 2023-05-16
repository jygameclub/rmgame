using UnityEngine;
private sealed class HatThrowItemView.<Move>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView <>4__this;
    public float delay;
    public Royal.Scenes.Game.Mechanics.Sortings.SortingData patchSorting;
    private bool <isTargetYBelow>5__2;
    private float <elapsed>5__3;
    private float <endSlowRatio>5__4;
    private float <maxScale>5__5;
    private float <scaleUpLength>5__6;
    private float <scaleDownLength>5__7;
    private Royal.Infrastructure.Utils.Animation.CubicBezier <bezierCurve>5__8;
    private float <duration>5__9;
    private float <speed>5__10;
    private bool <isScalingUp>5__11;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <outSine>5__12;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HatThrowItemView.<Move>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Infrastructure.Utils.Animation.CubicBezier val_59;
        UnityEngine.SpriteRenderer val_60;
        float val_61;
        int val_62;
        float val_63;
        float val_64;
        Royal.Infrastructure.Utils.Animation.CubicBezier val_65;
        float val_66;
        val_59 = this;
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
        this.<>4__this.stateManager.OperationStart(animationId:  11);
        val_60 = this.<>4__this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_60.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.<>4__this.Invoke(methodName:  "FixItemSortings", time:  0.31f);
        this.<>4__this.Invoke(methodName:  "FixParticleSortings", time:  0.41f);
        val_61 = this.delay;
        if(val_61 <= 0f)
        {
            goto label_9;
        }
        
        val_62 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_61);
        this.<>1__state = val_62;
        return (bool)val_62;
        label_2:
        this.<>1__state = 0;
        label_9:
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.patchSorting, order = this.patchSorting, sortEverything = X21}, offset:  (this.<>4__this.index) - ((this.<>4__this.index) << 2));
        bool val_6 = val_5.sortEverything & 4294967295;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_6}, offset:  (-7) - (this.<>4__this.index));
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_6}, offset:  0);
        this.<>4__this.UpdateSortings(itemSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_6}, particleSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295}, shadowSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = val_9.sortEverything & 4294967295});
        this.<>4__this.tracer.Play();
        UnityEngine.Vector3 val_13 = this.<>4__this.transform.position;
        this.<>4__this = val_13.x;
        this.<>4__this = val_13.y;
        this.<>4__this = val_13.z;
        UnityEngine.Vector3 val_14 = this.<>4__this.cell.GetViewPosition();
        this.<>4__this = val_14.x;
        this.<>4__this = val_14.y;
        val_14.x = val_14.x + 3f;
        this.<>4__this = val_14.z;
        this.<>4__this = this.<>4__this.startPosition;
        this.<>4__this = -7;
        this.<>4__this = val_14.x;
        this.<isTargetYBelow>5__2 = false;
        if(3f <= val_14.x)
        {
            goto label_17;
        }
        
        this.<>4__this = this.<>4__this.startPosition;
        this.<>4__this = this.<>4__this.finalPosition;
        this.<isTargetYBelow>5__2 = true;
        goto label_18;
        label_1:
        val_63 = this.<elapsed>5__3;
        val_64 = this.<duration>5__9;
        this.<>1__state = 0;
        goto label_19;
        label_17:
        val_14.x = val_14.x + 2f;
        this.<>4__this = this.<>4__this.finalPosition;
        this.<>4__this = -7;
        this.<>4__this = val_14.x;
        label_18:
        val_63 = val_59;
        this.<elapsed>5__3 = 0f;
        this.<>4__this.item.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.<>4__this.shadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_60 = this.<>4__this.shadow.transform;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        val_60.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        this.<endSlowRatio>5__4 = ;
        this.<maxScale>5__5 = ;
        this.<scaleUpLength>5__6 = 2f;
        this.<scaleDownLength>5__7 = 0.25f;
        this.<bezierCurve>5__8 = Royal.Infrastructure.Utils.Animation.CubicBezierPool.Pop().Init(p0:  new UnityEngine.Vector3() {x = this.<>4__this.startPosition, y = val_16.y, z = val_16.z}, p1:  new UnityEngine.Vector3() {x = this.<>4__this.curvePoint1}, p2:  new UnityEngine.Vector3() {x = this.<>4__this.curvePoint2, y = ???, z = this.<>4__this.finalPosition}, p3:  new UnityEngine.Vector3() {x = ???, y = 0f, z = 0f});
        float val_22 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  UnityEngine.Mathf.Lerp(a:  8f, b:  5f, t:  (UnityEngine.Mathf.Min(a:  7f, b:  val_18.length)) / 7f));
        val_22 = (this.<bezierCurve>5__8.length) * val_22;
        val_64 = val_59;
        this.<duration>5__9 = val_22;
        mem[1152921520296949804] = 1065353216;
        mem[1152921520296949808] = 1;
        mem[1152921520296949816] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3);
        label_19:
        val_61 = this.<elapsed>5__3;
        if(val_61 < 0)
        {
            goto label_35;
        }
        
        val_65 = this.<bezierCurve>5__8;
        goto label_72;
        label_35:
        float val_24 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_59 = this.<speed>5__10;
        val_24 = val_24 * val_59;
        val_61 = val_61 + val_24;
        this.<elapsed>5__3 = val_61;
        val_59 = val_61 / (this.<duration>5__9);
        val_61 = 1f;
        float val_25 = UnityEngine.Mathf.Min(a:  val_61, b:  val_59);
        val_65 = val_59;
        UnityEngine.Vector3 val_26 = this.<bezierCurve>5__8.GetValue(t:  val_25);
        val_66 = val_26.z;
        UnityEngine.Vector3 val_28 = this.<>4__this.transform.position;
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_66};
        float val_30 = this.<bezierCurve>5__8.GetLengthForT(t:  val_25);
        if((this.<isScalingUp>5__11) == false)
        {
            goto label_45;
        }
        
        float val_33 = this.<outSine>5__12.Invoke(t:  UnityEngine.Mathf.Min(a:  1f, b:  val_30 / (this.<scaleUpLength>5__6)));
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  UnityEngine.Mathf.Lerp(a:  0f, b:  this.<maxScale>5__5, t:  val_33));
        this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.zero;
        val_66 = val_39.y;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_66, z = val_39.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_33);
        this.<>4__this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z};
        val_60 = this.<>4__this.shadow;
        float val_41 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.5f, t:  val_33);
        val_60.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(val_33 < 1f)
        {
            goto label_57;
        }
        
        this.<isScalingUp>5__11 = false;
        goto label_57;
        label_45:
        float val_60 = this.<scaleDownLength>5__7;
        float val_42 = val_18.length - val_30;
        if(val_42 < 0)
        {
                val_60 = val_42 / val_60;
            val_60 = val_61 - val_60;
            float val_43 = this.<outSine>5__12.Invoke(t:  val_60);
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  UnityEngine.Mathf.Lerp(a:  1.1f, b:  1f, t:  val_43));
            this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
            UnityEngine.Vector3 val_50 = this.<>4__this.shadow.transform.localPosition;
            val_66 = val_50.y;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_66, z = val_50.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_43);
            this.<>4__this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
            val_60 = this.<>4__this.shadow;
            float val_52 = UnityEngine.Mathf.Lerp(a:  0.5f, b:  0f, t:  val_43);
            val_60.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        label_57:
        float val_53 = val_30 / val_18.length;
        if(val_53 > (this.<endSlowRatio>5__4))
        {
                var val_54 = ((this.<isTargetYBelow>5__2) == false) ? 1 : 0;
            this.<speed>5__10 = UnityEngine.Mathf.Lerp(a:  val_61, b:  36532560 + this.<isTargetYBelow>5__2 == false ? 1 : 0, t:  (val_53 - (this.<endSlowRatio>5__4)) / (val_61 - (this.<endSlowRatio>5__4)));
        }
        
        if((this.<elapsed>5__3) < (this.<duration>5__9))
        {
                this.<>2__current = 0;
            this.<>1__state = 2;
            val_62 = 1;
            return (bool)val_62;
        }
        
        label_72:
        val_59 = mem[this.<bezierCurve>5__8];
        Royal.Infrastructure.Utils.Animation.CubicBezierPool.Push(bezier:  val_59);
        this.<>4__this.OnReachedToCell();
        label_3:
        val_62 = 0;
        return (bool)val_62;
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
