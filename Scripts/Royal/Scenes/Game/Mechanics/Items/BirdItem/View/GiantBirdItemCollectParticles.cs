using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdItem.View
{
    public class GiantBirdItemCollectParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        public UnityEngine.ParticleSystem[] particesToBeSorted;
        
        // Methods
        public override int GetPoolId()
        {
            return 66;
        }
        public void Play(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            bool val_4 = sorting.sortEverything;
            var val_5 = 0;
            label_5:
            if(val_5 >= this.particesToBeSorted.Length)
            {
                goto label_2;
            }
            
            val_4 = (val_4 & (-4294967296)) | (val_4 & 4294967295);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.particesToBeSorted[val_5].GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sorting.layer, order = sorting.order, sortEverything = val_4});
            val_5 = val_5 + 1;
            if(this.particesToBeSorted != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            this.particles.Play();
            this.Invoke(methodName:  "RecycleSelf", time:  3f);
        }
        public GiantBirdItemCollectParticles()
        {
        
        }
    
    }

}
