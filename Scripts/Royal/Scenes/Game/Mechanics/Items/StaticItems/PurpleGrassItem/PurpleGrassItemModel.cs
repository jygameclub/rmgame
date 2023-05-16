using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem
{
    public class PurpleGrassItemModel : StaticItemModel
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView <ItemView>k__BackingField;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView ItemView { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public PurpleGrassItemModel(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType, int layer = 1)
        {
        
        }
        public int GetLayer()
        {
            return (int)this;
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_14 = 120;
            val_15 = 0;
            if(==0)
            {
                    throw new NullReferenceException();
            }
            
            val_15 = 87;
            val_14 = 1;
            val_17 = public Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory::Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView>(int poolId, bool activate);
            this.<ItemView>k__BackingField = Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView>(poolId:  87, activate:  true);
            if((public Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory::Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView>(int poolId, bool activate)) == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = null;
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_13 = Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets>();
            val_14 = 120;
            val_15 = 0;
            if((public Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets Royal.Scenes.Game.Levels.Units.ItemAssetsLibrary::Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemAssets>()) == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_13 = this.<ItemView>k__BackingField;
            val_14 = 120;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_13.Init(item:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, viewData:  new Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
            mem[1152921520019358224] = 1;
        }
        public void CreateViewForPot(UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData viewData)
        {
            Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView val_1 = 28416.Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassItemView>(poolId:  87, activate:  true);
            this.<ItemView>k__BackingField = val_1;
            val_1.Init(item:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, viewData:  new Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
            mem[1152921520019515408] = 1;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView)this.<ItemView>k__BackingField;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            int val_1 = W8 - 1;
            mem[1152921520019788680] = val_1;
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
        public void RefillLayers(Royal.Scenes.Game.Utils.LevelParser.TiledId grassFillType, Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData grassViewData)
        {
            if(grassFillType == 19)
            {
                    if(W8 > 0)
            {
                    return;
            }
            
            }
            
            mem[1152921520020177992] = W8 + 1;
            this.<ItemView>k__BackingField.UpdateView(layer:  -1766550376, grassViewData:  new Royal.Scenes.Game.Mechanics.Items.StaticItems.PurpleGrassItem.View.PurpleGrassViewData() {baseData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, patchData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}, shadowData = new GrassSpriteData() {sorting = new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false}, color = new UnityEngine.Color()}});
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
