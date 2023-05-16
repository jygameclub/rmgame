using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View
{
    public class IceCrusherExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem explodeParticles;
        public UnityEngine.ParticleSystem headParticles;
        
        // Methods
        public void ArrangePositionByType(Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection direction)
        {
            if((direction - 1) > 3)
            {
                    return;
            }
            
            var val_28 = 36605804 + ((direction - 1)) << 2;
            val_28 = val_28 + 36605804;
            goto (36605804 + ((direction - 1)) << 2 + 36605804);
        }
        public void Play()
        {
            this.explodeParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 74;
        }
        public IceCrusherExplodeParticles()
        {
        
        }
    
    }

}
