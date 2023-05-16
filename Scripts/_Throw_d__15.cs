using UnityEngine;
private sealed class ClocheView.<Throw>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Cloche.ClocheItemView item;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    public Royal.Scenes.Game.Ui.Cloche.ClocheView <>4__this;
    public Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId;
    private bool <isTargetYBelow>5__2;
    private float <elapsed>5__3;
    private float <endSlowRatio>5__4;
    private float <scaleUpLength>5__5;
    private float <scaleDownLength>5__6;
    private float <shadowMinimizeLength>5__7;
    private Royal.Infrastructure.Utils.Animation.CubicBezier <bezierCurve>5__8;
    private float <duration>5__9;
    private float <speed>5__10;
    private bool <isScalingUp>5__11;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <outSine>5__12;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <outCubic>5__13;
    private float <startScale>5__14;
    private float <maxScale>5__15;
    private float <endScale>5__16;
    private bool <didFixSorting>5__17;
    private UnityEngine.Vector3 <shadowLastPosition>5__18;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClocheView.<Throw>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_67;
        int val_68;
        float val_69;
        float val_70;
        float val_71;
        float val_72;
        float val_73;
        float val_74;
        Royal.Scenes.Game.Ui.Cloche.ClocheItemView val_75;
        float val_76;
        float val_79;
        UnityEngine.SpriteRenderer val_81;
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
        val_67 = 0.9f;
        float val_1 = this.item.Anticipate(yScale:  val_67);
        this.cell.Reserve();
        UnityEngine.WaitForSeconds val_2 = null;
        val_1 = val_1 * val_67;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  val_1);
        val_68 = 1;
        this.<>2__current = val_2;
        this.<>1__state = val_68;
        return (bool)val_68;
        label_1:
        val_69 = this.<elapsed>5__3;
        val_70 = this.<duration>5__9;
        this.<>1__state = 0;
        goto label_7;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.PlayThrowClip(tiledId:  this.tiledId);
        this.item.transform.SetParent(p:  0);
        UnityEngine.Vector3 val_5 = this.item.transform.position;
        val_71 = val_5.y;
        UnityEngine.Vector3 val_6 = this.cell.GetViewPosition();
        val_72 = val_6.z;
        val_73 = val_71 + 3f;
        this.<isTargetYBelow>5__2 = false;
        if(val_71 > val_6.y)
        {
                this.<isTargetYBelow>5__2 = true;
            val_74 = val_5.z;
        }
        else
        {
                float val_66 = 2f;
            val_66 = val_6.y + val_66;
            val_74 = val_72;
        }
        
        val_69 = this;
        this.<elapsed>5__3 = ;
        this.<endSlowRatio>5__4 = ;
        this.<scaleUpLength>5__5 = 2f;
        this.<scaleDownLength>5__6 = 0.25f;
        mem[1152921519941390096] = 1073741824;
        this.<bezierCurve>5__8 = Royal.Infrastructure.Utils.Animation.CubicBezierPool.Pop().Init(p0:  new UnityEngine.Vector3() {x = val_5.x, y = val_71, z = val_5.z}, p1:  new UnityEngine.Vector3() {x = val_5.x, y = val_73, z = val_5.z}, p2:  new UnityEngine.Vector3() {x = val_6.x, y = val_74, z = val_6.x}, p3:  new UnityEngine.Vector3() {x = val_72});
        float val_12 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  UnityEngine.Mathf.Lerp(a:  6f, b:  4f, t:  (UnityEngine.Mathf.Min(a:  7f, b:  val_8.length)) / 7f));
        val_12 = (this.<bezierCurve>5__8.length) * val_12;
        val_70 = this;
        this.<duration>5__9 = val_12;
        mem[1152921519941390116] = 1065353216;
        mem[1152921519941390120] = 1;
        mem[1152921519941390128] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3);
        mem[1152921519941390136] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  9);
        UnityEngine.Vector3 val_16 = this.item.transform.localScale;
        float val_67 = 1.05f;
        val_67 = val_16.x * val_67;
        this.<startScale>5__14 = val_16.x;
        this.<maxScale>5__15 = val_67;
        this.<didFixSorting>5__17 = false;
        this.<endScale>5__16 = this.item.endScale;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        this.<shadowLastPosition>5__18 = val_17;
        mem[1152921519941390164] = val_17.y;
        mem[1152921519941390168] = val_17.z;
        label_7:
        val_67 = this.<elapsed>5__3;
        if(val_67 < 0)
        {
            goto label_30;
        }
        
        val_75 = this.item;
        goto label_86;
        label_30:
        float val_18 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_68 = this.<speed>5__10;
        val_18 = val_18 * val_68;
        val_67 = val_67 + val_18;
        this.<elapsed>5__3 = val_67;
        val_76 = 1f;
        val_68 = val_67 / (this.<duration>5__9);
        float val_19 = UnityEngine.Mathf.Min(a:  val_76, b:  val_68);
        UnityEngine.Vector3 val_20 = this.<bezierCurve>5__8.GetValue(t:  val_19);
        val_75 = this;
        val_67 = val_20.y;
        val_73 = val_20.z;
        UnityEngine.Vector3 val_22 = this.item.transform.position;
        val_79 = val_67;
        this.item.transform.position = new UnityEngine.Vector3() {x = val_20.x, y = val_79, z = val_73};
        float val_24 = this.<bezierCurve>5__8.GetLengthForT(t:  val_19);
        float val_70 = this.<bezierCurve>5__8.length;
        val_71 = val_24;
        if((this.<isScalingUp>5__11) == false)
        {
            goto label_41;
        }
        
        float val_27 = this.<outSine>5__12.Invoke(t:  UnityEngine.Mathf.Min(a:  1f, b:  val_71 / (this.<scaleUpLength>5__5)));
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  UnityEngine.Mathf.Lerp(a:  this.<startScale>5__14, b:  this.<maxScale>5__15, t:  val_27));
        this.item.transform.localScale = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.zero;
        val_72 = val_33.z;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_72}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_27);
        this.item.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        val_81 = this.item.shadow;
        float val_35 = UnityEngine.Mathf.Lerp(a:  0f, b:  0.4f, t:  val_27);
        val_73 = 1f;
        val_79 = 0f;
        val_81.color = new UnityEngine.Color() {r = 0f, g = val_79, b = 0f, a = 0f};
        UnityEngine.Vector3 val_37 = this.item.shadow.transform.localPosition;
        this.<shadowLastPosition>5__18 = val_37;
        mem[1152921519941390164] = val_37.y;
        mem[1152921519941390168] = val_37.z;
        if(val_27 < val_73)
        {
            goto label_70;
        }
        
        this.<isScalingUp>5__11 = false;
        goto label_70;
        label_41:
        val_24 = val_70 - val_71;
        if(val_24 < 0)
        {
                float val_69 = this.<scaleDownLength>5__6;
            if(val_24 < 0)
        {
                val_24 = val_24 / val_69;
            val_24 = val_76 - val_24;
            float val_38 = this.<outSine>5__12.Invoke(t:  val_24);
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
            val_73 = val_40.x;
            val_72 = val_40.z;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_73, y = val_40.y, z = val_72}, d:  UnityEngine.Mathf.Lerp(a:  this.<maxScale>5__15, b:  this.<endScale>5__16, t:  val_38));
            this.item.transform.localScale = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
            val_76 = 1f;
            val_81 = this.item.shadow;
            float val_43 = UnityEngine.Mathf.Lerp(a:  0.4f, b:  0f, t:  val_38);
            val_79 = 0f;
            val_81.color = new UnityEngine.Color() {r = 0f, g = val_79, b = 0f, a = 0f};
        }
        else
        {
                val_24 = val_24 - val_69;
            val_69 = (this.<shadowMinimizeLength>5__7) - val_69;
            val_24 = val_24 / val_69;
            val_81 = this.item.shadow.transform;
            val_72 = this.<shadowLastPosition>5__18;
            val_79 = 0f;
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = val_79, z = 0f}, b:  new UnityEngine.Vector3() {x = val_72, y = val_73, z = val_6.y}, t:  this.<outCubic>5__13.Invoke(t:  val_24));
            val_81.localPosition = new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z};
        }
        
        }
        
        label_70:
        val_70 = val_71 / val_70;
        if(val_70 > (this.<endSlowRatio>5__4))
        {
                var val_47 = ((this.<isTargetYBelow>5__2) == false) ? 1 : 0;
            val_71 = mem[36532560 + this.<isTargetYBelow>5__2 == false ? 1 : 0];
            val_71 = 36532560 + this.<isTargetYBelow>5__2 == false ? 1 : 0;
            val_79 = val_71;
            this.<speed>5__10 = UnityEngine.Mathf.Lerp(a:  val_76, b:  val_79, t:  (val_70 - (this.<endSlowRatio>5__4)) / (val_76 - (this.<endSlowRatio>5__4)));
        }
        
        UnityEngine.Vector3 val_53 = this.<>4__this.transform.position;
        float val_71 = 1.5f;
        val_71 = val_53.y + val_71;
        if((val_67 > val_71) && ((this.<didFixSorting>5__17) != true))
        {
                this.<didFixSorting>5__17 = true;
            UnityEngine.Rendering.SortingGroup val_54 = this.item.GetComponent<UnityEngine.Rendering.SortingGroup>();
            val_81 = val_54;
            val_81.sortingOrder = val_54.sortingOrder - 1000;
        }
        
        if((this.<elapsed>5__3) < (this.<duration>5__9))
        {
                this.<>2__current = 0;
            this.<>1__state = 2;
            val_68 = 1;
            return (bool)val_68;
        }
        
        label_86:
        Royal.Scenes.Game.Ui.Cloche.ClocheItemParticles val_57 = mem[this.item].GetComponentInChildren<Royal.Scenes.Game.Ui.Cloche.ClocheItemParticles>();
        if(val_57 != 0)
        {
                val_57.DestroySelf();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_60 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(group:  mem[this.item].GetComponent<UnityEngine.Rendering.SortingGroup>());
            val_70 = val_60.sortEverything;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_63 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_60.layer, order = val_60.order, sortEverything = val_70 & 4294967295}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_57.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_63.layer, order = val_63.order, sortEverything = val_63.sortEverything & 4294967295});
        }
        
        UnityEngine.Object.Destroy(obj:  mem[this.item].gameObject);
        val_81 = this.<bezierCurve>5__8;
        Royal.Infrastructure.Utils.Animation.CubicBezierPool.Push(bezier:  val_81);
        this.<>4__this.OnReachedToCell(cell:  this.cell, tiledId:  this.tiledId);
        label_3:
        val_68 = 0;
        return (bool)val_68;
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
