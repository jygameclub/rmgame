using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem
{
    public class PropellerItemModel : SpecialItemModel, IPropellerItemViewDelegate, IItemViewDelegate, IGuidedExploder
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Explode.ExplodeData <TargetExplodeData>k__BackingField;
        private Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget <TargetItem>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView <ItemView>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy strategy;
        private readonly Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder explodeTargetFinder;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel lastValidCell;
        private UnityEngine.Vector3 lastValidTargetPosition;
        private bool stoppedLookingForNewTargets;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private readonly Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper curtainHelper;
        private readonly Royal.Player.Context.Units.LevelManager levelManager;
        private bool invalidateTarget;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Explode.ExplodeData TargetExplodeData { get; set; }
        public Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget TargetItem { get; set; }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView ItemView { get; set; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Explode.ExplodeData get_TargetExplodeData()
        {
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_0;
            val_0.id = ;
            val_0.point.x = this.<TargetExplodeData>k__BackingField;
            return val_0;
        }
        private void set_TargetExplodeData(Royal.Scenes.Game.Mechanics.Explode.ExplodeData value)
        {
            mem[1152921520099900832] = value.id;
            this.<TargetExplodeData>k__BackingField = value.point.x;
        }
        public Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget get_TargetItem()
        {
            return (Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget)this.<TargetItem>k__BackingField;
        }
        public void set_TargetItem(Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget value)
        {
            this.<TargetItem>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 3;
        }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType()
        {
            return 1;
        }
        public PropellerItemModel(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy strategy)
        {
            mem[1152921520100751313] = 1;
            this = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel(layer:  1);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.explodeTargetFinder = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Explode.ExplodeTargetFinder>(contextId:  12);
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.curtainHelper = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26);
            this.strategy = strategy;
            mem[1152921520100751320] = 1;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView val_1 = 28116.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView>(poolId:  9, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel).__il2cppRuntimeField_1E0;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.<ItemView>k__BackingField;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_9;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_10;
            var val_15;
            Royal.Scenes.Game.Mechanics.Explode.Trigger val_17;
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper val_19;
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  33)) != false)
            {
                    val_15 = this;
                Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33).CollectRemainingMovesCoin(cell:  CurrentCell, specialItemModel:  this);
            }
            else
            {
                    val_15 = 1152921520101297504;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = 1152921505091031040.CurrentCell;
            var val_17 = 0;
            if(mem[1152921505091760128] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_5 = 1152921505091723264 + ((mem[1152921505091760136]) << 4);
            }
            
            val_17 = -1685382640;
            var val_18 = 0;
            if(mem[1152921505091760128] != null)
            {
                    val_18 = val_18 + 1;
                val_17 = 1;
            }
            else
            {
                    var val_19 = mem[1152921505091760136];
                val_19 = val_19 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_7 = 1152921505091723264 + val_19;
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_8 = this.strategy.NextExploder(cell:  val_4);
            val_19 = this.curtainHelper;
            mem[1152921520101297632] = val_9;
            this.<TargetExplodeData>k__BackingField = val_10;
            val_19.add_OnCurtainReveal(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel::ForceTargetChange()));
            if(this.levelManager.IsThereDrillInLevel() != false)
            {
                    val_19 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31);
                val_19.add_OnDrillActivated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel::ForceTargetIfCellWillBeDestroyed()));
            }
            
            this.FindTarget(shouldPlayParticles:  this.strategy.ExplodeNeighbors(cell:  val_4, trigger:  val_17, propellerItemModel:  this));
            if(this.CurrentCell == null)
            {
                    return;
            }
        
        }
        private void ForceTargetIfCellWillBeDestroyed()
        {
            if(this.lastValidCell == null)
            {
                    return;
            }
            
            if(this.lastValidCell.IsBlockedByAnyDrill() == false)
            {
                    return;
            }
            
            this.invalidateTarget = true;
            this.stoppedLookingForNewTargets = false;
        }
        public void ForceTargetChange()
        {
            this.invalidateTarget = true;
            this.stoppedLookingForNewTargets = false;
        }
        private void FindTarget(bool shouldPlayParticles)
        {
            this.explodeTargetFinder.FindForExploder(exploder:  this);
            if((this.<TargetItem>k__BackingField) == null)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            if(mem[1152921505091760128] == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            goto label_7;
            label_2:
            this.<ItemView>k__BackingField.ExplodeSelf(isPropRocketCombo:  false);
            return;
            label_5:
            var val_5 = mem[1152921505091760136];
            val_5 = val_5 + 5;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_1 = 1152921505091723264 + val_5;
            label_7:
            this.strategy.OnTargetFound();
            this.<ItemView>k__BackingField.MoveToTarget(shouldPlayParticles:  shouldPlayParticles, targetReached:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel::TargetReached()));
        }
        private void TargetReached()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_13;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_15;
            this.curtainHelper.remove_OnCurtainReveal(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel::ForceTargetChange()));
            if(this.levelManager.IsThereDrillInLevel() != false)
            {
                    Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31).remove_OnDrillActivated(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel::ForceTargetIfCellWillBeDestroyed()));
            }
            
            var val_12 = 0;
            if(mem[1152921505121099776] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505121099784];
                val_13 = val_13 + 4;
                Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_5 = 1152921505121062912 + val_13;
            }
            
            this.<TargetItem>k__BackingField.RemoveIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<TargetExplodeData>k__BackingField, y = this.<TargetExplodeData>k__BackingField}, trigger = this.<TargetExplodeData>k__BackingField, id = 1152921520101268352});
            var val_14 = 0;
            if(mem[1152921505121099776] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_6 = 1152921505121062912 + ((mem[1152921505121099784]) << 4);
            }
            
            if((this.<TargetItem>k__BackingField.IsValidTarget) == false)
            {
                goto label_15;
            }
            
            var val_15 = 0;
            if(mem[1152921505121099776] == null)
            {
                goto label_18;
            }
            
            val_15 = val_15 + 1;
            goto label_20;
            label_15:
            val_13 = this.lastValidCell;
            var val_16 = 0;
            if(mem[1152921505091760128] == null)
            {
                goto label_23;
            }
            
            val_16 = val_16 + 1;
            goto label_25;
            label_18:
            var val_17 = mem[1152921505121099784];
            val_17 = val_17 + 1;
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_8 = 1152921505121062912 + val_17;
            label_20:
            val_13 = this.<TargetItem>k__BackingField.CurrentCell;
            var val_18 = 0;
            if(mem[1152921505091760128] == null)
            {
                goto label_28;
            }
            
            val_18 = val_18 + 1;
            goto label_30;
            label_23:
            var val_19 = mem[1152921505091760136];
            val_19 = val_19 + 2;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_10 = 1152921505091723264 + val_19;
            label_25:
            val_15 = this.<TargetExplodeData>k__BackingField.matchType;
            goto label_31;
            label_28:
            var val_20 = mem[1152921505091760136];
            val_20 = val_20 + 2;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_11 = 1152921505091723264 + val_20;
            label_30:
            val_15 = this.<TargetExplodeData>k__BackingField.matchType;
            label_31:
            this.strategy.OnTargetReached(cell:  val_13, exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<TargetExplodeData>k__BackingField.point, y = this.<TargetExplodeData>k__BackingField.point}, trigger = this.<TargetExplodeData>k__BackingField.point, id = val_15});
            this.gameState.OperationFinish(animationId:  3);
            this.gameState.FinishSpecialOperation();
        }
        public void TargetFound(Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget targetItem)
        {
            this.<TargetItem>k__BackingField = targetItem;
            if(targetItem == null)
            {
                    return;
            }
            
            this.gameState.OperationStart(animationId:  3);
            this.gameState.StartSpecialOperation();
        }
        public override void SwapWith(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public override bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            return true;
        }
        public bool IsTargetValid()
        {
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_12;
            var val_13 = 0;
            if(mem[1152921505121099776] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_1 = 1152921505121062912 + ((mem[1152921505121099784]) << 4);
            }
            
            if((this.<TargetItem>k__BackingField.IsValidTarget) != false)
            {
                    if(this.invalidateTarget == false)
            {
                goto label_7;
            }
            
            }
            
            this.invalidateTarget = false;
            if(this.stoppedLookingForNewTargets == false)
            {
                    return this.FindNewTarget();
            }
            
            if(((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  23)) == false) || ((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdItem.BirdItemHelper>(contextId:  23).IsThereAnyBirdOnBoard()) == false))
            {
                goto label_13;
            }
            
            val_12 = this.lastValidCell;
            if(val_12 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = val_12.NextItem;
            }
            
            if(X0 == false)
            {
                goto label_13;
            }
            
            label_21:
            this.<TargetItem>k__BackingField = 0;
            return this.FindNewTarget();
            label_13:
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  34)) == false)
            {
                    return true;
            }
            
            if((Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.FrogItem.FrogItemHelper>(contextId:  34).IsThereAnyFrogOnBoard()) == false)
            {
                    return true;
            }
            
            if(this.lastValidCell == null)
            {
                    return true;
            }
            
            if(this.lastValidCell.NextItem == null)
            {
                    return true;
            }
            
            goto label_21;
            label_7:
            var val_14 = 0;
            if(mem[1152921505121099776] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    var val_15 = mem[1152921505121099784];
                val_15 = val_15 + 1;
                Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_11 = 1152921505121062912 + val_15;
            }
            
            this.lastValidCell = this.<TargetItem>k__BackingField.CurrentCell;
            return true;
        }
        private bool FindNewTarget()
        {
            var val_5;
            bool val_9;
            val_5 = this;
            this.stoppedLookingForNewTargets = false;
            this.gameState.OperationFinish(animationId:  3);
            this.gameState.FinishSpecialOperation();
            var val_5 = 0;
            if(mem[1152921505091760128] != null)
            {
                    val_5 = val_5 + 1;
            }
            else
            {
                    var val_6 = mem[1152921505091760136];
                val_6 = val_6 + 6;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_1 = 1152921505091723264 + val_6;
            }
            
            this.strategy.OnTargetCancelled();
            if((this.<TargetItem>k__BackingField) != null)
            {
                    var val_7 = 0;
                if(mem[1152921505121099776] != null)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    var val_8 = mem[1152921505121099784];
                val_8 = val_8 + 4;
                Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_2 = 1152921505121062912 + val_8;
            }
            
                this.<TargetItem>k__BackingField.RemoveIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.<TargetExplodeData>k__BackingField, y = this.<TargetExplodeData>k__BackingField}, trigger = this.<TargetExplodeData>k__BackingField, id = public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy::OnTargetCancelled()});
            }
            
            this.FindTarget(shouldPlayParticles:  false);
            if((this.<TargetItem>k__BackingField) == null)
            {
                goto label_13;
            }
            
            var val_9 = 0;
            if(mem[1152921505121099776] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_3 = 1152921505121062912 + ((mem[1152921505121099784]) << 4);
            }
            
            if((this.<TargetItem>k__BackingField.IsValidTarget) == false)
            {
                goto label_18;
            }
            
            label_13:
            this.<ItemView>k__BackingField.CancelMove();
            val_9 = 0;
            return val_9;
            label_18:
            val_9 = true;
            this.stoppedLookingForNewTargets = val_9;
            return val_9;
        }
        public UnityEngine.Vector3 GetTargetPosition()
        {
            var val_8;
            var val_7 = 0;
            if(mem[1152921505121099776] != 35094320)
            {
                    val_7 = val_7 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_1 = 1152921505121062912 + ((mem[1152921505121099784]) << 4);
            }
            
            if(((this.<TargetItem>k__BackingField) & 1) == 0)
            {
                    return new UnityEngine.Vector3() {x = this.lastValidTargetPosition};
            }
            
            var val_8 = 0;
            if(mem[1152921505091760128] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505091760136];
                val_9 = val_9 + 4;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_2 = 1152921505091723264 + val_9;
            }
            
            bool val_3 = this.strategy.IsTntOrRocketCombo();
            if(val_3 == false)
            {
                goto label_13;
            }
            
            var val_10 = 0;
            if(mem[1152921505121099776] == 35094320)
            {
                goto label_15;
            }
            
            val_10 = val_10 + 1;
            goto label_17;
            label_13:
            var val_11 = 0;
            if(mem[1152921505121099776] == 35094320)
            {
                goto label_19;
            }
            
            val_11 = val_11 + 1;
            goto label_21;
            label_15:
            var val_12 = mem[1152921505121099784];
            val_12 = val_12 + 2;
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_5 = 1152921505121062912 + val_12;
            label_17:
            if(((val_3 != true) ? (this) : 0) != 0)
            {
                goto label_22;
            }
            
            label_19:
            var val_13 = mem[1152921505121099784];
            val_13 = val_13 + 3;
            Royal.Scenes.Game.Levels.Units.Explode.IExplodeTarget val_6 = 1152921505121062912 + val_13;
            label_21:
            val_8 = this;
            label_22:
            this.lastValidTargetPosition = new UnityEngine.Vector3();
            mem[1152921520102861220] = ???;
            mem[1152921520102861224] = ???;
            return new UnityEngine.Vector3() {x = this.lastValidTargetPosition};
        }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.IPropellerPilot GetNewPilot()
        {
            var val_2 = 0;
            if(mem[1152921505091760128] != null)
            {
                    val_2 = val_2 + 1;
                return this.strategy.GetNewPilot();
            }
            
            var val_3 = mem[1152921505091760136];
            val_3 = val_3 + 3;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy val_1 = 1152921505091723264 + val_3;
            return this.strategy.GetNewPilot();
        }
        public void UpdateStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.Strategy.IPropellerStrategy strategy)
        {
            this.strategy = strategy;
        }
    
    }

}
