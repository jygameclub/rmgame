using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public abstract class RoyalPassView : MonoBehaviour, IPoolable
    {
        // Fields
        private UnityEngine.Vector2 initialScale;
        
        // Methods
        public abstract int GetPoolId(); // 0
        protected void SetXPositionTransformAndXScale(UnityEngine.SpriteRenderer spriteRenderer, float xPosition, float targetSize)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localPosition;
            spriteRenderer.transform.localPosition = new UnityEngine.Vector3() {x = xPosition, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_4 = spriteRenderer.size;
            UnityEngine.Vector3 val_6 = spriteRenderer.transform.localScale;
            spriteRenderer.transform.localScale = new UnityEngine.Vector3() {x = targetSize / val_4.x, y = val_6.y, z = val_6.z};
        }
        protected void SetXPositionTransformAndXSize(UnityEngine.SpriteRenderer spriteRenderer, float xPosition, float xSize)
        {
            UnityEngine.Vector3 val_2 = spriteRenderer.transform.localPosition;
            spriteRenderer.transform.localPosition = new UnityEngine.Vector3() {x = xPosition, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_4 = spriteRenderer.size;
            spriteRenderer.size = new UnityEngine.Vector2() {x = xSize, y = val_4.y};
        }
        protected void IncrementXScale(UnityEngine.Transform transform, float extraScale)
        {
            UnityEngine.Vector3 val_1 = transform.localScale;
            val_1.x = val_1.x + extraScale;
            transform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public virtual void OnParentOrTransformSet()
        {
        
        }
        public virtual void OnSpawn()
        {
            UnityEngine.Vector3 val_2 = this.transform.localScale;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.initialScale = val_3;
            mem[1152921519287558924] = val_3.y;
        }
        public virtual void OnRecycle()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.initialScale, y = V8.16B});
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        protected RoyalPassView()
        {
        
        }
    
    }

}
