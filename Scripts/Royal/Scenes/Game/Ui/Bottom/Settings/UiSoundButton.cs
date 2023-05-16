using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Settings
{
    public class UiSoundButton : UiSettingsMenuButton
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
            this.muteLine.SetActive(value:  (~val_1.IsSfxActive()) & 1);
        }
        public void ButtonClick()
        {
            this.OnSfxToggle(active:  (~this.audioManager.IsSfxActive()) & 1);
            this.muteLine.SetActive(value:  (~this.audioManager.IsSfxActive()) & 1);
        }
        private void OnSfxToggle(bool active)
        {
            if(this.audioManager != null)
            {
                    if(active != false)
            {
                    this.audioManager.UnmuteSfx();
                return;
            }
            
                this.audioManager.MuteSfx();
                return;
            }
            
            throw new NullReferenceException();
        }
        public UiSoundButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
