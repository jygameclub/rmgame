using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Board.Cell
{
    public class CellModel : ICellViewDelegate
    {
        // Fields
        public const float DefaultFreezeTime = 0.15;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellType <Type>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType <FillType>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point;
        public readonly Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediator Mediator;
        private readonly Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors neighbors;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.ExplodeTargetMediator <ExplodeTargetMediator>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView <CellView>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator <StaticMediator>k__BackingField;
        private int fallFreeze;
        private int touchDisableCount;
        public bool shouldFindCross;
        public int incomingGrassCount;
        private readonly Royal.Infrastructure.Utils.Counters.DisableCounter reserve;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private readonly Royal.Player.Context.Units.LevelManager levelManager;
        private bool isBottomCell;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellType Type { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType FillType { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint Point { get; }
        public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors Neighbors { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.ExplodeTargetMediator ExplodeTargetMediator { get; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView CellView { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator StaticMediator { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel CurrentItem { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel NextItem { get; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel TargetItem { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellType get_Type()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellType)this.<Type>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType get_FillType()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType)this.<FillType>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint get_Point()
        {
            return new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.point, y = this.point};
        }
        public Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors get_Neighbors()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors)this.neighbors;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.ExplodeTargetMediator get_ExplodeTargetMediator()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.ExplodeTargetMediator)this.<ExplodeTargetMediator>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView get_CellView()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView)this.<CellView>k__BackingField;
        }
        private void set_CellView(Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView value)
        {
            this.<CellView>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator get_StaticMediator()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator)this.<StaticMediator>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_CurrentItem()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.Mediator.current.<Item>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_NextItem()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.Mediator.next.<Item>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemModel get_TargetItem()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this.Mediator.target.<Item>k__BackingField;
        }
        public CellModel(Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState, Royal.Scenes.Game.Mechanics.Board.Cell.CellType type, Royal.Scenes.Game.Mechanics.Board.Cell.CellFillType fillType, Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            this.<Type>k__BackingField = type;
            this.<FillType>k__BackingField = fillType;
            this.point = point;
            this.Mediator = new Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediator(cellModel:  this);
            this.<StaticMediator>k__BackingField = new Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemMediator(cellModel:  this);
            this.neighbors = new Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y});
            .frame = 0;
            .score = 0;
            .cell = this;
            this.<ExplodeTargetMediator>k__BackingField = new Royal.Scenes.Game.Mechanics.Board.Cell.ExplodeTargetMediator();
            this.reserve = new Royal.Infrastructure.Utils.Counters.DisableCounter();
            this.gameState = gameState;
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
        }
        private bool HasSwappableItem()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5;
            if((this.touchDisableCount == 0) && ((this.<StaticMediator>k__BackingField.HasTouchBlockingItem()) != true))
            {
                    val_5 = this.Mediator.current.<Item>k__BackingField;
                if(val_5 == null)
            {
                    return (bool)val_5 & 1;
            }
            
                if((this.CurrentItem & 1) != 0)
            {
                    val_5 = this.reserve.IsEnabled() ^ 1;
                return (bool)val_5 & 1;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        private bool HasAutoSwappableItem()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5;
            if((this.touchDisableCount == 0) && ((this.<StaticMediator>k__BackingField.HasFallBlockingItem()) != true))
            {
                    val_5 = this.Mediator.current.<Item>k__BackingField;
                if(val_5 == null)
            {
                    return (bool)val_5 & 1;
            }
            
                if((this.CurrentItem & 1) != 0)
            {
                    val_5 = this.reserve.IsEnabled() ^ 1;
                return (bool)val_5 & 1;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5 & 1;
        }
        private bool HasAutoSwappableItemAfterFall()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.Mediator.CellMediator val_8;
            if(this.touchDisableCount == 0)
            {
                    if((this.<StaticMediator>k__BackingField.HasFallBlockingItem()) == false)
            {
                goto label_2;
            }
            
            }
            
            return (bool)0 & 1;
            label_2:
            val_8 = this.Mediator;
            if((this.Mediator.target.<Item>k__BackingField) == null)
            {
                goto label_5;
            }
            
            if((this.TargetItem & 1) != 0)
            {
                goto label_22;
            }
            
            val_8 = this.Mediator;
            label_5:
            if((this.Mediator.next.<Item>k__BackingField) == null)
            {
                goto label_10;
            }
            
            if((this.NextItem & 1) == 0)
            {
                goto label_12;
            }
            
            label_22:
            bool val_6 = this.reserve.IsEnabled() ^ 1;
            return (bool)0 & 1;
            label_12:
            val_8 = this.Mediator;
            label_10:
            if((this.Mediator.current.<Item>k__BackingField) == null)
            {
                    return (bool)0 & 1;
            }
            
            if((this.CurrentItem & 1) != 0)
            {
                    return (bool)0 & 1;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_8 = this.TargetItem;
            if((val_8 == null) || ((val_8 & 1) == 0))
            {
                    return (bool)0 & 1;
            }
            
            goto label_22;
        }
        public bool IsSwappableEmptyCell()
        {
            if((this.touchDisableCount != 0) || ((this.<Type>k__BackingField) != 1))
            {
                    return false;
            }
            
            if((this.Mediator.current.<Item>k__BackingField) != null)
            {
                    return false;
            }
            
            var val_1 = ((this.Mediator.next.<Item>k__BackingField) == 0) ? 1 : 0;
            return false;
        }
        public bool CanSwapFrom()
        {
            return this.HasSwappableItem();
        }
        public bool CanSwapTo()
        {
            if(this.IsSwappableEmptyCell() == false)
            {
                    return this.HasSwappableItem();
            }
            
            return true;
        }
        public bool CanAutoSwap()
        {
            return this.HasAutoSwappableItem();
        }
        public bool CanAutoSwapAfterFall()
        {
            if(this.IsSwappableEmptyCell() == true)
            {
                    return true;
            }
            
            if(this.HasAutoSwappableItemAfterFall() == false)
            {
                    return this.HasSpecialItem();
            }
            
            return true;
        }
        public bool WillBeFreed()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.TargetItem;
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_2D0;
        }
        public bool HasSpecialItem()
        {
            if((this.Mediator.current.<Item>k__BackingField) == null)
            {
                    return false;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.CurrentItem;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_380;
        }
        public bool CanTapCurrentItem(out Royal.Scenes.Game.Mechanics.Items.Config.ITapItem tapItem)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.CurrentItem;
            tapItem = null;
            if(this.touchDisableCount == 0)
            {
                    if((this.<StaticMediator>k__BackingField.HasTouchBlockingItem()) == false)
            {
                goto label_3;
            }
            
            }
            
            return (bool)0 & 1;
            label_3:
            if((this.Mediator.current.<Item>k__BackingField) == null)
            {
                    return (bool)0 & 1;
            }
            
            if(tapItem == false)
            {
                    return (bool)0 & 1;
            }
            
            var val_9 = mem[X0];
            if((mem[X0] + 294) == 0)
            {
                goto label_11;
            }
            
            var val_6 = mem[X0] + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_10:
            if(((mem[X0] + 176 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (mem[X0] + 294))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            var val_8 = val_6;
            val_8 = val_8 + 2;
            val_9 = val_9 + val_8;
            val_5 = val_9 + 304;
            label_11:
            bool val_5 = tapItem.IsTapDisabled ^ 1;
            return (bool)0 & 1;
        }
        public bool IsFillingCell()
        {
            return (bool)((this.<FillType>k__BackingField) == 1) ? 1 : 0;
        }
        public bool IsNormalCell()
        {
            return (bool)((this.<Type>k__BackingField) == 1) ? 1 : 0;
        }
        public bool IsBlankCell()
        {
            return (bool)((this.<Type>k__BackingField) == 0) ? 1 : 0;
        }
        public void FreezeFall()
        {
            int val_1 = this.fallFreeze;
            val_1 = val_1 + 1;
            this.fallFreeze = val_1;
            this.gameState.operations.Start(operationType:  1);
        }
        public void UnFreezeFall()
        {
            int val_1 = this.fallFreeze;
            val_1 = val_1 - 1;
            this.fallFreeze = val_1;
            this.gameState.operations.Finish(operationType:  1);
        }
        public void FreezeFallForDuration(float duration)
        {
            float val_2 = this.<CellView>k__BackingField.freezeDuration;
            if(val_2 > 0f)
            {
                    float val_1 = duration - val_2;
                if(val_1 <= 0f)
            {
                    return;
            }
            
                val_2 = val_2 + val_1;
                this.<CellView>k__BackingField = val_2;
                return;
            }
            
            this.FreezeFall();
            this.<CellView>k__BackingField = duration;
            this.<CellView>k__BackingField = 1;
        }
        public bool IsFallFrozen()
        {
            return (bool)(this.fallFreeze > 0) ? 1 : 0;
        }
        public bool IsFallBlocked()
        {
            if((this.<StaticMediator>k__BackingField) != null)
            {
                    return this.<StaticMediator>k__BackingField.HasFallBlockingItem();
            }
            
            throw new NullReferenceException();
        }
        public void DisableTouch()
        {
            int val_1 = this.touchDisableCount;
            val_1 = val_1 + 1;
            this.touchDisableCount = val_1;
        }
        public void EnableTouch()
        {
            int val_1 = this.touchDisableCount;
            val_1 = val_1 - 1;
            if()
            {
                    return;
            }
            
            this.touchDisableCount = val_1;
        }
        public bool IsTouchEnabled()
        {
            return (bool)(this.touchDisableCount == 0) ? 1 : 0;
        }
        public override string ToString()
        {
            return (string)"Cell: "("Cell: ") + this.point;
        }
        public void CreateView()
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_1 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView>(poolId:  0, activate:  true);
            val_2.InitializeView(model:  this, itemFactory:  val_1);
            val_2.ShowView(show:  ((this.<Type>k__BackingField) == 1) ? 1 : 0);
            this.<CellView>k__BackingField = val_2;
            this.<StaticMediator>k__BackingField.CreateViews();
        }
        public void Reset()
        {
            if((this.<CellView>k__BackingField) != 0)
            {
                    Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).Recycle<Royal.Scenes.Game.Mechanics.Board.Cell.View.CellView>(go:  this.<CellView>k__BackingField);
            }
            
            this.<CellView>k__BackingField = 0;
            this.Mediator.ClearAllItems();
            this.<StaticMediator>k__BackingField.Reset();
        }
        public void ExplodeCurrentItem(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_3;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5;
            if((this.<StaticMediator>k__BackingField.ExplodeTopMostAboveItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id})) == true)
            {
                    return;
            }
            
            val_5 = this.Mediator.current.<Item>k__BackingField;
            if(val_5 != null)
            {
                    if(val_3 >= 1)
            {
                    var val_5 = 0;
                do
            {
                val_4 + 40.AddToExploders(id:  268435460);
                val_5 = val_5 + 1;
            }
            while(val_5 < val_3);
            
            }
            
                this.<StaticMediator>k__BackingField.belowExploderContainer.AddToExploders(id:  268435460);
                return;
            }
            
            this.<StaticMediator>k__BackingField.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public void ExplodeCurrentItemByNearMatch(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_3 = 1152921523921824768;
            if((this.<StaticMediator>k__BackingField.ExplodeTopMostAboveItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id})) == true)
            {
                    return;
            }
            
            if((this.Mediator.current.<Item>k__BackingField) == null)
            {
                    return;
            }
            
            if(((this.Mediator.current.<Item>k__BackingField) & 1) == 0)
            {
                    return;
            }
        
        }
        public void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_3 = 1152921523922018592;
            if((this.<StaticMediator>k__BackingField.GetStaticItem(itemType:  3)) != null)
            {
                    return;
            }
            
            this.<StaticMediator>k__BackingField.ExplodeAllAboveItems(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            this.<StaticMediator>k__BackingField.ExplodeAllBelowItems(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public UnityEngine.Vector3 GetViewPosition()
        {
            return this.<CellView>k__BackingField.transform.position;
        }
        public void SwapStarted()
        {
            this.FreezeFall();
            Royal.Scenes.Game.Mechanics.Board.Cell.View.SwapParticles val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1).Spawn<Royal.Scenes.Game.Mechanics.Board.Cell.View.SwapParticles>(poolId:  1, activate:  true);
            UnityEngine.Vector3 val_4 = this.GetViewPosition();
            val_2.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.Play();
        }
        public void SwapEnded()
        {
            this.UnFreezeFall();
        }
        public bool CanEnterToMatch()
        {
            bool val_1 = this.<StaticMediator>k__BackingField.HasTouchBlockingItemExceptChain();
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public bool CanEnterPossibleMatch()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3;
            if((this.<Type>k__BackingField) == 1)
            {
                    val_3 = this.Mediator.current.<Item>k__BackingField;
                if(val_3 == null)
            {
                    return (bool)val_3 & 1;
            }
            
                val_3 = (this.<StaticMediator>k__BackingField.HasTouchBlockingItem()) ^ 1;
                return (bool)val_3 & 1;
            }
            
            val_3 = 0;
            return (bool)val_3 & 1;
        }
        public bool CanEnterPossibleMatchAcceptingChain()
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3;
            if((this.<Type>k__BackingField) == 1)
            {
                    val_3 = this.Mediator.current.<Item>k__BackingField;
                if(val_3 == null)
            {
                    return (bool)val_3 & 1;
            }
            
                val_3 = (this.<StaticMediator>k__BackingField.HasTouchBlockingItemExceptChain()) ^ 1;
                return (bool)val_3 & 1;
            }
            
            val_3 = 0;
            return (bool)val_3 & 1;
        }
        public bool CanReceiveGrass()
        {
            var val_2;
            if((this.<Type>k__BackingField) != 1)
            {
                goto label_0;
            }
            
            if((this.Mediator.current.<Item>k__BackingField) == null)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.CurrentItem;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel).__il2cppRuntimeField_3E0;
            label_0:
            val_2 = 0;
            return (bool)val_2;
            label_3:
            val_2 = 1;
            return (bool)val_2;
        }
        public void SetBottomCell(bool isBottom)
        {
            this.isBottomCell = isBottom;
        }
        public bool IsBottomCell()
        {
            return (bool)this.isBottomCell;
        }
        public void Reserve()
        {
            this.FreezeFall();
            this.reserve.Enable();
        }
        public void UnReserve()
        {
            this.UnFreezeFall();
            this.reserve.Disable();
        }
        public bool IsReserved()
        {
            if(this.reserve != null)
            {
                    return this.reserve.IsEnabled();
            }
            
            throw new NullReferenceException();
        }
        public bool IsBlockedByAnyDrill()
        {
            if(this.levelManager.IsThereDrillInLevel() == false)
            {
                    return false;
            }
            
            return Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31).IsBlockedByAnyActiveDrill(cellModel:  this);
        }
    
    }

}
