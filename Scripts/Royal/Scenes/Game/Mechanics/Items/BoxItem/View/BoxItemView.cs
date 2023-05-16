using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BoxItem.View
{
    public class BoxItemView : ItemView
    {
        // Fields
        public UnityEngine.SpriteRenderer baseView;
        private Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemAssets itemAssets;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer)
        {
            Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemAssets>();
            this.itemAssets = val_1;
            this.baseView.sprite = val_1.GetSpriteForLayer(layer:  layer);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 31;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public override bool CanReceiveChainExtraShadow()
        {
            return true;
        }
        public void Explode()
        {
            int val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  3);
            PlaySfx(type:  (val_2 == 0) ? 29 : ((val_2 != 1) ? (30 + 1) : 30), offset:  0.04f);
            this.ExplodeParticle(particleLayer:  0);
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemView>(go:  this);
        }
        public void Damage(int damagedLayer)
        {
            int val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  3);
            PlaySfx(type:  (val_2 == 0) ? 32 : ((val_2 != 1) ? (33 + 1) : 33), offset:  0.04f);
            this.baseView.sprite = this.itemAssets.GetSpriteForLayer(layer:  damagedLayer);
            this.ExplodeParticle(particleLayer:  damagedLayer);
        }
        private void ExplodeParticle(int particleLayer)
        {
            int val_11 = particleLayer;
            Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemExplodeParticles val_1 = 6435.Spawn<Royal.Scenes.Game.Mechanics.Items.BoxItem.View.BoxItemExplodeParticles>(poolId:  32, activate:  true);
            val_1.Play(particleLayer:  val_11 = particleLayer);
            if((val_11 == 0) && (Royal.Player.Context.Units.LevelManager.IsStoryLevel != false))
            {
                    StoryItemCollection val_4 = UnityEngine.Object.Instantiate<StoryItemCollection>(original:  UnityEngine.Resources.Load<StoryItemCollection>(path:  "StoryItemCollected"));
                val_11 = val_4;
                UnityEngine.Vector3 val_7 = this.baseView.transform.position;
                val_4.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                val_11.Init();
            }
            
            UnityEngine.Vector3 val_10 = this.baseView.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public BoxItemView()
        {
        
        }
    
    }

}
