using UnityEngine;
private sealed class BirdNestBird.<Move>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird <>4__this;
    public float delay;
    public int index;
    private UnityEngine.Transform <shadowParent>5__2;
    private bool <isTargetYBelow>5__3;
    private float <elapsed>5__4;
    private float <endSlowRatio>5__5;
    private float <maxScale>5__6;
    private float <scaleUpLength>5__7;
    private float <scaleDownLength>5__8;
    private Royal.Infrastructure.Utils.Animation.CubicBezier <bezierCurve>5__9;
    private float <duration>5__10;
    private float <speed>5__11;
    private bool <isScalingUp>5__12;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <outSine>5__13;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BirdNestBird.<Move>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Infrastructure.Utils.Animation.CubicBezier val_73;
        int val_74;
        var val_75;
        int val_76;
        float val_77;
        float val_78;
        float val_79;
        var val_80;
        float val_81;
        float val_82;
        float val_83;
        float val_84;
        Royal.Infrastructure.Utils.Animation.CubicBezier val_85;
        val_73 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_74 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_74;
        }
        
        this.<>1__state = 0;
        this.<>4__this.stateManager.OperationStart(animationId:  11);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        this.<>4__this.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        val_75 = null;
        val_75 = null;
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.<>4__this.foreShadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        this.<shadowParent>5__2 = this.<>4__this.shadow.transform.parent;
        this.<>4__this.shadow.transform.SetParent(parent:  0, worldPositionStays:  true);
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.<>4__this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        this.<>4__this.shadow.gameObject.SetActive(value:  true);
        this.<>4__this.shadow.transform.SetParent(parent:  this.<shadowParent>5__2, worldPositionStays:  true);
        val_76 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.ItemLayerId;
        int val_10 = this.<>4__this.sortingGroup.sortingOrder;
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.<>4__this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        val_77 = this.delay;
        if(val_77 <= 0f)
        {
            goto label_23;
        }
        
        val_74 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_77);
        this.<>1__state = val_74;
        return (bool)val_74;
        label_1:
        val_78 = this.<elapsed>5__4;
        val_79 = this.<duration>5__10;
        this.<>1__state = 0;
        goto label_25;
        label_2:
        this.<>1__state = 0;
        label_23:
        this.<>4__this = 1;
        val_80 = null;
        val_80 = null;
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.<>4__this.foreShadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBirdNestBirdShadowSorting();
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.<>4__this.shadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_12.layer, order = val_12.order, sortEverything = val_12.sortEverything & 4294967295});
        this.<>4__this.shadow.gameObject.SetActive(value:  true);
        this.<>4__this.shadow.transform.SetParent(parent:  this.<shadowParent>5__2, worldPositionStays:  true);
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_16 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerFlyingSorting(isSpecialCombo:  false);
        val_16.sortEverything = val_16.sortEverything & 4294967295;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_18 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_16.layer, order = val_16.order, sortEverything = val_16.sortEverything}, offset:  this.index - (this.index << 2));
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.<>4__this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_18.layer, order = val_18.order, sortEverything = val_18.sortEverything & 4294967295});
        this.<>4__this.sfxManager.PlaySfx(type:  this.<>4__this.sfxManager.SelectRandomClip(from:  19, to:  20), offset:  0.04f);
        UnityEngine.Vector3 val_22 = this.<>4__this.transform.position;
        val_81 = val_22.y;
        UnityEngine.Vector3 val_23 = this.<>4__this.cell.GetViewPosition();
        val_82 = val_23.z;
        val_83 = val_81 + 3f;
        this.<isTargetYBelow>5__3 = false;
        if(val_81 > val_23.y)
        {
                this.<isTargetYBelow>5__3 = true;
            val_84 = val_22.z;
        }
        else
        {
                float val_72 = 2f;
            val_72 = val_23.y + val_72;
            val_84 = val_82;
        }
        
        val_78 = val_73;
        this.<elapsed>5__4 = 0f;
        this.<>4__this.shadow.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_76 = this.<>4__this.shadow.transform;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
        val_76.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        this.<endSlowRatio>5__5 = ;
        this.<maxScale>5__6 = ;
        this.<scaleUpLength>5__7 = 2f;
        this.<scaleDownLength>5__8 = 0.5f;
        this.<bezierCurve>5__9 = Royal.Infrastructure.Utils.Animation.CubicBezierPool.Pop().Init(p0:  new UnityEngine.Vector3() {x = val_22.x, y = val_81, z = val_22.z}, p1:  new UnityEngine.Vector3() {x = val_22.x, y = val_83, z = val_22.z}, p2:  new UnityEngine.Vector3() {x = val_23.x, y = val_84, z = val_23.x}, p3:  new UnityEngine.Vector3() {x = val_82, y = 0f, z = 0f});
        float val_31 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  UnityEngine.Mathf.Lerp(a:  8f, b:  5f, t:  (UnityEngine.Mathf.Min(a:  7f, b:  val_27.length)) / 7f));
        val_31 = (this.<bezierCurve>5__9.length) * val_31;
        val_79 = val_73;
        this.<duration>5__10 = val_31;
        mem[1152921523866233868] = 1065353216;
        mem[1152921523866233872] = 1;
        mem[1152921523866233880] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  3);
        label_25:
        val_77 = this.<elapsed>5__4;
        if(val_77 < 0)
        {
            goto label_52;
        }
        
        val_85 = this.<bezierCurve>5__9;
        goto label_92;
        label_52:
        float val_33 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        float val_73 = this.<speed>5__11;
        val_33 = val_33 * val_73;
        val_77 = val_77 + val_33;
        this.<elapsed>5__4 = val_77;
        val_73 = val_77 / (this.<duration>5__10);
        float val_34 = UnityEngine.Mathf.Min(a:  1f, b:  val_73);
        val_85 = val_73;
        UnityEngine.Vector3 val_35 = this.<bezierCurve>5__9.GetValue(t:  val_34);
        UnityEngine.Vector3 val_37 = this.<>4__this.transform.position;
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
        val_76 = this.<>4__this.root.transform;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.one;
        val_83 = val_40.z;
        val_77 = 1f;
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_83}, d:  UnityEngine.Mathf.Lerp(a:  0.83f, b:  val_77, t:  val_34 * 0.8f));
        val_76.localScale = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
        float val_44 = this.<bezierCurve>5__9.GetLengthForT(t:  val_34);
        if((this.<isScalingUp>5__12) == false)
        {
            goto label_66;
        }
        
        float val_47 = this.<outSine>5__13.Invoke(t:  UnityEngine.Mathf.Min(a:  1f, b:  val_44 / (this.<scaleUpLength>5__7)));
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, d:  UnityEngine.Mathf.Lerp(a:  1f, b:  this.<maxScale>5__6, t:  val_47));
        this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z};
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.zero;
        val_83 = val_53.y;
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_83, z = val_53.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_47);
        this.<>4__this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z};
        val_76 = this.<>4__this.shadow;
        float val_55 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_47);
        val_76.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        if(val_47 < 1f)
        {
            goto label_78;
        }
        
        this.<isScalingUp>5__12 = false;
        goto label_78;
        label_66:
        float val_74 = this.<scaleDownLength>5__8;
        float val_56 = val_27.length - val_44;
        if(val_56 < 0)
        {
                val_74 = val_56 / val_74;
            val_74 = val_77 - val_74;
            float val_57 = this.<outSine>5__13.Invoke(t:  val_74);
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.one;
            val_82 = this.<maxScale>5__6;
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, d:  UnityEngine.Mathf.Lerp(a:  val_82, b:  1f, t:  val_57));
            this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z};
            val_76 = this.<>4__this.shadow.transform;
            UnityEngine.Vector3 val_64 = this.<>4__this.shadow.transform.localPosition;
            val_83 = val_64.y;
            UnityEngine.Vector3 val_65 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_64.x, y = val_83, z = val_64.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_57);
            val_76.localPosition = new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z};
        }
        
        label_78:
        val_81 = this.<endSlowRatio>5__5;
        float val_66 = val_44 / val_27.length;
        if(val_66 > val_81)
        {
                var val_67 = ((this.<isTargetYBelow>5__3) == false) ? 1 : 0;
            this.<speed>5__11 = UnityEngine.Mathf.Lerp(a:  val_77, b:  36532560 + this.<isTargetYBelow>5__3 == false ? 1 : 0, t:  (val_66 - val_81) / (val_77 - val_81));
        }
        
        if((this.<elapsed>5__4) < (this.<duration>5__10))
        {
                this.<>2__current = 0;
            this.<>1__state = 2;
            val_74 = 1;
            return (bool)val_74;
        }
        
        label_92:
        val_73 = mem[this.<bezierCurve>5__9];
        Royal.Infrastructure.Utils.Animation.CubicBezierPool.Push(bezier:  val_73);
        this.<>4__this.OnReachedToCell();
        val_74 = 0;
        return (bool)val_74;
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
