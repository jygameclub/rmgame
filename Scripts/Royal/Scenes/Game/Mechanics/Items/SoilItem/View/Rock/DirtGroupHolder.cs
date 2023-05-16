using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock
{
    public class DirtGroupHolder : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer dirtGroupTL;
        public UnityEngine.SpriteRenderer dirtGroupTR;
        public UnityEngine.SpriteRenderer dirtGroupBL;
        public UnityEngine.SpriteRenderer dirtGroupBR;
        private static int[] RandomIndices;
        
        // Methods
        public void Randomize(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets itemAssets)
        {
            if(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.DirtGroupHolder.RandomIndices != null)
            {
                goto label_5;
            }
            
            int[] val_1 = new int[0];
            Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.DirtGroupHolder.RandomIndices = val_1;
            var val_7 = 0;
            label_7:
            if(val_7 >= (mem[1152921520167161528] << ))
            {
                goto label_5;
            }
            
            mem[1152921520167161536] = val_7;
            val_7 = val_7 + 1;
            if(Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.DirtGroupHolder.RandomIndices != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_5:
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0).ShuffleArray<System.Int32>(array:  val_1);
            this.dirtGroupTL.sprite = itemAssets.GetDirtGroup(index:  0);
            this.dirtGroupTR.sprite = itemAssets.GetDirtGroup(index:  mem[1152921520167161540]);
            this.dirtGroupBL.sprite = itemAssets.GetDirtGroup(index:  mem[1152921520167161544]);
            this.dirtGroupBR.sprite = itemAssets.GetDirtGroup(index:  mem[1152921520167161548]);
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_1 = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.dirtGroupTL, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.dirtGroupTR, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.dirtGroupBL, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.dirtGroupBR, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
        }
        public DirtGroupHolder()
        {
        
        }
    
    }

}
