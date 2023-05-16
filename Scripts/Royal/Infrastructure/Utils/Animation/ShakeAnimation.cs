using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public class ShakeAnimation : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 initialPosition;
        private bool isShaking;
        private bool shouldVisitCenter;
        private float animationTime;
        private float finishTime;
        private float minShake;
        private float midShake;
        private float maxShake;
        private int shakeFrame;
        
        // Methods
        private void Update()
        {
            var val_16;
            float val_18;
            float val_19;
            var val_20;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            val_16 = this;
            if(this.isShaking == false)
            {
                    return;
            }
            
            float val_1 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_18 = this.finishTime - val_1;
            if(val_18 < 0)
            {
                    this.StopShaking();
                return;
            }
            
            val_19 = this.animationTime;
            val_1 = val_18 - val_19;
            if(val_1 > 0f)
            {
                    return;
            }
            
            if(this.shouldVisitCenter == false)
            {
                goto label_4;
            }
            
            if(this.shakeFrame == 0)
            {
                goto label_5;
            }
            
            val_20 = this.transform;
            if((this.shakeFrame & 1) != 0)
            {
                goto label_6;
            }
            
            goto label_8;
            label_4:
            UnityEngine.Vector3 val_16 = this.initialPosition;
            float val_15 = this.minShake;
            val_15 = val_16 + val_15;
            val_16 = val_16 + this.maxShake;
            val_19 = UnityEngine.Random.Range(min:  val_15, max:  val_16);
            float val_17 = this.minShake;
            val_17 = val_16 + val_17;
            val_16 = val_16 + this.maxShake;
            val_16 = this.transform;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_19, y:  UnityEngine.Random.Range(min:  val_17, max:  val_16));
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_16.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            return;
            label_5:
            UnityEngine.Transform val_8 = this.transform;
            val_20 = val_8;
            UnityEngine.Vector3 val_9 = val_8.localPosition;
            val_19 = val_9.x;
            val_18 = val_9.z;
            UnityEngine.Vector3 val_10 = val_8.GetRandomOffset(shake1:  this.midShake, shake2:  this.maxShake);
            val_24 = val_10.x;
            val_25 = val_10.y;
            val_26 = val_10.z;
            goto label_16;
            label_6:
            UnityEngine.Vector3 val_12 = val_20.localPosition;
            val_19 = val_12.y;
            val_18 = val_12.z;
            if(val_18 > (val_19 * 0.5f))
            {
                    val_27 = this.midShake;
                val_28 = this.minShake;
            }
            else
            {
                    val_28 = 0f;
                val_27 = this.minShake;
            }
            
            UnityEngine.Vector3 val_13 = val_20.GetRandomOffset(shake1:  val_28, shake2:  val_27);
            val_24 = val_13.x;
            val_25 = val_13.y;
            val_26 = val_13.z;
            label_16:
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_19, z = val_18}, b:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26});
            label_8:
            val_20.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            int val_18 = this.shakeFrame;
            val_18 = val_18 + 1;
            this.shakeFrame = val_18;
        }
        private void StopShaking()
        {
            this.shakeFrame = 0;
            this.isShaking = false;
            this.transform.localPosition = new UnityEngine.Vector3() {x = this.initialPosition};
        }
        private UnityEngine.Vector3 GetRandomOffset(float shake1, float shake2)
        {
            float val_5 = UnityEngine.Random.Range(min:  shake1, max:  shake2);
            val_5 = ((UnityEngine.Random.Range(min:  0, max:  2)) < 1) ? (-val_5) : (val_5);
            float val_6 = shake2;
            float val_3 = UnityEngine.Random.Range(min:  shake1, max:  val_6);
            val_6 = ((UnityEngine.Random.Range(min:  0, max:  2)) < 1) ? (-val_3) : (val_3);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private static float GetRandomPosition(float shake1, float shake2)
        {
            float val_1 = UnityEngine.Random.Range(min:  shake1, max:  shake2);
            return (float)((UnityEngine.Random.Range(min:  0, max:  2)) < 1) ? (-val_1) : (val_1);
        }
        public void Shake(bool visitCenter, float delay, float duration, float min, float mid, float max)
        {
            if(this.isShaking != false)
            {
                    if(this.shouldVisitCenter != true)
            {
                    if(visitCenter == true)
            {
                    return;
            }
            
            }
            
                this.StopShaking();
            }
            
            UnityEngine.Vector3 val_3 = this.gameObject.transform.localPosition;
            this.initialPosition = val_3;
            mem[1152921527493193276] = val_3.y;
            mem[1152921527493193280] = val_3.z;
            this.shouldVisitCenter = visitCenter;
            this.animationTime = duration;
            float val_5 = Royal.Scenes.Game.Levels.LevelContext.Time;
            this.midShake = mid;
            this.maxShake = max;
            this.isShaking = true;
            val_5 = val_5 + this.animationTime;
            val_5 = val_5 + delay;
            this.finishTime = val_5;
            this.minShake = min;
        }
        public ShakeAnimation()
        {
        
        }
    
    }

}
