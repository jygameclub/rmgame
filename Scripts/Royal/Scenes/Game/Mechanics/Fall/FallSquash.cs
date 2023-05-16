using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Fall
{
    public class FallSquash : MonoBehaviour
    {
        // Fields
        private const float MinWidthOnFall = 0.97;
        private const float MaxBouncePosY = 0.05;
        private const float MaxBounceUpDur = 0.1;
        private const float MaxBounceDownDur = 0.08;
        private const float MaxWidthOnStretch = 0.05;
        private const float MinHeightOnStretch = 0.05;
        private const float MinYPosOnStretch = -0.025;
        private const float MaxStretchSpeed = 0.08;
        private const float MaxSquashSpeed = 0.05;
        private UnityEngine.Vector3 fallStartPosition;
        private bool isBouncing;
        private bool isFalling;
        private Royal.Scenes.Game.Mechanics.Fall.SquashType squashType;
        private Royal.Scenes.Game.Mechanics.Fall.FallState state;
        private float yPosOnStretch;
        private float stretchWidth;
        private float stretchHeight;
        private float stretchSpeed;
        private float squashSpeed;
        private float bounceYPos;
        private float bounceElapsedDur;
        
        // Methods
        public void UpdateState(Royal.Scenes.Game.Mechanics.Fall.FallState newState, float currentSpeed, float maxSpeed)
        {
            float val_3 = 0.05f;
            currentSpeed = currentSpeed + (-4f);
            maxSpeed = currentSpeed / maxSpeed;
            currentSpeed = (maxSpeed < 0) ? (val_3) : (maxSpeed);
            this.state = newState;
            if(this.state != 0)
            {
                    if(this.state != 1)
            {
                    return;
            }
            
                if(newState != 0)
            {
                    return;
            }
            
                maxSpeed = maxSpeed * val_3;
                val_3 = currentSpeed * val_3;
                currentSpeed = currentSpeed * (-0.025f);
                this.bounceElapsedDur = 0f;
                this.isBouncing = true;
                this.isFalling = false;
                this.bounceYPos = maxSpeed;
                this.stretchSpeed = 0.08f;
                this.squashSpeed = 0.05f;
                this.yPosOnStretch = currentSpeed;
                this.stretchWidth = val_3;
                this.stretchHeight = val_3;
                return;
            }
            
            if(newState != 1)
            {
                    return;
            }
            
            this.isBouncing = true;
            this.isFalling = true;
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.fallStartPosition = val_2;
            mem[1152921523884762892] = val_2.y;
            mem[1152921523884762896] = val_2.z;
            this.bounceElapsedDur = 0f;
            this.squashType = 0;
        }
        private void Update()
        {
            if(this.isFalling != false)
            {
                    this.ScaleItemOnFall();
                return;
            }
            
            if(this.isBouncing == false)
            {
                    return;
            }
            
            this.BounceItemAfterFall();
        }
        private void BounceItemAfterFall()
        {
            float val_20;
            float val_21;
            float val_22;
            Royal.Scenes.Game.Mechanics.Fall.SquashType val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_32;
            float val_33;
            if(this.squashType == 0)
            {
                    this.squashType = 1;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            val_20 = val_2.x;
            val_21 = val_2.y;
            val_22 = val_2.z;
            UnityEngine.Vector3 val_3 = val_1.localPosition;
            val_24 = this.squashType;
            val_25 = val_3.x;
            val_26 = val_3.y;
            val_27 = val_3.z;
            if(val_24 != 1)
            {
                goto label_3;
            }
            
            float val_19 = this.stretchWidth;
            val_28 = 1f;
            val_29 = val_19 + val_28;
            val_19 = val_29 + (-0.001f);
            if(val_20 >= 0)
            {
                goto label_4;
            }
            
            val_20 = UnityEngine.Mathf.MoveTowards(current:  val_20, target:  val_29, maxDelta:  this.stretchSpeed);
            val_21 = UnityEngine.Mathf.MoveTowards(current:  val_21, target:  val_28 - this.stretchHeight, maxDelta:  this.stretchSpeed);
            val_30 = val_26;
            val_24 = this.squashType;
            val_22 = val_22;
            val_25 = val_25;
            val_27 = val_27;
            val_26 = UnityEngine.Mathf.MoveTowards(current:  val_30, target:  this.yPosOnStretch, maxDelta:  this.stretchSpeed);
            label_3:
            if(val_24 == 2)
            {
                goto label_7;
            }
            
            goto label_8;
            label_4:
            this.squashType = 2;
            label_7:
            val_30 = 1.001f;
            if(val_20 <= val_30)
            {
                goto label_9;
            }
            
            val_29 = this.squashSpeed;
            val_28 = val_22;
            val_20 = UnityEngine.Mathf.MoveTowards(current:  val_20, target:  1f, maxDelta:  val_29);
            val_21 = UnityEngine.Mathf.MoveTowards(current:  val_21, target:  1f, maxDelta:  this.squashSpeed);
            val_30 = val_26;
            val_24 = this.squashType;
            val_26 = UnityEngine.Mathf.MoveTowards(current:  val_30, target:  0f, maxDelta:  this.squashSpeed);
            val_22 = val_28;
            label_8:
            if(val_24 == 4)
            {
                goto label_12;
            }
            
            if(val_24 == 3)
            {
                goto label_13;
            }
            
            goto label_23;
            label_9:
            val_21 = 1f;
            this.squashType = 3;
            val_20 = val_21;
            label_13:
            val_28 = this.bounceElapsedDur;
            float val_11 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            float val_12 = val_28 + val_11;
            this.bounceElapsedDur = val_12;
            val_11 = val_12 / 0.1f;
            if(val_11 >= 1f)
            {
                goto label_15;
            }
            
            val_29 = this.bounceYPos;
            val_32 = ManualEasing.Sine.Out(t:  val_11);
            val_33 = 0f;
            goto label_18;
            label_15:
            val_26 = this.bounceYPos;
            this.squashType = 4;
            this.bounceElapsedDur = 0f;
            goto label_23;
            label_12:
            val_28 = this.bounceElapsedDur;
            float val_14 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
            float val_15 = val_28 + val_14;
            this.bounceElapsedDur = val_15;
            val_14 = val_15 / 0.08f;
            if(val_14 >= 1f)
            {
                goto label_20;
            }
            
            val_29 = this.bounceYPos;
            val_32 = ManualEasing.Sine.In(t:  val_14);
            val_33 = val_29;
            label_18:
            val_26 = UnityEngine.Mathf.Lerp(a:  val_33, b:  0f, t:  val_32);
            goto label_23;
            label_20:
            this.bounceElapsedDur = 0f;
            this.squashType = 5;
            val_26 = 0f;
            label_23:
            UnityEngine.Transform val_18 = this.transform;
            val_18.localScale = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
            val_18.localPosition = new UnityEngine.Vector3() {x = val_25, y = val_26, z = val_27};
        }
        private void ScaleItemOnFall()
        {
            UnityEngine.Vector3 val_2 = this.transform.localScale;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_2.x, b:  0.97f, precision:  0.001f)) != false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.transform.position;
            float val_9 = -2f;
            val_9 = S11 + val_9;
            this.transform.localScale = new UnityEngine.Vector3() {x = UnityEngine.Mathf.Lerp(a:  0.97f, b:  1f, t:  UnityEngine.Mathf.InverseLerp(a:  val_9, b:  V11.16B, value:  val_5.y)), y = val_2.y, z = val_2.z};
        }
        public FallSquash()
        {
        
        }
    
    }

}
