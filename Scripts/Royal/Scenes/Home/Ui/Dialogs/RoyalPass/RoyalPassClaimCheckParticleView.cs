using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassClaimCheckParticleView : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem particles;
        
        // Methods
        public void PlayAndDestroy()
        {
            this.particles.Play();
            this.Invoke(methodName:  "Clear", time:  3f);
        }
        private void Clear()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public RoyalPassClaimCheckParticleView()
        {
        
        }
    
    }

}
