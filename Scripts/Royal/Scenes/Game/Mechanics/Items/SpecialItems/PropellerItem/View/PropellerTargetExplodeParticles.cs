using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View
{
    public class PropellerTargetExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem system;
        
        // Methods
        public void Play()
        {
            this.system.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        public override int GetPoolId()
        {
            return 11;
        }
        public PropellerTargetExplodeParticles()
        {
        
        }
    
    }

}
