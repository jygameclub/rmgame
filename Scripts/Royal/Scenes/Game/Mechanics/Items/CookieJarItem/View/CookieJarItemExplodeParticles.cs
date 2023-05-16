using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieJarItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem leafParticles;
        public UnityEngine.ParticleSystem shellParticles;
        
        // Methods
        public void Play(int particleLayer)
        {
            this.PlayAll(particleLayer:  particleLayer);
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        private void PlayAll(int particleLayer)
        {
            if(particleLayer != 1)
            {
                goto label_0;
            }
            
            if(this.shellParticles != null)
            {
                goto label_1;
            }
            
            throw new NullReferenceException();
            label_0:
            label_1:
            this.shellParticles.Play();
        }
        public override int GetPoolId()
        {
            return 118;
        }
        public CookieJarItemExplodeParticles()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
