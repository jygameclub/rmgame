using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View
{
    public class PropellerRocketComboParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem system;
        
        // Methods
        public void Play()
        {
            this.system.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 12;
        }
        public PropellerRocketComboParticles()
        {
        
        }
    
    }

}
