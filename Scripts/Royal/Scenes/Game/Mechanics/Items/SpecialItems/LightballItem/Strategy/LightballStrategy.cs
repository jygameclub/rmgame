using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy
{
    public abstract class LightballStrategy
    {
        // Fields
        protected const float LightballRayDelay = 0.07;
        protected const float MinimumLightballRunTime = 1;
        protected readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        protected readonly Royal.Scenes.Game.Context.Units.GameTouchListener touchManager;
        protected readonly Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator specialItemCreator;
        protected readonly Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        protected readonly Royal.Player.Context.Units.MadnessManager madnessManager;
        protected readonly Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballModel;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView lightballView;
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles lightballUseParticles;
        protected readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel> items;
        protected readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel> toBeRemovedItems;
        private readonly System.Collections.Generic.Dictionary<int, Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay> rays;
        protected Royal.Scenes.Game.Mechanics.Matches.MatchType matchType;
        private UnityEngine.Coroutine raySenderRoutine;
        private int incompleteRays;
        private int unCollectedRays;
        private bool isLookingForNewItems;
        private float lastRayCollectStartedAt;
        private bool <DidStart>k__BackingField;
        protected float startTime;
        private int raySoundIndex;
        public static float DefaultPositionOffset;
        public static float DefaultPositionOffsetDur;
        public static float DefaultMinShakeScale;
        public static float DefaultMaxShakeScale;
        public static float DefaultScaleSpeed;
        
        // Properties
        public bool DidStart { get; set; }
        public virtual float PositionOffset { get; }
        public virtual float PositionOffsetDur { get; }
        public virtual float MinShakeScale { get; }
        public virtual float MaxShakeScale { get; }
        public virtual float ScaleSpeed { get; }
        
        // Methods
        public bool get_DidStart()
        {
            return (bool)this.<DidStart>k__BackingField;
        }
        private void set_DidStart(bool value)
        {
            this.<DidStart>k__BackingField = value;
        }
        protected LightballStrategy()
        {
            this.items = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>();
            this.toBeRemovedItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel>();
            this.rays = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay>();
            this.touchManager = Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameTouchListener>(id:  0);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.specialItemCreator = this.itemFactory.specialItemCreator;
        }
        public abstract void Start(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel otherItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
        protected void Init(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem)
        {
            var val_3;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4;
            var val_6;
            this.lightballModel = lightballItem;
            val_6 = 0;
            this.lightballView = ;
            this.isLookingForNewItems = true;
            this.<DidStart>k__BackingField = true;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_2 = this.gridManager.GetIterator(iteratorType:  3);
            mem[1152921520144750464] = val_3;
            this.iterator = val_4;
            this.startTime = Royal.Scenes.Game.Levels.LevelContext.Time;
        }
        protected virtual void Reset()
        {
            this.items.Clear();
            this.rays.Clear();
            this.<DidStart>k__BackingField = false;
            this.matchType = 0;
            this.lastRayCollectStartedAt = 0f;
            this.startTime = 0f;
            this.lightballModel = 0;
            this.lightballView = 0;
            this.isLookingForNewItems = false;
            this.incompleteRays = 0;
            this.unCollectedRays = 0;
            if(this.raySenderRoutine != null)
            {
                    Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.raySenderRoutine);
                this.raySenderRoutine = 0;
            }
            
            if(this.lightballUseParticles == 0)
            {
                    return;
            }
            
            this.lightballUseParticles = 0;
        }
        public abstract void SingleRayReached(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay lightballRay, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel); // 0
        protected abstract void AllRaysComplete(); // 0
        protected abstract void AddMatchItemToList(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel); // 0
        protected abstract void StoppedLookingForNewItems(); // 0
        protected void AnimationCompleted()
        {
            bool val_1 = this.specialItemCreator.RunningLightballTypes.Remove(item:  this.matchType);
            this.touchManager.EnableTouch();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy).__il2cppRuntimeField_180;
        }
        protected void StartShakingLightball(Royal.Scenes.Game.Mechanics.Items.Config.ItemType otherItem)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballUseParticles>(poolId:  27, activate:  true);
            this.lightballUseParticles = val_1;
            val_1.Play();
            UnityEngine.Transform val_2 = this.lightballUseParticles.transform;
            val_2.SetParent(p:  val_2.transform);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.lightballUseParticles.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.lightballView.PlayUseAnimation(otherItem:  otherItem);
        }
        public void RayStartedToCollect()
        {
            int val_2 = this.unCollectedRays;
            val_2 = val_2 - 1;
            this.unCollectedRays = val_2;
            this.lastRayCollectStartedAt = Royal.Scenes.Game.Levels.LevelContext.Time;
        }
        public void SingleRayComplete(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay lightballRay, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel itemModel)
        {
            int val_1 = this.incompleteRays;
            val_1 = val_1 - 1;
            this.incompleteRays = val_1;
        }
        protected void StartSendingRays()
        {
            bool val_1 = this.specialItemCreator.RunningLightballTypes.Add(item:  this.matchType);
            this.raySenderRoutine = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.SendAllRays());
        }
        protected virtual void RemoveFromItems(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel item)
        {
            bool val_1 = this.items.Remove(item:  item);
            item.UnReserve();
        }
        private System.Collections.IEnumerator SendAllRays()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LightballStrategy.<SendAllRays>d__43();
        }
        private bool CanSendRayToItem(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel targetItem)
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6;
            var val_7;
            if((this.rays.ContainsKey(key:  targetItem.<Id>k__BackingField)) == true)
            {
                goto label_12;
            }
            
            val_6 = 0;
            if(targetItem.itemMediator.HasCurrentCell() == false)
            {
                goto label_5;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = targetItem.CurrentCell;
            val_6 = val_3;
            if((val_3.IsReadyForLightball(cell:  val_6)) == false)
            {
                goto label_6;
            }
            
            label_5:
            if((targetItem & 1) != 0)
            {
                    if(targetItem.itemMediator.HasCurrentCell() != false)
            {
                    val_7 = 1;
                return (bool)val_7;
            }
            
            }
            
            this.rays.Add(key:  targetItem.<Id>k__BackingField, value:  0);
            goto label_12;
            label_6:
            this.toBeRemovedItems.Add(item:  targetItem);
            label_12:
            val_7 = 0;
            return (bool)val_7;
        }
        protected void MoveRay(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel targetItem)
        {
            this.PlayRandomRaySound();
            int val_5 = this.incompleteRays;
            val_5 = val_5 + 1;
            this.incompleteRays = val_5;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay>(poolId:  24, activate:  true);
            UnityEngine.Vector3 val_4 = this.lightballView.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_1.Init(lightballStrategy:  this, targetModel:  targetItem);
            this.rays.Add(key:  -1640493600, value:  val_1);
        }
        private void PlayRandomRaySound()
        {
            this.sfxManager.PlaySfx(type:  (this.raySoundIndex == 1) ? 155 : ((this.raySoundIndex == 2) ? 156 : 154), offset:  0.04f);
            int val_3 = this.raySoundIndex;
            val_3 = val_3 + 1;
            val_3 = val_3 - 0;
            this.raySoundIndex = val_3;
        }
        private bool IsReadyForLightball(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_5;
            bool val_1 = this.HasTouchBlockingItemExceptChain();
            if(val_1 != true)
            {
                    if(val_1.HasCurrentItem() != false)
            {
                    val_5 = cell.IsReserved() ^ 1;
                return (bool)val_5 & 1;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        protected void FindItemsByType(Royal.Scenes.Game.Mechanics.Matches.MatchType match)
        {
            if(this.iterator == 0)
            {
                    return;
            }
            
            do
            {
                if((this.iterator.IsReadyForLightball(cell:  X22)) != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = X22 + 32.CurrentItem;
                if(val_2 != null)
            {
                    bool val_3 = val_2.IsReserved();
            }
            
            }
            
            }
            while(this.iterator != 0);
        
        }
        protected Royal.Scenes.Game.Mechanics.Matches.MatchType FindMostCommonItem()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_13;
            var val_18;
            var val_19;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if(this.gridManager == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_19 = 0;
            label_18:
            if(val_19 >= this.gridManager.Width)
            {
                goto label_2;
            }
            
            if(this.gridManager == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_18 = 0;
            label_16:
            if(val_18 >= this.gridManager.Height)
            {
                goto label_4;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_4 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  0);
            if(this.gridManager == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_5 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_4.x, y = val_4.x}];
            bool val_6 = val_5.IsReadyForLightball(cell:  val_5);
            if(val_6 != false)
            {
                    if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_6 == false)
            {
                    throw new NullReferenceException();
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_7 = val_6.CurrentItem;
                if((val_7 != null) && (val_7.IsReserved() != true))
            {
                    if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_1.TryGetValue(key:  val_7.<MatchType>k__BackingField, value: out  0)) != false)
            {
                    val_1.set_Item(key:  val_7.<MatchType>k__BackingField, value:  1);
            }
            else
            {
                    val_1.Add(key:  val_7.<MatchType>k__BackingField, value:  1);
            }
            
            }
            
            }
            
            val_18 = val_18 + 1;
            if(this.gridManager != null)
            {
                goto label_16;
            }
            
            throw new NullReferenceException();
            label_4:
            val_19 = val_19 + 1;
            if(this.gridManager != null)
            {
                goto label_18;
            }
            
            throw new NullReferenceException();
            label_2:
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.KeyCollection<TKey, TValue> val_11 = val_1.Keys;
            if(val_11 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_12 = val_11.GetEnumerator();
            val_18 = 0;
            val_19 = 0;
            goto label_24;
            label_25:
            if(this.specialItemCreator == null)
            {
                    throw new NullReferenceException();
            }
            
            if((this.specialItemCreator.RunningLightballTypes.Contains(item:  val_13)) != true)
            {
                    int val_15 = val_1.Item[val_13];
                var val_16 = (val_15 > val_19) ? (val_15) : (val_19);
            }
            
            label_24:
            if(((-1639930752) & 1) != 0)
            {
                goto label_25;
            }
            
            val_4.x.Dispose();
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)(val_15 > val_19) ? (val_13) : (val_18);
        }
        public virtual float get_PositionOffset()
        {
            null = null;
            return (float)Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultPositionOffset;
        }
        public virtual float get_PositionOffsetDur()
        {
            null = null;
            return (float)Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultPositionOffsetDur;
        }
        public virtual float get_MinShakeScale()
        {
            null = null;
            return (float)Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultMinShakeScale;
        }
        public virtual float get_MaxShakeScale()
        {
            null = null;
            return (float)Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultMaxShakeScale;
        }
        public virtual float get_ScaleSpeed()
        {
            null = null;
            return (float)Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultScaleSpeed;
        }
        public System.Collections.IEnumerator ShakeItem(Royal.Scenes.Game.Mechanics.Items.Config.RootTransform trans)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .trans = trans;
            return (System.Collections.IEnumerator)new LightballStrategy.<ShakeItem>d__65();
        }
        private static UnityEngine.Vector3 GetRandomPositionWithOffset(UnityEngine.Vector3 initialPosition, float offset)
        {
            float val_1 = UnityEngine.Random.value;
            val_1 = val_1 + val_1;
            val_1 = val_1 + (-1f);
            float val_3 = UnityEngine.Random.value;
            val_3 = val_3 + val_3;
            val_3 = val_3 + (-1f);
            float val_4 = val_3 * offset;
            float val_5 = initialPosition.x + (val_1 * offset);
            val_4 = initialPosition.y + val_4;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg CreateBg(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Items.Config.RootTransform parent)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemBg>(poolId:  23, activate:  true);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLightballItemBgSorting();
            val_1.Init(itemType:  itemType, matchType:  this.matchType, sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
            UnityEngine.Transform val_4 = val_1.transform;
            parent.AddChild(child:  val_4);
            val_4.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            return val_1;
        }
        public Royal.Scenes.Game.Mechanics.Sortings.SortingData GetLightballSorting()
        {
            return new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = this.lightballView, order = this.lightballView, sortEverything = (typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView).__il2cppRuntimeField_208 & 4294967295)>>0&0xFF};
        }
        private static LightballStrategy()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultPositionOffset = 0.016f;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultPositionOffsetDur = 0.025f;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultMinShakeScale = 0.98f;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultMaxShakeScale = 1.04f;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.DefaultScaleSpeed = 0.7f;
        }
    
    }

}
