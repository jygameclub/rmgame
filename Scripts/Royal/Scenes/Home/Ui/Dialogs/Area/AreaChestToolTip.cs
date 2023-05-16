using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Area
{
    public class AreaChestToolTip : UiPanel
    {
        // Fields
        public UnityEngine.GameObject area1Icons;
        public UnityEngine.GameObject icons;
        
        // Methods
        public void ArrangeRewardsForArea(int areaId)
        {
            float val_9;
            this.area1Icons.gameObject.SetActive(value:  (areaId == 1) ? 1 : 0);
            this.icons.gameObject.SetActive(value:  (areaId != 1) ? 1 : 0);
            UnityEngine.BoxCollider2D val_5 = this.GetComponent<UnityEngine.BoxCollider2D>();
            if(areaId == 1)
            {
                    UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  7.570589f, y:  1.737397f);
                val_5.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                val_9 = -1.023949f;
            }
            else
            {
                    UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  6.32204f, y:  2.724624f);
                val_5.size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
                val_9 = -1.517562f;
            }
            
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  -1.969078f, y:  val_9);
            val_5.offset = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        public AreaChestToolTip()
        {
        
        }
    
    }

}
