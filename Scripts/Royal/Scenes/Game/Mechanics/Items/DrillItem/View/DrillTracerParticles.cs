using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.View
{
    public class DrillTracerParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem tracerParticle;
        public UnityEngine.ParticleSystem sparkParticle;
        
        // Methods
        public void Play()
        {
            if(this.tracerParticle != null)
            {
                    this.tracerParticle.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 107;
        }
        public DrillTracerParticles()
        {
        
        }
    
    }

}
