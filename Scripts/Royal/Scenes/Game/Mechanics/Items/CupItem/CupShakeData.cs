using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CupItem
{
    public class CupShakeData
    {
        // Fields
        public const int MAXSteps = 5;
        public float moveDur;
        public bool isShaking;
        public float moveElapsed;
        public UnityEngine.Vector3 moveTarget;
        public UnityEngine.Vector3 moveStart;
        public float lastCupShakeTime;
        private int pointStep;
        private readonly Royal.Infrastructure.Utils.Animation.ManualEasing.Easer easing;
        
        // Methods
        public bool IsMoveCompleted()
        {
            if(this.moveElapsed > this.moveDur)
            {
                    return true;
            }
            
            return true;
        }
        public bool StartMove(UnityEngine.Vector3 startPosition)
        {
            var val_2;
            int val_3;
            float val_4;
            if(this.pointStep == 5)
            {
                    val_2 = 0;
                val_3 = 6;
            }
            else
            {
                    this.moveStart = startPosition;
                mem[1152921523755813308] = startPosition.y;
                mem[1152921523755813312] = startPosition.z;
                UnityEngine.Vector3 val_1 = this.GetTargetByStep();
                this.moveTarget = val_1;
                mem[1152921523755813296] = val_1.y;
                mem[1152921523755813300] = val_1.z;
                if(this.pointStep <= 4)
            {
                    val_4 = mem[36617008 + (this.pointStep) << 2];
                val_4 = 36617008 + (this.pointStep) << 2;
            }
            else
            {
                    val_4 = 0.0167f;
            }
            
                val_3 = this.pointStep + 1;
                val_2 = 1;
                this.moveDur = val_4;
                this.moveElapsed = 0f;
            }
            
            this.pointStep = val_3;
            return (bool)val_2;
        }
        public void StartShaking()
        {
            this.isShaking = true;
            this.lastCupShakeTime = UnityEngine.Time.time;
            if(this.pointStep < 3)
            {
                    return;
            }
            
            this.pointStep = 0;
            this.moveElapsed = 0f;
        }
        public bool ShouldShake()
        {
            if(this.isShaking == false)
            {
                    return false;
            }
            
            return (bool)(this.pointStep < 6) ? 1 : 0;
        }
        public void EndShaking()
        {
            this.isShaking = false;
            this.moveElapsed = 0f;
            this.pointStep = 0;
        }
        public UnityEngine.Vector3 GetMovePosition()
        {
            float val_2 = this.moveElapsed;
            val_2 = val_2 / this.moveDur;
            return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.moveStart, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.moveTarget, y = V12.16B, z = V11.16B}, t:  this.easing.Invoke(t:  val_2));
        }
        private UnityEngine.Vector3 GetTargetByStep()
        {
            if(this.pointStep <= 4)
            {
                    var val_5 = 36616624 + (this.pointStep) << 2;
                val_5 = val_5 + 36616624;
            }
            else
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
                return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            }
        
        }
        private float GetDurationByStep()
        {
            if(this.pointStep > 4)
            {
                    return 0.0167f;
            }
            
            return (float)36617008 + (this.pointStep) << 2;
        }
        public CupShakeData()
        {
            this.easing = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  4);
        }
    
    }

}
