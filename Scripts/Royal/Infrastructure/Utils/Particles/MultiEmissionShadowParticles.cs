using UnityEngine;

namespace Royal.Infrastructure.Utils.Particles
{
    public class MultiEmissionShadowParticles : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem system;
        public float alpha;
        public UnityEngine.Vector3 offset;
        private int shadowedParticles;
        private UnityEngine.ParticleSystem.Particle[] particles;
        
        // Methods
        private void Awake()
        {
            this.shadowedParticles = 0;
            MainModule val_1 = this.system.main;
            this.particles = new Particle[1391110248];
        }
        private void LateUpdate()
        {
            this.UpdateShadows();
        }
        private void OnDisable()
        {
            this.shadowedParticles = 0;
        }
        private void UpdateShadows()
        {
            UnityEngine.ParticleSystem val_16;
            int val_17;
            var val_18;
            float val_19;
            val_16 = this.system;
            int val_1 = val_16.GetParticles(particles:  this.particles);
            if(val_1 == 0)
            {
                goto label_2;
            }
            
            val_17 = this.shadowedParticles;
            val_18 = val_1 - val_17;
            if()
            {
                goto label_3;
            }
            
            this.shadowedParticles = val_1;
            goto label_4;
            label_2:
            this.shadowedParticles = 0;
            return;
            label_3:
            if(val_18 >= 1)
            {
                    var val_17 = 0;
                do
            {
                int val_2 = val_17 + val_17;
                val_2 = this.particles + (val_2 * 132);
                int val_3 = val_2 + 32;
                int val_4 = val_18 + val_17;
                val_4 = val_4 + val_17;
                val_4 = this.particles + (val_4 * 132);
                int val_5 = val_4 + 32;
                UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                int val_7 = val_17 + this.shadowedParticles;
                val_7 = this.particles + (val_7 * 132);
                val_7 = val_7 + 32;
                byte val_8 = val_6.r & 4294967295;
                Particle[] val_16 = this.particles;
                int val_15 = this.shadowedParticles;
                val_15 = val_17 + val_15;
                val_16 = val_16 + (val_15 * 132);
                int val_9 = val_16 + 32;
                val_19 = 0f;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
                val_17 = this.shadowedParticles;
                val_17 = val_17 + 1;
            }
            while(val_17 < val_18);
            
            }
            
            int val_11 = val_17 + (val_18 << 1);
            this.shadowedParticles = val_11;
            this.system.SetParticles(particles:  this.particles, size:  val_11);
            val_16 = this.shadowedParticles;
            label_4:
            if(val_16 < 1)
            {
                    return;
            }
            
            val_19 = 255f;
            var val_22 = 0;
            do
            {
                Particle[] val_18 = this.particles;
                if((val_18[32] == 16776960) && (val_18[32] == 255))
            {
                    float val_20 = this.alpha;
                val_18 = val_18[32] >> 24;
                float val_19 = (float)val_18;
                val_19 = val_19 / val_19;
                if(val_19 < 0)
            {
                    val_20 = val_20 / 10f;
                float val_12 = val_19 + val_20;
                UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                byte val_14 = val_13.r & 4294967295;
                var val_21 = this.particles[32];
                this.system.SetParticles(particles:  this.particles, size:  this.shadowedParticles);
            }
            
            }
            
                val_22 = val_22 + 1;
                val_18 = 32 + 132;
            }
            while(val_22 < this.shadowedParticles);
        
        }
        public MultiEmissionShadowParticles()
        {
        
        }
    
    }

}
