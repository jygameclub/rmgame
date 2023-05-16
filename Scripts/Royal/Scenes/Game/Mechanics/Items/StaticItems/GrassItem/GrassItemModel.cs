using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem
{
    public class GrassItemModel : StaticItemModel
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView <ItemView>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView ItemView { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public GrassItemModel(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType, int layer = 1)
        {
        
        }
        public int GetLayer()
        {
            return (int)this;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            this.<ItemView>k__BackingField = Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView>(poolId:  35, activate:  true);
            Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemAssets val_2 = Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemAssets>();
            this.<ItemView>k__BackingField.Init(item:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, viewData:  new GrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
            mem[1152921520037412640] = 1;
        }
        public void CreateViewForBush(UnityEngine.Vector3 position, GrassViewData viewData)
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView val_1 = 17944.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.GrassItem.View.GrassItemView>(poolId:  35, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(item:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, viewData:  new GrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
            mem[1152921520037557536] = 1;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView)this.<ItemView>k__BackingField;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = W8 - 1;
            mem[1152921520037830808] = val_1;
            if(W8 != 2)
            {
                    if(W8 != 1)
            {
                    return;
            }
            
                this.<ItemView>k__BackingField.Explode();
                this.FinalExplodeCompleted();
                return;
            }
            
            this.<ItemView>k__BackingField.Damage(damagedLayer:  val_1);
        }
        public override bool DoesBlockTouch()
        {
            return false;
        }
        public override int GetExplodeScore()
        {
            int val_4 = this.GetExplodeScore();
            bool val_2 = 0.HasCurrentItem();
            if(val_2 == false)
            {
                    return (int)val_4;
            }
            
            if((val_2.CurrentItem & 1) == 0)
            {
                    if(X0 == false)
            {
                    return (int)val_4;
            }
            
            }
            
            val_4 = val_4 - 1;
            return (int)val_4;
        }
        public override void AddIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.AddIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            if(data.id == 0)
            {
                    return;
            }
            
            if((data.id + 32.HasCurrentItem()) == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = data.id + 32.CurrentItem;
            val_2.extraIncomingContainer.AddToIncoming(id:  268435459, trigger:  -1748464304);
        }
        public override void RemoveIncomingExploder(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.RemoveIncomingExploder(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            if(data.id == 0)
            {
                    return;
            }
            
            if((data.id + 32.HasCurrentItem()) == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = data.id + 32.CurrentItem;
            val_2.extraIncomingContainer.RemoveFromIncoming(id:  268435459, trigger:  -1748311440);
        }
        public void RefillLayers(GrassViewData grassViewData)
        {
            if(W8 == 2)
            {
                    return;
            }
            
            mem[1152921520038521752] = W8 + 1;
            this.<ItemView>k__BackingField.UpdateView(layer:  -1748206616, grassViewData:  new GrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
        }
        public void NeighborGrassUpdated()
        {
            if((this.<ItemView>k__BackingField) != null)
            {
                    this.<ItemView>k__BackingField.UpdatePatches();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
