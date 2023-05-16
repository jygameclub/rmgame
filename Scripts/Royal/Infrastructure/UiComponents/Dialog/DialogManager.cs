using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Dialog
{
    public class DialogManager : IContextUnit
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private readonly Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Infrastructure.UiComponents.Dialog.DialogBackground background;
        private Royal.Infrastructure.UiComponents.Dialog.UiDialog dialog;
        private Royal.Scenes.Game.Ui.Dialogs.ToolTipManager toolTipManager;
        public Royal.Scenes.Home.Ui.Dialogs.HomeDialogAssets homeDialogAssets;
        public Royal.Scenes.Game.Ui.Dialogs.GameDialogAssets gameDialogAssets;
        public readonly Royal.Infrastructure.UiComponents.Dialog.CommonDialogAssets commonDialogAssets;
        private Royal.Infrastructure.UiComponents.Dialog.DialogManagerType managerType;
        private bool hasActiveDialog;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 13;
        }
        public DialogManager()
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.commonDialogAssets = UnityEngine.Resources.Load<Royal.Infrastructure.UiComponents.Dialog.CommonDialogAssets>(path:  "CommonDialogAssets");
        }
        private void SetGame()
        {
            this.homeDialogAssets = 0;
            this.managerType = 1;
            this.gameDialogAssets = UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Dialogs.GameDialogAssets>(path:  "GameDialogAssets");
            Royal.Infrastructure.UiComponents.Dialog.DialogBackground val_2 = UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Dialog.DialogBackground>(original:  this.commonDialogAssets.dialogBackground);
            this.background = val_2;
            val_2.Init(manager:  this);
            this.dialog = 0;
            this.hasActiveDialog = false;
        }
        private void SetHome()
        {
            this.managerType = 0;
            this.gameDialogAssets = 0;
            this.homeDialogAssets = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.HomeDialogAssets>(path:  "HomeDialogAssets");
            Royal.Infrastructure.UiComponents.Dialog.DialogBackground val_2 = UnityEngine.Object.Instantiate<Royal.Infrastructure.UiComponents.Dialog.DialogBackground>(original:  this.commonDialogAssets.dialogBackground);
            this.background = val_2;
            val_2.Init(manager:  this);
            this.dialog = 0;
            this.hasActiveDialog = false;
        }
        public bool IsGame()
        {
            return (bool)(this.managerType == 1) ? 1 : 0;
        }
        private bool IsHome()
        {
            return (bool)(this.managerType == 0) ? 1 : 0;
        }
        public void ShowDialog(Royal.Infrastructure.UiComponents.Dialog.UiDialog uiDialog)
        {
            object[] val_1 = new object[1];
            val_1[0] = uiDialog.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Show: {0}", values:  val_1);
            this.toolTipManager.CloseTooltip();
            this.hasActiveDialog = true;
            this.dialog = uiDialog;
            UnityEngine.Transform val_3 = this.cameraManager.camera.transform;
            if(this.background != 0)
            {
                    this.background.transform.SetParent(p:  val_3);
                this.background.Show();
            }
            
            this.dialog.transform.SetParent(p:  val_3);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogSorting();
            this.dialog.SetSorting(getDialogSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            UnityEngine.Vector2 val_9 = this.cameraManager.GetCenterPosition();
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            goto typeof(Royal.Infrastructure.UiComponents.Dialog.UiDialog).__il2cppRuntimeField_260;
        }
        public void CloseDialog(Royal.Infrastructure.UiComponents.Dialog.UiDialog uiDialog, bool fast = False)
        {
            var val_15;
            object val_16;
            int val_17;
            val_15 = fast;
            val_16 = this;
            if(this.hasActiveDialog == false)
            {
                    return;
            }
            
            if((uiDialog != 0) && (this.dialog != uiDialog))
            {
                    object[] val_3 = new object[2];
                val_17 = val_3.Length;
                val_3[0] = uiDialog;
                if(this.dialog != null)
            {
                    val_17 = val_3.Length;
            }
            
                val_3[1] = this.dialog;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  4, log:  "Try to close dialog ({0}) different from active one ({1})", values:  val_3);
                return;
            }
            
            if(val_15 != false)
            {
                    val_16 = ???;
                val_15 = ???;
            }
            else
            {
                    object[] val_11 = new object[1];
                val_11[0] = this.dialog.GetType();
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Close: {0}", values:  val_11);
                if(this.background != 0)
            {
                    this.background.Hide();
            }
            
                System.Action val_14 = new System.Action(object:  this, method:  System.Void Royal.Infrastructure.UiComponents.Dialog.DialogManager::ClearDialog());
            }
        
        }
        private void ClearDialog()
        {
            this.dialog = 0;
            this.hasActiveDialog = false;
        }
        private void ShowQuitDialog()
        {
            var val_5;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_6;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_7;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_8;
            val_5 = this;
            if(this.managerType == 0)
            {
                goto label_1;
            }
            
            if(this.managerType != 1)
            {
                    return;
            }
            
            if((Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14).IsPlaying()) == false)
            {
                    return;
            }
            
            val_6 = this.flowManager;
            Royal.Scenes.Game.Ui.Dialogs.LevelQuit.ShowLevelQuitDialogAction val_3 = null;
            val_7 = val_3;
            val_3 = new Royal.Scenes.Game.Ui.Dialogs.LevelQuit.ShowLevelQuitDialogAction();
            if(val_6 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_1:
            val_8 = this.flowManager;
            Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit.ShowApplicationQuitDialogAction val_4 = null;
            val_7 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit.ShowApplicationQuitDialogAction();
            label_5:
            val_8.Push(action:  val_4);
        }
        public void Bind()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.UiComponents.Dialog.DialogManager::SetGame()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.UiComponents.Dialog.DialogManager::SetHome()));
            this.toolTipManager = new Royal.Scenes.Game.Ui.Dialogs.ToolTipManager();
        }
        public bool HasActiveDialog()
        {
            return (bool)this.hasActiveDialog;
        }
        public Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetActiveDialogConfig()
        {
            object val_7;
            var val_8;
            var val_9;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            val_7 = this;
            val_8 = val_0;
            if(this.hasActiveDialog != false)
            {
                    val_7 = ???;
                val_8 = ???;
            }
            else
            {
                    val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_7, logTag:  4, log:  "No active dialog config found in GetActiveDialogConfig", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                val_8 = 0;
                val_8 = 0;
                val_8 = 0;
                val_8 = 0;
                return val_0;
            }
        
        }
        public Royal.Scenes.Game.Ui.Dialogs.ToolTipManager GetToolTipManager()
        {
            return (Royal.Scenes.Game.Ui.Dialogs.ToolTipManager)this.toolTipManager;
        }
        public void PressBack()
        {
            if(this.hasActiveDialog == false)
            {
                goto label_0;
            }
            
            if(this.dialog == null)
            {
                goto label_1;
            }
            
            goto typeof(Royal.Infrastructure.UiComponents.Dialog.UiDialog).__il2cppRuntimeField_2B0;
            label_0:
            this.dialog.ShowQuitDialog();
            return;
            label_1:
            throw new NullReferenceException();
        }
    
    }

}
