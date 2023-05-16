using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View
{
    public class OwlStatueItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem layer0Particle;
        public UnityEngine.ParticleSystem layer1Particle;
        public UnityEngine.ParticleSystem layer2Particle;
        
        // Methods
        public void Play(int particleLayer)
        {
            if(particleLayer == 2)
            {
                goto label_1;
            }
            
            if(particleLayer == 1)
            {
                goto label_2;
            }
            
            if(particleLayer != 0)
            {
                goto label_3;
            }
            
            if(this.layer0Particle != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            label_6:
            this.layer1Particle.Play();
            label_3:
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
            return;
            label_1:
            if(this.layer2Particle != null)
            {
                goto label_6;
            }
        
        }
        public override int GetPoolId()
        {
            return 47;
        }
        public OwlStatueItemExplodeParticles()
        {
        
        }
    
    }

}
