using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot
{
    public class PropellerSpecialComboPilot : DefaultPropellerPilot
    {
        // Fields
        private const float MaxRootSpeed = 4;
        private const float MinRootSpeed = 0.5;
        private const float MaxPropRootScale = 1.1;
        private const float EdgePropRootScale = 1;
        private const float MinPropRootScale = 0.9;
        private const float RightRootEdge = 0.5;
        private const float LeftRootEdge = -0.5;
        private float maxRootRotation;
        private float rootSpeed;
        private bool isPropellerGoingRight;
        private bool isPropellerAtFront;
        private readonly Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel otherItem;
        private readonly Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView otherItemView;
        private readonly bool isRightToLeft;
        private readonly bool isFromPropeller;
        private bool isFirstRotation;
        private UnityEngine.Vector3 propScaleSmoother;
        private UnityEngine.Vector3 specialScaleSmoother;
        
        // Properties
        protected override float ScaleUpSpeedConst { get; }
        protected override float MinOutSpeedConst { get; }
        protected override float MaxOutSpeedConst { get; }
        protected override float GoSpeedMultiplierConst { get; }
        protected override float MaxGoSpeedConst { get; }
        protected override float MinDistanceToScaleDown { get; }
        public override bool ShouldPlaySfxInLoop { get; }
        
        // Methods
        protected override float get_ScaleUpSpeedConst()
        {
            return 6f;
        }
        protected override float get_MinOutSpeedConst()
        {
            return 0.5f;
        }
        protected override float get_MaxOutSpeedConst()
        {
            return 0.7f;
        }
        protected override float get_GoSpeedMultiplierConst()
        {
            return 15f;
        }
        protected override float get_MaxGoSpeedConst()
        {
            return 45f;
        }
        protected override float get_MinDistanceToScaleDown()
        {
            return 1.5f;
        }
        public override bool get_ShouldPlaySfxInLoop()
        {
            return false;
        }
        public PropellerSpecialComboPilot(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel otherItem, bool isRightToLeft, bool isFromPropeller)
        {
            this = new System.Object();
            this.otherItem = otherItem;
            this.otherItemView = otherItem.GetSpecialItemView();
            this.isRightToLeft = isRightToLeft;
            this.isFromPropeller = isFromPropeller;
        }
        protected override float GetMinFlyTime()
        {
            return 0.1f;
        }
        public override void StartFlying(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView itemView, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate viewDelegate)
        {
            this.otherItemView.transform.SetParent(p:  itemView.transform);
            this.StartFlying(itemView:  itemView, viewDelegate:  viewDelegate);
        }
        protected override bool IsPropRocketCombo()
        {
            return (bool)(this.otherItem == 2) ? 1 : 0;
        }
        protected override bool IsPropSpecialCombo()
        {
            return true;
        }
        protected override void InitializeCurveVariables(UnityEngine.Vector3 targetNormalized)
        {
            float val_12;
            float val_13;
            val_12 = targetNormalized.z;
            val_13 = targetNormalized.x;
            this.InitializeCurveVariables(targetNormalized:  new UnityEngine.Vector3() {x = val_13, y = targetNormalized.y, z = val_12});
            this.isPropellerAtFront = this.isFromPropeller;
            bool val_1 = (this.isFromPropeller == true) ? 1 : 0;
            val_1 = ((this.isRightToLeft == true) ? 1 : 0) ^ val_1;
            this.isPropellerGoingRight = val_1;
            this.isFirstRotation = true;
            this.ArrangeSorting();
            this.maxRootRotation = (this.otherItem == 4) ? 10f : 5f;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView val_4 = this.otherItem.GetSpecialItemView();
            UnityEngine.Color val_5 = val_4.shadow.color;
            val_4.shadow.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = 0.2352941f};
            if(0 != 0)
            {
                    return;
            }
            
            var val_13 = 0;
            if(mem[1152921504786489344] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    var val_14 = mem[1152921504786489352];
                val_14 = val_14 + 1;
                UnityEngine.SpriteRenderer val_6 = 1152921504786452480 + val_14;
            }
            
            UnityEngine.Vector3 val_7 = val_4.shadow.GetTargetPosition();
            val_12 = val_7.x;
            val_13 = val_7.z;
            UnityEngine.Vector3 val_8 = val_4.shadow.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = val_7.y, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            if(val_9.x > 2f)
            {
                    return;
            }
            
            mem[1152921520113802524] = 1133903872;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.forward;
            mem[1152921520113802540] = val_10.x;
            mem[1152921520113802544] = val_10.y;
            mem[1152921520113802548] = val_10.z;
            mem[1152921520113802528] = val_8.x + val_8.x;
            mem[1152921520113802536] = val_8.y + val_8.y;
        }
        protected override void TargetReached()
        {
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22).StopSoundInLoop(type:  220);
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            UnityEngine.Transform val_3 = this.otherItemView.transform;
            val_3.SetParent(p:  val_2.<ItemParent>k__BackingField);
            val_3.Reset(force:  false);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            this.otherItemView.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.TargetReached();
        }
        protected override void ArrangePosition(UnityEngine.Vector3 targetVector, UnityEngine.Vector3 targetNormalized, float distanceToTarget)
        {
            this.ArrangeRootPositions();
            this.ArrangePosition(targetVector:  new UnityEngine.Vector3() {x = targetVector.x, y = targetVector.y, z = targetVector.z}, targetNormalized:  new UnityEngine.Vector3() {x = targetNormalized.x, y = targetNormalized.y, z = targetNormalized.z}, distanceToTarget:  distanceToTarget);
        }
        protected override void ArrangeScaleDown(float scaleRatio)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = V11.16B, y = V10.16B, z = V9.16B}, target:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, maxDistanceDelta:  scaleRatio);
            this.otherItemView.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.ArrangeScaleDown(scaleRatio:  scaleRatio);
        }
        protected override void ArrangeScaleUp(UnityEngine.Vector3 targetScale, UnityEngine.Vector3 itemScale, float scaleSpeedVar)
        {
            UnityEngine.Vector3 val_3 = this.otherItemView.shadow.transform.localPosition;
            scaleSpeedVar = UnityEngine.Time.deltaTime * scaleSpeedVar;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, target:  new UnityEngine.Vector3() {x = Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime, y = Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime.__il2cppRuntimeField_4, z = Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime.__il2cppRuntimeField_8}, maxDistanceDelta:  scaleSpeedVar);
            this.otherItemView.shadow.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.ArrangeScaleUp(targetScale:  new UnityEngine.Vector3() {x = targetScale.x, y = targetScale.y, z = targetScale.z}, itemScale:  new UnityEngine.Vector3() {x = itemScale.x, y = itemScale.y, z = itemScale.z}, scaleSpeedVar:  scaleSpeedVar);
        }
        private void ArrangeSorting()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerFlyingSorting(isSpecialCombo:  true);
            bool val_2 = val_1.sortEverything & 4294967295;
            val_1.layer.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_2}, allowOtherSortingUpdates:  false);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_2}, offset:  (this.isPropellerAtFront == true) ? (-10) : 10);
            this.otherItemView.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
        }
        private void ArrangeRootPositions()
        {
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_31;
            float val_32;
            float val_33;
            bool val_34;
            UnityEngine.Vector3 val_1 = X9 + 32.GetPosition();
            UnityEngine.Vector3 val_2 = GetPosition();
            float val_21 = System.Math.Abs(val_1.x);
            val_21 = val_21 + val_21;
            float val_3 = ManualEasing.Quintic.In(t:  val_21);
            float val_4 = UnityEngine.Mathf.Lerp(a:  1.1f, b:  1f, t:  val_3);
            val_21 = UnityEngine.Mathf.Lerp(a:  0.9f, b:  1f, t:  val_3);
            float val_6 = UnityEngine.Mathf.Lerp(a:  4f, b:  0.5f, t:  val_3);
            float val_22 = val_6;
            this.rootSpeed = val_6;
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_22 * val_8;
            val_8 = val_8 * ((this.isPropellerGoingRight == false) ? -1f : 1f);
            val_22 = val_1.x + val_8;
            val_8 = val_2.x - val_8;
            val_22 = val_1.y;
            if(this.isPropellerAtFront != false)
            {
                    val_23 = val_4;
            }
            else
            {
                    val_23 = val_21;
                val_21 = val_4;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_23);
            val_24 = val_10.x;
            val_25 = val_10.y;
            val_26 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            val_27 = val_21;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_27);
            val_31 = val_12.z;
            val_32 = val_12.x;
            val_33 = val_12.y;
            X9 + 32.SetPosition(vector:  new UnityEngine.Vector3() {x = val_22, y = val_22, z = val_1.z});
            SetPosition(vector:  new UnityEngine.Vector3() {x = val_8, y = val_2.y, z = val_2.z});
            if(this.isFirstRotation != false)
            {
                    UnityEngine.Vector3 val_13 = X9 + 32.GetScale();
                val_22 = val_13.x;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = val_22, y = val_13.y, z = val_13.z}, target:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, currentVelocity: ref  new UnityEngine.Vector3() {x = this.propScaleSmoother, y = this.propScaleSmoother, z = this.propScaleSmoother}, smoothTime:  0.5f);
                val_24 = val_14.x;
                val_25 = val_14.y;
                val_26 = val_14.z;
                UnityEngine.Vector3 val_15 = GetScale();
                val_27 = val_32;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, target:  new UnityEngine.Vector3() {x = val_27, y = val_33, z = val_31}, currentVelocity: ref  new UnityEngine.Vector3() {x = this.specialScaleSmoother, y = this.specialScaleSmoother, z = this.specialScaleSmoother}, smoothTime:  0.5f);
                val_32 = val_16.x;
                val_33 = val_16.y;
                val_31 = val_16.z;
            }
            
            X9 + 32.SetScale(vector:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26});
            SetScale(vector:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_31});
            UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  -this.maxRootRotation);
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  this.maxRootRotation);
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w}, b:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, t:  val_8 + 0.5f);
            SetRotation(quaternion:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w});
            if(this.isPropellerGoingRight != false)
            {
                    if(val_22 < 0.5f)
            {
                    return;
            }
            
                val_34 = this.isPropellerAtFront;
                this.isPropellerGoingRight = false;
            }
            else
            {
                    if(val_22 > (-0.5f))
            {
                    return;
            }
            
                val_34 = this.isPropellerAtFront;
                this.isPropellerGoingRight = true;
            }
            
            val_34 = val_34 ^ 1;
            this.isPropellerAtFront = val_34;
            this.ArrangeSorting();
            this.isFirstRotation = false;
        }
    
    }

}
