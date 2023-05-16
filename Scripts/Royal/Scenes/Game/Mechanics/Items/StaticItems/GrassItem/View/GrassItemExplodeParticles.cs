using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View
{
    public class GrassItemExplodeParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem[] parts;
        
        // Methods
        public void Play(int particleLayer)
        {
            this.SetSorting();
            this.PlayAll(layer:  particleLayer);
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        private void SetSorting()
        {
            bool val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGrassParticleSorting();
            val_5 = val_1.sortEverything;
            int val_5 = val_2.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                val_5 = (val_5 & (-4294967296)) | (val_5 & 4294967295);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  null, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_5});
                val_6 = val_6 + 1;
            }
            while(val_6 < (val_2.Length << ));
        
        }
        private void PlayAll(int layer)
        {
            this.parts[layer].Play();
        }
        public override int GetPoolId()
        {
            return 36;
        }
        public GrassItemExplodeParticles()
        {
        
        }
    
    }

}
