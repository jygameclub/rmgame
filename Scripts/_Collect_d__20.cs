using UnityEngine;
private sealed class MatchCollectManagerAnimation.<Collect>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate viewDelegate;
    private bool <isSpecialItem>5__2;
    private int <curtainHorizontalPosition>5__3;
    private int <curtainVerticalPosition>5__4;
    private int <offset>5__5;
    private UnityEngine.Transform <transform>5__6;
    private int <sorting>5__7;
    private float <minSpeedVar>5__8;
    private float <startSpeedVar>5__9;
    private float <elapsed>5__10;
    private UnityEngine.Vector3 <p0>5__11;
    private UnityEngine.Vector3 <p1>5__12;
    private UnityEngine.Vector3 <p2>5__13;
    private UnityEngine.Transform <shadowParent>5__14;
    private UnityEngine.Vector3 <shadowStartPos>5__15;
    private UnityEngine.Vector3 <shadowMaxPos>5__16;
    private UnityEngine.Quaternion <startRotation>5__17;
    private UnityEngine.Quaternion <maxRotation>5__18;
    private bool <isGoingDown>5__19;
    private UnityEngine.Vector3 <minPos>5__20;
    private float <speed>5__21;
    private float <maxSpeed>5__22;
    private bool <setItemUiSorting>5__23;
    private UnityEngine.Vector3 <previousPosition>5__24;
    private UnityEngine.Vector3 <previousTransPos>5__25;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MatchCollectManagerAnimation.<Collect>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_75;
        var val_76;
        Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_77;
        float val_78;
        float val_80;
        float val_81;
        float val_82;
        float val_84;
        float val_87;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_75 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_75;
        }
        
        this.<>1__state = 0;
        this.<isSpecialItem>5__2 = ((this.<>1__state) == 2) ? 1 : 0;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_4 = this.itemView.transform.position;
        goto label_11;
        label_1:
        this.<>1__state = 0;
        goto label_12;
        label_2:
        this.<>1__state = 0;
        goto label_51;
        label_11:
        this.<curtainHorizontalPosition>5__3 = 0;
        if(mem[1152921505098203136] != null)
        {
            
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_6 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        }
        
        val_5.x = val_5.x - val_5.x;
        if(val_5.x <= 0.1f)
        {
            goto label_23;
        }
        
        goto label_24;
        label_23:
        if(mem[1152921505098203136] != null)
        {
            
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_7 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        }
        
        val_5.x = val_5.x - val_5.x;
        if(val_5.x >= 0)
        {
            goto label_30;
        }
        
        label_24:
        this.<curtainHorizontalPosition>5__3 = 1;
        label_30:
        this.<curtainVerticalPosition>5__4 = 0;
        if(mem[1152921505098203136] != null)
        {
            
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_8 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        }
        
        this.<curtainVerticalPosition>5__4 = ((val_5.y - (-0.1f)) >= 2f) ? 0 : (0 + 1);
        if(this.collectData < 1)
        {
            goto label_36;
        }
        
        label_38:
        if(this.collectData == this.currentCell)
        {
            goto label_37;
        }
        
        if(1 < this.collectData.orderedCells)
        {
            goto label_38;
        }
        
        label_36:
        label_37:
        this.<offset>5__5 = 0;
        val_77 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).GetOperationCount(animationId:  5);
        UnityEngine.Transform val_13 = this.itemView.transform;
        this.<transform>5__6 = val_13;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        val_13.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        val_13.SetScale(vector:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        int val_76 = this.<offset>5__5;
        if((this.<isSpecialItem>5__2) != false)
        {
                int val_16 = 1020 + (val_76 * 20);
            this.<sorting>5__7 = val_16;
            this.itemView.SetSortingForCollect(offset:  val_16);
        }
        else
        {
                val_76 = (1000 - val_77) + (val_76 * 10);
            this.<sorting>5__7 = val_76;
        }
        
        this.itemView.shadowView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        var val_18 = ((this.<isSpecialItem>5__2) == false) ? 1 : 0;
        float val_77 = (float)this.<offset>5__5;
        val_77 = (36530472 + this.<isSpecialItem>5__2 == false ? 1 : 0) * val_77;
        val_78 = ((W23 == 0) ? 0f : 0.02f) + val_77;
        if(val_78 > 0f)
        {
                val_75 = 1;
            this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_78);
            this.<>1__state = val_75;
            return (bool)val_75;
        }
        
        label_51:
        this.<minSpeedVar>5__8 = 1;
        if((this.<isSpecialItem>5__2) == true)
        {
            goto label_57;
        }
        
        this.itemView.SetSortingForCollect(offset:  this.<sorting>5__7);
        if((this.<isSpecialItem>5__2) != true)
        {
            goto label_57;
        }
        
        if((this.<isSpecialItem>5__2) == true)
        {
            goto label_56;
        }
        
        if((this.<isSpecialItem>5__2) != true)
        {
            goto label_57;
        }
        
        float val_78 = -0.1f;
        float val_80 = this.<startSpeedVar>5__9;
        float val_79 = (float)this.<offset>5__5;
        val_78 = val_79 * val_78;
        val_78 = (this.<minSpeedVar>5__8) + val_78;
        this.<minSpeedVar>5__8 = val_78;
        val_79 = val_79 * 0.2f;
        if((this.<curtainVerticalPosition>5__4) == 1)
        {
            goto label_58;
        }
        
        val_80 = val_80 - val_79;
        goto label_71;
        label_56:
        float val_82 = -0.4f;
        float val_81 = -0.5f;
        float val_83 = (float)this.<offset>5__5;
        val_81 = val_83 * val_81;
        val_82 = val_83 * val_82;
        val_83 = val_83 * (-0.2f);
        float val_26 = val_81 + (-1f);
        float val_27 = val_82 + (-2.5f);
        val_83 = (this.<startSpeedVar>5__9) + val_83;
        goto label_71;
        label_58:
        val_79 = val_79 * (-0.5f);
        val_80 = val_80 + val_79;
        label_71:
        this.<startSpeedVar>5__9 = val_80;
        label_57:
        this.<elapsed>5__10 = 0f;
        UnityEngine.Vector3 val_29 = this.<transform>5__6.position;
        this.<p0>5__11 = val_29;
        mem[1152921520250387276] = val_29.y;
        mem[1152921520250387280] = val_29.z;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
        mem[1152921520250387288] = val_30.y;
        float val_84 = (float)this.<curtainHorizontalPosition>5__3;
        val_84 = (-1f) * val_84;
        val_84 = (this.<p0>5__11) + val_84;
        mem[1152921520250387292] = val_30.z;
        this.<p1>5__12 = val_84;
        if((this.<curtainVerticalPosition>5__4) == 1)
        {
                float val_31 = ((-2.5f) - val_79) + (this.<p0>5__11);
        }
        else
        {
                if(mem[1152921505098203136] != null)
        {
            
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_32 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        }
        
            float val_85 = -2.5f;
            val_85 = (this.<p0>5__11) + val_85;
        }
        
        mem[1152921520250387288] = val_85;
        this.<p2>5__13 = this.<p1>5__12;
        mem[1152921520250387300] = val_85;
        mem[1152921520250387304] = mem[1152921505098203144];
        this.<shadowParent>5__14 = this.itemView.shadowParent;
        UnityEngine.Vector3 val_34 = this.itemView.shadowParent.transform.localPosition;
        mem[1152921520250387328] = val_34.z;
        mem[1152921520250387340] = val_34.z;
        this.<shadowStartPos>5__15 = val_34;
        mem[1152921520250387324] = val_34.y;
        val_34.y = val_34.y + (-0.5f);
        val_34.x = val_34.x + 0.3f;
        this.<shadowMaxPos>5__16 = val_34.x;
        mem[1152921520250387336] = val_34.y;
        UnityEngine.Quaternion val_35 = this.<transform>5__6.localRotation;
        this.<startRotation>5__17 = val_35;
        mem[1152921520250387348] = val_35.y;
        mem[1152921520250387352] = val_35.z;
        float val_36 = ((float)this.<curtainHorizontalPosition>5__3) * 5f;
        mem[1152921520250387356] = val_35.w;
        UnityEngine.Quaternion val_37 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.<maxRotation>5__18 = val_37;
        mem[1152921520250387364] = val_37.y;
        mem[1152921520250387368] = val_37.z;
        mem[1152921520250387372] = val_37.w;
        this.<isGoingDown>5__19 = true;
        val_76 = 1152921505098166272;
        if(mem[1152921505098203136] != null)
        {
            
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_38 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        }
        
        UnityEngine.Vector3 val_39 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateMin(duration:  0.7f, p0:  new UnityEngine.Vector3() {x = this.<p0>5__11, y = V11.16B, z = V12.16B}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__12, y = V14.16B, z = ???}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__13, y = ???, z = this.<p0>5__11}, p3:  new UnityEngine.Vector3() {x = val_37.z, y = 50f}, precision:  0f);
        this.<minPos>5__20 = val_39;
        mem[1152921520250387384] = val_39.y;
        mem[1152921520250387388] = val_39.z;
        this.<speed>5__21 = 1f;
        if(mem[1152921505098203136] != null)
        {
            
        }
        else
        {
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_40 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        }
        
        val_80 = val_39.y;
        val_81 = val_39.z;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_80, z = val_81}, b:  new UnityEngine.Vector3() {x = this.<minPos>5__20, y = V12.16B, z = V11.16B});
        float val_86 = -8f;
        val_86 = val_41.x + val_86;
        val_86 = val_86 / (-10f);
        float val_42 = val_86 + 1f;
        this.<maxSpeed>5__22 = UnityEngine.Mathf.Lerp(a:  0.2f, b:  1f, t:  val_42);
        this.<setItemUiSorting>5__23 = false;
        UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<minPos>5__20, y = 1f, z = val_42}, b:  new UnityEngine.Vector3() {x = this.<p0>5__11, y = V12.16B, z = V11.16B});
        if((this.<curtainVerticalPosition>5__4) == 1)
        {
                float val_87 = -5f;
            val_87 = val_44.x + val_87;
            val_82 = val_87 / 5f;
            float val_45 = UnityEngine.Mathf.Lerp(a:  2f, b:  5f, t:  val_82);
            val_45 = (this.<startSpeedVar>5__9) / val_45;
            this.<startSpeedVar>5__9 = val_45;
        }
        
        UnityEngine.Vector3 val_46 = this.<transform>5__6.position;
        this.<previousPosition>5__24 = val_46;
        mem[1152921520250387408] = val_46.y;
        mem[1152921520250387412] = val_46.z;
        UnityEngine.Vector3 val_47 = this.<transform>5__6.position;
        this.<previousTransPos>5__25 = val_47;
        mem[1152921520250387420] = val_47.y;
        mem[1152921520250387424] = val_47.z;
        this.<speed>5__21 = this.<startSpeedVar>5__9;
        label_12:
        if((this.<elapsed>5__10) < 0)
        {
            goto label_110;
        }
        
        if(mem[1152921505098203136] == null)
        {
            goto label_113;
        }
        
        goto label_115;
        label_110:
        float val_49 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_49 = val_49 * (this.<speed>5__21);
        float val_50 = (this.<elapsed>5__10) + val_49;
        this.<elapsed>5__10 = val_50;
        val_77 = 1152921505098166272;
        var val_88 = 0;
        if(mem[1152921505098203136] == null)
        {
            goto label_118;
        }
        
        val_88 = val_88 + 1;
        val_84 = val_47.z;
        goto label_120;
        label_113:
        var val_89 = mem[1152921505098203144];
        val_89 = val_89 + 3;
        Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_51 = 1152921505098166272 + val_89;
        label_115:
        Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  this.collectManager.GetCollectAudioClipType(), offset:  0.04f);
        val_77 = this.itemView;
        UnityEngine.Vector3 val_53 = this.<transform>5__6.position;
        val_78 = val_53.x;
        var val_90 = 0;
        if(mem[1152921505097670656] == null)
        {
            goto label_125;
        }
        
        val_90 = val_90 + 1;
        goto label_127;
        label_118:
        val_84 = val_47.z;
        Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_54 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        label_120:
        UnityEngine.Vector3 val_55 = this.collectManager.GetCollectPosition();
        float val_91 = 0.7f;
        val_91 = val_50 / val_91;
        val_87 = val_91;
        UnityEngine.Vector3 val_56 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_87, p0:  new UnityEngine.Vector3() {x = this.<p0>5__11, y = val_84, z = this.<minPos>5__20}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__12, y = this.<p0>5__11, z = this.<p0>5__11}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__13, y = val_44.x, z = val_55.x}, p3:  new UnityEngine.Vector3() {x = val_55.z, y = 50f});
        float val_93 = val_56.y;
        if(((this.<isGoingDown>5__19) != false) && (val_93 > val_56.x))
        {
                this.<isGoingDown>5__19 = false;
        }
        
        this.<previousPosition>5__24 = val_56;
        mem[1152921520250387408] = val_93;
        mem[1152921520250387412] = val_56.z;
        UnityEngine.Vector3 val_57 = this.<transform>5__6.position;
        this.<previousTransPos>5__25 = val_57;
        mem[1152921520250387420] = val_57.y;
        mem[1152921520250387424] = val_57.z;
        float val_92 = val_56.x;
        this.<transform>5__6.position = new UnityEngine.Vector3() {x = val_92, y = val_93, z = val_56.z};
        if((this.<isGoingDown>5__19) == false)
        {
            goto label_132;
        }
        
        val_92 = val_92 - val_93;
        val_93 = (val_92 - val_93) / val_92;
        UnityEngine.Vector3 val_59 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__15, y = val_56.z, z = this.<p1>5__12}, b:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__16, y = this.<elapsed>5__10, z = this.<p2>5__13}, t:  val_93);
        this.<shadowParent>5__14.localPosition = new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z};
        UnityEngine.Quaternion val_60 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<startRotation>5__17, y = this.<shadowStartPos>5__15, z = val_56.z, w = this.<p2>5__13}, b:  new UnityEngine.Quaternion() {x = this.<maxRotation>5__18, y = val_84, z = this.<shadowMaxPos>5__16, w = this.<p1>5__12}, t:  val_93);
        this.<transform>5__6.localRotation = new UnityEngine.Quaternion() {x = val_60.x, y = val_60.y, z = val_60.z, w = val_60.w};
        val_78 = this.<minSpeedVar>5__8;
        label_166:
        this.<speed>5__21 = UnityEngine.Mathf.Lerp(a:  this.<startSpeedVar>5__9, b:  val_78, t:  val_93);
        goto label_163;
        label_132:
        var val_94 = 0;
        if(mem[1152921505098203136] == null)
        {
            goto label_144;
        }
        
        val_94 = val_94 + 1;
        goto label_146;
        label_125:
        var val_95 = mem[1152921505097670664];
        val_95 = val_95 + 1;
        Royal.Scenes.Game.Mechanics.Items.MatchItem.View.IMatchItemViewDelegate val_62 = 1152921505097633792 + val_95;
        label_127:
        this.viewDelegate.ManagerCollectCompleted(itemView:  val_77, collectManager:  this.collectManager, hitFromLeft:  ((this.<previousTransPos>5__25) < 0) ? 1 : 0);
        val_75 = 0;
        return (bool)val_75;
        label_144:
        Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_64 = 1152921505098166272 + ((mem[1152921505098203144]) << 4);
        label_146:
        UnityEngine.Vector3 val_65 = this.collectManager.GetCollectPosition();
        val_77 = 1152921504781127680;
        val_65.x = val_65.y - val_65.x;
        val_93 = (val_93 - val_84) / val_65.x;
        UnityEngine.Vector3 val_67 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__16, y = val_56.z, z = this.<p1>5__12}, b:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__15, y = this.<elapsed>5__10, z = this.<p2>5__13}, t:  val_93);
        this.<shadowParent>5__14.localPosition = new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z};
        UnityEngine.Quaternion val_69 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<maxRotation>5__18, y = this.<p2>5__13, z = this.<shadowStartPos>5__15, w = this.<p1>5__12}, b:  new UnityEngine.Quaternion() {x = this.<startRotation>5__17, y = this.<elapsed>5__10, z = val_84, w = this.<shadowMaxPos>5__16}, t:  val_93 + val_93);
        this.<transform>5__6.localRotation = new UnityEngine.Quaternion() {x = val_69.x, y = val_69.y, z = val_69.z, w = val_69.w};
        if(val_93 <= 0.8f)
        {
            goto label_154;
        }
        
        float val_96 = -0.8f;
        float val_97 = 5f;
        val_96 = val_93 + val_96;
        val_97 = (this.<maxSpeed>5__22) / val_97;
        float val_70 = val_96 / 0.2f;
        this.<speed>5__21 = UnityEngine.Mathf.Lerp(a:  this.<maxSpeed>5__22, b:  val_97, t:  val_70);
        if((this.<setItemUiSorting>5__23) != true)
        {
                this.<setItemUiSorting>5__23 = true;
            this.itemView.SetSortingForCollectOnUi();
        }
        
        UnityEngine.Vector3 val_72 = UnityEngine.Vector3.one;
        val_78 = val_72.x;
        val_80 = val_72.y;
        UnityEngine.Vector3 val_73 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_74 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z}, d:  val_93);
        UnityEngine.Vector3 val_75 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_78, y = val_80, z = val_72.z}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z}, t:  val_70);
        this.<transform>5__6.localScale = new UnityEngine.Vector3() {x = val_75.x, y = val_75.y, z = val_75.z};
        goto label_163;
        label_154:
        if(val_93 >= 0)
        {
            goto label_163;
        }
        
        goto label_166;
        label_163:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_75 = 1;
        return (bool)val_75;
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
