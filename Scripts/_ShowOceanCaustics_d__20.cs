using UnityEngine;
private sealed class Area01View.<ShowOceanCaustics>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area01.Area01View <>4__this;
    private int <frame>5__2;
    private float[] <lastDeltaTimes>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area01View.<ShowOceanCaustics>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return false;
        }
        
            this.<>1__state = 0;
            this.<>4__this = 0;
            this.<>4__this.oceanCausticsMat.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area01.Area01View.UseCustomTime, value:  1f);
            this.<>4__this.oceanCausticsMat.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area01.Area01View.CustomTime, value:  this.<>4__this.elapsedTime);
            val_9 = this;
            this.<frame>5__2 = 0;
            mem[1152921519801565888] = new float[3];
        }
        else
        {
                val_9 = this.<frame>5__2;
            this.<>1__state = 0;
        }
        
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
        if(((0.GetAverageOfDeltaTimes(lastFloats:  this.<lastDeltaTimes>5__3)) < 0) && (val_9 >= (this.<lastDeltaTimes>5__3.Length)))
        {
                label_10:
            if((this.<>4__this.oceanCausticsRoutine) != null)
        {
                this.<>4__this.StopCoroutine(routine:  this.<>4__this.oceanCausticsRoutine);
            this.<>4__this = 0;
        }
        
            UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  this.<>4__this.IncreaseOceanCausticsOpacitySmoothly());
            this.<>4__this = this.<>4__this.StartCoroutine(routine:  this.<>4__this.UpdateOceanCaustics());
            this.<>4__this.oceanDistortion.PlayDistortion();
            return false;
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
