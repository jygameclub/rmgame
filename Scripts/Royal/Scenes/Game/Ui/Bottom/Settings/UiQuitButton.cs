using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class UiQuitButton : UiSettingsMenuButton
    {
        // Fields
        public Royal.Scenes.Game.Ui.Bottom.Settings.SettingsDialog settingsDialog;
        
        // Methods
        public void ButtonClick()
        {
            if(this.settingsDialog != null)
            {
                    this.settingsDialog.TriggerQuit();
                return;
            }
            
            throw new NullReferenceException();
        }
        public UiQuitButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
