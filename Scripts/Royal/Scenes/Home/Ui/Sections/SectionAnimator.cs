using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections
{
    public class SectionAnimator : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.SectionAnimation sectionAnimation;
        public Royal.Scenes.Home.Ui.Sections.SectionSwipe sectionSwipe;
        private bool previouslyDragging;
        
        // Methods
        private void Start()
        {
            if(this.sectionAnimation != null)
            {
                    this.sectionAnimation.Enter();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void Update()
        {
            if((this.sectionSwipe.isDragging != true) && (this.previouslyDragging != false))
            {
                    this.sectionAnimation.Enter();
            }
            
            if(this.sectionSwipe.isDragging != false)
            {
                    this.sectionSwipe.ManualUpdate();
            }
            else
            {
                    this.sectionAnimation.ManualUpdate();
            }
            
            this.previouslyDragging = this.sectionSwipe.isDragging;
        }
        public SectionAnimator()
        {
        
        }
    
    }

}
