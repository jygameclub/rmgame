using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy
{
    public class LightballTntStrategy : LightballSpecialStrategy
    {
        // Fields
        private const float MadnessMatchItemAnimationDelay = 0.5;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.TntItemModel tntItem;
        
        // Properties
        protected override float ItemExplodeDelay { get; }
        protected override float ItemExplodeStartDelay { get; }
        
        // Methods
        protected override float get_ItemExplodeDelay()
        {
            return 0f;
        }
        protected override float get_ItemExplodeStartDelay()
        {
            return 0.5f;
        }
        public override void Start(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.LightballItemModel lightballItem, Royal.Scenes.Game.Mechanics.Items.Config.ItemModel otherItem, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_2 = 0;
            this.tntItem = ;
            this.Start(lightballItem:  lightballItem, otherItem:  otherItem, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x, y = data.point.y}, trigger = data.trigger, id = data.id, matchType = data.matchType});
        }
        protected override void Reset()
        {
            this.Reset();
            this.tntItem = 0;
        }
        public override void SingleRayReached(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay lightballRay, Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel itemModel)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_5;
            Royal.Scenes.Game.Mechanics.Goal.GoalType val_7;
            Royal.Scenes.Game.Mechanics.Items.MatchItem.MatchItemModel val_13;
            System.Action val_14;
            val_13 = itemModel;
            bool val_1 = val_13.IsUnderChain();
            if(val_1 != false)
            {
                    this.ExplodeChainAndResetMatchItem(itemModel:  val_13);
                return;
            }
            
            val_13 = Royal.Scenes.Game.Levels.Units.ItemCreation.ItemCreator.GetSettingsForTileId(tiledId:  40).isExtraPropeller.CreateItemWithSettings(settings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = val_5, itemType = val_5, layerCount = val_5, matchType = val_5, goalType = val_7, staticItemType = val_7, isExtraPropeller = val_7, isCreatedByLightball = val_7, potionColors = val_7, curtainId = val_7, isDrillMaster = val_7}, position:  new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_7});
            System.Action val_9 = null;
            val_14 = val_9;
            val_9 = new System.Action(object:  lightballRay, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemRay::EndRay());
            this.PutItemToCell(createdItem:  val_13, cell:  val_1.RemoveAnItemFromCell(itemModel:  val_13), onExplode:  val_9);
            UnityEngine.Vector3 val_11 = 1152921505105940480.transform.position;
            lightballRay.CreateItemBg(itemType:  val_13, position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, parent:  Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_byval_arg);
            lightballRay.ShakeItem(trans:  Royal.Scenes.Game.Mechanics.Items.Config.ItemModel.__il2cppRuntimeField_byval_arg);
        }
        protected override Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel GetReplacedItemForLightball()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel)this.tntItem;
        }
        protected override void CreateBgForReplacedItemForLightball()
        {
            UnityEngine.Vector3 val_2 = this.tntItem.<ItemView>k__BackingField.transform.position;
            mem[1152921520150634552] = this.CreateBg(itemType:  this.tntItem, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, parent:  null);
            mem[1152921520150634544] = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ShakeItem(trans:  this.tntItem));
        }
        protected override void AllRaysComplete()
        {
            int val_2;
            int val_3;
            var val_8;
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_1 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  14);
            val_8 = 0;
            label_11:
            var val_7 = mem[47599640];
            if(val_8 >= val_7)
            {
                goto label_2;
            }
            
            val_7 = val_7 & 4294967295;
            if(val_8 >= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = mem[47599632];
            val_8 = val_8 + 0;
            var val_9 = (mem[47599632] + 0) + 32;
            if((val_9 != 0) && ((val_9 & 1) != 0))
            {
                    if(((mem[47599632] + 0) + 32 + 32.HasCurrentCell()) != false)
            {
                    val_9 = val_3;
                val_9 = val_2;
                (mem[47599632] + 0) + 32 + 232.PlayLightballCreationAnimation();
            }
            
            }
            
            val_8 = val_8 + 1;
            if(val_9 != 0)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_2:
            UnityEngine.Coroutine val_6 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  (mem[47599632] + 0) + 32 + 232.PlayMadnessAnimation(cell:  0, data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_3, y = val_3}, trigger = val_3, id = val_2}));
            this.AllRaysComplete();
        }
        private System.Collections.IEnumerator PlayMadnessAnimation(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            .<>1__state = 0;
            .cell = cell;
            mem[1152921520151013112] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new LightballTntStrategy.<PlayMadnessAnimation>d__12();
        }
        public LightballTntStrategy()
        {
        
        }
    
    }

}
