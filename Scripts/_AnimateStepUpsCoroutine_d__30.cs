using UnityEngine;
private sealed class RoyalPassScrollContent.<AnimateStepUpsCoroutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent <>4__this;
    public System.Collections.Generic.List<int> enabledSteps;
    public System.Action onComplete;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <stepToggleEasing>5__2;
    private float <stepToggleDuration>5__3;
    private float <stepToggleElapsed>5__4;
    private UnityEngine.Vector3 <initialSeparatorScale>5__5;
    private UnityEngine.Vector3 <targetSeparatorScale>5__6;
    private UnityEngine.Vector3 <initialSeparatorPosition>5__7;
    private UnityEngine.Vector3 <targetTopSeparatorPosition>5__8;
    private UnityEngine.Vector3 <targetBottomSeparatorPosition>5__9;
    private float <initialHighlightAlpha>5__10;
    private float <targetHighlightAlpha>5__11;
    private UnityEngine.Vector3 <startPosition>5__12;
    private UnityEngine.Vector3 <endPosition>5__13;
    private int <currentAnimatingStepIndex>5__14;
    private float <duration>5__15;
    private float <elapsed>5__16;
    private bool <isToggleStepAnimationPlayed>5__17;
    private UnityEngine.Vector3 <previousPosition>5__18;
    private float <multiplier>5__19;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassScrollContent.<AnimateStepUpsCoroutine>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_44;
        float val_45;
        int val_46;
        float val_47;
        float val_48;
        int val_49;
        System.Collections.Generic.List<System.Int32> val_50;
        float val_52;
        UnityEngine.Vector3 val_53;
        float val_54;
        float val_55;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        this.<stepToggleEasing>5__2 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  5);
        val_44 = this;
        this.<stepToggleDuration>5__3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  45f);
        val_45 = 1152921519274021168;
        mem[1152921519274021172] = 0f;
        val_46 = 0;
        label_10:
        if(val_46 >= 36585472)
        {
            goto label_7;
        }
        
        if(val_46 >= 36585472)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<>4__this.InitStepUpAnimation(step:  3);
        val_46 = val_46 + 1;
        if(this.enabledSteps != null)
        {
            goto label_10;
        }
        
        label_1:
        val_48 = this.<duration>5__15;
        val_47 = this.<elapsed>5__16;
        this.<>1__state = 0;
        goto label_12;
        label_2:
        val_45 = this.<stepToggleElapsed>5__4;
        val_44 = this.<stepToggleDuration>5__3;
        this.<>1__state = 0;
        goto label_13;
        label_3:
        val_49 = 0;
        return (bool)val_49;
        label_7:
        UnityEngine.Vector3 val_3 = this.<>4__this.currentStepTopSeparator.localScale;
        this.<initialSeparatorScale>5__5 = val_3;
        mem[1152921519274021180] = val_3.y;
        mem[1152921519274021184] = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        this.<targetSeparatorScale>5__6 = val_4;
        mem[1152921519274021192] = val_4.y;
        mem[1152921519274021196] = val_4.z;
        UnityEngine.Vector3 val_5 = this.<>4__this.currentStepTopSeparator.localPosition;
        this.<initialSeparatorPosition>5__7 = val_5;
        mem[1152921519274021204] = val_5.y;
        mem[1152921519274021208] = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.<>4__this.cameraManager.cameraWidth);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  2f);
        this.<targetTopSeparatorPosition>5__8 = val_8;
        mem[1152921519274021216] = val_8.y;
        mem[1152921519274021220] = val_8.z;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.<>4__this.cameraManager.cameraWidth);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2f);
        this.<targetBottomSeparatorPosition>5__9 = val_11;
        mem[1152921519274021228] = val_11.y;
        mem[1152921519274021232] = val_11.z;
        UnityEngine.Color val_12 = this.<>4__this.currentStepHighlights[0].color;
        this.<initialHighlightAlpha>5__10 = val_12.a;
        this.<targetHighlightAlpha>5__11 = 0f;
        this.<>4__this.audioManager.PlaySound(type:  240, offset:  0.04f);
        label_13:
        float val_45 = mem[1152921519274021172];
        if(val_45 <= (this.<stepToggleDuration>5__3))
        {
            goto label_26;
        }
        
        UnityEngine.Transform val_13 = this.<>4__this.audioManager.transform;
        UnityEngine.Vector3 val_14 = val_13.localPosition;
        this.<startPosition>5__12 = val_14;
        mem[1152921519274021248] = val_14.y;
        mem[1152921519274021252] = val_14.z;
        val_45 = val_45 * (1.152922E+18f);
        UnityEngine.Vector3 val_16 = val_13.transform.localPosition;
        val_16.y = val_45 + val_16.y;
        this.<endPosition>5__13 = val_16;
        mem[1152921519274021260] = val_16.y;
        mem[1152921519274021264] = val_16.z;
        this.<currentAnimatingStepIndex>5__14 = 0;
        var val_17 = (this.enabledSteps == 1) ? 1 : 0;
        float val_18 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  36595044 + this.enabledSteps == 0x1 ? 1 : 0);
        val_48 = val_18;
        this.<duration>5__15 = val_18;
        this.<elapsed>5__16 = 0f;
        this.<isToggleStepAnimationPlayed>5__17 = false;
        this.<previousPosition>5__18 = this.<startPosition>5__12;
        mem[1152921519274021292] = 36595044;
        this.<multiplier>5__19 = 1f;
        val_47 = 0f;
        label_12:
        if(val_47 > val_48)
        {
                val_49 = 0;
            this.<>4__this = 1;
            return (bool)val_49;
        }
        
        val_18 = val_47 / val_48;
        float val_20 = ManualEasing.Quartic.Out(t:  UnityEngine.Mathf.Clamp01(value:  val_18));
        if((val_20 >= 0f) && (val_20 <= 0.25f))
        {
                float val_21 = val_20 * 4f;
            this.<multiplier>5__19 = UnityEngine.Mathf.Lerp(a:  0.3f, b:  1f, t:  val_21);
        }
        
        val_52 = 0.98f;
        if((val_20 >= val_52) && ((this.<isToggleStepAnimationPlayed>5__17) != true))
        {
                this.<isToggleStepAnimationPlayed>5__17 = true;
            val_52 = this.<targetSeparatorScale>5__6;
            UnityEngine.Coroutine val_24 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.PlayToggleStepAnimations(targetSeparatorScale:  new UnityEngine.Vector3() {x = val_52, y = 1f, z = val_21}, initialSeparatorScale:  new UnityEngine.Vector3() {x = this.<initialSeparatorScale>5__5}, targetTopSeparatorPosition:  new UnityEngine.Vector3() {x = this.<targetTopSeparatorPosition>5__8, y = ???, z = this.<initialSeparatorPosition>5__7}, initialSeparatorPosition:  new UnityEngine.Vector3() {x = ???, y = this.<targetBottomSeparatorPosition>5__9, z = ???}, targetBottomSeparatorPosition:  new UnityEngine.Vector3() {x = this.<targetHighlightAlpha>5__11, y = this.<initialHighlightAlpha>5__10}, targetHighlightAlpha:  null, initialHighlightAlpha:  ???, enabledSteps:  this.enabledSteps, onComplete:  this.onComplete));
        }
        
        float val_25 = UnityEngine.Time.deltaTime;
        val_53 = this.<startPosition>5__12;
        val_25 = val_25 * (this.<multiplier>5__19);
        val_25 = (this.<elapsed>5__16) + val_25;
        this.<elapsed>5__16 = val_25;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = val_53, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.<endPosition>5__13, y = V11.16B, z = this.<elapsed>5__16}, t:  val_20);
        val_48 = val_26.y;
        val_54 = val_26.z;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = this.<previousPosition>5__18, y = V11.16B, z = this.<elapsed>5__16});
        val_55 = val_27.y;
        UnityEngine.Transform val_28 = this.<>4__this.currentStep.transform;
        UnityEngine.Vector3 val_29 = val_28.position;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_55, z = val_27.z});
        val_28.position = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
        val_50 = this.enabledSteps;
        val_46 = this.<currentAnimatingStepIndex>5__14;
        if(val_46 < null)
        {
                Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll val_46 = 1152921505131393023;
            bool val_31 = (val_46 != null) ? 1 : 0;
            if(null <= val_46)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll val_33 = 1152921505131393024 + ((this.<currentAnimatingStepIndex>5__14) << 2);
            val_50 = mem[(1152921505131393024 + (this.<currentAnimatingStepIndex>5__14) << 2) + 32];
            val_31 = val_31 & ((val_46 == val_46) ? 1 : 0);
            UnityEngine.Vector3 val_35 = this.<>4__this.currentStepTopSeparator.transform.position;
            int val_47 = this.<currentAnimatingStepIndex>5__14;
            val_46 = this.<>4__this.UpdateRowProgressByTopSeparator(step:  val_50, yPositionOfTopSeparator:  val_35.y, isLastAnimatingStepWithTwoAnimations:  val_31);
            val_47 = val_47 + val_46;
            this.<currentAnimatingStepIndex>5__14 = val_47;
        }
        
        this.<previousPosition>5__18 = val_26;
        mem[1152921519274021288] = val_48;
        mem[1152921519274021292] = val_54;
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_49 = 1;
        return (bool)val_49;
        label_26:
        float val_37 = UnityEngine.Time.deltaTime;
        val_45 = val_45 + val_37;
        this.<stepToggleElapsed>5__4 = val_45;
        val_37 = val_45 / (this.<stepToggleDuration>5__3);
        float val_39 = this.<stepToggleEasing>5__2.Invoke(t:  UnityEngine.Mathf.Clamp01(value:  val_37));
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<initialSeparatorScale>5__5, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.<targetSeparatorScale>5__6, y = V11.16B, z = this.<stepToggleDuration>5__3}, t:  val_39);
        val_54 = val_40.y;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<initialSeparatorPosition>5__7, y = val_40.y, z = val_39}, b:  new UnityEngine.Vector3() {x = this.<targetTopSeparatorPosition>5__8, y = V11.16B, z = this.<stepToggleDuration>5__3}, t:  val_39);
        val_55 = val_41.z;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<initialSeparatorPosition>5__7, y = val_41.y, z = val_39}, b:  new UnityEngine.Vector3() {x = this.<targetBottomSeparatorPosition>5__9, y = V11.16B, z = this.<stepToggleDuration>5__3}, t:  val_39);
        val_53 = val_42.y;
        val_48 = UnityEngine.Mathf.Lerp(a:  this.<initialHighlightAlpha>5__10, b:  this.<targetHighlightAlpha>5__11, t:  val_39);
        this.<>4__this.currentStepTopSeparator.localScale = new UnityEngine.Vector3() {x = val_40.x, y = val_54, z = val_40.z};
        this.<>4__this.currentStepBottomSeparator.localScale = new UnityEngine.Vector3() {x = val_40.x, y = val_54, z = val_40.z};
        this.<>4__this.currentStepTopSeparator.localPosition = new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_55};
        this.<>4__this.currentStepBottomSeparator.localPosition = new UnityEngine.Vector3() {x = val_42.x, y = val_53, z = val_42.z};
        val_50 = 0;
        label_82:
        if(val_50 >= ((this.<>4__this.currentStepHighlights.Length) << ))
        {
            goto label_80;
        }
        
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.<>4__this.currentStepHighlights[val_50], alpha:  val_48);
        val_50 = val_50 + 1;
        if((this.<>4__this.currentStepHighlights) != null)
        {
            goto label_82;
        }
        
        throw new NullReferenceException();
        label_80:
        val_49 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_49;
        return (bool)val_49;
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
