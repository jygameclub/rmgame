using UnityEngine;
private sealed class DynamiteBoxItemView.<ShrinkWick>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView <>4__this;
    public int dynamiteIndex;
    private UnityEngine.SpriteRenderer <wick>5__2;
    private UnityEngine.Vector3 <wickStartScale>5__3;
    private UnityEngine.Vector3 <wickStartPosition>5__4;
    private UnityEngine.Vector3 <wickTargetScale>5__5;
    private UnityEngine.Vector3 <wickTargetPosition>5__6;
    private float <dur>5__7;
    private float <elapsed>5__8;
    private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles <sparks>5__9;
    private UnityEngine.Vector3 <sparkStartPos>5__10;
    private UnityEngine.Vector3 <sparkFinalPos>5__11;
    private UnityEngine.Vector3 <sparkStartScale>5__12;
    private UnityEngine.Vector3 <sparkFinalScale>5__13;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <sineInEasing>5__14;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamiteBoxItemView.<ShrinkWick>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_23;
        float val_24;
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
        val_23 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.<>1__state = val_23;
        return (bool)val_23;
        label_2:
        this.<>1__state = 0;
        this.<wick>5__2 = this.<>4__this.wicks[this.dynamiteIndex];
        UnityEngine.Vector3 val_3 = this.<>4__this.wicks[this.dynamiteIndex].transform.localScale;
        this.<wickStartScale>5__3 = val_3;
        mem[1152921520345412700] = val_3.y;
        mem[1152921520345412704] = val_3.z;
        UnityEngine.Vector3 val_5 = this.<>4__this.wicks[this.dynamiteIndex].transform.localPosition;
        this.<wickStartPosition>5__4 = val_5;
        mem[1152921520345412712] = val_5.y;
        mem[1152921520345412716] = val_5.z;
        this.<wickTargetScale>5__5 = 0;
        mem[1152921520345412728] = 0;
        UnityEngine.Vector3 val_7 = this.<wick>5__2.transform.localPosition;
        this.<wickTargetPosition>5__6 = val_7;
        mem[1152921520345412740] = val_7.z;
        mem[1152921520345412736] = 1028443341;
        this.<dur>5__7 = 0.5f;
        this.<elapsed>5__8 = 0f;
        Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles val_26 = this.<>4__this.sparkParticles[this.dynamiteIndex];
        this.<sparks>5__9 = val_26;
        UnityEngine.Vector3 val_9 = val_26.transform.localPosition;
        this.<sparkStartPos>5__10 = val_9;
        mem[1152921520345412764] = val_9.y;
        mem[1152921520345412768] = val_9.z;
        this.<sparkFinalPos>5__11 = 0;
        mem[1152921520345412780] = 0;
        UnityEngine.Vector3 val_11 = this.<sparks>5__9.transform.localScale;
        this.<sparkStartScale>5__12 = val_11;
        mem[1152921520345412788] = val_11.y;
        mem[1152921520345412792] = val_11.z;
        this.<sparkFinalScale>5__13 = 0;
        mem[1152921520345412804] = 0;
        this.<sineInEasing>5__14 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  2);
        goto label_24;
        label_1:
        this.<>1__state = 0;
        label_24:
        val_24 = this.<elapsed>5__8;
        if(val_24 < 0)
        {
            goto label_25;
        }
        
        label_3:
        val_23 = 0;
        return (bool)val_23;
        label_25:
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_24 + val_13;
        this.<elapsed>5__8 = val_13;
        val_24 = val_13 / (this.<dur>5__7);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<wickStartPosition>5__4, y = V10.16B, z = V14.16B}, b:  new UnityEngine.Vector3() {x = this.<wickTargetPosition>5__6, y = V11.16B, z = V12.16B}, t:  val_24);
        this.<wick>5__2.transform.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<wickStartScale>5__3, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = this.<wickTargetScale>5__5, y = V11.16B, z = V12.16B}, t:  val_24);
        this.<wick>5__2.transform.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<sparkStartPos>5__10, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = this.<sparkFinalPos>5__11, y = V11.16B, z = V12.16B}, t:  val_24);
        this.<sparks>5__9.transform.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<sparkStartScale>5__12, y = V14.16B, z = this.<wickStartPosition>5__4}, b:  new UnityEngine.Vector3() {x = this.<sparkFinalScale>5__13, y = V11.16B, z = V12.16B}, t:  this.<sineInEasing>5__14.Invoke(t:  val_24));
        this.<sparks>5__9.transform.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_23 = 1;
        return (bool)val_23;
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
