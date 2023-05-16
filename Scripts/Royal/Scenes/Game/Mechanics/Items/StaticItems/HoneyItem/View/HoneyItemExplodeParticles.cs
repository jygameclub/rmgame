using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 38;
        }
        public HoneyItemExplodeParticles()
        {
        
        }
    
    }

}
