using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CaldronItem.View
{
    public class CaldronItemView : ItemView
    {
        // Fields
        private static readonly int Caldron1;
        private static readonly int Caldron1To2;
        private static readonly int Caldron2To3;
        private static readonly int Caldron3ToThrow;
        private static readonly int CaldronThrow;
        private static readonly int Caldron1ToDisable;
        private static readonly int Caldron2ToDisable;
        private static readonly int Caldron3ToDisable;
        private static readonly int CaldronThrowIdle;
        public UnityEngine.Animator generatorAnimator;
        private Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.ICaldronItemViewDelegate viewDelegate;
        public UnityEngine.SpriteRenderer generatorHighlightSprite;
        public UnityEngine.SpriteRenderer[] generatorBackSprites;
        public UnityEngine.ParticleSystemRenderer[] frontParticles;
        public UnityEngine.ParticleSystemRenderer[] backParticles;
        public UnityEngine.SpriteRenderer[] generatorFrontSprites;
        public UnityEngine.SpriteRenderer[] lidSprites;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.ICaldronItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.viewDelegate = viewDelegate;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.generatorAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1, layer:  0, normalizedTime:  0f);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            this.ArrangeSortingOptimized(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        private void ArrangeSortingOptimized(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_16;
            var val_17;
            bool val_19 = sortingData.sortEverything;
            val_16 = false;
            bool val_1 = val_19 & 4294967295;
            label_6:
            if(val_16 >= (this.generatorBackSprites.Length << ))
            {
                goto label_2;
            }
            
            val_19 = (val_19 & (-4294967296)) | val_1;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_19}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.generatorBackSprites[val_16], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = X23});
            val_16 = val_16 + 1;
            if(this.generatorBackSprites != null)
            {
                goto label_6;
            }
            
            label_2:
            if((this & 1) == 0)
            {
                goto label_8;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGeneratorParticleSorting();
            var val_21 = 0;
            bool val_5 = val_4.sortEverything & 4294967295;
            label_16:
            if(val_21 >= (this.frontParticles.Length << ))
            {
                goto label_12;
            }
            
            val_16 = (val_16 & (-4294967296)) | val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_16}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.frontParticles[val_21], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_19});
            val_21 = val_21 + 1;
            if(this.frontParticles != null)
            {
                goto label_16;
            }
            
            label_8:
            var val_23 = 0;
            do
            {
                if(val_23 >= (this.generatorFrontSprites.Length << ))
            {
                    return;
            }
            
                val_19 = (val_19 & (-4294967296)) | val_1;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_19}, offset:  val_23 + this.generatorBackSprites.Length);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.generatorFrontSprites[val_23], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_10.layer, order = val_10.order, sortEverything = false});
                val_23 = val_23 + 1;
            }
            while(this.generatorFrontSprites != null);
            
            label_12:
            var val_25 = 0;
            label_29:
            if(val_25 >= (this.backParticles.Length << ))
            {
                goto label_27;
            }
            
            val_16 = (val_16 & (-4294967296)) | val_5;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.backParticles[val_25], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_16});
            val_25 = val_25 + 1;
            if(this.backParticles != null)
            {
                goto label_29;
            }
            
            label_27:
            val_17 = 0;
            do
            {
                if(val_17 >= (this.generatorFrontSprites.Length << ))
            {
                    return;
            }
            
                var val_27 = 0;
                if(mem[1152921505107681280] != null)
            {
                    val_27 = val_27 + 1;
            }
            else
            {
                    var val_28 = mem[1152921505107681288];
                val_28 = val_28 + 3;
                val_28 = 1152921505107644416 + val_28;
            }
            
                Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12 = this.viewDelegate.CurrentCell;
                Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.ICaldronItemViewDelegate val_13 = this.viewDelegate >> 30;
                val_13 = val_13 & 4294967292;
                val_16 = (val_16 & (-4294967296)) | val_5;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_17 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_16}, offset:  (val_17 + 44) - val_13);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.generatorFrontSprites[val_17], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_17.layer, order = val_17.order, sortEverything = false});
                val_17 = val_17 + 1;
            }
            while(this.generatorFrontSprites != null);
            
            throw new NullReferenceException();
        }
        private void ArrangeSortingNormal(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_13;
            int val_14;
            var val_15;
            var val_16 = 0;
            val_13 = sortingData.sortEverything & 4294967295;
            label_6:
            val_14 = this.generatorBackSprites.Length;
            if(val_16 >= (val_14 << ))
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = (X23 & (-4294967296)) | val_13}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.generatorBackSprites[val_16], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = X24});
            val_16 = val_16 + 1;
            if(this.generatorBackSprites != null)
            {
                goto label_6;
            }
            
            label_2:
            val_14 = this.generatorBackSprites.Length;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_13}, offset:  val_14);
            var val_18 = 0;
            bool val_5 = val_4.sortEverything & 4294967295;
            label_15:
            if(val_18 >= (this.frontParticles.Length << ))
            {
                goto label_11;
            }
            
            val_13 = (val_13 & (-4294967296)) | val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_13}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.frontParticles[val_18], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = false});
            val_18 = val_18 + 1;
            if(this.frontParticles != null)
            {
                goto label_15;
            }
            
            label_11:
            var val_20 = 0;
            label_20:
            if(val_20 >= (this.backParticles.Length << ))
            {
                goto label_18;
            }
            
            val_13 = (val_13 & (-4294967296)) | val_5;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.backParticles[val_20], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_13});
            val_20 = val_20 + 1;
            if(this.backParticles != null)
            {
                goto label_20;
            }
            
            label_18:
            var val_22 = 4;
            label_27:
            if((val_22 - 4) >= (this.generatorFrontSprites.Length << ))
            {
                goto label_23;
            }
            
            val_13 = (val_13 & (-4294967296)) | val_5;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_13}, offset:  val_22 + 7);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.generatorFrontSprites[0], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_12.layer, order = val_12.order, sortEverything = false});
            val_22 = val_22 + 1;
            if(this.generatorFrontSprites != null)
            {
                goto label_27;
            }
            
            label_23:
            val_15 = 0;
            do
            {
                if(val_15 >= (this.lidSprites.Length << ))
            {
                    return;
            }
            
                UnityEngine.SpriteRenderer val_23 = this.lidSprites[val_15];
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  val_23);
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_14 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_13.layer, order = val_13.order, sortEverything = val_13}, offset:  19);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  val_23, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_14.layer, order = val_14.order, sortEverything = val_4.layer});
                val_15 = val_15 + 1;
            }
            while(this.lidSprites != null);
            
            throw new NullReferenceException();
        }
        public override int GetPoolId()
        {
            return 122;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void Damage(int layer)
        {
            var val_1;
            if(layer != 0)
            {
                    if(layer != 1)
            {
                    if(layer != 2)
            {
                    return;
            }
            
                this.generatorAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1To2, layer:  0, normalizedTime:  0f);
                val_1 = 41;
            }
            else
            {
                    this.generatorAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron2To3, layer:  0, normalizedTime:  0f);
                val_1 = 42;
            }
            
                this.generatorAnimator.PlaySfx(type:  42, offset:  0.04f);
                return;
            }
            
            7092.PlaySfx(type:  48, offset:  0.04f);
            this.generatorAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.CaldronThrowIdle, layer:  0, normalizedTime:  0f);
        }
        public void PlayThrowAnimations(Royal.Scenes.Game.Mechanics.Matches.Cell14 cells)
        {
            var val_17 = 0;
            if(mem[1152921505107681280] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505107681288];
                val_18 = val_18 + 3;
                Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.ICaldronItemViewDelegate val_1 = 1152921505107644416 + val_18;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  true);
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything}, offset:  232);
            this.ArrangeSortingNormal(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            if((cells.<Count>k__BackingField) >= 1)
            {
                    var val_20 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronThrowItemView val_7 = Spawn<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronThrowItemView>(poolId:  123, activate:  true);
                UnityEngine.Vector3 val_10 = this.transform.position;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_7.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.generatorFrontSprites[0]);
                val_7.InitAndMove(cell:  cells.<Count>k__BackingField, index:  0, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f), patchSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_13.layer, order = val_13.order, sortEverything = X22});
                val_20 = val_20 + 1;
                var val_14 = 10 + 3;
            }
            while(val_20 < (cells.<Count>k__BackingField));
            
            }
            
            this.Invoke(methodName:  "ResetSortingToItemsLayer", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f));
            this.Invoke(methodName:  "ResetCaldronItemLayer", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f));
            this.generatorAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.CaldronThrow, layer:  0, normalizedTime:  0f);
            this.PlaySfx(type:  this.SelectRandomClip(from:  46, to:  47), offset:  0.04f);
        }
        private void ResetCaldronItemLayer()
        {
            var val_2 = 0;
            if(mem[1152921505107681280] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.ICaldronItemViewDelegate val_1 = 1152921505107644416 + ((mem[1152921505107681288]) << 4);
            }
            
            this.viewDelegate.ResetLayer();
        }
        private void ResetSortingToItemsLayer()
        {
            var val_5 = 0;
            if(mem[1152921505107681280] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505107681288];
                val_6 = val_6 + 3;
                Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.ICaldronItemViewDelegate val_1 = 1152921505107644416 + val_6;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  true);
            bool val_4 = val_3.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView).__il2cppRuntimeField_1F0;
        }
        public void ChangeToDisabledView()
        {
            UnityEngine.Animator val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            var val_12;
            val_6 = this;
            UnityEngine.AnimatorStateInfo val_1 = this.generatorAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_7 = null;
            val_7 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1ToDisable)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron2ToDisable)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron3ToDisable)
            {
                    return;
            }
            
            this.Invoke(methodName:  "PlayCloseSfx", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  24f));
            val_10 = null;
            val_10 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1To2)
            {
                goto label_15;
            }
            
            val_6 = this.generatorAnimator;
            val_11 = Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron2ToDisable;
            goto label_38;
            label_15:
            val_12 = null;
            val_12 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron2To3)
            {
                goto label_28;
            }
            
            val_12 = null;
            val_12 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.CaldronThrow)
            {
                goto label_28;
            }
            
            val_12 = null;
            val_12 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.CaldronThrowIdle)
            {
                goto label_28;
            }
            
            val_12 = null;
            val_12 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron3ToThrow)
            {
                goto label_38;
            }
            
            label_28:
            val_6 = this.generatorAnimator;
            val_11 = Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron3ToDisable;
            label_38:
            val_6.Play(stateNameHash:  val_11, layer:  0, normalizedTime:  0f);
        }
        private void PlayCloseSfx()
        {
            if(this != null)
            {
                    this.PlaySfx(type:  43, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public CaldronItemView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static CaldronItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_1");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1To2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_1_to_2");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron2To3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_2_to_3");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron3ToThrow = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_3_to_throw");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.CaldronThrow = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_throw");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron1ToDisable = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_1_to_disable");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron2ToDisable = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_2_to_disable");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.Caldron3ToDisable = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_3_to_disable");
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView.CaldronThrowIdle = UnityEngine.Animator.StringToHash(name:  "Base Layer.caldron_throw_idle");
        }
    
    }

}
