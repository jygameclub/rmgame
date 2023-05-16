using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.RemainingMoves
{
    public class RemainingMovesManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private bool <IsRemainingMovesActive>k__BackingField;
        private bool <IsTapToSkipClicked>k__BackingField;
        private System.Action OnTapToSkip;
        public Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.TapToSkip tapToSkip;
        private const float RemainingMoveCoinValue = 2.5;
        private const int DefaultInitialCoinAmount = 10;
        private const int HardInitialCoinAmount = 100;
        private const int SuperHardInitialCoinAmount = 150;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Player.Context.Data.Session.UserActiveLevelData activeLevelData;
        private Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer moveReplacer;
        private Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemExploder itemExploder;
        private Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialog remainingMovesDialog;
        private int extraCoinAmount;
        private System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinCollectAnimation> coinCollectAnimations;
        
        // Properties
        private bool IsRemainingMovesActive { get; set; }
        public bool IsTapToSkipClicked { get; set; }
        public int Id { get; }
        
        // Methods
        private bool get_IsRemainingMovesActive()
        {
            return (bool)this.<IsRemainingMovesActive>k__BackingField;
        }
        private void set_IsRemainingMovesActive(bool value)
        {
            this.<IsRemainingMovesActive>k__BackingField = value;
        }
        public bool get_IsTapToSkipClicked()
        {
            return (bool)this.<IsTapToSkipClicked>k__BackingField;
        }
        private void set_IsTapToSkipClicked(bool value)
        {
            this.<IsTapToSkipClicked>k__BackingField = value;
        }
        public void add_OnTapToSkip(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnTapToSkip, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTapToSkip != 1152921524007380520);
            
            return;
            label_2:
        }
        public void remove_OnTapToSkip(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnTapToSkip, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnTapToSkip != 1152921524007517096);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 33;
        }
        public void Bind()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.coinCollectAnimations = new System.Collections.Generic.List<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinCollectAnimation>();
            this.extraCoinAmount = 0;
            this.activeLevelData = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
        }
        public void CollectRemainingMovesCoin(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel specialItemModel)
        {
            if((this.<IsRemainingMovesActive>k__BackingField) == false)
            {
                    return;
            }
            
            int val_3 = this.extraCoinAmount;
            val_3 = val_3 + specialItemModel.remainingMoveCoins;
            this.extraCoinAmount = val_3;
            Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinCollectAnimation val_1 = new Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinCollectAnimation();
            UnityEngine.Vector3 val_2 = cell.GetViewPosition();
            val_1.Play(cellPoint:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X23, y = X23}, startPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, coinAmount:  specialItemModel.remainingMoveCoins);
            this.coinCollectAnimations.Add(item:  val_1);
        }
        public void Clear(bool gameExit)
        {
            this.coinCollectAnimations.Clear();
            this.<IsRemainingMovesActive>k__BackingField = false;
            this.<IsTapToSkipClicked>k__BackingField = false;
            this.OnTapToSkip = 0;
            this.itemExploder = 0;
            this.remainingMovesDialog = 0;
            this.moveReplacer = 0;
        }
        public void TriggerTapToSkipClick()
        {
            this.<IsTapToSkipClicked>k__BackingField = true;
            UnityEngine.Object.Destroy(obj:  this.tapToSkip.gameObject);
            this.tapToSkip = 0;
            if(this.OnTapToSkip != null)
            {
                    this.OnTapToSkip.Invoke();
            }
            
            this.OnTapToSkip = 0;
        }
        public bool ShouldSendMoves()
        {
            var val_3;
            if((this.<IsTapToSkipClicked>k__BackingField) != false)
            {
                    val_3 = 0;
                return (bool)(Royal.Player.Context.Data.Session.__il2cppRuntimeField_40 > 0) ? 1 : 0;
            }
            
            if(this.gridManager.HasAnySpecialItemOnBoard() == false)
            {
                    return (bool)(Royal.Player.Context.Data.Session.__il2cppRuntimeField_40 > 0) ? 1 : 0;
            }
            
            val_3 = 1;
            return (bool)(Royal.Player.Context.Data.Session.__il2cppRuntimeField_40 > 0) ? 1 : 0;
        }
        public void CompleteRemainingMovesImmediately()
        {
            this.<IsRemainingMovesActive>k__BackingField = true;
            if(this.activeLevelData.isBonus != true)
            {
                    int val_2 = this.GetInitialCoinAmount() + this.extraCoinAmount;
                this.extraCoinAmount = val_2;
                this.goalManager.ReplaceGoalsWithCoin(coinAmount:  val_2);
            }
            
            this.moveReplacer = new Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer();
            this.itemExploder = new Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemExploder();
            this.moveReplacer.SkipClickedImmediately();
            this.FlowCompleted();
        }
        public void StartRemainingMovesWithDialog(Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialog dialog)
        {
            this.<IsRemainingMovesActive>k__BackingField = true;
            this.itemFactory.itemCreator.RemainingMovesStarted();
            if(this.activeLevelData.isBonus != true)
            {
                    int val_2 = this.GetInitialCoinAmount() + this.extraCoinAmount;
                this.extraCoinAmount = val_2;
                this.goalManager.ReplaceGoalsWithCoin(coinAmount:  val_2);
            }
            
            this.remainingMovesDialog = dialog;
            this.moveReplacer = new Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer();
            this.itemExploder = new Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer();
            this.moveReplacer.SendMoves(startDelay:  0.3f, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager::ExplodeItemsOnBoard()));
            this.add_OnTapToSkip(value:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager::SkipClicked()));
        }
        private int GetInitialCoinAmount()
        {
            var val_3;
            if(this.activeLevelData.IsHard != false)
            {
                    var val_2 = (this.activeLevelData.difficulty == 1) ? 100 : 150;
                return 10;
            }
            
            val_3 = 10;
            return 10;
        }
        private void ExplodeItemsOnBoard()
        {
            this.itemExploder.ExplodeItemsOnBoard(onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager::FlowCompleted()));
        }
        private void FlowCompleted()
        {
            Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesDialog val_12;
            this.<IsRemainingMovesActive>k__BackingField = false;
            if(this.tapToSkip != 0)
            {
                    this.OnTapToSkip = 0;
                UnityEngine.Object.Destroy(obj:  this.tapToSkip.gameObject);
                this.tapToSkip = 0;
            }
            
            int val_13 = this.goalManager.GetGoalLeftCount(goalType:  21);
            if(this.activeLevelData.isBonus != false)
            {
                    int val_5 = val_13 - this.extraCoinAmount;
                val_5 = val_5 - this.activeLevelData.animationData.coin.GetCollectedAmount();
                if(val_5 >= 1)
            {
                    val_5 = this.extraCoinAmount + val_5;
                this.extraCoinAmount = val_5;
            }
            
            }
            
            int val_6 = this.moveReplacer.GetNotReplacedMovesCount();
            if(this.moveReplacer != null)
            {
                    float val_12 = (float)val_6;
                val_12 = val_12 * 2.5f;
                this.extraCoinAmount = (this.extraCoinAmount + UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished);
            }
            
            if(this.itemExploder != null)
            {
                    this.extraCoinAmount = this.itemExploder.CalculateExtraCoinAmountOnBoard() + this.extraCoinAmount;
            }
            
            this.activeLevelData.RemainingMovesEnd(notReplacedMoves:  val_6, extraCoins:  this.extraCoinAmount);
            this.levelManager.RemainingMovesEnd();
            val_12 = this.remainingMovesDialog;
            bool val_9 = UnityEngine.Object.op_Inequality(x:  val_12, y:  0);
            val_13 = this.activeLevelData.animationData.coin.GetCollectedAmount() - val_13;
            if(val_13 >= 1)
            {
                    do
            {
                this.goalManager.IncreaseGoal(goalType:  21);
                this.goalManager.IncreaseGoalUi(goalType:  21);
                val_12 = 0 + 1;
            }
            while(val_12 < val_13);
            
            }
            
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Explode.AutoExplodeManager>(contextId:  6).Disable();
        }
        public void SkipClicked()
        {
            this.moveReplacer.SkipClicked();
            this.itemExploder.SkipClicked();
            List.Enumerator<T> val_1 = this.coinCollectAnimations.GetEnumerator();
            label_6:
            if(((-2072366472) & 1) == 0)
            {
                goto label_4;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.TapToSkip();
            goto label_6;
            label_4:
            0.Dispose();
        }
        public RemainingMovesManager()
        {
        
        }
    
    }

}
