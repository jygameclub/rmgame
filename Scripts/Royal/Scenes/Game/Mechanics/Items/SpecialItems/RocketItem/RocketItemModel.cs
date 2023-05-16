using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem
{
    public class RocketItemModel : SpecialItemModel, IRocketItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Explode.ExplodeData preSetExplodeData;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView <ItemView>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation <Orientation>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView ItemView { get; set; }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation Orientation { get; set; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation get_Orientation()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation)this.<Orientation>k__BackingField;
        }
        private void set_Orientation(Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation value)
        {
            this.<Orientation>k__BackingField = value;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 2;
        }
        public override Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType()
        {
            return 13;
        }
        public RocketItemModel(Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation orientation)
        {
            mem[1152921520087110033] = 1;
            val_1 = new Royal.Scenes.Game.Mechanics.Items.Config.ItemModel(layer:  1);
            this.<Orientation>k__BackingField = orientation;
            mem[1152921520087110040] = 2;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView val_1 = 29899.Spawn<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView>(poolId:  7, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel).__il2cppRuntimeField_1E0;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.<ItemView>k__BackingField;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        public void ExplodeWithPresetData(Royal.Scenes.Game.Mechanics.Explode.ExplodeData trigger, Royal.Scenes.Game.Mechanics.Explode.ExplodeData presetData)
        {
            mem[1152921520087604144] = presetData.id;
            this.preSetExplodeData = presetData.point.x;
            this.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = trigger.point.x}, id = trigger.id});
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_9;
            int val_10;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel val_14;
            var val_15;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_16;
            var val_17;
            int val_18;
            val_14 = this;
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  33)) != false)
            {
                    val_15 = val_14;
                Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33).CollectRemainingMovesCoin(cell:  CurrentCell, specialItemModel:  this);
            }
            else
            {
                    val_15 = 1152921520087806032;
            }
            
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_4 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_5 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_6 = 1152921505090392064.CurrentCell;
            val_16 = val_6;
            if(val_6 == null)
            {
                    val_16 = val_6.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x, y = data.point.x}];
            }
            
            if((this.<Orientation>k__BackingField) == 1)
            {
                goto label_8;
            }
            
            if((this.<Orientation>k__BackingField) != 0)
            {
                goto label_9;
            }
            
            this.AddNeighborsRecursive(list:  val_4, model:  val_16, type:  7);
            val_17 = 3;
            goto label_10;
            label_8:
            this.AddNeighborsRecursive(list:  val_4, model:  val_16, type:  1);
            val_17 = 5;
            label_10:
            this.AddNeighborsRecursive(list:  val_5, model:  val_16, type:  5);
            label_9:
            if((-1698874112) != 12)
            {
                    if((-1698874112) == 7)
            {
                
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_8 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  6);
                val_18 = val_9;
            }
            
            }
            
            val_9 = val_18;
            val_10 = val_10;
            this.<ItemView>k__BackingField.Play(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10, y = val_10}, trigger = val_10, id = val_9}, cell:  val_16, firstList:  val_4, secondList:  val_5);
            if(1152921505090392064.CurrentCell != null)
            {
                    val_9 = val_18;
                val_10 = val_10;
                1152921505090392064.CurrentCell.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10, y = val_10}, trigger = val_10, id = val_9});
                return;
            }
            
            if(val_16 == null)
            {
                    return;
            }
            
            val_16.ExplodeCurrentItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10, y = val_10}, trigger = val_10, id = val_18});
            val_9 = val_18;
            val_10 = val_10;
            val_16.ExplodeTopMostBelowItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_10, y = val_10}, trigger = val_10, id = val_9});
        }
        private void AddNeighborsRecursive(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> list, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel model, int type)
        {
            goto label_0;
            label_5:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = this.Get(type:  type);
            if(val_1 == null)
            {
                    return;
            }
            
            model = val_1;
            list.Add(item:  model);
            label_0:
            if(model != null)
            {
                goto label_5;
            }
        
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
        public void ChangeOrientation(Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation orientation)
        {
            this.<Orientation>k__BackingField = orientation;
            this.<ItemView>k__BackingField.Init(viewDelegate:  this, position:  new UnityEngine.Vector3());
        }
    
    }

}
