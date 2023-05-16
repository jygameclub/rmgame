using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionSwipe : MonoBehaviour, IScrollable, IDraggable, ITouchable
    {
        // Fields
        private const float Threshold = 0.05;
        public float FastSwipeDuration;
        public float FastSwipeTimeDelta;
        public float LateFastSwipeLength;
        public float EarlyFastSwipeLength;
        public Royal.Infrastructure.UiComponents.Touch.ZIndex zIndex;
        public Royal.Scenes.Home.Ui.Sections.SectionManager sectionManager;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Infrastructure.UiComponents.Dialog.DialogManager dialogManager;
        private UnityEngine.Vector3 previousTouchPos;
        private UnityEngine.Vector3 currentTouchPos;
        private UnityEngine.Vector3 startSwipePos;
        private UnityEngine.Vector3 touchDownPos;
        private float timer;
        private float nextRecordTime;
        private UnityEngine.Vector3 recordedPos1;
        private UnityEngine.Vector3 recordedPos2;
        private UnityEngine.Vector3 recordedPos3;
        private bool isDragging;
        private bool passedVerticalThreshold;
        
        // Properties
        public bool IsDragging { get; }
        public Royal.Infrastructure.UiComponents.Scroll.Direction ScrollDirection { get; }
        public Royal.Infrastructure.UiComponents.Touch.ZIndex ZIndex { get; set; }
        
        // Methods
        public bool get_IsDragging()
        {
            return (bool)this.isDragging;
        }
        public Royal.Infrastructure.UiComponents.Scroll.Direction get_ScrollDirection()
        {
            return 0;
        }
        public Royal.Infrastructure.UiComponents.Touch.ZIndex get_ZIndex()
        {
            return (Royal.Infrastructure.UiComponents.Touch.ZIndex)this.zIndex;
        }
        public void set_ZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex value)
        {
            this.zIndex = value;
        }
        private void Start()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.dialogManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            this.isDragging = false;
        }
        public void TouchDown(UnityEngine.Vector2 worldPosition)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
            UnityEngine.Vector2 val_2 = this.cameraManager.WorldToScreenPoint(worldPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.touchDownPos = val_3;
            mem[1152921518954442176] = val_3.y;
            mem[1152921518954442180] = val_3.z;
            this.currentTouchPos = val_3;
            mem[1152921518954442152] = val_3.y;
            mem[1152921518954442156] = val_3.z;
            this.isDragging = false;
            this.passedVerticalThreshold = false;
        }
        public void TouchMove(UnityEngine.Vector2 worldPosition)
        {
            float val_8 = worldPosition.y;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldPosition.x, y = val_8});
            UnityEngine.Vector2 val_2 = this.cameraManager.WorldToScreenPoint(worldPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if(this.dialogManager.hasActiveDialog == true)
            {
                    return;
            }
            
            val_8 = val_2.x;
            if(this.isDragging != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8, y = val_2.y});
                this.currentTouchPos = val_3;
                mem[1152921518954566440] = val_3.y;
                mem[1152921518954566444] = val_3.z;
                return;
            }
            
            float val_5 = val_2.y - S10;
            val_5 = val_5 / (float)UnityEngine.Screen.height;
            if(System.Math.Abs(val_5) > 0.025f)
            {
                    this.passedVerticalThreshold = true;
                return;
            }
            
            if(this.passedVerticalThreshold == true)
            {
                    return;
            }
            
            float val_7 = val_8 - this.touchDownPos;
            val_7 = val_7 / (float)UnityEngine.Screen.width;
            if(System.Math.Abs(val_7) <= 0.05f)
            {
                    return;
            }
            
            this.StartSwipe(screenPosition:  new UnityEngine.Vector2() {x = val_8, y = val_2.y});
        }
        public void TouchUp(UnityEngine.Vector2 worldPosition)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
            UnityEngine.Vector2 val_2 = this.cameraManager.WorldToScreenPoint(worldPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.currentTouchPos = val_3;
            mem[1152921518954698920] = val_3.y;
            mem[1152921518954698924] = val_3.z;
            if(this.isDragging == false)
            {
                    return;
            }
            
            if(this.FastSwipedLeft() != false)
            {
                    this.sectionManager.FocusToLeftSection();
            }
            else
            {
                    if(this.FastSwipedRight() != false)
            {
                    this.sectionManager.FocusToRightSection();
            }
            else
            {
                    this.sectionManager.FocusToNearestSection();
            }
            
            }
            
            this.isDragging = false;
        }
        public void CancelTouch(bool isTouchDisabled)
        {
            this.isDragging = false;
            this.passedVerticalThreshold = false;
        }
        public void StartSwipe(UnityEngine.Vector2 screenPosition)
        {
            this.isDragging = true;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y});
            this.startSwipePos = val_1;
            mem[1152921518954935220] = val_1.y;
            this.previousTouchPos = val_1;
            mem[1152921518954935196] = val_1.y;
            mem[1152921518954935224] = val_1.z;
            mem[1152921518954935200] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y});
            this.currentTouchPos = val_2;
            mem[1152921518954935208] = val_2.y;
            float val_3 = this.FastSwipeTimeDelta;
            mem[1152921518954935212] = val_2.z;
            this.timer = 0f;
            val_3 = val_3 + 0f;
            this.nextRecordTime = val_3;
        }
        public void ManualUpdate()
        {
            var val_7;
            float val_8;
            float val_9;
            float val_13;
            val_7 = this;
            val_8 = this.nextRecordTime;
            val_9 = this.timer + UnityEngine.Time.deltaTime;
            this.timer = val_9;
            if(val_9 > val_8)
            {
                    val_8 = this.FastSwipeTimeDelta;
                val_9 = val_9 + val_8;
                mem[1152921518955067756] = ???;
                mem[1152921518955067760] = ???;
                this.recordedPos2 = this.recordedPos1;
                this.recordedPos1 = this.currentTouchPos;
                this.nextRecordTime = val_9;
                mem[1152921518955067736] = ???;
            }
            
            UnityEngine.Vector3 val_2 = this.cameraManager.GetPosition();
            UnityEngine.Vector3 val_7 = this.currentTouchPos;
            val_7 = this.previousTouchPos - val_7;
            float val_3 = this.cameraManager.ScreenToWorldUnit(screenUnits:  val_7);
            if(val_3 >= 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_4 = this.sectionManager.LeftMostSectionPosition();
            if(val_2.x < 0)
            {
                goto label_5;
            }
            
            label_3:
            val_13 = 1f;
            if(val_3 <= 0f)
            {
                goto label_8;
            }
            
            UnityEngine.Vector3 val_5 = this.sectionManager.RightMostSectionPosition();
            if(val_2.x <= val_5.x)
            {
                goto label_8;
            }
            
            label_5:
            val_13 = 0.35f;
            label_8:
            float val_6 = val_3 * val_13;
            val_6 = val_2.x + val_6;
            this.cameraManager.SetPosition(position:  new UnityEngine.Vector3() {x = val_6, y = val_2.y, z = val_2.z});
            this.previousTouchPos = this.currentTouchPos;
            mem[1152921518955067680] = ???;
        }
        private bool FastSwipedLeft()
        {
            UnityEngine.Vector3 val_5;
            var val_6;
            float val_7;
            if(this.timer > this.FastSwipeDuration)
            {
                    val_5 = this.recordedPos3;
                val_6 = 0;
                int val_1 = UnityEngine.Screen.width;
                val_7 = this.LateFastSwipeLength;
            }
            else
            {
                    val_5 = this.touchDownPos;
                val_6 = 0;
                val_7 = this.EarlyFastSwipeLength;
            }
            
            float val_3 = this.currentTouchPos - val_5;
            val_3 = val_3 / (float)UnityEngine.Screen.width;
            return (bool)(val_3 > val_7) ? 1 : 0;
        }
        private bool FastSwipedRight()
        {
            float val_6;
            float val_7;
            if(this.timer > this.FastSwipeDuration)
            {
                    val_6 = (this.currentTouchPos - this.recordedPos3) / (float)UnityEngine.Screen.width;
                val_7 = this.LateFastSwipeLength;
                return (bool)(val_6 < 0) ? 1 : 0;
            }
            
            val_6 = (this.currentTouchPos - this.touchDownPos) / (float)UnityEngine.Screen.width;
            val_7 = this.EarlyFastSwipeLength;
            return (bool)(val_6 < 0) ? 1 : 0;
        }
        public float NormalizedSwipePosition(bool checkTouch = False)
        {
            if(checkTouch != false)
            {
                    if(this.isDragging == false)
            {
                    return 0f;
            }
            
            }
            
            float val_2 = this.currentTouchPos - this.startSwipePos;
            val_2 = val_2 / (float)UnityEngine.Screen.width;
            return (float)val_2;
        }
        public float NormalizedLateSwipePosition()
        {
            float val_2 = this.currentTouchPos - this.recordedPos3;
            val_2 = val_2 / (float)UnityEngine.Screen.width;
            return (float)val_2;
        }
        public float NormalizedEarlySwipePosition()
        {
            float val_2 = this.currentTouchPos - this.touchDownPos;
            val_2 = val_2 / (float)UnityEngine.Screen.width;
            return (float)val_2;
        }
        public SectionSwipe()
        {
            this.FastSwipeDuration = ;
            this.FastSwipeTimeDelta = ;
            this.LateFastSwipeLength = 0.1f;
            this.EarlyFastSwipeLength = 0.1f;
        }
    
    }

}
