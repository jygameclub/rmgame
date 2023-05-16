using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.ColorBoxItem
{
    public class ColorBoxItemModel : ItemModel, IItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView itemView;
        private readonly Royal.Scenes.Game.Mechanics.Matches.MatchType color;
        
        // Properties
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType ItemType { get; }
        
        // Methods
        public override Royal.Scenes.Game.Mechanics.Items.Config.ItemType get_ItemType()
        {
            return 18;
        }
        public ColorBoxItemModel(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, int layerCount)
        {
            this.color = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  tiledId);
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView val_1 = 8404.Spawn<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView>(poolId:  67, activate:  true);
            this.itemView = val_1;
            val_1.Init(viewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, color:  this.color, layerCount:  2023217296);
            this.HasView = true;
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
            if(2023883376 != 15)
            {
                    if(2023883376 != 5)
            {
                goto label_1;
            }
            
            }
            
            if(data.id != this.color)
            {
                    return;
            }
            
            label_1:
            int val_1 = data.id - 1;
            mem[1152921523810563568] = val_1;
            if(data.id != this.color)
            {
                    this.itemView.Damage(damagedLayer:  val_1);
                return;
            }
            
            this.itemView.Explode();
            this.FinalExplodeCompleted(freezeDuration:  0.15f);
        }
    
    }

}
