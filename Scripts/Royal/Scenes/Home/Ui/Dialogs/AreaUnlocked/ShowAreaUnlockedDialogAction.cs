using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked
{
    public class ShowAreaUnlockedDialogAction : DialogAction
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Dialog.UiDialog dialog;
        private bool isButtonClicked;
        
        // Methods
        public ShowAreaUnlockedDialogAction(bool isButtonClicked = False)
        {
            this.isButtonClicked = isButtonClicked;
        }
        public override void Execute()
        {
            string val_11;
            var val_12;
            var val_13;
            if(this.isButtonClicked != false)
            {
                    if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).IsNewLevelPublished) != false)
            {
                    Royal.Scenes.Home.Ui.Dialogs.CompletedAllLevels.CompletedAllLevelsDialog val_3 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.CompletedAllLevels.CompletedAllLevelsDialog>(assetName:  "CompletedAllLevelsDialog", action:  this);
                this.dialog = val_3;
                val_3.Init(isNewLevelsPublished:  true);
            }
            else
            {
                    if((Royal.Player.Context.Units.LevelManager.IsAllLevelsCompleted() != false) && (((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).IsThereActiveLeague()) != false) && ((val_4.<IsActiveLeagueUpdatedOnline>k__BackingField) != false)))
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.ShowEnterLeaguePopupAction());
            }
            else
            {
                    val_11 = "AreaComingSoonDialog";
                val_12 = 1152921519530448656;
                this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.AreaComingSoon.AreaComingSoonDialog>(assetName:  val_11, action:  this);
            }
            
            }
            
            }
            
            if(this.dialog != 0)
            {
                
            }
            else
            {
                    val_13 = public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete();
            }
            
            this.Complete();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this.dialog == 0)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Infrastructure.UiComponents.Dialog.UiDialog).__il2cppRuntimeField_250;
        }
    
    }

}
