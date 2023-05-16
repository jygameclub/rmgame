using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem.View
{
    public class PotionItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem explodeParticles;
        
        // Methods
        public void Play()
        {
            this.explodeParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  2f);
        }
        public override int GetPoolId()
        {
            return 54;
        }
        public PotionItemExplodeParticles()
        {
        
        }
    
    }

}
