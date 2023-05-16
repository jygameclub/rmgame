using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem.View
{
    public class CupboardItemSingleExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem mushroomParticles;
        
        // Methods
        public void Play()
        {
            this.mushroomParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 42;
        }
        public CupboardItemSingleExplodeParticles()
        {
        
        }
    
    }

}
