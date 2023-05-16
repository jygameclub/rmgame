using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.EggItem.View
{
    public class EggItemView : ItemView
    {
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position)
        {
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 44;
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
            PlaySfx(type:  (val_2 == 0) ? 111 : ((val_2 != 1) ? (112 + 1) : 112), offset:  0.04f);
            this.SpawnParticle();
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemView>(go:  this);
        }
        private void SpawnParticle()
        {
            Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemExplodeParticles val_1 = 13632.Spawn<Royal.Scenes.Game.Mechanics.Items.EggItem.View.EggItemExplodeParticles>(poolId:  45, activate:  true);
            val_1.Play();
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public EggItemView()
        {
        
        }
    
    }

}
