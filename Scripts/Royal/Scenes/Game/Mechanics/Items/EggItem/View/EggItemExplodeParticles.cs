using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.EggItem.View
{
    public class EggItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
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
            return 45;
        }
        public EggItemExplodeParticles()
        {
        
        }
    
    }

}
