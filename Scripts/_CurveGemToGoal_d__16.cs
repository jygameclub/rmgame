using UnityEngine;
private sealed class GemGoalView.<CurveGemToGoal>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView <>4__this;
    public int index;
    public bool inverseSign;
    public bool differentRandom;
    public int randomStartFrameDelay;
    public bool isMain;
    private UnityEngine.SpriteRenderer <gem>5__2;
    private UnityEngine.SpriteRenderer <gemShadow>5__3;
    private Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinTracer <tracer>5__4;
    private UnityEngine.Transform <gemTransform>5__5;
    private UnityEngine.Transform <gemShadowTransform>5__6;
    private float <duration>5__7;
    private float <elapsed>5__8;
    private UnityEngine.Vector3 <p0>5__9;
    private UnityEngine.Vector3 <p3>5__10;
    private Royal.Infrastructure.Utils.Animation.CubicBezier <bezierCurve>5__11;
    private float <localStartSpeed>5__12;
    private float <speed>5__13;
    private float <localMinSpeed>5__14;
    private float <localFinalSpeed>5__15;
    private UnityEngine.Vector3 <shadowStartPos>5__16;
    private UnityEngine.Vector3 <shadowMaxPos>5__17;
    private bool <isGoingDown>5__18;
    private UnityEngine.Vector3 <minPos>5__19;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <cubeIn>5__20;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GemGoalView.<CurveGemToGoal>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_70;
        float val_71;
        float val_72;
        float val_73;
        float val_74;
        float val_75;
        float val_76;
        var val_77;
        float val_78;
        Royal.Infrastructure.Utils.Animation.CubicBezier val_79;
        float val_84;
        float val_88;
        float val_89;
        float val_90;
        float val_91;
        var val_92;
        var val_93;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_70 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_70;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.<>4__this.transform.localPosition;
        UnityEngine.SpriteRenderer val_69 = this.<>4__this.gems[this.index];
        this.<gem>5__2 = val_69;
        this.<gemShadow>5__3 = this.<>4__this.gemShadows[this.index];
        this.<tracer>5__4 = this.<>4__this.tracers[this.index];
        this.<gemTransform>5__5 = val_69.transform;
        this.<gemShadowTransform>5__6 = this.<gemShadow>5__3.transform;
        this.<tracer>5__4.ArrangeRateOverDistanceByRatio(ratio:  1f);
        this.<tracer>5__4.Play();
        UnityEngine.Vector3 val_7 = this.<gemTransform>5__5.localScale;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  1.3f);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<gemTransform>5__5, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.1f), ease:  27);
        val_71 = this;
        this.<duration>5__7 = 0.5f;
        UnityEngine.Vector3 val_11 = this.<>4__this.goalManager.GetGoalPosition(goalType:  34);
        val_72 = this;
        this.<elapsed>5__8 = 0f;
        UnityEngine.Vector3 val_12 = this.<gemTransform>5__5.position;
        this.<p0>5__9 = val_12;
        mem[1152921520179432508] = val_12.y;
        mem[1152921520179432512] = val_12.z;
        this.<p3>5__10 = val_11;
        mem[1152921520179432520] = val_11.y;
        mem[1152921520179432524] = val_11.z;
        val_73 = -1f;
        float val_13 = (this.inverseSign == false) ? 1f : (val_73);
        if(val_2.x <= (-4f))
        {
            goto label_22;
        }
        
        if(val_2.x >= 4f)
        {
            goto label_23;
        }
        
        if(this.differentRandom == false)
        {
            goto label_24;
        }
        
        goto label_26;
        label_2:
        val_72 = this.<elapsed>5__8;
        val_71 = this.<duration>5__7;
        this.<>1__state = 0;
        goto label_27;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView>(go:  this.<>4__this);
        goto label_51;
        label_22:
        float val_15 = this.<>4__this.randomManager.Next(min:  0f, max:  2.5f);
        goto label_32;
        label_23:
        float val_16 = this.<>4__this.randomManager.Next(min:  0f, max:  2.5f);
        val_73 = 1f;
        goto label_34;
        label_24:
        label_26:
        val_73 = val_13;
        label_32:
        label_34:
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<p0>5__9, y = V15.16B, z = 0.1f}, b:  new UnityEngine.Vector3() {x = this.<p3>5__10, y = 3f, z = val_13}, t:  this.<>4__this.randomManager.Next(min:  0.1f, max:  0.8f));
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.forward;
        UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.AngleAxis(angle:  90f, axis:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__10, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = this.<p0>5__9, y = 3f, z = val_13});
        UnityEngine.Vector3 val_24 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, point:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        float val_72 = this.<>4__this.randomManager.Next(min:  2f, max:  ((((val_2.x > (-3f)) ? 1 : 0) & ((val_2.x < 3f) ? 1 : 0)) != 0) ? 3f : 2.5f);
        val_72 = val_72 * val_73;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  val_72);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  5f);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<p0>5__9, y = val_22.z, z = 3f}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  val_73, a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        float val_31 = UnityEngine.Random.value;
        val_31 = val_31 * 0.5f;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  val_31 + 0.5f);
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        val_74 = val_34.y;
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        val_75 = val_35.x;
        val_76 = val_35.z;
        this.<bezierCurve>5__11 = Royal.Infrastructure.Utils.Animation.CubicBezierPool.Pop().Init(p0:  new UnityEngine.Vector3() {x = this.<p0>5__9, y = val_35.y, z = val_35.z}, p1:  new UnityEngine.Vector3() {x = val_34.x, y = val_74, z = val_34.z}, p2:  new UnityEngine.Vector3() {x = val_75, y = val_76, z = this.<p3>5__10}, p3:  new UnityEngine.Vector3() {x = val_25.x});
        float val_39 = UnityEngine.Mathf.Lerp(a:  1f, b:  1.5f, t:  val_37.length / 15f);
        val_39 = val_39 * (this.<duration>5__7);
        this.<duration>5__7 = val_39;
        val_77 = null;
        val_77 = null;
        float val_74 = 0.5f;
        float val_75 = Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.StartSpeed;
        float val_73 = (float)this.randomStartFrameDelay;
        val_73 = val_73 * 0.1f;
        val_74 = val_73 + val_74;
        val_75 = val_75 - val_73;
        this.<localStartSpeed>5__12 = val_75;
        this.<speed>5__13 = val_75;
        val_73 = Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.MinSpeed - val_73;
        this.<localMinSpeed>5__14 = val_73;
        this.<localFinalSpeed>5__15 = val_74;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.zero;
        this.<shadowStartPos>5__16 = val_40;
        mem[1152921520179432556] = val_40.y;
        float val_41 = val_40.x + 0.1f;
        val_40.y = val_40.y + (-0.3f);
        mem[1152921520179432560] = val_40.z;
        this.<shadowMaxPos>5__17 = val_41;
        mem[1152921520179432568] = val_40.y;
        mem[1152921520179432572] = val_40.z;
        this.<isGoingDown>5__18 = true;
        UnityEngine.Vector3 val_42 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateMin(duration:  this.<duration>5__7, p0:  new UnityEngine.Vector3() {x = this.<p0>5__9, y = val_74, z = val_41}, p1:  new UnityEngine.Vector3() {x = val_34.x, y = val_74, z = val_34.z}, p2:  new UnityEngine.Vector3() {x = val_75, y = val_76, z = this.<p3>5__10}, p3:  new UnityEngine.Vector3() {x = -0.3f, y = 50f}, precision:  null);
        this.<minPos>5__19 = val_42;
        mem[1152921520179432584] = val_42.y;
        mem[1152921520179432588] = val_42.z;
        this.<cubeIn>5__20 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  8);
        label_27:
        val_78 = this.<elapsed>5__8;
        if(val_78 < 0)
        {
            goto label_48;
        }
        
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.<gem>5__2, alpha:  0f);
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.<gemShadow>5__3, alpha:  0f);
        val_79 = this.<bezierCurve>5__11;
        Royal.Infrastructure.Utils.Animation.CubicBezierPool.Push(bezier:  val_79);
        if(this.isMain == false)
        {
            goto label_51;
        }
        
        this.<>4__this.stateManager.OperationFinish(animationId:  5);
        var val_76 = 0;
        if(mem[1152921505095061504] == null)
        {
            goto label_56;
        }
        
        val_76 = val_76 + 1;
        goto label_58;
        label_51:
        val_70 = 0;
        return (bool)val_70;
        label_48:
        float val_44 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_44 = val_44 * (this.<speed>5__13);
        val_78 = val_78 + val_44;
        this.<elapsed>5__8 = val_78;
        val_44 = val_78 / (this.<duration>5__7);
        float val_45 = UnityEngine.Mathf.Clamp01(value:  val_44);
        UnityEngine.Vector3 val_46 = this.<gemTransform>5__5.position;
        UnityEngine.Vector3 val_47 = this.<bezierCurve>5__11.GetValue(t:  val_45);
        float val_48 = this.<bezierCurve>5__11.GetLengthForT(t:  val_45);
        if((this.<isGoingDown>5__18) != false)
        {
                UnityEngine.Vector3 val_49 = this.<gemTransform>5__5.position;
            if(val_47.y > val_49.y)
        {
                this.<isGoingDown>5__18 = false;
        }
        
        }
        
        float val_77 = val_47.x;
        this.<gemTransform>5__5.position = new UnityEngine.Vector3() {x = val_77, y = val_47.y, z = val_47.z};
        if((this.<isGoingDown>5__18) == false)
        {
            goto label_70;
        }
        
        val_77 = val_77 - val_47.y;
        float val_51 = (val_77 - val_47.y) / val_77;
        val_76 = this.<shadowStartPos>5__16;
        val_79 = this.<gemShadowTransform>5__6.transform;
        val_84 = val_51;
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_76, y = val_35.y, z = val_48}, b:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__17, y = val_47.z, z = val_47.y}, t:  val_84);
        val_79.localPosition = new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z};
        val_88 = this.<localStartSpeed>5__12;
        val_89 = val_88;
        val_90 = this.<localMinSpeed>5__14;
        val_91 = val_51;
        goto label_89;
        label_70:
        val_77 = val_47.y - val_77;
        val_77 = (val_47.y - val_77) / val_77;
        val_84 = this.<cubeIn>5__20.Invoke(t:  val_77);
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__17, y = val_76, z = val_48}, b:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__16, y = val_47.z, z = val_47.x}, t:  val_84);
        float val_58 = val_48 / (this.<bezierCurve>5__11.length);
        this.<gemShadowTransform>5__6.transform.localPosition = new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
        val_79 = 1152921505094918144;
        if(val_58 >= 0)
        {
            goto label_83;
        }
        
        val_92 = null;
        val_92 = null;
        val_88 = Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.MaxSpeed;
        float val_60 = 0.5f - val_58;
        val_60 = val_60 + val_60;
        val_60 = 1f - val_60;
        val_89 = this.<localStartSpeed>5__12;
        val_90 = val_88;
        val_91 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  2).Invoke(t:  val_60);
        goto label_89;
        label_56:
        Royal.Scenes.Game.Mechanics.Items.RockItem.View.IRockItemViewDelegate val_62 = 1152921505095024640 + ((mem[1152921505095061512]) << 4);
        label_58:
        this.<>4__this.viewDelegate.CollectCompleted();
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = 2;
        val_70 = 1;
        return (bool)val_70;
        label_83:
        val_93 = null;
        val_93 = null;
        val_88 = this.<localFinalSpeed>5__15;
        float val_78 = -0.5f;
        val_78 = val_58 + val_78;
        val_91 = val_78 + val_78;
        val_89 = Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView.MaxSpeed;
        val_90 = val_88;
        label_89:
        this.<speed>5__13 = UnityEngine.Mathf.Lerp(a:  val_89, b:  val_90, t:  val_91);
        UnityEngine.Vector3 val_66 = this.<>4__this.transform.position;
        val_75 = val_66.y;
        UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__10, y = val_88, z = val_58}, b:  new UnityEngine.Vector3() {x = val_66.x, y = val_75, z = val_66.z});
        val_78 = val_67.x;
        UnityEngine.Vector3 val_68 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__10, y = val_67.y, z = val_67.z}, b:  new UnityEngine.Vector3() {x = this.<p0>5__9, y = val_75, z = val_66.z});
        val_68.x = val_78 / val_68.x;
        this.<tracer>5__4.ArrangeRateOverDistanceByRatio(ratio:  val_68.x);
        val_70 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_70;
        return (bool)val_70;
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
