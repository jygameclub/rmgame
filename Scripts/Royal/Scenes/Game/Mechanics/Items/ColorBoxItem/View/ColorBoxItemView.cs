using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View
{
    public class ColorBoxItemView : ItemView
    {
        // Fields
        public UnityEngine.SpriteRenderer baseView;
        private Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType color;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position, Royal.Scenes.Game.Mechanics.Matches.MatchType color, int layerCount)
        {
            Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemAssets>();
            this.itemAssets = val_1;
            this.baseView.sprite = val_1.GetSpriteForColor(matchType:  color, layer:  layerCount);
            this.color = color;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 67;
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
            PlaySfx(type:  (val_2 == 0) ? 77 : ((val_2 != 1) ? (78 + 1) : 78), offset:  0.04f);
            this.ExplodeParticle(damagedLayer:  0);
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemView>(go:  this);
        }
        private void ExplodeParticle(int damagedLayer)
        {
            Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemExplodeParticles val_1 = 8406.Spawn<Royal.Scenes.Game.Mechanics.Items.ColorBoxItem.View.ColorBoxItemExplodeParticles>(poolId:  68, activate:  true);
            val_1.Play(matchType:  this.color, layer:  damagedLayer);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public void Damage(int damagedLayer)
        {
            int val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  3);
            PlaySfx(type:  (val_2 == 0) ? 80 : ((val_2 != 1) ? (81 + 1) : 81), offset:  0.04f);
            this.baseView.sprite = this.itemAssets.GetSpriteForColor(matchType:  this.color, layer:  damagedLayer);
            this.ExplodeParticle(damagedLayer:  damagedLayer);
        }
        public ColorBoxItemView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
