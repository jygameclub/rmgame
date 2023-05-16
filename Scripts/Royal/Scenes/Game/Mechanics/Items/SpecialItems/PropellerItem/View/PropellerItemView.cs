using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View
{
    public class PropellerItemView : SpecialItemView
    {
        // Fields
        private static readonly int PropellerCreationStateId;
        private static readonly int PropellerTapStartFlyStateId;
        private static readonly int PropellerSwipeStartFlyStateId;
        private static readonly int PropellerStartFallStateId;
        private static readonly int PropellerEndFallStateId;
        public UnityEngine.Transform fanTransform;
        public UnityEngine.Transform animatorTransform;
        private System.Action onTargetReach;
        private int sortingOrder;
        private bool didStartFlyAnimation;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot pilot;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate viewDelegate;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.pilot = 0;
            this.viewDelegate = viewDelegate;
            UnityEngine.Transform val_1 = 28130.transform;
            val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_1.gameObject.SetActive(value:  true);
            this.didStartFlyAnimation = false;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            this.animatorTransform.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override void ChangeAlpha(float alpha)
        {
        
        }
        public override void ResetAlpha()
        {
        
        }
        public override Royal.Scenes.Game.Mechanics.Sortings.SortingData GetCreationSorting()
        {
            var val_4 = 0;
            if(mem[1152921505091121152] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505091121160];
                val_5 = val_5 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_1 = 1152921505091084288 + val_5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.viewDelegate.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything};
        }
        public override void PlayCreationAnimation(float normalizedStartTime = 0, bool playSound = True)
        {
            Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerCreationStateId, layer:  0, normalizedTime:  normalizedStartTime);
            if(playSound == false)
            {
                    return;
            }
            
            PlaySfx(type:  216, offset:  0.04f);
        }
        public override void PlayBoosterAnimation()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBoosterSorting();
            this.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295}, allowOtherSortingUpdates:  true);
        }
        public override void StopCreationAnimation()
        {
        
        }
        public void PlayStartFlyAnimation(bool isSwipe = False)
        {
            var val_2;
            var val_3;
            int val_4;
            var val_5;
            if(this.didStartFlyAnimation != false)
            {
                    return;
            }
            
            this.didStartFlyAnimation = true;
            28135.PlaySfx(type:  219, offset:  0.04f);
            28135.gameObject.SetActive(value:  true);
            val_2 = null;
            if(isSwipe == false)
            {
                goto label_5;
            }
            
            val_3 = null;
            val_4 = 1152921505091248136;
            if(this != null)
            {
                goto label_8;
            }
            
            label_5:
            val_5 = null;
            val_4 = 1152921505091248132;
            label_8:
            this.Play(stateNameHash:  val_4, layer:  0, normalizedTime:  0f);
        }
        public override int GetPoolId()
        {
            return 9;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public override void SwapAnimationStarted(bool isValid = True, Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem = 0)
        {
            this.SwapAnimationStarted(isValid:  isValid, otherItem:  0);
            if(isValid == false)
            {
                    return;
            }
            
            if(otherItem == 5)
            {
                    return;
            }
            
            if(otherItem == 31)
            {
                    return;
            }
            
            this.PlayStartFlyAnimation(isSwipe:  true);
        }
        private void PlayExplodeParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemExplodeParticles val_1 = 28134.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemExplodeParticles>(poolId:  10, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public void MoveToTarget(bool shouldPlayParticles, System.Action targetReached)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_5 = this.pilot;
            this.onTargetReach = targetReached;
            if(val_5 == null)
            {
                    var val_8 = 0;
                if(mem[1152921505091121152] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505091121160];
                val_9 = val_9 + 2;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_1 = 1152921505091084288 + val_9;
            }
            
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_2 = this.viewDelegate.GetNewPilot();
                val_5 = val_2;
                this.pilot = val_2;
            }
            
            var val_10 = 0;
            if(mem[1152921505091600384] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505091600392];
                val_11 = val_11 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_3 = 1152921505091563520 + val_11;
            }
            
            if(val_5.FlyState != 0)
            {
                    return;
            }
            
            var val_12 = 0;
            if(mem[1152921505091600384] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_5 = 1152921505091563520 + ((mem[1152921505091600392]) << 4);
            }
            
            bool val_6 = this.pilot.ShouldPlaySfxInLoop;
            if(val_6 != false)
            {
                    val_6.PlaySfxInLoop(type:  217);
            }
            
            val_5 = this.pilot;
            var val_13 = 0;
            if(mem[1152921505091600384] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921505091600392];
                val_14 = val_14 + 2;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_7 = 1152921505091563520 + val_14;
            }
            
            val_5.StartFlying(itemView:  this, viewDelegate:  this.viewDelegate);
            if(shouldPlayParticles == false)
            {
                    return;
            }
            
            this.PlayExplodeParticles();
        }
        public void CancelMove()
        {
            var val_2 = 0;
            if(mem[1152921505091600384] != null)
            {
                    val_2 = val_2 + 1;
            }
            else
            {
                    var val_3 = mem[1152921505091600392];
                val_3 = val_3 + 3;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_1 = 1152921505091563520 + val_3;
            }
            
            this.pilot.TargetChanged();
        }
        public void ExplodeSelf(bool isPropRocketCombo = False)
        {
            var val_7;
            if(isPropRocketCombo != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerRocketComboParticles val_1 = 28126.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerRocketComboParticles>(poolId:  12, activate:  true);
                val_7 = val_1;
                val_1.Play();
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerTargetExplodeParticles val_2 = 28126.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerTargetExplodeParticles>(poolId:  11, activate:  true);
                val_7 = val_2;
                val_2.Play();
            }
            
            UnityEngine.Transform val_3 = val_7.transform;
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_3.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_3.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView>(go:  this);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).StopSoundInLoop(type:  217);
        }
        public void TriggerTargetReached()
        {
            this.PlaySfx(type:  218, offset:  0.04f);
            if(this.onTargetReach == null)
            {
                    return;
            }
            
            this.onTargetReach.Invoke();
        }
        protected void Update()
        {
            if(this.pilot == null)
            {
                    return;
            }
            
            var val_4 = 0;
            if(mem[1152921505091600384] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505091600392];
                val_5 = val_5 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_1 = 1152921505091563520 + val_5;
            }
            
            if(this.pilot.FlyState == 0)
            {
                    return;
            }
            
            var val_6 = 0;
            if(mem[1152921505091600384] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505091600392];
                val_7 = val_7 + 4;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot val_3 = 1152921505091563520 + val_7;
            }
            
            this.pilot.Move();
        }
        public override void FallStarted()
        {
            float val_3;
            var val_5;
            var val_6;
            var val_7;
            val_5 = this;
            this.FallStarted();
            UnityEngine.AnimatorStateInfo val_1 = this.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_6 = null;
            val_6 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerCreationStateId)
            {
                    if(val_3 >= 1f)
            {
                goto label_5;
            }
            
            }
            
            val_7 = null;
            val_7 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerEndFallStateId)
            {
                goto label_8;
            }
            
            return;
            label_5:
            val_7 = null;
            label_8:
            this.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerStartFallStateId, layer:  0, normalizedTime:  0f);
        }
        public override void FallEnded()
        {
            var val_5;
            var val_6;
            val_5 = this;
            this.FallEnded();
            UnityEngine.AnimatorStateInfo val_1 = this.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_6 = null;
            val_6 = null;
            if( != Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerStartFallStateId)
            {
                    return;
            }
            
            this.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerEndFallStateId, layer:  0, normalizedTime:  0f);
        }
        public PropellerItemView()
        {
            val_1 = new Royal.Scenes.Game.Mechanics.Items.Config.ItemView();
        }
        private static PropellerItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerCreationStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.PropellerCreationAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerTapStartFlyStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.PropellerTapStartFlyAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerSwipeStartFlyStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.PropellerSwipeStartFlyAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerStartFallStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.PropellerStartFallAnimation");
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView.PropellerEndFallStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.PropellerEndFallAnimation");
        }
    
    }

}
