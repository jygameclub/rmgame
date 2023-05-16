using UnityEngine;
private sealed class Area22View.<ShowWaterCaustics>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area22.Area22View <>4__this;
    private int <frame>5__2;
    private float[] <lastDeltaTimes>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area22View.<ShowWaterCaustics>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        int val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.waterCausticsMaterial.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area22.Area22View.UseCustomTime, value:  1f);
        this.<>4__this.waterCausticsMaterial.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area22.Area22View.CustomTime, value:  this.<>4__this.elapsedTime);
        val_9 = this;
        this.<frame>5__2 = 0;
        mem[1152921519640408272] = new float[3];
        goto label_8;
        label_1:
        val_9 = this.<frame>5__2;
        this.<>1__state = 0;
        label_8:
        if(val_9 >= 10)
        {
                if((this.<>4__this) != null)
        {
            goto label_10;
        }
        
        }
        
        int val_3 = val_9 / (this.<lastDeltaTimes>5__3.Length);
        val_3 = val_9 - (val_3 * (this.<lastDeltaTimes>5__3.Length));
        this.<lastDeltaTimes>5__3[val_3] = UnityEngine.Time.deltaTime;
        int val_9 = val_9;
        val_9 = val_9 + 1;
        val_9 = val_9;
        if(((0.GetAverageOfDeltaTimes(lastFloats:  this.<lastDeltaTimes>5__3)) >= 0) || (val_9 < (this.<lastDeltaTimes>5__3.Length)))
        {
            goto label_17;
        }
        
        label_10:
        if((this.<>4__this.waterCausticsRoutine) != null)
        {
                this.<>4__this.StopCoroutine(routine:  this.<>4__this.waterCausticsRoutine);
            this.<>4__this = 0;
        }
        
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.IncreaseWaterCausticsOpacitySmoothly());
        val_10 = 0;
        this.<>4__this = this.<>4__this.StartCoroutine(routine:  this.<>4__this.UpdateWaterCaustics());
        return (bool)val_10;
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_17:
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
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
