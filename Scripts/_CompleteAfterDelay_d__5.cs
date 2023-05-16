using UnityEngine;
private sealed class PlayLifeCollectAnimationAction.<CompleteAfterDelay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayLifeCollectAnimationAction.<CompleteAfterDelay>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
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
        if(((this.<>4__this.unlimitedMinutes) < 1) || ((this.<>4__this.disableUiTouch) == true))
        {
            goto label_6;
        }
        
        val_6 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.waitForSeconds);
        this.<>1__state = val_6;
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        label_6:
        UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeItemAnimation>(path:  "LifeItemAnimation")).Play(minutes:  this.<>4__this.unlimitedMinutes);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  ((this.<>4__this.disableUiTouch) == false) ? 0.5f : 1.5f);
        this.<>1__state = 2;
        val_6 = 1;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        label_3:
        val_6 = 0;
        return (bool)val_6;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = 39091;
        val_1 = new System.NotSupportedException();
        throw val_1;
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
