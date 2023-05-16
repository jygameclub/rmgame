using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OysterItem
{
    public class OysterItemModel : ItemModel, IOysterItemViewDelegate, IItemViewDelegate, ITapItem
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView itemView;
        private bool <IsTapDisabled>k__BackingField;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        public Royal.Scenes.Game.Levels.Units.Touch.MoveType GetMoveType { get; }
        public bool IsTapDisabled { get; set; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 21;
        }
        public Royal.Scenes.Game.Levels.Units.Touch.MoveType get_GetMoveType()
        {
            return 0;
        }
        public OysterItemModel(int layerCount)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView val_1 = 26396.Spawn<Royal.Scenes.Game.Mechanics.Items.OysterItem.View.OysterItemView>(poolId:  80, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, layer:  1);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OysterItem.OysterItemModel).__il2cppRuntimeField_1E0;
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
            int val_1 = W8 - 1;
            mem[1152921520206403216] = val_1;
            if()
            {
                    this.itemView.Damage(damagedLayer:  val_1);
                return;
            }
            
            this.itemView.CollectToGoal();
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OysterItem.OysterItemModel).__il2cppRuntimeField_350;
        }
        public override void CollectAsGoal(bool updateUi = True)
        {
            if(this != null)
            {
                    this.DecreaseGoal(goalType:  updateUi);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void CollectCompleted()
        {
            goto typeof(Royal.Scenes.Game.Mechanics.Items.OysterItem.OysterItemModel).__il2cppRuntimeField_3C0;
        }
        public bool Tap(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            return false;
        }
        public override void RevealFromHoney()
        {
            this.itemView.ArrangeSortingForHoney();
            this.RevealFromHoney();
        }
        public bool get_IsTapDisabled()
        {
            return (bool)this.<IsTapDisabled>k__BackingField;
        }
        public void set_IsTapDisabled(bool value)
        {
            this.<IsTapDisabled>k__BackingField = value;
        }
    
    }

}
