using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View
{
    public class TntItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem circleParticle;
        
        // Methods
        public void Play()
        {
            this.circleParticle.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        public override int GetPoolId()
        {
            return 18;
        }
        public TntItemExplodeParticles()
        {
        
        }
    
    }

}
