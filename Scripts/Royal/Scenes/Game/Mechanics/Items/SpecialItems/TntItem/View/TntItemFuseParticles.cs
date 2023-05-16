using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View
{
    public class TntItemFuseParticles : ItemParticles, ITntFuseParticles
    {
        // Fields
        public UnityEngine.ParticleSystem fuseParticles;
        public UnityEngine.Renderer sorting0;
        public UnityEngine.Renderer sorting1;
        public UnityEngine.Renderer sorting2;
        
        // Properties
        public UnityEngine.Transform Transform { get; }
        
        // Methods
        public override int GetPoolId()
        {
            return 15;
        }
        public void Play()
        {
            if(this.fuseParticles.isPlaying != false)
            {
                    return;
            }
            
            this.fuseParticles.Play();
        }
        public void Stop()
        {
            if(this.fuseParticles != null)
            {
                    this.fuseParticles.Stop();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Recycle()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles).__il2cppRuntimeField_1B0;
        }
        public UnityEngine.Transform get_Transform()
        {
            return this.transform;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_5 = sortingData.sortEverything;
            val_5 = val_5 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting0, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting1, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5}, offset:  2);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting2, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        public TntItemFuseParticles()
        {
        
        }
    
    }

}
