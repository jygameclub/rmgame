using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem.View
{
    public class MatchItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.Sprite[] colorSprites1;
        public UnityEngine.Sprite[] colorSprites2;
        public UnityEngine.ParticleSystem lightRing;
        public UnityEngine.ParticleSystem blastPart;
        public Royal.Infrastructure.Utils.Particles.AutoShadowParticles shadowParticles;
        private int extraEmitCount;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType type;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Matches.MatchType type, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory)
        {
            var val_7;
            this.type = type;
            EmissionModule val_1 = this.shadowParticles.system.emission;
            this.extraEmitCount = (int)val_7.yAdvance;
        }
        public void Play(bool extraEmit)
        {
            extraEmit = extraEmit;
            this.PlayByType(extraEmit:  extraEmit);
            this.Invoke(methodName:  "RecycleSelf", time:  1f);
        }
        private void PlayByType(bool extraEmit)
        {
            var val_4;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_4 = this.type;
            val_4 = 0;
            val_4 = val_4 - 2;
            if(val_4 <= 4)
            {
                    val_4 = mem[36606496 + ((this.type - 2)) << 3];
                val_4 = 36606496 + ((this.type - 2)) << 3;
            }
            
            TextureSheetAnimationModule val_1 = this.blastPart.textureSheetAnimation;
            UnityEngine.Sprite val_5 = this.colorSprites1[val_4];
            TextureSheetAnimationModule val_2 = this.blastPart.textureSheetAnimation;
            UnityEngine.Sprite val_6 = this.colorSprites2[val_4];
            TextureSheetAnimationModule val_3 = this.blastPart.textureSheetAnimation;
            UnityEngine.Sprite val_7 = this.colorSprites1[val_4];
            if(extraEmit != false)
            {
                    this.shadowParticles.system.Emit(count:  this.extraEmitCount);
            }
            
            this.lightRing.Play();
            this.blastPart.Play();
        }
        public override int GetPoolId()
        {
            return 4;
        }
        public MatchItemExplodeParticles()
        {
        
        }
    
    }

}
