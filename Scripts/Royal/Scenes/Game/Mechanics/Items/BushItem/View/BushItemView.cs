using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BushItem.View
{
    public class BushItemView : ItemView
    {
        // Fields
        private static readonly int BushState5;
        private static readonly int BushState4;
        private static readonly int BushState3;
        private static readonly int BushState2;
        private static readonly int BushState1;
        public UnityEngine.Animator bushSpineAnimator;
        public Spine.Unity.SkeletonMecanim skeletonMecanim;
        public UnityEngine.Transform view;
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.IBushItemViewDelegate itemViewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles particles;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.BushItem.View.IBushItemViewDelegate bushItemModel, UnityEngine.Vector3 position)
        {
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.itemViewDelegate = bushItemModel;
            this.InitTransform(viewDelegate:  bushItemModel, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            var val_4 = 0;
            if(mem[1152921505108054016] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    var val_5 = mem[1152921505108054024];
                val_5 = val_5 + 1;
                Royal.Scenes.Game.Mechanics.Items.BushItem.View.IBushItemViewDelegate val_2 = 1152921505108017152 + val_5;
            }
            
            this.PlayAnimationForState(state:  bushItemModel.GetLayerCount());
        }
        private int GetAnimationByState(int state)
        {
            var val_2;
            var val_5;
            val_2 = state;
            if((val_2 - 1) <= 4)
            {
                    var val_2 = 36608424 + ((state - 1)) << 2;
                val_2 = val_2 + 36608424;
            }
            else
            {
                    val_5 = 1;
                return (int)Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView.__il2cppRuntimeField_static_fields;
            }
        
        }
        private void PlayAnimationForState(int state)
        {
            this.bushSpineAnimator.Play(stateNameHash:  this.GetAnimationByState(state:  state), layer:  0, normalizedTime:  0f);
            this.bushSpineAnimator.Update(deltaTime:  UnityEngine.Time.deltaTime);
            this.skeletonMecanim.Skeleton.Update(delta:  UnityEngine.Time.deltaTime);
            this.skeletonMecanim.translator.Apply(skeleton:  this.skeletonMecanim.Skeleton);
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        public override void DisableFillMask()
        {
        
        }
        public override int GetPoolId()
        {
            return 55;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.itemViewDelegate = 0;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.Recycle<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles>(go:  this.particles);
            this.particles = 0;
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = this.GetCenterPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        public void Explode(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            bool val_4;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetBushExplode();
            val_4 = val_1.sortEverything & 4294967295;
            this.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_4});
            var val_3 = 0;
            if(mem[1152921505108054016] != null)
            {
                    val_3 = val_3 + 1;
                val_4 = 0;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.BushItem.View.IBushItemViewDelegate val_2 = 1152921505108017152 + ((mem[1152921505108054024]) << 4);
            }
            
            this.itemViewDelegate.CreateGrasses(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = point.x, y = point.y});
            this.itemViewDelegate.Recycle<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView>(go:  this);
        }
        public void Damage(int damagedLayer)
        {
            this.PlaySound(damagedLayer:  damagedLayer);
            if(damagedLayer >= 1)
            {
                    this.PlayAnimationForState(state:  damagedLayer);
            }
            
            this.SpawnParticle(particleLayer:  damagedLayer);
        }
        private void PlaySound(int damagedLayer)
        {
            var val_4;
            if((damagedLayer - 1) < 3)
            {
                    var val_3 = ((this.randomManager.Next(min:  0, max:  2)) != 0) ? (37 + 1) : 37;
            }
            else
            {
                    if(damagedLayer != 4)
            {
                    if(damagedLayer != 0)
            {
                    return;
            }
            
                this.PlaySfx(type:  35, offset:  0.04f);
                val_4 = 39;
            }
            else
            {
                    val_4 = 36;
            }
            
            }
            
            this.PlaySfx(type:  36, offset:  0.04f);
        }
        private void SpawnParticle(int particleLayer)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemExplodeParticles>(poolId:  56, activate:  true);
            this.particles = val_2;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_3:
            label_5:
            this.particles.Play(layer:  particleLayer);
            UnityEngine.Vector3 val_4 = this.view.position;
            this.particles.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            if(particleLayer != 0)
            {
                    return;
            }
            
            this.particles = 0;
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public BushItemView()
        {
        
        }
        private static BushItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView.BushState5 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_05_cicek");
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView.BushState4 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_04");
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView.BushState3 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_03");
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView.BushState2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_02");
            Royal.Scenes.Game.Mechanics.Items.BushItem.View.BushItemView.BushState1 = UnityEngine.Animator.StringToHash(name:  "Base Layer.state_01_ayi");
        }
    
    }

}
