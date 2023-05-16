using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.AreaTask
{
    public class ShowAreaTaskAnimationDialogAction : DialogAction
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private readonly Royal.Scenes.Home.Ui.Dialogs.AreaTask.AreaTaskAnimationDialog dialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public ShowAreaTaskAnimationDialogAction(int areaTaskId, int areaTaskPrice)
        {
            Royal.Scenes.Home.Ui.Dialogs.AreaTask.AreaTaskAnimationDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Home.Ui.Dialogs.AreaTask.AreaTaskAnimationDialog>(asset:  mem[72087281321656360], action:  this);
            this.dialog = val_1;
            val_1.Init(areaTaskId:  areaTaskId, areaTaskPrice:  areaTaskPrice);
        }
        public override void Execute()
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            throw new NullReferenceException();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        public override void Complete()
        {
            this.Complete();
        }
    
    }

}
