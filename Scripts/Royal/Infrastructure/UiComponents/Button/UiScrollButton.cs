using UnityEngine;

namespace Royal.Infrastructure.UiComponents.Button
{
    public class UiScrollButton : UiBasicButton
    {
        // Fields
        public UnityEngine.Bounds maskBounds;
        
        // Properties
        public override Royal.Infrastructure.UiComponents.Touch.ZIndex ZIndex { get; set; }
        
        // Methods
        public override Royal.Infrastructure.UiComponents.Touch.ZIndex get_ZIndex()
        {
            var val_2;
            if(this.IsInside() != false)
            {
                    return 5;
            }
            
            val_2 = 5;
            return 5;
        }
        public override void set_ZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex value)
        {
            mem[1152921527531263464] = value;
        }
        private bool IsInside()
        {
            var val_4;
            UnityEngine.Bounds val_1 = this.bounds;
            if((this.maskBounds & 1) != 0)
            {
                    val_4 = this.maskBounds;
            }
            else
            {
                    val_4 = 0;
            }
            
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        public UiScrollButton()
        {
            mem[1152921527531499692] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
