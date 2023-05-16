using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class ShowAreaDialogAction : DialogAction
    {
        // Fields
        private readonly bool disableTouch;
        private readonly int areaId;
        private Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog dialog;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowAreaDialogAction(bool isUserAction, bool disableTouch = False, bool isAuto = False)
        {
            bool val_12;
            var val_13;
            val_12 = disableTouch;
            this.<Type>k__BackingField = ((isAuto & true) != 0) ? ((isUserAction != true) ? 2 : 0) : (0 + 1);
            this.disableTouch = val_12;
            this.areaId = Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_name;
            if(val_12 == false)
            {
                    return;
            }
            
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_4.disabler.DisableTouch();
            val_12 = ???;
            val_13 = ???;
        }
        public override void Execute()
        {
            Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog val_1 = Royal.Infrastructure.UiComponents.Dialog.UiDialog.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Area.AreaDialog>(asset:  mem[72087281321656344], action:  this);
            this.dialog = val_1;
            val_1.Init(areaId:  this.areaId);
            if(this.disableTouch == false)
            {
                    return;
            }
            
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_2.disabler.EnableTouch();
            this = ???;
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
    
    }

}
