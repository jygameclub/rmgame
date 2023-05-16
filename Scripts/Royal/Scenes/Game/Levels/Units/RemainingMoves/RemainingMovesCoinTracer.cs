using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.RemainingMoves
{
    public class RemainingMovesCoinTracer : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem[] particles;
        public float[] initialRateOverDistances;
        private int maxRateOverDistance;
        private int minRateOverDistance;
        
        // Methods
        private void Awake()
        {
            var val_3;
            this.initialRateOverDistances = new float[0];
            var val_7 = 0;
            do
            {
                if(val_7 >= this.particles.Length)
            {
                    return;
            }
            
                EmissionModule val_2 = this.particles[val_7].emission;
                this.initialRateOverDistances[val_7] = val_3.yAdvance;
                val_7 = val_7 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public void ArrangeRateOverDistanceByRatio(float ratio)
        {
            var val_8 = 0;
            do
            {
                if(val_8 >= this.particles.Length)
            {
                    return;
            }
            
                EmissionModule val_1 = this.particles[val_8].emission;
                float val_2 = UnityEngine.Mathf.Lerp(a:  (float)this.minRateOverDistance, b:  (float)this.maxRateOverDistance, t:  ratio);
                val_2 = this.initialRateOverDistances[val_8] * val_2;
                MinMaxCurve val_3 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  val_2);
                val_8 = val_8 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public void Play()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            var val_7 = 4;
            do
            {
                if((val_7 - 4) >= this.particles.Length)
            {
                    return;
            }
            
                EmissionModule val_4 = this.particles[0].emission;
                this.particles[0].Play();
                val_7 = val_7 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public void Recycle()
        {
            this.transform.SetParent(p:  0);
            var val_6 = 4;
            label_9:
            if((val_6 - 4) >= this.particles.Length)
            {
                goto label_3;
            }
            
            EmissionModule val_3 = this.particles[0].emission;
            this.particles[0].Stop();
            val_6 = val_6 + 1;
            if(this.particles != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_3:
            this.Invoke(methodName:  "DestroySelf", time:  1f);
        }
        private void DestroySelf()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public RemainingMovesCoinTracer()
        {
            this.maxRateOverDistance = 3;
            this.minRateOverDistance = 1;
        }
    
    }

}
