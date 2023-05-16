using UnityEngine;

namespace DigitalRuby.LightningBolt
{
    public class LightningBoltScript : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject StartObject;
        public UnityEngine.Vector3 StartPosition;
        public UnityEngine.GameObject EndObject;
        public UnityEngine.Vector3 EndPosition;
        public int Generations;
        public float Duration;
        private float timer;
        public float ChaosFactor;
        public bool ManualMode;
        public int Rows;
        public int Columns;
        public DigitalRuby.LightningBolt.LightningBoltAnimationMode AnimationMode;
        public System.Random RandomGenerator;
        private UnityEngine.LineRenderer lineRenderer;
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> segments;
        private int startIndex;
        private UnityEngine.Vector2 size;
        private UnityEngine.Vector2[] offsets;
        private int animationOffsetIndex;
        private int animationPingPongDirection;
        private bool orthographic;
        
        // Methods
        private void GetPerpendicularVector(ref UnityEngine.Vector3 directionNormalized, out UnityEngine.Vector3 side)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            val_9 = directionNormalized.y;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_10 = directionNormalized.x;
            val_11 = val_9;
            val_12 = directionNormalized.z;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            }
            else
            {
                    val_9 = directionNormalized.x;
                float val_8 = System.Math.Abs(directionNormalized.y);
                float val_9 = System.Math.Abs(directionNormalized.z);
                if((System.Math.Abs(val_9) >= val_8) && (val_8 >= val_9))
            {
                    val_12 = 1f;
                val_10 = (-(directionNormalized.y + directionNormalized.z)) / val_9;
                val_11 = val_12;
            }
            else
            {
                    if(val_8 < val_9)
            {
                    val_11 = 1f;
                val_12 = (-(val_9 + directionNormalized.y)) / directionNormalized.z;
                val_10 = val_11;
            }
            else
            {
                    val_12 = 1f;
                val_11 = (-(val_9 + directionNormalized.z)) / directionNormalized.y;
                val_10 = val_12;
            }
            
            }
            
            }
            
            side.x = val_10;
            side.y = val_11;
            side.z = val_12;
        }
        private void GenerateLightningBolt(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int generation, int totalGenerations, float offsetAmount)
        {
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_8;
            var val_9;
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            int val_15;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_16;
            val_9 = generation;
            val_10 = end.z;
            val_11 = end.y;
            val_12 = end.x;
            val_13 = start.z;
            if(val_9 > 8)
            {
                    return;
            }
            
            if(this.orthographic != false)
            {
                    float val_1 = UnityEngine.Mathf.Min(a:  val_13, b:  val_10);
                val_10 = val_1;
                val_13 = val_1;
            }
            
            val_8 = this.segments;
            val_8.Add(item:  new System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = -2.081018E-21f, y = 2.524356E-29f, z = -2.074291E-21f}});
            if(val_9 == 0)
            {
                    return;
            }
            
            if(offsetAmount <= 0f)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = val_11, z = val_10}, b:  new UnityEngine.Vector3() {x = start.x, y = start.y, z = val_13});
                val_2.x = val_2.x * this.ChaosFactor;
            }
            
            label_22:
            val_8 = this.segments;
            val_15 = this.startIndex;
            this.startIndex = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished;
            int val_7 = 24;
            int val_3 = 32 + (val_15 * val_7);
            label_20:
            val_16 = val_8;
            if(val_7 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_16 = this.segments;
            }
            
            val_7 = val_7 + val_3;
            val_13 = mem[(24 + (this.startIndex * 24) + 32) + 4];
            val_13 = (24 + (this.startIndex * 24) + 32) + 4;
            if(val_7 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_3;
            val_12 = mem[((24 + (this.startIndex * 24) + 32) + (this.startIndex * 24) + 32) + 12 + 4];
            val_12 = ((24 + (this.startIndex * 24) + 32) + (this.startIndex * 24) + 32) + 12 + 4;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7, y = val_13, z = (24 + (this.startIndex * 24) + 32) + 8}, b:  new UnityEngine.Vector3() {x = ((24 + (this.startIndex * 24) + 32) + (this.startIndex * 24) + 32) + 12, y = val_12, z = ((24 + (this.startIndex * 24) + 32) + (this.startIndex * 24) + 32) + 20});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.5f);
            this.RandomVector(start: ref  new UnityEngine.Vector3() {x = val_7, y = val_13, z = (24 + (this.startIndex * 24) + 32) + 8}, end: ref  new UnityEngine.Vector3() {x = ((24 + (this.startIndex * 24) + 32) + (this.startIndex * 24) + 32) + 12, y = val_12, z = ((24 + (this.startIndex * 24) + 32) + (this.startIndex * 24) + 32) + 20}, offsetAmount:  val_2.x, result: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_11 = val_6.z;
            this.segments.Add(item:  new System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = -2.081018E-21f, y = 2.524356E-29f, z = -2.074291E-21f}});
            val_8 = this.segments;
            val_8.Add(item:  new System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = -2.081018E-21f, y = 2.524356E-29f, z = -2.074291E-21f}});
            val_15 = val_15 + 1;
            if(val_15 >= this.startIndex)
            {
                goto label_19;
            }
            
            val_3 = val_3 + 24;
            if(this.segments != null)
            {
                goto label_20;
            }
            
            label_19:
            float val_8 = val_2.x;
            val_9 = val_9 - 1;
            val_8 = val_8 * 0.5f;
            if(val_9 > 1)
            {
                goto label_22;
            }
        
        }
        public void RandomVector(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, float offsetAmount, out UnityEngine.Vector3 result)
        {
            float val_8;
            float val_9;
            float val_13;
            float val_14;
            float val_15;
            float val_16;
            val_8 = end.z;
            val_9 = start.y;
            if(this.orthographic != false)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = val_8}, b:  new UnityEngine.Vector3() {x = start.x, y = val_9, z = start.z});
                float val_7 = (float)-val_1.y;
                val_13 = 0f;
                val_14 = 0f;
                val_15 = 0f;
                val_7 = val_7 * offsetAmount;
                val_7 = val_7 + val_7;
                val_16 = val_7 - offsetAmount;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = val_8}, b:  new UnityEngine.Vector3() {x = start.x, y = val_9, z = start.z});
                val_9 = val_2.y;
                val_2.x.GetPerpendicularVector(directionNormalized: ref  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, side: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_8 = (float)(float)val_2.x * 360f;
                val_13 = val_8;
                val_14 = val_2.x;
                val_15 = val_9;
                val_16 = ((float)val_2.x + 0.1f) * offsetAmount;
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  val_13, axis:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_2.z});
                UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  val_16);
            result.x = val_6.x;
            result.y = val_6.y;
            result.z = val_6.z;
        }
        private void SelectOffsetFromAnimationMode()
        {
            int val_5;
            UnityEngine.Vector2[] val_6;
            if(this.AnimationMode == 3)
            {
                goto label_0;
            }
            
            if(this.AnimationMode == 2)
            {
                goto label_1;
            }
            
            if(this.AnimationMode == 0)
            {
                goto label_23;
            }
            
            val_5 = this.RandomGenerator;
            if((val_5 & 2147483648) == 0)
            {
                goto label_24;
            }
            
            goto label_23;
            label_1:
            val_5 = this.animationOffsetIndex;
            int val_1 = val_5 + 1;
            this.animationOffsetIndex = val_1;
            if(val_1 < this.offsets.Length)
            {
                goto label_8;
            }
            
            this.animationOffsetIndex = 0;
            if((val_5 & 2147483648) == 0)
            {
                goto label_24;
            }
            
            goto label_23;
            label_0:
            val_5 = this.animationOffsetIndex;
            int val_5 = this.animationPingPongDirection;
            val_5 = val_5 + val_5;
            this.animationOffsetIndex = val_5;
            if(val_5 >= this.offsets.Length)
            {
                goto label_12;
            }
            
            if((val_5 & 2147483648) != 0)
            {
                goto label_13;
            }
            
            label_8:
            if((val_5 & 2147483648) != 0)
            {
                goto label_23;
            }
            
            label_24:
            if(val_5 >= this.offsets.Length)
            {
                goto label_23;
            }
            
            UnityEngine.Material val_2 = this.lineRenderer.material;
            goto label_21;
            label_12:
            this.animationOffsetIndex = this.offsets.Length - 2;
            this.animationPingPongDirection = 0;
            if((val_5 & 2147483648) == 0)
            {
                goto label_24;
            }
            
            goto label_23;
            label_13:
            this.animationOffsetIndex = 1;
            this.animationPingPongDirection = 0;
            if((val_5 & 2147483648) == 0)
            {
                goto label_24;
            }
            
            label_23:
            val_6 = this.offsets;
            label_21:
            this.lineRenderer.material.mainTextureOffset = new UnityEngine.Vector2() {x = val_6[0], y = val_6[0]};
        }
        private void UpdateLineRenderer()
        {
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_5;
            var val_6;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_6 = this.segments;
            val_6 = val_6 - this.startIndex;
            System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>> val_1 = val_6 + 1;
            this.lineRenderer.positionCount = val_1;
            if(val_1 < 1)
            {
                    return;
            }
            
            if(val_6 <= this.startIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (this.startIndex * 24);
            this.lineRenderer.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = (this.startIndex * 24) + (this.segments - this.startIndex) + 32, y = (this.startIndex * 24) + (this.segments - this.startIndex) + 32 + 4, z = (this.startIndex * 24) + (this.segments - this.startIndex) + 40});
            val_5 = this.segments;
            val_6 = 1;
            int val_2 = this.startIndex + ((this.startIndex) << 1);
            int val_3 = val_2 << 3;
            label_11:
            int val_4 = this.startIndex + val_6;
            val_4 = val_4 - 1;
            if(val_4 >= val_2)
            {
                goto label_8;
            }
            
            if(val_2 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + val_3;
            this.lineRenderer.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = ((this.startIndex + (this.startIndex) << 1) + ((this.startIndex + (this.startIndex) << 1) << 3)) + 44, y = ((this.startIndex + (this.startIndex) << 1) + ((this.startIndex + (this.startIndex) << 1) << 3)) + 44 + 4, z = ((this.startIndex + (this.startIndex) << 1) + ((this.startIndex + (this.startIndex) << 1) << 3)) + 52});
            val_5 = this.segments;
            val_3 = val_3 + 24;
            val_6 = val_6 + 1;
            if(val_5 != null)
            {
                goto label_11;
            }
            
            throw new NullReferenceException();
            label_8:
            val_5.Clear();
            this.SelectOffsetFromAnimationMode();
        }
        private void Start()
        {
            bool val_7;
            if(UnityEngine.Camera.main == 0)
            {
                goto label_3;
            }
            
            val_7 = UnityEngine.Camera.main.orthographic;
            if(this != null)
            {
                goto label_5;
            }
            
            label_3:
            val_7 = false;
            label_5:
            this.orthographic = val_7;
            UnityEngine.LineRenderer val_5 = this.GetComponent<UnityEngine.LineRenderer>();
            this.lineRenderer = val_5;
            val_5.positionCount = 0;
            this.UpdateFromMaterialChange();
        }
        private void Update()
        {
            bool val_7;
            if(UnityEngine.Camera.main == 0)
            {
                goto label_3;
            }
            
            val_7 = UnityEngine.Camera.main.orthographic;
            if(this != null)
            {
                goto label_5;
            }
            
            label_3:
            val_7 = false;
            label_5:
            this.orthographic = val_7;
            if(this.timer <= 0f)
            {
                    if(this.ManualMode != false)
            {
                    this.timer = this.Duration;
                this.lineRenderer.positionCount = 0;
            }
            else
            {
                    this.Trigger();
            }
            
            }
            
            float val_5 = UnityEngine.Time.deltaTime;
            val_5 = this.timer - val_5;
            this.timer = val_5;
        }
        public void Trigger()
        {
            float val_10;
            float val_12;
            UnityEngine.Vector3 val_13;
            float val_14;
            float val_15;
            UnityEngine.Vector3 val_16;
            val_10 = this.timer;
            val_12 = this.Duration + (UnityEngine.Mathf.Min(a:  0f, b:  val_10));
            this.timer = val_12;
            if(this.StartObject == 0)
            {
                    val_13 = this.StartPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = this.StartObject.transform.position;
                val_16 = this.StartPosition;
                val_12 = val_4.x;
                val_10 = val_4.y;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12, y = val_10, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_16, y = V11.16B, z = V10.16B});
                val_13 = val_5.x;
                val_14 = val_5.y;
                val_15 = val_5.z;
            }
            
            if(this.EndObject == 0)
            {
                
            }
            else
            {
                    UnityEngine.Vector3 val_8 = this.EndObject.transform.position;
                val_16 = val_8.y;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_16, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.EndPosition, y = V14.16B, z = val_4.z});
                val_13 = val_13;
            }
            
            this.startIndex = 0;
            this.GenerateLightningBolt(start:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, end:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, generation:  this.Generations, totalGenerations:  0, offsetAmount:  0f);
            this.UpdateLineRenderer();
        }
        public void UpdateFromMaterialChange()
        {
            int val_7;
            int val_8;
            float val_7 = (float)this.Columns;
            float val_8 = (float)this.Rows;
            val_7 = 1f / val_7;
            val_8 = 1f / val_8;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  val_7, y:  val_8);
            this.size = val_1.x;
            this.lineRenderer.material.mainTextureScale = new UnityEngine.Vector2() {x = this.size, y = val_8};
            int val_3 = this.Columns * this.Rows;
            val_7 = this.Rows;
            this.offsets = new UnityEngine.Vector2[0];
            if(val_7 < 1)
            {
                    return;
            }
            
            val_8 = this.Columns;
            var val_12 = 0;
            do
            {
                if(val_8 >= 1)
            {
                    var val_11 = 0;
                do
            {
                float val_9 = 0f;
                val_9 = val_9 / (float)val_8;
                float val_10 = (float)val_7;
                val_10 = 0f / val_10;
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_9, y:  val_10);
                val_11 = val_11 + 1;
                this.offsets[val_11 + (val_12 * val_8)] = val_5.x;
                val_7 = this.Rows;
                val_8 = this.Columns;
            }
            while(val_11 < val_8);
            
            }
            
                val_12 = val_12 + 1;
            }
            while(val_12 < val_7);
        
        }
        public LightningBoltScript()
        {
            this.Generations = 6;
            this.Duration = 7.346868E-41f;
            this.ChaosFactor = 0.15f;
            this.Rows = 1;
            this.Columns = 0;
            this.AnimationMode = 3;
            this.RandomGenerator = new System.Random();
            this.segments = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Vector3, UnityEngine.Vector3>>();
            this.animationPingPongDirection = 1;
        }
    
    }

}
