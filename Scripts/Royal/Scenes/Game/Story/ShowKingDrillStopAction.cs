using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class ShowKingDrillStopAction : DialogAction
    {
        // Methods
        public override void Execute()
        {
            null = null;
            typeof(Royal.Scenes.Game.Ui.GameUi).__il2cppRuntimeField_28 + 112 + 136.AnimateStopButton(onButtonClicked:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Story.ShowKingDrillStopAction::ShowKing()));
        }
        private void ShowKing()
        {
            Royal.Scenes.Game.Story.StoryLevelCompletedDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Game.Story.StoryLevelCompletedDialog>(assetName:  "StoryLevelCompletedDialog", action:  this);
            goto typeof(Royal.Scenes.Game.Story.StoryLevelCompletedDialog).__il2cppRuntimeField_240;
        }
        public override void Complete()
        {
            this.Complete();
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public ShowKingDrillStopAction()
        {
        
        }
    
    }

}
