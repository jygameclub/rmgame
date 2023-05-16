using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PreviousArea
{
    public class ShowPreviousAreaDialogAction : DialogAction
    {
        // Fields
        private readonly int areaId;
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Infrastructure.UiComponents.Dialog.UiDialog dialog;
        private Royal.Scenes.Home.Areas.Scripts.AreaView.OnReplayKilled onReplayKilled;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowPreviousAreaDialogAction(int areaId)
        {
            this.areaId = areaId;
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
        }
        public override void Execute()
        {
            .<>4__this = this;
            Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8);
            .assetBundleHelper = val_2;
            bool val_4 = val_2.TryLoadArea(areaNo:  this.areaId, onLoaded:  new System.Action<System.Boolean>(object:  new ShowPreviousAreaDialogAction.<>c__DisplayClass7_0(), method:  System.Void ShowPreviousAreaDialogAction.<>c__DisplayClass7_0::<Execute>b__0(bool onLoaded)));
        }
        private void LoadAreaViewAsync()
        {
            Royal.Scenes.Home.Context.Units.Area.AreaManager.InstantiateAreaView(areaId:  this.areaId, async:  true, onComplete:  new System.Action<Royal.Scenes.Home.Areas.Scripts.AreaView>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.PreviousArea.ShowPreviousAreaDialogAction::<LoadAreaViewAsync>b__8_0(Royal.Scenes.Home.Areas.Scripts.AreaView areaView)));
        }
        private void CreatePreviousAreaDialog(Royal.Scenes.Home.Areas.Scripts.AreaView areaView)
        {
            this.onReplayKilled = areaView.InitPreviousAreaReplaySequence(onReplayComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.PreviousArea.ShowPreviousAreaDialogAction::<CreatePreviousAreaDialog>b__9_0()));
            Royal.Scenes.Home.Ui.Dialogs.PreviousArea.PreviousAreaDialog val_3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.PreviousArea.PreviousAreaDialog>(assetName:  "PreviousAreaDialog", action:  this);
            val_3.Init(areaView:  areaView, onReplayKilled:  this.onReplayKilled);
            this.dialog = val_3;
            throw new NullReferenceException();
        }
        private void AreaBundleLoadSuccess()
        {
            this.LoadAreaViewAsync();
        }
        private void AreaBundleLoadFail()
        {
            Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.AreaDownloadFail.AreaDownloadFailDialog>(assetName:  "AreaDownloadFailDialog", action:  this);
            val_1.Init(isAtAreaUnlock:  false, isAtAreaLoad:  false);
            this.dialog = val_1;
            throw new NullReferenceException();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this.dialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void <LoadAreaViewAsync>b__8_0(Royal.Scenes.Home.Areas.Scripts.AreaView areaView)
        {
            .areaView = areaView;
            .<>4__this = this;
            (ShowPreviousAreaDialogAction.<>c__DisplayClass8_0)[1152921519315299328].areaView.LoadAreaTaskAssetsAsync(onAllCompleted:  new System.Action(object:  new ShowPreviousAreaDialogAction.<>c__DisplayClass8_0(), method:  System.Void ShowPreviousAreaDialogAction.<>c__DisplayClass8_0::<LoadAreaViewAsync>b__1()));
        }
        private void <CreatePreviousAreaDialog>b__9_0()
        {
            if(this.dialog == 0)
            {
                    return;
            }
            
            (Royal.Infrastructure.UiComponents.Dialog.UiDialog.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Dialogs.PreviousArea.PreviousAreaDialog.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 = 1;
        }
    
    }

}
