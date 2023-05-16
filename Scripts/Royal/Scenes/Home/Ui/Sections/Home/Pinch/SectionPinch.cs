using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Pinch
{
    public class SectionPinch : AreaPinch
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.SectionManager sectionManager;
        private Royal.Infrastructure.UiComponents.Dialog.DialogManager dialogManager;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            this.dialogManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
        }
        protected override bool CanSingleTouch()
        {
            return (bool)this;
        }
        protected override bool CanPinch()
        {
            var val_3 = 0;
            if((this.sectionManager.AtSection(type:  0)) == false)
            {
                    return (bool)(this.dialogManager.hasActiveDialog == false) ? 1 : 0;
            }
            
            return (bool)(this.dialogManager.hasActiveDialog == false) ? 1 : 0;
        }
        protected override UnityEngine.Vector3 OwnerPosition()
        {
            return UnityEngine.Vector3.zero;
        }
        public SectionPinch()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
