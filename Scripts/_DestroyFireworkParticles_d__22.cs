using UnityEngine;
private sealed class WinLogoAnimationDialog.<DestroyFireworkParticles>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog <>4__this;
    public UnityEngine.GameObject fireworkParticles;
    private float <duration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WinLogoAnimationDialog.<DestroyFireworkParticles>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_2;
        var val_3;
        float val_4;
        val_2 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        val_3 = val_2;
        this.<duration>5__2 = 0f;
        val_4 = 0f;
        this.<>1__state = 0;
        goto label_3;
        label_1:
        val_3 = val_2;
        val_4 = this.<duration>5__2;
        this.<>1__state = 0;
        if(val_4 >= 0)
        {
            goto label_4;
        }
        
        label_3:
        float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_1 = val_4 + val_1;
        this.<duration>5__2 = val_1;
        if((this.<>4__this.remainingMovesManager.<IsTapToSkipClicked>k__BackingField) == false)
        {
            goto label_7;
        }
        
        label_4:
        val_2 = this.fireworkParticles;
        UnityEngine.Object.Destroy(obj:  val_2);
        return false;
        label_7:
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
