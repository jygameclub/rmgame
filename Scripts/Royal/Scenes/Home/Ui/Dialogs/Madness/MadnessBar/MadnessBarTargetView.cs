using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar
{
    public class MadnessBarTargetView : MonoBehaviour
    {
        // Methods
        public void CreateTarget(Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType, bool isInGameBar = False)
        {
            this.DestroyTarget();
            string val_4 = ((eventType & 255) == 3) ? ((isInGameBar != true) ? "MadnessInGameBarBook" : "BarTargetBook") : ((isInGameBar != true) ? "MadnessInGamePropeller" : "BarTargetPropeller");
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_4), parent:  this.transform);
        }
        private void DestroyTarget()
        {
            int val_3 = this.transform.childCount - 1;
            if(<0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_5 = this.transform.GetChild(index:  val_3);
                val_5.SetParent(p:  0);
                UnityEngine.Object.Destroy(obj:  val_5.gameObject);
                val_3 = val_3 - 1;
            }
            while(>=0);
        
        }
        public MadnessBarTargetView()
        {
        
        }
    
    }

}
