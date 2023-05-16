using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionHighlight : SectionElement
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.SectionSwipe swipe;
        private bool previouslyDragging;
        
        // Methods
        protected override void Update()
        {
            float val_7;
            if((this.swipe.isDragging != true) && (this.previouslyDragging != false))
            {
                    this.ResetProgress();
            }
            
            if(this.swipe.isDragging == false)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_2 = this.transform.localPosition;
            if(this.swipe.isDragging == false)
            {
                goto label_6;
            }
            
            float val_4 = this.swipe.currentTouchPos - this.swipe.startSwipePos;
            val_4 = val_4 / (float)UnityEngine.Screen.width;
            val_7 = val_4 * 1.55f;
            goto label_7;
            label_3:
            this.Update();
            goto label_8;
            label_6:
            val_7 = 0f;
            label_7:
            this.transform.localPosition = new UnityEngine.Vector3() {x = S10 - val_7, y = val_2.y, z = val_2.z};
            label_8:
            this.previouslyDragging = this.swipe.isDragging;
        }
        public SectionHighlight()
        {
            mem[1152921518950451816] = 1061997773;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
