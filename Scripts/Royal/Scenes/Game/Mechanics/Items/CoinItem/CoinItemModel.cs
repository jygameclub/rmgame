using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CoinItem
{
    public class CoinItemModel : ItemModel, ICoinItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView itemView;
        private readonly Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 15;
        }
        public CoinItemModel()
        {
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView val_1 = 8342.Spawn<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(poolId:  61, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.HasView = true;
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
            return true;
        }
        public override bool IsSwappable()
        {
            return true;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.StartCollectAnimation();
            this.FinalExplodeCompleted(freezeDuration:  0.15f);
        }
        public override void CollectAsGoal(bool updateUi = True)
        {
            if(this != null)
            {
                    this.IncreaseGoal(goalType:  updateUi);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void StartCollectAnimation()
        {
            this.stateManager.OperationStart(animationId:  5);
            UnityEngine.Vector3 val_1 = this.stateManager.GetGoalPosition(goalType:  5);
            this.itemView.CollectToGoal(goalPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.itemView.FlyingToBeCollected(goalType:  5);
        }
        public void CollectAnimationCompleted()
        {
            8341.IncreaseGoalUi(goalType:  null);
            this.stateManager.OperationFinish(animationId:  5);
            this.stateManager.Recycle<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  this.itemView);
        }
    
    }

}
