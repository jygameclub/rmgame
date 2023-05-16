using UnityEngine;
private sealed class RoyalPassCoinTracer.<CurveFromTopBarEndToBank>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer <>4__this;
    public UnityEngine.Vector3 startPosition;
    public UnityEngine.Vector3 endPosition;
    public System.Action onComplete;
    private float <duration>5__2;
    private float <elapsed>5__3;
    private UnityEngine.Vector3 <p0>5__4;
    private UnityEngine.Vector3 <p3>5__5;
    private Royal.Infrastructure.Utils.Animation.CubicBezier <bezierCurve>5__6;
    private float <speed>5__7;
    private float <localFinalSpeed>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassCoinTracer.<CurveFromTopBarEndToBank>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action val_25;
        float val_26;
        float val_27;
        var val_28;
        float val_29;
        Royal.Infrastructure.Utils.Animation.CubicBezier val_30;
        var val_32;
        var val_33;
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        var val_38;
        if((this.<>1__state) != 1)
        {
                val_25 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_25;
        }
        
            this.<>1__state = 0;
            this.<>4__this.tracer.ArrangeRateOverDistanceByRatio(ratio:  1f);
            this.<>4__this.tracer.Play();
            this.<p0>5__4 = this.startPosition;
            mem[1152921519196003332] = ???;
            mem[1152921519196003336] = ???;
            this.<p3>5__5 = this.endPosition;
            mem[1152921519196003344] = ???;
            this.<duration>5__2 = 0.5f;
            this.<elapsed>5__3 = 0f;
            val_27 = UnityEngine.Mathf.LerpUnclamped(a:  this.<p0>5__4, b:  this.<p3>5__5, t:  1.25f);
            float val_3 = UnityEngine.Mathf.Lerp(a:  this.<p0>5__4, b:  this.<p3>5__5, t:  0.85f);
            this.<bezierCurve>5__6 = Royal.Infrastructure.Utils.Animation.CubicBezierPool.Pop().Init(p0:  new UnityEngine.Vector3() {x = this.<p0>5__4, y = this.<p3>5__5, z = 0.85f}, p1:  new UnityEngine.Vector3() {x = this.endPosition, y = UnityEngine.Mathf.Lerp(a:  W10, b:  ???, t:  0.2f), z = V8.16B}, p2:  new UnityEngine.Vector3() {x = val_27, y = ???, z = this.<p3>5__5}, p3:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???});
            float val_7 = UnityEngine.Mathf.Lerp(a:  1f, b:  1.5f, t:  val_5.length / 15f);
            val_7 = val_7 * (this.<duration>5__2);
            this.<duration>5__2 = val_7;
            val_28 = null;
            val_28 = null;
            this.<speed>5__7 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.StartSpeed;
            this.<localFinalSpeed>5__8 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.LocalFinalSpeed;
        }
        else
        {
                this.<>1__state = 0;
        }
        
        val_29 = this.<elapsed>5__3;
        if(val_29 >= 0)
        {
                val_30 = this.<bezierCurve>5__6;
            Royal.Infrastructure.Utils.Animation.CubicBezierPool.Push(bezier:  val_30);
            this.<>4__this.PlayHitParticlesAndRecycleDelayed();
            val_25 = this.onComplete;
            if(val_25 == null)
        {
                return (bool)val_25;
        }
        
            val_25.Invoke();
            val_25 = 0;
            return (bool)val_25;
        }
        
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = val_8 * (this.<speed>5__7);
        val_29 = val_29 + val_8;
        this.<elapsed>5__3 = val_29;
        val_30 = 1152921504781234176;
        val_8 = val_29 / (this.<duration>5__2);
        float val_9 = UnityEngine.Mathf.Clamp01(value:  val_8);
        UnityEngine.Vector3 val_11 = this.<>4__this.transform.position;
        UnityEngine.Vector3 val_12 = this.<bezierCurve>5__6.GetValue(t:  val_9);
        float val_23 = this.<bezierCurve>5__6.length;
        val_23 = (this.<bezierCurve>5__6.GetLengthForT(t:  val_9)) / val_23;
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        val_32 = null;
        if(val_23 < 0)
        {
                val_33 = null;
            val_34 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.MaxSpeed;
            float val_16 = 0.5f - val_23;
            val_16 = val_16 + val_16;
            val_16 = 1f - val_16;
            val_35 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.StartSpeed;
            val_36 = val_34;
            val_37 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  2).Invoke(t:  val_16);
        }
        else
        {
                val_38 = null;
            val_34 = this.<localFinalSpeed>5__8;
            float val_24 = -0.5f;
            val_24 = val_23 + val_24;
            val_37 = val_24 + val_24;
            val_35 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassCoinTracer.MaxSpeed;
            val_36 = val_34;
        }
        
        this.<speed>5__7 = UnityEngine.Mathf.Lerp(a:  val_35, b:  val_36, t:  val_37);
        UnityEngine.Vector3 val_20 = this.<>4__this.transform.position;
        val_26 = val_20.y;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__5, y = val_34, z = 0.5f}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_26, z = val_20.z});
        val_29 = val_21.x;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__5, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = this.<p0>5__4, y = val_26, z = val_20.z});
        val_22.x = val_29 / val_22.x;
        this.<>4__this.tracer.ArrangeRateOverDistanceByRatio(ratio:  val_22.x);
        val_25 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_25;
        return (bool)val_25;
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
