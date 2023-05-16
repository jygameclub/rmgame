using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class ItemView : MonoBehaviour, IPoolable
    {
        // Fields
        private bool <IsFillMaskEnabled>k__BackingField;
        private bool <IsSwapping>k__BackingField;
        public Royal.Scenes.Game.Mechanics.Items.Config.RootTransform rootTransform;
        protected UnityEngine.Rendering.SortingGroup sortingGroup;
        protected Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        private bool allowSortingUpdates;
        private Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate;
        private bool <IsUnderHoney>k__BackingField;
        private bool <IsUnderChain>k__BackingField;
        
        // Properties
        public bool IsFillMaskEnabled { get; set; }
        public bool IsSwapping { get; set; }
        public UnityEngine.Vector3 Position { get; set; }
        public bool IsUnderHoney { get; set; }
        protected bool IsUnderChain { get; set; }
        
        // Methods
        public bool get_IsFillMaskEnabled()
        {
            return (bool)this.<IsFillMaskEnabled>k__BackingField;
        }
        private void set_IsFillMaskEnabled(bool value)
        {
            this.<IsFillMaskEnabled>k__BackingField = value;
        }
        public bool get_IsSwapping()
        {
            return (bool)this.<IsSwapping>k__BackingField;
        }
        private void set_IsSwapping(bool value)
        {
            this.<IsSwapping>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_Position()
        {
            return this.transform.position;
        }
        public void set_Position(UnityEngine.Vector3 value)
        {
            this.transform.position = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
        public bool get_IsUnderHoney()
        {
            return (bool)this.<IsUnderHoney>k__BackingField;
        }
        private void set_IsUnderHoney(bool value)
        {
            this.<IsUnderHoney>k__BackingField = value;
        }
        protected bool get_IsUnderChain()
        {
            return (bool)this.<IsUnderChain>k__BackingField;
        }
        private void set_IsUnderChain(bool value)
        {
            this.<IsUnderChain>k__BackingField = value;
        }
        protected virtual void Awake()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
        }
        protected void InitTransform(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.RootTransform val_12 = this;
            UnityEngine.Transform val_1 = this.transform;
            val_1.SetParent(p:  this.itemFactory.<ItemParent>k__BackingField);
            val_1.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            val_1.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
            this.<IsSwapping>k__BackingField = false;
            this.viewDelegate = viewDelegate;
            this.rootTransform = val_12;
            this.rootTransform.Reset(force:  true);
            var val_15 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    var val_16 = mem[1152921505105711112];
                val_16 = val_16 + 4;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_4 = 1152921505105674240 + val_16;
            }
            
            this.<IsUnderHoney>k__BackingField = viewDelegate.IsUnderHoney();
            var val_17 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    var val_18 = mem[1152921505105711112];
                val_18 = val_18 + 6;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_7 = 1152921505105674240 + val_18;
            }
            
            this.<IsUnderChain>k__BackingField = viewDelegate.IsUnderChain();
            var val_19 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_19 = val_19 + 1;
            }
            else
            {
                    var val_20 = mem[1152921505105711112];
                val_20 = val_20 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_10 = 1152921505105674240 + val_20;
            }
            
            if((viewDelegate.CurrentCell != null) && ((val_12 & 1) != 0))
            {
                    if((this.<IsUnderHoney>k__BackingField) == false)
            {
                goto label_23;
            }
            
            }
            
            label_26:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  (int)position.y, isReverseSort:  false);
            this.allowSortingUpdates = true;
            bool val_13 = val_12.sortEverything & 4294967295;
            val_12 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_1F0;
            label_23:
            var val_14 = ((val_12 + 81) == 0) ? 1 : 0;
            goto label_26;
        }
        public abstract int GetPoolId(); // 0
        public abstract void OnSpawn(); // 0
        public abstract void OnRecycle(); // 0
        public virtual bool IsOneCellItem()
        {
            return true;
        }
        private void UpdateSortingOnInit(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.allowSortingUpdates = true;
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_1F0;
        }
        public void UpdateSortingForAnimation(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData, bool allowOtherSortingUpdates)
        {
            this.allowSortingUpdates = true;
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            this.allowSortingUpdates = allowOtherSortingUpdates;
        }
        public virtual void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            if(this.allowSortingUpdates == false)
            {
                    return;
            }
            
            sortingData.sortEverything = sortingData.sortEverything & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.sortingGroup, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything});
        }
        public virtual Royal.Scenes.Game.Mechanics.Sortings.SortingData GetSorting()
        {
            int val_1 = this.sortingGroup.sortingLayerID;
            int val_2 = this.sortingGroup.sortingOrder;
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false};
        }
        public virtual void SwapAnimationStarted(bool isValid = True, Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem = 0)
        {
            this.<IsSwapping>k__BackingField = true;
        }
        public virtual void SwapAnimationEnded()
        {
            this.<IsSwapping>k__BackingField = false;
        }
        public virtual void Hide()
        {
            if(this.rootTransform != null)
            {
                    this.rootTransform.HideView();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Show()
        {
            if(this.rootTransform != null)
            {
                    this.rootTransform.ShowView();
                return;
            }
            
            throw new NullReferenceException();
        }
        public bool IsHidden()
        {
            if(this.rootTransform != null)
            {
                    return (bool)this.rootTransform.<IsHidden>k__BackingField;
            }
            
            throw new NullReferenceException();
        }
        public void ChangePosition(UnityEngine.Vector3 position)
        {
            this.transform.localPosition = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        }
        public virtual void EnableFillMask()
        {
            if(val_1.Length >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true)[val_3].maskInteraction = 2;
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
            
            }
            
            this.<IsFillMaskEnabled>k__BackingField = true;
        }
        public virtual void DisableFillMask()
        {
            if(val_1.Length >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true)[val_3].maskInteraction = 0;
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
            
            }
            
            this.<IsFillMaskEnabled>k__BackingField = false;
        }
        public virtual UnityEngine.Vector3 GetCenterPosition()
        {
            return this.transform.position;
        }
        public virtual UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_260;
        }
        public virtual void UpdateFallState(Royal.Scenes.Game.Mechanics.Fall.FallState newState, float currentSpeed, float maxSpeed)
        {
            if(this.rootTransform != null)
            {
                    this.rootTransform.UpdateFallState(newState:  newState, currentSpeed:  currentSpeed, maxSpeed:  maxSpeed);
                return;
            }
            
            throw new NullReferenceException();
        }
        public virtual void FallStarted()
        {
        
        }
        public virtual void FallEnded()
        {
        
        }
        public void Impact(float xDiff, float yDiff, float firstSpeed, float lastSpeed)
        {
            if((this & 1) == 0)
            {
                    return;
            }
            
            this.rootTransform.Impact(xDiff:  xDiff, yDiff:  yDiff, firstSpeed:  firstSpeed, lastSpeed:  lastSpeed);
        }
        public virtual bool IsReverseSorted()
        {
            return false;
        }
        public void SetIsUnderHoney(bool isUnder)
        {
            var val_8;
            this.<IsUnderHoney>k__BackingField = isUnder;
            if(this.viewDelegate == null)
            {
                goto label_6;
            }
            
            var val_8 = 0;
            if(mem[1152921505105711104] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505105711112];
                val_9 = val_9 + 3;
                Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_2 = 1152921505105674240 + val_9;
            }
            
            if(this.viewDelegate.CurrentCell == null)
            {
                goto label_6;
            }
            
            var val_10 = 0;
            if(mem[1152921505105711104] == null)
            {
                goto label_9;
            }
            
            val_10 = val_10 + 1;
            goto label_11;
            label_6:
            val_8 = 11;
            goto label_12;
            label_9:
            var val_11 = mem[1152921505105711112];
            val_11 = val_11 + 3;
            Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate val_4 = 1152921505105674240 + val_11;
            label_11:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.viewDelegate.CurrentCell;
            label_12:
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  this.viewDelegate, isReverseSort:  false);
            bool val_7 = val_6.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_1F0;
        }
        public void RevealFromChain()
        {
            this.<IsUnderChain>k__BackingField = false;
        }
        public virtual bool CanReceiveChainExtraShadow()
        {
            return false;
        }
        public virtual void PlayWrongMoveAnimation()
        {
            UnityEngine.Transform val_1 = this.rootTransform.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.9f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)), ease:  3);
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f), mode:  0), ease:  3));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f), mode:  0), ease:  3));
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f), mode:  0), ease:  3));
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f), mode:  0), ease:  3));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f), mode:  0), ease:  3));
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f)), ease:  3));
        }
        protected ItemView()
        {
        
        }
    
    }

}
