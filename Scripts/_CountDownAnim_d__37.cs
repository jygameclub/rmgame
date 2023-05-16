using UnityEngine;
private sealed class KingDrillRoom.<CountDownAnim>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Story.KingDrillRoom <>4__this;
    private UnityEngine.Vector3 <startPos>5__2;
    private float <remainingTime>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KingDrillRoom.<CountDownAnim>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Story.KingDrillRoomBundledSubPrefabView val_11;
        int val_12;
        UnityEngine.Vector3 val_14;
        UnityEngine.Vector3 val_15;
        float val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_11;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.<>4__this.bundle.wall.transform.position;
        this.<startPos>5__2 = val_2;
        mem[1152921519968767628] = val_2.y;
        mem[1152921519968767632] = val_2.z;
        this.<remainingTime>5__3 = (float)this.<>4__this.moveManager.<MaxSeconds>k__BackingField;
        goto label_8;
        label_1:
        this.<>1__state = 0;
        label_8:
        if((this.<>4__this.moveManager.<Seconds>k__BackingField) <= 0)
        {
            goto label_11;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = (this.<remainingTime>5__3) - val_3;
        this.<remainingTime>5__3 = val_3;
        int val_11 = this.<>4__this.moveManager.<Seconds>k__BackingField;
        val_11 = val_11 - 1;
        if(val_3 >= 0)
        {
            goto label_13;
        }
        
        this.<>4__this.moveManager.DecreaseSecond();
        val_11 = this.<>4__this;
        this.<>4__this.bundle.timer.SetSeconds(seconds:  this.<>4__this.moveManager.<Seconds>k__BackingField);
        this.<>4__this.PlaySpeechForRemainingSeconds();
        goto label_17;
        label_11:
        val_12 = 0;
        return (bool)val_12;
        label_13:
        val_11 = this.<>4__this.bundle;
        label_17:
        mem[this.<>4__this.bundle] + 128.UpdateTimerRatio(actualRatio:  UnityEngine.Mathf.Max(a:  0f, b:  (this.<remainingTime>5__3) / ((float)this.<>4__this.moveManager.<MaxSeconds>k__BackingField)));
        if((this.<remainingTime>5__3) > 10f)
        {
                float val_12 = this.<remainingTime>5__3;
            val_14 = this.<startPos>5__2;
            float val_13 = (float)this.<>4__this.moveManager.<MaxSeconds>k__BackingField;
            val_15 = this.<>4__this.wallFirstMaxLeftPos;
            val_12 = val_12 + (-10f);
            val_13 = val_13 + (-10f);
            val_12 = val_12 / val_13;
            val_12 = 1f - val_12;
            val_18 = this.<>4__this.wallCurve.Evaluate(time:  val_12);
        }
        else
        {
                val_14 = this.<>4__this.wallFirstMaxLeftPos;
            float val_14 = this.<remainingTime>5__3;
            val_14 = val_14 / (-10f);
            val_14 = val_14 + 1f;
            val_18 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  0).Invoke(t:  val_14);
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_14, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.<>4__this.wallMaxLeftPosition, y = V12.16B, z = V13.16B}, t:  val_18);
        mem[this.<>4__this.bundle] + 40.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        val_12 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_12;
        return (bool)val_12;
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
