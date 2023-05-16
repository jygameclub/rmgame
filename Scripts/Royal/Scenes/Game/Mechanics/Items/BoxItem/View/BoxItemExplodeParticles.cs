using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BoxItem.View
{
    public class BoxItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem layer4;
        public UnityEngine.ParticleSystem layer3;
        public UnityEngine.ParticleSystem layer2;
        public UnityEngine.ParticleSystem layer1;
        
        // Methods
        public void Play(int particleLayer)
        {
            if(particleLayer <= 3)
            {
                    var val_1 = 36608408 + (particleLayer) << 2;
                val_1 = val_1 + 36608408;
            }
            else
            {
                    this.Invoke(methodName:  "RecycleSelf", time:  3f);
            }
        
        }
        public override int GetPoolId()
        {
            return 32;
        }
        public BoxItemExplodeParticles()
        {
        
        }
    
    }

}
