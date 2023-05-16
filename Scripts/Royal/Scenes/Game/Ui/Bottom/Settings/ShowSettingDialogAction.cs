using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class ShowSettingDialogAction : DialogAction
    {
        // Fields
        private readonly Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog settingsDialog;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 1;
        }
        public ShowSettingDialogAction(Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog dialog)
        {
            this.settingsDialog = dialog;
        }
        public override void Execute()
        {
            this.settingsDialog = this;
            goto typeof(Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog).__il2cppRuntimeField_240;
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            if(this.settingsDialog != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
