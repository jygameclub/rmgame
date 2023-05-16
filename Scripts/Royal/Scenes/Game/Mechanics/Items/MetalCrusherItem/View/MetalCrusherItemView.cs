using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View
{
    public class MetalCrusherItemView : ItemView
    {
        // Fields
        private static readonly int MetalCrusherHorizontalAnimation;
        private static readonly int MetalCrusherVerticalAnimation;
        private static readonly int MetalCrusherDefault;
        private const float MaxAngleHeight = 2;
        private const float AngleSpeed = 10;
        private const float ShrinkSpeed = 2;
        private const float MaxAngleForMaxHeight = 0.2;
        private const float ShadowAlpha = 1;
        public UnityEngine.SpriteRenderer furnace;
        public UnityEngine.SpriteRenderer furnaceHeated;
        public UnityEngine.SpriteRenderer furnaceAnim;
        public UnityEngine.Transform furnaceExtraPositioner;
        public UnityEngine.SpriteRenderer furnaceExtra;
        public UnityEngine.SpriteRenderer furnaceExtraHeated;
        public UnityEngine.SpriteRenderer metal;
        public UnityEngine.SpriteRenderer pipeHeat;
        public UnityEngine.SpriteRenderer furnaceExtraShadow;
        public UnityEngine.Transform pipeHeatRotator;
        public UnityEngine.Transform machineParent;
        public UnityEngine.Transform metalParent;
        public UnityEngine.Animator metalCrusherAnimator;
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate itemViewDelegate;
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection metalCrusherDirection;
        private float targetAngle;
        private float currentLength;
        private float targetLength;
        private int nextUnfreezeLayer;
        private int nextParticlesLayer;
        private bool isMetalAnimating;
        private bool sortingIsIncreased;
        private bool heatIsDisplaced;
        private bool shadowIsFadedOut;
        private UnityEngine.Coroutine pipeHeatCoroutine;
        private Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherParticles metalCrusherParticles;
        private static readonly int Finish;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer, Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection metalCrusherDirection)
        {
            this.itemViewDelegate = viewDelegate;
            this.itemAssets = 185636.Load<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemAssets>();
            this.metalCrusherDirection = metalCrusherDirection;
            this.currentLength = (float)layer;
            this.targetLength = (float)layer;
            this.nextUnfreezeLayer = layer;
            this.nextParticlesLayer = layer;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.CalculateMachine();
            this.ResetRotation();
            this.CalculateBarSize(layer:  (float)layer);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.furnaceExtraShadow, alpha:  1f);
            this.sortingIsIncreased = false;
            this.heatIsDisplaced = false;
            this.shadowIsFadedOut = false;
        }
        private void PlayAnimationByType()
        {
            UnityEngine.Animator val_3;
            int val_4;
            this.TogglePipeHeat(isEnabled:  true);
            this.metalCrusherAnimator.SetBool(id:  Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.Finish, value:  false);
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection val_3 = this.metalCrusherDirection;
            if((val_3 - 1) >= 2)
            {
                    val_3 = val_3 - 3;
                if(val_3 > 1)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
                val_3 = this.metalCrusherAnimator;
                val_4 = Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.MetalCrusherVerticalAnimation;
            }
            else
            {
                    val_3 = this.metalCrusherAnimator;
                val_4 = Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.ShadowAlpha;
            }
            
            val_3.Play(stateNameHash:  val_4, layer:  0, normalizedTime:  0f);
        }
        private void CalculateMachine()
        {
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection val_80 = this.metalCrusherDirection;
            val_80 = val_80 - 1;
            if(val_80 > 3)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            var val_81 = 36613852 + ((this.metalCrusherDirection - 1)) << 2;
            val_81 = val_81 + 36613852;
            goto (36613852 + ((this.metalCrusherDirection - 1)) << 2 + 36613852);
        }
        private void CalculateBarSize(float layer)
        {
            var val_19 = this;
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection val_19 = this.metalCrusherDirection;
            val_19 = val_19 - 1;
            if(val_19 > 3)
            {
                    return;
            }
            
            var val_20 = 36613868 + ((this.metalCrusherDirection - 1)) << 2;
            val_20 = val_20 + 36613868;
            goto (36613868 + ((this.metalCrusherDirection - 1)) << 2 + 36613868);
        }
        private void ResetRotation()
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this.metalParent.localRotation = new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w};
            this.targetAngle = 0f;
            this.ResetPipeHeatTransform();
        }
        public void TogglePipeHeat(bool isEnabled)
        {
            if(this.pipeHeatCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.pipeHeatCoroutine);
                this.pipeHeatCoroutine = 0;
            }
            
            this.pipeHeatCoroutine = this.StartCoroutine(routine:  this.AnimatePipeHeat(isEnabled:  isEnabled));
        }
        private System.Collections.IEnumerator AnimatePipeHeat(bool isEnabled)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .isEnabled = isEnabled;
            return (System.Collections.IEnumerator)new MetalCrusherItemView.<AnimatePipeHeat>d__42();
        }
        private System.Collections.IEnumerator AnimateShadowDisappear()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MetalCrusherItemView.<AnimateShadowDisappear>d__43();
        }
        private System.Collections.IEnumerator AnimatePipeHeat()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new MetalCrusherItemView.<AnimatePipeHeat>d__44();
        }
        public override int GetPoolId()
        {
            return 112;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0.7785714f, y:  0.9714286f);
            this.pipeHeat.size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            this.ResetPipeHeatTransform();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.pipeHeat, alpha:  0f);
            if(this.pipeHeatCoroutine == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.pipeHeatCoroutine);
            this.pipeHeatCoroutine = 0;
        }
        private void Explode()
        {
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate val_10;
            var val_11;
            var val_9 = 0;
            if(mem[1152921505096978432] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate val_1 = 1152921505096941568 + ((mem[1152921505096978440]) << 4);
            }
            
            this.itemViewDelegate.FinalExplode();
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherExplodeParticles val_2 = this.itemViewDelegate.Spawn<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherExplodeParticles>(poolId:  114, activate:  true);
            val_2.ArrangePositionByType(direction:  this.metalCrusherDirection);
            val_2.Play();
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_10 = 1152921505097207808;
            val_11 = 0;
            this.metalCrusherAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.MetalCrusherDefault, layer:  0, normalizedTime:  0f);
            this.metalCrusherAnimator.Update(deltaTime:  UnityEngine.Time.deltaTime);
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
                if(mem[1152921505096978432] != null)
            {
                    val_11 = val_11 + 1;
                val_11 = 1;
            }
            else
            {
                    var val_12 = mem[1152921505096978440];
                val_12 = val_12 + 1;
                Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate val_7 = 1152921505096941568 + val_12;
            }
            
                val_10.UnfreezeLayer(layer:  this.nextUnfreezeLayer);
                val_13 = val_13 - 1;
                this.nextUnfreezeLayer = this.nextUnfreezeLayer - 1;
            }
            while(mem[1152921505096978432] > null);
            
            }
            
            }
            
            this.itemViewDelegate = 0;
            this.metalCrusherParticles = 0;
            val_10.Recycle<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView>(go:  this);
        }
        public void Damage(int layer)
        {
            this.targetLength = (float)layer;
        }
        private void Update()
        {
            float val_18;
            float val_19;
            int val_20;
            var val_21;
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate val_22;
            var val_24;
            float val_26;
            if(this.itemViewDelegate == null)
            {
                    return;
            }
            
            val_18 = this.currentLength;
            if(this.targetLength < 0)
            {
                    float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
                val_1 = val_1 + val_1;
                float val_2 = val_18 - val_1;
                this.currentLength = val_2;
                float val_3 = UnityEngine.Mathf.Max(a:  val_2, b:  this.targetLength);
                this.currentLength = val_3;
                this.CalculateBarSize(layer:  val_3);
                val_19 = this.currentLength;
                float val_18 = (float)this.nextParticlesLayer;
                val_18 = val_18 - val_19;
                if(val_18 > 0f)
            {
                    val_20 = 187;
                val_21 = 0;
                this.PlaySfx(type:  187, offset:  0.04f);
                this.PlayParticles();
                int val_19 = this.nextParticlesLayer;
                val_19 = this.currentLength;
                val_19 = val_19 - 1;
                this.nextParticlesLayer = val_19;
            }
            
                Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection val_20 = this.metalCrusherDirection;
                val_20 = val_20 - 3;
                val_19 = (float)this.nextUnfreezeLayer - val_19;
                if(val_19 > ((val_20 > 1) ? 0.6f : 0.5f))
            {
                    val_22 = this.itemViewDelegate;
                var val_21 = 0;
                if(mem[1152921505096978432] != null)
            {
                    val_21 = val_21 + 1;
                val_21 = 1;
            }
            else
            {
                    var val_22 = mem[1152921505096978440];
                val_22 = val_22 + 1;
                Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate val_5 = 1152921505096941568 + val_22;
            }
            
                val_20 = this.nextUnfreezeLayer;
                val_22.UnfreezeLayer(layer:  val_20);
                int val_23 = this.nextUnfreezeLayer;
                val_23 = val_23 - 1;
                this.nextUnfreezeLayer = val_23;
            }
            
                this.ArrangeMetalParentRotation();
                if(this.isMetalAnimating != true)
            {
                    this.PlayAnimationByType();
            }
            
                val_18 = this.currentLength;
                this.isMetalAnimating = true;
            }
            
            if(((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_18, b:  this.targetLength, precision:  0.001f)) != false) && (this.isMetalAnimating != false))
            {
                    this.isMetalAnimating = false;
                this.ResetRotation();
                val_22 = 1152921505097207808;
                val_24 = 1;
                val_20 = Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.Finish;
                this.metalCrusherAnimator.SetBool(id:  val_20, value:  true);
                float val_24 = this.targetLength;
                if(val_24 < 0)
            {
                    val_24 = (float)this.nextUnfreezeLayer - val_24;
                int val_27 = (int)val_24;
                if(val_27 >= (1.401298E-45f))
            {
                    do
            {
                val_22 = this.itemViewDelegate;
                var val_25 = 0;
                if(mem[1152921505096978432] != null)
            {
                    val_25 = val_25 + 1;
                val_24 = 1;
            }
            else
            {
                    var val_26 = mem[1152921505096978440];
                val_26 = val_26 + 1;
                Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.IMetalCrusherItemViewDelegate val_7 = 1152921505096941568 + val_26;
            }
            
                val_20 = this.nextUnfreezeLayer;
                val_22.UnfreezeLayer(layer:  val_20);
                val_27 = val_27 - 1;
                int val_8 = this.nextUnfreezeLayer - 1;
                this.nextUnfreezeLayer = val_8;
            }
            while(mem[1152921505096978432] > null);
            
            }
            
            }
            
            }
            
            val_26 = this.currentLength;
            if((val_26 < 0) && (this.heatIsDisplaced != true))
            {
                    this.heatIsDisplaced = true;
                val_20 = this.AnimatePipeHeat();
                UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  val_20);
                val_26 = this.currentLength;
            }
            
            if((val_26 < 0) && (this.shadowIsFadedOut != true))
            {
                    this.shadowIsFadedOut = true;
                val_20 = this.AnimateShadowDisappear();
                UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  val_20);
                val_26 = this.currentLength;
            }
            
            if((val_26 < 0) && (this.sortingIsIncreased != true))
            {
                    this.sortingIsIncreased = true;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_13 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetIceCrusherExplodeSorting();
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_8, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_13.layer, order = val_13.order, sortEverything = val_13.sortEverything & 4294967295});
                val_20 = 188;
                val_8.PlaySfx(type:  188, offset:  0.04f);
            }
            
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.currentLength, b:  0f, precision:  0.001f)) == false)
            {
                    return;
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_16 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetIceCrusherExplodeSorting();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  val_8, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_16.layer, order = val_16.order, sortEverything = val_16.sortEverything & 4294967295});
            this.Explode();
        }
        private void ArrangeMetalParentRotation()
        {
            float val_14;
            float val_15;
            float val_13 = 2f;
            val_13 = val_13 / this.currentLength;
            float val_14 = System.Math.Abs(val_13);
            UnityEngine.Quaternion val_1 = this.metalParent.localRotation;
            float val_15 = -360f;
            val_15 = val_1.z + val_15;
            float val_2 = (val_1.z > 180f) ? (val_15) : val_1.z;
            val_14 = val_2;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_14, b:  this.targetAngle, precision:  0.001f)) != false)
            {
                    float val_4 = UnityEngine.Random.value;
                val_4 = val_14 * val_4;
                val_14 = val_4 + val_4;
                val_15 = val_14 - val_14;
                this.targetAngle = val_15;
            }
            else
            {
                    val_15 = this.targetAngle;
            }
            
            float val_16 = 10f;
            val_16 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime * val_16;
            val_16 = val_14 * val_16;
            float val_7 = UnityEngine.Mathf.MoveTowards(current:  val_2, target:  val_15, maxDelta:  val_16 / 0.2f);
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_7);
            this.metalParent.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
            this.ResetPipeHeatTransform();
            UnityEngine.Vector3 val_11 = this.metalParent.transform.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
            this.pipeHeat.transform.RotateAround(point:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, axis:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, angle:  val_7);
        }
        private void ResetPipeHeatTransform()
        {
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.597f, y:  0f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.pipeHeat.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            this.pipeHeat.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        private void PlayParticles()
        {
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherParticles val_1 = 24421.Spawn<Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherParticles>(poolId:  113, activate:  true);
            this.metalCrusherParticles = val_1;
            UnityEngine.Vector3 val_3 = this.machineParent.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.metalCrusherParticles.Prepare(direction:  this.metalCrusherDirection);
            this.metalCrusherParticles.Play();
        }
        private float GetUnfreezeRatio()
        {
            if(this.metalCrusherDirection != 4)
            {
                    return (float)(this.metalCrusherDirection == 3) ? 0.5f : 0.6f;
            }
            
            return 0.5f;
        }
        public MetalCrusherItemView()
        {
        
        }
        private static MetalCrusherItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.ShadowAlpha = UnityEngine.Animator.StringToHash(name:  "Base Layer.metal_yatay_oyna");
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.MetalCrusherVerticalAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.metal_dikey_oyna");
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.MetalCrusherDefault = UnityEngine.Animator.StringToHash(name:  "Base Layer.metal_crusher_default");
            Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView.Finish = UnityEngine.Animator.StringToHash(name:  "finish");
        }
    
    }

}
