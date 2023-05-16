using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SwitchItem.View
{
    public class SwitchItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem explodeParticles;
        
        // Methods
        public void Play()
        {
            this.explodeParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 120;
        }
        public SwitchItemExplodeParticles()
        {
        
        }
    
    }

}
