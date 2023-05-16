using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View
{
    public class CurtainItemView : StaticItemView
    {
        // Fields
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainPartTL curtainTL;
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainPartTR curtainTR;
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainPartBL curtainBL;
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainPartBR curtainBR;
        private Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell;
        private int curtainId;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager curtainManager;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainRevealParticles revealParticles;
        private bool isBottom;
        
        // Methods
        public void Init(UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_1 = 9963.GetStaticItem(itemType:  3);
            this.curtainId = (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel.__il2cppRuntimeField_typeHier + -8;
            this.curtainManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26).GetCurtainManagerById(curtainGroupId:  this.curtainId);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = 47595520});
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            this.InitTransform(type:  3, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.neighbors = Royal.Scenes.Game.Mechanics.Sortings.Sorting.__il2cppRuntimeField_cctor_finished;
            this.currentCell = cell;
            this.UpdateSprites();
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_1 = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_1});
        }
        public void UpdateSprites()
        {
            float val_16;
            var val_17;
            var val_18;
            bool val_17 = this.HasSameCurtain(otherCell:  this.neighbors.Get(type:  1));
            bool val_4 = this.HasSameCurtain(otherCell:  this.neighbors.Get(type:  7));
            bool val_6 = this.HasSameCurtain(otherCell:  this.neighbors.Get(type:  5));
            bool val_8 = this.HasSameCurtain(otherCell:  this.neighbors.Get(type:  3));
            bool val_9 = val_17 | val_4;
            val_9 = val_6 & (~val_9);
            val_9 = val_9 & val_8;
            int val_10 = this.curtainManager.height - 1;
            if(val_9 == false)
            {
                goto label_5;
            }
            
            this.curtainTL.Init(spriteType:  0, height:  0.5f);
            this.curtainTR.Init(spriteType:  1, height:  0.5f);
            val_16 = (float)val_10;
            val_17 = 2;
            goto label_9;
            label_5:
            bool val_11 = val_17 ^ 1;
            val_11 = val_4 & val_11;
            val_11 = val_11 & val_6;
            if((val_11 & val_8) == false)
            {
                goto label_10;
            }
            
            this.curtainTL.Init(spriteType:  1, height:  0.5f);
            this.curtainTR.Init(spriteType:  1, height:  0.5f);
            val_16 = (float)val_10;
            val_17 = 3;
            label_9:
            this.curtainBL.Init(spriteType:  3, height:  val_16);
            label_25:
            label_39:
            this.curtainBR.Init(spriteType:  3, height:  val_16);
            label_37:
            bool val_16 = ~val_6;
            val_16 = val_16 & 1;
            this.isBottom = val_16;
            return;
            label_10:
            val_11 = val_8 | (~val_11);
            if(val_11 == false)
            {
                goto label_15;
            }
            
            bool val_13 = val_6 ^ 1;
            bool val_14 = val_17 & (~val_4);
            val_14 = val_14 & val_13;
            val_14 = val_14 & val_8;
            if(val_14 == false)
            {
                goto label_16;
            }
            
            this.curtainTL.ClearSprite();
            this.curtainTR.ClearSprite();
            val_18 = 4;
            goto label_20;
            label_15:
            this.curtainTL.Init(spriteType:  1, height:  0.5f);
            this.curtainTR.Init(spriteType:  0, height:  0.5f);
            this.curtainBL.Init(spriteType:  3, height:  (float)val_10);
            goto label_25;
            label_16:
            val_17 = val_17 & val_4;
            val_13 = val_17 & val_13;
            val_13 = val_13 & val_8;
            if(val_13 == false)
            {
                goto label_26;
            }
            
            this.curtainTL.ClearSprite();
            this.curtainTR.ClearSprite();
            val_18 = 5;
            label_20:
            this.curtainBL.Init(spriteType:  5, height:  0.5f);
            goto label_39;
            label_26:
            this.curtainTL.ClearSprite();
            this.curtainTR.ClearSprite();
            bool val_15 = val_17 ^ 1;
            val_15 = val_6 | val_15;
            val_15 = val_15 | val_8;
            if(val_15 == false)
            {
                goto label_35;
            }
            
            this.curtainBL.ClearSprite();
            this.curtainBR.ClearSprite();
            goto label_37;
            label_35:
            this.curtainBL.Init(spriteType:  5, height:  0.5f);
            goto label_39;
        }
        private bool HasSameCurtain(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel otherCell)
        {
            var val_3;
            if(otherCell != null)
            {
                    if((9962.GetStaticItem(itemType:  3)) == null)
            {
                    return (bool)val_3;
            }
            
                var val_2 = (this.curtainId == Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel.__il2cppRuntimeField_typeHierarchyDepth) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public override int GetPoolId()
        {
            return 77;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void Explode()
        {
            if(this.revealParticles != 0)
            {
                    this.revealParticles.transform.SetParent(p:  0);
                this.revealParticles.RecycleIn(recycleTime:  3f);
                this.revealParticles = 0;
            }
            
            this.revealParticles.Recycle<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView>(go:  this);
        }
        public void ArrangeSortingForRevealAnimation()
        {
            int val_4;
            var val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.currentCell.point, y = this.currentCell.point});
            val_4 = val_1.layer;
            val_5 = val_1.sortEverything;
            if(this.isBottom != false)
            {
                    val_1.sortEverything = val_5 & 4294967295;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4, order = val_1.order, sortEverything = val_1.sortEverything}, offset:  0);
                val_4 = val_2.layer;
                val_5 = val_2.sortEverything;
            }
            
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4, order = val_2.order, sortEverything = val_5 & 4294967295});
        }
        public void PlayExplodeParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainExplodeParticles val_1 = 9964.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainExplodeParticles>(poolId:  78, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public void PlayRevealParticles()
        {
            this.revealParticles = 9965.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainRevealParticles>(poolId:  79, activate:  true);
            val_1.particles.Play();
            this.revealParticles.transform.SetParent(p:  this.transform);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.revealParticles.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public CurtainItemView()
        {
        
        }
    
    }

}
