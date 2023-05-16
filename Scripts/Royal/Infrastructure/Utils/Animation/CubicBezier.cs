using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public class CubicBezier
    {
        // Fields
        private const int Len = 100;
        private float[] lengths;
        private UnityEngine.Vector3 p0;
        private UnityEngine.Vector3 p1;
        private UnityEngine.Vector3 p2;
        private UnityEngine.Vector3 p3;
        public float length;
        
        // Methods
        public Royal.Infrastructure.Utils.Animation.CubicBezier Init(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            var val_1;
            var val_2;
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            val_6 = val_2;
            val_7 = p1.x;
            val_6 = val_6;
            this.p0 = p0;
            mem[1152921527485113724] = p0.y;
            mem[1152921527485113728] = p0.z;
            this.p1 = p1;
            mem[1152921527485113736] = p1.y;
            mem[1152921527485113740] = p1.z;
            this.p2 = p2;
            mem[1152921527485113748] = val_6;
            mem[1152921527485113752] = p2.y;
            this.p3 = p2.z;
            mem[1152921527485113760] = val_1;
            mem[1152921527485113764] = p3.x;
            val_8 = 0f;
            UnityEngine.Vector3 val_3 = this.GetValue(t:  0f);
            val_9 = val_3.x;
            val_10 = val_3.y;
            label_7:
            if((9 - 8) >= (this.lengths.Length << ))
            {
                goto label_2;
            }
            
            float val_9 = (float)9 - 8;
            val_9 = val_9 / (float)this.lengths.Length;
            UnityEngine.Vector3 val_6 = this.GetValue(t:  val_9);
            val_7 = val_6.y;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_7, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_3.z});
            val_8 = val_8 + val_7.x;
            this.lengths = val_8;
            var val_8 = 9 + 1;
            val_10 = val_7;
            val_9 = val_6.x;
            if(this.lengths != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_2:
            this.length = val_8;
            return (Royal.Infrastructure.Utils.Animation.CubicBezier)this;
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
        public float GetLengthForT(float t)
        {
            t = t * 100f;
            return (float)this.lengths[(int)t];
        }
        public UnityEngine.Vector3 GetValue(float t)
        {
            UnityEngine.Vector3 val_1 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  t, p0:  new UnityEngine.Vector3() {x = this.p0}, p1:  new UnityEngine.Vector3() {x = this.p1}, p2:  new UnityEngine.Vector3() {x = this.p2, y = ???, z = this.p3}, p3:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???});
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public UnityEngine.Vector3 GetLinearValue(float t)
        {
            UnityEngine.Vector3 val_2 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  this.MapToLinearTime(u:  t), p0:  new UnityEngine.Vector3() {x = this.p0}, p1:  new UnityEngine.Vector3() {x = this.p1}, p2:  new UnityEngine.Vector3() {x = this.p2, y = ???, z = this.p3}, p3:  new UnityEngine.Vector3() {x = ???, y = ???});
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public CubicBezier()
        {
            this.lengths = new float[101];
        }
    
    }

}
