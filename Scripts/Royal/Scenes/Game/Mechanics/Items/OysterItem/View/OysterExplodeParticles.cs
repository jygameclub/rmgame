using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OysterItem.View
{
    public class OysterExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem layer3;
        public UnityEngine.ParticleSystem layer2;
        public UnityEngine.ParticleSystem layer1;
        
        // Methods
        public void Play(int particleLayer)
        {
            if(particleLayer == 0)
            {
                goto label_1;
            }
            
            if(particleLayer == 1)
            {
                goto label_2;
            }
            
            if(particleLayer != 2)
            {
                goto label_3;
            }
            
            if(this.layer3 != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            label_6:
            this.layer2.Play();
            label_3:
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
            return;
            label_1:
            if(this.layer1 != null)
            {
                goto label_6;
            }
        
        }
        public override int GetPoolId()
        {
            return 81;
        }
        public OysterExplodeParticles()
        {
        
        }
    
    }

}
