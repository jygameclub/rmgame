using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupInfoDialogEntered : KingsCupInfoDialog
    {
        // Fields
        private bool playClicked;
        
        // Methods
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            var val_3;
            if((this.playClicked != true) && (this.playClicked != true))
            {
                    val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                .isUserAction = true;
                .<Type>k__BackingField = 2;
                .<IsForClaim>k__BackingField = false;
                val_3.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.KingsCup.ShowKingsCupPopupAction());
            }
            
            this.OnClose(dialogClosed:  dialogClosed);
        }
        public void OnPlayClicked()
        {
            this.playClicked = true;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((((public static Royal.Scenes.Start.Context.Units.Flow.FlowManager Royal.Scenes.Start.Context.ApplicationContext::Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(Royal.Scenes.Start.Context.ApplicationContextId id)) == 0) && (val_1.HasAutoActionInTheFlow != true)) && (val_1.IsInnerFlowExecuting() != true))
            {
                    val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  true));
            }
        
        }
        public KingsCupInfoDialogEntered()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Dialog.UiDialog();
        }
    
    }

}
