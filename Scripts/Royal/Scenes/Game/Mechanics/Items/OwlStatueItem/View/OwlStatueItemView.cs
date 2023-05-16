using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View
{
    public class OwlStatueItemView : ItemView
    {
        // Fields
        public UnityEngine.SpriteRenderer baseView;
        private Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate itemViewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemAssets itemAssets;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer)
        {
            this.itemViewDelegate = viewDelegate;
            Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemAssets>();
            this.itemAssets = val_1;
            this.baseView.sprite = val_1.GetSpriteForLayer(layer:  layer);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 46;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.itemViewDelegate = 0;
        }
        public override bool CanReceiveChainExtraShadow()
        {
            return true;
        }
        public void Explode()
        {
            26388.PlaySfx(type:  192, offset:  0.04f);
            this.ExplodeParticle(particleLayer:  0);
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemView>(go:  this);
        }
        public void Damage(int damagedLayer)
        {
            var val_3;
            var val_4;
            if(damagedLayer == 1)
            {
                    val_3 = 193;
                val_4 = 194;
            }
            else
            {
                    val_3 = 195;
                val_4 = 196;
            }
            
            X21.PlaySfx(type:  X21.SelectRandomClip(from:  195, to:  196), offset:  0.04f);
            this.baseView.sprite = this.itemAssets.GetSpriteForLayer(layer:  damagedLayer);
            this.ExplodeParticle(particleLayer:  damagedLayer);
        }
        private void ExplodeParticle(int particleLayer)
        {
            Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemExplodeParticles val_1 = 26387.Spawn<Royal.Scenes.Game.Mechanics.Items.OwlStatueItem.View.OwlStatueItemExplodeParticles>(poolId:  47, activate:  true);
            val_1.Play(particleLayer:  particleLayer);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public OwlStatueItemView()
        {
        
        }
    
    }

}
