using UnityEngine;
private sealed class ShowWinLogoDialogAction.<ShowLogoWithDelay>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.ShowWinLogoDialogAction <>4__this;
    private Royal.Infrastructure.UiComponents.Touch.UiTouchListener <uiTouchListener>5__2;
    private Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog <dialog>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShowWinLogoDialogAction.<ShowLogoWithDelay>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        var val_9;
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
        this.<uiTouchListener>5__2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
        val_1.disabler.DisableTouch();
        val_8 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = val_8;
        return (bool)val_8;
        label_2:
        this.<>1__state = 0;
        this.<dialog>5__3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.WinLogoAnimationDialog>(asset:  mem[21474836553], action:  this.<>4__this);
        val_9 = null;
        val_9 = null;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogSorting();
        val_4.sortEverything = val_4.sortEverything & 4294967295;
        Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything}, offset:  220);
        UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.2f);
        this.<>1__state = 2;
        val_8 = 1;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        this.<dialog>5__3.PlayWinLogoAnimation();
        this.<uiTouchListener>5__2.disabler.EnableTouch();
        label_3:
        val_8 = 0;
        return (bool)val_8;
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
