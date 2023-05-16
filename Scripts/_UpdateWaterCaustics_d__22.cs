using UnityEngine;
private sealed class Area22View.<UpdateWaterCaustics>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Areas.Area22.Area22View <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Area22View.<UpdateWaterCaustics>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this = 0;
        this.<>4__this.waterCausticsMaterial.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area22.Area22View.UseCustomTime, value:  1f);
        this.<>4__this.distortionAnimation.PlayDistortion();
        goto label_8;
        label_1:
        this.<>1__state = 0;
        label_8:
        this.<>4__this.waterCausticsMaterial.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area22.Area22View.CustomTime, value:  this.<>4__this.elapsedTime);
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_1 / 20f;
        val_2 = 1;
        val_1 = (this.<>4__this.elapsedTime) + val_1;
        this.<>4__this = val_1;
        this.<>2__current = 0;
        this.<>1__state = val_2;
        return (bool)val_2;
        label_2:
        val_2 = 0;
        return (bool)val_2;
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
