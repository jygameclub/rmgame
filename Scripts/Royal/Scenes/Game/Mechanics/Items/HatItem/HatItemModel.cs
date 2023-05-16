using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.HatItem
{
    public class HatItemModel : ItemModel, IHatItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView itemView;
        private Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper hatItemHelper;
        private bool isThrowing;
        private bool isInThrowIdle;
        private bool isActive;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override bool IsValidTarget { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 22;
        }
        public override bool get_IsValidTarget()
        {
            if(this.isActive == false)
            {
                    return false;
            }
            
            return (bool)(this.isThrowing == false) ? 1 : 0;
        }
        public HatItemModel()
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView val_1 = 18644.Spawn<Royal.Scenes.Game.Mechanics.Items.HatItem.View.HatItemView>(poolId:  83, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.isActive = true;
            this.isThrowing = false;
            Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27);
            this.hatItemHelper = val_2;
            val_2.Register(hatModel:  this);
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
                    mem[1152921520287154736] = val_1;
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
                mem[1152921520287295360] = 3;
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
            return (System.Collections.IEnumerator)new HatItemModel.<Throw>d__20();
        }
        public override int GetExplodeScore()
        {
            if(this.isActive == false)
            {
                    return 0;
            }
            
            if(this.hatItemHelper.purpleOnBoard >= this.hatItemHelper.GetPurpleGoal())
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
                    return Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.HatItem.HatItemHelper>(contextId:  27).FindItemReadyToExplode(itemModel:  this);
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemModel)this;
        }
    
    }

}
