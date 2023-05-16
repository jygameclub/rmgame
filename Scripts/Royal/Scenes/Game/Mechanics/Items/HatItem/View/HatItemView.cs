using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.HatItem.View
{
    public class HatItemView : ItemView
    {
        // Fields
        private static readonly int Hat1;
        private static readonly int Hat1To2;
        private static readonly int Hat2To3;
        private static readonly int Hat3ToThrow;
        private static readonly int HatThrow;
        private static readonly int HatDisable;
        private static readonly int HatThrowIdle;
        public UnityEngine.Animator hatAnimator;
        private Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate viewDelegate;
        public UnityEngine.SpriteRenderer hatHighlightSprite;
        public UnityEngine.SpriteRenderer[] hatBackSprites;
        public UnityEngine.ParticleSystemRenderer[] particlesRenderers;
        public UnityEngine.SpriteRenderer hatPatch;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.viewDelegate = viewDelegate;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.hatAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat1, layer:  0, normalizedTime:  0f);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            this.ArrangeSortingOptimized(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        private void ArrangeSortingOptimized(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_14 = sortingData.sortEverything;
            var val_15 = 0;
            label_6:
            if(val_15 >= (this.hatBackSprites.Length << ))
            {
                goto label_2;
            }
            
            val_14 = (val_14 & (-4294967296)) | (val_14 & 4294967295);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_14}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.hatBackSprites[val_15], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = X23});
            val_15 = val_15 + 1;
            if(this.hatBackSprites != null)
            {
                goto label_6;
            }
            
            label_2:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHatParticleSorting();
            var val_17 = 0;
            bool val_5 = val_4.sortEverything & 4294967295;
            label_13:
            if(val_17 >= (this.particlesRenderers.Length << ))
            {
                goto label_11;
            }
            
            val_14 = (val_14 & (-4294967296)) | val_5;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.particlesRenderers[val_17], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_14});
            val_17 = val_17 + 1;
            if(this.particlesRenderers != null)
            {
                goto label_13;
            }
            
            label_11:
            var val_18 = 0;
            if(mem[1152921505100652544] != null)
            {
                    val_18 = val_18 + 1;
            }
            else
            {
                    var val_19 = mem[1152921505100652552];
                val_19 = val_19 + 3;
                Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate val_7 = 1152921505100615680 + val_19;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_8 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate val_9 = this.viewDelegate >> 30;
            val_9 = val_9 & 4294967292;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_11 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_5}, offset:  44 - val_9);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.hatPatch, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11.layer, order = val_11.order, sortEverything = val_11.sortEverything & 4294967295});
        }
        private void ArrangeSortingNormal(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            int val_9;
            var val_10;
            bool val_9 = sortingData.sortEverything;
            bool val_11 = false;
            val_9 = val_9 & 4294967295;
            label_6:
            val_9 = this.hatBackSprites.Length;
            if(val_11 >= (val_9 << ))
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = (X23 & (-4294967296)) | val_9}, offset:  0);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.hatBackSprites[val_11], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = X24});
            val_11 = val_11 + 1;
            if(this.hatBackSprites != null)
            {
                goto label_6;
            }
            
            label_2:
            val_9 = this.hatBackSprites.Length;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_9}, offset:  val_9);
            val_10 = 0;
            bool val_5 = val_4.sortEverything & 4294967295;
            label_13:
            if(val_10 >= (this.particlesRenderers.Length << ))
            {
                goto label_11;
            }
            
            val_11 = (val_11 & (-4294967296)) | val_5;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.particlesRenderers[val_10], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_11});
            val_10 = val_10 + 1;
            if(this.particlesRenderers != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
            label_11:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_5}, offset:  11);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.hatPatch, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
        }
        public override int GetPoolId()
        {
            return 83;
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
            
                this.hatAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat1To2, layer:  0, normalizedTime:  0f);
                val_1 = 170;
            }
            else
            {
                    this.hatAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat2To3, layer:  0, normalizedTime:  0f);
                val_1 = 171;
            }
            
                this.hatAnimator.PlaySfx(type:  171, offset:  0.04f);
                return;
            }
            
            18652.PlaySfx(type:  168, offset:  0.04f);
            this.hatAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatThrowIdle, layer:  0, normalizedTime:  0f);
        }
        public void PlayThrowAnimations(Royal.Scenes.Game.Mechanics.Matches.Cell14 cells)
        {
            var val_18 = 0;
            if(mem[1152921505100652544] != null)
            {
                    val_18 = val_18 + 1;
            }
            else
            {
                    var val_19 = mem[1152921505100652552];
                val_19 = val_19 + 3;
                Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate val_1 = 1152921505100615680 + val_19;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  true);
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything}, offset:  232);
            this.ArrangeSortingNormal(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            float val_6 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f);
            if((cells.<Count>k__BackingField) >= 1)
            {
                    var val_20 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView val_7 = Spawn<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatThrowItemView>(poolId:  84, activate:  true);
                UnityEngine.Vector3 val_10 = this.transform.position;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_7.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.GetSorting(renderer:  this.hatPatch);
                val_7.InitAndMove(cell:  cells.<Count>k__BackingField, index:  0, delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f), patchSorting:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_13.layer, order = val_13.order, sortEverything = X22});
                val_20 = val_20 + 1;
                var val_14 = 10 + 3;
            }
            while(val_20 < (cells.<Count>k__BackingField));
            
                if((cells.<Count>k__BackingField) >= 1)
            {
                    this.Invoke(methodName:  "PlayRandomWhoosh", time:  val_6);
            }
            
            }
            
            this.Invoke(methodName:  "ResetSortingToItemsLayer", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f));
            this.Invoke(methodName:  "ResetHatLayer", time:  val_6);
            this.hatAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatThrow, layer:  0, normalizedTime:  0f);
            PlaySfx(type:  ((this.randomManager.NextBool() & true) != 0) ? (172 + 1) : 172, offset:  0.04f);
        }
        private void PlayRandomWhoosh()
        {
            X8.PlaySfx(type:  ((this.randomManager.NextBool() & true) != 0) ? (174 + 1) : 174, offset:  0.04f);
        }
        private void ResetHatLayer()
        {
            var val_2 = 0;
            if(mem[1152921505100652544] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate val_1 = 1152921505100615680 + ((mem[1152921505100652552]) << 4);
            }
            
            this.viewDelegate.ResetLayer();
        }
        private void ResetSortingToItemsLayer()
        {
            var val_5 = 0;
            if(mem[1152921505100652544] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505100652552];
                val_6 = val_6 + 3;
                Royal.Scenes.Game.Mechanics.Items.HatItem.View.IHatItemViewDelegate val_1 = 1152921505100615680 + val_6;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  true);
            bool val_4 = val_3.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView).__il2cppRuntimeField_1F0;
        }
        public void ChangeToDisabledView()
        {
            var val_5;
            UnityEngine.AnimatorStateInfo val_1 = this.hatAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_5 = null;
            val_5 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatDisable)
            {
                    return;
            }
            
            this.hatAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatDisable, layer:  0, normalizedTime:  0f);
            this.hatAnimator.PlaySfx(type:  176, offset:  0.04f);
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public HatItemView()
        {
        
        }
        private static HatItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_1");
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat1To2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_1_to_2");
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat2To3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_2_to_3");
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.Hat3ToThrow = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_3_to_throw");
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatThrow = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_throw");
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatDisable = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_disable");
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView.HatThrowIdle = UnityEngine.Animator.StringToHash(name:  "Base Layer.hat_throw_idle");
        }
    
    }

}
