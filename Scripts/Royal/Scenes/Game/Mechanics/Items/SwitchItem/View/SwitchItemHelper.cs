using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SwitchItem.View
{
    public class SwitchItemHelper : IGameContextBehaviour, IGameContextUnit, IContextUnit, IContextBehaviour, ILateContextUnit
    {
        // Fields
        private bool waitingToSwitch;
        private float timeWithoutOperation;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private readonly float operationlessTimeThreshold;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SwitchItem.SwitchItemModel> switches;
        private readonly int[] waitingOperations;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 37;
        }
        public void Bind()
        {
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            Royal.Scenes.Game.Levels.Units.MoveManager val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.moveManager = val_2;
            val_2.remove_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemHelper::PrepareForSwitch(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
            this.moveManager.add_OnMoveCompleted(value:  new System.Action<Royal.Scenes.Game.Levels.Units.Touch.MoveType>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.SwitchItem.View.SwitchItemHelper::PrepareForSwitch(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)));
        }
        public void Clear(bool gameExit)
        {
            this.waitingToSwitch = false;
            this.timeWithoutOperation = 0f;
            this.switches.Clear();
        }
        private void PrepareForSwitch(Royal.Scenes.Game.Levels.Units.Touch.MoveType moveType)
        {
            if((Royal.Scenes.Game.Levels.Units.Touch.MoveTypeExtensions.IsLightBulbMove(moveType:  moveType)) == false)
            {
                    return;
            }
            
            this.waitingToSwitch = true;
        }
        public void AddSwitch(Royal.Scenes.Game.Mechanics.Items.SwitchItem.SwitchItemModel switchItem)
        {
            this.switches.Add(item:  switchItem);
        }
        public void RemoveSwitch(Royal.Scenes.Game.Mechanics.Items.SwitchItem.SwitchItemModel switchItem)
        {
            bool val_1 = this.switches.Remove(item:  switchItem);
        }
        private bool HasWaitingOperation()
        {
            var val_2;
            var val_3;
            int val_2 = this.waitingOperations.Length;
            if(val_2 < 1)
            {
                goto label_1;
            }
            
            val_2 = 0;
            val_2 = val_2 & 4294967295;
            label_5:
            if((this.stateManager.HasOperation(animationId:  -704739328)) == true)
            {
                goto label_4;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (this.waitingOperations.Length << ))
            {
                goto label_5;
            }
            
            label_1:
            val_3 = 0;
            return (bool)val_3;
            label_4:
            val_3 = 1;
            return (bool)val_3;
        }
        public void ManualUpdate()
        {
            float val_6;
            if(this.waitingToSwitch == false)
            {
                    return;
            }
            
            int val_6 = this.stateManager.ongoingSpecialOperationCount;
            val_6 = 0f;
            if(val_6 <= 0)
            {
                    val_6 = this.timeWithoutOperation + UnityEngine.Time.deltaTime;
            }
            
            this.timeWithoutOperation = val_6;
            if(val_6 <= this.operationlessTimeThreshold)
            {
                    return;
            }
            
            var val_7 = 0;
            label_13:
            if(val_7 >= val_6)
            {
                goto label_6;
            }
            
            if(val_6 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(((this.stateManager.ongoingSpecialOperationCount + 0) + 32.CurrentCell) != null)
            {
                    if(((this.stateManager.ongoingSpecialOperationCount + 0) + 32.CurrentCell.HasFallBlockingItem()) != true)
            {
                    (this.stateManager.ongoingSpecialOperationCount + 0) + 32.SetState(state:  (((this.stateManager.ongoingSpecialOperationCount + 0) + 32 + 136) == 0) ? 1 : 0);
            }
            
            }
            
            val_7 = val_7 + 1;
            if(this.switches != null)
            {
                goto label_13;
            }
            
            throw new NullReferenceException();
            label_6:
            this.timeWithoutOperation = 0f;
            this.waitingToSwitch = false;
        }
        public SwitchItemHelper()
        {
            this.operationlessTimeThreshold = 0.02f;
            this.switches = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.SwitchItem.SwitchItemModel>(capacity:  20);
            this.waitingOperations = new int[3] {3, 4, 9};
        }
    
    }

}
