using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public class CupItemExplodeParticles : ItemParticles
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
            return 94;
        }
        public CupItemExplodeParticles()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
