using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Pinch
{
    public class DialogPinch : AreaPinch
    {
        // Fields
        private UnityEngine.Transform dialogTransform;
        public bool pinchEnabled;
        
        // Methods
        public void SetDialogTransform(UnityEngine.Transform dialogTransform)
        {
            this.dialogTransform = dialogTransform;
        }
        protected override bool CanSingleTouch()
        {
            return (bool)this.pinchEnabled;
        }
        protected override bool CanPinch()
        {
            return (bool)this.pinchEnabled;
        }
        protected override UnityEngine.Vector3 OwnerPosition()
        {
            if(this.dialogTransform != null)
            {
                    return this.dialogTransform.position;
            }
            
            throw new NullReferenceException();
        }
        public DialogPinch()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
