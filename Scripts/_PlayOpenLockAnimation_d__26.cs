using UnityEngine;
private sealed class RoyalPassRewardContainerView.<PlayOpenLockAnimation>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView <>4__this;
    public float yThreshold;
    private Royal.Scenes.Start.Context.Units.Audio.AudioManager <audioManager>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassRewardContainerView.<PlayOpenLockAnimation>d__26(int <>1__state)
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
            goto label_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_2 = this.<>4__this.lockParent.transform.position;
        if(val_2.y >= this.yThreshold)
        {
            goto label_6;
        }
        
        this.<>4__this.lockParent.gameObject.SetActive(value:  true);
        this.<audioManager>5__2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        val_7 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  45f));
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.lockAnimator.enabled = true;
        this.<>4__this.lockAnimator.Play(stateNameHash:  Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardContainerView.UnlockAnimation, layer:  0, normalizedTime:  0f);
        this.<audioManager>5__2.PlaySound(type:  146, offset:  0.04f);
        label_6:
        val_7 = 0;
        return (bool)val_7;
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
