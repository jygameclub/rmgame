using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupboardItem.View
{
    public class CupboardItemDoorExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem doorParticles;
        
        // Methods
        public void Play()
        {
            this.doorParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 41;
        }
        public CupboardItemDoorExplodeParticles()
        {
        
        }
    
    }

}
