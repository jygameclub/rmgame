using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View
{
    public class DynamiteBoxItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem explodeParticles;
        public UnityEngine.ParticleSystem destroyParticles;
        
        // Methods
        public void Play()
        {
            this.explodeParticles.Play();
            this.destroyParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 92;
        }
        public DynamiteBoxItemExplodeParticles()
        {
        
        }
    
    }

}
