using UnityEngine;

namespace Royal.Infrastructure.Utils.Particles
{
    public class AutoDisableParticles : MonoBehaviour
    {
        // Fields
        private UnityEngine.ParticleSystem[] particles;
        private bool shouldDestroy;
        
        // Methods
        private void Awake()
        {
            this.InitParticles();
        }
        public void InitParticles()
        {
            this.particles = this.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true);
        }
        public void Play(bool shouldDestroy = False)
        {
            UnityEngine.ParticleSystem[] val_5;
            this.shouldDestroy = shouldDestroy;
            this.gameObject.SetActive(value:  true);
            val_5 = this.particles;
            if(val_5 != null)
            {
                    if(this.particles.Length != 0)
            {
                goto label_2;
            }
            
            }
            
            this.InitParticles();
            val_5 = this.particles;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            label_2:
            var val_6 = 0;
            label_7:
            if(val_6 >= this.particles.Length)
            {
                goto label_4;
            }
            
            val_5[val_6].Play();
            val_6 = val_6 + 1;
            if(this.particles != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_4:
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.AutoDisableRoutine());
            return;
            label_3:
            this.OnComplete();
        }
        private System.Collections.IEnumerator AutoDisableRoutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new AutoDisableParticles.<AutoDisableRoutine>d__5();
        }
        private void OnComplete()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.shouldDestroy != false)
            {
                    UnityEngine.Object.Destroy(obj:  val_1);
                return;
            }
            
            val_1.SetActive(value:  false);
        }
        public float GetMinParticleDelay()
        {
            var val_3;
            var val_13;
            float val_14;
            val_13 = 0;
            val_14 = 10f;
            do
            {
                if(val_13 >= this.particles.Length)
            {
                    return (float)val_14;
            }
            
                UnityEngine.ParticleSystem val_12 = this.particles[val_13];
                MainModule val_1 = val_12.main;
                if((val_3.yAdvance < 0) && ((val_12.GetComponent<UnityEngine.Renderer>().enabled) != false))
            {
                    EmissionModule val_7 = val_12.emission;
                if((1387809880 & 1) != 0)
            {
                    MainModule val_8 = val_12.main;
                if(val_3.yAdvance > 0f)
            {
                    MainModule val_10 = val_12.main;
                val_14 = val_3.yAdvance;
            }
            
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public float GetMaxParticleLifetime()
        {
            var val_2;
            var val_13;
            float val_14;
            val_13 = 0;
            val_14 = 0f;
            do
            {
                if(val_13 >= this.particles.Length)
            {
                    return (float)(((val_6 > 0f) ? 1 : 0) != 1388085696) ? (val_6) : (val_14);
            }
            
                UnityEngine.ParticleSystem val_12 = this.particles[val_13];
                MainModule val_1 = val_12.main;
                float val_6 = UnityEngine.Mathf.Max(a:  val_2.xAdvance, b:  val_2.yAdvance);
                if(val_6 > val_14)
            {
                    if((val_12.GetComponent<UnityEngine.Renderer>().enabled) != false)
            {
                    EmissionModule val_9 = val_12.emission;
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public void SetMinParticleDelay()
        {
            var val_6 = 0;
            do
            {
                if(val_6 >= this.particles.Length)
            {
                    return;
            }
            
                MainModule val_1 = this.particles[val_6].main;
                MinMaxCurve val_2 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  0f);
                val_6 = val_6 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public AutoDisableParticles()
        {
        
        }
    
    }

}
