using UnityEngine;

namespace Royal.Infrastructure.Utils.Particles
{
    public class AutoShadowParticles : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem system;
        public float alpha;
        public UnityEngine.Vector3 offset;
        private bool shouldUpdate;
        private int updateShadowCount;
        private UnityEngine.ParticleSystem.Particle[] particles;
        
        // Methods
        private void Awake()
        {
            if(this.alpha <= 0f)
            {
                    return;
            }
            
            this.shouldUpdate = true;
            EmissionModule val_1 = this.system.emission;
            int val_7 = (UnityEngine.Mathf.Max(a:  -26864, b:  -26864)) << 2;
            this.particles = new Particle[0];
        }
        private void LateUpdate()
        {
            if(this.shouldUpdate == false)
            {
                    return;
            }
            
            if(this.updateShadowCount != 0)
            {
                    this.UpdateShadows();
                return;
            }
            
            this.AddShadows();
        }
        private void OnDisable()
        {
            if(this.alpha > 0f)
            {
                    this.shouldUpdate = true;
            }
            
            this.updateShadowCount = 0;
        }
        private void AddShadows()
        {
            Particle[] val_10;
            int val_1 = this.system.GetParticles(particles:  this.particles);
            if(val_1 == 0)
            {
                    return;
            }
            
            val_10 = this.particles;
            var val_2 = (this.particles.Length < 0) ? (this.particles.Length + 1) : this.particles.Length;
            val_2 = (val_1 > (val_2 >> 1)) ? (val_2 >> 1) : (val_1);
            if(val_2 < 1)
            {
                goto label_13;
            }
            
            var val_13 = 0;
            var val_14 = 32;
            label_14:
            val_2 = (long)val_2 + val_13;
            Particle[] val_5 = (val_10[val_2 + 32][val_14]) - 32;
            UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            byte val_7 = val_6.r & 4294967295;
            var val_10 = this.particles[val_14];
            var val_11 = this.particles[val_14];
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
            var val_12 = this.particles[val_14];
            val_13 = val_13 + 1;
            if(val_13 >= (long)val_2)
            {
                goto label_13;
            }
            
            val_14 = val_14 + 132;
            if(this.particles != null)
            {
                goto label_14;
            }
            
            label_13:
            this.system.SetParticles(particles:  this.particles, size:  val_1 << 1);
            int val_15 = this.updateShadowCount;
            val_15 = val_15 + 1;
            this.updateShadowCount = val_15;
        }
        private void UpdateShadows()
        {
            int val_1 = this.system.GetParticles(particles:  this.particles);
            if(val_1 >= 2)
            {
                    var val_7 = 0;
                var val_8 = 32;
                do
            {
                float val_3 = this.alpha * (float)this.updateShadowCount;
                UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
                byte val_5 = val_4.r & 4294967295;
                var val_6 = this.particles[val_8];
                val_7 = val_7 + 1;
                val_8 = val_8 + 132;
            }
            while(val_7 < (val_1 >> 1));
            
            }
            
            this.system.SetParticles(particles:  this.particles, size:  val_1);
            int val_9 = this.updateShadowCount;
            val_9 = val_9 + 1;
            this.updateShadowCount = val_9;
            if(val_9 < 11)
            {
                    return;
            }
            
            this.shouldUpdate = false;
        }
        public AutoShadowParticles()
        {
        
        }
    
    }

}
