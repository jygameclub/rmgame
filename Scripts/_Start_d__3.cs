using UnityEngine;
private sealed class GameUi.<Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.GameUi <>4__this;
    private bool <startedWithLoadingView>5__2;
    private Royal.Scenes.Start.Context.Units.Loading.LoadingManager <loadingManager>5__3;
    private int <waitFrameCount>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameUi.<Start>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Start.Context.Units.Loading.LoadingManager val_5;
        int val_6;
        bool val_7;
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
        if(Royal.Player.Context.Units.LevelManager.IsStoryLevel != false)
        {
                this.<>4__this.CreateKingDrill();
        }
        
        this.<startedWithLoadingView>5__2 = false;
        Royal.Scenes.Start.Context.Units.Loading.LoadingManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
        this.<loadingManager>5__3 = val_2;
        if(val_2 != null)
        {
            goto label_8;
        }
        
        label_2:
        val_5 = this.<loadingManager>5__3;
        this.<>1__state = 0;
        label_8:
        if(val_5.IsClear == false)
        {
            goto label_11;
        }
        
        this.<waitFrameCount>5__4 = 1;
        if((this.<startedWithLoadingView>5__2) == false)
        {
            goto label_12;
        }
        
        val_6 = 6;
        goto label_13;
        label_1:
        this.<>1__state = 0;
        label_16:
        val_6 = mem[this.<waitFrameCount>5__4];
        val_6 = this.<waitFrameCount>5__4;
        goto label_14;
        label_11:
        val_7 = true;
        this.<>2__current = 0;
        this.<startedWithLoadingView>5__2 = val_7;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_12:
        if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid == false)
        {
            goto label_16;
        }
        
        val_6 = 6;
        label_13:
        this.<waitFrameCount>5__4 = val_6;
        label_14:
        if(val_6 > 0)
        {
                val_6 = val_6 - 1;
            this.<>2__current = 0;
            this.<waitFrameCount>5__4 = val_6;
            this.<>1__state = 2;
            val_7 = 1;
            return (bool)val_7;
        }
        
        this.<>4__this.StartLevelWithAnimation(initialAnimation:  true);
        label_3:
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
