using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View
{
    public class SoilExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem[] particles;
        
        // Methods
        public void PlayForLayer(int layer)
        {
            this.particles[layer].Play();
        }
        public override int GetPoolId()
        {
            return 105;
        }
        public SoilExplodeParticles()
        {
        
        }
    
    }

}
