using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public sealed class ShowPrelevelDialogAction : DialogAction
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Dialog.UiDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 2;
        }
        public ShowPrelevelDialogAction(bool clearBoosterSelectionData)
        {
            if(clearBoosterSelectionData == false)
            {
                    return;
            }
            
            Reset();
        }
        public override void Execute()
        {
            Royal.Scenes.Start.Context.Units.Flow.DialogAction val_9;
            var val_10;
            string val_11;
            var val_12;
            val_9 = this;
            if(this.IsThereAnyLevelToPlay() == false)
            {
                    return;
            }
            
            if(IsStory != false)
            {
                    val_11 = "StoryPrelevelDialog";
                val_12 = 1152921519326243104;
            }
            else
            {
                    val_11 = "BonusPrelevelDialog";
                val_12 = 1152921519326244240;
            }
            
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog>(assetName:  null, action:  this);
            val_10 = ???;
            val_9 = ???;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog).__il2cppRuntimeField_240;
        }
        private bool IsThereAnyLevelToPlay()
        {
            Royal.Scenes.Start.Context.Units.Flow.DialogAction val_19;
            var val_20;
            var val_21;
            val_19 = this;
            if(Royal.Player.Context.Units.LevelManager.IsAllLevelsCompleted() == false)
            {
                goto label_8;
            }
            
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsInLeague()) == false)
            {
                goto label_4;
            }
            
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).IsRemainingTimeFinished) == false)
            {
                goto label_8;
            }
            
            this.Complete();
            val_19 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            label_37:
            val_19.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.League.ShowLeagueInfoPopupAction(isUserAction:  true));
            goto label_12;
            label_8:
            val_20 = 1;
            return (bool)val_20;
            label_4:
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).IsNewLevelPublished) == false)
            {
                goto label_17;
            }
            
            this.dialog = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.CompletedAllLevels.CompletedAllLevelsDialog>(assetName:  "CompletedAllLevelsDialog", action:  this);
            val_21 = 1;
            goto label_21;
            label_17:
            if(((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LeagueManager>(id:  5).IsThereActiveLeague()) == false) || ((val_10.<IsActiveLeagueUpdatedOnline>k__BackingField) == false))
            {
                goto label_26;
            }
            
            if(((IsLastArea() == false) || (AreAllTasksCompleted() == false)) || (ChestClaimed() == false))
            {
                goto label_34;
            }
            
            this.Complete();
            Royal.Scenes.Home.Ui.Dialogs.League.ShowEnterLeaguePopupAction val_16 = new Royal.Scenes.Home.Ui.Dialogs.League.ShowEnterLeaguePopupAction();
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12)) != null)
            {
                goto label_37;
            }
            
            label_26:
            Royal.Scenes.Home.Ui.Dialogs.CompletedAllLevels.CompletedAllLevelsDialog val_17 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.CompletedAllLevels.CompletedAllLevelsDialog>(assetName:  "CompletedAllLevelsDialog", action:  this);
            this.dialog = val_17;
            val_21 = 0;
            label_21:
            val_17.Init(isNewLevelsPublished:  false);
            label_43:
            label_12:
            val_20 = 0;
            return (bool)val_20;
            label_34:
            Royal.Scenes.Home.Ui.Dialogs.League.CompleteAllAreasDialog val_18 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.League.CompleteAllAreasDialog>(assetName:  "CompleteAllAreasDialog", action:  this);
            this.dialog = val_18;
            if(val_18 != null)
            {
                goto label_43;
            }
            
            throw new NullReferenceException();
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
