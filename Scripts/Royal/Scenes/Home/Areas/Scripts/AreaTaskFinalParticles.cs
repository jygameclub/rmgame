using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaTaskFinalParticles : AutoDisableParticles
    {
        // Fields
        public float particleStartTime;
        public float uiAppearTime;
        
        // Methods
        public void PlayAndDestroy()
        {
            this.Invoke(methodName:  "PlayLate", time:  this.particleStartTime);
        }
        public void PlayLate()
        {
            this.Play(shouldDestroy:  true);
        }
        public void ArrangeParticleTimes()
        {
            this.InitParticles();
            float val_1 = this.GetMinParticleDelay();
            this.particleStartTime = val_1;
            float val_2 = this.GetMaxParticleLifetime();
            val_2 = val_1 + val_2;
            val_2 = val_2 + (-0.1f);
            this.uiAppearTime = val_2;
            this.SetMinParticleDelay();
        }
        public AreaTaskFinalParticles()
        {
        
        }
    
    }

}
