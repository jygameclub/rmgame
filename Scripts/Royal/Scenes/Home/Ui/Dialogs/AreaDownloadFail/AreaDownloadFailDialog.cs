using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail
{
    public class AreaDownloadFailDialog : UiDialog
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private bool isAtAreaUnlock;
        private bool isAtAreaLoad;
        
        // Methods
        public void Init(bool isAtAreaUnlock = False, bool isAtAreaLoad = False)
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.isAtAreaUnlock = isAtAreaUnlock;
            this.isAtAreaLoad = isAtAreaLoad;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog::OnApplicationResume()));
        }
        private void OnApplicationResume()
        {
            .<>4__this = this;
            .areaId = Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name;
            if(this.isAtAreaLoad == false)
            {
                goto label_7;
            }
            
            label_20:
            .areaId = typeof(Royal.Player.Context.Data.Persistent.UserAreaData).__il2cppRuntimeField_14;
            label_19:
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene) == false)
            {
                    return;
            }
            
            .CS$<>8__locals1 = new AreaDownloadFailDialog.<>c__DisplayClass4_0();
            .assetBundleHelper = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21).ShowLoading(onComplete:  new System.Action(object:  new AreaDownloadFailDialog.<>c__DisplayClass4_1(), method:  System.Void AreaDownloadFailDialog.<>c__DisplayClass4_1::<OnApplicationResume>b__0()), showSplash:  true, forceCreateNewSplash:  false);
            return;
            label_7:
            if((this.isAtAreaUnlock == false) || (AreAllTasksCompleted() == false))
            {
                goto label_19;
            }
            
            int val_9 = (AreaDownloadFailDialog.<>c__DisplayClass4_0)[1152921519532629744].areaId;
            val_9 = val_9 + 1;
            goto label_20;
        }
        private void OnSuccess()
        {
            Royal.Scenes.Start.Context.Units.Loading.LoadingManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            if(val_1.IsActive != false)
            {
                    val_1.HideLoading(delay:  0f);
            }
            
            if((this.isAtAreaUnlock != false) && (AreAllTasksCompleted() != false))
            {
                    Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).UnlockNextArea();
            }
            else
            {
                    if(this.isAtAreaLoad != false)
            {
                    Royal.Scenes.Home.Context.Units.Area.Data.AreaDataParser.ParseAndSetFromLocalStorage();
            }
            
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).ForceLoadHomeSceneWhenPossible();
        }
        private static void OnFail()
        {
            Royal.Scenes.Start.Context.Units.Loading.LoadingManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            if(val_1.IsActive != false)
            {
                    val_1.HideLoading(delay:  0f);
            }
            
            .isAtAreaUnlock = false;
            .isAtAreaLoad = false;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailAction());
        }
        public void Continue()
        {
            Royal.Scenes.Home.Context.HomeContextController val_2;
            var val_3;
            var val_4;
            val_2 = this;
            if(this.isAtAreaUnlock != true)
            {
                    if(this.isAtAreaLoad == false)
            {
                    return;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField;
            if(val_2 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.ArrangeTasksButtonAnimation();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3).remove_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog::OnApplicationResume()));
            this.OnClose(dialogClosed:  dialogClosed);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            return this.GetConfig();
        }
        public AreaDownloadFailDialog()
        {
        
        }
    
    }

}
