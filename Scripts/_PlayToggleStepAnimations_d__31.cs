using UnityEngine;
private sealed class RoyalPassScrollContent.<PlayToggleStepAnimations>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassScrollContent <>4__this;
    public UnityEngine.Vector3 targetSeparatorScale;
    public UnityEngine.Vector3 initialSeparatorScale;
    public UnityEngine.Vector3 targetTopSeparatorPosition;
    public UnityEngine.Vector3 initialSeparatorPosition;
    public UnityEngine.Vector3 targetBottomSeparatorPosition;
    public float targetHighlightAlpha;
    public float initialHighlightAlpha;
    public System.Collections.Generic.List<int> enabledSteps;
    public System.Action onComplete;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <stepToggleEasing>5__2;
    private float <stepToggleDuration>5__3;
    private float <stepToggleElapsed>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassScrollContent.<PlayToggleStepAnimations>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_19;
        float val_20;
        float val_21;
        System.Action val_22;
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
        if((this.<>4__this.royalPassManager.IsLastStep()) == false)
        {
            goto label_6;
        }
        
        this.<>4__this.PlayBankStepReachedAnimations();
        goto label_9;
        label_2:
        val_19 = this.<stepToggleElapsed>5__4;
        val_20 = this.<stepToggleDuration>5__3;
        this.<>1__state = 0;
        goto label_8;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        label_6:
        this.<stepToggleEasing>5__2 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  5);
        val_20 = this;
        this.<stepToggleDuration>5__3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  45f);
        val_19 = 1152921519275136632;
        this.<stepToggleElapsed>5__4 = 0f;
        this.<>4__this.audioManager.PlaySound(type:  239, offset:  0.04f);
        label_8:
        val_21 = this.<stepToggleElapsed>5__4;
        if(val_21 <= (this.<stepToggleDuration>5__3))
        {
            goto label_14;
        }
        
        this.<stepToggleEasing>5__2 = 0;
        label_9:
        bool val_19 = this.<>4__this.isMoveAnimationCompleted;
        if(val_19 == false)
        {
            goto label_16;
        }
        
        val_20 = 0;
        label_20:
        if(val_20 >= val_19)
        {
            goto label_18;
        }
        
        val_19 = val_19 & 4294967295;
        if(val_20 >= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_19 + 0;
        this.<>4__this.FinishStepUpAnimation(step:  ((this.<>4__this.isMoveAnimationCompleted & 4294967295) + 0) + 32);
        val_20 = val_20 + 1;
        if(this.enabledSteps != null)
        {
            goto label_20;
        }
        
        label_18:
        val_22 = this.onComplete;
        if(val_22 == null)
        {
                return (bool)val_22;
        }
        
        val_22.Invoke();
        label_3:
        val_22 = 0;
        return (bool)val_22;
        label_16:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_22 = 1;
        return (bool)val_22;
        label_14:
        float val_4 = UnityEngine.Time.deltaTime;
        val_21 = val_21 + val_4;
        this.<stepToggleElapsed>5__4 = val_21;
        val_4 = val_21 / (this.<stepToggleDuration>5__3);
        val_21 = this.<stepToggleEasing>5__2.Invoke(t:  UnityEngine.Mathf.Clamp01(value:  val_4));
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.targetSeparatorScale, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.initialSeparatorScale, y = V11.16B, z = this.<stepToggleDuration>5__3}, t:  val_21);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.targetTopSeparatorPosition, y = val_7.y, z = val_21}, b:  new UnityEngine.Vector3() {x = this.initialSeparatorPosition, y = V11.16B, z = this.<stepToggleDuration>5__3}, t:  val_21);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.targetBottomSeparatorPosition, y = val_21, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.initialSeparatorPosition, y = V11.16B, z = this.<stepToggleDuration>5__3}, t:  val_21);
        this.<>4__this.currentStepTopSeparator.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        this.<>4__this.currentStepBottomSeparator.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        float val_12 = this.<>4__this.GetSeparatorPositionY(step:  (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished - 1)) << 2) + 32, def:  val_8.y);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        float val_16 = this.<>4__this.GetSeparatorPositionY(step:  (((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + ((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished - 1)) << 2) + (((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + ((Unit>>0&0xFFFFFFFF, def:  val_9.y);
        this.<>4__this.currentStepTopSeparator.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.<>4__this.currentStepBottomSeparator.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        var val_21 = 0;
        label_43:
        if(val_21 >= ((this.<>4__this.currentStepHighlights.Length) << ))
        {
            goto label_41;
        }
        
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.<>4__this.currentStepHighlights[val_21], alpha:  UnityEngine.Mathf.Lerp(a:  this.targetHighlightAlpha, b:  this.initialHighlightAlpha, t:  val_21));
        val_21 = val_21 + 1;
        if((this.<>4__this.currentStepHighlights) != null)
        {
            goto label_43;
        }
        
        throw new NullReferenceException();
        label_41:
        val_20 = this.enabledSteps;
        if((this.<>4__this.currentStepHighlights) == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<>4__this.UpdateRowPatchAlphaByRatio(step:  (this.<>4__this.currentStepHighlights[((this.<>4__this.currentStepHighlights) - 1) << 2]) + 1, ratio:  val_21);
        val_22 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_22;
        return (bool)val_22;
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
