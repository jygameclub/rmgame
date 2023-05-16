using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SafeItem.View
{
    public class SafeItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem baseParticles;
        
        // Methods
        public void Play()
        {
            this.baseParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 60;
        }
        public SafeItemExplodeParticles()
        {
        
        }
    
    }

}
