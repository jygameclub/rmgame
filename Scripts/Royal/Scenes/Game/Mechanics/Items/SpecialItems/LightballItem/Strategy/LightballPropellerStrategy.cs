using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy
{
    public class LightballPropellerStrategy : LightballSpecialStrategy
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.PropellerItemModel propellerItem;
        
        // Methods
        public override void Start(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel otherItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_2 = 0;
            this.propellerItem = ;
            this.Start(lightballItem:  lightballItem, otherItem:  otherItem, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x, y = data.point.y}, trigger = data.trigger, id = data.id, matchType = data.matchType});
        }
        protected override void Reset()
        {
            this.Reset();
            this.propellerItem = 0;
        }
        protected override Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel GetReplacedItemForLightball()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel)this.propellerItem;
        }
        protected override void CreateBgForReplacedItemForLightball()
        {
            UnityEngine.Vector3 val_2 = this.propellerItem.<ItemView>k__BackingField.transform.position;
            mem[1152921520139441912] = this.CreateBg(itemType:  this.propellerItem, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, parent:  null);
            mem[1152921520139441904] = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ShakeItem(trans:  this.propellerItem));
        }
        public override void SingleRayReached(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay lightballRay, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel val_8 = itemModel;
            bool val_1 = val_8.IsUnderChain();
            if(val_1 != false)
            {
                    this.ExplodeChainAndResetMatchItem(itemModel:  val_8 = itemModel);
                return;
            }
            
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = val_1.RemoveAnItemFromCell(itemModel:  val_8);
            val_8 = 1073741824.CreateItemAt(tiledId:  10, position:  new UnityEngine.Vector3());
            UnityEngine.Vector3 val_4 = val_2.GetViewPosition();
            SpecialItemCreated(createdItem:  val_8, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, animationDelayInFrames:  0);
            this.PutItemToCell(createdItem:  val_8, cell:  val_2, onExplode:  new System.Action(object:  lightballRay, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay::EndRay()));
            UnityEngine.Vector3 val_7 = 1152921505105940480.transform.position;
            lightballRay.CreateItemBg(itemType:  val_8, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, parent:  Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_byval_arg);
            lightballRay.ShakeItem(trans:  Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_byval_arg);
        }
        public LightballPropellerStrategy()
        {
        
        }
    
    }

}
