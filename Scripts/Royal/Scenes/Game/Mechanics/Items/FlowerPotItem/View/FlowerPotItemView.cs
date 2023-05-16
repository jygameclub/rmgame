using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View
{
    public class FlowerPotItemView : ItemView
    {
        // Fields
        private static readonly int FlowerPotState1;
        private static readonly int FlowerPotState2;
        public Spine.Unity.SkeletonMecanim skeletonMecanim;
        public UnityEngine.Animator animator;
        private Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate itemViewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles particles;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate flowerPotItemModel, UnityEngine.Vector3 position)
        {
            this.itemViewDelegate = flowerPotItemModel;
            this.InitTransform(viewDelegate:  flowerPotItemModel, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView.FlowerPotState1, layer:  0, normalizedTime:  0f);
            this.animator.Update(deltaTime:  UnityEngine.Time.deltaTime);
        }
        public override int GetPoolId()
        {
            return 85;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.Recycle<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles>(go:  this.particles);
            this.particles = 0;
        }
        public void Damage(int damagedLayer)
        {
            this.SpawnParticle(damagedLayer:  damagedLayer);
            if(damagedLayer >= 1)
            {
                    Royal.Scenes.Start.Context.Units.Audio.AudioClipType val_1 = SelectRandomClip(from:  122, to:  123);
                PlaySfx(type:  val_1, offset:  0.04f);
                this.PlayAnimationForState(damagedLayer:  val_1);
                return;
            }
            
            PlaySfx(type:  SelectRandomClip(from:  124, to:  125), offset:  0.04f);
            PlaySfx(type:  126, offset:  0.04f);
            Recycle<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView>(go:  this);
        }
        private void SpawnParticle(int damagedLayer)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemExplodeParticles>(poolId:  86, activate:  true);
            this.particles = val_2;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_3:
            label_5:
            this.particles.Play(layer:  damagedLayer);
            UnityEngine.Vector3 val_5 = this.transform.position;
            this.particles.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(damagedLayer != 0)
            {
                    return;
            }
            
            this.particles = 0;
        }
        public override void EnableFillMask()
        {
            this.EnableFillMask();
            this.skeletonMecanim = 2;
        }
        public override void DisableFillMask()
        {
            this.DisableFillMask();
            this.skeletonMecanim = 0;
        }
        private void PlayAnimationForState(int damagedLayer)
        {
            this.animator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView.FlowerPotState2);
        }
        public override bool IsReverseSorted()
        {
            if(W8 == 0)
            {
                    return (bool)(W8 == 0) ? 1 : 0;
            }
            
            return false;
        }
        public FlowerPotItemView()
        {
        
        }
        private static FlowerPotItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView.FlowerPotState1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_1");
            Royal.Scenes.Game.Mechanics.Items.FlowerPotItem.View.FlowerPotItemView.FlowerPotState2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_2");
        }
    
    }

}
