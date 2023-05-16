using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch
{
    public class UiTouchListener : IContextBehaviour, IContextUnit
    {
        // Fields
        public const int TouchDelayFrameCount = 3;
        private const int MaxColliderCount = 10;
        private const string BlockerTag = "Blocker";
        private const string TouchableTag = "Touchable";
        private const string ScrollableTag = "Scrollable";
        private const string PinchableTag = "Pinchable";
        private readonly UnityEngine.LayerMask layerMask;
        private readonly UnityEngine.Collider2D[] colliders;
        private readonly Royal.Infrastructure.UiComponents.Touch.ITouchable[] touchables;
        private System.Action OnMouseUp;
        private System.Action OnDelayMouseUp;
        private System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable> OnMouseDown;
        public Royal.Infrastructure.UiComponents.Touch.UiTouchDisabler disabler;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        public readonly Royal.Infrastructure.UiComponents.Touch.Inputs.InputHelper inputHelper;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener.TouchWrapper touch;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener.ScrollWrapper vertical;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener.ScrollWrapper horizontal;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener.PinchWrapper pinch;
        private bool delayTouchUp;
        private int touchDownFrame;
        private UnityEngine.Vector3 touchUpPosition;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public void add_OnMouseUp(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnMouseUp, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMouseUp != 1152921527501500088);
            
            return;
            label_2:
        }
        public void remove_OnMouseUp(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnMouseUp, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMouseUp != 1152921527501636664);
            
            return;
            label_2:
        }
        public void add_OnDelayMouseUp(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnDelayMouseUp, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDelayMouseUp != 1152921527501773248);
            
            return;
            label_2:
        }
        public void remove_OnDelayMouseUp(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnDelayMouseUp, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnDelayMouseUp != 1152921527501909824);
            
            return;
            label_2:
        }
        public void add_OnMouseDown(System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnMouseDown, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMouseDown != 1152921527502046408);
            
            return;
            label_2:
        }
        public void remove_OnMouseDown(System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnMouseDown, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnMouseDown != 1152921527502182984);
            
            return;
            label_2:
        }
        public int get_Id()
        {
            return 15;
        }
        public UiTouchListener()
        {
            this.colliders = new UnityEngine.Collider2D[10];
            this.touchables = new Royal.Infrastructure.UiComponents.Touch.ITouchable[10];
            string[] val_3 = new string[1];
            val_3[0] = "UI";
            UnityEngine.LayerMask val_5 = UnityEngine.LayerMask.op_Implicit(intVal:  UnityEngine.LayerMask.GetMask(layerNames:  val_3));
            this.layerMask = val_5;
            this.delayTouchUp = false;
            this.inputHelper = new Royal.Infrastructure.UiComponents.Touch.Inputs.AndroidInputHelper();
        }
        public void ManualUpdate()
        {
            Royal.Infrastructure.UiComponents.Touch.Inputs.InputHelper val_1;
            if(this.disabler >= 1)
            {
                    if(this.touch == 0)
            {
                    return;
            }
            
            }
            else
            {
                    val_1 = this.inputHelper;
                if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(this.delayTouchUp != false)
            {
                    this.DelayTouchUpdate();
                return;
            }
            
                val_1 = this.inputHelper;
                if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_1 & 1) == 0)
            {
                    return;
            }
            
                val_1 = this.inputHelper;
                if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_1 & 1) != 0)
            {
                    if(this.inputHelper == null)
            {
                    throw new NullReferenceException();
            }
            
                this.TryTouchDown(screenPosition:  new UnityEngine.Vector2());
                return;
            }
            
                if(this.inputHelper == null)
            {
                    throw new NullReferenceException();
            }
            
                val_1 = this.inputHelper;
                if((val_1 & 1) != 0)
            {
                    if(this.inputHelper == null)
            {
                    throw new NullReferenceException();
            }
            
                this.TryTouchMove(screenPosition:  new UnityEngine.Vector2());
                return;
            }
            
                if(this.inputHelper == null)
            {
                    throw new NullReferenceException();
            }
            
                if((this.inputHelper & 1) == 0)
            {
                    return;
            }
            
                val_1 = this.inputHelper;
                if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
                this.TryTouchUp(screenPosition:  new UnityEngine.Vector2());
                return;
            }
            
            if(this.touch == 0)
            {
                    return;
            }
            
            TouchWrapper val_5 = this.touch;
            if((mem[this.touch + 294]) == 0)
            {
                goto label_27;
            }
            
            var val_2 = mem[this.touch + 176];
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_26:
            if(((mem[this.touch + 176] + 8) + -8) == null)
            {
                goto label_25;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (mem[this.touch + 294]))
            {
                goto label_26;
            }
            
            goto label_27;
            label_25:
            var val_4 = val_2;
            val_4 = val_4 + 5;
            val_5 = val_5 + val_4;
            label_27:
            this.touch.CancelTouch(isTouchDisabled:  1 & 1);
        }
        private UnityEngine.Vector2 GetTouchPosition()
        {
            if(this.inputHelper != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private bool GetTouch()
        {
            if(this.inputHelper != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private bool GetTouchDown()
        {
            if(this.inputHelper != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private bool GetTouchMove()
        {
            if(this.inputHelper != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private bool GetTouchUp()
        {
            if(this.inputHelper != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void DelayTouchUpdate()
        {
            int val_3 = this.touchDownFrame;
            val_3 = val_3 + 3;
            if(UnityEngine.Time.frameCount < val_3)
            {
                    return;
            }
            
            this.delayTouchUp = false;
            if(!=0)
            {
                    UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.touchUpPosition, y = V8.16B, z = V9.16B});
                bool val_7 = static_value_02D63000;
                var val_4 = static_value_02D63000 + 176;
                var val_5 = 0;
                val_4 = val_4 + 8;
                val_5 = val_5 + 1;
                val_4 = val_4 + 16;
                TouchUp(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            }
            
            if(this.OnDelayMouseUp == null)
            {
                    return;
            }
            
            this.OnDelayMouseUp.Invoke();
        }
        public void Bind()
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Game.Context.GameContext>(id:  11).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.UiComponents.Touch.UiTouchListener::Clear()));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.HomeContext>(id:  10).add_OnActivate(value:  new System.Action(object:  this, method:  System.Void Royal.Infrastructure.UiComponents.Touch.UiTouchListener::Clear()));
            goto typeof(Royal.Infrastructure.UiComponents.Touch.Inputs.InputHelper).__il2cppRuntimeField_170;
        }
        public bool Touching()
        {
            if(this.touch != 0)
            {
                    return true;
            }
            
            if(this.vertical == 0)
            {
                    return (bool)(this.horizontal != 0) ? 1 : 0;
            }
            
            return true;
        }
        private void Reset()
        {
            var val_3;
            var val_4;
            this.touch = 0;
            mem[1152921527503721016] = 0;
            return;
            label_7:
            if(((mem[this.pinch.selected] + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[this.pinch.selected] + 294))
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_3 = ;
            val_3 = val_3 + 5;
             =  + val_3;
            val_3 =  + 304;
            label_8:
            this.pinch.selected.CancelTouch(isTouchDisabled:  false);
             = 0;
             = 0;
            return;
            label_13:
            if(((mem[this.pinch.selected + 8] + 176 + 8) + -8) == null)
            {
                goto label_12;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[this.pinch.selected + 8] + 294))
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            var val_8 = ;
            val_8 = val_8 + 5;
             =  + val_8;
            val_4 =  + 304;
            label_14:
            mem[this.pinch.selected + 8].CancelTouch(isTouchDisabled:  false);
             = 0;
             = 0;
        }
        private void Clear()
        {
            this.Reset();
            System.Array.Clear(array:  this.touchables, index:  0, length:  this.touchables.Length);
            System.Array.Clear(array:  this.colliders, index:  0, length:  this.colliders.Length);
        }
        private void TryTouchDown(UnityEngine.Vector2 screenPosition)
        {
            this.Reset();
            UnityEngine.Vector2 val_1 = this.GetWorldPosition(screenPosition:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y});
            this.CheckCollision(worldPosition:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            if(this.pinch != 0)
            {
                    bool val_6 = static_value_02D63000;
                var val_3 = static_value_02D63000 + 176;
                var val_4 = 0;
                val_3 = val_3 + 8;
                val_4 = val_4 + 1;
                val_3 = val_3 + 16;
                TouchDown(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.vertical != 0)
            {
                    bool val_10 = static_value_02D63000;
                var val_7 = static_value_02D63000 + 176;
                var val_8 = 0;
                val_7 = val_7 + 8;
                val_8 = val_8 + 1;
                val_7 = val_7 + 16;
                TouchDown(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.horizontal != 0)
            {
                    bool val_14 = static_value_02D63000;
                var val_11 = static_value_02D63000 + 176;
                var val_12 = 0;
                val_11 = val_11 + 8;
                val_12 = val_12 + 1;
                val_11 = val_11 + 16;
                TouchDown(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.touch != 0)
            {
                    bool val_18 = static_value_02D63000;
                var val_15 = static_value_02D63000 + 176;
                var val_16 = 0;
                val_15 = val_15 + 8;
                val_16 = val_16 + 1;
                val_15 = val_15 + 16;
                TouchDown(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
                this.touchDownFrame = UnityEngine.Time.frameCount;
            }
            
            if(this.OnMouseDown == null)
            {
                    return;
            }
            
            this.OnMouseDown.Invoke(obj:  public System.Void Royal.Infrastructure.UiComponents.Touch.ITouchable::TouchDown(UnityEngine.Vector2 position));
        }
        private void TryTouchMove(UnityEngine.Vector2 screenPosition)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_9 = this;
            UnityEngine.Vector2 val_1 = this.GetWorldPosition(screenPosition:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y});
            if(this.pinch == 0)
            {
                goto label_16;
            }
            
            if(this.pinch < 1)
            {
                goto label_2;
            }
            
            goto label_16;
            label_2:
            var val_9 = X21;
            if((X21 + 294) == 0)
            {
                goto label_8;
            }
            
            var val_6 = X21 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_7:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (X21 + 294))
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_8 = val_6;
            val_8 = val_8 + 3;
            val_9 = val_9 + val_8;
            val_10 = val_9 + 304;
            label_8:
            X21.TouchMove(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            var val_12 = X21;
            if((X21 + 294) == 0)
            {
                goto label_13;
            }
            
            var val_10 = X21 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_12:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (X21 + 294))
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            val_12 = val_12 + (((X21 + 176 + 8)) << 4);
            val_11 = val_12 + 304;
            label_13:
            bool val_2 = X21.IsDragging;
            label_16:
            if(this.vertical == 0)
            {
                goto label_32;
            }
            
            if(this.vertical < 1)
            {
                goto label_18;
            }
            
            goto label_32;
            label_18:
            var val_16 = X22;
            if((X22 + 294) == 0)
            {
                goto label_24;
            }
            
            var val_13 = X22 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_23:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_22;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (X22 + 294))
            {
                goto label_23;
            }
            
            goto label_24;
            label_22:
            var val_15 = val_13;
            val_15 = val_15 + 3;
            val_16 = val_16 + val_15;
            val_12 = val_16 + 304;
            label_24:
            X22.TouchMove(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            var val_19 = X22;
            if((X22 + 294) == 0)
            {
                goto label_29;
            }
            
            var val_17 = X22 + 176;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_28:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_27;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (X22 + 294))
            {
                goto label_28;
            }
            
            goto label_29;
            label_27:
            val_19 = val_19 + (((X22 + 176 + 8)) << 4);
            val_13 = val_19 + 304;
            label_29:
            bool val_3 = X22.IsDragging;
            label_32:
            if(this.horizontal == 0)
            {
                goto label_48;
            }
            
            if(this.horizontal < 1)
            {
                goto label_34;
            }
            
            goto label_48;
            label_34:
            var val_23 = X22;
            if((X22 + 294) == 0)
            {
                goto label_40;
            }
            
            var val_20 = X22 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_39:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_38;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (X22 + 294))
            {
                goto label_39;
            }
            
            goto label_40;
            label_38:
            var val_22 = val_20;
            val_22 = val_22 + 3;
            val_23 = val_23 + val_22;
            val_14 = val_23 + 304;
            label_40:
            X22.TouchMove(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            var val_26 = X22;
            if((X22 + 294) == 0)
            {
                goto label_45;
            }
            
            var val_24 = X22 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_44:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_43;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < (X22 + 294))
            {
                goto label_44;
            }
            
            goto label_45;
            label_43:
            val_26 = val_26 + (((X22 + 176 + 8)) << 4);
            val_15 = val_26 + 304;
            label_45:
            bool val_4 = X22.IsDragging;
            label_48:
            if(this.touch == 0)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            var val_27 = 0;
            if(mem[1152921505130631168] != null)
            {
                    val_27 = val_27 + 1;
            }
            else
            {
                    var val_28 = mem[1152921505130631176];
                val_28 = val_28 + 3;
                Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_5 = 1152921505130594304 + val_28;
            }
            
            this.TouchMove(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        }
        private void TryTouchUp(UnityEngine.Vector2 screenPosition)
        {
            UnityEngine.Vector2 val_1 = this.GetWorldPosition(screenPosition:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y});
            if(this.pinch != 0)
            {
                    bool val_5 = static_value_02D63000;
                var val_2 = static_value_02D63000 + 176;
                var val_3 = 0;
                val_2 = val_2 + 8;
                val_3 = val_3 + 1;
                val_2 = val_2 + 16;
                TouchUp(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.vertical != 0)
            {
                    bool val_9 = static_value_02D63000;
                var val_6 = static_value_02D63000 + 176;
                var val_7 = 0;
                val_6 = val_6 + 8;
                val_7 = val_7 + 1;
                val_6 = val_6 + 16;
                TouchUp(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.horizontal != 0)
            {
                    bool val_13 = static_value_02D63000;
                var val_10 = static_value_02D63000 + 176;
                var val_11 = 0;
                val_10 = val_10 + 8;
                val_11 = val_11 + 1;
                val_10 = val_10 + 16;
                TouchUp(position:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.touch != 0)
            {
                    this.TryDelayTouch(worldPosition:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            }
            
            if(this.OnMouseUp == null)
            {
                    return;
            }
            
            this.OnMouseUp.Invoke();
        }
        private void TryDelayTouch(UnityEngine.Vector2 worldPosition)
        {
            int val_3 = this.touchDownFrame;
            val_3 = val_3 + 3;
            if(UnityEngine.Time.frameCount < val_3)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
                this.touchUpPosition = val_2;
                mem[1152921527504450540] = val_2.y;
                mem[1152921527504450544] = val_2.z;
                this.delayTouchUp = true;
                return;
            }
            
            this.delayTouchUp = false;
            if(!=0)
            {
                    bool val_7 = static_value_02D63000;
                var val_4 = static_value_02D63000 + 176;
                var val_5 = 0;
                val_4 = val_4 + 8;
                val_5 = val_5 + 1;
                val_4 = val_4 + 16;
                TouchUp(position:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y});
            }
            
            if(this.OnDelayMouseUp == null)
            {
                    return;
            }
            
            this.OnDelayMouseUp.Invoke();
        }
        private UnityEngine.Vector2 GetWorldPosition(UnityEngine.Vector2 screenPosition)
        {
            UnityEngine.Vector3 val_1 = this.cameraManager.ScreenToWorldPoint(screenCoordinates:  new UnityEngine.Vector2() {x = screenPosition.x, y = screenPosition.y});
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        private void CheckCollision(UnityEngine.Vector2 worldPosition)
        {
            int val_15;
            var val_16;
            System.Array.Clear(array:  this.colliders, index:  0, length:  this.colliders.Length);
            val_15 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.layerMask});
            int val_2 = UnityEngine.Physics2D.OverlapPointNonAlloc(point:  new UnityEngine.Vector2() {x = worldPosition.x, y = worldPosition.y}, results:  this.colliders, layerMask:  val_15);
            if(val_2 == 0)
            {
                    return;
            }
            
            if(val_2 == 10)
            {
                    object[] val_3 = new object[1];
                val_15 = val_3;
                val_15[0] = 10;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "All collider array ({0}) is used, might be more colliders.", values:  val_3);
            }
            
            int val_4 = this.SortTouchables(colliderCount:  val_2);
            if(val_4 < 1)
            {
                    return;
            }
            
            val_16 = 0;
            label_45:
            UnityEngine.GameObject val_5 = this.touchables[val_16].gameObject;
            val_15 = val_5;
            if((val_5.CompareTag(tag:  "Blocker")) == true)
            {
                    return;
            }
            
            if((this.pinch != 0) || ((val_15.CompareTag(tag:  "Pinchable")) == false))
            {
                goto label_20;
            }
            
            this.pinch = 1;
            mem[1152921527504829592] = val_15.GetComponent<Royal.Scenes.Home.Ui.Sections.Home.Pinch.IPinchable>();
            goto label_44;
            label_20:
            if(this.vertical != 0)
            {
                    if(this.horizontal != 0)
            {
                goto label_41;
            }
            
            }
            
            if((val_15.CompareTag(tag:  "Scrollable")) == false)
            {
                goto label_41;
            }
            
            Royal.Infrastructure.UiComponents.Scroll.IScrollable val_10 = val_15.GetComponent<Royal.Infrastructure.UiComponents.Scroll.IScrollable>();
            if((this.horizontal > 0) || (this.horizontal != 0))
            {
                goto label_26;
            }
            
            var val_18 = 0;
            if(mem[1152921505131216896] != null)
            {
                    val_18 = val_18 + 1;
            }
            else
            {
                    Royal.Infrastructure.UiComponents.Scroll.IScrollable val_11 = 1152921505131180032 + ((mem[1152921505131216904]) << 4);
            }
            
            if(val_10.ScrollDirection == 0)
            {
                goto label_32;
            }
            
            label_26:
            if(((public Royal.Infrastructure.UiComponents.Scroll.Direction Royal.Infrastructure.UiComponents.Scroll.IScrollable::get_ScrollDirection()) > 0) || (this.vertical != 0))
            {
                goto label_41;
            }
            
            var val_19 = 0;
            if(mem[1152921505131216896] == null)
            {
                goto label_37;
            }
            
            val_19 = val_19 + 1;
            goto label_39;
            label_32:
            this.horizontal = 1;
            mem[1152921527504829576] = val_10;
            goto label_44;
            label_37:
            Royal.Infrastructure.UiComponents.Scroll.IScrollable val_13 = 1152921505131180032 + ((mem[1152921505131216904]) << 4);
            label_39:
            if(val_10.ScrollDirection != 1)
            {
                goto label_41;
            }
            
            this.vertical = 1;
            mem[1152921527504829560] = val_10;
            goto label_44;
            label_41:
            if(this.touch == 0)
            {
                    if((val_15.CompareTag(tag:  "Touchable")) != false)
            {
                    this.touch = 1;
                mem[1152921527504829544] = val_15.GetComponent<Royal.Infrastructure.UiComponents.Touch.ITouchable>();
            }
            
            }
            
            label_44:
            val_16 = val_16 + 1;
            if(val_16 < val_4)
            {
                goto label_45;
            }
        
        }
        private int SortTouchables(int colliderCount)
        {
            int val_1 = this.FillTouchableArray(colliders:  this.colliders, colliderCount:  colliderCount, touchables:  this.touchables);
            if(val_1 < 2)
            {
                    return val_1;
            }
            
            Royal.Infrastructure.UiComponents.Touch.UiTouchSorting.InsertionSort(array:  this.touchables, arrayLength:  val_1);
            return val_1;
        }
        private int FillTouchableArray(UnityEngine.Collider2D[] colliders, int colliderCount, Royal.Infrastructure.UiComponents.Touch.ITouchable[] touchables)
        {
            var val_3;
            System.Array.Clear(array:  touchables, index:  0, length:  touchables.Length);
            if(colliderCount >= 1)
            {
                    var val_3 = 0;
                val_3 = 0;
                do
            {
                if(1152921506547721664 != 0)
            {
                    Royal.Infrastructure.UiComponents.Touch.ITouchable val_2 = 1152921506547721664.GetComponent<Royal.Infrastructure.UiComponents.Touch.ITouchable>();
                if(val_2 != null)
            {
                    val_3 = val_3 + 1;
                touchables[val_3] = val_2;
            }
            
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < (long)colliderCount);
            
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
    
    }

}
