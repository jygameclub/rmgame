using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassLastRowSafeParticleView : RoyalPassView
    {
        // Methods
        public override void OnSpawn()
        {
            this.OnSpawn();
            this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public override int GetPoolId()
        {
            return 13;
        }
        public RoyalPassLastRowSafeParticleView()
        {
        
        }
    
    }

}
