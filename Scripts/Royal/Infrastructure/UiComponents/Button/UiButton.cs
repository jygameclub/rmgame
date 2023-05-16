using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Button
{
    public class UiButton : UiTouchComponent
    {
        // Fields
        public bool scaleDown;
        public bool isSilentButton;
        public bool immediateCancelOnScroll;
        public float overrideScaleFactor;
        public UnityEngine.Collider2D colliderBox;
        public UnityEngine.Events.UnityEvent onClick;
        private UnityEngine.Vector3 initialScale;
        private bool scaledDown;
        protected bool didCancel;
        
        // Methods
        public override void TouchDown(UnityEngine.Vector2 position)
        {
            this.ScaleDown();
            this.didCancel = false;
        }
        public override void TouchMove(UnityEngine.Vector2 position)
        {
            float val_9;
            var val_10;
            val_9 = position.y;
            val_10 = this;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = val_9});
            if((this.IsInside(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == true)
            {
                    return;
            }
            
            if(this.scaleDown == false)
            {
                    return;
            }
            
            if(this.scaledDown == false)
            {
                    return;
            }
            
            this.scaledDown = false;
            val_10 = ???;
            val_9 = ???;
            goto typeof(Royal.Infrastructure.UiComponents.Button.UiButton).__il2cppRuntimeField_250;
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if((this.scaleDown != false) && (this.scaledDown != false))
            {
                    this.scaledDown = false;
            }
            
            this.InvokeClick(position:  new UnityEngine.Vector2() {x = position.x, y = position.y});
        }
        protected void InvokeClick(UnityEngine.Vector2 position)
        {
            if(this.didCancel != true)
            {
                    UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
                if((this.IsInside(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    this.onClick.Invoke();
                if(this.isSilentButton != true)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  40, offset:  0.04f);
            }
            
            }
            
            }
            
            this.didCancel = false;
        }
        public override void CancelTouch(bool isTouchDisabled)
        {
            if(this.immediateCancelOnScroll != true)
            {
                    if(isTouchDisabled == false)
            {
                goto label_3;
            }
            
            }
            
            if((this.scaleDown != false) && (this.scaledDown != false))
            {
                    this.scaledDown = false;
            }
            
            label_3:
            this.didCancel = true;
        }
        private void ScaleDown()
        {
            if(this.scaleDown == false)
            {
                    return;
            }
            
            if(this.scaledDown != false)
            {
                    return;
            }
            
            this.scaledDown = true;
            UnityEngine.Vector3 val_3 = this.gameObject.transform.localScale;
            this.initialScale = val_3;
            mem[1152921527530073932] = val_3.y;
            mem[1152921527530073936] = val_3.z;
            goto typeof(Royal.Infrastructure.UiComponents.Button.UiButton).__il2cppRuntimeField_240;
        }
        protected virtual void PlayScaleDownAnimation()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  (this.overrideScaleFactor > 0f) ? this.overrideScaleFactor : 0.9409f);
            val_1.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        protected void ScaleUp()
        {
            if(this.scaleDown == false)
            {
                    return;
            }
            
            if(this.scaledDown == false)
            {
                    return;
            }
            
            this.scaledDown = false;
            goto typeof(Royal.Infrastructure.UiComponents.Button.UiButton).__il2cppRuntimeField_250;
        }
        protected virtual void PlayScaleUpAnimation()
        {
            if(this == 0)
            {
                    return;
            }
            
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = this.initialScale};
        }
        protected bool IsInside(UnityEngine.Vector3 point)
        {
            var val_6;
            if(this.colliderBox == 0)
            {
                    val_6 = 0;
                return false;
            }
            
            UnityEngine.Bounds val_2 = this.colliderBox.bounds;
            return false;
        }
        protected override void Reset()
        {
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == true)
            {
                    return;
            }
            
            this.Reset();
            this.colliderBox = this.GetComponent<UnityEngine.BoxCollider2D>();
        }
        public UiButton()
        {
            this.scaleDown = true;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
