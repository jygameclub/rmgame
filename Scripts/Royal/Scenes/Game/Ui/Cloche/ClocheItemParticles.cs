using UnityEngine;

namespace Royal.Scenes.Game.Ui.Cloche
{
    public class ClocheItemParticles : MonoBehaviour
    {
        // Methods
        public void DestroySelf()
        {
            this.transform.SetParent(p:  0);
            this.Invoke(methodName:  "Destroy", time:  1f);
        }
        public ClocheItemParticles()
        {
        
        }
    
    }

}
