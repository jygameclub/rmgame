using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Scroll
{
    public abstract class UiScroll : UiTouchComponent, IScrollable, IDraggable, ITouchable
    {
        // Fields
        protected const float Speed = 0.52;
        private const float Threshold = 0.195;
        private const float StretchFactor = 0.205;
        private const float StretchOffset = 3;
        private const float StretchBackFactor = 0.098;
        private const float ForceLimit = 2.97;
        private const float ForceTolerance = 0.0001;
        private const float ForceIncreaseFactor = 0.982;
        private const float ForceDecreaseFactor = 0.934;
        public UnityEngine.SpriteMask scrollMask;
        public UnityEngine.BoxCollider2D scrollArea;
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContent content;
        protected float min;
        protected float max;
        protected float last;
        private bool touchEnded;
        private int scrollSteadyCount;
        private float current;
        private float previous;
        private float start;
        private float force;
        private readonly float[] drags;
        public bool enableScroll;
        public bool touchDownOnDisabled;
        private bool <IsDragging>k__BackingField;
        
        // Properties
        public float Min { get; }
        public float Max { get; }
        public bool IsDragging { get; set; }
        public abstract Royal.Infrastructure.UiComponents.Scroll.Direction ScrollDirection { get; }
        
        // Methods
        public float get_Min()
        {
            return (float)this.min;
        }
        public float get_Max()
        {
            return (float)this.max;
        }
        public bool get_IsDragging()
        {
            return (bool)this.<IsDragging>k__BackingField;
        }
        private void set_IsDragging(bool value)
        {
            this.<IsDragging>k__BackingField = value;
        }
        public abstract Royal.Infrastructure.UiComponents.Scroll.Direction get_ScrollDirection(); // 0
        protected abstract void PrepareContent(); // 0
        public abstract void PrepareContent(float position); // 0
        protected abstract void MoveContent(); // 0
        protected abstract float LocalPosition(UnityEngine.Vector2 worldPosition); // 0
        protected virtual void Awake()
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContent val_2;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContent val_3;
            this.enableScroll = true;
            UnityEngine.Bounds val_1 = this.scrollMask.bounds;
            this.content = this;
            this.content = val_2;
            this.content = val_3;
            this.content.add_OnContentChanged(value:  new System.Action(object:  this, method:  typeof(Royal.Infrastructure.UiComponents.Scroll.UiScroll).__il2cppRuntimeField_278));
        }
        private void Update()
        {
            if(this.enableScroll == false)
            {
                    return;
            }
            
            if(this.touchDownOnDisabled == true)
            {
                    return;
            }
            
            if(this.scrollSteadyCount > 5)
            {
                    return;
            }
            
            if(this.touchEnded == false)
            {
                    return;
            }
            
            this.AfterTouchEnded();
        }
        private void AfterTouchEnded()
        {
            float val_3;
            float val_4;
            float val_5;
            val_3 = this.last;
            if(System.Math.Abs(this.force) > 0.0001f)
            {
                    float val_3 = this.force;
                val_3 = val_3 * 0.934f;
                this.force = val_3;
                val_3 = val_3 + val_3;
            }
            else
            {
                    this.force = 0f;
            }
            
            val_4 = this.min;
            if(val_3 <= val_4)
            {
                goto label_5;
            }
            
            val_4 = this.max;
            val_5 = 0f;
            if(val_3 < val_4)
            {
                goto label_6;
            }
            
            label_5:
            val_5 = val_3 - val_4;
            label_6:
            float val_1 = UnityEngine.Mathf.Clamp(value:  val_5, min:  -3f, max:  3f);
            if((val_1 != 0f) && (val_1 <= _TYPE_MAX_))
            {
                    float val_4 = this.force;
                val_4 = val_4 * 0.7f;
                this.force = val_4;
            }
            
            val_1 = val_1 * (-0.098f);
            val_5 = val_3 + val_1;
            if((this.<IsDragging>k__BackingField) != true)
            {
                    val_1 = val_5 ?? this.last;
                if(val_1 < 0)
            {
                    int val_5 = this.scrollSteadyCount;
                val_5 = val_5 + 1;
                this.scrollSteadyCount = val_5;
            }
            
            }
            
            this.last = val_5;
            goto typeof(Royal.Infrastructure.UiComponents.Scroll.UiScroll).__il2cppRuntimeField_290;
        }
        public override void TouchDown(UnityEngine.Vector2 worldPos)
        {
            if(this.enableScroll != false)
            {
                    this.scrollSteadyCount = 0;
                this.force = 0f;
                this.previous = worldPos.x;
                this.start = worldPos.x;
                this.touchEnded = false;
                return;
            }
            
            this.touchDownOnDisabled = true;
        }
        public override void TouchMove(UnityEngine.Vector2 worldPos)
        {
            float val_10;
            bool val_11;
            float val_12;
            System.Single[] val_13;
            float val_14;
            var val_15;
            float val_16;
            if(this.enableScroll == false)
            {
                    return;
            }
            
            if(this.touchDownOnDisabled != false)
            {
                    return;
            }
            
            val_10 = worldPos.x;
            val_11 = this.<IsDragging>k__BackingField;
            if(((val_10 ?? this.start) <= 0.195f) || (val_11 == true))
            {
                goto label_6;
            }
            
            this.<IsDragging>k__BackingField = true;
            this.current = worldPos.x;
            var val_9 = 0;
            label_10:
            if(val_9 >= (this.drags.Length << ))
            {
                goto label_8;
            }
            
            val_9 = val_9 + 1;
            this.drags[val_9] = this.current;
            if(this.drags != null)
            {
                goto label_10;
            }
            
            label_8:
            val_11 = this.<IsDragging>k__BackingField;
            label_6:
            if(val_11 == false)
            {
                    return;
            }
            
            this.current = worldPos.x;
            val_12 = this.current;
            val_13 = this.drags;
            this.previous = val_12;
            int val_10 = this.drags.Length;
            val_14 = UnityEngine.Mathf.Clamp(value:  worldPos.x - this.previous, min:  -3f, max:  3f);
            int val_4 = val_10 - 1;
            if(val_4 >= 1)
            {
                    val_10 = val_10 - 2;
                var val_11 = (long)val_4;
                val_11 = val_11 + 8;
                val_10 = val_10 + 32;
                do
            {
                int val_12 = this.drags.Length;
                val_4 = val_4 - 1;
                var val_5 = val_11 - 8;
                val_12 = val_12 & 4294967295;
                val_10 = val_10 - 4;
                val_13 = null;
                val_13 = this.drags;
                val_11 = val_11 - 1;
            }
            while(val_4 > 0);
            
                val_12 = this.current;
            }
            
            val_13 = val_12;
            if((val_14 < 0) && (this.last <= this.min))
            {
                    val_15 = this.last - this.min;
            }
            else
            {
                    float val_13 = this.max;
                val_13 = this.last - val_13;
            }
            
            float val_7 = UnityEngine.Mathf.Clamp(value:  System.Math.Abs((this.last > val_13) ? (val_13) : 0f), min:  0f, max:  3f);
            if(val_7 > 0f)
            {
                    val_10 = val_7;
                float val_15 = System.Math.Abs(val_10);
                val_15 = 3f - val_15;
                val_16 = val_15 * 0.205f;
                float val_8 = UnityEngine.Mathf.Clamp01(value:  val_16);
            }
            else
            {
                    val_16 = 1f;
            }
            
            val_16 = val_14 * val_16;
            val_16 = this.last + val_16;
            this.last = val_16;
            goto typeof(Royal.Infrastructure.UiComponents.Scroll.UiScroll).__il2cppRuntimeField_290;
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            float val_4;
            if(this.touchDownOnDisabled != false)
            {
                    this.touchDownOnDisabled = false;
            }
            
            if(this.enableScroll == false)
            {
                    return;
            }
            
            if((this.last <= this.min) || (this.last >= this.max))
            {
                goto label_4;
            }
            
            if((this.<IsDragging>k__BackingField) == false)
            {
                goto label_5;
            }
            
            int val_5 = this.drags.Length;
            int val_1 = val_5 - 1;
            if(val_1 < 1)
            {
                goto label_7;
            }
            
            val_5 = val_5 & 4294967295;
            do
            {
                float val_6 = this.drags[0];
                val_6 = val_6 - this.drags[0];
                val_4 = 0f + val_6;
            }
            while((0 + 1) < (long)val_1);
            
            goto label_11;
            label_4:
            this.<IsDragging>k__BackingField = false;
            this.touchEnded = true;
            this.force = 0f;
            return;
            label_7:
            val_4 = 0f;
            label_11:
            val_4 = val_4 / (float)val_1;
            this.force = UnityEngine.Mathf.Clamp(value:  val_4 * 0.982f, min:  -2.97f, max:  2.97f);
            label_5:
            this.<IsDragging>k__BackingField = false;
            this.touchEnded = true;
        }
        public override void CancelTouch(bool isTouchDisabled)
        {
            this.<IsDragging>k__BackingField = false;
            this.touchEnded = true;
            this.force = 0f;
        }
        public void UpdateMaskBounds()
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContent val_2;
            Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContent val_3;
            UnityEngine.Bounds val_1 = this.scrollMask.bounds;
            this.content = this;
            this.content = val_2;
            this.content = val_3;
        }
        protected virtual void OnDestroy()
        {
            this.enableScroll = false;
        }
        protected UiScroll()
        {
            this.drags = new float[3];
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
