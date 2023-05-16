using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  2f);
        }
        public override int GetPoolId()
        {
            return 78;
        }
        public CurtainExplodeParticles()
        {
        
        }
    
    }

}
