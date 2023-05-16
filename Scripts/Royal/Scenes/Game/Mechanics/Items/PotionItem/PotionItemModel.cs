using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PotionItem
{
    public class PotionItemModel : MultipleCellItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView itemView;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> matchList;
        private readonly Royal.Scenes.Game.Levels.Units.LevelRandomManager levelRandomManager;
        private readonly System.Collections.Generic.Dictionary<int, int> fakeExploderCounter;
        private readonly bool isPredefined;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 12;
        }
        public PotionItemModel(int layer, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings itemSettings)
        {
            this.levelRandomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            if((-1595361536) == 53)
            {
                    System.ValueTuple<System.Boolean, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>> val_3 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.PotionItem.PotionItemHelper>(contextId:  24).GetMatchList(itemSettings:  new Royal.Scenes.Game.Levels.Units.ItemCreation.ItemSettings() {tiledId = itemSettings.tiledId, itemType = itemSettings.tiledId, layerCount = itemSettings.layerCount, goalType = itemSettings.goalType, staticItemType = itemSettings.goalType, isExtraPropeller = itemSettings.isExtraPropeller, isCreatedByLightball = false, potionColors = itemSettings.tiledId, curtainId = -1595361536, isDrillMaster = true}, itemFactory:  0);
                this.isPredefined = (val_3.Item2 != 255) ? 1 : 0;
                this.matchList = ;
            }
            else
            {
                    this.isPredefined = true;
                Royal.Scenes.Game.Mechanics.Matches.MatchType val_5 = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  -1595361536);
                System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_6 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType>();
                val_6.Add(item:  val_5);
                val_6.Add(item:  val_5);
                val_6.Add(item:  val_5);
                val_6.Add(item:  val_5);
                this.matchList = val_6;
            }
            
            this.fakeExploderCounter = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>(capacity:  layer);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView val_1 = 27814.Spawn<Royal.Scenes.Game.Mechanics.Items.PotionItem.View.PotionItemView>(poolId:  51, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, isPredefined:  this.isPredefined, matchTypes:  this.matchList);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.PotionItem.PotionItemModel).__il2cppRuntimeField_1E0;
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
            return false;
        }
        public override bool IsSwappable()
        {
            return false;
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_8;
            int val_9;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> val_10;
            val_8 = this;
            val_9 = data.id;
            if(val_9 != 0)
            {
                    val_10 = this.matchList;
            }
            else
            {
                    val_10 = this.matchList;
                val_9 = this.levelRandomManager.GetRandomItemFromList<Royal.Scenes.Game.Mechanics.Matches.MatchType>(list:  this.matchList);
            }
            
            if((this.matchList.SyncRoot.Remove(item:  val_9)) == false)
            {
                    return;
            }
            
            this.itemView.Damage(matchType:  val_9);
            mem[1152921520192136992] = mem[this.matchList.SyncRoot + 24];
            if((mem[this.matchList.SyncRoot + 24]) != 0)
            {
                    val_8 = ???;
            }
            else
            {
                    this.itemView.Explode();
            }
        
        }
        public void TryFakeExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_4 = 1152921520192334064;
            bool val_2 = this.fakeExploderCounter.TryGetValue(key:  268435459, value: out  0);
            this.fakeExploderCounter.set_Item(key:  268435459, value:  1);
        }
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_2 = 1152921520192486928;
            var val_1 = 0;
            do
            {
                val_1 = val_1 + 1;
                if(val_1 >= this.matchList)
            {
                    return;
            }
            
            }
            while(this.matchList != null);
            
            throw new NullReferenceException();
        }
    
    }

}
