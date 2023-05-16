using UnityEngine;
private sealed class CoinBezierCollect.<CollectToUserInfo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView itemView;
    public UnityEngine.Vector3 goalPosition;
    public System.Action onComplete;
    private UnityEngine.Transform <transform>5__2;
    private UnityEngine.SpriteRenderer <shadowView>5__3;
    private float <minSpeedVar>5__4;
    private float <startSpeedVar>5__5;
    private float <elapsed>5__6;
    private UnityEngine.Vector3 <p0>5__7;
    private UnityEngine.Vector3 <p3>5__8;
    private UnityEngine.Vector3 <p1>5__9;
    private UnityEngine.Vector3 <p2>5__10;
    private UnityEngine.Vector3 <shadowStartPos>5__11;
    private UnityEngine.Vector3 <shadowMaxPos>5__12;
    private UnityEngine.Quaternion <startRotation>5__13;
    private UnityEngine.Quaternion <maxRotation>5__14;
    private bool <isGoingDown>5__15;
    private UnityEngine.Vector3 <minPos>5__16;
    private float <speed>5__17;
    private float <maxSpeed>5__18;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoinBezierCollect.<CollectToUserInfo>d__1(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_42;
        float val_43;
        UnityEngine.Quaternion val_44;
        float val_45;
        float val_46;
        float val_47;
        float val_54;
        if((this.<>1__state) != 1)
        {
                val_42 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_42;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_1 = this.itemView.transform;
            this.<transform>5__2 = val_1;
            this.<shadowView>5__3 = this.itemView.shadowView;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            0.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.itemView.PrepareShadowColorForCollect();
            float val_43 = 0.2f;
            float val_42 = UnityEngine.Random.Range(min:  -0.2f, max:  val_43);
            float val_6 = UnityEngine.Random.Range(min:  -0.05f, max:  0.05f);
            val_6 = val_6 + 1f;
            this.<minSpeedVar>5__4 = val_6;
            float val_7 = UnityEngine.Random.Range(min:  -0.02f, max:  0.02f);
            val_7 = val_7 + 0.5f;
            this.<startSpeedVar>5__5 = val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.1f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.goalPosition, y = V12.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_43 = this;
            this.<elapsed>5__6 = 0f;
            val_42 = val_42 + (-0.5f);
            val_43 = (UnityEngine.Random.Range(min:  -0.2f, max:  val_43)) + (-1f);
            UnityEngine.Vector3 val_11 = this.<transform>5__2.position;
            this.<p0>5__7 = val_11;
            mem[1152921523820766864] = val_11.y;
            mem[1152921523820766868] = val_11.z;
            this.<p3>5__8 = val_10;
            mem[1152921523820766876] = val_10.y;
            mem[1152921523820766880] = val_10.z;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            float val_13 = (this.goalPosition < 0) ? 1f : 0f;
            val_13 = val_42 * val_13;
            val_13 = val_13 + (this.<p0>5__7);
            float val_14 = val_43 + val_9.x;
            this.<p1>5__9 = val_13;
            mem[1152921523820766888] = val_14;
            mem[1152921523820766892] = val_12.z;
            this.<p2>5__10 = val_13;
            mem[1152921523820766900] = val_14;
            mem[1152921523820766904] = val_12.z;
            UnityEngine.Vector3 val_16 = this.itemView.shadowView.transform.localPosition;
            this.<shadowStartPos>5__11 = val_16;
            mem[1152921523820766912] = val_16.y;
            val_16.y = val_16.y + (-0.5f);
            val_16.x = val_16.x + 0.3f;
            mem[1152921523820766924] = val_16.y;
            mem[1152921523820766928] = val_16.z;
            mem[1152921523820766916] = val_16.z;
            this.<shadowMaxPos>5__12 = val_16.x;
            UnityEngine.Quaternion val_17 = this.<transform>5__2.localRotation;
            this.<startRotation>5__13 = val_17;
            mem[1152921523820766936] = val_17.y;
            mem[1152921523820766940] = val_17.z;
            mem[1152921523820766944] = val_17.w;
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.<maxRotation>5__14 = val_18;
            mem[1152921523820766952] = val_18.y;
            mem[1152921523820766956] = val_18.z;
            mem[1152921523820766960] = val_18.w;
            this.<isGoingDown>5__15 = true;
            UnityEngine.Vector3 val_19 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateMin(duration:  1f, p0:  new UnityEngine.Vector3() {x = this.<p0>5__7, y = V16.16B, z = V7.16B}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__9, y = val_9.z}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__10, y = ???, z = this.<p3>5__8}, p3:  new UnityEngine.Vector3() {x = val_18.x, y = 50f}, precision:  0f);
            this.<minPos>5__16 = val_19;
            mem[1152921523820766972] = val_19.y;
            mem[1152921523820766976] = val_19.z;
            this.<speed>5__17 = 0.2f;
            val_45 = val_19.y;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.goalPosition, y = val_10.z, z = this.goalPosition}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_45, z = val_19.z});
            val_46 = val_20.x;
            float val_44 = -8f;
            val_44 = val_46 + val_44;
            val_44 = val_44 / (-10f);
            this.<maxSpeed>5__18 = UnityEngine.Mathf.Lerp(a:  val_43, b:  2.5f, t:  val_44 + 1f);
        }
        else
        {
                val_43 = this.<elapsed>5__6;
            this.<>1__state = 0;
        }
        
        val_47 = mem[this.<elapsed>5__6];
        val_47 = val_43;
        if(val_47 >= 0)
        {
                this.onComplete.Invoke();
            val_42 = 0;
            return (bool)val_42;
        }
        
        float val_23 = UnityEngine.Time.deltaTime;
        val_23 = val_23 * (this.<speed>5__17);
        val_23 = val_47 + val_23;
        this.<elapsed>5__6 = val_23;
        UnityEngine.Vector3 val_24 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_23, p0:  new UnityEngine.Vector3() {x = this.<p0>5__7}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__9}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__10, y = ???, z = this.<p3>5__8}, p3:  new UnityEngine.Vector3() {x = ???, y = 50f});
        if((this.<isGoingDown>5__15) != false)
        {
                UnityEngine.Vector3 val_25 = this.<transform>5__2.position;
            if(val_24.y > val_25.y)
        {
                this.<isGoingDown>5__15 = false;
        }
        
        }
        
        float val_45 = val_24.x;
        this.<transform>5__2.position = new UnityEngine.Vector3() {x = val_45, y = val_24.y, z = val_24.z};
        if((this.<isGoingDown>5__15) == false)
        {
            goto label_31;
        }
        
        val_45 = val_45 - val_24.y;
        float val_27 = (val_45 - val_24.y) / val_45;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__11, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__12, y = val_24.z, z = val_24.y}, t:  val_27);
        this.<shadowView>5__3.transform.localPosition = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
        val_44 = this.<maxRotation>5__14;
        UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<startRotation>5__13, y = val_24.z, z = val_24.y, w = V15.16B}, b:  new UnityEngine.Quaternion() {x = val_44, y = V12.16B, z = this.<shadowStartPos>5__11, w = V11.16B}, t:  val_27);
        this.<transform>5__2.localRotation = new UnityEngine.Quaternion() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w};
        val_47 = this.<minSpeedVar>5__4;
        val_54 = this.<startSpeedVar>5__5;
        goto label_52;
        label_31:
        val_45 = val_24.y - val_45;
        float val_32 = (val_24.y - val_45) / val_45;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__12, y = V12.16B, z = val_24.z}, b:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__11, y = val_24.y, z = val_24.x}, t:  val_32);
        this.<shadowView>5__3.transform.localPosition = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
        float val_35 = val_32 + val_32;
        UnityEngine.Quaternion val_36 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<maxRotation>5__14, y = val_34.y, z = val_24.y, w = val_24.x}, b:  new UnityEngine.Quaternion() {x = this.<startRotation>5__13, y = this.<shadowMaxPos>5__12, z = val_32, w = V12.16B}, t:  val_35);
        this.<transform>5__2.localRotation = new UnityEngine.Quaternion() {x = val_36.x, y = val_36.y, z = val_36.z, w = val_36.w};
        val_46 = 1f;
        val_36.x = val_36.x - val_36.y;
        float val_46 = -3f;
        val_46 = val_36.x + val_46;
        float val_37 = val_46 / val_36.x;
        if(val_32 <= val_37)
        {
            goto label_49;
        }
        
        val_47 = this.<maxSpeed>5__18;
        float val_38 = val_32 - val_37;
        float val_40 = val_47 / 5f;
        val_38 = val_38 / (val_46 - val_37);
        val_54 = val_47;
        goto label_52;
        label_49:
        if(val_32 >= 0)
        {
            goto label_53;
        }
        
        val_47 = this.<minSpeedVar>5__4;
        val_54 = val_47;
        label_52:
        this.<speed>5__17 = UnityEngine.Mathf.Lerp(a:  val_54, b:  this.<maxSpeed>5__18, t:  val_35);
        label_53:
        val_42 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_42;
        return (bool)val_42;
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
