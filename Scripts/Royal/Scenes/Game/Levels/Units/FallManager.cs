using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class FallManager : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour
    {
        // Fields
        private const float ItemPositionDiffY = 1;
        private bool <IsAllItemsSteady>k__BackingField;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory factory;
        private readonly System.Collections.Generic.Stack<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> crossLeftVisitCells;
        private readonly System.Collections.Generic.Stack<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> crossRightVisitCells;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator verticalIterator;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator horizontalIterator;
        private bool enable;
        
        // Properties
        public int Id { get; }
        private bool IsAllItemsSteady { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 7;
        }
        private bool get_IsAllItemsSteady()
        {
            return (bool)this.<IsAllItemsSteady>k__BackingField;
        }
        private void set_IsAllItemsSteady(bool value)
        {
            this.<IsAllItemsSteady>k__BackingField = value;
        }
        public void Clear(bool gameExit)
        {
            this.crossLeftVisitCells.Clear();
            this.crossRightVisitCells.Clear();
        }
        public FallManager()
        {
            this.enable = true;
            this.crossLeftVisitCells = new System.Collections.Generic.Stack<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            this.crossRightVisitCells = new System.Collections.Generic.Stack<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
        }
        public void Bind()
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.factory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gridManager.add_OnCellGridInitialized(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.FallManager::GridManagerOnOnCellGridInitialized()));
        }
        private void GridManagerOnOnCellGridInitialized()
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_2;
            var val_3;
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_6;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = this.gridManager.GetIterator(iteratorType:  0);
            this.verticalIterator = val_2;
            mem[1152921523952793072] = val_3;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4 = this.gridManager.GetIterator(iteratorType:  1);
            mem[1152921523952793096] = val_5;
            this.horizontalIterator = val_6;
        }
        public void ManualUpdate()
        {
            if(this.enable != false)
            {
                    this.ClearTargetItems();
                this.CalculateStraightFalls();
                this.CalculateCrossFalls();
                this.CallFallUpdates();
                return;
            }
            
            this.gameState.OperationReset(animationId:  0);
        }
        public void Enable(bool enable)
        {
            this.enable = enable;
        }
        private void ClearTargetItems()
        {
            goto label_4;
            label_6:
            if((X21 + 32.HasTargetItem()) != false)
            {
                    if(X21.NextItem != X21.TargetItem)
            {
                    X21 + 32.ClearTargetItem();
            }
            
            }
            
            label_4:
            if(this.verticalIterator != 0)
            {
                goto label_6;
            }
        
        }
        private void CalculateStraightFalls()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel val_1 = 0;
            goto label_4;
            label_5:
            this.FindTargetItemOrFillingCell(cell:  X21, fillingCell: out  val_1);
            if(((X21 + 32.HasTargetItem()) != true) && (val_1 != 0))
            {
                    this.CreateItemFromFillingCell(fillingCell:  val_1, cell:  X21);
            }
            
            label_4:
            if(this.verticalIterator != 0)
            {
                goto label_5;
            }
        
        }
        private void CalculateCrossFalls()
        {
            goto label_5;
            label_6:
            if((X21.IsNormalCell() != false) && ((X21 + 80) != 0))
            {
                    if((X21 + 32.HasTargetItem()) != true)
            {
                    this.FindCrossItem(currentCell:  X21);
            }
            
            }
            
            label_5:
            if(this.verticalIterator != 0)
            {
                goto label_6;
            }
        
        }
        private void CallFallUpdates()
        {
            Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_7;
            this.gameState.OperationReset(animationId:  0);
            this.<IsAllItemsSteady>k__BackingField = true;
            if(this.horizontalIterator != 0)
            {
                    do
            {
                if((X21 + 32.HasTargetItem()) != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = X21 + 32.TargetItem;
                val_7 = val_2.fallComponent;
                var val_8 = 0;
                if(mem[1152921505110343680] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505110343688];
                val_9 = val_9 + 5;
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_3 = 1152921505110306816 + val_9;
            }
            
                val_7.ManualUpdate();
                var val_10 = 0;
                if(mem[1152921505110343680] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_4 = 1152921505110306816 + ((mem[1152921505110343688]) << 4);
            }
            
                this.<IsAllItemsSteady>k__BackingField = (((this.<IsAllItemsSteady>k__BackingField) == true) ? 1 : 0) & val_7.IsItemSteady();
            }
            
            }
            while(this.horizontalIterator != 0);
            
            }
            
            if((this.<IsAllItemsSteady>k__BackingField) != false)
            {
                    return;
            }
            
            this.gameState.OperationStart(animationId:  0);
        }
        private void CreateItemFromFillingCell(Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator val_7;
            var val_8;
            val_7 = this;
            bool val_1 = fillingCell.HasCreatedItem;
            if(val_1 != false)
            {
                    bool val_2 = val_1.SetTargetItem(item:  fillingCell.<LastCreatedItem>k__BackingField);
                return;
            }
            
            if(val_1.HasTargetItem() == true)
            {
                    return;
            }
            
            val_7 = this.factory.itemCreator;
            float val_7 = 1f;
            val_7 = (float)S8 + val_7;
            val_8 = 0;
            bool val_5 = this.factory.SetTargetItem(item:  val_7.CreateItemForFillingCellAt(fillingCell:  fillingCell, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}));
            var val_8 = 0;
            if(mem[1152921505110343680] != null)
            {
                    val_8 = val_8 + 1;
                val_8 = 6;
            }
            else
            {
                    var val_9 = mem[1152921505110343688];
                val_9 = val_9 + 6;
                Royal.Scenes.Game.Mechanics.Fall.IFallComponent val_6 = 1152921505110306816 + val_9;
            }
            
            val_4.fallComponent.SetFillingCell(fillingCell:  fillingCell);
        }
        private void FindTargetItemOrFillingCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, out Royal.Scenes.Game.Mechanics.Board.Cell.FillingCellModel fillingCell)
        {
            var val_18;
            var val_19;
            cell = 0;
            fillingCell = 0;
            if(16183.HasTargetItem() == true)
            {
                    return;
            }
            
            bool val_2 = cell.IsFallBlocked();
            if(val_2 != false)
            {
                    return;
            }
            
            if((val_2.GetNextItemOfCell(fromCell:  cell, toCell:  cell)) == null)
            {
                goto label_5;
            }
            
            label_26:
            bool val_5 = cell.SetTargetItem(item:  cell.NextItem);
            return;
            label_5:
            if(cell.IsFallFrozen() == true)
            {
                    return;
            }
            
            if(cell.IsFillingCell() != false)
            {
                    fillingCell = cell;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_9 = cell.Get(type:  1);
            if(val_9 == null)
            {
                goto label_18;
            }
            
            label_22:
            if(val_9.IsFallFrozen() == true)
            {
                    return;
            }
            
            val_18 = val_9;
            if(val_18.IsNormalCell() != false)
            {
                    val_18 = cell;
                bool val_12 = val_18.IsBlankCell();
                if(val_12 == true)
            {
                    return;
            }
            
            }
            
            bool val_13 = val_12.IsFallPossibleFromCellToCell(fromCell:  val_9, toCell:  cell);
            if(val_13 == false)
            {
                goto label_18;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_14 = val_13.GetNextItemOfCell(fromCell:  val_9, toCell:  cell);
            val_19 = val_14;
            if(val_14 != null)
            {
                goto label_19;
            }
            
            bool val_15 = val_9.IsFillingCell();
            if(val_15 == true)
            {
                goto label_20;
            }
            
            if((val_15.Get(type:  1)) != null)
            {
                goto label_22;
            }
            
            label_18:
            cell = 1;
            return;
            label_19:
            if(val_14 != null)
            {
                goto label_26;
            }
            
            throw new NullReferenceException();
            label_20:
            val_19 = null;
            fillingCell = val_9;
            val_19 = null;
            SetCellAsTarget(targetCell:  cell);
        }
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel GetNextItemOfCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            if(X19.HasNextItem() == false)
            {
                    return 0;
            }
            
            if((X19.NextItem & 1) == 0)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = X19.NextItem;
            if(val_3.itemMediator.HasTargetCell() == false)
            {
                    return X19.NextItem;
            }
            
            if(val_3.itemMediator.TargetCell == fromCell)
            {
                    return X19.NextItem;
            }
            
            return 0;
        }
        private bool IsFallPossibleFromCellToCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel fromCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel toCell)
        {
            var val_8;
            var val_9;
            val_8 = toCell;
            bool val_1 = fromCell.IsFallBlocked();
            if(val_1 != false)
            {
                    val_9 = 0;
                return (bool)val_9;
            }
            
            bool val_2 = val_1.HasCurrentItem();
            if(val_2 != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.CurrentItem;
                val_8 = ???;
            }
            else
            {
                    val_9 = 1;
                return (bool)val_9;
            }
        
        }
        private void FindCrossItem(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell)
        {
            this.crossLeftVisitCells.Clear();
            this.crossRightVisitCells.Clear();
            if(currentCell != null)
            {
                    label_9:
                bool val_1 = currentCell.IsFallFrozen();
                if((val_1 != true) && ((val_1.IsFallPossibleFromCellToCell(fromCell:  currentCell, toCell:  0)) != false))
            {
                    if(currentCell.IsBlankCell() != true)
            {
                    this.AddToCrossVisitCells(cell:  currentCell, continueLooking: ref  true, neighborType:  3);
                this.AddToCrossVisitCells(cell:  currentCell, continueLooking: ref  true, neighborType:  7);
            }
            
                if((this.Get(type:  1)) != null)
            {
                    if(1 != 255)
            {
                goto label_9;
            }
            
            }
            
            }
            
            }
            
            this.FindCrossItemInLeftOrRightColumn(targetCell:  currentCell);
        }
        private void AddToCrossVisitCells(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, ref bool continueLooking, int neighborType)
        {
            if(continueLooking == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 16176.Get(type:  neighborType);
            if(val_1 != null)
            {
                    if(val_1.IsFallFrozen() != false)
            {
                    continueLooking = false;
                return;
            }
            
            }
            
            if(neighborType != 3)
            {
                goto label_6;
            }
            
            if(this.crossRightVisitCells != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_6:
            label_7:
            this.crossLeftVisitCells.Push(item:  cell);
        }
        private void FindCrossItemInLeftOrRightColumn(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel targetCell)
        {
            var val_7;
            label_10:
            if(true <= 0)
            {
                goto label_2;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.crossLeftVisitCells.Pop();
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = val_1.FindTargetItemFromCrossCell(targetCell:  targetCell, visitingCell:  val_1, neighborType:  0);
            val_7 = val_2;
            if((val_2 == null) || ((val_7 & 1) != 0))
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            if(this.crossRightVisitCells <= 0)
            {
                    return;
            }
            
            val_7 = 0;
            label_4:
            if(this.crossRightVisitCells >= 1)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_3 = this.crossRightVisitCells.Pop();
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_3.FindTargetItemFromCrossCell(targetCell:  targetCell, visitingCell:  val_3, neighborType:  2);
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_5 = (val_4 == 0) ? (val_7) : (val_4);
            }
            
            if(val_5 == 0)
            {
                goto label_10;
            }
            
            label_5:
            bool val_6 = val_4.SetTargetItem(item:  val_5);
        }
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemModel FindTargetItemFromCrossCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel targetCell, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel visitingCell, int neighborType)
        {
            var val_15;
            int val_16;
            var val_17;
            var val_18;
            val_15 = mem[X8 + 32];
            val_15 = X8 + 32;
            val_16 = neighborType;
            if(val_15 == 0)
            {
                goto label_11;
            }
            
            if((X8 + 32 + 32.TargetItem) != null)
            {
                    val_17 = val_1.itemMediator.NextCell;
            }
            else
            {
                    val_17 = 0;
            }
            
            if((X8 + 32 + 32.TargetItem) != null)
            {
                    val_18 = val_3.itemMediator.CurrentCell;
            }
            else
            {
                    val_18 = 0;
            }
            
            if(val_15.IsBlankCell() == true)
            {
                goto label_11;
            }
            
            bool val_6 = val_15.IsFallBlocked();
            if(val_6 == false)
            {
                goto label_12;
            }
            
            label_11:
            label_35:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_7 = val_6.Get(type:  val_16);
            if(val_7 == null)
            {
                    return 0;
            }
            
            val_16 = val_7;
            bool val_8 = val_7.HasCurrentItem();
            if(val_8 == false)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_9 = val_8.CurrentItem;
            if((val_9 & 1) == 0)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_10 = val_9.CurrentItem;
            if((val_10 & 1) == 0)
            {
                    return 0;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11 = val_10.CurrentItem;
            if(val_11.itemMediator.HasTargetCell() == false)
            {
                    return val_14.CurrentItem;
            }
            
            val_15 = val_11.itemMediator.TargetCell;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_14 = val_11.itemMediator.CurrentCell;
            if(val_15 != val_14)
            {
                    return 0;
            }
            
            return val_14.CurrentItem;
            label_12:
            if(val_17 != 0)
            {
                    if(0 < W9)
            {
                goto label_35;
            }
            
            }
            
            if(val_18 == 0)
            {
                    return 0;
            }
            
            if(0 < W9)
            {
                goto label_35;
            }
            
            return 0;
        }
    
    }

}
