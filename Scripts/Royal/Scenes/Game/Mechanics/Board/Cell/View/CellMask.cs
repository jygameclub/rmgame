using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell.View
{
    public class CellMask : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer readMask;
        public UnityEngine.SpriteRenderer writeMask;
        
        // Methods
        public void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sort)
        {
            int val_2 = (sort.layer >> 32) - 1;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.writeMask, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.readMask, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
        }
        public void Enable(bool isEnabled)
        {
            float val_8;
            float val_9;
            UnityEngine.SpriteRenderer val_10;
            var val_11;
            this.gameObject.SetActive(value:  isEnabled);
            if(Royal.Player.Context.Units.LevelManager.IsStoryLevel != false)
            {
                    val_8 = 1.05f;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_8, y:  2f);
                val_9 = 0f;
                0.ArrangeMaskSize(mask:  this.readMask, size:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, pos:  new UnityEngine.Vector3() {x = 0f, y = val_9, z = 0f});
                val_10 = this.writeMask;
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_8, y:  2f);
                val_11 = 0.4f;
            }
            else
            {
                    val_8 = 1.05f;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_8, y:  1.2f);
                val_9 = 0f;
                0.ArrangeMaskSize(mask:  this.readMask, size:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, pos:  new UnityEngine.Vector3() {x = 0f, y = val_9, z = 0f});
                val_10 = this.writeMask;
                UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_8, y:  1.2f);
                val_11 = 0f;
            }
            
            0.ArrangeMaskSize(mask:  val_10, size:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        }
        private void ArrangeMaskSize(UnityEngine.SpriteRenderer mask, UnityEngine.Vector2 size, UnityEngine.Vector3 pos)
        {
            mask.size = new UnityEngine.Vector2() {x = size.x, y = size.y};
            mask.transform.localPosition = new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z};
        }
        public CellMask()
        {
        
        }
    
    }

}
