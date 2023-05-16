using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EpisodeComplete
{
    public class FireworksParticlesSoundSystem : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem startingFireWorksSystem;
        private int activeParticleCountAtRepeatingSystem;
        private bool isStartingSoundsPlayed;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        private void Awake()
        {
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        private void Update()
        {
            if(this.isStartingSoundsPlayed == true)
            {
                    return;
            }
            
            if(this.startingFireWorksSystem.isEmitting == false)
            {
                    return;
            }
            
            this.isStartingSoundsPlayed = true;
            this.audioManager.PlaySound(type:  121, offset:  0.04f);
            this.Invoke(methodName:  "PlayFlySound", time:  0.05f);
            this.Invoke(methodName:  "PlayFlySound", time:  0.15f);
            this.Invoke(methodName:  "PlayExplodeSound", time:  0.5f);
            this.Invoke(methodName:  "PlayExplodeSound", time:  0.6f);
            this.Invoke(methodName:  "PlayExplodeSound", time:  0.7f);
        }
        private void PlayExplodeSound()
        {
            int val_1 = this.randomManager.Next(min:  0, max:  3);
            this.audioManager.PlaySound(type:  (val_1 == 3) ? 120 : ((val_1 == 2) ? (118 + 1) : 118), offset:  0.04f);
        }
        private void PlayFlySound()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  121, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public FireworksParticlesSoundSystem()
        {
        
        }
    
    }

}
