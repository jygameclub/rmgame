using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainTokenExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem tokenParticle;
        public UnityEngine.ParticleSystem chainParticles;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Matches.MatchType tokenColor, int curtainHeight)
        {
            var val_19;
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            UnityEngine.Sprite val_3 = val_1.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets>().GetTokenSprite(matchType:  tokenColor);
            TextureSheetAnimationModule val_4 = this.tokenParticle.textureSheetAnimation;
            this.tokenParticle.Play();
            EmissionModule val_5 = this.chainParticles.emission;
            int val_10 = curtainHeight << 4;
            val_10 = val_10 - curtainHeight;
            MinMaxCurve val_11 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  (float)val_10);
            EmissionModule val_14 = this.chainParticles.emission;
            ShapeModule val_15 = this.chainParticles.shape;
            if((curtainHeight - 3) < 5)
            {
                    val_19 = mem[36605200 + ((curtainHeight - 3)) << 2];
                val_19 = 36605200 + ((curtainHeight - 3)) << 2;
            }
            else
            {
                    val_19 = (float)curtainHeight * 0.25f;
            }
            
            this.chainParticles.Play();
            this.chainParticles.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        private float GetChainShapeRadiusByHeight(int curtainHeight)
        {
            if((curtainHeight - 3) < 5)
            {
                    return (float)36605200 + ((curtainHeight - 3)) << 2;
            }
            
            float val_2 = (float)curtainHeight;
            val_2 = val_2 * 0.25f;
            return (float)val_2;
        }
        public override int GetPoolId()
        {
            return 0;
        }
        public override void RecycleSelf()
        {
            this.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public CurtainTokenExplodeParticles()
        {
        
        }
    
    }

}
