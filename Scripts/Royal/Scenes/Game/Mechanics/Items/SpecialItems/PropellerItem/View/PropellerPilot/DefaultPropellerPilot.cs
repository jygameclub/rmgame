using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot
{
    public class DefaultPropellerPilot : IPropellerPilot
    {
        // Fields
        protected static UnityEngine.Vector3 maxShadowDistance;
        protected const float OutDuration = 0.75;
        protected const float OutLimit = 0.7;
        private const float MaxScale = 1.5;
        private const float MinOutDegree = 20;
        private const float MaxOutDegree = 100;
        private const float StartOutSpeedConst = 0.2;
        private const float GoRatio = 0.7;
        private const float GoStartSpeed = 0;
        private const float DownLimit = 0.3;
        private const float MaxDeltaTime = 0.5;
        protected float outSpeed;
        protected float elapsed;
        protected float moveCanceledAtTime;
        protected float maxOutDegreeVar;
        protected float startOutSpeed;
        protected float minOutSpeed;
        protected float maxOutSpeed;
        protected UnityEngine.Vector3 outVectorType;
        protected UnityEngine.Vector3 maxReachedShadowDistance;
        protected UnityEngine.Vector3 combinedVelocity;
        protected bool isOnEdge;
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView itemView;
        protected UnityEngine.Transform transform;
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate viewDelegate;
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState flyState;
        private float outDegree;
        private float rotationSmoothVel;
        private float rotationFanSmoothVel;
        private float goSpeed;
        private float maxReachedScale;
        private float scaleDownStartDistance;
        private int lastRunFrame;
        private Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerScaleState scaleState;
        private UnityEngine.Vector3 combinedVelocitySmoother;
        private bool updateSortingForScaleDown;
        
        // Properties
        protected virtual float ScaleUpSpeedConst { get; }
        protected virtual float MinOutSpeedConst { get; }
        protected virtual float MaxOutSpeedConst { get; }
        protected virtual float GoSpeedMultiplierConst { get; }
        protected virtual float MaxGoSpeedConst { get; }
        protected virtual float MinDistanceToScaleDown { get; }
        public virtual bool ShouldPlaySfxInLoop { get; }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState FlyState { get; }
        
        // Methods
        protected virtual float get_ScaleUpSpeedConst()
        {
            return 4f;
        }
        protected virtual float get_MinOutSpeedConst()
        {
            return 0.8f;
        }
        protected virtual float get_MaxOutSpeedConst()
        {
            return 1f;
        }
        protected virtual float get_GoSpeedMultiplierConst()
        {
            return 20f;
        }
        protected virtual float get_MaxGoSpeedConst()
        {
            return 50f;
        }
        protected virtual float get_MinDistanceToScaleDown()
        {
            return 1f;
        }
        public virtual bool get_ShouldPlaySfxInLoop()
        {
            return true;
        }
        public Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState get_FlyState()
        {
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState)this.flyState;
        }
        public virtual void StartFlying(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerItemView itemView, Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate viewDelegate)
        {
            this.itemView = itemView;
            this.transform = itemView.transform;
            this.viewDelegate = viewDelegate;
            this.flyState = this;
            this.lastRunFrame = 0;
            var val_6 = 0;
            if(mem[1152921505091121152] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    var val_7 = mem[1152921505091121160];
                val_7 = val_7 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_2 = 1152921505091084288 + val_7;
            }
            
            UnityEngine.Vector3 val_3 = viewDelegate.GetTargetPosition();
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        protected virtual Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState GetStartState()
        {
            return 2;
        }
        public virtual void TargetChanged()
        {
            this.goSpeed = 0f;
            this.flyState = 2;
            this.elapsed = UnityEngine.Mathf.Min(a:  0.5f, b:  this.elapsed);
            this.moveCanceledAtTime = Royal.Scenes.Game.Levels.LevelContext.Time;
            if(this.scaleState != 2)
            {
                    return;
            }
            
            this.scaleState = 1;
        }
        public virtual void Move()
        {
            if(this.lastRunFrame == Royal.Scenes.Game.Levels.LevelContext.FrameCount)
            {
                    return;
            }
            
            this.lastRunFrame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
            float val_3 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_3 = this.elapsed + val_3;
            this.elapsed = val_3;
            var val_11 = 0;
            if(mem[1152921505091121152] != null)
            {
                    val_11 = val_11 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_4 = 1152921505091084288 + ((mem[1152921505091121160]) << 4);
            }
            
            if(this.viewDelegate.IsTargetValid() == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot).__il2cppRuntimeField_270;
        }
        protected virtual void MoveToTarget()
        {
            var val_10 = 0;
            if(mem[1152921505091121152] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    var val_11 = mem[1152921505091121160];
                val_11 = val_11 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_1 = 1152921505091084288 + val_11;
            }
            
            UnityEngine.Vector3 val_2 = this.viewDelegate.GetTargetPosition();
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.ArrangeScale(distanceToTarget:  val_4.x);
            UnityEngine.Vector3 val_5 = this.transform.position;
            var val_12 = 0;
            if(mem[1152921505091121152] != null)
            {
                    val_12 = val_12 + 1;
            }
            else
            {
                    var val_13 = mem[1152921505091121160];
                val_13 = val_13 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_6 = 1152921505091084288 + val_13;
            }
            
            UnityEngine.Vector3 val_7 = this.viewDelegate.GetTargetPosition();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            if(this.elapsed < val_8.x)
            {
                    return;
            }
            
            if(val_8.x < 0)
            {
                    return;
            }
            
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_8.x, b:  0f, precision:  0.001f)) == false)
            {
                    return;
            }
        
        }
        protected virtual float GetMinFlyTime()
        {
            return 0.5f;
        }
        protected virtual void InitializeCurveVariables(UnityEngine.Vector3 targetNormalized)
        {
            float val_19;
            float val_20;
            var val_21;
            var val_22;
            var val_23;
            this.itemView.PlayStartFlyAnimation(isSwipe:  false);
            this.elapsed = 0f;
            this.moveCanceledAtTime = 0f;
            this.scaleState = 1;
            this.outDegree = ;
            this.rotationSmoothVel = ;
            this.rotationFanSmoothVel = 0f;
            this.goSpeed = 0f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.combinedVelocity = val_1;
            mem[1152921520109969928] = val_1.y;
            mem[1152921520109969932] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.combinedVelocitySmoother = val_2;
            mem[1152921520109970008] = val_2.y;
            mem[1152921520109970012] = val_2.z;
            this.startOutSpeed = 0.2f;
            this.minOutSpeed = val_2.x;
            this.maxOutSpeed = val_2.x;
            UnityEngine.Vector3 val_3 = this.transform.localPosition;
            bool val_4 = (val_3.x < 0) ? 1 : 0;
            val_4 = val_4 | ((val_3.x > 6f) ? 1 : 0);
            this.isOnEdge = val_4;
            var val_19 = 0;
            if(mem[1152921505091121152] != null)
            {
                    val_19 = val_19 + 1;
            }
            else
            {
                    var val_20 = mem[1152921505091121160];
                val_20 = val_20 + 1;
                Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.IPropellerItemViewDelegate val_7 = 1152921505091084288 + val_20;
            }
            
            UnityEngine.Vector3 val_8 = this.viewDelegate.GetTargetPosition();
            UnityEngine.Vector3 val_9 = this.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            if(this.isOnEdge == false)
            {
                goto label_12;
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            val_19 = targetNormalized.x;
            val_20 = targetNormalized.y;
            this.maxOutDegreeVar = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = targetNormalized.z}, to:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_21 = null;
            label_32:
            if(val_3.x >= 0)
            {
                goto label_25;
            }
            
            goto label_22;
            label_12:
            float val_12 = UnityEngine.Random.value;
            val_12 = val_12 * 80f;
            val_20 = 20f;
            val_12 = val_12 + val_20;
            this.maxOutDegreeVar = val_12;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
            this.outVectorType = val_13;
            mem[1152921520109969904] = val_13.y;
            val_19 = 1f;
            mem[1152921520109969908] = val_13.z;
            if(val_9.x >= 0)
            {
                goto label_20;
            }
            
            val_22 = null;
            label_22:
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.forward;
            goto label_23;
            label_20:
            val_19 = 7f;
            if(val_9.x <= val_19)
            {
                goto label_26;
            }
            
            val_23 = null;
            label_25:
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.back;
            label_23:
            this.outVectorType = val_15;
            mem[1152921520109969904] = val_15.y;
            mem[1152921520109969908] = val_15.z;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_16 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerFlyingSorting(isSpecialCombo:  false);
            this.itemView.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_16.layer, order = val_16.order, sortEverything = val_16.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            return;
            label_26:
            float val_18 = UnityEngine.Random.value;
            goto label_32;
        }
        protected virtual void TargetReached()
        {
            this.flyState = 0;
            this.itemView.TriggerTargetReached();
            this.itemView.ExplodeSelf(isPropRocketCombo:  false);
        }
        protected virtual bool IsPropRocketCombo()
        {
            return false;
        }
        protected virtual bool IsPropSpecialCombo()
        {
            return false;
        }
        protected virtual void ArrangePosition(UnityEngine.Vector3 targetVector, UnityEngine.Vector3 targetNormalized, float distanceToTarget)
        {
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_39;
            float val_40;
            float val_41;
            float val_1 = UnityEngine.Time.deltaTime;
            val_32 = val_1;
            if(val_1 > 0.5f)
            {
                    object[] val_2 = new object[1];
                val_2[0] = val_32;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "DeltaTime is too high: {0}", values:  val_2);
                val_32 = 0.5f;
            }
            
            float val_4 = UnityEngine.Mathf.Min(a:  1f, b:  this.elapsed / 0.75f);
            if(val_4 < 0)
            {
                    val_33 = this.maxOutSpeed;
                float val_5 = val_4 / 0.7f;
                val_34 = this.startOutSpeed;
            }
            else
            {
                    val_33 = this.maxOutSpeed;
                float val_32 = -0.7f;
                val_32 = val_4 + val_32;
                val_34 = val_33;
            }
            
            this.outSpeed = UnityEngine.Mathf.Lerp(a:  val_34, b:  this.minOutSpeed, t:  val_32 / 0.3f);
            float val_8 = UnityEngine.Mathf.Lerp(a:  this.maxOutDegreeVar, b:  20f, t:  val_4);
            this.outDegree = val_8;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.AngleAxis(angle:  val_8, axis:  new UnityEngine.Vector3() {x = this.outVectorType, y = val_33, z = val_4});
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, point:  new UnityEngine.Vector3() {x = targetVector.x, y = targetVector.y, z = targetVector.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_32 * this.outSpeed);
            val_35 = val_12.y;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_39 = val_13.x;
            val_40 = val_13.y;
            float val_33 = this.elapsed;
            if(val_33 <= 0.525f)
            {
                goto label_20;
            }
            
            val_33 = val_32 * val_33;
            val_33 = this.goSpeed + val_33;
            float val_14 = UnityEngine.Mathf.Clamp(value:  val_33, min:  0f, max:  val_33);
            this.goSpeed = val_14;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = targetNormalized.x, y = targetNormalized.y, z = targetNormalized.z}, d:  val_32 * val_14);
            val_35 = val_35;
            if(val_16.x <= distanceToTarget)
            {
                goto label_25;
            }
            
            val_40 = targetVector.y;
            val_41 = targetVector.z;
            val_39 = targetVector.x;
            goto label_27;
            label_20:
            val_41 = val_13.z;
            goto label_27;
            label_25:
            val_39 = targetVector.x;
            val_40 = val_40;
            val_41 = val_41;
            label_27:
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_35, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.combinedVelocity, y = val_35, z = val_12.x}, rhs:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z})) != true)
            {
                    if(this.scaleState != 2)
            {
                goto label_31;
            }
            
            }
            
            this.combinedVelocity = val_17;
            mem[1152921520110495912] = val_17.y;
            mem[1152921520110495916] = val_17.z;
            label_47:
            UnityEngine.Vector3 val_20 = this.transform.position;
            UnityEngine.Vector3 val_21 = this.transform.position;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = this.combinedVelocity, y = val_17.z, z = val_17.x});
            this.transform.position = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            this.ArrangeRotation(curveVelocity:  new UnityEngine.Vector3() {x = val_12.x, y = val_35, z = val_12.z}, targetVelocity:  new UnityEngine.Vector3() {x = targetVector.x, y = val_40, z = val_41}, targetNormalized:  new UnityEngine.Vector3() {x = targetNormalized.x, y = targetNormalized.z, z = distanceToTarget}, distanceToTarget:  null);
            return;
            label_31:
            float val_34 = val_17.z;
            float val_35 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_34}, to:  new UnityEngine.Vector3() {x = this.combinedVelocity, y = val_35, z = this.combinedVelocity});
            val_34 = val_35 / 90f;
            val_35 = this.combinedVelocity * (UnityEngine.Mathf.Lerp(a:  0f, b:  0.35f, t:  val_34));
            float val_36 = -2f;
            val_36 = distanceToTarget + val_36;
            float val_25 = val_36 * 0.5f;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = this.combinedVelocity, y = 0.1f, z = val_25}, target:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, currentVelocity: ref  new UnityEngine.Vector3() {x = this.combinedVelocitySmoother, y = this.combinedVelocitySmoother, z = this.combinedVelocitySmoother}, smoothTime:  (UnityEngine.Mathf.Lerp(a:  0f, b:  0.1f, t:  val_25)) + val_35);
            this.combinedVelocity = val_28;
            mem[1152921520110495912] = val_28.y;
            mem[1152921520110495916] = val_28.z;
            if((val_28.x <= distanceToTarget) || (this.scaleState != 0))
            {
                goto label_47;
            }
            
            this.scaleDownStartDistance = distanceToTarget;
            UnityEngine.Vector3 val_29 = this.transform.localScale;
            this.maxReachedScale = val_29.x;
            UnityEngine.Vector3 val_31 = this.transform.transform.localPosition;
            this.maxReachedShadowDistance = val_31;
            mem[1152921520110495900] = val_31.y;
            mem[1152921520110495904] = val_31.z;
            this.scaleState = 2;
            if((this & 1) != 0)
            {
                goto label_47;
            }
            
            this.updateSortingForScaleDown = true;
            goto label_47;
        }
        protected virtual float CalculateAngleSmoothCoefficient()
        {
            return UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  (Royal.Scenes.Game.Levels.LevelContext.Time - this.moveCanceledAtTime) / 0.4f);
        }
        private void ArrangeRotation(UnityEngine.Vector3 curveVelocity, UnityEngine.Vector3 targetVelocity, UnityEngine.Vector3 targetNormalized, float distanceToTarget)
        {
            float val_24 = targetVelocity.x;
            float val_26 = targetNormalized.z;
            val_24 = (((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.goSpeed, b:  0f, precision:  0.001f)) != true) ? curveVelocity.x : (val_24)) * 20f;
            float val_3 = val_26 + (-1.8f);
            float val_25 = val_3;
            float val_4 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_25);
            val_4 = val_24 * val_4;
            val_4 = val_4 + 1f;
            val_25 = val_4 * 0.5f;
            val_26 = (this.scaleState == 2) ? 0f : UnityEngine.Mathf.Lerp(a:  35f, b:  -20f, t:  val_25);
            UnityEngine.Vector3 val_6 = this.itemView.animatorTransform.eulerAngles;
            float val_27 = -360f;
            val_27 = val_6.z + val_27;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.SmoothDamp(current:  (val_6.z > 180f) ? (val_27) : val_6.z, target:  val_26, currentVelocity: ref  this.rotationSmoothVel, smoothTime:  UnityEngine.Mathf.Lerp(a:  0.064f, b:  0.4f, t:  val_3)), axis:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.itemView.animatorTransform.rotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            UnityEngine.Quaternion val_16 = this.itemView.fanTransform.localRotation;
            float val_28 = val_27;
            float val_17 = (this.scaleState == 2) ? 0f : val_16.z;
            val_28 = val_17 + val_28;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_23 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.SmoothDamp(current:  (val_17 > 180f) ? (val_28) : (val_17), target:  UnityEngine.Mathf.Lerp(a:  -8f, b:  8f, t:  (targetNormalized.x + 1f) * 0.5f), currentVelocity: ref  this.rotationFanSmoothVel, smoothTime:  UnityEngine.Mathf.Lerp(a:  0.064f, b:  0.25f, t:  val_3)), axis:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            this.itemView.fanTransform.localRotation = new UnityEngine.Quaternion() {x = val_23.x, y = val_23.y, z = val_23.z, w = val_23.w};
        }
        protected void ArrangeScale(float distanceToTarget)
        {
            var val_13;
            var val_17;
            float val_36;
            var val_37;
            var val_38;
            var val_39;
            val_36 = distanceToTarget;
            val_37 = this;
            if(this.scaleState != 1)
            {
                    if(this.scaleState != 2)
            {
                    return;
            }
            
                val_36 = (this.scaleDownStartDistance - val_36) / this.scaleDownStartDistance;
                if((val_36 >= 0.3f) && (this.updateSortingForScaleDown != false))
            {
                    this.updateSortingForScaleDown = false;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetPropellerScaleDownSorting(isSpecialCombo:  false, offset:  0);
                this.itemView.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            }
            
                val_38 = ???;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  1.5f, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                UnityEngine.Vector3 val_6 = val_38 + 96.localScale;
                float val_36 = -1f;
                val_6.x = val_5.x - val_6.x;
                val_36 = val_5.x + val_36;
                val_6.x = val_6.x / val_36;
                float val_9 = (UnityEngine.Mathf.Clamp(value:  Royal.Infrastructure.Utils.Animation.ManualEasing.Linear(t:  val_6.x), min:  0.3f, max:  1f)) * (UnityEngine.Mathf.Clamp(value:  Royal.Infrastructure.Utils.Animation.ManualEasing.Linear(t:  val_6.x), min:  0.3f, max:  1f));
                val_39 = val_13;
                val_36 = val_17;
            }
        
        }
        protected virtual void ArrangeScaleDown(float scaleRatio)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  this.maxReachedScale, a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, t:  UnityEngine.Mathf.Clamp(value:  scaleRatio, min:  0f, max:  1f));
            this.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = this.maxReachedShadowDistance, y = val_2.y, z = val_2.z}, target:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, maxDistanceDelta:  scaleRatio);
            this.transform.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        protected virtual void ArrangeScaleUp(UnityEngine.Vector3 targetScale, UnityEngine.Vector3 itemScale, float scaleSpeedVar)
        {
            var val_10;
            scaleSpeedVar = UnityEngine.Time.deltaTime * scaleSpeedVar;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = itemScale.x, y = itemScale.y, z = itemScale.z}, target:  new UnityEngine.Vector3() {x = targetScale.x, y = targetScale.y, z = targetScale.z}, maxDistanceDelta:  scaleSpeedVar);
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Transform val_3 = this.transform.transform;
            UnityEngine.Vector3 val_5 = val_3.transform.localPosition;
            val_10 = null;
            val_10 = null;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, target:  new UnityEngine.Vector3() {x = Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime, y = Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime.__il2cppRuntimeField_4, z = Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime.__il2cppRuntimeField_8}, maxDistanceDelta:  UnityEngine.Time.deltaTime * scaleSpeedVar);
            val_3.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            if(itemScale.x <= 1.5f)
            {
                    if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  itemScale.x, b:  1.5f, precision:  0.001f)) == false)
            {
                    return;
            }
            
            }
            
            this.scaleState = 0;
        }
        public DefaultPropellerPilot()
        {
        
        }
        private static DefaultPropellerPilot()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime = 0f;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime.__il2cppRuntimeField_3 = 0;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot.DefaultPropellerPilot.MaxDeltaTime.__il2cppRuntimeField_8 = 0;
        }
    
    }

}
