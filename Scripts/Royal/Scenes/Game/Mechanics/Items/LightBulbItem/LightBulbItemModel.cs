using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.LightBulbItem
{
    public class LightBulbItemModel : MultipleCellItemModel, ILightBulbItemViewDelegate, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] colorOrder;
        private Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView itemView;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType currentMatchType;
        private int matchTypeIndex;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 30;
        }
        public LightBulbItemModel(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, int layer)
        {
            this.currentMatchType = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  tiledId);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            this.colorOrder = 1073741824.GetLightBulbColorOrder();
            int val_2 = this.GetInitialColorIndex();
            this.matchTypeIndex = val_2;
            this.currentMatchType = this.colorOrder[val_2 << 2];
            Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView val_3 = val_2.Spawn<Royal.Scenes.Game.Mechanics.Items.LightBulbItem.View.LightBulbItemView>(poolId:  108, activate:  true);
            this.itemView = val_3;
            val_3.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, initialColor:  this.currentMatchType);
            goto typeof(Royal.Scenes.Game.Mechanics.Items.LightBulbItem.LightBulbItemModel).__il2cppRuntimeField_1E0;
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
            int val_4 = data.id;
            if(val_4 != 0)
            {
                    if(val_4 != this.currentMatchType)
            {
                    return;
            }
            
            }
            
            this.itemView.Damage(matchType:  this.currentMatchType, layer:  0);
            val_4 = val_4 - 1;
            mem[1152921520262423152] = val_4;
            if(val_4 != this.currentMatchType)
            {
                
            }
            else
            {
                    this.itemView.Explode();
            }
        
        }
        public override void ExplodeAll(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            this.ExplodeAll(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
            int val_2 = (W20 - 2) - data.id;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                val_2 = val_2 - 1;
            }
            while(val_2 != 1);
        
        }
        private int GetInitialColorIndex()
        {
            var val_1;
            if(this.colorOrder.Length >= 1)
            {
                    val_1 = 0;
                do
            {
                if(this.colorOrder[0] == this.currentMatchType)
            {
                    return (int)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < this.colorOrder.Length);
            
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType GetColor()
        {
            return (Royal.Scenes.Game.Mechanics.Matches.MatchType)this.currentMatchType;
        }
        public Royal.Scenes.Game.Mechanics.Matches.MatchType ChangeColor()
        {
            int val_2 = this.matchTypeIndex;
            val_2 = val_2 + 1;
            val_2 = val_2 - ((val_2 / this.colorOrder.Length) * this.colorOrder.Length);
            this.matchTypeIndex = val_2;
            Royal.Scenes.Game.Mechanics.Matches.MatchType val_3 = this.colorOrder[val_2 << 2];
            this.currentMatchType = val_3;
            return val_3;
        }
    
    }

}
