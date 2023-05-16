using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem.View
{
    public class PotionItemSingleExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem potionsParticles;
        public UnityEngine.ParticleSystem colorParticles;
        public UnityEngine.ParticleSystem[] colors;
        
        // Methods
        public void Play(UnityEngine.Sprite splashSprite, UnityEngine.Sprite dropSprite)
        {
            var val_3;
            TextureSheetAnimationModule val_1 = this.colors[0].textureSheetAnimation;
            val_3 = 5;
            label_8:
            if((5 - 4) >= this.colors.Length)
            {
                goto label_5;
            }
            
            TextureSheetAnimationModule val_3 = this.colors[1].textureSheetAnimation;
            val_3 = 5 + 1;
            if(this.colors != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_5:
            this.colorParticles.Play();
            this.potionsParticles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  2f);
        }
        public override int GetPoolId()
        {
            return 53;
        }
        public PotionItemSingleExplodeParticles()
        {
        
        }
    
    }

}
