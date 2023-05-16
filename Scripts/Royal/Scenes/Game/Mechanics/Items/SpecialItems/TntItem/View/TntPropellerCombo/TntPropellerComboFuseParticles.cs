using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo
{
    public class TntPropellerComboFuseParticles : ItemParticles, ITntFuseParticles
    {
        // Fields
        public UnityEngine.ParticleSystem fuseParticles;
        public UnityEngine.Renderer sorting0;
        public UnityEngine.Renderer sorting1;
        public UnityEngine.Renderer sorting2;
        public UnityEngine.Renderer sorting3;
        
        // Properties
        public UnityEngine.Transform Transform { get; }
        
        // Methods
        public override int GetPoolId()
        {
            return 16;
        }
        public void Play()
        {
            if(this.fuseParticles != null)
            {
                    this.fuseParticles.Play();
                return;
            }
            
            throw new NullReferenceException();
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
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles).__il2cppRuntimeField_1B0;
        }
        public UnityEngine.Transform get_Transform()
        {
            return this.transform;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_7 = sortingData.sortEverything;
            val_7 = val_7 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting0, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_7});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_7}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting1, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_7}, offset:  2);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting2, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_7}, offset:  3);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.sorting3, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
        }
        public TntPropellerComboFuseParticles()
        {
        
        }
    
    }

}
