using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MailBoxItem
{
    public class MailBoxItemModel : ItemModel, IMailBoxItemViewDelegate, IItemViewDelegate, IGoalDependedExplodeTarget
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView itemView;
        private bool isActive;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override bool IsValidTarget { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 11;
        }
        public override bool get_IsValidTarget()
        {
            return (bool)this.isActive;
        }
        public MailBoxItemModel()
        {
            this.isActive = true;
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView val_1 = 23760.Spawn<Royal.Scenes.Game.Mechanics.Items.MailBoxItem.View.MailBoxItemView>(poolId:  48, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            add_OnGoalUpdated(value:  new System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.MailBoxItem.MailBoxItemModel::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int count)));
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return true;
        }
        public override bool IsFallable()
        {
            return false;
        }
        public override bool IsSwappable()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if((this.GetGoalUiLeftCount(goalType:  data.point.x)) < 1)
            {
                    return;
            }
            
            if(this.itemView.CanPlayCollectAnimation() == false)
            {
                    return;
            }
            
            this.itemView.Explode();
            this.stateManager.OperationStart(animationId:  5);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.MailBoxItem.MailBoxItemModel).__il2cppRuntimeField_3B0;
        }
        public void OnGoalReached()
        {
            this.stateManager.OperationFinish(animationId:  5);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.MailBoxItem.MailBoxItemModel).__il2cppRuntimeField_3C0;
        }
        private void OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int count)
        {
            if(count > 0)
            {
                    return;
            }
            
            if(true != goalType)
            {
                    return;
            }
            
            this.isActive = false;
            this.itemView.ChangeToDisabledView();
            goalType.remove_OnGoalUpdated(value:  new System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.MailBoxItem.MailBoxItemModel::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int count)));
        }
        public UnityEngine.Vector3 GetGoalPosition()
        {
            if(this != null)
            {
                    return this.GetGoalPosition(goalType:  null);
            }
            
            throw new NullReferenceException();
        }
        public override bool CanReceiveGrass()
        {
            return false;
        }
        public override void RecycleView()
        {
            remove_OnGoalUpdated(value:  new System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.MailBoxItem.MailBoxItemModel::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int count)));
            this.RecycleView();
        }
        public override int GetExplodeScore()
        {
            if(this.isActive == false)
            {
                    return 0;
            }
            
            return this.GetExplodeScore();
        }
        public override int RemainingExplodeCount()
        {
            var val_3;
            if(this.isActive != false)
            {
                    val_3 = (this.GetGoalLeftCount(goalType:  null)) - this.isActive.GetIncomingCount();
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
    
    }

}
