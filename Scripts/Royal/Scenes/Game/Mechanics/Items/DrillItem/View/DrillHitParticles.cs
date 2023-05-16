using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.View
{
    public class DrillHitParticles : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem blastParticles;
        public UnityEngine.ParticleSystem sparkParticles;
        
        // Methods
        public void PlayBlast()
        {
            if(this.blastParticles != null)
            {
                    this.blastParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void PlaySparks()
        {
            if(this.sparkParticles != null)
            {
                    this.sparkParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public DrillHitParticles()
        {
        
        }
    
    }

}
