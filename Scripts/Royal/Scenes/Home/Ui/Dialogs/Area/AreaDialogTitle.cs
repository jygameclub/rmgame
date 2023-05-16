using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class AreaDialogTitle : CurvedTitle
    {
        // Fields
        private const float DefaultRectWidth = 5.2761;
        private const float DefaultRectHeight = 2.2484;
        
        // Methods
        public void SetText(string areaName, int areaId)
        {
            if((areaId - 1) <= 25)
            {
                    var val_34 = 36587040 + ((areaId - 1)) << 2;
                val_34 = val_34 + 36587040;
            }
            else
            {
                    this.SetText(text:  areaName, curveStrength:  1f);
            }
        
        }
        public AreaDialogTitle()
        {
        
        }
    
    }

}
