using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupGiftBoxToolTip : UiPanel
    {
        // Fields
        public UnityEngine.GameObject upArrow;
        public UnityEngine.GameObject downArrow;
        public TMPro.TextMeshPro[] hours;
        public UnityEngine.GameObject[] rewards;
        
        // Methods
        private void Awake()
        {
            var val_3;
            var val_4 = 0;
            do
            {
                if(val_4 >= this.hours.Length)
            {
                    return;
            }
            
                TMPro.TextMeshPro val_3 = this.hours[val_4];
                val_3 = null;
                val_3 = null;
                val_3.text = val_3.text + Royal.Infrastructure.Utils.Time.TimeUtil.hLocalized;
                val_4 = val_4 + 1;
            }
            while(this.hours != null);
            
            throw new NullReferenceException();
        }
        public void ArrangeRewards(int rank, bool atDown)
        {
            float val_8;
            if(rank > 3)
            {
                    if(atDown != true)
            {
                    this.upArrow.SetActive(value:  false);
                this.downArrow.SetActive(value:  true);
            }
            
            }
            else
            {
                
            }
            
            this.rewards[rank - 1].SetActive(value:  true);
            UnityEngine.BoxCollider2D val_3 = this.GetComponent<UnityEngine.BoxCollider2D>();
            if(rank > 2)
            {
                    UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  7.570589f, y:  1.737397f);
                val_3.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                val_8 = -1.023949f;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  6.32204f, y:  2.724624f);
                val_3.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
                val_8 = -1.517562f;
            }
            
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  -1.969078f, y:  val_8);
            val_3.offset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        public KingsCupGiftBoxToolTip()
        {
        
        }
    
    }

}
