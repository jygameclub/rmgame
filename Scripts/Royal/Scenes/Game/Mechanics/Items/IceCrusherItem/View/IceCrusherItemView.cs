using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View
{
    public class IceCrusherItemView : ItemView
    {
        // Fields
        private static readonly int IceCrusherDownAnimation;
        private static readonly int IceCrusherUpAnimation;
        private static readonly int IceCrusherHorizontalAnimation;
        private static readonly int IceCrusherDefault;
        private const float MaxAngleHeight = 2;
        private const float AngleSpeed = 10;
        private const float DefaultPatchHeight = 0.9214286;
        private const float DefaultPatchWidth = 0.9857143;
        private const float ShrinkSpeed = 2;
        private const float MaxAngleForMaxHeight = 0.2;
        public UnityEngine.SpriteRenderer ice;
        public UnityEngine.SpriteRenderer iceDownPatch;
        public UnityEngine.Transform machineParent;
        public UnityEngine.Transform iceParent;
        public UnityEngine.GameObject horizontalMachine;
        public UnityEngine.GameObject upMachine;
        public UnityEngine.GameObject downMachine;
        public UnityEngine.Animator iceCrusherAnimator;
        private Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate itemViewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.LogItem.View.IceCrusherItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection iceCrusherDirection;
        private float targetAngle;
        private float currentLength;
        private float targetLength;
        private int nextUnfreezeLayer;
        private int nextParticlesLayer;
        private bool isIceAnimating;
        private Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherParticles iceCrusherParticles;
        private static readonly int Finish;
        private bool sortingIsIncreased;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer, Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection iceCrusherDirection)
        {
            this.itemViewDelegate = viewDelegate;
            this.itemAssets = 185636.Load<Royal.Scenes.Game.Mechanics.Items.LogItem.View.IceCrusherItemAssets>();
            this.iceCrusherDirection = iceCrusherDirection;
            this.currentLength = (float)layer;
            this.targetLength = (float)layer;
            this.nextUnfreezeLayer = layer;
            this.nextParticlesLayer = layer;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.CalculateBarSize(layer:  (float)layer);
            this.CalculateMachine();
            this.ResetIceParentRotation();
            this.sortingIsIncreased = false;
        }
        private void PlayAnimationByType()
        {
            UnityEngine.Animator val_3;
            float val_4;
            this.iceCrusherAnimator.SetBool(id:  Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.Finish, value:  false);
            if((this.iceCrusherDirection - 1) < 2)
            {
                goto label_4;
            }
            
            if(this.iceCrusherDirection == 3)
            {
                goto label_5;
            }
            
            if(this.iceCrusherDirection != 4)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            val_3 = this.iceCrusherAnimator;
            val_4 = Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.MaxAngleForMaxHeight;
            goto label_14;
            label_4:
            val_3 = this.iceCrusherAnimator;
            val_4 = Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.IceCrusherHorizontalAnimation;
            goto label_14;
            label_5:
            val_3 = this.iceCrusherAnimator;
            val_4 = Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.IceCrusherUpAnimation;
            label_14:
            val_3.Play(stateNameHash:  val_4, layer:  0, normalizedTime:  0f);
        }
        private void CalculateMachine()
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_35 = this.iceCrusherDirection;
            val_35 = val_35 - 1;
            if(val_35 > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_36 = 36605836 + ((this.iceCrusherDirection - 1)) << 2;
            val_36 = val_36 + 36605836;
            goto (36605836 + ((this.iceCrusherDirection - 1)) << 2 + 36605836);
        }
        private void CalculateBarSize(float layer)
        {
            var val_27 = this;
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_27 = this.iceCrusherDirection;
            val_27 = val_27 - 1;
            if(val_27 > 3)
            {
                    return;
            }
            
            var val_28 = 36605820 + ((this.iceCrusherDirection - 1)) << 2;
            val_28 = val_28 + 36605820;
            goto (36605820 + ((this.iceCrusherDirection - 1)) << 2 + 36605820);
        }
        private void ArrangeIceParentRotation()
        {
            float val_10;
            float val_11;
            float val_9 = 2f;
            val_9 = val_9 / this.currentLength;
            float val_10 = System.Math.Abs(val_9);
            UnityEngine.Quaternion val_1 = this.iceParent.localRotation;
            float val_11 = -360f;
            val_11 = val_1.z + val_11;
            float val_2 = (val_1.z > 180f) ? (val_11) : val_1.z;
            val_10 = val_2;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_10, b:  this.targetAngle, precision:  0.001f)) != false)
            {
                    float val_4 = UnityEngine.Random.value;
                val_4 = val_10 * val_4;
                val_10 = val_4 + val_4;
                val_11 = val_10 - val_10;
                this.targetAngle = val_11;
            }
            else
            {
                    val_11 = this.targetAngle;
            }
            
            float val_12 = 10f;
            val_12 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime * val_12;
            val_12 = val_10 * val_12;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  UnityEngine.Mathf.MoveTowards(current:  val_2, target:  val_11, maxDelta:  val_12 / 0.2f));
            this.iceParent.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
        }
        private void ResetIceParentRotation()
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this.iceParent.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
            this.targetAngle = 0f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.machineParent.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public override int GetPoolId()
        {
            return 72;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        private void Explode()
        {
            Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate val_10;
            var val_11;
            var val_9 = 0;
            if(mem[1152921505099747328] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate val_1 = 1152921505099710464 + ((mem[1152921505099747336]) << 4);
            }
            
            this.itemViewDelegate.FinalExplode();
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherExplodeParticles val_2 = this.itemViewDelegate.Spawn<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherExplodeParticles>(poolId:  74, activate:  true);
            val_2.ArrangePositionByType(direction:  this.iceCrusherDirection);
            val_2.Play();
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_10 = 1152921505100083200;
            val_11 = 0;
            this.iceCrusherAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.IceCrusherDefault, layer:  0, normalizedTime:  0f);
            this.iceCrusherAnimator.Update(deltaTime:  UnityEngine.Time.deltaTime);
            float val_10 = this.targetLength;
            if(val_10 < 0)
            {
                    val_10 = (float)this.nextUnfreezeLayer - val_10;
                int val_13 = (int)val_10;
                if(val_13 >= (1.401298E-45f))
            {
                    do
            {
                val_10 = this.itemViewDelegate;
                var val_11 = 0;
                if(mem[1152921505099747328] != null)
            {
                    val_11 = val_11 + 1;
                val_11 = 1;
            }
            else
            {
                    var val_12 = mem[1152921505099747336];
                val_12 = val_12 + 1;
                Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate val_7 = 1152921505099710464 + val_12;
            }
            
                val_10.UnfreezeLayer(layer:  this.nextUnfreezeLayer);
                val_13 = val_13 - 1;
                this.nextUnfreezeLayer = this.nextUnfreezeLayer - 1;
            }
            while(mem[1152921505099747328] > null);
            
            }
            
            }
            
            this.itemViewDelegate = 0;
            this.iceCrusherParticles = 0;
            val_10.Recycle<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView>(go:  this);
        }
        public void Damage(int layer)
        {
            this.targetLength = (float)layer;
        }
        private void Update()
        {
            float val_15;
            float val_16;
            Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate val_17;
            int val_19;
            var val_20;
            if(this.itemViewDelegate == null)
            {
                    return;
            }
            
            val_15 = this.currentLength;
            if(this.targetLength < 0)
            {
                    float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
                val_1 = val_1 + val_1;
                float val_2 = val_15 - val_1;
                this.currentLength = val_2;
                float val_3 = UnityEngine.Mathf.Max(a:  val_2, b:  this.targetLength);
                this.currentLength = val_3;
                this.CalculateBarSize(layer:  val_3);
                val_16 = this.currentLength;
                float val_15 = (float)this.nextParticlesLayer;
                val_15 = val_15 - val_16;
                if(val_15 > 0f)
            {
                    this.PlayParticles();
                int val_16 = this.nextParticlesLayer;
                val_16 = this.currentLength;
                val_16 = val_16 - 1;
                this.nextParticlesLayer = val_16;
            }
            
                Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_17 = this.iceCrusherDirection;
                val_17 = val_17 - 3;
                val_16 = (float)this.nextUnfreezeLayer - val_16;
                if(val_16 > ((val_17 > 1) ? 0.6f : 0.5f))
            {
                    val_17 = this.itemViewDelegate;
                var val_18 = 0;
                if(mem[1152921505099747328] != null)
            {
                    val_18 = val_18 + 1;
            }
            else
            {
                    var val_19 = mem[1152921505099747336];
                val_19 = val_19 + 1;
                Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate val_5 = 1152921505099710464 + val_19;
            }
            
                val_19 = this.nextUnfreezeLayer;
                val_17.UnfreezeLayer(layer:  val_19);
                int val_20 = this.nextUnfreezeLayer;
                val_20 = val_20 - 1;
                this.nextUnfreezeLayer = val_20;
            }
            
                this.ArrangeIceParentRotation();
                if(this.isIceAnimating != true)
            {
                    this.PlayAnimationByType();
                val_19 = 138;
                this.PlaySfxInLoop(type:  138);
            }
            
                val_15 = this.currentLength;
                this.isIceAnimating = true;
            }
            
            if(((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_15, b:  this.targetLength, precision:  0.001f)) != false) && (this.isIceAnimating != false))
            {
                    this.isIceAnimating = false;
                this.ResetIceParentRotation();
                this.iceCrusherParticles.Pause();
                val_17 = 1152921505100083200;
                val_20 = 1;
                this.iceCrusherAnimator.SetBool(id:  Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.Finish, value:  true);
                float val_21 = this.targetLength;
                if(val_21 < 0)
            {
                    val_21 = (float)this.nextUnfreezeLayer - val_21;
                int val_24 = (int)val_21;
                if(val_24 >= (1.401298E-45f))
            {
                    do
            {
                val_17 = this.itemViewDelegate;
                var val_22 = 0;
                if(mem[1152921505099747328] != null)
            {
                    val_22 = val_22 + 1;
                val_20 = 1;
            }
            else
            {
                    var val_23 = mem[1152921505099747336];
                val_23 = val_23 + 1;
                Royal.Scenes.Game.Mechanics.Items.LogItem.View.IIceCrusherItemViewDelegate val_7 = 1152921505099710464 + val_23;
            }
            
                val_17.UnfreezeLayer(layer:  this.nextUnfreezeLayer);
                val_24 = val_24 - 1;
                int val_8 = this.nextUnfreezeLayer - 1;
                this.nextUnfreezeLayer = val_8;
            }
            while(mem[1152921505099747328] > null);
            
            }
            
            }
            
                val_19 = 138;
                val_17.StopSoundInLoop(type:  138);
                bool val_9 = Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.targetLength, b:  0f, precision:  0.001f);
                if(val_9 != true)
            {
                    val_19 = 139;
                val_9.PlaySfx(type:  139, offset:  0.04f);
            }
            
            }
            
            if((this.currentLength < 0) && (this.sortingIsIncreased != true))
            {
                    this.sortingIsIncreased = true;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetIceCrusherExplodeSorting();
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_8, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_10.layer, order = val_10.order, sortEverything = val_10.sortEverything & 4294967295});
                val_19 = 140;
                val_8.PlaySfx(type:  140, offset:  0.04f);
            }
            
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.currentLength, b:  0f, precision:  0.001f)) == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetIceCrusherExplodeSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_8, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_13.layer, order = val_13.order, sortEverything = val_13.sortEverything & 4294967295});
            this.Explode();
        }
        private void PlayParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherDirection val_6 = this.iceCrusherDirection;
            this.iceCrusherParticles = 19493.Spawn<Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherParticles>(poolId:  73, activate:  true);
            val_6 = val_6 - 1;
            if(val_6 > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_7 = 36605852 + ((this.iceCrusherDirection - 1)) << 2;
            val_7 = val_7 + 36605852;
            goto (36605852 + ((this.iceCrusherDirection - 1)) << 2 + 36605852);
        }
        private float GetUnfreezeRatio()
        {
            if(this.iceCrusherDirection != 4)
            {
                    return (float)(this.iceCrusherDirection == 3) ? 0.5f : 0.6f;
            }
            
            return 0.5f;
        }
        public IceCrusherItemView()
        {
        
        }
        private static IceCrusherItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.MaxAngleForMaxHeight = UnityEngine.Animator.StringToHash(name:  "Base Layer.asagi_oyna");
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.IceCrusherUpAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.yukari_oyna");
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.IceCrusherHorizontalAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.yatay_oyna");
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.IceCrusherDefault = UnityEngine.Animator.StringToHash(name:  "Base Layer.ice_crusher_default");
            Royal.Scenes.Game.Mechanics.Items.IceCrusherItem.View.IceCrusherItemView.Finish = UnityEngine.Animator.StringToHash(name:  "finish");
        }
    
    }

}
