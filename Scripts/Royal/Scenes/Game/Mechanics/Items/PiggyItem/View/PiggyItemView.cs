using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.PiggyItem.View
{
    public class PiggyItemView : ItemView
    {
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 75;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void Explode()
        {
            int val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  3);
            PlaySfx(type:  (val_2 == 0) ? 221 : ((val_2 != 1) ? (222 + 1) : 222), offset:  0.04f);
            this.SpawnParticle();
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView>(go:  this);
        }
        private void SpawnParticle()
        {
            Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemExplodeParticles val_1 = 27036.Spawn<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemExplodeParticles>(poolId:  76, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public PiggyItemView()
        {
        
        }
    
    }

}
