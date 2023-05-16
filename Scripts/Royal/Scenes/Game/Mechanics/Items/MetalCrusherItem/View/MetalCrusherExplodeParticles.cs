using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View
{
    public class MetalCrusherExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem explodeParticles;
        public UnityEngine.ParticleSystem headParticles;
        
        // Methods
        public void ArrangePositionByType(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection direction)
        {
            if((direction - 1) > 3)
            {
                    return;
            }
            
            var val_28 = 36613836 + ((direction - 1)) << 2;
            val_28 = val_28 + 36613836;
            goto (36613836 + ((direction - 1)) << 2 + 36613836);
        }
        public void Play()
        {
            this.explodeParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 114;
        }
        public MetalCrusherExplodeParticles()
        {
        
        }
    
    }

}
