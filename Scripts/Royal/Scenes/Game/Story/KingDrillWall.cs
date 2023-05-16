using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class KingDrillWall : MonoBehaviour
    {
        // Fields
        private const int WallHeight = 6;
        private const int WallWidth = 8;
        public UnityEngine.Transform tileHolder;
        public UnityEngine.Sprite[] tiles;
        public UnityEngine.SpriteRenderer wallShadow;
        
        // Methods
        private void Awake()
        {
            this.CreateRandomWall();
        }
        private void CreateRandomWall()
        {
            bool val_4;
            var val_14;
            label_15:
            var val_17 = 0;
            label_14:
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject();
            UnityEngine.SpriteRenderer val_3 = val_2.AddComponent<UnityEngine.SpriteRenderer>();
            val_14 = null;
            val_14 = null;
            bool val_14 = val_4;
            val_14 = val_14 & (-4294967296);
            val_4 = val_14;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  val_3, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId | 21904333209600, order = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId | 21904333209600, sortEverything = val_14});
            var val_15 = 0;
            label_10:
            UnityEngine.Sprite val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).RandomFromArray<UnityEngine.Sprite>(array:  this.tiles);
            if(val_6 != 0)
            {
                goto label_9;
            }
            
            val_15 = val_15 + 1;
            if(val_15 < 9)
            {
                goto label_10;
            }
            
            label_9:
            val_3.sprite = val_6;
            val_2.transform.SetParent(p:  this.tileHolder);
            UnityEngine.Vector2 val_10 = val_3.size;
            UnityEngine.Vector2 val_11 = val_3.size;
            float val_16 = 0f;
            val_16 = val_10.x * val_16;
            val_11.y = val_11.y * 0f;
            val_2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_12 = val_3.size;
            val_17 = val_17 + 1;
            if(val_17 < 7)
            {
                goto label_14;
            }
            
            if(0 <= 4)
            {
                goto label_15;
            }
            
            UnityEngine.Vector2 val_13 = this.wallShadow.size;
            float val_18 = 8f;
            val_18 = val_12.x * val_18;
            this.wallShadow.size = new UnityEngine.Vector2() {x = val_18, y = val_13.y};
        }
        public KingDrillWall()
        {
        
        }
    
    }

}
