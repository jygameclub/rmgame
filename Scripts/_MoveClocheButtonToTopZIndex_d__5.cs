using UnityEngine;
private sealed class HomeClocheTutorial.<MoveClocheButtonToTopZIndex>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeClocheTutorial <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HomeClocheTutorial.<MoveClocheButtonToTopZIndex>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog val_10;
        int val_11;
        val_10 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_9;
        }
        
        this.<>1__state = 0;
        this.<>4__this.prelevelDialog.PrepareClocheForTutorial(tutorial:  this.<>4__this);
        val_11 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        val_10 = this.<>4__this.prelevelDialog;
        if(val_10 != 0)
        {
                Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView val_3 = this.<>4__this.tutorialManager.CreateArrow();
            val_10 = val_3;
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView val_5 = val_3.SetScale(scale:  1.3f).SetOrientation(orientation:  0);
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView val_6 = val_10.SetPosition(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            val_10.SetSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295}).Show(fadeDuration:  0.2f);
        }
        
        label_9:
        val_11 = 0;
        return (bool)val_11;
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
