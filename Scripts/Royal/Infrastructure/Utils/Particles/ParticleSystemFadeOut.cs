using UnityEngine;

namespace Royal.Infrastructure.Utils.Particles
{
    public class ParticleSystemFadeOut : MonoBehaviour
    {
        // Fields
        private UnityEngine.ParticleSystem.Particle[] particles;
        private UnityEngine.ParticleSystem pSystem;
        private bool startFading;
        private float fadeInSeconds;
        private float elapsedSeconds;
        
        // Methods
        private void Update()
        {
            if(this.startFading == false)
            {
                    return;
            }
            
            float val_4 = this.elapsedSeconds;
            val_4 = val_4 + UnityEngine.Time.deltaTime;
            this.elapsedSeconds = val_4;
            float val_3 = UnityEngine.Mathf.Min(a:  1f, b:  val_4 / this.fadeInSeconds);
            val_3 = 1f - val_3;
            this.FadeColorByRatio(ratio:  val_3);
        }
        private void FadeColorByRatio(float ratio)
        {
            int val_1 = this.pSystem.GetParticles(particles:  this.particles);
            if(val_1 >= 1)
            {
                    var val_7 = 0;
                var val_8 = 32;
                ratio = ratio * 255f;
                var val_2 = (ratio < 0) ? ((int)ratio) : ((int)ratio);
                val_2 = val_2 & 255;
                do
            {
                float val_6 = (float)(ulong)(this.particles[val_8] >> 24) & 255;
                val_6 = val_6 / 255f;
                if(val_6 > ratio)
            {
                    Particle[] val_5 = (this.particles[val_8] & 16777215) | (val_2 << 24);
            }
            
                val_7 = val_7 + 1;
                val_8 = val_8 + 132;
            }
            while(val_7 < (long)val_1);
            
            }
            
            this.pSystem.SetParticles(particles:  this.particles, size:  val_1);
        }
        public void FadeOut(float seconds)
        {
            UnityEngine.ParticleSystem val_1 = this.GetComponent<UnityEngine.ParticleSystem>();
            this.pSystem = val_1;
            int val_2 = val_1.particleCount;
            this.particles = new Particle[0];
            SubEmittersModule val_4 = this.pSystem.subEmitters;
            EmissionModule val_5 = this.pSystem.emission;
            this.fadeInSeconds = seconds;
            this.startFading = true;
            this.elapsedSeconds = 0f;
        }
        public ParticleSystemFadeOut()
        {
        
        }
    
    }

}
