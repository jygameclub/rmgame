using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial.View
{
    public class HomeTutorialMaskView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer centerMask;
        public UnityEngine.SpriteRenderer leftMask;
        public UnityEngine.SpriteRenderer rightMask;
        
        // Methods
        public void ArrangeArea(UnityEngine.Vector3 centerPosition, float width, float height)
        {
            float val_5;
            this.transform.position = new UnityEngine.Vector3() {x = centerPosition.x, y = centerPosition.y, z = centerPosition.z};
            UnityEngine.Bounds val_3 = this.centerMask.sprite.bounds;
            float val_24 = 0.9f;
            val_24 = (width / val_5) * val_24;
            float val_8 = height / centerPosition.y;
            this.centerMask.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.centerMask.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_25 = -0.5f;
            val_25 = width * val_25;
            this.leftMask.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_26 = 0.5f;
            val_26 = width * val_26;
            this.rightMask.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            UnityEngine.Bounds val_14 = this.leftMask.sprite.bounds;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  height / val_12.y);
            this.leftMask.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            this.rightMask.transform.localScale = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector3 val_22 = this.transform.localPosition;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = 0f};
        }
        public HomeTutorialMaskView()
        {
        
        }
    
    }

}
