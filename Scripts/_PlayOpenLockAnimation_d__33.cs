using UnityEngine;
private sealed class RoyalPassLastRowView.<PlayOpenLockAnimation>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView <>4__this;
    public float yThreshold;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassLastRowView.<PlayOpenLockAnimation>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Animator val_6;
        int val_7;
        val_6 = this;
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
        
        val_7 = 1;
        this.<>4__this.lockParent.gameObject.SetActive(value:  true);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  45f));
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.lockAnimator.enabled = true;
        val_6 = this.<>4__this.lockAnimator;
        val_6.Play(stateNameHash:  Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassLastRowView.BackgroundPatchDarkAlpha, layer:  0, normalizedTime:  0f);
        this.<>4__this.audioManager.PlaySound(type:  146, offset:  0.04f);
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
