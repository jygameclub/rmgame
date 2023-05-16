using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieTracerParticles : ItemParticles
    {
        // Fields
        private const float StartDelay = 0.12;
        public UnityEngine.ParticleSystem[] particles;
        private Spine.Unity.BoneFollower boneFollower;
        private UnityEngine.Vector3 boneSetPosition;
        private bool didPlayParticles;
        private float delayElapsed;
        
        // Methods
        public void SetBone(Spine.Unity.SkeletonMecanim skeletonMecanim)
        {
            Spine.Unity.BoneFollower val_2 = this.gameObject.AddComponent<Spine.Unity.BoneFollower>();
            this.boneFollower = val_2;
            val_2 = skeletonMecanim;
            bool val_3 = this.boneFollower.SetBone(name:  "boneybone");
            this.boneFollower.LateUpdate();
            UnityEngine.Vector3 val_5 = this.transform.position;
            this.boneSetPosition = val_5;
            mem[1152921523777747836] = val_5.y;
            mem[1152921523777747840] = val_5.z;
            this.didPlayParticles = false;
        }
        private void Update()
        {
            UnityEngine.Vector3 val_5;
            if(this.didPlayParticles == true)
            {
                    return;
            }
            
            val_5 = this.boneSetPosition;
            UnityEngine.Vector3 val_2 = this.transform.position;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(v1:  new UnityEngine.Vector3() {x = val_5, y = V9.16B, z = V10.16B}, v2:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == true)
            {
                    return;
            }
            
            val_5 = this.delayElapsed;
            if(val_5 < 0)
            {
                    float val_4 = UnityEngine.Time.deltaTime;
                val_4 = val_5 + val_4;
                this.delayElapsed = val_4;
                return;
            }
            
            this.didPlayParticles = true;
            this.Play();
        }
        private void Play()
        {
            var val_5 = 4;
            do
            {
                if((val_5 - 4) >= this.particles.Length)
            {
                    return;
            }
            
                EmissionModule val_2 = this.particles[0].emission;
                this.particles[0].Play();
                val_5 = val_5 + 1;
            }
            while(this.particles != null);
            
            throw new NullReferenceException();
        }
        public void Recycle()
        {
            var val_5 = 4;
            label_8:
            if((val_5 - 4) >= this.particles.Length)
            {
                goto label_2;
            }
            
            EmissionModule val_2 = this.particles[0].emission;
            this.particles[0].Stop();
            val_5 = val_5 + 1;
            if(this.particles != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_2:
            UnityEngine.Object.Destroy(obj:  this.boneFollower);
            this.boneFollower = 0;
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
            this.delayElapsed = 0f;
        }
        public override int GetPoolId()
        {
            return 117;
        }
        public CookieTracerParticles()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
