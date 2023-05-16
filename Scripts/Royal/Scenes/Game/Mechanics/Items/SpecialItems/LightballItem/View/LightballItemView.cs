using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View
{
    public class LightballItemView : SpecialItemView
    {
        // Fields
        private static readonly int LightballCreationStateId;
        private static readonly int LightballUseStateId;
        private static readonly int LightballDefaultStateId;
        private bool didStartUseAnimation;
        private bool isCreationAnimationFinished;
        public UnityEngine.Coroutine shakeRoutine;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel viewDelegate, UnityEngine.Vector3 position)
        {
            this.didStartUseAnimation = false;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            viewDelegate.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballDefaultStateId, layer:  0, normalizedTime:  0f);
            this.isCreationAnimationFinished = true;
        }
        private void Update()
        {
            if(this.isCreationAnimationFinished == true)
            {
                    return;
            }
            
            if(this.IsCreationAnimationPlaying() != false)
            {
                    return;
            }
            
            this.isCreationAnimationFinished = true;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  0, isReverseSort:  false);
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
        }
        public override Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCreationSorting()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballCreationSorting();
            val_1.sortEverything = val_1.sortEverything & 4294967295;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything};
        }
        public override int GetPoolId()
        {
            return 22;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            if(this.shakeRoutine == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.shakeRoutine);
            this.shakeRoutine = 0;
        }
        public void Explode()
        {
            22314.PlaySfx(type:  152, offset:  0.04f);
            22314.StopSoundInLoop(type:  157);
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemExplodeParticles val_1 = 22314.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemExplodeParticles>(poolId:  25, activate:  true);
            val_1.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView>(go:  this);
        }
        public override void PlayCreationAnimation(float normalizedStartTime = 0, bool playSound = True)
        {
            if(playSound != false)
            {
                    22320.PlaySfx(type:  151, offset:  0.04f);
            }
            
            this.isCreationAnimationFinished = false;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballCreationSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            this.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballCreationStateId, layer:  0, normalizedTime:  normalizedStartTime);
        }
        private bool IsCreationAnimationPlaying()
        {
            float val_3;
            var val_6;
            var val_7;
            UnityEngine.AnimatorStateInfo val_1 = 22317.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_6 = null;
            val_6 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballCreationStateId)
            {
                    var val_5 = (val_3 <= 1f) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public override void PlayBoosterAnimation()
        {
            this.isCreationAnimationFinished = false;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBoosterSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
            this.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballCreationStateId, layer:  0, normalizedTime:  0.1166667f);
        }
        public override void StopCreationAnimation()
        {
        
        }
        public void PlayUseAnimation(Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem)
        {
            if(this.didStartUseAnimation == true)
            {
                    return;
            }
            
            if(otherItem != 5)
            {
                    22321.PlaySfxInLoop(type:  157);
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballUseSorting(offset:  ((this.didStartUseAnimation + 56 + 24 + 32) + ((this.didStartUseAnimation + 56 + 24 + 32) << 2)) << 1);
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            this.didStartUseAnimation + 56 + 24 + 32.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballUseStateId, layer:  0, normalizedTime:  0f);
            this.didStartUseAnimation = true;
            this.isCreationAnimationFinished = true;
        }
        public override void SwapAnimationStarted(bool isValid = True, Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem = 0)
        {
            this.SwapAnimationStarted(isValid:  isValid, otherItem:  0);
            if(otherItem == 31)
            {
                    return;
            }
            
            if(isValid == false)
            {
                    return;
            }
            
            this.PlayUseAnimation(otherItem:  otherItem);
        }
        public LightballItemView()
        {
            val_1 = new Royal.Scenes.Game.Mechanics.Items.Config.ItemView();
        }
        private static LightballItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballCreationStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.LightballCreationAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballUseStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.LightballUseAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView.LightballDefaultStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.LightballDefaultAnimation");
        }
    
    }

}
