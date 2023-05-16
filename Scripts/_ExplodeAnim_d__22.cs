using UnityEngine;
private sealed class MatchItemView.<ExplodeAnim>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Explode.Trigger exploder;
    public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView <>4__this;
    private float <elapsed>5__2;
    private UnityEngine.Vector3 <startScale>5__3;
    private UnityEngine.Vector3 <endScale>5__4;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easer>5__5;
    private float <duration>5__6;
    private float <particleDelay>5__7;
    private bool <didExplodeParticle>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MatchItemView.<ExplodeAnim>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        float val_9;
        var val_10;
        float val_11;
        int val_12;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(this.exploder != 4)
        {
                if(this.exploder != 2)
        {
            goto label_4;
        }
        
        }
        
        val_8 = this;
        this.<elapsed>5__2 = 0f;
        UnityEngine.Vector3 val_1 = 39208.GetScale();
        this.<startScale>5__3 = val_1;
        mem[1152921520244154072] = val_1.y;
        mem[1152921520244154076] = val_1.z;
        var val_2 = (this.exploder == 2) ? 1 : 0;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.<endScale>5__4 = val_3;
        mem[1152921520244154084] = val_3.y;
        mem[1152921520244154088] = val_3.z;
        val_9 = mem[36605768 + this.exploder == 0x2 ? 1 : 0];
        val_9 = 36605768 + this.exploder == 0x2 ? 1 : 0;
        val_10 = this;
        this.<duration>5__6 = val_9;
        mem[1152921520244154096] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  2);
        mem[1152921520244154108] = 36605776 + this.exploder == 0x2 ? 1 : 0;
        mem[1152921520244154112] = 0;
        goto label_9;
        label_1:
        val_10 = this;
        val_9 = this.<duration>5__6;
        val_8 = -3.087165E-17f;
        this.<>1__state = 0;
        label_9:
        if(val_8 >= 0)
        {
                39208.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  this.<>4__this);
            val_12 = 0;
            this.<easer>5__5 = 0;
            mem[1152921520244154084] = 0;
            mem[1152921520244154076] = 0;
            this.<startScale>5__3 = 0;
            return (bool)val_12;
        }
        
        float val_5 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_5 = val_8 + val_5;
        this.<elapsed>5__2 = val_5;
        val_5 = val_5 / (this.<duration>5__6);
        val_11 = this.<easer>5__5.Invoke(t:  val_5);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<startScale>5__3, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.<endScale>5__4, y = V11.16B, z = V9.16B}, t:  val_11);
        this.<elapsed>5__2.SetScale(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        if(((this.<elapsed>5__2) >= (this.<particleDelay>5__7)) && ((this.<didExplodeParticle>5__8) != true))
        {
                this.<didExplodeParticle>5__8 = true;
            this.<>4__this.PlayParticle(extraEmit:  false);
        }
        
        val_12 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_12;
        return (bool)val_12;
        label_4:
        this.<>4__this.PlayParticle(extraEmit:  true);
        this.<>4__this.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  this.<>4__this);
        label_2:
        val_12 = 0;
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
