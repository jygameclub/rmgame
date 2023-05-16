using UnityEngine;
private sealed class MatchItemView.<MergeCoroutine>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView <>4__this;
    public Royal.Infrastructure.Utils.Animation.ManualEasingType easing;
    public float duration;
    public UnityEngine.Vector3 endPosition;
    public bool extrapolate;
    public System.Action onComplete;
    private float <elapsed>5__2;
    private UnityEngine.Vector3 <startPosition>5__3;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easer>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MatchItemView.<MergeCoroutine>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_10;
        int val_11;
        var val_12;
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
        this.<elapsed>5__2 = 0f;
        UnityEngine.Vector3 val_2 = this.<>4__this.transform.position;
        this.<startPosition>5__3 = val_2;
        mem[1152921520244904944] = val_2.y;
        mem[1152921520244904948] = val_2.z;
        this.<easer>5__4 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  this.easing);
        goto label_6;
        label_2:
        this.<>1__state = 0;
        goto label_17;
        label_1:
        this.<>1__state = 0;
        label_6:
        val_10 = this.<elapsed>5__2;
        if(val_10 < 0)
        {
            goto label_8;
        }
        
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = this.endPosition};
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_8:
        float val_5 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_5 = val_10 + val_5;
        this.<elapsed>5__2 = val_5;
        val_5 = val_5 / this.duration;
        UnityEngine.Vector3 val_8 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<startPosition>5__3, y = this.duration}, b:  new UnityEngine.Vector3() {x = this.endPosition}, t:  this.<easer>5__4.Invoke(t:  val_5), extrapolate:  this.extrapolate);
        this.<>4__this.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_10 = this.<elapsed>5__2;
        val_12 = null;
        val_12 = null;
        if((val_10 / this.duration) > Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.ExplodeCompleteRatio)
        {
                if(this.onComplete != null)
        {
                this.onComplete.Invoke();
        }
        
            if((this.<>4__this.mergeCoroutine) != null)
        {
                Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.<>4__this.mergeCoroutine);
            this.<>4__this = 0;
        }
        
            val_11 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_11;
            return (bool)val_11;
        }
        
        label_17:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_11 = 1;
        return (bool)val_11;
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
