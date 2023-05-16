using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class UiMusicButton : UiSettingsMenuButton
    {
        // Fields
        public UnityEngine.GameObject muteLine;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Royal.Scenes.Start.Context.Units.Audio.AudioManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.audioManager = val_1;
            this.muteLine.SetActive(value:  (~val_1.IsMusicActive()) & 1);
        }
        public void ButtonClick()
        {
            this.OnMusicToggle(active:  (~this.audioManager.IsMusicActive()) & 1);
            this.muteLine.SetActive(value:  (~this.audioManager.IsMusicActive()) & 1);
        }
        private void OnMusicToggle(bool active)
        {
            if(this.audioManager != null)
            {
                    if(active != false)
            {
                    this.audioManager.UnmuteMusic();
                return;
            }
            
                this.audioManager.MuteMusic();
                return;
            }
            
            throw new NullReferenceException();
        }
        public UiMusicButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
