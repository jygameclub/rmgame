using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View
{
    public class LightballUseParticles : ItemParticles
    {
        // Fields
        public UnityEngine.ParticleSystem backGlowBg;
        public UnityEngine.ParticleSystem backGlow;
        public UnityEngine.ParticleSystem ring;
        
        // Methods
        public void Play()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballUseSorting(offset:  0);
            bool val_2 = val_1.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_2}, offset:  -2);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_2}, offset:  0);
            bool val_9 = val_4.sortEverything;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.backGlowBg.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            val_9 = val_9 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.backGlow.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_9});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.ring.GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_9});
            this.backGlowBg.Play();
            this.backGlow.Play();
            this.ring.Play();
        }
        public void StopEmitting()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles).__il2cppRuntimeField_1B0;
        }
        public override int GetPoolId()
        {
            return 27;
        }
        public LightballUseParticles()
        {
        
        }
    
    }

}
