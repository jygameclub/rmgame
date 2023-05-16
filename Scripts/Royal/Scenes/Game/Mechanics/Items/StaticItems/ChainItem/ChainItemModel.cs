using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem
{
    public class ChainItemModel : StaticItemModel, IChainItemViewDelegate
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView <ItemView>k__BackingField;
        private Royal.Player.Context.Units.LevelManager levelManager;
        
        // Properties
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView ItemView { get; set; }
        
        // Methods
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView get_ItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView)this.<ItemView>k__BackingField;
        }
        private void set_ItemView(Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView value)
        {
            this.<ItemView>k__BackingField = value;
        }
        public ChainItemModel(Royal.Scenes.Game.Mechanics.Board.Cell.StaticItemType itemType, int layer = 1)
        {
        
        }
        public override void CreateView(UnityEngine.Vector3 position)
        {
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView val_2 = Spawn<Royal.Scenes.Game.Mechanics.Items.StaticItems.ChainItem.View.ChainItemView>(poolId:  126, activate:  true);
            this.<ItemView>k__BackingField = val_2;
            val_2.Init(itemViewDelegate:  this, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, cell:  1, layer:  -1725424672);
            mem[1152921520061320624] = 1;
        }
        public override Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView GetItemView()
        {
            return (Royal.Scenes.Game.Mechanics.Items.Config.StaticItemView)this.<ItemView>k__BackingField;
        }
        public int GetLayerCount()
        {
            return (int)this;
        }
        public override void PlayInvalidMoveAnimation()
        {
            this.PlayInvalidMoveAnimation();
            this.<ItemView>k__BackingField.PlayShakeAnimation(playSfx:  true);
        }
        protected override void TryExplode(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            var val_8;
            mem[1152921520061817768] = W8 - 1;
            if(W8 != 2)
            {
                    if(W8 != 1)
            {
                    return;
            }
            
                X19.FreezeFallForDuration(duration:  0.15f);
                this.<ItemView>k__BackingField.Explode();
                this.FinalExplodeCompleted();
                if((X19 + 32.HasCurrentItem()) == false)
            {
                    return;
            }
            
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = X19.CurrentItem;
                val_8 = ???;
            }
            else
            {
                    this.<ItemView>k__BackingField.Damage();
            }
        
        }
        public override bool DoesBlockTouch()
        {
            return true;
        }
        public override bool DoesBlockFall()
        {
            return true;
        }
        public override bool CanExplodeWithNearMatch()
        {
            return false;
        }
        public override int GetExplodeScore()
        {
            if(this.levelManager != null)
            {
                    if(this.levelManager.propellerIgnoresChain == false)
            {
                    return this.GetExplodeScore();
            }
            
                return 0;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
