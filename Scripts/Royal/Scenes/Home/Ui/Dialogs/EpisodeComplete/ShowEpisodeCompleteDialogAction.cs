using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete
{
    public class ShowEpisodeCompleteDialogAction : DialogAction
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public override void Execute()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiHideAnimation();
            Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.InstantiateFromResources<Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete.EpisodeCompletedDialog>(assetName:  "AreaCompletedDialog", action:  this);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            throw new NullReferenceException();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public override void Complete()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.PlayHomeUiAppearAnimation();
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((val_1.HasActionInFlow(actionType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    val_1.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  0.4f, disableUiTouch:  false, flowType:  1));
            }
            
            this.Complete();
        }
        public ShowEpisodeCompleteDialogAction()
        {
        
        }
    
    }

}
