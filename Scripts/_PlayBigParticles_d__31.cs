using UnityEngine;
private sealed class DynamiteBoxItemView.<PlayBigParticles>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DynamiteBoxItemView.<PlayBigParticles>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles val_3;
        int val_4;
        var val_5;
        val_3 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_7;
        }
        
        this.<>1__state = 0;
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        39421.PlaySfx(type:  110, offset:  0.04f);
        val_5 = 4;
        label_16:
        if((val_5 - 4) >= ((this.<>4__this.sparkParticles.Length) << ))
        {
            goto label_7;
        }
        
        val_3 = this.<>4__this.sparkParticles[0];
        if(val_3 != 0)
        {
                Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles val_4 = this.<>4__this.sparkParticles[0];
            this.<>4__this.sparkParticles[0].particlesBig.Play();
        }
        
        val_5 = val_5 + 1;
        if((this.<>4__this.sparkParticles) != null)
        {
            goto label_16;
        }
        
        throw new NullReferenceException();
        label_7:
        val_4 = 0;
        return (bool)val_4;
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
