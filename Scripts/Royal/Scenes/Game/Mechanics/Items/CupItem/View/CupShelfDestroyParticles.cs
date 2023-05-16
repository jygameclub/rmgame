using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public class CupShelfDestroyParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 95;
        }
        public CupShelfDestroyParticles()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
