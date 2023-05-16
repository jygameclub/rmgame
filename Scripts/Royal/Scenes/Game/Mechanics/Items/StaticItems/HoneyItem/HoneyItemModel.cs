using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem
{
    public class HoneyItemModel : StaticItemModel
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView <ItemView>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView ItemView { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public HoneyItemModel(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType, int layer = 1)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView val_1 = 18998.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.HoneyItem.View.HoneyItemView>(poolId:  37, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, cell:  37);
            mem[1152921520024943760] = 1;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView)this.<ItemView>k__BackingField;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            object val_1 = 18999;
            val_1 = new System.Object();
            mem[1152921520025201544] = 47690447;
            if()
            {
                    return;
            }
            
            this.<ItemView>k__BackingField.Explode(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}, onComplete:  new System.Action(object:  val_1, method:  System.Void HoneyItemModel.<>c__DisplayClass7_0::<TryExplode>b__0()));
            this.DisableAutoExplodeTemporarily();
            this.FinalExplodeCompleted();
        }
        public override bool DoesBlockTouch()
        {
            return true;
        }
        public override bool DoesBlockVisibility()
        {
            return true;
        }
        private static void UpdateNeighbors(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel currentCell)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_18:
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_1 = 4.Get(type:  Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes + 32);
            if(val_1 != null)
            {
                    bool val_2 = val_1.HasTouchBlockingItem();
                if(val_2 != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_3 = val_2.GetStaticItem(itemType:  2);
                if(val_3 != null)
            {
                    val_3.UpdateView();
            }
            
            }
            
            }
            
            val_4 = 1;
            label_1:
            val_5 = null;
            val_5 = null;
            if(val_4 < Royal.Scenes.Game.Mechanics.Board.Grid.CellNeighbors.AllNeighborTypes.Length)
            {
                goto label_18;
            }
        
        }
        private void UpdateView()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            if((this.<ItemView>k__BackingField) != null)
            {
                    this.<ItemView>k__BackingField.UpdateSprites();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
