using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.RemainingMoves
{
    public class RemainingMovesSingleCoinPilot : ItemParticles
    {
        // Fields
        private const float FirstVectorFinalSpeed = 0;
        private const float FirstVectorStartTime = 0;
        private float FirstVectorInitialSpeed;
        private float FirstVectorDuration;
        private const float SecondVectorInitialSpeed = 3;
        private const float SecondVectorFinalSpeed = 0;
        private const float SecondVectorStartTime = 0.45;
        private const float SecondVectorDuration = 0.1;
        private const float FinalVectorInitialSpeed = 0;
        private const float FinalVectorFinalSpeed = 20;
        private const float FinalVectorDuration = 0.6;
        private float FinalVectorStartTime;
        private bool isRunning;
        private UnityEngine.Vector3 firstTarget;
        private UnityEngine.Vector3 finalTarget;
        private UnityEngine.Vector3 initialPosition;
        private System.Action<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot> onComplete;
        private float elapsedDuration;
        private UnityEngine.Vector3 shadowStartPos;
        private UnityEngine.Vector3 shadowMaxPos;
        private bool particleDecremented;
        public Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView coinItemView;
        public Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesCoinTracer coinTracer;
        
        // Methods
        public void MoveToTarget(Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView coinItemView, UnityEngine.Vector3 firstTarget, UnityEngine.Vector3 finalTarget, int index, System.Action<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesSingleCoinPilot> onComplete)
        {
            this.coinItemView = coinItemView;
            this.firstTarget = firstTarget;
            mem[1152921524009594060] = firstTarget.y;
            mem[1152921524009594064] = firstTarget.z;
            this.finalTarget = finalTarget;
            mem[1152921524009594072] = finalTarget.y;
            mem[1152921524009594076] = finalTarget.z;
            this.onComplete = onComplete;
            UnityEngine.Vector3 val_2 = coinItemView.shadowView.transform.localPosition;
            this.shadowStartPos = val_2;
            mem[1152921524009594112] = val_2.y;
            val_2.y = val_2.y + (-0.5f);
            val_2.x = val_2.x + 0.3f;
            mem[1152921524009594124] = val_2.y;
            mem[1152921524009594128] = val_2.z;
            mem[1152921524009594116] = val_2.z;
            this.shadowMaxPos = val_2.x;
            UnityEngine.Vector3 val_4 = this.transform.position;
            float val_6 = 0.1f;
            val_6 = (float)index * val_6;
            float val_7 = -0.05f;
            val_6 = val_6 + 0.3f;
            this.initialPosition = val_4;
            mem[1152921524009594084] = val_4.y;
            mem[1152921524009594088] = val_4.z;
            val_7 = val_6 + val_7;
            this.FirstVectorDuration = val_6;
            this.FinalVectorStartTime = val_7;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = firstTarget.x, y = firstTarget.y, z = firstTarget.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_5.x = val_5.x + val_5.x;
            val_5.x = val_5.x / this.FirstVectorDuration;
            this.elapsedDuration = 0f;
            this.FirstVectorInitialSpeed = val_5.x;
            this.isRunning = true;
            this.coinTracer.ArrangeRateOverDistanceByRatio(ratio:  1f);
            this.coinTracer.Play();
        }
        public void TapToSkip()
        {
            this.isRunning = false;
            this.onComplete.Invoke(obj:  this);
        }
        private void Update()
        {
            if(this.isRunning == false)
            {
                    return;
            }
            
            float val_1 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            val_1 = this.elapsedDuration + val_1;
            this.elapsedDuration = val_1;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = this.finalTarget, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_5 = this.GetFirstVector();
            UnityEngine.Vector3 val_6 = this.GetFinalVector();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Transform val_8 = this.transform;
            UnityEngine.Vector3 val_9 = val_8.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_7.y, z = val_4.z});
            val_8.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = this.transform.position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.finalTarget, y = val_9.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            if(val_13.x < 0)
            {
                    this.isRunning = false;
                this.onComplete.Invoke(obj:  this);
            }
            
            this.ArrangeShadow();
        }
        private void ArrangeShadow()
        {
            var val_11;
            UnityEngine.Vector3 val_12;
            float val_13;
            float val_14;
            float val_17;
            val_11 = this;
            if(this.elapsedDuration < 0)
            {
                    val_13 = this.elapsedDuration;
                val_12 = this.shadowStartPos;
                val_11 = this.coinItemView.shadowView.transform;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_12, y = V10.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = this.shadowMaxPos, y = V11.16B, z = V9.16B}, t:  val_13 / this.FirstVectorDuration);
                val_11.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                return;
            }
            
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_17 = val_5.x;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.finalTarget, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_17, y = val_5.y, z = val_5.z});
            val_14 = val_6.x;
            if(val_14 < 0)
            {
                    float val_11 = -3f;
                val_11 = val_14 / val_11;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.shadowMaxPos, y = val_5.z, z = val_17}, b:  new UnityEngine.Vector3() {x = this.shadowStartPos, y = V10.16B, z = V9.16B}, t:  val_11 + 1f);
                this.coinItemView.shadowView.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            }
            
            val_13 = this.finalTarget;
            val_12 = this.firstTarget;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13, y = val_5.z, z = val_17}, b:  new UnityEngine.Vector3() {x = val_12, y = V10.16B, z = V9.16B});
            val_10.x = val_14 / val_10.x;
            this.coinTracer.ArrangeRateOverDistanceByRatio(ratio:  val_10.x);
        }
        private UnityEngine.Vector3 GetFirstVector()
        {
            UnityEngine.Vector3 val_7;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.firstTarget, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.initialPosition, y = V8.16B, z = V9.16B});
            if(val_1.x > 1f)
            {
                    val_7 = this.initialPosition;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.firstTarget, y = V9.16B, z = this.firstTarget}, b:  new UnityEngine.Vector3() {x = val_7, y = this.initialPosition, z = V11.16B});
            }
            
            float val_7 = UnityEngine.Mathf.Lerp(a:  this.FirstVectorInitialSpeed, b:  0f, t:  this.elapsedDuration / this.FirstVectorDuration);
            val_7 = val_7 * Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_7);
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private UnityEngine.Vector3 GetFinalVector()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.finalTarget, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            if(val_3.x > 1f)
            {
                
            }
            
            float val_9 = UnityEngine.Mathf.Lerp(a:  0f, b:  20f, t:  (this.elapsedDuration - this.FinalVectorStartTime) / 0.6f);
            val_9 = val_9 * Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = 1f, z = val_3.z}, d:  val_9);
            return new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        public override int GetPoolId()
        {
            return 69;
        }
        public void Recycle()
        {
            this.Invoke(methodName:  "RecycleSelf", time:  2f);
        }
        public RemainingMovesSingleCoinPilot()
        {
        
        }
    
    }

}
