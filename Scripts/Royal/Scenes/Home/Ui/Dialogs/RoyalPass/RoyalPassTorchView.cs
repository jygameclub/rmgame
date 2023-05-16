using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassTorchView : RoyalPassView
    {
        // Fields
        public UnityEngine.ParticleSystem leftTorch;
        public UnityEngine.ParticleSystem rightTorch;
        
        // Methods
        public override void OnSpawn()
        {
            this.OnSpawn();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public override void OnParentOrTransformSet()
        {
            this.leftTorch.Play();
            this.rightTorch.Play();
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.leftTorch.Stop();
            this.rightTorch.Stop();
        }
        public override int GetPoolId()
        {
            return 9;
        }
        public RoyalPassTorchView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
