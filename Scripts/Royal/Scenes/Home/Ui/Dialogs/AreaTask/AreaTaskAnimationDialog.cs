using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaTask
{
    public class AreaTaskAnimationDialog : UiDialog
    {
        // Fields
        private Royal.Scenes.Home.Context.Units.Area.AreaManager areaManager;
        private int price;
        private int taskId;
        
        // Methods
        public void Init(int areaTaskId, int areaTaskPrice)
        {
            this.areaManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            this.price = areaTaskPrice;
            this.taskId = areaTaskId;
        }
        protected override void AfterShowAnimation()
        {
            null = null;
            PlayHomeUiHideAnimation();
            this.Invoke(methodName:  "ConfirmTask", time:  0.45f);
        }
        private void ConfirmTask()
        {
            var val_2;
            this.areaManager.Build(taskId:  this.taskId, price:  this.price, onComplete:  new System.Action(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.AreaTask.AreaTaskAnimationDialog).__il2cppRuntimeField_258));
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_40.UpdateStarText();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            float val_2;
            bool val_3;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.backgroundFadeAlpha = 0f;
            val_0.backgroundFadeOutDuration = val_2;
            val_0.shouldHideBackground = val_3;
            return val_0;
        }
        public AreaTaskAnimationDialog()
        {
        
        }
    
    }

}
