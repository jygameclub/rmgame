using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.Warning
{
    public abstract class ClocheWarn : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform cloche;
        public UnityEngine.Transform crossSign;
        
        // Methods
        public void Show(int clocheCount)
        {
            var val_5;
            var val_6;
            var val_7;
            string val_8;
            this.gameObject.SetActive(value:  true);
            if(clocheCount == 1)
            {
                    val_5 = this.cloche.GetComponent<UnityEngine.SpriteRenderer>();
                val_6 = public static UnityEngine.Sprite UnityEngine.Resources::Load<UnityEngine.Sprite>(string path);
                val_7 = "cloche_1";
            }
            else
            {
                    val_5 = this.cloche.GetComponent<UnityEngine.SpriteRenderer>();
                if(clocheCount == 2)
            {
                    val_8 = "cloche_2";
            }
            else
            {
                    val_8 = "cloche_3";
            }
            
                val_6 = public static UnityEngine.Sprite UnityEngine.Resources::Load<UnityEngine.Sprite>(string path);
            }
            
            val_5.sprite = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  val_8);
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.Warning.ClocheWarn).__il2cppRuntimeField_170;
        }
        protected abstract void SetupClocheAndCrossSign(int clocheCount); // 0
        protected ClocheWarn()
        {
        
        }
    
    }

}
