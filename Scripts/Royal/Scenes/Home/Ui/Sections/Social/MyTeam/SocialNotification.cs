using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class SocialNotification : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject greenNotification;
        public UnityEngine.GameObject redNotification;
        public TMPro.TextMeshPro redText;
        private int activeAskCount;
        private int activeHelpCount;
        
        // Methods
        public static void UpdateActiveHelpCount(int diff)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1).ChangeActiveHelpCount(diff:  diff);
        }
        private void ChangeActiveHelpCount(int diff)
        {
            int val_2;
            if(this == 0)
            {
                    return;
            }
            
            if(diff != 0)
            {
                    val_2 = this.activeHelpCount + diff;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.activeHelpCount = val_2;
            this.Show();
        }
        public void UpdateActiveAskCount(int askCount)
        {
            if(this.activeAskCount == askCount)
            {
                    return;
            }
            
            this.activeAskCount = askCount;
            this.Show();
        }
        public void Hide()
        {
            this.activeAskCount = 0;
            this.activeHelpCount = 0;
            this.greenNotification.SetActive(value:  false);
            this.redNotification.SetActive(value:  false);
            this.gameObject.SetActive(value:  false);
        }
        private void Show()
        {
            var val_2;
            if(this.activeAskCount >= 1)
            {
                    val_2 = 1;
            }
            else
            {
                    if(this.activeHelpCount >= 1)
            {
                    this.greenNotification.SetActive(value:  false);
                this.redNotification.SetActive(value:  true);
                this.redText.text = this.activeHelpCount.ToString();
                return;
            }
            
                this.activeAskCount = 0;
                this.activeHelpCount = 0;
                val_2 = 0;
            }
            
            this.greenNotification.SetActive(value:  false);
            this.redNotification.SetActive(value:  false);
        }
        public void ShowMark()
        {
            this.gameObject.SetActive(value:  true);
            this.greenNotification.SetActive(value:  false);
            this.redNotification.SetActive(value:  true);
            this.redText.text = "!";
        }
        public void Highlight(bool highlight)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  (highlight != true) ? 0.74f : 0.85f);
            this.greenNotification.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.redNotification.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public SocialNotification()
        {
        
        }
    
    }

}
