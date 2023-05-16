using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.Config
{
    public abstract class StaticItemModel : IExplodeTarget
    {
        // Fields
        private const float AutoExplodeDisableDuration = 0.4;
        private bool <HasView>k__BackingField;
        private readonly Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType <StaticItemType>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Goal.GoalType <GoalType>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Board.Cell.CellModel <CurrentCell>k__BackingField;
        public readonly Royal.Scenes.Game.Mechanics.Explode.IncomingExploderContainer incomingContainer;
        protected readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        protected int layer;
        private readonly Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        
        // Properties
        public bool HasView { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType StaticItemType { get; }
        public Royal.Scenes.Game.Mechanics.Goal.GoalType GoalType { get; set; }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel CurrentCell { get; set; }
        public virtual bool IsValidTarget { get; }
        
        // Methods
        public bool get_HasView()
        {
            return (bool)this.<HasView>k__BackingField;
        }
        protected void set_HasView(bool value)
        {
            this.<HasView>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType get_StaticItemType()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType)this.<StaticItemType>k__BackingField;
        }
        public Royal.Scenes.Game.Mechanics.Goal.GoalType get_GoalType()
        {
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)this.<GoalType>k__BackingField;
        }
        public void set_GoalType(Royal.Scenes.Game.Mechanics.Goal.GoalType value)
        {
            this.<GoalType>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel get_CurrentCell()
        {
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)this.<CurrentCell>k__BackingField;
        }
        public void set_CurrentCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel value)
        {
            this.<CurrentCell>k__BackingField = value;
        }
        public virtual bool get_IsValidTarget()
        {
            return (bool)this.<HasView>k__BackingField;
        }
        protected StaticItemModel(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType, int layer = 1)
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.<StaticItemType>k__BackingField = itemType;
            this.layer = layer;
            this.incomingContainer = new Royal.Scenes.Game.Mechanics.Explode.IncomingExploderContainer();
        }
        public abstract void CreateView(UnityEngine.Vector3 position); // 0
        public abstract Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView GetItemView(); // 0
        protected abstract void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data); // 0
        public virtual void PlayInvalidMoveAnimation()
        {
        
        }
        public virtual bool DoesBlockTouch()
        {
            return false;
        }
        public virtual bool DoesBlockPropeller()
        {
            return false;
        }
        public virtual bool DoesBlockFall()
        {
            return false;
        }
        public virtual bool DoesBlockVisibility()
        {
            return false;
        }
        public virtual int GetExplodeScore()
        {
            return (int)((this.<StaticItemType>k__BackingField) > 2) ? (((this.<StaticItemType>k__BackingField) == 4) ? 1000 : 0) : 1000;
        }
        public virtual bool ShouldAddToGoalOnStart()
        {
            return true;
        }
        public virtual void Explode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public virtual void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_3;
            if(this.layer == 1)
            {
                    val_3 = data.id;
                return;
            }
            
            if(this.layer < 2)
            {
                    return;
            }
            
            this.layer = 1;
            val_3 = data.id;
        }
        public int GetLayer()
        {
            return (int)this.layer;
        }
        public UnityEngine.Vector3 GetViewPosition()
        {
            if((this.<CurrentCell>k__BackingField) != null)
            {
                    return this.<CurrentCell>k__BackingField.GetViewPosition();
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            if((this.<CurrentCell>k__BackingField) != null)
            {
                    return this.<CurrentCell>k__BackingField.GetViewPosition();
            }
            
            throw new NullReferenceException();
        }
        protected void FinalExplodeCompleted()
        {
            this.<CurrentCell>k__BackingField.<StaticMediator>k__BackingField.ClearStaticItem(itemType:  this.<StaticItemType>k__BackingField);
            this.<HasView>k__BackingField = false;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel).__il2cppRuntimeField_290;
        }
        protected virtual void CollectAsGoal()
        {
            this.goalManager.DecreaseGoal(goalType:  this.<GoalType>k__BackingField);
            this.goalManager.DecreaseGoalUi(goalType:  this.<GoalType>k__BackingField);
        }
        public void DisableAutoExplodeTemporarily()
        {
            if((this.<CurrentCell>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<CurrentCell>k__BackingField.Mediator.HasCurrentItem()) == false)
            {
                    return;
            }
            
            if((this.<CurrentCell>k__BackingField.Mediator.CurrentItem) == null)
            {
                    return;
            }
        
        }
        private System.Collections.IEnumerator DisableAndEnableAutoExplode(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel, float duration)
        {
            .<>1__state = 0;
            .itemModel = itemModel;
            .duration = duration;
            return (System.Collections.IEnumerator)new StaticItemModel.<DisableAndEnableAutoExplode>d__41();
        }
        public int RemainingExplodeCount()
        {
            int val_1 = this.incomingContainer.GetIncomingCount();
            val_1 = this.layer - val_1;
            return (int)val_1;
        }
        public virtual void AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this.incomingContainer != null)
            {
                    this.incomingContainer.AddToIncoming(id:  268435460);
                return;
            }
            
            throw new NullReferenceException();
        }
        public virtual void RemoveIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this.incomingContainer != null)
            {
                    this.incomingContainer.RemoveFromIncoming(id:  268435460);
                return;
            }
            
            throw new NullReferenceException();
        }
        public virtual bool CanSelectByBooster()
        {
            return true;
        }
        public virtual bool CanExplodeWithNearMatch()
        {
            return true;
        }
    
    }

}
