using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CoinItem.View
{
    public class CoinItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void Play()
        {
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        public override int GetPoolId()
        {
            return 62;
        }
        public CoinItemExplodeParticles()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
