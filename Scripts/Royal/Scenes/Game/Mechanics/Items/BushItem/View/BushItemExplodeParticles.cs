using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem.View
{
    public class BushItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem[] particlesByLayer;
        
        // Methods
        public void Play(int layer)
        {
            this.particlesByLayer[layer].Play();
            if(layer != 0)
            {
                    return;
            }
            
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 56;
        }
        public BushItemExplodeParticles()
        {
        
        }
    
    }

}
