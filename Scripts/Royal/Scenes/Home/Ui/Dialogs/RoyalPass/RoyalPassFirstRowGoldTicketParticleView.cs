using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassFirstRowGoldTicketParticleView : RoyalPassView
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public override void OnSpawn()
        {
            this.OnSpawn();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  0.041f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.4f);
            this.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.particles.Play();
        }
        public override void OnRecycle()
        {
            this.OnRecycle();
            this.particles.Stop(withChildren:  true, stopBehavior:  0);
        }
        public override int GetPoolId()
        {
            return 10;
        }
        public RoyalPassFirstRowGoldTicketParticleView()
        {
        
        }
    
    }

}
