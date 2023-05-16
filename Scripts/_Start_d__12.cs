using UnityEngine;
private sealed class HomeUi.<Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.HomeUi <>4__this;
    private bool <startedWithLoadingView>5__2;
    private Royal.Scenes.Start.Context.Units.Loading.LoadingManager <loadingManager>5__3;
    private int <waitFrameCount>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HomeUi.<Start>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_30;
        int val_31;
        bool val_32;
        val_30 = this;
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
        if(IsWin == false)
        {
            goto label_8;
        }
        
        if((this.<>4__this.previousScene) != 2)
        {
            goto label_14;
        }
        
        Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).PauseMainFlow();
        goto label_14;
        label_2:
        this.<>1__state = 0;
        label_48:
        if((this.<loadingManager>5__3.IsClear) == false)
        {
            goto label_16;
        }
        
        this.<waitFrameCount>5__4 = 1;
        if((this.<startedWithLoadingView>5__2) == false)
        {
            goto label_17;
        }
        
        val_31 = 6;
        goto label_18;
        label_1:
        this.<>1__state = 0;
        label_50:
        val_31 = mem[this.<waitFrameCount>5__4];
        val_31 = this.<waitFrameCount>5__4;
        goto label_19;
        label_16:
        val_32 = true;
        this.<>2__current = 0;
        this.<startedWithLoadingView>5__2 = val_32;
        this.<>1__state = val_32;
        return (bool)val_32;
        label_8:
        label_14:
        this.<>4__this.iconsView.ManualStart(homeSection:  this.<>4__this.homeSection);
        this.<>4__this.iconsView.DisableTouch();
        UnityEngine.Vector3 val_4 = this.<>4__this.userInfoPanel.GetTargetPosition();
        this.<>4__this = val_4.x;
        this.<>4__this = val_4.y;
        this.<>4__this = val_4.z;
        UnityEngine.Vector3 val_5 = this.<>4__this.sectionBar.GetTargetPosition();
        this.<>4__this = val_5.x;
        this.<>4__this = val_5.y;
        this.<>4__this = val_5.z;
        UnityEngine.Vector3 val_6 = this.<>4__this.homeSection.GetActionButtonsPosition();
        this.<>4__this = val_6.x;
        this.<>4__this = val_6.y;
        this.<>4__this = val_6.z;
        UnityEngine.Vector3 val_8 = this.<>4__this.userInfoPanel.transform.position;
        this.<>4__this.iconsView.PreparePosition(userInfoPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, willAnimateIn:  false);
        if((this.<>4__this.previousScene) != 2)
        {
            goto label_53;
        }
        
        UnityEngine.Vector3 val_10 = this.<>4__this.userInfoPanel.transform.position;
        this.<>4__this.iconsView.PreparePosition(userInfoPosition:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, willAnimateIn:  true);
        UnityEngine.Transform val_11 = this.<>4__this.userInfoPanel.transform;
        UnityEngine.Vector3 val_12 = val_11.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  7f);
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        val_11.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        UnityEngine.Transform val_16 = this.<>4__this.sectionBar.transform;
        UnityEngine.Vector3 val_17 = val_16.position;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  7f);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        val_16.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Transform val_21 = this.<>4__this.actionButtons.transform;
        UnityEngine.Vector3 val_22 = val_21.position;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  7f);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        val_21.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        this.<startedWithLoadingView>5__2 = false;
        Royal.Scenes.Start.Context.Units.Loading.LoadingManager val_26 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
        this.<loadingManager>5__3 = val_26;
        if(val_26 != null)
        {
            goto label_48;
        }
        
        label_17:
        if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsAndroid == false)
        {
            goto label_50;
        }
        
        val_31 = 6;
        label_18:
        this.<waitFrameCount>5__4 = val_31;
        label_19:
        if(val_31 > 0)
        {
                val_31 = val_31 - 1;
            this.<>2__current = 0;
            this.<waitFrameCount>5__4 = val_31;
            this.<>1__state = 2;
            val_32 = 1;
            return (bool)val_32;
        }
        
        this.<loadingManager>5__3 = 0;
        label_53:
        if((this.<>4__this.previousScene) == 2)
        {
                bool val_28 = IsWin;
        }
        
        Royal.Scenes.Home.Ui.HomeUi.EnableTouchStatic();
        Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.HomeSceneFlow>(id:  2).StartFlow(previousScene:  this.<>4__this.previousScene);
        label_3:
        val_32 = 0;
        return (bool)val_32;
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
