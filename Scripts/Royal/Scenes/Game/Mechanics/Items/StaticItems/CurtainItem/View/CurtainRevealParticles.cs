using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainRevealParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            if(this.particles != null)
            {
                    this.particles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 79;
        }
        public void RecycleIn(float recycleTime)
        {
            this.Invoke(methodName:  "RecycleSelf", time:  recycleTime);
        }
        public CurtainRevealParticles()
        {
        
        }
    
    }

}
