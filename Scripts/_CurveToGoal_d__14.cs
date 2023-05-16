using UnityEngine;
private sealed class MailGoalView.<CurveToGoal>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView <>4__this;
    public UnityEngine.Vector3 targetPos;
    public float duration;
    public System.Action onComplete;
    private float <elapsed>5__2;
    private UnityEngine.Vector3 <p0>5__3;
    private UnityEngine.Vector3 <p3>5__4;
    private UnityEngine.Vector3 <p1>5__5;
    private UnityEngine.Vector3 <p2>5__6;
    private float <speed>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MailGoalView.<CurveToGoal>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_25;
        float val_26;
        float val_27;
        float val_28;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_25 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_25;
        }
        
        this.<>1__state = 0;
        val_26 = this.<>4__this.collectDelay;
        if(val_26 >= 0f)
        {
            goto label_5;
        }
        
        val_27 = this;
        this.<elapsed>5__2 = 0f;
        goto label_6;
        label_1:
        val_27 = this.<elapsed>5__2;
        val_28 = this.duration;
        this.<>1__state = 0;
        goto label_7;
        label_2:
        val_27 = this;
        this.<elapsed>5__2 = 0f;
        this.<>1__state = 0;
        label_6:
        UnityEngine.Vector3 val_2 = this.<>4__this.transform.position;
        this.<p0>5__3 = val_2;
        mem[1152921520259025560] = val_2.y;
        mem[1152921520259025564] = val_2.z;
        this.<p3>5__4 = this.targetPos;
        mem[1152921520259025576] = 0;
        UnityEngine.Vector3 val_24 = this.targetPos;
        val_24 = val_24 - val_2.x;
        UnityEngine.Vector3 val_6 = this.<>4__this.transform.position;
        float val_25 = -0.7f;
        float val_7 = (UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  val_24, b:  0.5f), b:  -0.5f)) + val_6.x;
        val_25 = val_6.y + val_25;
        mem[1152921520259025588] = val_6.z;
        this.<p2>5__6 = val_7;
        this.<p1>5__5 = val_7;
        mem[1152921520259025584] = val_25;
        mem[1152921520259025596] = val_25;
        mem[1152921520259025600] = val_6.z;
        val_6.z = (Royal.Infrastructure.Utils.Animation.CubicBezierCurve.CalculateArcLength(p0:  new UnityEngine.Vector3() {x = this.<p0>5__3, y = V6.16B, z = val_6.z}, p1:  new UnityEngine.Vector3() {x = val_7, y = val_25, z = val_6.z}, p2:  new UnityEngine.Vector3() {x = val_7, y = val_6.z, z = this.<p3>5__4}, p3:  new UnityEngine.Vector3() {x = val_6.y, y = this.targetPos, z = this.targetPos})) / 15f;
        float val_9 = UnityEngine.Mathf.Lerp(a:  1f, b:  1.5f, t:  val_6.z);
        val_28 = this;
        val_9 = val_9 * this.duration;
        this.duration = val_9;
        mem[1152921520259025604] = 1065353216;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>4__this.shadowView.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  this.duration, snapping:  false), ease:  2);
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>4__this.viewParent, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  this.duration, snapping:  false), ease:  3);
        label_7:
        val_26 = this.<elapsed>5__2;
        if(val_26 >= 0)
        {
                this.<>4__this.tracerParticles.Recycle();
            this.<>4__this = 0;
            this.onComplete.Invoke();
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).Recycle<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailGoalView>(go:  this.<>4__this);
            val_25 = 0;
            return (bool)val_25;
        }
        
        float val_16 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_16 = val_16 * (this.<speed>5__7);
        val_26 = val_26 + val_16;
        this.<elapsed>5__2 = val_26;
        val_16 = val_26 / this.duration;
        UnityEngine.Vector3 val_18 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  UnityEngine.Mathf.Clamp01(value:  val_16), p0:  new UnityEngine.Vector3() {x = this.<p0>5__3, y = 0f, z = this.duration}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__5, y = val_6.z}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__6, y = ???, z = this.<p3>5__4}, p3:  new UnityEngine.Vector3() {x = ???, y = this.targetPos, z = this.targetPos});
        val_26 = val_18.x;
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_26, y = val_18.y, z = val_18.z};
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<p3>5__4, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_26, y = val_18.y, z = val_18.z});
        this.<speed>5__7 = UnityEngine.Mathf.Lerp(a:  0.6f, b:  1f, t:  val_20.x / 5f);
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_25 = 1;
        return (bool)val_25;
        label_5:
        val_25 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_26);
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
