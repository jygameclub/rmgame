using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.Warning
{
    public class ClocheAndMadnessWarn : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer cloche;
        public UnityEngine.Transform madnessTargetRoot;
        public TMPro.TextMeshPro madnessCountText;
        public TMPro.TextMeshPro warningText;
        public UnityEngine.Vector2 madnessPropellerCountTextPosition;
        public UnityEngine.Vector2 madnessPropellerTargetPosition;
        public UnityEngine.Vector2 madnessPropellerTargetScale;
        public UnityEngine.Vector2 madnessBookCountTextPosition;
        public UnityEngine.Vector2 madnessBookCountText3LetterPosition;
        public UnityEngine.Vector2 madnessBookCountText4LetterPosition;
        public float madnessBookCountText4LetterFontSize;
        public UnityEngine.Vector2 madnessBookTargetPosition;
        public UnityEngine.Vector2 madnessBookTargetScale;
        
        // Methods
        public void Show(int clocheCount, int madnessCount, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType madnessEventType)
        {
            UnityEngine.SpriteRenderer val_18;
            string val_19;
            string val_20;
            string val_21;
            var val_22;
            UnityEngine.Vector2 val_23;
            this.gameObject.SetActive(value:  true);
            this.madnessCountText.text = madnessCount.ToString();
            if(clocheCount == 2)
            {
                goto label_3;
            }
            
            if(clocheCount != 1)
            {
                goto label_4;
            }
            
            val_18 = this.cloche;
            val_19 = "cloche_1";
            goto label_6;
            label_3:
            val_18 = this.cloche;
            val_19 = "cloche_2";
            goto label_6;
            label_4:
            val_18 = this.cloche;
            val_19 = "cloche_3";
            label_6:
            val_18.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  val_19);
            UnityEngine.Transform val_4 = this.madnessTargetRoot.transform;
            if((madnessEventType & 255) != 3)
            {
                goto label_9;
            }
            
            val_20 = "MadnessInGameBook";
            val_21 = "YouWillLoseButlersGift&Books";
            if(madnessCount >= 1000)
            {
                goto label_10;
            }
            
            if(madnessCount >= 100)
            {
                goto label_12;
            }
            
            val_22 = null;
            val_23 = this.madnessBookCountTextPosition;
            goto label_13;
            label_9:
            val_20 = "MadnessInGamePropeller";
            val_21 = "YouWillLoseButlersGift&Propellers";
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessPropellerCountTextPosition, y = V8.16B});
            this.madnessCountText.rectTransform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessPropellerTargetPosition, y = val_8.y});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            goto label_19;
            label_10:
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessBookCountText4LetterPosition, y = V8.16B});
            this.madnessCountText.rectTransform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            this.madnessCountText.fontSize = this.madnessBookCountText4LetterFontSize;
            goto label_25;
            label_12:
            val_22 = null;
            val_23 = this.madnessBookCountText3LetterPosition;
            label_13:
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23, y = V8.16B});
            this.madnessCountText.rectTransform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            label_25:
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessBookTargetPosition, y = V8.16B});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            label_19:
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.madnessBookTargetScale, y = val_13.y});
            val_4.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            this.warningText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_21);
            UnityEngine.Transform val_17 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  val_20), parent:  this.madnessTargetRoot);
        }
        public ClocheAndMadnessWarn()
        {
        
        }
    
    }

}
