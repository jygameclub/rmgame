using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem
{
    public class CookieJarItemModel : ItemModel, ICookieJarItemViewDelegate, IItemViewDelegate, IGoalDependedExplodeTarget
    {
        // Fields
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarCollectHelper cookieJarCollectHelper;
        private Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView itemView;
        private bool isActive;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override bool IsValidTarget { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 33;
        }
        public override bool get_IsValidTarget()
        {
            return (bool)this.isActive;
        }
        public CookieJarItemModel()
        {
            this.isActive = true;
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.cookieJarCollectHelper = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarCollectHelper>(contextId:  36);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView val_1 = 9500.Spawn<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarItemView>(poolId:  115, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.cookieJarCollectHelper.AddCookieJar(cookieJar:  this);
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
        public override bool WillCellBeFreed(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_3;
            if(cell.CurrentItem != this)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            if(this.isActive != false)
            {
                    var val_2 = (this < 1) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public override int FinalExplodeCount()
        {
            return UnityEngine.Mathf.Max(a:  0, b:  (9501.GetGoalUiLeftCount(goalType:  null)) - this.cookieJarCollectHelper.GetExpectedCollectCount());
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
        public int GetIncomingExplodeCountToThis()
        {
            if(this != null)
            {
                    return this.GetIncomingCount();
            }
            
            throw new NullReferenceException();
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_11;
            if((9502.GetGoalUiLeftCount(goalType:  data.point.x)) < 1)
            {
                    return;
            }
            
            if(this.itemView.CanPlayCollectAnimation() == false)
            {
                    return;
            }
            
            this.itemView.Explode();
            .itemView = this.itemView;
            this.cookieJarCollectHelper.Collect(mailCollectData:  new Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData(), trigger:  1981220048);
            this.stateManager.OperationStart(animationId:  5);
            this = ???;
            val_11 = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.CookieJarItemModel).__il2cppRuntimeField_3B0;
        }
        public void OnGoalReached()
        {
            this.stateManager.OperationFinish(animationId:  5);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.CookieJarItemModel).__il2cppRuntimeField_3C0;
        }
        public void OnGoalStartedReaching()
        {
            if(this.isActive == false)
            {
                    return;
            }
            
            this.isActive = false;
            this.itemView.PlayParticle();
            this.itemView.PlayMailboxCloseSound();
        }
        public void FinalizeExplode(float freezeDuration = 0.15)
        {
            this.CurrentCell.FreezeFallForDuration(duration:  freezeDuration);
            this.ClearFromAllRegisteredCells();
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
            return true;
        }
        public override int GetExplodeScore()
        {
            if(this.isActive == false)
            {
                    return 0;
            }
            
            return this.GetExplodeScore();
        }
    
    }

}
