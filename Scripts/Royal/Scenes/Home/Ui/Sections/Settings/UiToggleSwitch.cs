using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Settings
{
    public class UiToggleSwitch : UiTouchComponent
    {
        // Fields
        public UnityEngine.Collider2D onColliderBox;
        public UnityEngine.Collider2D offColliderBox;
        public UnityEngine.Collider2D colliderBox;
        private bool touchedOn;
        private bool touchedOff;
        private bool movedSwitch;
        public float duration;
        private float threshold;
        public UnityEngine.Transform toggleSwitch;
        public bool isSilentToggle;
        private UnityEngine.Vector3 <TargetPosition>k__BackingField;
        private UnityEngine.Vector3 <StartPosition>k__BackingField;
        private UnityEngine.Vector3 onPosition;
        private UnityEngine.Vector3 offPosition;
        private UnityEngine.Vector3 touchStartPosition;
        private float progress;
        private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer easer;
        private bool isOn;
        private System.Action<bool> OnToggleChange;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Properties
        public UnityEngine.Vector3 TargetPosition { get; set; }
        public UnityEngine.Vector3 StartPosition { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_TargetPosition()
        {
            return new UnityEngine.Vector3() {x = this.<TargetPosition>k__BackingField};
        }
        private void set_TargetPosition(UnityEngine.Vector3 value)
        {
            this.<TargetPosition>k__BackingField = value;
            mem[1152921519055196008] = value.y;
            mem[1152921519055196012] = value.z;
        }
        public UnityEngine.Vector3 get_StartPosition()
        {
            return new UnityEngine.Vector3() {x = this.<StartPosition>k__BackingField};
        }
        private void set_StartPosition(UnityEngine.Vector3 value)
        {
            this.<StartPosition>k__BackingField = value;
            mem[1152921519055420020] = value.y;
            mem[1152921519055420024] = value.z;
        }
        public void add_OnToggleChange(System.Action<bool> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnToggleChange, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnToggleChange != 1152921519055544376);
            
            return;
            label_2:
        }
        public void remove_OnToggleChange(System.Action<bool> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnToggleChange, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnToggleChange != 1152921519055680952);
            
            return;
            label_2:
        }
        private void Start()
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.progress + val_1;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  this.duration);
            this.progress = val_2;
            val_2 = val_2 / this.duration;
            UnityEngine.Vector3 val_4 = Royal.Infrastructure.Utils.Math.VectorExtensions.Lerp(a:  new UnityEngine.Vector3() {x = this.<StartPosition>k__BackingField, y = 0.75f, z = this.duration}, b:  new UnityEngine.Vector3() {x = this.<TargetPosition>k__BackingField}, t:  ManualEasing.Back.Out(t:  val_2, overshootAmplitude:  0.75f), extrapolate:  true);
            this.toggleSwitch.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public void Toggle(bool enable)
        {
            this.isOn = enable;
            this.progress = 0f;
            UnityEngine.Vector3 val_2 = this.toggleSwitch.localPosition;
            this.<StartPosition>k__BackingField = val_2;
            mem[1152921519056053748] = val_2.y;
            mem[1152921519056053752] = val_2.z;
            this.<TargetPosition>k__BackingField = (this.isOn == false) ? this.offPosition : this.onPosition;
            mem[1152921519056053736] = (this.isOn == false) ? 1152921519056053772 : 1152921519056053760;
            mem[1152921519056053740] = (this.isOn == false) ? 1152921519056053776 : 1152921519056053764;
            if(this.OnToggleChange == null)
            {
                    return;
            }
            
            this.OnToggleChange.Invoke(obj:  enable);
        }
        public override void TouchDown(UnityEngine.Vector2 position)
        {
            bool val_8;
            this.movedSwitch = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if((this.IsInsideOn(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    val_8 = 1;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
                if((this.IsInsideOff(point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == false)
            {
                    return;
            }
            
                val_8 = true;
            }
            
            this.touchedOn = val_8;
            this.touchedOff = true;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            this.touchStartPosition = val_5;
            mem[1152921519056178072] = val_5.y;
            mem[1152921519056178076] = val_5.z;
        }
        public override void TouchMove(UnityEngine.Vector2 position)
        {
            float val_12;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if((this.IsInside(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return;
            }
            
            if(this.touchedOff == false)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            val_12 = this.threshold;
            val_3.x = val_3.x - this.touchStartPosition;
            if(val_3.x >= 0)
            {
                goto label_7;
            }
            
            this.Toggle(enable:  false);
            this.touchedOn = true;
            this.touchedOff = false;
            this.movedSwitch = true;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if((this.IsInsideOn(point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) == true)
            {
                goto label_10;
            }
            
            return;
            label_7:
            if(this.touchedOn == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            val_12 = this.threshold;
            val_6.x = val_6.x - this.touchStartPosition;
            if(val_6.x <= val_12)
            {
                    return;
            }
            
            this.Toggle(enable:  true);
            this.touchedOn = true;
            this.touchedOff = true;
            this.movedSwitch = true;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if((this.IsInsideOff(point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) == false)
            {
                    return;
            }
            
            label_10:
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            this.touchStartPosition = val_9;
            mem[1152921519056294168] = val_9.y;
            mem[1152921519056294172] = val_9.z;
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            if(((this.IsInside(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false) && (this.movedSwitch != true))
            {
                    this.Toggle(enable:  (this.isOn == false) ? 1 : 0);
                if(this.isSilentToggle != true)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  40, offset:  0.04f);
            }
            
            }
            
            this.touchedOn = false;
            this.touchedOff = false;
            this.movedSwitch = false;
        }
        public override void CancelTouch(bool isTouchDisabled)
        {
            this.touchedOn = false;
            this.touchedOff = false;
            this.movedSwitch = false;
        }
        private bool IsInsideOn(UnityEngine.Vector3 point)
        {
            UnityEngine.Bounds val_1 = this.onColliderBox.bounds;
            return false;
        }
        private bool IsInsideOff(UnityEngine.Vector3 point)
        {
            UnityEngine.Bounds val_1 = this.offColliderBox.bounds;
            return false;
        }
        private bool IsInside(UnityEngine.Vector3 point)
        {
            UnityEngine.Bounds val_1 = this.colliderBox.bounds;
            return false;
        }
        private bool PassRightThreshold(UnityEngine.Vector3 position)
        {
            position.x = position.x - this.touchStartPosition;
            return (bool)(position.x > this.threshold) ? 1 : 0;
        }
        private bool PassLeftThreshold(UnityEngine.Vector3 position)
        {
            position.x = position.x - this.touchStartPosition;
            return (bool)(position.x < 0) ? 1 : 0;
        }
        public UiToggleSwitch()
        {
            this.duration = 0.2f;
            this.threshold = 0.6f;
            this.onPosition = 0;
            mem[1152921519057263684] = 0;
            this.offPosition = 0;
            mem[1152921519057263696] = 0;
        }
    
    }

}
