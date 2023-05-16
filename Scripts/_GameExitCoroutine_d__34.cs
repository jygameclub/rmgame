using UnityEngine;
private sealed class GameManager.<GameExitCoroutine>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Context.Units.GameManager <>4__this;
    private int <count>5__2;
    private bool <loadingViewDisplayed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameManager.<GameExitCoroutine>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        bool val_6;
        var val_7;
        System.Action val_9;
        val_5 = 0;
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
                return (bool)val_5;
        }
        
        this.<count>5__2 = 0;
        this.<>1__state = 0;
        this.<loadingViewDisplayed>5__3 = false;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        label_2:
        this.<>1__state = 0;
        label_4:
        int val_5 = this.<count>5__2;
        if(((val_5 - 3) < 30) || ((this.<>4__this.gameState.HasAnyOperation()) == true))
        {
            goto label_9;
        }
        
        Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.FallManager>(contextId:  7) = 1;
        Royal.Scenes.Game.Levels.LevelContext.SetTimeScale(timeScale:  1f);
        if((this.<>4__this.OnGameExit) != null)
        {
                this.<>4__this.OnGameExit.Invoke();
        }
        
        if((this.<loadingViewDisplayed>5__3) != false)
        {
                this.<>4__this.loadingManager.HideLoading(delay:  0.3f);
        }
        
        this.<>4__this = 1;
        val_6 = 2;
        goto label_16;
        label_1:
        val_6 = 0;
        goto label_15;
        label_9:
        val_5 = val_5 + 1;
        this.<count>5__2 = val_5;
        val_6 = true;
        if(val_5 == 3)
        {
                this.<loadingViewDisplayed>5__3 = val_6;
            val_7 = null;
            val_7 = null;
            val_9 = GameManager.<>c.<>9__34_0;
            if(val_9 == null)
        {
                System.Action val_4 = null;
            val_9 = val_4;
            val_4 = new System.Action(object:  GameManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameManager.<>c::<GameExitCoroutine>b__34_0());
            GameManager.<>c.<>9__34_0 = val_9;
        }
        
            this.<>4__this.loadingManager.ShowLoading(onComplete:  val_4, showSplash:  false, forceCreateNewSplash:  false);
            val_6 = 1;
        }
        
        label_16:
        val_5 = 1;
        this.<>2__current = 0;
        label_15:
        this.<>1__state = val_6;
        return (bool)val_5;
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
