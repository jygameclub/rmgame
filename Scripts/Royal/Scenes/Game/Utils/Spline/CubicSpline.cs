using UnityEngine;

namespace Royal.Scenes.Game.Utils.Spline
{
    public class CubicSpline
    {
        // Fields
        private float[] a;
        private float[] b;
        private float[] xOrig;
        private float[] yOrig;
        private int _lastIndex;
        
        // Methods
        public CubicSpline()
        {
        
        }
        public CubicSpline(float[] x, float[] y, float startSlope = NaN, float endSlope = NaN, bool debug = False)
        {
            debug = debug;
            this.Fit(x:  x, y:  y, startSlope:  startSlope, endSlope:  endSlope, debug:  debug);
        }
        private void CheckAlreadyFitted()
        {
            if(this.a == null)
            {
                    throw new System.Exception(message:  "Fit must be called before you can evaluate.");
            }
        
        }
        private int GetNextXIndex(float x)
        {
            int val_4 = this._lastIndex;
            int val_5 = (long)val_4;
            if(this.xOrig[val_5] > x)
            {
                    throw new System.ArgumentException(message:  "The X values to evaluate must be sorted.");
            }
            
            if(val_4 >= (this.xOrig.Length - 2))
            {
                    return (int)val_4;
            }
            
            val_4 = val_5;
            do
            {
                val_5 = val_4 + 1;
                if(this.xOrig[val_4] >= 0)
            {
                    return (int)val_4;
            }
            
                this._lastIndex = val_5;
                val_4 = val_4 + 1;
            }
            while(val_4 < (((-8589934592) + ((this.xOrig.Length) << 32)) >> 32));
            
            return (int)val_4;
        }
        private float EvalSpline(float x, int j, bool debug = False)
        {
            int val_7;
            object val_8;
            val_7 = j;
            val_8 = this;
            float val_3 = x - null;
            float val_4 = val_3 / (null - null);
            float val_9 = this.a[(long)val_7];
            float val_10 = this.yOrig[(long)val_7];
            float val_11 = 1f;
            val_11 = val_11 - val_4;
            val_3 = val_4 * (this.yOrig[(long)val_7 + 1]);
            val_9 = val_11 * val_9;
            val_10 = val_11 * val_10;
            val_11 = val_4 * val_11;
            val_9 = val_9 + (val_4 * this.b[(long)val_7]);
            val_3 = val_10 + val_3;
            val_9 = val_11 * val_9;
            if(debug == false)
            {
                    return (float)val_3 + val_9;
            }
            
            val_7 = val_7;
            val_8 = val_4;
            System.Console.WriteLine(format:  "xs = {0}, j = {1}, t = {2}", arg0:  x, arg1:  val_7, arg2:  val_4);
            return (float)val_3 + val_9;
        }
        public float[] FitAndEval(float[] x, float[] y, float[] xs, float startSlope = NaN, float endSlope = NaN, bool debug = False)
        {
            bool val_1 = debug;
            this.Fit(x:  x, y:  y, startSlope:  startSlope, endSlope:  endSlope, debug:  val_1);
            return this.Eval(x:  xs, debug:  val_1);
        }
        public void Fit(float[] x, float[] y, float startSlope = NaN, float endSlope = NaN, bool debug = False)
        {
            bool val_31;
            float val_32;
            float val_33;
            var val_34;
            object val_35;
            float val_36;
            float val_37;
            var val_38;
            var val_39;
            val_31 = debug;
            val_32 = endSlope;
            val_33 = startSlope;
            if((System.Single.IsInfinity(f:  val_33)) == true)
            {
                    throw new System.Exception(message:  "startSlope and endSlope cannot be infinity.");
            }
            
            if((System.Single.IsInfinity(f:  val_32)) == true)
            {
                    throw new System.Exception(message:  "startSlope and endSlope cannot be infinity.");
            }
            
            this.xOrig = x;
            this.yOrig = y;
            val_34 = 1152921506544102208;
            float[] val_3 = new float[0];
            Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF val_4 = null;
            val_35 = val_4;
            val_4 = new Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF(n:  x.Length);
            if((System.Single.IsNaN(f:  val_33)) != false)
            {
                    float val_31 = x[0];
                val_31 = x[1] - val_31;
                float val_33 = 1f;
                val_33 = val_33 / val_31;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].C = val_33;
                float val_34 = (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].C[0];
                val_34 = val_34 + val_34;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].B = val_34;
                float val_35 = y[0];
                val_36 = y[1];
                val_31 = val_31 * val_31;
                val_35 = val_36 - val_35;
                val_35 = val_35 * 3f;
                val_33 = val_35 / val_31;
            }
            else
            {
                    (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].B = 1065353216;
            }
            
            int val_6 = x.Length - 1;
            val_3[0] = val_33;
            if(val_6 >= 2)
            {
                    var val_42 = 0;
                var val_36 = 1;
                do
            {
                val_36 = val_36 - 1;
                val_36 = val_36 + 2;
                val_36 = val_36 - 1;
                float val_7 = null - null;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].A[val_42] = 1f / val_7;
                float val_9 = null - null;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].C[val_42] = 1f / val_9;
                float val_37 = (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].A[val_42];
                val_37 = val_37 + (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].C[val_42];
                val_37 = val_37 + val_37;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].B[val_42] = val_37;
                val_36 = val_36 - 1;
                val_36 = val_36 + 2;
                val_36 = val_36 - 1;
                float val_39 = y[val_42];
                float val_40 = y[val_42];
                val_7 = val_7 * val_7;
                val_39 = val_40 - val_39;
                val_9 = val_9 * val_9;
                val_40 = y[val_42] - val_40;
                val_7 = val_39 / val_7;
                val_9 = val_40 / val_9;
                val_7 = val_7 + val_9;
                val_36 = val_36 + 1;
                val_36 = val_7 * 3f;
                mem2[0] = val_36;
                val_42 = val_42 + 4;
            }
            while(val_36 < (long)val_6);
            
            }
            
            val_37 = val_32;
            if((System.Single.IsNaN(f:  val_37)) != false)
            {
                    int val_12 = x.Length - 2;
                val_38 = (long)val_6;
                float val_13 = null - null;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].A[val_38] = 1f / val_13;
                float val_43 = (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].A[val_38];
                val_43 = val_43 + val_43;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].B[val_38] = val_43;
                val_13 = val_13 * val_13;
                val_37 = (null - null) / val_13;
                val_32 = val_37 * 3f;
            }
            else
            {
                    val_38 = (long)val_6;
                (Royal.Scenes.Game.Utils.Spline.TriDiagonalMatrixF)[1152921519824695088].B[val_38] = 1f;
            }
            
            val_3[val_38] = val_32;
            if(val_31 != false)
            {
                    System.Console.WriteLine(format:  "Tri-diagonal matrix:\n{0}", arg0:  val_4.ToDisplayString(fmt:  ":0.0000", prefix:  "  "));
                System.Console.WriteLine(format:  "r: {0}", arg0:  Royal.Scenes.Game.Utils.Spline.ArrayUtil.ToString<System.Single>(array:  val_3, format:  ""));
                System.Single[] val_18 = val_4.Solve(d:  val_3);
                val_39 = val_18;
                val_35 = Royal.Scenes.Game.Utils.Spline.ArrayUtil.ToString<System.Single>(array:  val_18, format:  "");
                System.Console.WriteLine(format:  "k = {0}", arg0:  val_35);
                val_31 = val_31;
                val_34 = 1152921506544102208;
            }
            else
            {
                    val_39 = val_4.Solve(d:  val_3);
            }
            
            this.a = new float[0];
            this.b = new float[0];
            if(x.Length >= 2)
            {
                    var val_44 = 8;
                do
            {
                var val_23 = val_44 - 7;
                val_23 = val_23 - 1;
                val_23 = val_23 + 1;
                val_23 = val_23 - 1;
                float val_24 = null - null;
                float val_25 = null - null;
                float val_26 = val_24 * null;
                val_26 = val_26 - val_25;
                this.a = val_26;
                var val_27 = val_23 + 1;
                val_27 = val_27 - 1;
                val_27 = val_27 + 2;
                val_24 = val_24 * val_26;
                val_25 = val_25 - val_24;
                this.b = val_25;
                val_44 = val_44 + 1;
            }
            while(val_27 < (long)x.Length);
            
            }
            
            if(val_31 == false)
            {
                    return;
            }
            
            System.Console.WriteLine(format:  "a: {0}", arg0:  Royal.Scenes.Game.Utils.Spline.ArrayUtil.ToString<System.Single>(array:  this.a, format:  ""));
            System.Console.WriteLine(format:  "b: {0}", arg0:  Royal.Scenes.Game.Utils.Spline.ArrayUtil.ToString<System.Single>(array:  this.b, format:  ""));
        }
        public float[] Eval(float[] x, bool debug = False)
        {
            int val_5;
            this.CheckAlreadyFitted();
            val_5 = x.Length;
            float[] val_1 = new float[0];
            this._lastIndex = 0;
            if(val_5 < 1)
            {
                    return (System.Single[])val_1;
            }
            
            var val_5 = 0;
            val_5 = (long)val_5;
            do
            {
                mem2[0] = this.EvalSpline(x:  1.966197E+31f, j:  this.GetNextXIndex(x:  1.966197E+31f), debug:  debug);
                val_5 = val_5 + 1;
            }
            while(val_5 < val_5);
            
            return (System.Single[])val_1;
        }
        public float[] EvalSlope(float[] x, bool debug = False)
        {
            var val_14;
            int val_15;
            System.Single[] val_16;
            this.CheckAlreadyFitted();
            val_15 = x.Length;
            val_16 = new float[0];
            this._lastIndex = 0;
            if(val_15 < 1)
            {
                    return val_16;
            }
            
            object val_16 = 0;
            val_14 = (long)val_15;
            do
            {
                int val_2 = this.GetNextXIndex(x:  1.966197E+31f);
                int val_3 = val_2 + 1;
                val_15 = val_2;
                float val_14 = this.a[(long)val_15];
                float val_15 = this.b[(long)val_15];
                float val_4 = null - null;
                float val_7 = (null - null) / val_4;
                float val_8 = (null - null) / val_4;
                float val_9 = 1f - val_7;
                float val_10 = val_15 - val_14;
                float val_11 = val_7 + val_7;
                val_15 = val_7 * val_15;
                val_14 = val_9 * val_14;
                val_11 = 1f - val_11;
                val_9 = val_7 * val_9;
                val_14 = val_14 + val_15;
                val_10 = val_9 * val_10;
                float val_12 = val_11 * val_14;
                val_12 = val_12 / val_4;
                val_8 = val_8 + val_12;
                val_4 = val_10 / val_4;
                val_8 = val_4 + val_8;
                mem2[0] = val_8;
                if(debug != false)
            {
                    object[] val_13 = new object[4];
                val_13[0] = val_16;
                val_13[1] = null;
                val_13[2] = val_15;
                val_15 = val_7;
                val_13[3] = val_15;
                System.Console.WriteLine(format:  "[{0}]: xs = {1}, j = {2}, t = {3}", arg:  val_13);
                val_16 = val_16;
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 < val_14);
            
            return val_16;
        }
        public static float[] Compute(float[] x, float[] y, float[] xs, float startSlope = NaN, float endSlope = NaN, bool debug = False)
        {
            Royal.Scenes.Game.Utils.Spline.CubicSpline val_1 = new Royal.Scenes.Game.Utils.Spline.CubicSpline();
            bool val_2 = debug;
            val_1.Fit(x:  x, y:  y, startSlope:  startSlope, endSlope:  endSlope, debug:  val_2);
            return val_1.Eval(x:  xs, debug:  val_2);
        }
        public static void FitParametric(float[] x, float[] y, int nOutputPoints, out float[] xs, out float[] ys, float firstDx = NaN, float firstDy = NaN, float lastDx = NaN, float lastDy = NaN)
        {
            float val_16;
            float val_17;
            float[] val_1 = new float[0];
            val_16 = 0f;
            val_1[0] = 0f;
            if(x.Length >= 2)
            {
                    do
            {
                var val_2 = 9 - 8;
                val_2 = val_2 - 1;
                val_2 = val_2 + 1;
                float val_6 = (null - null) * (null - null);
                float val_7 = (null - null) * (null - null);
                val_7 = val_6 + val_7;
                if(val_6 >= _TYPE_MAX_)
            {
                    val_17 = val_7;
            }
            
                var val_8 = (val_2 - 1) + 1;
                val_16 = 0f + val_17;
                val_8 = val_8 + 1;
                val_1[1] = val_16;
                var val_9 = 9 + 1;
            }
            while(val_8 < (long)x.Length);
            
            }
            
            float[] val_10 = new float[0];
            int val_22 = val_10.Length;
            val_16 = val_16 / ((float)nOutputPoints - 1);
            val_10[0] = 0f;
            if(nOutputPoints >= 2)
            {
                    var val_24 = 0;
                val_22 = val_22 & 4294967295;
                do
            {
                var val_12 = val_24 + 1;
                float val_23 = val_10[val_24];
                val_24 = val_24 + 1;
                val_23 = val_16 + val_23;
                val_10[val_24] = val_23;
            }
            while((val_24 + 2) < (long)nOutputPoints);
            
            }
            
            Royal.Scenes.Game.Utils.Spline.CubicSpline.NormalizeVector(dx: ref  float val_14 = -3.334383E-32f, dy: ref  float val_15 = -3.334381E-32f);
            Royal.Scenes.Game.Utils.Spline.CubicSpline.NormalizeVector(dx: ref  float val_16 = -3.334378E-32f, dy: ref  float val_17 = -3.334377E-32f);
            Royal.Scenes.Game.Utils.Spline.CubicSpline val_18 = new Royal.Scenes.Game.Utils.Spline.CubicSpline();
            float val_25 = firstDx;
            float val_26 = lastDx;
            val_25 = val_25 / val_16;
            val_26 = val_26 / val_16;
            val_18.Fit(x:  val_1, y:  x, startSlope:  val_25, endSlope:  val_26, debug:  false);
            xs = val_18.Eval(x:  val_10, debug:  false);
            Royal.Scenes.Game.Utils.Spline.CubicSpline val_20 = new Royal.Scenes.Game.Utils.Spline.CubicSpline();
            float val_28 = firstDy;
            float val_29 = lastDy;
            val_28 = val_28 / val_16;
            val_29 = val_29 / val_16;
            val_20.Fit(x:  val_1, y:  y, startSlope:  val_28, endSlope:  val_29, debug:  false);
            ys = val_20.Eval(x:  val_10, debug:  false);
        }
        private static void NormalizeVector(ref float dx, ref float dy)
        {
            float val_6;
            if((System.Single.IsNaN(f:  dx)) != true)
            {
                    if((System.Single.IsNaN(f:  dy)) == false)
            {
                goto label_2;
            }
            
            }
            
            dy = 0f;
            dx = 0f;
            return;
            label_2:
            float val_3 = dx * dx;
            float val_4 = dy * dy;
            val_4 = val_3 + val_4;
            if(val_3 >= _TYPE_MAX_)
            {
                    val_6 = val_4;
            }
            
            if(val_6 <= (1.401298E-45f))
            {
                    throw new System.ArgumentException(message:  "The input vector is too small to be normalized.");
            }
            
            float val_6 = dx;
            val_6 = val_6 / val_6;
            dx = val_6;
            val_6 = dy / val_6;
            dy = val_6;
        }
    
    }

}
