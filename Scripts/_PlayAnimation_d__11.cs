using UnityEngine;
private sealed class InboxLifeAnimation.<PlayAnimation>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation <>4__this;
    private float <elapsed>5__2;
    private float <duration>5__3;
    private bool <isHitAnimationPlayed>5__4;
    private UnityEngine.Vector3 <start>5__5;
    private UnityEngine.Vector3 <startScale>5__6;
    private UnityEngine.Vector3 <firstScale>5__7;
    private UnityEngine.Vector3 <endScale>5__8;
    private float <maxScaleRatio>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InboxLifeAnimation.<PlayAnimation>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_25;
        int val_26;
        float val_27;
        UnityEngine.Vector3 val_28;
        var val_29;
        var val_30;
        UnityEngine.Vector3 val_31;
        var val_32;
        var val_33;
        val_25 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_26 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_26;
        }
        
        this.<>1__state = 0;
        this.<>4__this.appearParticles.Play();
        this.<isHitAnimationPlayed>5__4 = false;
        this.<elapsed>5__2 = 0f;
        this.<duration>5__3 = 0.6f;
        UnityEngine.Vector3 val_2 = this.<>4__this.transform.position;
        this.<start>5__5 = val_2;
        mem[1152921519124057656] = val_2.y;
        mem[1152921519124057660] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.<startScale>5__6 = val_3;
        mem[1152921519124057668] = val_3.y;
        mem[1152921519124057672] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.5f);
        this.<firstScale>5__7 = val_5;
        mem[1152921519124057680] = val_5.y;
        mem[1152921519124057684] = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        this.<endScale>5__8 = val_6;
        mem[1152921519124057692] = val_6.y;
        mem[1152921519124057696] = val_6.z;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.<maxScaleRatio>5__9 = 0.3f;
        goto label_11;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.onLifeDestroy.Invoke();
        val_25 = this.<>4__this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_25);
        val_26 = 0;
        return (bool)val_26;
        label_2:
        this.<>1__state = 0;
        label_11:
        val_27 = this.<elapsed>5__2;
        if(val_27 >= 0)
        {
                this.<>4__this.onComplete.Invoke();
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
            this.<>1__state = 2;
            val_26 = 1;
            return (bool)val_26;
        }
        
        val_27 = val_27 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__2 = val_27;
        float val_11 = UnityEngine.Mathf.Clamp(value:  val_27, min:  0f, max:  this.<duration>5__3);
        float val_25 = this.<maxScaleRatio>5__9;
        val_27 = val_11 / (this.<duration>5__3);
        if(val_27 < 0)
        {
                val_28 = this.<startScale>5__6;
            val_29 = 1152921519124057668;
            val_30 = 1152921519124057672;
            val_31 = this.<firstScale>5__7;
            val_32 = 1152921519124057680;
            val_33 = 1152921519124057684;
            float val_12 = val_27 / val_25;
        }
        else
        {
                val_11 = val_27 - val_25;
            val_25 = 1f - val_25;
            val_28 = this.<firstScale>5__7;
            val_29 = 1152921519124057680;
            val_30 = 1152921519124057684;
            val_31 = this.<endScale>5__8;
            val_32 = 1152921519124057692;
            val_33 = 1152921519124057696;
        }
        
        UnityEngine.Vector3 val_14 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<firstScale>5__7.x, y = 1.111524E-23f, z = 1.111524E-23f}, b:  new UnityEngine.Vector3() {x = this.<endScale>5__8.x, y = 1.111524E-23f, z = 1.111524E-23f}, t:  val_11 / val_25, extrapolate:  true);
        this.<>4__this.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.Vector3 val_16 = this.<>4__this.hitTransform.position;
        float val_17 = UnityEngine.Mathf.LerpUnclamped(a:  val_14.z, b:  val_16.y, t:  val_27);
        UnityEngine.Vector3 val_18 = this.<>4__this.hitTransform.position;
        float val_19 = ManualEasing.Sine.In(t:  val_27);
        val_19 = val_27 + val_19;
        float val_21 = UnityEngine.Mathf.LerpUnclamped(a:  this.<start>5__5, b:  val_18.x, t:  val_19 * 0.5f);
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if((this.<isHitAnimationPlayed>5__4) != true)
        {
                float val_26 = this.<elapsed>5__2;
            val_26 = (this.<duration>5__3) - val_26;
            if(val_26 < 0)
        {
                this.<isHitAnimationPlayed>5__4 = true;
            this.<>4__this.PlayItemHitAnimation();
            this.<>4__this.shadow.parent.gameObject.SetActive(value:  false);
        }
        
        }
        
        val_26 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_26;
        return (bool)val_26;
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
