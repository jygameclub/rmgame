using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem.View
{
    public class DrillCounter : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro countText;
        public Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillHitParticles hitParticles;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemAssets drillItemAssets;
        
        // Methods
        public void UpdateTokenSprite()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.drillItemAssets = val_1.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemAssets>();
            this.countText.fontMaterial = val_2.counterMaterial;
        }
        public void UpdateTokenCount(int count, bool isInitial)
        {
            if(isInitial != true)
            {
                    this.hitParticles.blastParticles.Play();
                this.hitParticles.sparkParticles.Play();
            }
            
            this.countText.text = count.ToString();
        }
        public void FadeOutCountText()
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_2 = DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.countText, endValue:  0f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f));
        }
        public DrillCounter()
        {
        
        }
    
    }

}
