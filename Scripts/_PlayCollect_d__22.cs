using UnityEngine;
private sealed class LeagueCrownCollectView.<PlayCollect>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView <>4__this;
    private UnityEngine.Vector3 <p0>5__2;
    private UnityEngine.Vector3 <p1>5__3;
    private UnityEngine.Vector3 <p3>5__4;
    private UnityEngine.Vector3 <p2>5__5;
    private UnityEngine.Vector3 <shadowStartPos>5__6;
    private UnityEngine.Vector3 <shadowMaxPos>5__7;
    private float <curveDuration>5__8;
    private float <initalScale>5__9;
    private float <finalScale>5__10;
    private float <scaleDownRatio>5__11;
    private float <elapsed>5__12;
    private float <startSpeed>5__13;
    private float <maxSpeed>5__14;
    private float <speed>5__15;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeagueCrownCollectView.<PlayCollect>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_31;
        var val_32;
        float val_33;
        float val_34;
        float val_35;
        int val_36;
        float val_38;
        float val_39;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.<>4__this.crownItem.transform.position;
        this.<p0>5__2 = val_2;
        mem[1152921519132292188] = val_2.y;
        mem[1152921519132292192] = val_2.z;
        UnityEngine.Vector3 val_4 = this.<>4__this.crownItem.transform.position;
        this.<p1>5__3 = val_4;
        mem[1152921519132292200] = val_4.y;
        mem[1152921519132292204] = val_4.z;
        val_31 = 1152921505032404992;
        val_32 = null;
        val_32 = null;
        UnityEngine.Vector3 val_32 = this.<p1>5__3;
        float val_31 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P1YOffset;
        val_31 = val_4.y + val_31;
        mem[1152921519132292200] = val_31;
        val_32 = val_32 + Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P1XOffset;
        this.<p1>5__3 = val_32;
        UnityEngine.Vector3 val_6 = this.<>4__this.leagueButtonFrame.transform.position;
        val_33 = val_6.z;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_33}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.<p3>5__4 = val_7;
        mem[1152921519132292212] = val_7.y;
        mem[1152921519132292216] = val_7.z;
        this.<p2>5__5 = val_7;
        mem[1152921519132292224] = val_7.y;
        mem[1152921519132292228] = val_7.z;
        val_7.y = val_7.y + Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P2YOffset;
        mem[1152921519132292224] = val_7.y;
        val_7.x = val_7.x + Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.P2XOffset;
        this.<p2>5__5 = val_7.x;
        UnityEngine.Vector3 val_9 = this.<>4__this.crownShadow.transform.localPosition;
        mem[1152921519132292240] = val_9.z;
        this.<shadowMaxPos>5__7 = val_9;
        this.<shadowStartPos>5__6 = val_9;
        mem[1152921519132292236] = val_9.y;
        mem[1152921519132292248] = val_9.y + (-0.15f);
        mem[1152921519132292252] = val_9.z;
        val_34 = 0f;
        this.<initalScale>5__9 = 1.188f;
        this.<finalScale>5__10 = 0.6534001f;
        this.<curveDuration>5__8 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.Duration;
        val_35 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.Duration;
        this.<elapsed>5__12 = ;
        this.<startSpeed>5__13 = ;
        this.<maxSpeed>5__14 = 1f;
        this.<speed>5__15 = 0.2f;
        this.<scaleDownRatio>5__11 = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LeagueCrownCollect.LeagueCrownCollectView.ScaleDownRatio;
        goto label_16;
        label_1:
        val_34 = this.<elapsed>5__12;
        val_35 = this.<curveDuration>5__8;
        this.<>1__state = 0;
        label_16:
        if(val_34 < 0)
        {
            goto label_17;
        }
        
        this.<>4__this.PlayItemHitAnimation();
        label_2:
        val_36 = 0;
        return (bool)val_36;
        label_17:
        float val_11 = UnityEngine.Time.deltaTime;
        val_11 = val_11 * (this.<speed>5__15);
        val_34 = val_34 + val_11;
        this.<elapsed>5__12 = val_34;
        val_11 = val_34 / (this.<curveDuration>5__8);
        val_34 = 1f;
        float val_12 = UnityEngine.Mathf.Min(a:  val_11, b:  val_34);
        UnityEngine.Vector3 val_13 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  val_12, p0:  new UnityEngine.Vector3() {x = this.<p0>5__2}, p1:  new UnityEngine.Vector3() {x = this.<p1>5__3}, p2:  new UnityEngine.Vector3() {x = this.<p2>5__5, y = ???, z = this.<p3>5__4}, p3:  new UnityEngine.Vector3() {x = ???, y = 0f, z = 0f});
        val_38 = val_13.x;
        val_39 = val_13.y;
        this.<>4__this.crownItem.transform.position = new UnityEngine.Vector3() {x = val_38, y = val_39, z = val_13.z};
        if(val_12 < 0)
        {
                val_39 = this.<startSpeed>5__13;
            val_38 = this.<maxSpeed>5__14;
            this.<speed>5__15 = UnityEngine.Mathf.Lerp(a:  val_39, b:  val_38, t:  val_12 / 0.2f);
        }
        
        val_31 = this.<>4__this.crownShadow.transform;
        if(val_12 < 0)
        {
            
        }
        else
        {
                float val_33 = -0.5f;
            val_33 = val_12 + val_33;
        }
        
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__7, y = V14.16B, z = 0.2f}, b:  new UnityEngine.Vector3() {x = this.<shadowStartPos>5__6, y = val_39, z = val_38}, t:  val_33 + val_33);
        val_31.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        val_33 = this.<scaleDownRatio>5__11;
        if(val_12 > val_33)
        {
                float val_21 = val_12 - val_33;
            val_21 = val_21 / (val_34 - val_33);
            val_34 = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  2).Invoke(t:  val_21);
            val_31 = this.<>4__this.crownItem.transform;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Mathf.Lerp(a:  this.<initalScale>5__9, b:  this.<finalScale>5__10, t:  val_34), a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_31.localScale = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<shadowMaxPos>5__7, y = this.<initalScale>5__9, z = val_39}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, t:  val_34);
            this.<>4__this.crownShadow.transform.localPosition = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
        }
        
        val_36 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_36;
        return (bool)val_36;
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
