using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Touch
{
    public struct UiTouchDisabler
    {
        // Fields
        private int touchDisabled;
        private int pinchDisabled;
        private int verticalScrollDisabled;
        private int horizontalScrollDisabled;
        
        // Methods
        public void Reset()
        {
        
        }
        public void DisableTouch()
        {
            mem[1152921527500031776] = W8 + 1;
        }
        public void EnableTouch()
        {
            mem[1152921527500143776] = W8 - 1;
        }
        public bool IsTouchDisabled()
        {
            return (bool)(W8 > 0) ? 1 : 0;
        }
        public void DisableHorizontalScroll()
        {
            mem[1152921527500367788] = W8 + 1;
        }
        public void EnableHorizontalScroll()
        {
            mem[1152921527500479788] = W8 - 1;
        }
        public bool IsHorizontalScrollDisabled()
        {
            return (bool)(W8 > 0) ? 1 : 0;
        }
        public void DisableVerticalScroll()
        {
            mem[1152921527500703784] = W8 + 1;
        }
        public void EnableVerticalScroll()
        {
            mem[1152921527500815784] = W8 - 1;
        }
        public bool IsVerticalScrollDisabled()
        {
            return (bool)(W8 > 0) ? 1 : 0;
        }
        public void DisablePinch()
        {
            mem[1152921527501039780] = W8 + 1;
        }
        public void EnablePinch()
        {
            mem[1152921527501151780] = W8 - 1;
        }
        public bool IsPinchDisabled()
        {
            return (bool)(W8 > 0) ? 1 : 0;
        }
        public void SetAllTouches(bool enable)
        {
            bool val_1 = enable;
            throw 36601481;
        }
    
    }

}
