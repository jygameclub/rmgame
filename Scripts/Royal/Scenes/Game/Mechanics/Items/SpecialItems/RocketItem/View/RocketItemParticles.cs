using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View
{
    public class RocketItemParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem circleParticle;
        
        // Methods
        public void Play()
        {
            if(this.circleParticle != null)
            {
                    this.circleParticle.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 8;
        }
        public void SetParticlePosition(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, d:  0.65f);
            this.circleParticle.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public RocketItemParticles()
        {
        
        }
    
    }

}
