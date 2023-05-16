using UnityEngine;
private sealed class AreaDialogTaskRow.<AnimateAfterDelay>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRow <>4__this;
    public int toIndex;
    public System.Action onComplete;
    private Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialogTaskRow.<>c__DisplayClass19_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AreaDialogTaskRow.<AnimateAfterDelay>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AreaDialogTaskRow.<>c__DisplayClass19_0 val_13;
        int val_14;
        val_13 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new AreaDialogTaskRow.<>c__DisplayClass19_0();
        .<>4__this = this.<>4__this;
        this.<>8__1 = this.toIndex;
        this.<>8__1 = this.onComplete;
        val_14 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        this.<>1__state = val_14;
        return (bool)val_14;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.audioManager.PlaySound(type:  254, offset:  0.04f);
        this.<>4__this.checkVisual.SetActive(value:  true);
        UnityEngine.Vector3 val_4 = this.<>4__this.checkVisual.transform.localScale;
        this.<>8__1 = val_4.x;
        this.<>8__1 = val_4.y;
        this.<>8__1 = val_4.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.<>8__1.originalScale, y = V8.16B, z = V9.16B}, d:  2.5f);
        this.<>4__this.checkVisual.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.<>8__1.originalScale, y = val_6.y, z = val_6.z}, d:  1f);
        val_13 = this.<>8__1;
        Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetOnComplete<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.SetEase<UnityEngine.Vector3>(tween:  Royal.Infrastructure.Utils.Animation.Tween.MTweenShortcuts.MtLocalScale(transform:  this.<>4__this.checkVisual.transform, endScale:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.15f), easeType:  2), onComplete:  new System.Action(object:  val_13, method:  System.Void AreaDialogTaskRow.<>c__DisplayClass19_0::<AnimateAfterDelay>b__0())).Start();
        label_2:
        val_14 = 0;
        return (bool)val_14;
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
