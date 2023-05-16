using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainHitParticles : MonoBehaviour
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
        public CurtainHitParticles()
        {
        
        }
    
    }

}
