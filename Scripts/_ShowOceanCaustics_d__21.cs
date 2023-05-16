using UnityEngine;
private sealed class Area20View.<ShowOceanCaustics>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area20.Area20View <>4__this;
    private int <frame>5__2;
    private float[] <lastDeltaTimes>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area20View.<ShowOceanCaustics>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        this.<>4__this.particles.SetActive(value:  true);
        this.<>4__this = 0;
        var val_10 = 4;
        label_14:
        if((val_10 - 4) >= (this.<>4__this.oceanCausticsMat.Length))
        {
            goto label_6;
        }
        
        this.<>4__this.oceanCausticsMat[0].SetFloat(nameID:  Royal.Scenes.Home.Areas.Area20.Area20View.UseCustomTime, value:  1f);
        this.<>4__this.oceanCausticsMat[0].SetFloat(nameID:  Royal.Scenes.Home.Areas.Area20.Area20View.CustomTime, value:  this.<>4__this.elapsedTime);
        val_10 = val_10 + 1;
        if((this.<>4__this.oceanCausticsMat) != null)
        {
            goto label_14;
        }
        
        label_1:
        val_7 = this.<frame>5__2;
        this.<>1__state = 0;
        goto label_16;
        label_6:
        val_7 = this;
        this.<frame>5__2 = 0;
        mem[1152921519648809360] = new float[3];
        label_16:
        if((this.<frame>5__2) >= 10)
        {
                if((this.<>4__this) != null)
        {
            goto label_18;
        }
        
        }
        
        int val_4 = (this.<frame>5__2) / (this.<lastDeltaTimes>5__3.Length);
        val_4 = (this.<frame>5__2) - (val_4 * (this.<lastDeltaTimes>5__3.Length));
        this.<lastDeltaTimes>5__3[val_4] = UnityEngine.Time.deltaTime;
        this.<frame>5__2 = 1;
        if(((0.GetAverageOfDeltaTimes(lastFloats:  this.<lastDeltaTimes>5__3)) < 0) && ((this.<frame>5__2) >= (this.<lastDeltaTimes>5__3.Length)))
        {
                label_18:
            if((this.<>4__this.oceanCausticsRoutine) != null)
        {
                this.<>4__this.StopCoroutine(routine:  this.<>4__this.oceanCausticsRoutine);
            this.<>4__this = 0;
        }
        
            this.<>4__this = this.<>4__this.StartCoroutine(routine:  this.<>4__this.UpdateOceanCaustics());
            var val_12 = 0;
            do
        {
            if(val_12 >= (this.<>4__this.distortionAnimations.Length))
        {
                return false;
        }
        
            this.<>4__this.distortionAnimations[val_12].PlayDistortion();
            val_12 = val_12 + 1;
        }
        while((this.<>4__this.distortionAnimations) != null);
        
            throw new NullReferenceException();
        }
        
        this.<>2__current = 0;
        this.<>1__state = 1;
        return false;
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
