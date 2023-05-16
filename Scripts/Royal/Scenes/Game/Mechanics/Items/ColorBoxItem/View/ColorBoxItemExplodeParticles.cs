using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View
{
    public class ColorBoxItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem state1;
        public UnityEngine.ParticleSystem state1Door1;
        public UnityEngine.ParticleSystem state1Door2;
        public UnityEngine.ParticleSystem state1BigParts;
        public UnityEngine.ParticleSystem state1MidParts;
        public UnityEngine.ParticleSystem state1SmallParts;
        public UnityEngine.ParticleSystem state2;
        public UnityEngine.ParticleSystem state2SmallParts;
        public UnityEngine.ParticleSystem state3;
        public UnityEngine.ParticleSystem state3SmallParts;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int layer)
        {
            Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemAssets>();
            if(layer == 2)
            {
                goto label_3;
            }
            
            if(layer == 1)
            {
                goto label_4;
            }
            
            if(layer != 0)
            {
                goto label_5;
            }
            
            TextureSheetAnimationModule val_2 = this.state1Door1.textureSheetAnimation;
            UnityEngine.Sprite val_3 = val_1.GetLiquid(matchType:  matchType, startIndex:  15);
            TextureSheetAnimationModule val_4 = this.state1Door2.textureSheetAnimation;
            UnityEngine.Sprite val_5 = val_1.GetLiquid(matchType:  matchType, startIndex:  15);
            TextureSheetAnimationModule val_6 = this.state1BigParts.textureSheetAnimation;
            UnityEngine.Sprite val_7 = val_1.GetLiquid(matchType:  matchType, startIndex:  20);
            TextureSheetAnimationModule val_8 = this.state1BigParts.textureSheetAnimation;
            UnityEngine.Sprite val_9 = val_1.GetLiquid(matchType:  matchType, startIndex:  45);
            TextureSheetAnimationModule val_10 = this.state1MidParts.textureSheetAnimation;
            UnityEngine.Sprite val_11 = val_1.GetLiquid(matchType:  matchType, startIndex:  45);
            TextureSheetAnimationModule val_12 = this.state1MidParts.textureSheetAnimation;
            UnityEngine.Sprite val_13 = val_1.GetLiquid(matchType:  matchType, startIndex:  20);
            TextureSheetAnimationModule val_14 = this.state1MidParts.textureSheetAnimation;
            UnityEngine.Sprite val_15 = val_1.GetLiquid(matchType:  matchType, startIndex:  25);
            TextureSheetAnimationModule val_16 = this.state1SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_17 = val_1.GetLiquid(matchType:  matchType, startIndex:  30);
            TextureSheetAnimationModule val_18 = this.state1SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_19 = val_1.GetLiquid(matchType:  matchType, startIndex:  35);
            TextureSheetAnimationModule val_20 = this.state1SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_21 = val_1.GetLiquid(matchType:  matchType, startIndex:  40);
            if(this.state1 != null)
            {
                goto label_24;
            }
            
            label_3:
            TextureSheetAnimationModule val_22 = this.state3.textureSheetAnimation;
            UnityEngine.Sprite val_23 = val_1.GetLiquid(matchType:  matchType, startIndex:  50);
            TextureSheetAnimationModule val_24 = this.state3SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_25 = val_1.GetLiquid(matchType:  matchType, startIndex:  25);
            TextureSheetAnimationModule val_26 = this.state3SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_27 = val_1.GetLiquid(matchType:  matchType, startIndex:  35);
            TextureSheetAnimationModule val_28 = this.state3SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_29 = val_1.GetLiquid(matchType:  matchType, startIndex:  20);
            if(this.state3 != null)
            {
                goto label_24;
            }
            
            label_4:
            TextureSheetAnimationModule val_30 = this.state2.textureSheetAnimation;
            UnityEngine.Sprite val_31 = val_1.GetLiquid(matchType:  matchType, startIndex:  50);
            TextureSheetAnimationModule val_32 = this.state2SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_33 = val_1.GetLiquid(matchType:  matchType, startIndex:  25);
            TextureSheetAnimationModule val_34 = this.state2SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_35 = val_1.GetLiquid(matchType:  matchType, startIndex:  35);
            TextureSheetAnimationModule val_36 = this.state2SmallParts.textureSheetAnimation;
            UnityEngine.Sprite val_37 = val_1.GetLiquid(matchType:  matchType, startIndex:  20);
            label_24:
            this.state2.Play();
            label_5:
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public override int GetPoolId()
        {
            return 68;
        }
        public ColorBoxItemExplodeParticles()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
