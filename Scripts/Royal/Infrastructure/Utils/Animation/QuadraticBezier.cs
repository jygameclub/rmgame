using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public class QuadraticBezier
    {
        // Fields
        private const int Len = 100;
        private float[] lengths;
        private UnityEngine.Vector3 p0;
        private UnityEngine.Vector3 p1;
        private UnityEngine.Vector3 p2;
        public float length;
        
        // Methods
        public Royal.Infrastructure.Utils.Animation.QuadraticBezier Init(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
        {
            var val_1;
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            val_5 = p0.z;
            this.p0 = p0;
            mem[1152921527491876444] = p0.y;
            mem[1152921527491876448] = val_5;
            this.p1 = p1;
            mem[1152921527491876456] = p1.y;
            mem[1152921527491876460] = p1.z;
            this.p2 = p2;
            mem[1152921527491876468] = val_1;
            mem[1152921527491876472] = p2.y;
            val_6 = 0f;
            UnityEngine.Vector3 val_2 = this.GetValue(t:  0f);
            val_7 = val_2.x;
            val_8 = val_2.y;
            label_7:
            if((9 - 8) >= (this.lengths.Length << ))
            {
                goto label_2;
            }
            
            float val_8 = (float)9 - 8;
            val_8 = val_8 / (float)this.lengths.Length;
            UnityEngine.Vector3 val_5 = this.GetValue(t:  val_8);
            val_5 = val_5.y;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_2.z});
            val_6 = val_6 + val_6.x;
            this.lengths = val_6;
            var val_7 = 9 + 1;
            val_8 = val_5;
            val_7 = val_5.x;
            if(this.lengths != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            this.length = val_6;
            return (Royal.Infrastructure.Utils.Animation.QuadraticBezier)this;
        }
        private float MapToLinearTime(float u)
        {
            float val_8;
            var val_9 = 0;
            float val_1 = this.length * u;
            label_5:
            var val_2 = (100 < 0) ? (100 + 1) : 100;
            val_2 = val_9 + (val_2 >> 1);
            float val_8 = this.lengths[val_2];
            if(val_8 >= 0)
            {
                goto label_2;
            }
            
            val_9 = val_2 + 1;
            if(100 > val_9)
            {
                goto label_5;
            }
            
            goto label_4;
            label_2:
            if(val_2 > val_9)
            {
                goto label_5;
            }
            
            label_4:
            var val_4 = val_2 - ((val_8 > val_1) ? 1 : 0);
            float val_10 = this.lengths[val_4];
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_10, b:  val_1, precision:  0.001f)) != false)
            {
                    val_8 = (float)val_4;
            }
            else
            {
                    float val_11 = this.lengths[val_4 + 1];
                val_11 = val_11 - val_10;
                val_11 = (val_1 - val_10) / val_11;
                val_8 = val_11 + (float)val_4;
            }
            
            val_8 = val_8 / 100f;
            return (float)val_8;
        }
        public UnityEngine.Vector3 GetValue(float t)
        {
            UnityEngine.Vector3 val_1 = Royal.Infrastructure.Utils.Animation.QuadraticBezierUtil.GetValue(t:  t, p0:  new UnityEngine.Vector3() {x = this.p0}, p1:  new UnityEngine.Vector3() {x = this.p1}, p2:  new UnityEngine.Vector3() {x = this.p2, y = ???, z = ???});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public UnityEngine.Vector3 GetLinearValue(float t)
        {
            UnityEngine.Vector3 val_2 = Royal.Infrastructure.Utils.Animation.QuadraticBezierUtil.GetValue(t:  this.MapToLinearTime(u:  t), p0:  new UnityEngine.Vector3() {x = this.p0}, p1:  new UnityEngine.Vector3() {x = this.p1}, p2:  new UnityEngine.Vector3() {x = this.p2, y = ???, z = ???});
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public QuadraticBezier()
        {
            this.lengths = new float[101];
        }
    
    }

}
