using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View
{
    public class HoneyItemView : StaticItemView
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemSprite[] grids;
        public UnityEngine.SpriteRenderer[] connects;
        public UnityEngine.SpriteRenderer[] extras;
        private Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemAssets itemAssets;
        
        // Methods
        public void Init(UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            this.itemAssets = 185636.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemAssets>();
            this.neighbors = 1152921520032194272;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell, y = cell});
            bool val_3 = val_2.sortEverything & 4294967295;
            this.InitTransform(type:  2, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            var val_6 = 0;
            label_10:
            if(val_6 >= this.extras.Length)
            {
                goto label_7;
            }
            
            this.extras[val_6].enabled = false;
            val_6 = val_6 + 1;
            if(this.extras != null)
            {
                goto label_10;
            }
            
            label_7:
            var val_8 = 0;
            label_16:
            if(val_8 >= this.connects.Length)
            {
                goto label_13;
            }
            
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            this.connects[val_8].color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            val_8 = val_8 + 1;
            if(this.connects != null)
            {
                goto label_16;
            }
            
            label_13:
            var val_10 = 0;
            label_22:
            if(val_10 >= this.grids.Length)
            {
                goto label_19;
            }
            
            this.grids[val_10].Init(honeyItemAssets:  this.itemAssets, extraRenderers:  this.extras);
            val_10 = val_10 + 1;
            if(this.grids != null)
            {
                goto label_22;
            }
            
            throw new NullReferenceException();
            label_19:
            this.UpdateSprites();
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_8 = sortingData.sortEverything;
            var val_9 = 0;
            bool val_1 = val_8 & 4294967295;
            label_5:
            if(val_9 >= this.grids.Length)
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemSprite val_8 = this.grids[val_9];
            val_8 = sortingData.layer;
            val_8 = val_8;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.grids[0x0][0].spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            val_9 = val_9 + 1;
            if(this.grids != null)
            {
                goto label_5;
            }
            
            label_2:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1}, offset:  10);
            var val_11 = 0;
            label_12:
            if(val_11 >= (this.connects.Length << ))
            {
                goto label_10;
            }
            
            val_8 = (val_8 & (-4294967296)) | (val_2.sortEverything & 4294967295);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.connects[val_11], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_8});
            val_11 = val_11 + 1;
            if(this.connects != null)
            {
                goto label_12;
            }
            
            label_10:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHoneySortingForExplosion();
            var val_13 = 0;
            do
            {
                if(val_13 >= (this.extras.Length << ))
            {
                    return;
            }
            
                val_8 = (val_8 & (-4294967296)) | (val_5.sortEverything & 4294967295);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.extras[val_13], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_8});
                val_13 = val_13 + 1;
            }
            while(this.extras != null);
            
            throw new NullReferenceException();
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data, System.Action onComplete)
        {
            PlaySfx(type:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  2)) != 0) ? (135 + 1) : 135, offset:  0.04f);
            this.SpawnParticle();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.ExplodeWithAnimation(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}, onComplete:  onComplete));
        }
        private void SpawnParticle()
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemExplodeParticles val_1 = 19013.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemExplodeParticles>(poolId:  38, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public override int GetPoolId()
        {
            return 37;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void UpdateSprites()
        {
            var val_25;
            var val_26;
            val_25 = 0;
            bool val_17 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  4));
            bool val_18 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  1));
            bool val_19 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  5));
            bool val_20 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  7));
            bool val_21 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  3));
            bool val_22 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  0));
            bool val_23 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  2));
            bool val_24 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  6));
            label_17:
            if(val_25 >= this.grids.Length)
            {
                    return;
            }
            
            if(((val_25 - 2) & 2147483648) != 0)
            {
                goto label_11;
            }
            
            if(this.grids[val_25] != null)
            {
                goto label_14;
            }
            
            label_11:
            val_26 = 0;
            label_14:
            val_25 = val_25 + 1;
            if(this.grids != null)
            {
                goto label_17;
            }
            
            throw new NullReferenceException();
        }
        private System.Collections.IEnumerator ExplodeWithAnimation(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .onComplete = onComplete;
            mem[1152921520034663768] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new HoneyItemView.<ExplodeWithAnimation>d__13();
        }
        private void ExpandSprites()
        {
            var val_26 = 0;
            label_12:
            if(val_26 >= this.extras.Length)
            {
                goto label_9;
            }
            
            this.extras[val_26].enabled = false;
            val_26 = val_26 + 1;
            if(this.extras != null)
            {
                goto label_12;
            }
            
            label_9:
            var val_28 = 0;
            bool val_17 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  4));
            bool val_18 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  1));
            bool val_19 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  5));
            bool val_20 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  7));
            bool val_21 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  3));
            bool val_22 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  0));
            bool val_23 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  2));
            bool val_24 = Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView.HasHoneyItem(cell:  this.neighbors.Get(type:  6));
            do
            {
                if(val_28 >= this.grids.Length)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemSprite val_27 = this.grids[val_28];
                val_28 = val_28 + 1;
            }
            while(this.grids != null);
            
            throw new NullReferenceException();
        }
        private void SetTransparency(float alpha)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            var val_5 = 0;
            label_5:
            if(val_5 >= this.grids.Length)
            {
                goto label_1;
            }
            
            Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemSprite val_4 = this.grids[val_5];
            this.grids[0x0][0].spriteRenderer.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
            val_5 = val_5 + 1;
            if(this.grids != null)
            {
                goto label_5;
            }
            
            label_1:
            var val_8 = 4;
            label_15:
            if((val_8 - 4) >= this.extras.Length)
            {
                goto label_8;
            }
            
            if(this.extras[0].enabled != false)
            {
                    this.extras[0].color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
            }
            
            val_8 = val_8 + 1;
            if(this.extras != null)
            {
                goto label_15;
            }
            
            label_8:
            var val_10 = 0;
            do
            {
                if(val_10 >= this.connects.Length)
            {
                    return;
            }
            
                this.connects[val_10].color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = alpha};
                val_10 = val_10 + 1;
            }
            while(this.connects != null);
            
            throw new NullReferenceException();
        }
        private static bool HasHoneyItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_4;
            if(cell == null)
            {
                    return (bool)val_4;
            }
            
            bool val_1 = cell.HasTouchBlockingItem();
            if(val_1 != false)
            {
                    var val_3 = ((val_1.GetStaticItem(itemType:  2)) != 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public HoneyItemView()
        {
        
        }
    
    }

}
