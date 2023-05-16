using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.Warning
{
    public class MadnessWarn : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro madnessCountText;
        public TMPro.TextMeshPro warningText;
        public UnityEngine.Transform madnessTargetRoot;
        public UnityEngine.Vector2 madnessPropellerCountTextPosition;
        public UnityEngine.Vector2 madnessBookCountTextPosition;
        public UnityEngine.Vector2 madnessPropellerTargetPosition;
        public UnityEngine.Vector2 madnessBookTargetPosition;
        
        // Methods
        public void Show(int madnessCount, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType madnessEventType)
        {
            string val_12;
            string val_13;
            UnityEngine.Transform val_17;
            this.gameObject.SetActive(value:  true);
            this.madnessCountText.text = madnessCount.ToString();
            if((madnessEventType & 255) == 3)
            {
                    val_12 = "MadnessInGameBook";
                val_13 = "YouWillLoseBooks";
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessBookCountTextPosition, y = V8.16B});
                this.madnessCountText.rectTransform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                val_17 = this.madnessTargetRoot;
            }
            else
            {
                    val_12 = "MadnessInGamePropeller";
                val_13 = "YouWillLosePropellers";
                UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessPropellerCountTextPosition, y = V8.16B});
                this.madnessCountText.rectTransform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                val_17 = this.madnessTargetRoot;
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessPropellerTargetPosition, y = val_7.y});
            val_17.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            this.warningText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_13);
            UnityEngine.Transform val_11 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  val_12), parent:  this.madnessTargetRoot);
        }
        public MadnessWarn()
        {
        
        }
    
    }

}
