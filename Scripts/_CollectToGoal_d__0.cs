using UnityEngine;
private sealed class CoinBezierCollect.<CollectToGoal>d__0 : IEnumerator<object>, IEnumerator, IDisposable
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
    private bool <isSortingSetForUi>5__15;
    private bool <isGoingDown>5__16;
    private UnityEngine.Vector3 <minPos>5__17;
    private float <speed>5__18;
    private float <maxSpeed>5__19;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CoinBezierCollect.<CollectToGoal>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_47;
        float val_48;
        UnityEngine.Vector3 val_50;
        float val_51;
        float val_52;
        if((this.<>1__state) != 1)
        {
                val_47 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_47;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_3 = this.itemView.transform;
            this.<transform>5__2 = val_3;
            this.<shadowView>5__3 = this.itemView.shadowView;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            val_3.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            0.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.itemView.PrepareShadowColorForCollect();
            float val_47 = UnityEngine.Random.Range(min:  -0.5f, max:  0.5f);
            float val_8 = UnityEngine.Random.Range(min:  -0.05f, max:  0.05f);
            val_8 = val_8 + 1f;
            this.<minSpeedVar>5__4 = val_8;
            float val_9 = UnityEngine.Random.Range(min:  -0.05f, max:  0.05f);
            val_9 = val_9 + 1f;
            this.<startSpeedVar>5__5 = val_9;
            this.itemView.SetSortingForCollect(offset:  1000 - (Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).GetOperationCount(animationId:  5)));
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.1f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.goalPosition, y = 0.05f, z = V14.16B}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_48 = this;
            this.<elapsed>5__6 = 0f;
            val_47 = val_47 + (-1f);
            UnityEngine.Vector3 val_15 = this.<transform>5__2.position;
            this.<p0>5__7 = val_15;
            mem[1152921523819901328] = val_15.y;
            mem[1152921523819901332] = val_15.z;
            this.<p3>5__8 = val_13;
            mem[1152921523819901340] = val_13.y;
            mem[1152921523819901344] = val_13.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            float val_17 = (this.goalPosition < 0) ? 1f : 0f;
            val_17 = val_47 * val_17;
            val_17 = val_17 + (this.<p0>5__7);
            float val_18 = ((UnityEngine.Random.Range(min:  -0.4f, max:  0.4f)) + (-2.5f)) + val_12.x;
            this.<p1>5__9 = val_17;
            mem[1152921523819901352] = val_18;
            mem[1152921523819901356] = val_16.z;
            this.<p2>5__10 = val_17;
            mem[1152921523819901364] = val_18;
            mem[1152921523819901368] = val_16.z;
            UnityEngine.Vector3 val_20 = this.itemView.shadowView.transform.localPosition;
            this.<shadowStartPos>5__11 = val_20;
            mem[1152921523819901376] = val_20.y;
            val_20.y = val_20.y + (-0.5f);
            mem[1152921523819901388] = val_20.y;
            mem[1152921523819901392] = val_20.z;
            val_20.x = val_20.x + 0.3f;
            mem[1152921523819901380] = val_20.z;
            this.<shadowMaxPos>5__12 = val_20.x;
            UnityEngine.Quaternion val_21 = this.<transform>5__2.localRotation;
            this.<startRotation>5__13 = val_21;
            mem[1152921523819901400] = val_21.y;
            mem[1152921523819901404] = val_21.z;
            mem[1152921523819901408] = val_21.w;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.<maxRotation>5__14 = val_22;
            mem[1152921523819901416] = val_22.y;
            this.<isSortingSetForUi>5__15 = true;
            this.<isGoingDown>5__16 = true;
            mem[1152921523819901420] = val_22.z;
            mem[1152921523819901424] = val_22.w;
            UnityEngine.Vector3 val_23 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateMin(duration:  0.7f, p0:  new UnityEngine.Vector3() {x = this.<p0>5__7, y = V16.16B, z = V7.16B}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__9, y = val_12.z}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__10, y = ???, z = this.<p3>5__8}, p3:  new UnityEngine.Vector3() {x = val_22.x, y = 50f}, precision:  0f);
            this.<minPos>5__17 = val_23;
            mem[1152921523819901436] = val_23.y;
            mem[1152921523819901440] = val_23.z;
            this.<speed>5__18 = 0.2f;
            val_50 = this.goalPosition;
            val_51 = val_23.x;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_50, y = val_13.x, z = val_13.y}, b:  new UnityEngine.Vector3() {x = val_51, y = val_23.y, z = val_23.z});
            float val_48 = -8f;
            val_48 = val_24.x + val_48;
            val_48 = val_48 / (-10f);
            this.<maxSpeed>5__19 = UnityEngine.Mathf.Lerp(a:  0.2f, b:  1f, t:  val_48 + 1f);
        }
        else
        {
                val_48 = this.<elapsed>5__6;
            this.<>1__state = 0;
        }
        
        val_52 = mem[this.<elapsed>5__6];
        val_52 = val_48;
        if(val_52 >= 0)
        {
                this.onComplete.Invoke();
            val_47 = 0;
            return (bool)val_47;
        }
        
        float val_27 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_27 = val_27 * (this.<speed>5__18);
        val_27 = val_52 + val_27;
        this.<elapsed>5__6 = val_27;
        val_27 = val_27 / 0.7f;
        UnityEngine.Vector3 val_28 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_27, p0:  new UnityEngine.Vector3() {x = this.<p0>5__7}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__9}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__10, y = this.<speed>5__18, z = this.<p3>5__8}, p3:  new UnityEngine.Vector3() {x = ???, y = 50f});
        if((this.<isGoingDown>5__16) != false)
        {
                UnityEngine.Vector3 val_29 = this.<transform>5__2.position;
            if(val_28.y > val_29.y)
        {
                this.<isGoingDown>5__16 = false;
        }
        
        }
        
        float val_49 = val_28.x;
        this.<transform>5__2.position = new UnityEngine.Vector3() {x = val_49, y = val_28.y, z = val_28.z};
        if((this.<isGoingDown>5__16) == false)
        {
            goto label_33;
        }
        
        val_49 = val_49 - val_28.y;
        float val_31 = (val_49 - val_28.y) / val_49;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__11, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__12, y = val_28.z, z = val_28.y}, t:  val_31);
        this.<shadowView>5__3.transform.localPosition = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
        val_50 = this.<maxRotation>5__14;
        UnityEngine.Quaternion val_34 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<startRotation>5__13, y = val_28.z, z = val_28.y, w = V15.16B}, b:  new UnityEngine.Quaternion() {x = val_50, y = V12.16B, z = this.<shadowStartPos>5__11, w = V11.16B}, t:  val_31);
        this.<transform>5__2.localRotation = new UnityEngine.Quaternion() {x = val_34.x, y = val_34.y, z = val_34.z, w = val_34.w};
        val_52 = this.<minSpeedVar>5__4;
        label_59:
        this.<speed>5__18 = UnityEngine.Mathf.Lerp(a:  this.<startSpeedVar>5__5, b:  val_52, t:  val_31);
        label_56:
        val_47 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_47;
        return (bool)val_47;
        label_33:
        val_49 = val_28.y - val_49;
        float val_37 = (val_28.y - val_49) / val_49;
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__12, y = V12.16B, z = val_28.z}, b:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__11, y = val_28.y, z = val_28.x}, t:  val_37);
        this.<shadowView>5__3.transform.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
        UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.<maxRotation>5__14, y = this.<shadowStartPos>5__11, z = val_28.y, w = val_28.x}, b:  new UnityEngine.Quaternion() {x = this.<startRotation>5__13, y = this.<shadowMaxPos>5__12, z = val_37, w = V12.16B}, t:  val_37 + val_37);
        this.<transform>5__2.localRotation = new UnityEngine.Quaternion() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w};
        val_41.x = val_41.x - val_41.y;
        float val_50 = -3f;
        val_50 = val_41.x + val_50;
        float val_42 = val_50 / val_41.x;
        if(val_37 <= val_42)
        {
            goto label_50;
        }
        
        float val_43 = val_37 - val_42;
        val_43 = val_43 / (1f - val_42);
        this.<speed>5__18 = UnityEngine.Mathf.Lerp(a:  this.<maxSpeed>5__19, b:  (this.<maxSpeed>5__19) / 5f, t:  val_43);
        if((this.<isSortingSetForUi>5__15) == true)
        {
            goto label_56;
        }
        
        this.<isSortingSetForUi>5__15 = true;
        this.itemView.SetSortingForCollectOnUi();
        goto label_56;
        label_50:
        if(val_37 >= 0)
        {
            goto label_56;
        }
        
        goto label_59;
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
