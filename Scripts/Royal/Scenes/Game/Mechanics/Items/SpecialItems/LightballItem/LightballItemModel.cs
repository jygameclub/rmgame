using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem
{
    public class LightballItemModel : SpecialItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView itemView;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy lightballStrategy;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        
        // Methods
        public LightballItemModel()
        {
            mem[1152921520121068600] = 5;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 5;
        }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType()
        {
            return 4;
        }
        public void UpdateStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy strategy)
        {
            this.lightballStrategy = strategy;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView val_1 = 22305.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemView>(poolId:  22, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel).__il2cppRuntimeField_1E0;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.itemView;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            bool val_1 = this.Start(item:  0, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        private bool Start(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_3;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy val_4;
            var val_5;
            var val_6;
            val_3 = 1152921520122079280;
            22307.StartSpecialOperation();
            val_4 = this.lightballStrategy;
            if(val_4 == null)
            {
                goto label_2;
            }
            
            if((this.lightballStrategy.<DidStart>k__BackingField) == false)
            {
                goto label_3;
            }
            
            val_5 = 1;
            return (bool)((this.lightballStrategy.<DidStart>k__BackingField) == true) ? 1 : 0;
            label_2:
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.DefaultLightballStrategy val_1 = null;
            val_4 = val_1;
            val_1 = new Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.DefaultLightballStrategy();
            this.lightballStrategy = val_4;
            val_6;
            return (bool)((this.lightballStrategy.<DidStart>k__BackingField) == true) ? 1 : 0;
            label_3:
            val_6;
            return (bool)((this.lightballStrategy.<DidStart>k__BackingField) == true) ? 1 : 0;
        }
        public void ExplodeSelf()
        {
            int val_6;
            int val_7;
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  33)) != false)
            {
                    Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33);
                val_2.CollectRemainingMovesCoin(cell:  CurrentCell, specialItemModel:  this);
            }
            
            this.itemView.Explode();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_4 = this.itemView.CurrentCell;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_5 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  15);
            val_2.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_7, y = val_7}, trigger = val_7, id = val_6});
        }
        public override void SwapWith(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel item, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            bool val_1 = this.Start(item:  item, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public void ComboWith(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel specialItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            bool val_1 = this.Start(item:  specialItem, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public override bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            return (bool)this.Start(item:  0, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        public override int GetExplodeScore()
        {
            if(this.lightballStrategy == null)
            {
                    return this.GetExplodeScore();
            }
            
            if((this.lightballStrategy.<DidStart>k__BackingField) == false)
            {
                    return this.GetExplodeScore();
            }
            
            return 0;
        }
        public override bool CanSwapWith(Royal.Scenes.Game.Mechanics.Items.Config.ItemModel model)
        {
            if(model == null)
            {
                    return true;
            }
            
            if((model & 1) != 0)
            {
                    return true;
            }
        
        }
    
    }

}
