using UnityEngine;

namespace Royal.Scenes.Game.Utils.Spline
{
    public class TriDiagonalMatrixF
    {
        // Fields
        public float[] A;
        public float[] B;
        public float[] C;
        
        // Properties
        public int N { get; }
        public float Item { get; set; }
        
        // Methods
        public int get_N()
        {
            if(this.A == null)
            {
                    return 0;
            }
            
            return (int)this.A.Length;
        }
        public float get_Item(int row, int col)
        {
            System.Single[] val_2;
            int val_1 = row - col;
            if(val_1 == 1)
            {
                goto label_0;
            }
            
            if(val_1 == 1)
            {
                goto label_1;
            }
            
            if(val_1 != 0)
            {
                    return (float)val_2[row];
            }
            
            val_2 = this.B;
            if(val_2 != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_1:
            val_2 = this.A;
            label_6:
            return (float)val_2[row];
            label_0:
            if(this.C != null)
            {
                goto label_6;
            }
            
            throw new IndexOutOfRangeException();
        }
        public void set_Item(int row, int col, float value)
        {
            int val_1 = row - col;
            if(val_1 == 1)
            {
                goto label_1;
            }
            
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(val_1 != 0)
            {
                    throw new System.ArgumentException(message:  "Only the main, super, and sub diagonals can be set.");
            }
            
            label_8:
            this.B[row] = value;
            return;
            label_2:
            if(this.A != null)
            {
                goto label_8;
            }
            
            label_1:
            if(this.C != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
        }
        public TriDiagonalMatrixF(int n)
        {
            this.A = new float[0];
            this.B = new float[0];
            this.C = new float[0];
        }
        public string ToDisplayString(string fmt = "", string prefix = "")
        {
            string val_8;
            var val_9;
            var val_10;
            System.Single[] val_11;
            System.Single[] val_12;
            System.Single[] val_13;
            if(this.A == null)
            {
                    return prefix + "0x0 Matrix";
            }
            
            if(this.A.Length < 1)
            {
                    return prefix + "0x0 Matrix";
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_8 = fmt;
            val_9 = 0;
            goto label_3;
            label_11:
            System.Text.StringBuilder val_3 = val_1.Append(value:  prefix);
            val_10 = 0;
            goto label_4;
            label_8:
            System.Text.StringBuilder val_5 = val_1.AppendFormat(format:  "{0" + val_8 + "}", arg0:  this.Item[0, 0]);
            val_11 = this.A;
            if(val_11 != null)
            {
                    val_11 = this.A.Length;
            }
            
            val_11 = val_11 - 1;
            if(val_10 < val_11)
            {
                    System.Text.StringBuilder val_6 = val_1.Append(value:  ", ");
            }
            
            val_10 = 1;
            label_4:
            val_12 = this.A;
            if(val_12 != null)
            {
                    val_12 = this.A.Length;
            }
            
            if(val_10 < val_12)
            {
                goto label_8;
            }
            
            val_8 = 0;
            System.Text.StringBuilder val_7 = val_1.AppendLine();
            val_9 = 1;
            label_3:
            val_13 = this.A;
            if(val_13 != null)
            {
                    val_13 = this.A.Length;
            }
            
            if(val_9 < val_13)
            {
                goto label_11;
            }
            
            return (string)val_1;
        }
        public float[] Solve(float[] d)
        {
            int val_9;
            if(this.A == null)
            {
                goto label_1;
            }
            
            val_9 = this.A.Length;
            if(d != null)
            {
                goto label_2;
            }
            
            label_1:
            val_9 = 0;
            label_2:
            if(val_9 != d.Length)
            {
                    throw new System.ArgumentException(message:  "The input d is not the same size as this matrix.");
            }
            
            float[] val_1 = new float[0];
            float val_18 = this.C[0];
            val_18 = val_18 / this.B[0];
            val_1[0] = val_18;
            if(val_9 >= 2)
            {
                    var val_24 = 0;
                int val_2 = val_1.Length & 4294967295;
                do
            {
                var val_3 = val_24 + 1;
                val_3 = val_3 - 1;
                val_3 = val_3 + 1;
                float val_20 = val_1[val_24];
                val_20 = val_20 * this.A[val_24];
                val_3 = val_3 + 1;
                val_20 = this.B[val_24] - val_20;
                val_20 = this.C[val_24] / val_20;
                val_24 = val_24 + 1;
                val_1[val_24] = val_20;
            }
            while(val_3 < 0);
            
            }
            
            float[] val_4 = new float[0];
            int val_27 = val_4.Length;
            float val_25 = d[0];
            val_25 = val_25 / this.B[0];
            val_4[0] = val_25;
            if(val_9 >= 2)
            {
                    var val_31 = 0;
                val_27 = val_27 & 4294967295;
                do
            {
                var val_7 = ((val_31 + 1) - 1) + 1;
                val_7 = val_7 - 1;
                val_7 = val_7 + 1;
                float val_28 = val_4[val_31];
                float val_29 = this.A[val_31];
                val_28 = val_28 * val_29;
                val_29 = val_29 * null;
                float val_9 = null - val_28;
                val_9 = val_9 / (this.B[val_31] - val_29);
                val_31 = val_31 + 1;
                val_4[val_31] = val_9;
            }
            while((val_7 + 1) < 0);
            
            }
            
            float[] val_11 = new float[0];
            var val_33 = (long)val_9 - 1;
            var val_13 = val_9 - 2;
            val_11[val_33] = val_4[val_33];
            if(val_33 < 0)
            {
                    return (System.Single[])val_11;
            }
            
            var val_36 = 0;
            val_33 = val_33 & 4294967295;
            do
            {
                var val_14 = (long)val_13 + val_36;
                int val_34 = val_11.Length;
                val_34 = val_34 & 4294967295;
                float val_16 = null * (val_11[val_33 + val_36]);
                val_16 = null - val_16;
                mem2[0] = val_16;
                val_36 = val_36 - 1;
            }
            while(val_13 >= 0);
            
            return (System.Single[])val_11;
        }
    
    }

}
