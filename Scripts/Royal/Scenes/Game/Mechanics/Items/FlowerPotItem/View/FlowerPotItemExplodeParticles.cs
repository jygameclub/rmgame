using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View
{
    public class FlowerPotItemExplodeParticles : ItemParticles
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
            return 86;
        }
        public FlowerPotItemExplodeParticles()
        {
        
        }
    
    }

}
