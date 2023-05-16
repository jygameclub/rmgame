using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class ShowPausedUnlimitedLifeTooltipAction : FlowAction
    {
        // Fields
        private readonly Royal.Infrastructure.UiComponents.Button.UiButton parentButton;
        private readonly int <Type>k__BackingField;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return (int)this.<Type>k__BackingField;
        }
        public ShowPausedUnlimitedLifeTooltipAction(Royal.Infrastructure.UiComponents.Button.UiButton parentButton, bool userAction)
        {
            this.parentButton = parentButton;
            this.<Type>k__BackingField = ((userAction & true) != 0) ? (2 + 1) : 2;
        }
        public override void Execute()
        {
            this.Complete();
            if(this.parentButton == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.parentButton.transform;
            UnityEngine.Vector3 val_3 = val_2.position;
            Royal.Infrastructure.UiComponents.Dialog.DialogManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            float val_6 = 0.66f;
            float val_7 = -0.66f;
            this = this.parentButton;
            val_6 = val_3.x + val_6;
            val_7 = val_3.y + val_7;
            val_4.toolTipManager.ToggleTooltip(parent:  val_2, touchable:  this, direction:  0, pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, bodyPosition:  0.122f, text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "PausedUnlimitedLives"));
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.Complete();
        }
    
    }

}
