using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch.Inputs
{
    public abstract class MobileInputHelper : InputHelper
    {
        // Fields
        private UnityEngine.Touch lastTouch;
        
        // Methods
        public override UnityEngine.Vector2 GetTouchPosition()
        {
        
        }
        public override bool GetTouch()
        {
            var val_8;
            int val_1 = UnityEngine.Input.touchCount;
            if(val_1 == 0)
            {
                goto label_0;
            }
            
            if(val_1 >= 1)
            {
                    var val_8 = 0;
                do
            {
                UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  0);
                if(fingerId == this.lastTouch.fingerId)
            {
                goto label_6;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_1);
            
            }
            
            UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
            int val_6 = rolloverSize;
            if(val_6 == 0)
            {
                goto label_4;
            }
            
            label_0:
            Basic = 0;
            val_8 = 0;
            return (bool)val_8;
            label_4:
            UnityEngine.Touch val_7 = UnityEngine.Input.GetTouch(index:  val_6);
            label_6:
            val_8 = 1;
            return (bool)val_8;
        }
        public override bool GetTouchDown()
        {
            return (bool)(this.lastTouch.rolloverSize == 0) ? 1 : 0;
        }
        public override bool GetTouchMove()
        {
            if(this.lastTouch.rolloverSize == 1)
            {
                    return (bool)(this.lastTouch.rolloverSize == 2) ? 1 : 0;
            }
            
            return (bool)(this.lastTouch.rolloverSize == 2) ? 1 : 0;
        }
        public override bool GetTouchUp()
        {
            return (bool)(this.lastTouch.rolloverSize == 3) ? 1 : 0;
        }
        protected MobileInputHelper()
        {
            val_1 = new System.Object();
        }
    
    }

}
