using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View
{
    public class DynamiteSparkParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        public UnityEngine.ParticleSystem particlesBig;
        public UnityEngine.ParticleSystem[] sortings;
        
        // Methods
        public void Play(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            int val_7;
            bool val_8 = sortingData.sortEverything;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.particles.Play();
            val_7 = 0;
            do
            {
                if(val_7 >= this.sortings.Length)
            {
                    return;
            }
            
                val_7 = val_7 + 1;
                val_8 = (val_8 & (-4294967296)) | (val_8 & 4294967295);
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_8}, offset:  val_7);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sortings[val_7].GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = X23});
            }
            while(this.sortings != null);
            
            throw new NullReferenceException();
        }
        public void PlayBigParticles()
        {
            if(this.particlesBig != null)
            {
                    this.particlesBig.Play();
                return;
            }
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 91;
        }
        public DynamiteSparkParticles()
        {
        
        }
    
    }

}
