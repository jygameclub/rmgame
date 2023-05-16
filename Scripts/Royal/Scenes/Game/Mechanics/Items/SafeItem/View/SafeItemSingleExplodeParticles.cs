using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SafeItem.View
{
    public class SafeItemSingleExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem handleParticles;
        public UnityEngine.ParticleSystem doorParticles1;
        public UnityEngine.ParticleSystem doorParticles2;
        public UnityEngine.ParticleSystem doorParticles3;
        
        // Methods
        public void Play(int damagedLayer)
        {
            if((damagedLayer - 1) <= 3)
            {
                    var val_2 = 36614020 + ((damagedLayer - 1)) << 2;
                val_2 = val_2 + 36614020;
            }
            else
            {
                    this.Invoke(methodName:  "RecycleSelf", time:  3f);
            }
        
        }
        public override int GetPoolId()
        {
            return 59;
        }
        public SafeItemSingleExplodeParticles()
        {
        
        }
    
    }

}
