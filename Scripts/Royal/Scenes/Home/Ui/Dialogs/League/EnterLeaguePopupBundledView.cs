using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class EnterLeaguePopupBundledView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer topLeftRenderer;
        public UnityEngine.SpriteRenderer topRightRenderer;
        public UnityEngine.Transform centerUi;
        public UnityEngine.Transform polesAndRopes;
        public UnityEngine.Transform firstPole;
        public UnityEngine.Transform fourthPole;
        
        // Methods
        public void Prepare(string prefabName)
        {
            float val_13;
            float val_14;
            float val_15;
            UnityEngine.Transform val_16;
            if((System.String.op_Equality(a:  prefabName, b:  "EnterLeaguePopupForTallDevices")) != false)
            {
                    val_13 = 3.121428f;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  4.606841f, y:  val_13);
                this.topLeftRenderer.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                val_14 = 1.03572f;
                val_15 = 1.0524f;
                this.topLeftRenderer.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  4.606841f, y:  val_13);
                this.topRightRenderer.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                this.topRightRenderer.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.centerUi.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.centerUi.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.polesAndRopes.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_16 = this.polesAndRopes;
            }
            else
            {
                    if((System.String.op_Equality(a:  prefabName, b:  "EnterLeaguePopupForOtherDevices")) == false)
            {
                    return;
            }
            
                UnityEngine.Transform val_7 = this.topLeftRenderer.transform;
                val_13 = 3.121428f;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  4.606841f, y:  val_13);
                this.topLeftRenderer.size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
                val_14 = 1.03572f;
                val_15 = 1.0524f;
                val_7.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_7.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Transform val_9 = this.topRightRenderer.transform;
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  4.606841f, y:  val_13);
                this.topRightRenderer.size = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
                val_9.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_9.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.centerUi.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.centerUi.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.polesAndRopes.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_16 = this.polesAndRopes;
            }
            
            val_16.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.firstPole.gameObject.SetActive(value:  false);
            this.fourthPole.gameObject.SetActive(value:  false);
        }
        public EnterLeaguePopupBundledView()
        {
        
        }
    
    }

}
