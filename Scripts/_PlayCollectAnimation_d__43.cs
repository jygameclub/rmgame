using UnityEngine;
private sealed class RoyalPassRewardRevealDialog.<PlayCollectAnimation>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float dur;
    public UnityEngine.Transform item;
    public float shadowMaxY;
    public UnityEngine.Transform shadow;
    public UnityEngine.Transform target;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog <>4__this;
    public bool isLifeCollect;
    private float <elapsed>5__2;
    private float <duration>5__3;
    private bool <isHitAnimationPlayed>5__4;
    private float <scaleDuration>5__5;
    private UnityEngine.Vector3 <start>5__6;
    private UnityEngine.Vector3 <startScale>5__7;
    private UnityEngine.Vector3 <endScale>5__8;
    private float <shadowMaxRatio>5__9;
    private UnityEngine.Vector3 <maxShadow>5__10;
    private UnityEngine.Vector3 <minShadow>5__11;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassRewardRevealDialog.<PlayCollectAnimation>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        UnityEngine.Transform val_33;
        if((this.<>1__state) != 1)
        {
                val_27 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_27;
        }
        
            val_28 = this;
            this.<elapsed>5__2 = 0f;
            this.<>1__state = 0;
            mem[1152921519251513500] = 0;
            mem[1152921519251513496] = this.dur;
            mem[1152921519251513504] = this.dur;
            UnityEngine.Vector3 val_2 = this.item.transform.position;
            this.<start>5__6 = val_2;
            mem[1152921519251513512] = val_2.y;
            mem[1152921519251513516] = val_2.z;
            UnityEngine.Vector3 val_4 = this.item.transform.localScale;
            this.<startScale>5__7 = val_4;
            mem[1152921519251513524] = val_4.y;
            mem[1152921519251513528] = val_4.z;
            val_29 = val_4.y;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_29, z = val_4.z}, d:  0.5f);
            this.<endScale>5__8 = val_5;
            mem[1152921519251513536] = val_5.y;
            mem[1152921519251513540] = val_5.z;
            this.<shadowMaxRatio>5__9 = 0.2f;
            this.<maxShadow>5__10 = 0;
            mem[1152921519251513556] = 0;
            val_30 = 1152921519251513496;
            UnityEngine.Vector3 val_7 = this.shadow.transform.localPosition;
            this.<minShadow>5__11 = val_7;
            mem[1152921519251513564] = val_7.y;
            mem[1152921519251513568] = val_7.z;
        }
        else
        {
                val_28 = this.<elapsed>5__2;
            val_30 = this.<duration>5__3;
            this.<>1__state = 0;
        }
        
        val_31 = mem[this.<elapsed>5__2];
        val_31 = val_28;
        if(val_31 >= 0)
        {
                val_27 = 0;
            return (bool)val_27;
        }
        
        val_31 = val_31 + UnityEngine.Time.deltaTime;
        val_28 = val_31;
        float val_9 = UnityEngine.Mathf.Clamp(value:  val_31, min:  0f, max:  val_30);
        val_9 = val_9 / (this.<duration>5__3);
        val_31 = ManualEasing.Cubic.In(t:  val_9);
        float val_11 = UnityEngine.Mathf.Clamp(value:  this.<elapsed>5__2, min:  0f, max:  this.<scaleDuration>5__5);
        val_11 = val_11 / (this.<scaleDuration>5__5);
        UnityEngine.Vector3 val_14 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<startScale>5__7, y = 4f, z = this.<scaleDuration>5__5}, b:  new UnityEngine.Vector3() {x = this.<endScale>5__8}, t:  ManualEasing.Back.In(t:  val_11, overshootAmplitude:  4f), extrapolate:  true);
        this.item.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        val_33 = this.shadow;
        if(val_33 != 0)
        {
                val_33 = this.shadow.transform;
            if(val_31 < 0)
        {
                float val_27 = this.<shadowMaxRatio>5__9;
            val_27 = val_31 / val_27;
        }
        else
        {
                float val_28 = this.<shadowMaxRatio>5__9;
            val_28 = 1f - val_28;
            val_28 = (val_31 - val_28) / val_28;
        }
        
            UnityEngine.Vector3 val_18 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<maxShadow>5__10, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = this.<minShadow>5__11}, t:  val_28, extrapolate:  true);
            val_33.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        }
        
        UnityEngine.Vector3 val_19 = this.target.position;
        float val_20 = UnityEngine.Mathf.LerpUnclamped(a:  this.<shadowMaxRatio>5__9, b:  val_19.y, t:  val_31);
        val_29 = this.<start>5__6;
        UnityEngine.Vector3 val_21 = this.target.position;
        float val_22 = ManualEasing.Sine.In(t:  val_31);
        val_22 = val_31 + val_22;
        float val_24 = UnityEngine.Mathf.LerpUnclamped(a:  val_29, b:  val_21.x, t:  val_22 * 0.5f);
        this.item.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if((this.<isHitAnimationPlayed>5__4) != true)
        {
                float val_29 = val_30;
            val_29 = val_29 - val_28;
            if(val_29 < 0)
        {
                this.item.gameObject.SetActive(value:  false);
            this.<isHitAnimationPlayed>5__4 = true;
            this.<>4__this.PlayHitAnimation(target:  this.target, isLifeCollect:  this.isLifeCollect);
        }
        
        }
        
        val_27 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_27;
        return (bool)val_27;
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
