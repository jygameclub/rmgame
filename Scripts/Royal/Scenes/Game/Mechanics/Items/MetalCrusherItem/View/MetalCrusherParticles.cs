using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View
{
    public class MetalCrusherParticles : ItemParticles
    {
        // Fields
        public UnityEngine.Transform positioner;
        public UnityEngine.ParticleSystem smokeParticles;
        public UnityEngine.ParticleSystem sparkParticles;
        public UnityEngine.ParticleSystem smallParticles;
        
        // Methods
        public void Play()
        {
            this.smokeParticles.Play();
            this.sparkParticles.Play();
            this.RecycleInSeconds(seconds:  3f);
        }
        public void Prepare(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection direction)
        {
            if((direction - 1) > 3)
            {
                    return;
            }
            
            var val_15 = 36613884 + ((direction - 1)) << 2;
            val_15 = val_15 + 36613884;
            goto (36613884 + ((direction - 1)) << 2 + 36613884);
        }
        private void RecycleInSeconds(float seconds)
        {
            this.Invoke(methodName:  "RecycleSelf", time:  seconds);
        }
        public override int GetPoolId()
        {
            return 113;
        }
        public MetalCrusherParticles()
        {
        
        }
    
    }

}
