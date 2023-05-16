using UnityEngine;
private sealed class CaldronThrowItemView.<Move>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronThrowItemView <>4__this;
    public float delay;
    public Royal.Scenes.Game.Mechanics.Sortings.SortingData patchSorting;
    private bool <isTargetYBelow>5__2;
    private float <elapsed>5__3;
    private float <endSlowRatio>5__4;
    private float <maxScale>5__5;
    private float <endScale>5__6;
    private float <shadowFlyMaxAlpha>5__7;
    private float <shadowLandMaxAlpha>5__8;
    private float <scaleUpLength>5__9;
    private Royal.Infrastructure.Utils.Animation.CubicBezier <bezierCurve>5__10;
    private float <scaleDownLength>5__11;
    private float <duration>5__12;
    private float <speed>5__13;
    private bool <isScalingUp>5__14;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <outSine>5__15;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <inCubic>5__16;
    private UnityEngine.Vector3 <bigShadowMaxPosition>5__17;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CaldronThrowItemView.<Move>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Infrastructure.Utils.Animation.CubicBezier val_60;
        UnityEngine.SpriteRenderer val_61;
        float val_62;
        int val_63;
        float val_64;
        float val_65;
        Royal.Infrastructure.Utils.Animation.CubicBezier val_66;
        float val_67;
        float val_68;
        val_60 = this;
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
        val_61 = this.<>4__this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_61.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.<>4__this.Invoke(methodName:  "FixItemSortings", time:  0.31f);
        this.<>4__this.Invoke(methodName:  "FixParticleSortings", time:  0.41f);
        val_62 = this.delay;
        if(val_62 <= 0f)
        {
            goto label_9;
        }
        
        val_63 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_62);
        this.<>1__state = val_63;
        return (bool)val_63;
        label_1:
        val_64 = this.<elapsed>5__3;
        val_65 = this.<duration>5__12;
        this.<>1__state = 0;
        goto label_11;
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
        if(3f > val_14.x)
        {
                this.<>4__this = this.<>4__this.startPosition;
            this.<>4__this = this.<>4__this.finalPosition;
            this.<isTargetYBelow>5__2 = true;
        }
        else
        {
                val_14.x = val_14.x + 2f;
            this.<>4__this = this.<>4__this.finalPosition;
            this.<>4__this = -7;
            this.<>4__this = val_14.x;
        }
        
        val_64 = val_60;
        this.<elapsed>5__3 = 0f;
        this.<>4__this.item.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.<>4__this.bigShadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        this.<>4__this.bigShadow.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        val_61 = this.<>4__this.smallShadow;
        UnityEngine.Color val_17 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        val_61.color = new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a};
        this.<shadowLandMaxAlpha>5__8 = 0.8235294f;
        this.<scaleUpLength>5__9 = 2f;
        this.<endSlowRatio>5__4 = ;
        this.<maxScale>5__5 = ;
        this.<endScale>5__6 = 1.02f;
        this.<shadowFlyMaxAlpha>5__7 = 0.4313726f;
        this.<bezierCurve>5__10 = Royal.Infrastructure.Utils.Animation.CubicBezierPool.Pop().Init(p0:  new UnityEngine.Vector3() {x = this.<>4__this.startPosition, y = val_17.g, z = val_17.b}, p1:  new UnityEngine.Vector3() {x = this.<>4__this.curvePoint1}, p2:  new UnityEngine.Vector3() {x = this.<>4__this.curvePoint2, y = ???, z = this.<>4__this.finalPosition}, p3:  new UnityEngine.Vector3() {x = ???});
        float val_20 = UnityEngine.Mathf.Min(a:  7f, b:  val_19.length);
        float val_60 = 0.3f;
        val_60 = val_20 * val_60;
        this.<scaleDownLength>5__11 = val_60;
        float val_23 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  UnityEngine.Mathf.Lerp(a:  8f, b:  5f, t:  val_20 / 7f));
        val_23 = (this.<bezierCurve>5__10.length) * val_23;
        val_65 = val_60;
        this.<duration>5__12 = val_23;
        mem[1152921523835969512] = 1065353216;
        mem[1152921523835969516] = 1;
        mem[1152921523835969520] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3);
        mem[1152921523835969528] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  8);
        mem[1152921523835969536] = 0;
        mem[1152921523835969544] = 0;
        label_11:
        val_62 = this.<elapsed>5__3;
        if(val_62 < 0)
        {
            goto label_36;
        }
        
        val_66 = this.<bezierCurve>5__10;
        goto label_73;
        label_36:
        float val_26 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_61 = this.<speed>5__13;
        val_26 = val_26 * val_61;
        val_62 = val_62 + val_26;
        this.<elapsed>5__3 = val_62;
        val_67 = 1f;
        val_61 = val_62 / (this.<duration>5__12);
        float val_27 = UnityEngine.Mathf.Min(a:  val_67, b:  val_61);
        val_66 = val_60;
        UnityEngine.Vector3 val_28 = this.<bezierCurve>5__10.GetValue(t:  val_27);
        val_68 = val_28.z;
        UnityEngine.Vector3 val_30 = this.<>4__this.transform.position;
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_68};
        float val_32 = this.<bezierCurve>5__10.GetLengthForT(t:  val_27);
        if((this.<isScalingUp>5__14) == false)
        {
            goto label_46;
        }
        
        float val_35 = this.<outSine>5__15.Invoke(t:  UnityEngine.Mathf.Min(a:  1f, b:  val_32 / (this.<scaleUpLength>5__9)));
        UnityEngine.Vector3 val_37 = UnityEngine.Vector3.one;
        val_68 = val_37.y;
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_68, z = val_37.z}, d:  UnityEngine.Mathf.Lerp(a:  0f, b:  this.<maxScale>5__5, t:  val_35));
        this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z}, b:  new UnityEngine.Vector3() {x = this.<bigShadowMaxPosition>5__17}, t:  val_35);
        this.<>4__this.bigShadow.transform.localPosition = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
        val_61 = this.<>4__this.bigShadow;
        float val_43 = UnityEngine.Mathf.Lerp(a:  0f, b:  this.<shadowFlyMaxAlpha>5__7, t:  val_35);
        val_61.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(val_35 < 1f)
        {
            goto label_58;
        }
        
        this.<isScalingUp>5__14 = false;
        goto label_58;
        label_46:
        float val_62 = this.<scaleDownLength>5__11;
        float val_44 = val_19.length - val_32;
        if(val_44 < 0)
        {
                val_62 = val_44 / val_62;
            val_62 = val_67 - val_62;
            float val_45 = this.<outSine>5__15.Invoke(t:  val_62);
            float val_63 = this.<scaleDownLength>5__11;
            val_63 = val_44 / val_63;
            val_63 = val_67 - val_63;
            float val_64 = this.<scaleDownLength>5__11;
            val_64 = val_44 / val_64;
            val_64 = val_67 - val_64;
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, d:  UnityEngine.Mathf.Lerp(a:  this.<maxScale>5__5, b:  this.<endScale>5__6, t:  val_45));
            this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
            val_67 = 1f;
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<bigShadowMaxPosition>5__17, y = this.<maxScale>5__5, z = val_45}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  this.<inCubic>5__16.Invoke(t:  val_63));
            this.<>4__this.bigShadow.transform.localPosition = new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z};
            val_61 = this.<>4__this.bigShadow;
            float val_54 = UnityEngine.Mathf.Lerp(a:  this.<shadowFlyMaxAlpha>5__7, b:  this.<shadowLandMaxAlpha>5__8, t:  this.<inCubic>5__16.Invoke(t:  val_64));
            val_61.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        label_58:
        val_62 = val_32 / val_19.length;
        if(val_62 > (this.<endSlowRatio>5__4))
        {
                var val_55 = ((this.<isTargetYBelow>5__2) == false) ? 1 : 0;
            this.<speed>5__13 = UnityEngine.Mathf.Lerp(a:  val_67, b:  36532560 + this.<isTargetYBelow>5__2 == false ? 1 : 0, t:  (val_62 - (this.<endSlowRatio>5__4)) / (val_67 - (this.<endSlowRatio>5__4)));
        }
        
        if((this.<elapsed>5__3) < (this.<duration>5__12))
        {
                this.<>2__current = 0;
            this.<>1__state = 2;
            val_63 = 1;
            return (bool)val_63;
        }
        
        label_73:
        val_60 = mem[this.<bezierCurve>5__10];
        Royal.Infrastructure.Utils.Animation.CubicBezierPool.Push(bezier:  val_60);
        this.<>4__this.OnReachedToCell();
        label_3:
        val_63 = 0;
        return (bool)val_63;
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
