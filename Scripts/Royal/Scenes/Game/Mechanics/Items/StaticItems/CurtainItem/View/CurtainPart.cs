using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public abstract class CurtainPart : MonoBehaviour
    {
        // Fields
        public const int TopEnd = 0;
        public const int TopTile = 1;
        public const int MidEnd = 2;
        public const int MidTile = 3;
        public const int BotEnd = 4;
        public const int BotTile = 5;
        protected Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets curtainAssets;
        public UnityEngine.SpriteRenderer part;
        
        // Methods
        public void Init(int spriteType, float height = 0.5)
        {
            UnityEngine.SpriteRenderer val_11;
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.curtainAssets = val_1.assetsLibrary.Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  val_1.assetsLibrary);
            if(height > 0.5f)
            {
                    this.part.drawMode = 2;
                this.part.tileMode = 0;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
                this.part.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                UnityEngine.Sprite val_5 = this.part.sprite;
                val_11 = this.part;
                UnityEngine.Rect val_6 = val_5.rect;
                float val_7 = val_5.pixelsPerUnit;
                val_7 = val_6.m_XMin / val_7;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7, y:  height);
                val_11.size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
                return;
            }
            
            this.part.drawMode = 0;
            val_11 = this.part.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_11.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public void SetSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.part, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        public abstract void ArrangeSprite(int spriteType); // 0
        public void ClearSprite()
        {
            if(this.part != null)
            {
                    this.part.sprite = 0;
                return;
            }
            
            throw new NullReferenceException();
        }
        protected CurtainPart()
        {
        
        }
    
    }

}
