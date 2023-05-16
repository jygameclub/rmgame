using UnityEngine;
private sealed class MatchBezierCollect.<CollectToGoalAnimation>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView;
    public UnityEngine.Vector3 goalPosition;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate itemViewDelegate;
    private bool <isSpecialItem>5__2;
    private int <offset>5__3;
    private UnityEngine.Transform <transform>5__4;
    private UnityEngine.SpriteRenderer <shadowView>5__5;
    private int <sorting>5__6;
    private float <minSpeedVar>5__7;
    private float <startSpeedVar>5__8;
    private float <elapsed>5__9;
    private UnityEngine.Vector3 <p0>5__10;
    private UnityEngine.Vector3 <p3>5__11;
    private UnityEngine.Vector3 <p1>5__12;
    private UnityEngine.Vector3 <p2>5__13;
    private UnityEngine.Vector3 <shadowStartPos>5__14;
    private UnityEngine.Vector3 <shadowMaxPos>5__15;
    private UnityEngine.Quaternion <startRotation>5__16;
    private UnityEngine.Quaternion <maxRotation>5__17;
    private bool <isGoingDown>5__18;
    private UnityEngine.Vector3 <minPos>5__19;
    private float <speed>5__20;
    private float <maxSpeed>5__21;
    private bool <setItemUiSorting>5__22;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MatchBezierCollect.<CollectToGoalAnimation>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_55;
        int val_56;
        var val_57;
        var val_58;
        float val_59;
        float val_60;
        UnityEngine.Vector3 val_62;
        float val_63;
        val_55 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_56 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_56;
        }
        
        this.<>1__state = 0;
        mem[1152921520248301704] = (W9 == 2) ? 1 : 0;
        if(this.collectData < 1)
        {
            goto label_4;
        }
        
        label_6:
        if(1152921520248301520 == this.currentCell)
        {
            goto label_5;
        }
        
        if(1 < this.collectData)
        {
            goto label_6;
        }
        
        label_4:
        label_5:
        this.<offset>5__3 = 0;
        val_57 = 0;
        UnityEngine.Transform val_4 = this.itemView.transform;
        this.<transform>5__4 = val_4;
        this.<shadowView>5__5 = this.itemView.shadowView;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_4.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        val_4.SetScale(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        int val_54 = this.<offset>5__3;
        if((this.<isSpecialItem>5__2) == false)
        {
            goto label_15;
        }
        
        int val_7 = 1020 + (val_54 * 20);
        this.<sorting>5__6 = val_7;
        this.itemView.SetSortingForCollect(offset:  val_7);
        goto label_17;
        label_2:
        this.<>1__state = 0;
        goto label_21;
        label_1:
        val_59 = this.<elapsed>5__9;
        this.<>1__state = 0;
        goto label_19;
        label_15:
        val_54 = (1000 - (Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).GetOperationCount(animationId:  5))) + (val_54 * 10);
        this.<sorting>5__6 = val_54;
        label_17:
        this.<shadowView>5__5.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        var val_9 = ((this.<isSpecialItem>5__2) == false) ? 1 : 0;
        float val_55 = (float)this.<offset>5__3;
        val_55 = (36530472 + this.<isSpecialItem>5__2 == false ? 1 : 0) * val_55;
        val_60 = ((this.currentCell == 0) ? 0f : 0.02f) + val_55;
        if(val_60 > 0f)
        {
                val_56 = 1;
            this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_60);
            this.<>1__state = val_56;
            return (bool)val_56;
        }
        
        label_21:
        this.<minSpeedVar>5__7 = 1;
        if((this.<isSpecialItem>5__2) == true)
        {
            goto label_28;
        }
        
        this.itemView.SetSortingForCollect(offset:  this.<sorting>5__6);
        if((this.<isSpecialItem>5__2) != true)
        {
            goto label_28;
        }
        
        if((this.<isSpecialItem>5__2) == true)
        {
            goto label_26;
        }
        
        if((this.<isSpecialItem>5__2) != true)
        {
            goto label_28;
        }
        
        float val_12 = (-2.5f) - ((float)this.<offset>5__3);
        double val_56 = (double)V4.2S;
        val_56 = val_56 * (1.34110482108429E-08);
        val_56 = (this.<minSpeedVar>5__7) - val_56;
        this.<minSpeedVar>5__7 = val_56;
        goto label_28;
        label_26:
        float val_58 = -0.4f;
        float val_57 = -0.5f;
        float val_59 = (float)this.<offset>5__3;
        val_57 = val_59 * val_57;
        val_58 = val_59 * val_58;
        val_59 = val_59 * (-0.2f);
        val_59 = (this.<startSpeedVar>5__8) + val_59;
        this.<startSpeedVar>5__8 = val_59;
        label_28:
        val_59 = val_55;
        this.<elapsed>5__9 = 0f;
        UnityEngine.Vector3 val_15 = this.<transform>5__4.position;
        this.<p0>5__10 = val_15;
        mem[1152921520248301748] = val_15.y;
        mem[1152921520248301752] = val_15.z;
        this.<p3>5__11 = this.goalPosition;
        mem[1152921520248301764] = ???;
        var val_16 = (this.goalPosition < 0) ? 1 : 0;
        if(((this.<p3>5__11) == 1) && ((this.<p3>5__11) == 2))
        {
                val_57 = 0;
            UnityEngine.Vector3 val_19 = mem[this.collectData + 56].transform.position;
        }
        
        val_58 = 1152921504781127680;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_60 = this.<p0>5__10;
        float val_23 = ((((this.goalPosition < 0) ? 1 : 0) & ((this.goalPosition < 0) ? 1 : 0)) != 0) ? 1f : 0f;
        val_23 = (val_57 + (-1f)) * val_23;
        val_60 = val_23 + val_60;
        float val_24 = (val_58 + (-2.5f)) + val_58;
        mem[1152921520248301776] = val_22.z;
        this.<p1>5__12 = val_60;
        mem[1152921520248301772] = val_24;
        this.<p2>5__13 = val_60;
        mem[1152921520248301784] = val_24;
        mem[1152921520248301788] = val_22.z;
        UnityEngine.Vector3 val_26 = this.itemView.shadowView.transform.localPosition;
        mem[1152921520248301800] = val_26.z;
        mem[1152921520248301812] = val_26.z;
        this.<shadowStartPos>5__14 = val_26;
        mem[1152921520248301796] = val_26.y;
        val_26.y = val_26.y + (-0.5f);
        val_26.x = val_26.x + 0.3f;
        this.<shadowMaxPos>5__15 = val_26.x;
        mem[1152921520248301808] = val_26.y;
        UnityEngine.Quaternion val_27 = this.<transform>5__4.localRotation;
        this.<startRotation>5__16 = val_27;
        mem[1152921520248301820] = val_27.y;
        mem[1152921520248301824] = val_27.z;
        mem[1152921520248301828] = val_27.w;
        UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.<maxRotation>5__17 = val_28;
        mem[1152921520248301836] = val_28.y;
        mem[1152921520248301840] = val_28.z;
        mem[1152921520248301844] = val_28.w;
        this.<isGoingDown>5__18 = true;
        UnityEngine.Vector3 val_29 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateMin(duration:  0.7f, p0:  new UnityEngine.Vector3() {x = this.<p0>5__10, y = val_28.z, z = val_28.w}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__12}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__13.x, y = ???, z = this.<p3>5__11.x}, p3:  new UnityEngine.Vector3() {x = val_28.x, y = 50f}, precision:  0f);
        this.<minPos>5__19 = val_29;
        mem[1152921520248301856] = val_29.y;
        mem[1152921520248301860] = val_29.z;
        this.<speed>5__20 = 0.2f;
        val_62 = this.goalPosition;
        val_63 = val_29.x;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_62, y = this.goalPosition, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_63, y = val_29.y, z = val_29.z});
        float val_61 = -8f;
        val_61 = val_30.x + val_61;
        val_61 = val_61 / (-10f);
        float val_31 = val_61 + 1f;
        this.<maxSpeed>5__21 = UnityEngine.Mathf.Lerp(a:  0.2f, b:  1f, t:  val_31);
        this.<setItemUiSorting>5__22 = false;
        label_19:
        val_60 = 0.7f;
        if((this.<elapsed>5__9) < 0)
        {
            goto label_47;
        }
        
        val_55 = this.itemView;
        var val_62 = 0;
        if(mem[1152921505097670656] == null)
        {
            goto label_50;
        }
        
        val_62 = val_62 + 1;
        val_57 = 0;
        goto label_52;
        label_47:
        float val_33 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_33 = val_33 * (this.<speed>5__20);
        val_33 = (this.<elapsed>5__9) + val_33;
        this.<elapsed>5__9 = val_33;
        val_33 = val_33 / val_60;
        UnityEngine.Vector3 val_34 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_33, p0:  new UnityEngine.Vector3() {x = this.<p0>5__10, y = val_31, z = val_63}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__12, y = val_29.z}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__13.x, y = this.<speed>5__20, z = this.<p3>5__11.x}, p3:  new UnityEngine.Vector3() {x = ???, y = 50f});
        if((this.<isGoingDown>5__18) != false)
        {
                UnityEngine.Vector3 val_35 = this.<transform>5__4.position;
            if(val_34.y > val_35.y)
        {
                this.<isGoingDown>5__18 = false;
        }
        
        }
        
        float val_63 = val_34.x;
        this.<transform>5__4.position = new UnityEngine.Vector3() {x = val_63, y = val_34.y, z = val_34.z};
        if((this.<isGoingDown>5__18) == false)
        {
            goto label_57;
        }
        
        val_63 = val_63 - val_34.y;
        float val_37 = (val_63 - val_34.y) / val_63;
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__14, y = val_34.z, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__15, y = val_34.y, z = val_29.y}, t:  val_37);
        this.<shadowView>5__5.transform.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
        UnityEngine.Quaternion val_40 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<startRotation>5__16, y = val_34.z, z = val_29.y, w = this.<shadowMaxPos>5__15}, b:  new UnityEngine.Quaternion() {x = this.<maxRotation>5__17, y = V15.16B, z = V13.16B, w = val_37}, t:  val_37);
        this.<transform>5__4.localRotation = new UnityEngine.Quaternion() {x = val_40.x, y = val_40.y, z = val_40.z, w = val_40.w};
        val_60 = this.<minSpeedVar>5__7;
        label_84:
        this.<speed>5__20 = UnityEngine.Mathf.Lerp(a:  this.<startSpeedVar>5__8, b:  val_60, t:  val_37);
        label_81:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_56 = 1;
        return (bool)val_56;
        label_57:
        val_63 = val_34.y - val_63;
        float val_43 = (val_34.y - val_63) / val_63;
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__15, y = val_34.z, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__14, y = val_34.y, z = val_29.y}, t:  val_43);
        this.<shadowView>5__5.transform.localPosition = new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z};
        UnityEngine.Quaternion val_47 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<maxRotation>5__17, y = val_29.y, z = this.<shadowStartPos>5__14, w = V13.16B}, b:  new UnityEngine.Quaternion() {x = this.<startRotation>5__16, y = this.<shadowMaxPos>5__15, z = val_43, w = V15.16B}, t:  val_43 + val_43);
        this.<transform>5__4.localRotation = new UnityEngine.Quaternion() {x = val_47.x, y = val_47.y, z = val_47.z, w = val_47.w};
        val_47.x = val_47.x - val_47.y;
        float val_64 = -3f;
        val_64 = val_47.x + val_64;
        float val_48 = val_64 / val_47.x;
        if(val_43 <= val_48)
        {
            goto label_75;
        }
        
        float val_49 = val_43 - val_48;
        val_49 = val_49 / (1f - val_48);
        this.<speed>5__20 = UnityEngine.Mathf.Lerp(a:  this.<maxSpeed>5__21, b:  (this.<maxSpeed>5__21) / 5f, t:  val_49);
        if((this.<setItemUiSorting>5__22) == true)
        {
            goto label_81;
        }
        
        this.<setItemUiSorting>5__22 = true;
        this.itemView.SetSortingForCollectOnUi();
        goto label_81;
        label_50:
        Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_53 = 1152921505097633792 + ((mem[1152921505097670664]) << 4);
        label_52:
        this.itemViewDelegate.CollectAnimationCompleted(itemView:  val_55);
        val_56 = 0;
        return (bool)val_56;
        label_75:
        if(val_43 >= 0)
        {
            goto label_81;
        }
        
        goto label_84;
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
