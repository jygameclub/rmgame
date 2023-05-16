using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem.View
{
    public class CupItemView : ItemView
    {
        // Fields
        private static readonly int CupIdle;
        private static readonly int CupDamage1;
        private static readonly int CupDamage2;
        private static readonly int CupDamage3;
        public const int ItemSortingOffset = 50;
        public Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfViewPart[] views;
        public UnityEngine.SpriteRenderer pinView;
        public UnityEngine.SpriteRenderer cupView;
        public UnityEngine.SpriteRenderer shadowView;
        public UnityEngine.SpriteRenderer bottomShadow;
        public UnityEngine.Animator cupAnimator;
        private Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
        private int cupId;
        private Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemAssets cupItemAssets;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate itemModel, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int cupId)
        {
            this.cupId = cupId;
            this.neighbors = null;
            this.cell = cell;
            this.cupItemAssets = 185636.Load<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemAssets>();
            this.cupView.gameObject.SetActive(value:  true);
            this.shadowView.gameObject.SetActive(value:  true);
            this.InitTransform(viewDelegate:  itemModel, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.cupAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.ItemSortingOffset, layer:  0, normalizedTime:  0f);
            this.pinView.enabled = false;
            this.bottomShadow.enabled = false;
            this.UpdateSprites();
        }
        public override int GetPoolId()
        {
            return 93;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public override bool CanReceiveChainExtraShadow()
        {
            return true;
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_12;
            if(this.cell != null)
            {
                    val_12 = this.cell.point;
            }
            else
            {
                    val_12 = 0;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295}, offset:  0);
            bool val_3 = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_3}, offset:  50);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.bottomShadow, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_3}, offset:  51);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.shadowView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_3}, offset:  52);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.pinView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_3}, offset:  53);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.cupView, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_10.layer, order = val_10.order, sortEverything = val_10.sortEverything & 4294967295});
            var val_13 = 0;
            do
            {
                if(val_13 >= this.views.Length)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfViewPart val_12 = this.views[val_13];
                val_13 = val_13 + 1;
            }
            while(this.views != null);
            
            throw new NullReferenceException();
        }
        public void UpdateSprites()
        {
            UnityEngine.SpriteRenderer val_37;
            bool val_6 = this.HasCupItem(cell:  this.neighbors.Get(type:  5));
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_17 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.bottomShadow);
            val_17.sortEverything = val_17.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_18 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_17.layer, order = val_17.order, sortEverything = val_17.sortEverything}, offset:  49);
            bool val_39 = val_18.sortEverything;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_19 = this.GetTopMostLeftSideCell();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_20 = this.GetTopMostRightSideCell();
            bool val_22 = this.HasCupItem(cell:  this.neighbors.Get(type:  4));
            bool val_23 = this.HasCupItem(cell:  this.neighbors.Get(type:  1));
            bool val_24 = this.HasCupItem(cell:  this.neighbors.Get(type:  7));
            var val_41 = 4;
            bool val_27 = this.HasCupItem(cell:  this.neighbors.Get(type:  3));
            bool val_28 = this.HasCupItem(cell:  this.neighbors.Get(type:  0));
            bool val_29 = this.HasCupItem(cell:  this.neighbors.Get(type:  2));
            bool val_32 = this.HasCupItem(cell:  this.neighbors.Get(type:  6));
            label_19:
            if((val_41 - 4) >= this.views.Length)
            {
                goto label_13;
            }
            
            val_39 = (val_39 & (-4294967296)) | (val_39 & 4294967295);
            this.views[0].Init(defaultSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_18.layer, order = val_18.order, sortEverything = val_39}, topMostLeftSideDiff:  (val_19.x >> 32) - this.cell, topMostRightSideDiff:  (val_20.x >> 32) - this.cell);
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfViewPart val_40 = this.views[0];
            bool val_35 = val_6;
            val_41 = val_41 + 1;
            if(this.views != null)
            {
                goto label_19;
            }
            
            label_13:
            if(val_6 == false)
            {
                goto label_21;
            }
            
            val_37 = this.shadowView;
            UnityEngine.Sprite val_36 = this.cupItemAssets.GetCupShadowNormal();
            if(val_37 != null)
            {
                goto label_23;
            }
            
            label_21:
            this.bottomShadow.enabled = true;
            val_37 = this.shadowView;
            label_23:
            val_37.sprite = this.cupItemAssets.GetCupShadowBottom();
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint GetTopMostLeftSideCell()
        {
            goto label_1;
            label_8:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.cell.neighbors.Get(type:  1);
            this.cell = val_1;
            label_1:
            bool val_7 = this.HasCupItem(cell:  X8.Get(type:  0));
            if((val_7 | (this.HasCupItem(cell:  X8.Get(type:  7)))) == true)
            {
                    return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7};
            }
            
            if(((this.HasCupItem(cell:  val_1.Get(type:  1))) ^ 1) == false)
            {
                goto label_8;
            }
            
            return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7};
        }
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint GetTopMostRightSideCell()
        {
            goto label_1;
            label_8:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.cell.neighbors.Get(type:  1);
            this.cell = val_1;
            label_1:
            bool val_7 = this.HasCupItem(cell:  X8.Get(type:  2));
            if((val_7 | (this.HasCupItem(cell:  X8.Get(type:  3)))) == true)
            {
                    return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7};
            }
            
            if(((this.HasCupItem(cell:  val_1.Get(type:  1))) ^ 1) == false)
            {
                goto label_8;
            }
            
            return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7};
        }
        private bool HasCupItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
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
            
                var val_3 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.CupItem.CupItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public void Damage()
        {
            this.bottomShadow.enabled = false;
            this.pinView.enabled = true;
            this.cupView.gameObject.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.shadowView.gameObject;
            val_2.SetActive(value:  false);
            if((val_2.CanPlay(type1:  91, type2:  92, offset:  0.04f)) != false)
            {
                    X20.PlaySfx(type:  X20.SelectRandomClip(from:  91, to:  92), offset:  0.04f);
            }
            
            this.DamageParticles();
        }
        public void Explode()
        {
            9872.PlaySfx(type:  252, offset:  0.04f);
            this.DestroyParticles();
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView>(go:  this);
        }
        private void DamageParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemExplodeParticles val_1 = 9870.Spawn<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemExplodeParticles>(poolId:  94, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        private void DestroyParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfDestroyParticles val_1 = 9871.Spawn<Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupShelfDestroyParticles>(poolId:  95, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public void RandomShake(int randomOffset, int j)
        {
            UnityEngine.Animator val_2;
            int val_3;
            int val_1 = j + randomOffset;
            val_1 = val_1 - 0;
            if(val_1 == 1)
            {
                goto label_1;
            }
            
            if(val_1 != 0)
            {
                goto label_2;
            }
            
            val_2 = this.cupAnimator;
            val_3 = Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.CupDamage1;
            goto label_10;
            label_1:
            val_2 = this.cupAnimator;
            val_3 = Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.CupDamage2;
            goto label_10;
            label_2:
            val_2 = this.cupAnimator;
            val_3 = Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.CupDamage3;
            label_10:
            val_2.Play(stateNameHash:  val_3, layer:  0, normalizedTime:  0f);
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public CupItemView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static CupItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.ItemSortingOffset = UnityEngine.Animator.StringToHash(name:  "Base Layer.CupIdleAnimation");
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.CupDamage1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.CupDamageAnimation");
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.CupDamage2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.CupDamageAnimation2");
            Royal.Scenes.Game.Mechanics.Items.CupItem.View.CupItemView.CupDamage3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.CupDamageAnimation3");
        }
    
    }

}
