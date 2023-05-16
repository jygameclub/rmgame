using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntRocketCombo
{
    public class TntRocketComboUseParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem circleParticle;
        public UnityEngine.ParticleSystem baseParticle;
        
        // Methods
        public void Init(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory, bool isHorizontal)
        {
            float val_2;
            if(isHorizontal != false)
            {
                    val_2 = 0.6f;
            }
            else
            {
                    val_2 = 1.1f;
            }
            
            this.baseParticle.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void Play()
        {
            if(this.circleParticle != null)
            {
                    this.circleParticle.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 20;
        }
        public TntRocketComboUseParticles()
        {
        
        }
    
    }

}
