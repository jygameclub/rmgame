using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SoilItem.View
{
    public class SoilItemView : ItemView
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemSprite[] views;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.RockHolder smallRockHolder;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.RockHolder mediumLargeRockHolder;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.RockHolder crackHolder;
        public Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.DirtGroupHolder dirtGroupHolder;
        public UnityEngine.Bounds[] bounds;
        public bool hasSmallRock;
        public bool hasMediumLargeRock;
        public bool hasCrack;
        private Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors;
        public UnityEngine.ParticleSystem fuseParticles;
        public UnityEngine.SpriteRenderer bombView;
        public int soilGroupId;
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles particles;
        private Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets itemAssets;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate itemModel, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int soilGroupId)
        {
            this.soilGroupId = soilGroupId;
            this.neighbors = true;
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.itemAssets = Load<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemAssets>();
            this.InitTransform(viewDelegate:  itemModel, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.UpdateSprites();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSoilSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = cell, y = cell});
            bool val_4 = val_3.sortEverything & 4294967295;
            this.FillWithRandomRocks();
        }
        public override int GetPoolId()
        {
            return 104;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.bounds = new UnityEngine.Bounds[3];
            this.hasSmallRock = false;
            this.hasMediumLargeRock = false;
            this.hasCrack = false;
            this.HideSpritesInCellBounds();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.crackHolder.spriteRenderer, alpha:  1f);
            this.fuseParticles.gameObject.SetActive(value:  false);
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this.particles, y:  0);
            if(val_3 == false)
            {
                    return;
            }
            
            val_3.Recycle<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles>(go:  this.particles);
            this.particles = 0;
        }
        public override bool CanReceiveChainExtraShadow()
        {
            return true;
        }
        private void HideSpritesInCellBounds()
        {
            Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemSprite[] val_1;
            this.smallRockHolder.spriteRenderer.sprite = 0;
            this.mediumLargeRockHolder.spriteRenderer.sprite = 0;
            this.crackHolder.spriteRenderer.sprite = 0;
            this.dirtGroupHolder.dirtGroupBL.sprite = 0;
            this.dirtGroupHolder.dirtGroupBR.sprite = 0;
            this.dirtGroupHolder.dirtGroupTL.sprite = 0;
            this.dirtGroupHolder.dirtGroupTR.sprite = 0;
            this.bombView.sprite = 0;
            val_1 = this.views;
            var val_2 = 0;
            do
            {
                if(val_2 >= this.views.Length)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemSprite val_1 = val_1[val_2];
                if((this.views[0x0][0].currentType != 2) && (this.views[0x0][0].currentType != 7))
            {
                    this.views[0x0][0].part.sprite = 0;
                val_1 = this.views;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_1 != null);
            
            throw new NullReferenceException();
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_12 = sortingData.sortEverything;
            val_12 = val_12 & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_12}, offset:  24);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.smallRockHolder.spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_12}, offset:  24);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.mediumLargeRockHolder.spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_12}, offset:  24);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.crackHolder.spriteRenderer, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_5.layer, order = val_5.order, sortEverything = val_5.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_12}, offset:  25);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.bombView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Items.SoilItem.View.Rock.DirtGroupHolder val_14 = this.dirtGroupHolder;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_12}, offset:  23);
            val_14.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_9.layer, order = val_9.order, sortEverything = val_9.sortEverything & 4294967295});
            var val_15 = 0;
            do
            {
                if(val_15 >= this.views.Length)
            {
                    return;
            }
            
                val_14 = (val_14 & (-4294967296)) | val_12;
                this.views[val_15].UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14});
                val_15 = val_15 + 1;
            }
            while(this.views != null);
            
            throw new NullReferenceException();
        }
        public void Damage(int damagedLayer)
        {
            this.bombView.sprite = this.itemAssets.GetBombSpriteForLayer(layer:  damagedLayer);
            if((damagedLayer - 1) <= 3)
            {
                    var val_4 = 36614036 + ((damagedLayer - 1)) << 2;
                val_4 = val_4 + 36614036;
            }
            else
            {
                    this.DamageParticles(damagedLayer:  damagedLayer);
                this.RemoveIntersectingRocksAndCracks();
            }
        
        }
        public void Explode()
        {
            this.DamageParticles(damagedLayer:  0);
            this.PlaySfx(type:  203, offset:  0.04f);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.RecycleCoroutine());
        }
        private System.Collections.IEnumerator RecycleCoroutine()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new SoilItemView.<RecycleCoroutine>d__25();
        }
        private void RecycleDelayed()
        {
            34448.Recycle<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemView>(go:  this);
        }
        private void DamageParticles(int damagedLayer)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilExplodeParticles>(poolId:  105, activate:  true);
            this.particles = val_2;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_3:
            label_5:
            this.particles.PlayForLayer(layer:  damagedLayer);
            UnityEngine.Vector3 val_5 = this.transform.position;
            this.particles.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(damagedLayer != 0)
            {
                    return;
            }
            
            this.particles = 0;
        }
        private void UpdateSprites()
        {
            var val_25;
            bool val_17 = this.HasSoilItem(cell:  this.neighbors.Get(type:  4));
            val_25 = 4;
            bool val_18 = this.HasSoilItem(cell:  this.neighbors.Get(type:  1));
            bool val_19 = this.HasSoilItem(cell:  this.neighbors.Get(type:  5));
            bool val_20 = this.HasSoilItem(cell:  this.neighbors.Get(type:  7));
            bool val_21 = this.HasSoilItem(cell:  this.neighbors.Get(type:  3));
            bool val_22 = this.HasSoilItem(cell:  this.neighbors.Get(type:  0));
            bool val_23 = this.HasSoilItem(cell:  this.neighbors.Get(type:  2));
            bool val_24 = this.HasSoilItem(cell:  this.neighbors.Get(type:  6));
            do
            {
                if((val_25 - 4) >= this.views.Length)
            {
                    return;
            }
            
                this.views[0].Init();
                Royal.Scenes.Game.Mechanics.Items.SoilItem.View.SoilItemSprite val_27 = this.views[0];
                val_25 = val_25 + 1;
            }
            while(this.views != null);
            
            throw new NullReferenceException();
        }
        private void RemoveIntersectingRocksAndCracks()
        {
            UnityEngine.Bounds val_1 = this.bombView.bounds;
            UnityEngine.Bounds val_4 = this.smallRockHolder.spriteRenderer.bounds;
            if(((-1621677632) & 1) != 0)
            {
                    this.smallRockHolder.spriteRenderer.sprite = 0;
            }
            
            UnityEngine.Bounds val_7 = this.bombView.bounds;
            UnityEngine.Bounds val_8 = this.mediumLargeRockHolder.spriteRenderer.bounds;
            if(((-1621677632) & 1) != 0)
            {
                    this.mediumLargeRockHolder.spriteRenderer.sprite = 0;
            }
            
            UnityEngine.Bounds val_9 = this.bombView.bounds;
            UnityEngine.Bounds val_10 = this.crackHolder.spriteRenderer.bounds;
            if(((-1621677632) & 1) == 0)
            {
                    return;
            }
            
            this.crackHolder.spriteRenderer.sprite = 0;
        }
        private bool HasSoilItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_5;
            if(cell != null)
            {
                    if(cell.CurrentItem == null)
            {
                    return (bool)val_5;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = cell.CurrentItem;
                if(val_2 == null)
            {
                    return (bool)val_5;
            }
            
                var val_3 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        private void FillWithRandomRocks()
        {
            UnityEngine.Bounds[] val_3;
            UnityEngine.Bounds[] val_4;
            UnityEngine.Bounds[] val_7;
            UnityEngine.Bounds[] val_8;
            UnityEngine.Bounds[] val_11;
            UnityEngine.Bounds[] val_12;
            this.dirtGroupHolder.Randomize(itemAssets:  this.itemAssets);
            this.hasSmallRock = this.smallRockHolder & 1;
            UnityEngine.Bounds val_2 = this.smallRockHolder.spriteRenderer.bounds;
            this.bounds = val_3;
            this.bounds = val_4;
            this.hasMediumLargeRock = this.mediumLargeRockHolder & 1;
            UnityEngine.Bounds val_6 = this.mediumLargeRockHolder.spriteRenderer.bounds;
            this.bounds = val_7;
            this.bounds = val_8;
            this.hasCrack = this.crackHolder & 1;
            UnityEngine.Bounds val_10 = this.crackHolder.spriteRenderer.bounds;
            this.bounds = val_11;
            this.bounds = val_12;
        }
        public SoilItemView()
        {
            this.bounds = new UnityEngine.Bounds[3];
        }
    
    }

}
