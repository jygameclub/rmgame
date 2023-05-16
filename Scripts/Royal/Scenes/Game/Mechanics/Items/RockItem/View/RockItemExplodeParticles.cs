using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.RockItem.View
{
    public class RockItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem layer1Particles;
        public UnityEngine.ParticleSystem layer0Particles;
        
        // Methods
        public void Play(int layer)
        {
            if(layer == 1)
            {
                    this.layer1Particles.Play();
                return;
            }
            
            this.layer0Particles.Play();
            if(layer != 0)
            {
                    return;
            }
            
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 102;
        }
        public RockItemExplodeParticles()
        {
        
        }
    
    }

}
