using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PiggyItem.View
{
    public class PiggyItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  2f);
        }
        private void PlayAll()
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
            return 76;
        }
        public PiggyItemExplodeParticles()
        {
        
        }
    
    }

}
