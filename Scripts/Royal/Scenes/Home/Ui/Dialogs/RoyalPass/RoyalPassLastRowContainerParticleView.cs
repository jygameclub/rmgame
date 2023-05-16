using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassLastRowContainerParticleView : RoyalPassView
    {
        // Methods
        public override void OnSpawn()
        {
            this.OnSpawn();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public override int GetPoolId()
        {
            return 12;
        }
        public RoyalPassLastRowContainerParticleView()
        {
        
        }
    
    }

}
