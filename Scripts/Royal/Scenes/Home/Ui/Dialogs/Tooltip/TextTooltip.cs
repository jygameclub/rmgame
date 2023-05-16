using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Tooltip
{
    public class TextTooltip : MonoBehaviour
    {
        // Fields
        private const float BackgroundBorderHeight = 0.75;
        private const float BackgroundBorderWidth = 0.65;
        private const float BottomBorderThickness = 0.07;
        public UnityEngine.SpriteRenderer leftBg;
        public UnityEngine.SpriteRenderer rightBg;
        public UnityEngine.GameObject bg;
        public UnityEngine.GameObject upArrow;
        public UnityEngine.GameObject downArrow;
        public TMPro.TextMeshPro text;
        
        // Methods
        public void AutoAdjustSize(Royal.Scenes.Game.Ui.Dialogs.ToolTipManager.Direction direction)
        {
            UnityEngine.Vector2 val_2 = this.text.GetPreferredValues(text:  this.text.text);
            val_2.x = val_2.x * 0.5f;
            float val_3 = val_2.x + 0.65f;
            float val_4 = val_2.y + 0.75f;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_3, y:  val_4);
            this.rightBg.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_3, y:  val_4);
            this.leftBg.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector3 val_8 = this.bg.transform.localPosition;
            float val_12 = -0.07f;
            float val_11 = -0.5f;
            val_11 = val_4 * val_11;
            val_12 = (val_4 * 0.5f) + val_12;
            val_4 = (direction == 0) ? (val_11) : (val_12);
            this.bg.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_4, z = val_8.z};
        }
        public void SetBodyPosition(float position)
        {
            UnityEngine.Vector3 val_2 = this.bg.transform.localPosition;
            this.bg.transform.localPosition = new UnityEngine.Vector3() {x = position, y = val_2.y, z = val_2.z};
        }
        public void EnableArrow(Royal.Scenes.Game.Ui.Dialogs.ToolTipManager.Direction direction)
        {
            if(direction == 0)
            {
                goto label_0;
            }
            
            label_2:
            this.upArrow.SetActive(value:  false);
            return;
            label_0:
            if(this.downArrow != null)
            {
                goto label_2;
            }
            
            throw new NullReferenceException();
        }
        public void PrepareTooltip(Royal.Scenes.Game.Ui.Dialogs.ToolTipManager.Direction direction, float bodyPosition, string message)
        {
            this.EnableArrow(direction:  direction);
            this.text.text = message;
            this.AutoAdjustSize(direction:  direction);
            this.SetBodyPosition(position:  bodyPosition);
        }
        public TextTooltip()
        {
        
        }
    
    }

}
