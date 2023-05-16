using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Pinch
{
    public abstract class AreaPinch : MonoBehaviour, IPinchable, IDraggable, ITouchable
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Touch.ZIndex zIndex;
        private float previousLength;
        private UnityEngine.Vector3 startScale;
        private UnityEngine.Vector3 endScale;
        private float returnProgress;
        private bool returning;
        private bool multiTouchedLastFrame;
        private UnityEngine.Vector2 previousMidPoint;
        private UnityEngine.Vector3 startPosition;
        private UnityEngine.Vector3 scalePivotStartPosition;
        private UnityEngine.Vector3 imageStartPosition;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private bool singleTouchedLastFrame;
        private UnityEngine.Vector2 previousSinglePoint;
        private UnityEngine.Transform scalePivot;
        private UnityEngine.Transform image;
        private bool pinching;
        
        // Properties
        public Royal.Infrastructure.UiComponents.Touch.ZIndex ZIndex { get; set; }
        public bool IsDragging { get; }
        
        // Methods
        public Royal.Infrastructure.UiComponents.Touch.ZIndex get_ZIndex()
        {
            return (Royal.Infrastructure.UiComponents.Touch.ZIndex)this.zIndex;
        }
        public void set_ZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex value)
        {
            this.zIndex = value;
        }
        public bool get_IsDragging()
        {
            return (bool)this.pinching;
        }
        protected virtual void Start()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Transform val_3 = this.transform.GetChild(index:  0);
            this.scalePivot = val_3;
            UnityEngine.Vector3 val_4 = val_3.localScale;
            this.startScale = val_4;
            mem[1152921519098185620] = val_4.y;
            mem[1152921519098185624] = val_4.z;
            UnityEngine.Vector3 val_5 = this.scalePivot.localScale;
            this.endScale = val_5;
            mem[1152921519098185632] = val_5.y;
            mem[1152921519098185636] = val_5.z;
            this.pinching = false;
        }
        public void SetImage(UnityEngine.Transform image)
        {
            this.image = image;
        }
        private void Update()
        {
            bool val_3;
            if(UnityEngine.Input.touchCount == 0)
            {
                    this.NoTouchUpdate();
            }
            
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(UnityEngine.Input.touchCount != 1)
            {
                goto label_2;
            }
            
            if((this & 1) == 0)
            {
                goto label_3;
            }
            
            this.SingleTouchUpdate();
            val_3 = 1;
            goto label_4;
            label_3:
            this.NoTouchUpdate();
            label_2:
            val_3 = false;
            label_4:
            this.singleTouchedLastFrame = val_3;
        }
        protected abstract bool CanSingleTouch(); // 0
        private void LateUpdate()
        {
            this.PostUpdate();
        }
        public void TouchDown(UnityEngine.Vector2 position)
        {
        
        }
        public void TouchMove(UnityEngine.Vector2 position)
        {
            bool val_2;
            if((this & 1) == 0)
            {
                    return;
            }
            
            if(UnityEngine.Input.touchCount == 2)
            {
                    this.MultiTouchUpdate();
                val_2 = 1;
            }
            else
            {
                    val_2 = false;
            }
            
            this.multiTouchedLastFrame = val_2;
        }
        public void TouchUp(UnityEngine.Vector2 position)
        {
            this.multiTouchedLastFrame = false;
        }
        public void CancelTouch(bool isTouchDisabled)
        {
            this.pinching = false;
        }
        private void NoTouchUpdate()
        {
            float val_12;
            if(this.returning == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 + val_1;
            val_12 = this.returnProgress + val_1;
            this.returnProgress = val_12;
            if(val_12 >= 1f)
            {
                    val_12 = 1f;
                this.returning = false;
                this.returnProgress = 1f;
            }
            
            float val_2 = ManualEasing.Quintic.Out(t:  val_12);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.startScale, y = V13.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = this.endScale, y = V11.16B, z = V9.16B}, t:  val_2);
            this.scalePivot.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.startPosition, y = this.endScale, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, t:  val_2);
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.scalePivotStartPosition, y = this.endScale, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, t:  val_2);
            this.scalePivot.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.imageStartPosition, y = this.endScale, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, t:  val_2);
            this.image.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.multiTouchedLastFrame = false;
            this.singleTouchedLastFrame = false;
            this.pinching = false;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.returnProgress, b:  1f, precision:  0.001f)) == false)
            {
                    return;
            }
            
            this.returning = false;
        }
        private void SingleTouchUpdate()
        {
            UnityEngine.Touch val_1 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
            UnityEngine.Vector3 val_3 = this.cameraManager.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            if((this.singleTouchedLastFrame != false) && (this.multiTouchedLastFrame != true))
            {
                    UnityEngine.Vector3 val_7 = this.transform.localPosition;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = this.previousSinglePoint, y = val_4.y});
                UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
                this.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            }
            
            this.previousSinglePoint = val_4;
            mem[1152921519099279776] = val_4.y;
        }
        private void MultiTouchUpdate()
        {
            float val_30;
            float val_31;
            this.pinching = true;
            UnityEngine.Touch val_1 = UnityEngine.Input.GetTouch(index:  0);
            UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  1);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
            UnityEngine.Vector3 val_4 = this.cameraManager.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
            UnityEngine.Vector3 val_6 = this.cameraManager.camera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_30 = val_6.x;
            val_31 = val_6.z;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_30, y = val_6.y, z = val_31});
            float val_9 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_30, y = val_6.y, z = val_31});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  2f);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            if((((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  this.previousLength, b:  0f, precision:  0.001f)) != true) && (this.multiTouchedLastFrame != false)) && (this.singleTouchedLastFrame != true))
            {
                    UnityEngine.Vector3 val_14 = this.image.position;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                this.scalePivot.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                this.image.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                UnityEngine.Vector3 val_16 = this.scalePivot.localScale;
                float val_17 = val_9 - this.previousLength;
                val_17 = this.previousLength + val_17;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
                val_30 = val_20.y;
                val_31 = val_20.z;
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_30, z = val_31}, d:  UnityEngine.Mathf.Clamp(value:  (val_16.x * val_17) / this.previousLength, min:  1f, max:  3f));
                this.scalePivot.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
                UnityEngine.Vector3 val_25 = this.transform.localPosition;
                UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y}, b:  new UnityEngine.Vector2() {x = this.previousMidPoint, y = val_12.y});
                UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
                this.transform.localPosition = new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z};
            }
            
            this.previousLength = val_9;
            this.previousMidPoint = val_12;
            mem[1152921519099490164] = val_12.y;
        }
        private void PostUpdate()
        {
            float val_28 = this.GetWidth();
            float val_29 = this.GetHeight();
            val_28 = (val_28 ?? this.cameraManager.cameraWidth) * 0.5f;
            UnityEngine.Vector3 val_6 = this.transform.localPosition;
            float val_7 = UnityEngine.Mathf.Clamp(value:  val_6.x, min:  -val_28, max:  val_28);
            val_29 = (val_29 ?? this.cameraManager.cameraHeight) * 0.5f;
            UnityEngine.Vector3 val_10 = this.transform.localPosition;
            float val_11 = UnityEngine.Mathf.Clamp(value:  val_10.y, min:  -val_29, max:  val_29);
            UnityEngine.Vector3 val_13 = this.transform.localPosition;
            this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_14 = this.image.position;
            float val_17 = UnityEngine.Mathf.Clamp(value:  val_14.x, min:  0f - val_28, max:  val_28 + 0f);
            UnityEngine.Vector3 val_18 = this.image.position;
            float val_21 = UnityEngine.Mathf.Clamp(value:  val_18.y, min:  0f - val_29, max:  val_29 + 0f);
            UnityEngine.Vector3 val_22 = this.image.position;
            this.image.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(this.singleTouchedLastFrame != true)
            {
                    if(this.multiTouchedLastFrame == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_24 = this.transform.localPosition;
            this.startPosition = val_24;
            mem[1152921519099721052] = val_24.y;
            mem[1152921519099721056] = val_24.z;
            UnityEngine.Vector3 val_25 = this.scalePivot.localPosition;
            this.scalePivotStartPosition = val_25;
            mem[1152921519099721064] = val_25.y;
            mem[1152921519099721068] = val_25.z;
            UnityEngine.Vector3 val_26 = this.image.localPosition;
            this.imageStartPosition = val_26;
            mem[1152921519099721076] = val_26.y;
            mem[1152921519099721080] = val_26.z;
            UnityEngine.Vector3 val_27 = this.scalePivot.localScale;
            this.startScale = val_27;
            mem[1152921519099721012] = val_27.y;
            mem[1152921519099721016] = val_27.z;
            this.returnProgress = 0f;
            this.returning = true;
        }
        private float GetWidth()
        {
            UnityEngine.Vector3 val_1 = this.scalePivot.localScale;
            val_1.x = this.cameraManager.cameraWidth * val_1.x;
            return (float)val_1.x;
        }
        private float GetHeight()
        {
            UnityEngine.Vector3 val_1 = this.scalePivot.localScale;
            return (float)this.cameraManager.cameraHeight * val_1.y;
        }
        protected abstract bool CanPinch(); // 0
        protected abstract UnityEngine.Vector3 OwnerPosition(); // 0
        protected AreaPinch()
        {
        
        }
    
    }

}
