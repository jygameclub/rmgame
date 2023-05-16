using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy
{
    public class LightballRocketStrategy : LightballSpecialStrategy
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.RocketItemModel rocketItem;
        private readonly System.Collections.Generic.Dictionary<int, Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation> replacedItemsTypes;
        private Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation lastRocketOrientation;
        
        // Properties
        protected override float ItemExplodeDelay { get; }
        public override float PositionOffset { get; }
        public override float MaxShakeScale { get; }
        
        // Methods
        protected override float get_ItemExplodeDelay()
        {
            return 0.15f;
        }
        public override float get_PositionOffset()
        {
            return 0.01f;
        }
        public override float get_MaxShakeScale()
        {
            return 1.02f;
        }
        public override void Start(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel otherItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            if(otherItem != null)
            {
                    this.rocketItem = otherItem;
                this.lastRocketOrientation = null;
                this.Start(lightballItem:  lightballItem, otherItem:  otherItem, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x, y = data.point.y}, trigger = data.trigger, id = data.id, matchType = data.matchType});
                return;
            }
            
            this.rocketItem = 0;
            throw new NullReferenceException();
        }
        protected override void Reset()
        {
            this.Reset();
            this.replacedItemsTypes.Clear();
            this.rocketItem = 0;
        }
        protected override void AddMatchItemToList(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation val_1;
            this.AddMatchItemToList(itemModel:  itemModel);
            this.replacedItemsTypes.Add(key:  itemModel, value:  this.lastRocketOrientation);
            if(this.lastRocketOrientation != 0)
            {
                    if(this.lastRocketOrientation != 1)
            {
                    return;
            }
            
                val_1 = 0;
            }
            else
            {
                    val_1 = 1;
            }
            
            this.lastRocketOrientation = val_1;
        }
        protected override Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel GetReplacedItemForLightball()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel)this.rocketItem;
        }
        protected override void CreateBgForReplacedItemForLightball()
        {
            UnityEngine.Vector3 val_1 = this.rocketItem.<ItemView>k__BackingField.Position;
            mem[1152921520140772792] = this.CreateBg(itemType:  this.rocketItem, position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, parent:  null);
        }
        protected override void RemoveFromItems(Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel item)
        {
            this.RemoveFromItems(item:  item);
            bool val_1 = this.replacedItemsTypes.Remove(key:  item);
        }
        public override void SingleRayReached(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay lightballRay, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            bool val_1 = itemModel.IsUnderChain();
            if(val_1 != false)
            {
                    this.ExplodeChainAndResetMatchItem(itemModel:  itemModel);
                return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = 1073741824.CreateItemAt(tiledId:  this.GetCurrentTiledId(id:  itemModel), position:  new UnityEngine.Vector3());
            this.PutItemToCell(createdItem:  val_4, cell:  val_1.RemoveAnItemFromCell(itemModel:  itemModel), onExplode:  new System.Action(object:  lightballRay, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay::EndRay()));
            this = val_4;
            UnityEngine.Vector3 val_7 = 1152921505105940480.transform.position;
            lightballRay.CreateItemBg(itemType:  this, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, parent:  Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_byval_arg);
            lightballRay.ShakeItem(trans:  Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_byval_arg);
        }
        private Royal.Scenes.Game.Utils.LevelParser.TiledId GetCurrentTiledId(int id)
        {
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(this.replacedItemsTypes.Item[id] == 0) ? 30 : 20;
        }
        public LightballRocketStrategy()
        {
            this.replacedItemsTypes = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Mechanics.Items.Config.ItemOrientation>();
        }
    
    }

}
