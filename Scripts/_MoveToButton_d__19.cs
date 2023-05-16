using UnityEngine;
private sealed class ContributionItemView.<MoveToButton>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView <>4__this;
    private float <elapsed>5__2;
    private float <duration>5__3;
    private bool <isHitAnimationPlayed>5__4;
    private UnityEngine.Vector3 <start>5__5;
    private float <scaleDuration>5__6;
    private UnityEngine.Vector3 <startScale>5__7;
    private UnityEngine.Vector3 <endScale>5__8;
    private UnityEngine.Vector3 <startShadow>5__9;
    private UnityEngine.Vector3 <endShadow>5__10;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ContributionItemView.<MoveToButton>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_30;
        int val_31;
        float val_32;
        var val_33;
        var val_34;
        float val_35;
        float val_36;
        val_30 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
                val_31 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_31;
        }
        
            val_32 = val_30;
            this.<elapsed>5__2 = 0f;
            this.<>1__state = 0;
            val_33 = 1152921505030275072;
            val_34 = null;
            val_34 = null;
            this.<isHitAnimationPlayed>5__4 = false;
            this.<duration>5__3 = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView.Duration;
            UnityEngine.Vector3 val_2 = this.<>4__this.rewardedItemObject.transform.position;
            this.<start>5__5 = val_2;
            mem[1152921519091089864] = val_2.y;
            mem[1152921519091089868] = val_2.z;
            float val_30 = 0.05f;
            val_35 = this.<scaleDuration>5__6;
            val_30 = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView.Duration + val_30;
            this.<scaleDuration>5__6 = val_30;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.089f);
            this.<startScale>5__7 = val_4;
            mem[1152921519091089880] = val_4.y;
            mem[1152921519091089884] = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.99f);
            this.<endScale>5__8 = val_6;
            mem[1152921519091089892] = val_6.y;
            mem[1152921519091089896] = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView.TargetShadowPosition, y = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView.TargetShadowPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView.TargetShadowPosition.__il2cppRuntimeField_8}, d:  1.089f);
            this.<startShadow>5__9 = val_7;
            mem[1152921519091089904] = val_7.y;
            mem[1152921519091089908] = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.<endShadow>5__10 = val_8;
            mem[1152921519091089916] = val_8.y;
            mem[1152921519091089920] = val_8.z;
        }
        else
        {
                val_32 = this.<elapsed>5__2;
            val_35 = this.<scaleDuration>5__6;
            this.<>1__state = 0;
        }
        
        val_36 = mem[this.<elapsed>5__2];
        val_36 = val_32;
        if(val_36 < 0)
        {
            goto label_12;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = 2;
        val_31 = 1;
        return (bool)val_31;
        label_1:
        this.<>1__state = 0;
        val_30 = this.<>4__this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_30);
        val_31 = 0;
        return (bool)val_31;
        label_12:
        float val_12 = val_36 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__2 = val_12;
        float val_31 = -0.05f;
        val_31 = val_12 + val_31;
        float val_13 = UnityEngine.Mathf.Clamp(value:  val_31, min:  0f, max:  this.<duration>5__3);
        val_13 = val_13 / (this.<duration>5__3);
        val_36 = ManualEasing.Back.In(t:  val_13);
        float val_15 = UnityEngine.Mathf.Clamp(value:  this.<elapsed>5__2, min:  0f, max:  this.<scaleDuration>5__6);
        val_15 = val_15 / (this.<scaleDuration>5__6);
        float val_16 = ManualEasing.Back.In(t:  val_15, overshootAmplitude:  6f);
        UnityEngine.Vector3 val_18 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<startScale>5__7, y = 6f, z = this.<scaleDuration>5__6}, b:  new UnityEngine.Vector3() {x = this.<endScale>5__8}, t:  val_16, extrapolate:  true);
        this.<>4__this.rewardedItemObject.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        val_33 = this.<>4__this.shadow.transform;
        UnityEngine.Vector3 val_20 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<startShadow>5__9, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = this.<endShadow>5__10}, t:  val_16, extrapolate:  true);
        val_33.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Vector3 val_21 = this.<>4__this.levelButtonFrame.position;
        float val_22 = UnityEngine.Mathf.LerpUnclamped(a:  val_16, b:  val_21.y, t:  val_36);
        UnityEngine.Vector3 val_23 = this.<>4__this.levelButtonFrame.position;
        float val_24 = ManualEasing.Sine.In(t:  val_36);
        val_24 = val_36 + val_24;
        float val_26 = UnityEngine.Mathf.LerpUnclamped(a:  this.<start>5__5, b:  val_23.x, t:  val_24 * 0.5f);
        this.<>4__this.rewardedItemObject.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if((this.<isHitAnimationPlayed>5__4) != true)
        {
                float val_32 = val_35;
            val_32 = val_32 - val_32;
            if(val_32 < 0)
        {
                this.<isHitAnimationPlayed>5__4 = true;
            this.<>4__this.PlayItemHitAnimation();
            this.<>4__this.image.gameObject.SetActive(value:  false);
            this.<>4__this.shadow.gameObject.SetActive(value:  false);
        }
        
        }
        
        val_31 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_31;
        return (bool)val_31;
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
