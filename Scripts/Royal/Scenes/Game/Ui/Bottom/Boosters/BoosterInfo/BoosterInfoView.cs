using UnityEngine;

namespace Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterInfo
{
    public class BoosterInfoView : MonoBehaviour
    {
        // Methods
        public Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterInfo.BoosterInfoView Init(float verticalPosition)
        {
            UnityEngine.Vector3 val_4 = this.transform.position;
            this.gameObject.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return (Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterInfo.BoosterInfoView)this;
        }
        public BoosterInfoView()
        {
        
        }
    
    }

}
