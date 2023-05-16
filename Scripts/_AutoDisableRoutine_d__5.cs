using UnityEngine;
private sealed class AutoDisableParticles.<AutoDisableRoutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Utils.Particles.AutoDisableParticles <>4__this;
    private bool <hasParticles>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutoDisableParticles.<AutoDisableRoutine>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        bool val_10;
        int val_11;
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
        this.<hasParticles>5__2 = true;
        var val_11 = 0;
        label_10:
        if(val_11 >= (this.<>4__this.particles.Length))
        {
            goto label_6;
        }
        
        UnityEngine.ParticleSystem val_10 = this.<>4__this.particles[val_11];
        MainModule val_1 = val_10.main;
        if(val_2.yAdvance > 0f)
        {
                MainModule val_5 = val_10.main;
            float val_6 = val_2.yAdvance;
        }
        
        val_11 = val_11 + 1;
        if((this.<>4__this.particles) != null)
        {
            goto label_10;
        }
        
        label_1:
        val_10 = this;
        this.<hasParticles>5__2 = false;
        this.<>1__state = 0;
        var val_13 = 0;
        label_18:
        if(val_13 >= (this.<>4__this.particles.Length))
        {
            goto label_14;
        }
        
        if((this.<>4__this.particles[val_13].particleCount) >= 1)
        {
            goto label_17;
        }
        
        val_13 = val_13 + 1;
        if((this.<>4__this.particles) != null)
        {
            goto label_18;
        }
        
        label_2:
        this.<>1__state = 0;
        val_10 = this.<hasParticles>5__2;
        label_14:
        if(val_10 == true)
        {
            goto label_20;
        }
        
        this.<>4__this.OnComplete();
        label_3:
        val_11 = 0;
        return (bool)val_11;
        label_6:
        val_11 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Mathf.Max(a:  0.5f, b:  0f));
        this.<>1__state = val_11;
        return (bool)val_11;
        label_17:
        this.<hasParticles>5__2 = true;
        label_20:
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
