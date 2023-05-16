using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View
{
    public sealed class TntItemView : SpecialItemView
    {
        // Fields
        private static readonly int TntBoosterAnimationStateId;
        private static readonly int TntLightballCreationAnimationStateId;
        public UnityEngine.Transform fuseTransform;
        public UnityEngine.Transform movingFuseParent;
        public UnityEngine.SpriteMask fuseMask;
        public UnityEngine.Transform fuseMaskAnimated;
        public UnityEngine.SpriteRenderer fuseForLightball;
        private Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles fuseParticles;
        private int currentCellYToCheckAboveItem;
        private bool playFuseAnimation;
        private bool didFixCreationSorting;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate tntViewDelegate, UnityEngine.Vector3 position)
        {
            this.viewDelegate = tntViewDelegate;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets>();
            this.itemAssets = val_1;
            tntViewDelegate.sprite = val_1.GetSprite();
            this.InitTransform(viewDelegate:  this.viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            UnityEngine.GameObject val_3 = this.gameObject;
            val_3.SetActive(value:  true);
            UnityEngine.GameObject val_4 = val_3.gameObject;
            val_4.SetActive(value:  false);
            UnityEngine.Transform val_5 = val_4.transform;
            val_5.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            val_5.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_5.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.PrepareFuseParticles();
            var val_8 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_7 = 1152921505089806336 + ((mem[1152921505089843208]) << 4);
            }
            
            this.fuseParticles.Play();
        }
        public override void EnableFillMask()
        {
            this.EnableFillMask();
            var val_4 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505089843208];
                val_5 = val_5 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_1 = 1152921505089806336 + val_5;
            }
            
            if(val_3.Length < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                this.fuseParticles.Transform.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>(includeInactive:  true)[val_7].maskInteraction = 2;
                val_7 = val_7 + 1;
            }
            while(val_7 < val_3.Length);
        
        }
        public override void DisableFillMask()
        {
            var val_4 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505089843208];
                val_5 = val_5 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_1 = 1152921505089806336 + val_5;
            }
            
            if(val_3.Length >= 1)
            {
                    var val_7 = 0;
                do
            {
                this.fuseParticles.Transform.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>(includeInactive:  true)[val_7].maskInteraction = 0;
                val_7 = val_7 + 1;
            }
            while(val_7 < val_3.Length);
            
            }
            
            this.DisableFillMask();
        }
        private void Update()
        {
            float val_20;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_27;
            var val_29;
            val_27 = this;
            if(37961.isActiveAndEnabled == false)
            {
                goto label_2;
            }
            
            if(this.playFuseAnimation == false)
            {
                goto label_3;
            }
            
            var val_29 = 0;
            if(mem[1152921505089843200] == null)
            {
                goto label_6;
            }
            
            val_29 = val_29 + 1;
            goto label_8;
            label_2:
            if((this.currentCellYToCheckAboveItem >> 31) != 0)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.currentCellYToCheckAboveItem, isReverseSort:  false);
            bool val_4 = val_3.sortEverything & 4294967295;
            if(this.currentCellYToCheckAboveItem != 0)
            {
                    return;
            }
            
            this.currentCellYToCheckAboveItem = 0;
            return;
            label_6:
            var val_30 = mem[1152921505089843208];
            val_30 = val_30 + 3;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_5 = 1152921505089806336 + val_30;
            label_8:
            UnityEngine.Vector3 val_8 = this.movingFuseParent.transform.position;
            this.fuseParticles.Transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_11 = this.fuseMaskAnimated.transform.position;
            this.fuseMask.transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Quaternion val_14 = this.fuseMaskAnimated.transform.rotation;
            this.fuseMask.transform.rotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w};
            UnityEngine.Transform val_15 = this.fuseMask.transform;
            UnityEngine.Vector3 val_17 = this.fuseMaskAnimated.transform.localScale;
            val_15.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            label_3:
            UnityEngine.AnimatorStateInfo val_18 = val_15.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_29 = null;
            val_29 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView.TntLightballCreationAnimationStateId)
            {
                    return;
            }
            
            if(val_20 >= 0)
            {
                    return;
            }
            
            if(val_20 <= 0.5f)
            {
                goto label_34;
            }
            
            val_27 = this.fuseParticles;
            var val_31 = 0;
            if(mem[1152921505089843200] == null)
            {
                goto label_37;
            }
            
            val_31 = val_31 + 1;
            goto label_39;
            label_34:
            if(val_20 <= 0.4f)
            {
                    return;
            }
            
            if(this.didFixCreationSorting == true)
            {
                    return;
            }
            
            if(this.viewDelegate == null)
            {
                    return;
            }
            
            var val_32 = 0;
            if(mem[1152921505105711104] == null)
            {
                goto label_45;
            }
            
            val_32 = val_32 + 1;
            goto label_47;
            label_37:
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_22 = 1152921505089806336 + ((mem[1152921505089843208]) << 4);
            label_39:
            val_27.Play();
            return;
            label_45:
            var val_33 = mem[1152921505105711112];
            val_33 = val_33 + 3;
            Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_23 = 1152921505105674240 + val_33;
            label_47:
            if(this.viewDelegate.CurrentCell == null)
            {
                    return;
            }
            
            this.didFixCreationSorting = true;
            var val_34 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_34 = val_34 + 1;
            }
            else
            {
                    var val_35 = mem[1152921505105711112];
                val_35 = val_35 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_25 = 1152921505105674240 + val_35;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_26 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_27 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_27.layer, order = val_27.order, sortEverything = val_27.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
        }
        public override Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCreationSorting()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTntAnimationSorting();
            val_1.sortEverything = val_1.sortEverything & 4294967295;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything};
        }
        public override int GetPoolId()
        {
            return 13;
        }
        public override void OnSpawn()
        {
        
        }
        public override void Hide()
        {
            this.Hide();
            var val_2 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505089843208];
                val_3 = val_3 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_1 = 1152921505089806336 + val_3;
            }
            
            this.fuseParticles.Stop();
        }
        public override void OnRecycle()
        {
            UnityEngine.Transform val_1 = 37952.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            var val_8 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505089843208];
                val_9 = val_9 + 2;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_4 = 1152921505089806336 + val_9;
            }
            
            this.fuseParticles.Recycle();
            this.fuseParticles = 0;
            this.viewDelegate = 0;
            this.currentCellYToCheckAboveItem = 0;
            this.fuseParticles.gameObject.SetActive(value:  false);
            this.playFuseAnimation = false;
            this.fuseMask.gameObject.SetActive(value:  false);
            this.fuseForLightball.gameObject.SetActive(value:  false);
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            int val_11;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_12;
            var val_13;
            var val_14;
            Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_16;
            int val_17;
            val_11 = sortingData.layer;
            val_12 = this;
            bool val_1 = sortingData.sortEverything & 4294967295;
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11, order = sortingData.order, sortEverything = val_1});
            if((sortingData.sortEverything & true) != 0)
            {
                goto label_1;
            }
            
            label_16:
            val_12 = this.fuseParticles;
            if(val_12 == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_11, order = sortingData.order, sortEverything = val_1}, offset:  1);
            val_13 = null;
            val_14 = 0;
            if(mem[1152921505089843200] == val_13)
            {
                goto label_6;
            }
            
            val_14 = val_14 + 1;
            goto label_8;
            label_1:
            val_16 = this.viewDelegate;
            val_17 = null;
            var val_7 = 0;
            val_14 = 1152921505105711112;
            if(mem[1152921505105711104] == val_17)
            {
                goto label_11;
            }
            
            val_7 = val_7 + 1;
            goto label_13;
            label_6:
            var val_8 = mem[1152921505089843208];
            val_8 = val_8 + 4;
            val_13 = 1152921505089806336 + val_8;
            label_8:
            val_17 = val_2.layer;
            val_11 = ???;
            val_16 = ???;
            val_12 = ???;
            val_12.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_17, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            return;
            label_11:
            var val_9 = mem[1152921505105711112];
            val_9 = val_9 + 3;
            Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_4 = 1152921505105674240 + val_9;
            label_13:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = val_16.CurrentCell;
            if(val_5 == null)
            {
                    return;
            }
            
            if(val_5.HasTouchBlockingItem() == true)
            {
                goto label_16;
            }
        
        }
        public void Explode()
        {
            37947.PlaySfx(type:  256, offset:  0.04f);
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemExplodeParticles val_1 = 37947.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemExplodeParticles>(poolId:  18, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.Recycle();
        }
        public override void PlayCreationAnimation(float normalizedStartTime = 0, bool playSound = True)
        {
            if(playSound != false)
            {
                    37954.PlaySfx(type:  255, offset:  0.04f);
            }
            
            UnityEngine.GameObject val_1 = 37954.gameObject;
            val_1.SetActive(value:  false);
            val_1.gameObject.SetActive(value:  true);
            var val_6 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505089843208];
                val_7 = val_7 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_3 = 1152921505089806336 + val_7;
            }
            
            this.fuseParticles.Stop();
            this.didFixCreationSorting = false;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTntAnimationSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            this.Play(stateNameHash:  0, layer:  0, normalizedTime:  normalizedStartTime);
        }
        public override void PlayBoosterAnimation()
        {
            UnityEngine.GameObject val_1 = 37953.gameObject;
            val_1.SetActive(value:  false);
            val_1.gameObject.SetActive(value:  true);
            var val_6 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505089843208];
                val_7 = val_7 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_3 = 1152921505089806336 + val_7;
            }
            
            this.fuseParticles.Stop();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBoosterSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
            this.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView.TntBoosterAnimationStateId, layer:  0, normalizedTime:  0f);
        }
        public override void StopCreationAnimation()
        {
            bool val_1 = 37959.isActiveAndEnabled;
            if(val_1 == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = val_1.gameObject;
            val_2.SetActive(value:  true);
            val_2.gameObject.SetActive(value:  false);
            var val_10 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505105711112];
                val_11 = val_11 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_4 = 1152921505105674240 + val_11;
            }
            
            if(this.viewDelegate.CurrentCell == null)
            {
                    return;
            }
            
            var val_12 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505105711112];
                val_13 = val_13 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_6 = 1152921505105674240 + val_13;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
        }
        public void PlayLightballCreationAnimation()
        {
            this.fuseForLightball.gameObject.SetActive(value:  true);
            this.fuseForLightball.maskInteraction = 2;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = -1705473168, order = 268435459, sortEverything = (typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView).__il2cppRuntimeField_208 & 4294967295)}, offset:  10);
            bool val_4 = val_3.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.fuseForLightball, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_4});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_4}, offset:  -2);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_4}, offset:  2);
            this.fuseMask.gameObject.SetActive(value:  true);
            this.fuseMask.backSortingLayerID = val_5.layer;
            this.fuseMask.backSortingOrder = val_5.layer >> 32;
            this.fuseMask.frontSortingLayerID = val_6.layer;
            this.fuseMask.frontSortingOrder = val_6.layer >> 32;
            UnityEngine.GameObject val_10 = this.fuseMask.gameObject;
            val_10.SetActive(value:  false);
            val_10.gameObject.SetActive(value:  true);
            val_6.layer.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView.TntLightballCreationAnimationStateId, layer:  0, normalizedTime:  0f);
            this.playFuseAnimation = true;
        }
        private void PrepareFuseParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles val_1 = 37956.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles>(poolId:  15, activate:  true);
            this.fuseParticles = val_1;
            var val_8 = 0;
            if(mem[1152921505090002944] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505090002952];
                val_9 = val_9 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemFuseParticles val_2 = 1152921505089966080 + val_9;
            }
            
            UnityEngine.Transform val_3 = val_1.Transform;
            val_3.SetParent(p:  this.fuseTransform);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            val_3.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTntFuseParticlesSorting();
            var val_10 = 0;
            if(mem[1152921505089843200] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505089843208];
                val_11 = val_11 + 4;
                val_11 = 1152921505089806336 + val_11;
            }
            
            this.fuseParticles.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything & 4294967295});
        }
        public void Recycle()
        {
            37958.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView>(go:  this);
        }
        public override void SwapAnimationStarted(bool isValid = True, Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem = 0)
        {
            this.SwapAnimationStarted(isValid:  isValid, otherItem:  otherItem);
            if(otherItem != 3)
            {
                    return;
            }
            
            this.PreparePropellerComboFuseParticles();
        }
        private void PreparePropellerComboFuseParticles()
        {
            if(this.fuseParticles != null)
            {
                    var val_8 = 0;
                if(mem[1152921505089843200] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505089843208];
                val_9 = val_9 + 2;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.ITntFuseParticles val_1 = 1152921505089806336 + val_9;
            }
            
                this.fuseParticles.Recycle();
            }
            
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles val_2 = this.fuseParticles.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles>(poolId:  16, activate:  true);
            this.fuseParticles = val_2;
            var val_10 = 0;
            if(mem[1152921505090375680] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505090375688];
                val_11 = val_11 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntPropellerCombo.TntPropellerComboFuseParticles val_3 = 1152921505090338816 + val_11;
            }
            
            UnityEngine.Transform val_4 = val_2.Transform;
            val_4.SetParent(p:  this.fuseTransform.transform);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_4.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_4.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public override void FallStarted()
        {
            var val_3 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_3 = val_3 + 1;
            }
            else
            {
                    var val_4 = mem[1152921505105711112];
                val_4 = val_4 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_1 = 1152921505105674240 + val_4;
            }
            
            if(this.viewDelegate.CurrentCell == null)
            {
                goto label_6;
            }
            
            label_8:
            this.currentCellYToCheckAboveItem = public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate::get_CurrentCell();
            return;
            label_6:
            if(this != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
        }
        public override void FallEnded()
        {
            this.currentCellYToCheckAboveItem = 0;
        }
        public TntItemView()
        {
        
        }
        private static TntItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView.TntBoosterAnimationStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.TntBoosterAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemView.TntLightballCreationAnimationStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.TntLightballCreationAnimation");
        }
    
    }

}
