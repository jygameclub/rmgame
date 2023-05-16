using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntTntCombo.Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.Combo
{
    public class TntTntComboExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem circleParticle;
        
        // Methods
        public void Play()
        {
            this.circleParticle.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        public override int GetPoolId()
        {
            return 21;
        }
        public TntTntComboExplodeParticles()
        {
        
        }
    
    }

}
