using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerPilot
{
    public class PropellerPropellerComboPilot : DefaultPropellerPilot
    {
        // Fields
        private const float ComboExpandDistance = 1;
        private float comboExpandCompletedAtTime;
        private UnityEngine.Vector3 comboTargetPosition;
        private readonly float startAngle;
        
        // Methods
        public PropellerPropellerComboPilot(float angle)
        {
            this = new System.Object();
            this.startAngle = angle;
        }
        protected override Royal.Scenes.Game.Mechanics.Items.SpecialItems.PropellerItem.View.PropellerFlyState GetStartState()
        {
            return 1;
        }
        public override void TargetChanged()
        {
            if(W8 == 1)
            {
                    return;
            }
            
            this.TargetChanged();
        }
        protected override void InitializeCurveVariables(UnityEngine.Vector3 targetNormalized)
        {
            this.InitializeCurveVariables(targetNormalized:  new UnityEngine.Vector3() {x = targetNormalized.x, y = targetNormalized.y, z = targetNormalized.z});
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.AngleAxis(angle:  this.startAngle, axis:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1f);
            UnityEngine.Vector3 val_6 = 0.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.comboTargetPosition = val_7;
            mem[1152921520111928732] = val_7.y;
            mem[1152921520111928736] = val_7.z;
            UnityEngine.Vector3 val_8 = 0.position;
            UnityEngine.Color val_9 = UnityEngine.Color.magenta;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, end:  new UnityEngine.Vector3() {x = this.comboTargetPosition, y = val_2.w, z = V12.16B}, color:  new UnityEngine.Color() {r = val_9.r, g = val_9.b, b = 20f, a = val_8.y}, duration:  ???);
        }
        protected override void MoveToTarget()
        {
            if(W8 == 1)
            {
                    this.ArrangeComboExpandPosition();
                return;
            }
            
            this.MoveToTarget();
        }
        private void ArrangeComboExpandPosition()
        {
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            UnityEngine.Vector3 val_1 = 28143.position;
            float val_2 = S8 / 0.75f;
            float val_15 = 0.7f;
            val_15 = (UnityEngine.Mathf.Min(a:  1f, b:  val_2)) / val_15;
            float val_4 = UnityEngine.Mathf.Lerp(a:  V3.16B, b:  val_2, t:  val_15);
            val_4 = val_4 * 7f;
            mem[1152921520112152576] = val_4;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.comboTargetPosition, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            float val_7 = S12 * Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_15 = val_5.x;
            val_16 = val_5.y;
            val_17 = val_5.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, d:  val_7);
            mem[1152921520112152628] = val_8.x;
            mem[1152921520112152632] = val_8.y;
            mem[1152921520112152636] = val_8.z;
            UnityEngine.Vector3 val_9 = position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_7, y = mem[1152921520112152632], z = mem[1152921520112152636]});
            position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            if(val_10.x > val_10.x)
            {
                    this.comboExpandCompletedAtTime = Royal.Scenes.Game.Levels.LevelContext.Time;
                mem[1152921520112152672] = 2;
                val_18 = 0.6f;
                val_15 = V12.16B;
                val_16 = val_10.x;
                val_17 = val_5.z;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, d:  val_18);
                mem[1152921520112152628] = val_12.x;
                mem[1152921520112152632] = val_12.y;
                mem[1152921520112152636] = val_12.z;
            }
            
            this.ArrangeScale(distanceToTarget:  val_12.x);
            UnityEngine.Vector3 val_13 = this.position;
            UnityEngine.Color val_14 = UnityEngine.Color.red;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, end:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, color:  new UnityEngine.Color() {r = val_14.r, g = val_14.b, b = 5f, a = val_1.z}, duration:  val_5.x);
        }
        protected override float CalculateAngleSmoothCoefficient()
        {
            float val_2 = Royal.Scenes.Game.Levels.LevelContext.Time - this.comboExpandCompletedAtTime;
            float val_3 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_3 = val_3 - this.comboExpandCompletedAtTime;
            return UnityEngine.Mathf.Lerp(a:  1f, b:  0f, t:  ((val_2 < 0) ? (val_2) : (val_3)) / 0.4f);
        }
    
    }

}
