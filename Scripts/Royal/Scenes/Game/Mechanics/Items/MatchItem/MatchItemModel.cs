using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MatchItem
{
    public class MatchItemModel : ItemModel, IMatchItemViewDelegate, IItemViewDelegate, IHintable, IGoalDependedExplodeTarget
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView <ItemView>k__BackingField;
        public Royal.Scenes.Game.Mechanics.Matches.MatchGroup matchGroup;
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData collectData;
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.SpecialItemCreation.SpecialItemCreationData specialItemData;
        private int reserveCounter;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private readonly Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper curtainHelper;
        private readonly Royal.Player.Context.Units.LevelManager levelManager;
        private readonly Royal.Scenes.Game.Levels.Units.Combo.ComboManager comboManager;
        private bool <IsSelectedAsHint>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView ItemView { get; set; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public bool IsSelectedAsHint { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 1;
        }
        public MatchItemModel(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            var val_5;
            mem[1152921520232973816] = matchType;
            val_5 = null;
            val_5 = null;
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.curtainHelper = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.comboManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Combo.ComboManager>(contextId:  13);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_1 = 24006.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(poolId:  2, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel).__il2cppRuntimeField_1E0;
        }
        public override bool ShouldAddToGoalOnStart()
        {
            return false;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.<ItemView>k__BackingField;
        }
        public override int GetExplodeScore()
        {
            var val_12;
            int val_5 = 0;
            val_12 = Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemExplodeScoreCalculator.CalculateScoreForMatchItem(itemModel:  this);
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  23)) != false)
            {
                    if((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23).GetAvailableBirdScoreAboveCell(cellModel:  this.CurrentCell, extra: out  val_5)) >= 1)
            {
                goto label_3;
            }
            
            }
            
            if(((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  34)) != false) && ((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34).GetAvailableFrogScoreAboveCell(cellModel:  this.CurrentCell, extra: out  val_5)) >= 1))
            {
                    label_3:
                val_12 = val_5 + val_12;
            }
            
            int val_11 = this.GetFrogExtraScore();
            val_11 = val_11 + val_12;
            return (int)val_11;
        }
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_6;
            bool val_1 = this.WillCellBeFreed(cell:  cell);
            if(val_1 != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            bool val_2 = val_1.HasBelowItem();
            if(val_2 != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_3 = val_2.GetTopMostBelowItem();
                var val_5 = (val_3.incomingContainer.GetIncomingCount() > 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        public override bool IsFallable()
        {
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        public override bool IsMatchItem()
        {
            return true;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        public void Reserve()
        {
            int val_1 = this.reserveCounter;
            val_1 = val_1 + 1;
            this.reserveCounter = val_1;
        }
        public void UnReserve()
        {
            int val_1 = this.reserveCounter;
            val_1 = val_1 - 1;
            this.reserveCounter = val_1;
        }
        public bool IsReserved()
        {
            return (bool)(this.reserveCounter > 0) ? 1 : 0;
        }
        public bool IsReadyForAutoExplode()
        {
            var val_4;
            if((this.<ItemView>k__BackingField) == null)
            {
                    bool val_5 = static_value_02D64000;
                var val_3 = static_value_02D64000 + 176;
                var val_4 = 0;
                val_3 = val_3 + 8;
                val_4 = val_4 + 1;
                val_3 = val_3 + 16;
                if(IsItemSteady() != false)
            {
                    var val_2 = (this.reserveCounter < 1) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public bool ShouldWaitForFallingMatchItems()
        {
            var val_12;
            var val_14;
            val_12 = this;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = 24012.CurrentCell.Get(type:  1);
            if(val_2 == null)
            {
                goto label_9;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.TargetItem;
            if(val_3 == null)
            {
                goto label_9;
            }
            
            var val_4 = (((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(((Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_3 : 0 + 40.IsItemSteady()) == false)
            {
                goto label_15;
            }
            
            val_12 = val_4;
            val_14 = (val_4 + 136) ^ 1;
            return (bool)val_14 & 1;
            label_9:
            val_14 = 0;
            return (bool)val_14 & 1;
            label_15:
            var val_14 = 0;
            if(mem[1152921505097617408] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    var val_15 = mem[1152921505097617416];
                val_15 = val_15 + 3;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel val_10 = 1152921505097580544 + val_15;
            }
            
            float val_11 = this.StateChangedTime;
            val_11 = val_11 + 0.25f;
            var val_12 = (Royal.Scenes.Game.Levels.LevelContext.Time <= val_11) ? 1 : 0;
            return (bool)val_14 & 1;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_16;
            var val_17;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_18;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_19;
            var val_20;
            float val_21;
            int val_1 = 24015.GetGoalUiLeftCount(goalType:  data.point.x);
            val_16 = 0;
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  26)) != false)
            {
                    val_16 = this.curtainHelper.GetCurtainForMatchType(matchType:  0);
            }
            
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  31)) != false)
            {
                    val_17 = this;
                Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager val_6 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31).GetDrillForMatchType(matchType:  public static Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper Royal.Scenes.Game.Levels.LevelContext::GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(Royal.Scenes.Game.Levels.LevelContextId contextId));
            }
            else
            {
                    val_17 = 1152921520234845352;
            }
            
            if(null == 5)
            {
                    Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper val_7 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27);
                if(val_7 != null)
            {
                    int val_16 = val_7.purpleOnBoard;
                val_16 = val_16 - 1;
                val_7 = val_16;
            }
            
            }
            
            if(this.specialItemData < 1)
            {
                goto label_9;
            }
            
            if(val_1 < 1)
            {
                goto label_10;
            }
            
            this.CollectToGoal();
            goto label_18;
            label_9:
            if(val_1 < 1)
            {
                goto label_12;
            }
            
            this.CollectToGoal();
            goto label_32;
            label_10:
            if(val_16 == null)
            {
                goto label_14;
            }
            
            val_18 = val_16;
            goto label_15;
            label_12:
            if(val_16 == null)
            {
                goto label_16;
            }
            
            val_19 = val_16;
            goto label_17;
            label_14:
            if(0 == 0)
            {
                goto label_18;
            }
            
            val_18 = 0;
            label_15:
            this.CollectToManager(collectManager:  val_18);
            label_18:
            if(this.specialItemData < 1)
            {
                goto label_19;
            }
            
            val_20 = 0;
            label_21:
            if(this.specialItemData == this.CurrentCell)
            {
                goto label_20;
            }
            
            val_20 = val_20 + 1;
            if(val_20 < this.specialItemData.orderedCells)
            {
                goto label_21;
            }
            
            label_19:
            val_20 = 0;
            label_20:
            val_16 = this.<ItemView>k__BackingField;
            UnityEngine.Vector3 val_9 = this.specialItemData.GetViewPosition();
            val_16.ExplodeAndMoveToPosition(targetPosition:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, index:  0, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel::<TryExplode>b__29_0()));
            label_32:
            val_16.CurrentCell.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            if((-1551834784) == 4)
            {
                    var val_12 = (this.specialItemData.orderedCells > 0) ? 1 : 0;
                val_21 = mem[36605760 + this.specialItemData.orderedCells > null ? 1 : 0];
                val_21 = 36605760 + this.specialItemData.orderedCells > null ? 1 : 0;
            }
            else
            {
                    val_21 = 0.15f;
            }
            
            this.HandleMadness(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemCounts.ItemExploded(matchType:  this, count:  1);
            return;
            label_16:
            if(0 == 0)
            {
                goto label_29;
            }
            
            val_19 = 0;
            label_17:
            this.CollectToManager(collectManager:  val_19);
            goto label_32;
            label_29:
            UnityEngine.Coroutine val_14 = this.<ItemView>k__BackingField.StartCoroutine(routine:  this.<ItemView>k__BackingField.ExplodeAnim(exploder:  -1551834784));
            goto label_32;
        }
        private void HandleMadness(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            if((-1551632768) == 2)
            {
                    return;
            }
            
            if((-1551632768) == 4)
            {
                    return;
            }
            
            val_1 = this;
            if((this.comboManager.ballBall.<IsRunning>k__BackingField) == false)
            {
                goto label_4;
            }
            
            goto label_19;
            label_4:
            val_4 = 1152921505102000128;
            if((Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.DynamiteBoxItemModel.<IsRunning>k__BackingField) == false)
            {
                goto label_13;
            }
            
            val_2 = val_1;
            goto label_19;
            label_13:
            if(((-1551632768) > 15) || ((0 & 49664) != 0))
            {
                goto label_21;
            }
            
            val_3 = 268435459;
            label_19:
            IncrementMadnessMatchItemCount(matchType:  data.point.x, exploderId:  268435459);
            return;
            label_21:
            TryCollectMadness(matchType:  47587328, originPosition:  new UnityEngine.Vector3(), count:  1, animationDelayInFrames:  5, createdItem:  0, remainingMoves:  false);
        }
        public override void CollectAsGoal(bool updateUi = True)
        {
            if(this != null)
            {
                    this.DecreaseGoal(goalType:  updateUi);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void CollectAnimationCompleted(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView)
        {
            24004.DecreaseGoalUi(goalType:  itemView);
            this.stateManager.OperationFinish(animationId:  5);
            this.stateManager.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  itemView);
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).PlaySfx(type:  185, offset:  0.04f);
        }
        public void ManagerCollectCompleted(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView itemView, Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager, bool hitFromLeft)
        {
            var val_3;
            this.stateManager.OperationFinish(animationId:  5);
            val_3 = public System.Void Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory::Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView go);
            this.stateManager.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  itemView);
            var val_3 = 0;
            if(mem[1152921505098203136] != null)
            {
                    val_3 = val_3 + 1;
                val_3 = 2;
            }
            else
            {
                    var val_4 = mem[1152921505098203144];
                val_4 = val_4 + 2;
                Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_1 = 1152921505098166272 + val_4;
            }
            
            collectManager.ItemReached(hitFromLeft:  hitFromLeft);
        }
        private Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView Collect()
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_2;
            if((true == 2) && (this.specialItemData >= 1))
            {
                    val_2 = 24005.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(poolId:  2, activate:  true);
                val_2.Init(viewDelegate:  this, position:  new UnityEngine.Vector3());
            }
            else
            {
                    val_2 = this.<ItemView>k__BackingField;
            }
            
            this.stateManager.OperationStart(animationId:  5);
            return val_2;
        }
        private void CollectToGoal()
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView val_1 = this.Collect();
            UnityEngine.Vector3 val_2 = X8.GetGoalPosition(goalType:  null);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.CurrentCell;
            val_1.CollectToGoal(goalPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, cellModel:  val_3, collectData:  new Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData() {orderedCells = new Royal.Scenes.Game.Mechanics.Matches.Cell14()});
            val_1.FlyingToBeCollected(goalType:  val_3);
        }
        private void CollectToManager(Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager collectManager)
        {
            this.Collect().CollectToManager(collectManager:  collectManager, cellModel:  this.CurrentCell, collectData:  new Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.MatchCollectData() {orderedCells = new Royal.Scenes.Game.Mechanics.Matches.Cell14()});
        }
        public override void ReplaceItem()
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.Collect.ICollectManager val_6;
            if(null == 5)
            {
                    Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27);
                if(val_1 != null)
            {
                    int val_6 = val_1.purpleOnBoard;
                val_6 = val_6 - 1;
                val_1 = val_6;
            }
            
            }
            
            int val_2 = val_1.GetGoalUiLeftCount(goalType:  public static Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper Royal.Scenes.Game.Levels.LevelContext::GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(Royal.Scenes.Game.Levels.LevelContextId contextId));
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager val_3 = this.curtainHelper.GetCurtainForMatchType(matchType:  public static Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper Royal.Scenes.Game.Levels.LevelContext::GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(Royal.Scenes.Game.Levels.LevelContextId contextId));
            Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper val_4 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31);
            if(val_4 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager val_5 = val_4.GetDrillForMatchType(matchType:  public static Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper Royal.Scenes.Game.Levels.LevelContext::GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(Royal.Scenes.Game.Levels.LevelContextId contextId));
            }
            
            if(val_2 < 1)
            {
                goto label_7;
            }
            
            this.CollectToGoal();
            goto label_8;
            label_7:
            if(val_3 == null)
            {
                goto label_9;
            }
            
            val_6 = val_3;
            goto label_10;
            label_9:
            if(0 == 0)
            {
                goto label_11;
            }
            
            val_6 = 0;
            label_10:
            this.CollectToManager(collectManager:  val_6);
            label_8:
            label_17:
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemCounts.ItemExploded(matchType:  this, count:  1);
            TryCollectMadness(matchType:  1, originPosition:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, count:  1, animationDelayInFrames:  5, createdItem:  0, remainingMoves:  false);
            return;
            label_11:
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.Config.ItemView>(go:  this);
            goto label_17;
        }
        public bool get_IsSelectedAsHint()
        {
            return (bool)this.<IsSelectedAsHint>k__BackingField;
        }
        private void set_IsSelectedAsHint(bool value)
        {
            this.<IsSelectedAsHint>k__BackingField = value;
        }
        public void StartHintAnimation(bool changeSorting)
        {
            this.<IsSelectedAsHint>k__BackingField = true;
            this.<ItemView>k__BackingField.SetHighlightRatio(ratio:  0f);
            if(changeSorting == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHintSorting();
            this = ???;
            bool val_2 = val_1.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView).__il2cppRuntimeField_1F0;
        }
        public void StopHintAnimation()
        {
            this.<ItemView>k__BackingField.SetHighlightRatio(ratio:  0f);
            this.<ItemView>k__BackingField.Reset(force:  false);
            if((this.<ItemView>k__BackingField) != null)
            {
                    return;
            }
            
            if(this.CurrentCell == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetItemSorting(row:  -1550221792, isReverseSort:  false);
            bool val_4 = val_3.sortEverything & 4294967295;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel).__il2cppRuntimeField_1F0;
        }
        public void SetHighlightRatio(float ratio)
        {
            if((this.<ItemView>k__BackingField) != null)
            {
                    this.<ItemView>k__BackingField.SetHighlightRatio(ratio:  ratio);
                return;
            }
            
            throw new NullReferenceException();
        }
        public float GetHighlightRatio()
        {
            if((this.<ItemView>k__BackingField) != null)
            {
                    return this.<ItemView>k__BackingField.GetHighlightRatio();
            }
            
            throw new NullReferenceException();
        }
        public float GetMaxHighlightRatio()
        {
            if((this.<ItemView>k__BackingField) != null)
            {
                    return this.<ItemView>k__BackingField.GetMaxHighlightRatio();
            }
            
            throw new NullReferenceException();
        }
        public override bool CanFallCross()
        {
            return true;
        }
        public bool ShouldCalculateScore()
        {
            var val_7;
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager val_1 = this.curtainHelper.GetCurtainForMatchType(matchType:  null);
            if(true != 5)
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27);
            val_7 = val_2;
            if(val_2 == null)
            {
                goto label_4;
            }
            
            var val_4 = (val_2.purpleOnBoard >= val_7.GetPurpleGoal()) ? 1 : 0;
            goto label_4;
            label_2:
            val_7 = 0;
            label_4:
            var val_6 = (this.GetGoalLeftCount() > 0) ? 1 : 0;
            val_6 = val_7 | val_6;
            if(val_6 != 0)
            {
                    return true;
            }
            
            if(val_1 == null)
            {
                    return true;
            }
            
            return val_1.HasTargetLeftLogic();
        }
        private void <TryExplode>b__29_0()
        {
            24016.Recycle<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView>(go:  this.<ItemView>k__BackingField);
        }
    
    }

}
