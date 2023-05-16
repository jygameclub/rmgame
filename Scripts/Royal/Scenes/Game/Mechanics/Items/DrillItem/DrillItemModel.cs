using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DrillItem
{
    public class DrillItemModel : MultipleCellItemModel, IDrillItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private readonly Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillManager drillManager;
        private Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView <ItemView>k__BackingField;
        
        // Properties
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView ItemView { get; set; }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 29;
        }
        public DrillItemModel(int layerCount, Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillDirection direction)
        {
            this.direction = direction;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            var val_7;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_8;
            Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper val_1 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillHelper>(contextId:  31);
            val_1.InitDrills();
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.CurrentCell;
            this.drillManager = val_1.GetDrillManagerByPoint(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint());
            Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView val_4 = Spawn<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView>(poolId:  106, activate:  true);
            this.<ItemView>k__BackingField = val_4;
            val_4.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, direction:  this.direction, drillManager:  this.drillManager, currentCell:  this.CurrentCell);
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_6 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  24);
            mem[1152921520352483592] = val_7;
            this.exploder = val_8;
            Royal.Player.Context.Units.LevelManager val_9 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            if(val_9.isThereHatInLevel == false)
            {
                    return;
            }
            
            if(val_1.HasAnyPinkDrill() == false)
            {
                    return;
            }
            
            this.drillManager = 1;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.ItemView)this.<ItemView>k__BackingField;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        public override bool IsFallable()
        {
            return false;
        }
        public override bool IsSwappable()
        {
            return false;
        }
        public override bool CanSelectByBooster()
        {
            return false;
        }
        public void StartDrill()
        {
            if((this.<ItemView>k__BackingField) != null)
            {
                    this.<ItemView>k__BackingField.StartDrill();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void MoveDrill(bool haveWaited)
        {
            this.<ItemView>k__BackingField.MoveDrill(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder.point, y = this.exploder.point}, trigger = this.exploder.point, id = ???}, cell:  this.CurrentCell, cellsOnPath:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), cellsOnDrill:  new Royal.Scenes.Game.Mechanics.Matches.Cell14(), haveWaited:  haveWaited);
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
        
        }
        public void FinalExplode()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.DrillItem.DrillItemModel).__il2cppRuntimeField_350;
        }
    
    }

}
