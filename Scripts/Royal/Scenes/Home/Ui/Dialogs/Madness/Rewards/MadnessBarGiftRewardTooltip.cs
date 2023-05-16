using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards
{
    public class MadnessBarGiftRewardTooltip : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro bigGiftBoxHours;
        public TMPro.TextMeshPro bigChestHours;
        public UnityEngine.GameObject[] rewards;
        
        // Methods
        public void ArrangeRewards(int boxNumber)
        {
            string val_10;
            var val_11;
            var val_12;
            val_10 = boxNumber;
            this.rewards[val_10].SetActive(value:  true);
            UnityEngine.BoxCollider2D val_1 = this.GetComponent<UnityEngine.BoxCollider2D>();
            if(val_10 == 4)
            {
                goto label_4;
            }
            
            if(val_10 != 2)
            {
                goto label_5;
            }
            
            val_10 = this.bigGiftBoxHours.text;
            val_11 = null;
            val_11 = null;
            this.bigGiftBoxHours.text = null.AddToEnd(value:  val_10, extra:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -2.655728f, y:  -0.9339099f);
            val_1.offset = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            goto label_15;
            label_4:
            val_10 = this.bigChestHours.text;
            val_12 = null;
            val_12 = null;
            this.bigChestHours.text = null.AddToEnd(value:  val_10, extra:  Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized);
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  -1.926652f, y:  -0.9339099f);
            val_1.offset = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            goto label_15;
            label_5:
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  -0.4143057f, y:  -0.9339099f);
            val_1.offset = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            label_15:
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  3.173258f, y:  1.557319f);
            val_1.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        public string AddToEnd(string value, string extra)
        {
            string val_1;
            string val_2;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    val_1 = extra;
                val_2 = value;
                return val_1 + val_2;
            }
            
            val_1 = value;
            val_2 = extra;
            return val_1 + val_2;
        }
        public MadnessBarGiftRewardTooltip()
        {
        
        }
    
    }

}
