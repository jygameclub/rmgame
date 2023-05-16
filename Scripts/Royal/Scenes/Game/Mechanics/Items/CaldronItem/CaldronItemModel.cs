using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CaldronItem
{
    public class CaldronItemModel : ItemModel, ICaldronItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView itemView;
        private Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemHelper caldronItemHelper;
        private bool isThrowing;
        private bool isInThrowIdle;
        private bool isActive;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override bool IsValidTarget { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 35;
        }
        public override bool get_IsValidTarget()
        {
            if(this.isActive == false)
            {
                    return false;
            }
            
            return (bool)(this.isThrowing == false) ? 1 : 0;
        }
        public CaldronItemModel()
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView val_1 = 7084.Spawn<Royal.Scenes.Game.Mechanics.Items.CaldronItem.View.CaldronItemView>(poolId:  122, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.HasView = true;
            this.isActive = true;
            this.isThrowing = false;
            Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemHelper>(contextId:  38);
            this.caldronItemHelper = val_2;
            val_2.Register(caldronItemModel:  this);
        }
        public void Close()
        {
            if(this.isActive == false)
            {
                    return;
            }
            
            this.isActive = false;
            if(this.isInThrowIdle == false)
            {
                goto label_1;
            }
            
            label_3:
            if(this.itemView == null)
            {
                goto label_2;
            }
            
            this.itemView.ChangeToDisabledView();
            return;
            label_1:
            if(this.isThrowing == false)
            {
                goto label_3;
            }
            
            return;
            label_2:
            throw new NullReferenceException();
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
        public override bool CanReceiveGrass()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(this.isThrowing != false)
            {
                    return;
            }
            
            if(this.isActive == false)
            {
                    return;
            }
            
            bool val_1 = this.isActive - 1;
            if()
            {
                    mem[1152921523825460816] = val_1;
                this.itemView.Damage(layer:  val_1);
            }
            
            if(this.isActive == true)
            {
                    return;
            }
            
            this.isThrowing = true;
            UnityEngine.Coroutine val_3 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.Throw());
        }
        public void ResetLayer()
        {
            if(this.isActive != false)
            {
                    this.isThrowing = false;
                mem[1152921523825601440] = 3;
                return;
            }
            
            if(this.itemView != null)
            {
                    this.itemView.ChangeToDisabledView();
                return;
            }
            
            throw new NullReferenceException();
        }
        public int GetLayer()
        {
            return (int)this;
        }
        private System.Collections.IEnumerator Throw()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new CaldronItemModel.<Throw>d__20();
        }
        public override int GetExplodeScore()
        {
            if(this.isActive == false)
            {
                    return 0;
            }
            
            if(this.caldronItemHelper.throwItemOnBoard >= this.caldronItemHelper.GetThrowItemGoal())
            {
                    return 0;
            }
            
            return this.GetExplodeScore();
        }
        public override bool ShouldTryRedirectForPropeller()
        {
            return true;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemModel TryRedirectForPropeller()
        {
            if(true != 1)
            {
                    return Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CaldronItem.CaldronItemHelper>(contextId:  38).FindItemReadyToExplode(itemModel:  this);
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this;
        }
    
    }

}
