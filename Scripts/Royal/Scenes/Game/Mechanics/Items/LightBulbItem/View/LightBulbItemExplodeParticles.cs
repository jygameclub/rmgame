using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View
{
    public class LightBulbItemExplodeParticles : ItemParticles
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
            return 110;
        }
        public LightBulbItemExplodeParticles()
        {
        
        }
    
    }

}
