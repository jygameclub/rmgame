using UnityEngine;
private sealed class LightballItemRay.<MoveAndDestroy>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay <>4__this;
    private UnityEngine.Vector3 <startPosition>5__2;
    private UnityEngine.Vector3 <targetViewPos>5__3;
    private bool <didReach>5__4;
    private float <elapsed>5__5;
    private float <duration>5__6;
    private float <colorStartWidth>5__7;
    private float <whiteStartWidth>5__8;
    private float <startAlpha>5__9;
    private float <whiteFadeStartTime>5__10;
    private float <whiteFadeEndTime>5__11;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LightballItemRay.<MoveAndDestroy>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg val_39;
        float val_40;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_30 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_30;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.<>4__this.transform.position;
        this.<startPosition>5__2 = val_2;
        mem[1152921520130927836] = val_2.y;
        mem[1152921520130927840] = val_2.z;
        this.<>4__this.whiteLine.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.<>4__this.colorLine.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = this.<startPosition>5__2, y = val_2.y, z = val_2.z});
        val_31 = this;
        this.<elapsed>5__5 = 0f;
        this.<duration>5__6 = 0.2333333f;
        mem[1152921520130927844] = this.<startPosition>5__2;
        mem[1152921520130927848] = val_2.y;
        mem[1152921520130927852] = val_2.z;
        mem[1152921520130927856] = 0;
        this.<colorStartWidth>5__7 = this.<>4__this.colorLine.widthMultiplier;
        this.<whiteStartWidth>5__8 = this.<>4__this.whiteLine.widthMultiplier;
        goto label_11;
        label_1:
        val_32 = this.<elapsed>5__5;
        val_33 = this.<duration>5__6;
        this.<>1__state = 0;
        if(val_32 < 0)
        {
            goto label_12;
        }
        
        this.<>4__this.colorLine.enabled = false;
        this.<>4__this.whiteLine.enabled = false;
        this.<>4__this = 0;
        int val_30 = this.<>4__this.lightballStrategy.incompleteRays;
        val_30 = 0;
        val_30 = val_30 - 1;
        this.<>4__this.lightballStrategy = val_30;
        return (bool)val_30;
        label_2:
        val_31 = this.<elapsed>5__5;
        this.<>1__state = 0;
        label_11:
        val_34 = this.<duration>5__6;
        if((this.<elapsed>5__5) >= 0)
        {
                if((this.<>4__this) != null)
        {
            goto label_23;
        }
        
        }
        
        val_34 = (this.<elapsed>5__5) + Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_31 = val_34;
        if(((this.<>4__this.targetModel) & 1) != 0)
        {
                this.<targetViewPos>5__3 = val_34;
            mem[1152921520130927848] = ???;
            mem[1152921520130927852] = ???;
            float val_7 = UnityEngine.Mathf.Clamp(value:  (this.<elapsed>5__5) / (this.<duration>5__6), min:  0f, max:  1f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<startPosition>5__2, y = V14.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.<targetViewPos>5__3, y = V12.16B, z = this.<duration>5__6}, t:  ManualEasing.Sine.Out(t:  val_7));
            val_36 = val_9.x;
            val_37 = val_9.z;
            this.<>4__this.whiteLine.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.<>4__this.colorLine.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_36, y = val_9.y, z = val_37});
            this.<>4__this.colorLine.widthMultiplier = UnityEngine.Mathf.Lerp(a:  (this.<colorStartWidth>5__7) * 1.2f, b:  this.<colorStartWidth>5__7, t:  ManualEasing.Sine.In(t:  val_7));
            val_38 = this.<whiteStartWidth>5__8;
            this.<>4__this.whiteLine.widthMultiplier = UnityEngine.Mathf.Lerp(a:  val_38 * 1.2f, b:  val_38, t:  ManualEasing.Sine.In(t:  val_7));
            if((this.<didReach>5__4) != true)
        {
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_36, y = val_9.y, z = val_37}, b:  new UnityEngine.Vector3() {x = this.<targetViewPos>5__3, y = val_7, z = val_38});
            if(val_16.x <= 0.4f)
        {
                this.<didReach>5__4 = true;
            if(((this.<>4__this.targetModel) & 1) != 0)
        {
                bool val_17 = this.<>4__this.targetModel.HasCurrentCell();
        }
        
        }
        
        }
        
            val_39 = this.<>4__this.lightballBg;
            if(val_39 != 0)
        {
                UnityEngine.Vector3 val_20 = this.<>4__this.colorLine.GetPosition(index:  1);
            this.<>4__this.lightballBg.rayTipParticle.transform.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        }
        
            val_30 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_30;
            return (bool)val_30;
        }
        
        label_23:
        this.<>4__this = 1;
        int val_31 = this.<>4__this.lightballStrategy.unCollectedRays;
        val_31 = val_31 - 1;
        this.<>4__this.lightballStrategy = val_31;
        this.<>4__this.lightballStrategy = Royal.Scenes.Game.Levels.LevelContext.Time;
        val_39 = this.<startPosition>5__2;
        UnityEngine.Color val_22 = this.<>4__this.whiteLine.startColor;
        val_33 = 3.81469872727062E-07;
        val_40 = 0f;
        this.<startAlpha>5__9 = val_22.a;
        this.<startPosition>5__2 = val_39;
        mem[1152921520130927840] = ???;
        this.<elapsed>5__5 = 0f;
        this.<duration>5__6 = 0.3833333f;
        this.<whiteFadeStartTime>5__10 = 0.1666667f;
        this.<whiteFadeEndTime>5__11 = 0.3f;
        label_12:
        float val_23 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_23 = val_40 + val_23;
        this.<elapsed>5__5 = val_23;
        val_23 = val_23 / (this.<duration>5__6);
        val_35 = ManualEasing.Sine.InOut(t:  val_23);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<startPosition>5__2, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.<targetViewPos>5__3, y = V13.16B, z = V12.16B}, t:  val_35);
        this.<>4__this.colorLine.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        float val_32 = this.<elapsed>5__5;
        float val_33 = this.<whiteFadeStartTime>5__10;
        val_32 = val_32 - val_33;
        val_33 = (this.<whiteFadeEndTime>5__11) - val_33;
        UnityEngine.Color val_28 = this.<>4__this.whiteLine.startColor;
        val_36 = val_28.r;
        val_37 = val_28.b;
        float val_29 = UnityEngine.Mathf.Lerp(a:  this.<startAlpha>5__9, b:  0f, t:  UnityEngine.Mathf.Clamp(value:  val_32 / val_33, min:  0f, max:  1f));
        this.<>4__this.whiteLine.startColor = new UnityEngine.Color() {r = val_36, g = val_28.g, b = val_37, a = val_29};
        this.<>4__this.whiteLine.endColor = new UnityEngine.Color() {r = val_36, g = val_28.g, b = val_37, a = val_29};
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_30 = 1;
        return (bool)val_30;
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
