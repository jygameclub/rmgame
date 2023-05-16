using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class GoldNickName : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro nick;
        public bool isDefaultShiny;
        private Coffee.UIExtensions.UIShiny uiShiny;
        private UnityEngine.Material originalMaterial;
        private TMPro.TMP_ColorGradient originalGradient;
        private bool isGold;
        private bool enableVertexGradient;
        private UnityEngine.Color oldColor;
        
        // Methods
        private void Awake()
        {
            if(this.isDefaultShiny == false)
            {
                    return;
            }
            
            this.CreateGoldNickname();
        }
        public void SetNickName(string nickName, bool isGold, UnityEngine.Color nickColor, int borderType = 0)
        {
            this.nick.text = nickName;
            this.ArrangeGoldNickname(gold:  isGold, nickColor:  new UnityEngine.Color() {r = nickColor.r, g = nickColor.g, b = nickColor.b, a = nickColor.a}, borderType:  borderType);
        }
        public void SetNickName(string nickName, bool isGold, int borderType = 0)
        {
            this.nick.text = nickName;
            UnityEngine.Color val_1 = this.nick.color;
            this.ArrangeGoldNickname(gold:  isGold, nickColor:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, borderType:  borderType);
        }
        private void ArrangeGoldNickname(bool gold, UnityEngine.Color nickColor, int borderType)
        {
            var val_1 = (this.isGold == false) ? 1 : 0;
            val_1 = val_1 ^ gold;
            if(val_1 != false)
            {
                    return;
            }
            
            this.isGold = gold;
            if(gold != false)
            {
                    this.oldColor = nickColor;
                mem[1152921519184346776] = nickColor.g;
                mem[1152921519184346780] = nickColor.b;
                mem[1152921519184346784] = nickColor.a;
                UnityEngine.Color val_3 = UnityEngine.Color.white;
                this.nick.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
                this.enableVertexGradient = null;
                this.nick.enableVertexGradient = true;
                this.originalGradient = null;
                Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets val_4 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.Instance;
                this.nick.colorGradientPreset = val_4.goldGradient;
                this.originalMaterial = this.nick.fontSharedMaterial;
                Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets val_6 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.Instance;
                var val_7 = (borderType == 1) ? 24 : 32;
                this.nick.fontSharedMaterial = null;
                this.CreateGoldNickname();
                return;
            }
            
            this.nick.enableVertexGradient = this.enableVertexGradient;
            this.nick.fontSharedMaterial = this.originalMaterial;
            this.nick.colorGradientPreset = this.originalGradient;
            this.nick.color = new UnityEngine.Color() {r = this.oldColor, g = nickColor.g, b = nickColor.b, a = nickColor.a};
            this.DisableGoldNickName();
        }
        private void CreateGoldNickname()
        {
            UnityEngine.Object val_6;
            Coffee.UIExtensions.UIShiny val_7;
            val_6 = 0;
            if(this.uiShiny != val_6)
            {
                goto label_3;
            }
            
            val_6 = public Coffee.UIExtensions.UIShiny UnityEngine.GameObject::AddComponent<Coffee.UIExtensions.UIShiny>();
            Coffee.UIExtensions.UIShiny val_3 = this.gameObject.AddComponent<Coffee.UIExtensions.UIShiny>();
            this.uiShiny = val_3;
            if(val_3 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_3:
            val_7 = this.uiShiny;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            label_5:
            val_6 = 1;
            val_7.enabled = true;
            val_7 = this.nick;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6 = public System.String TMPro.TMP_Text::get_text();
            string val_5 = val_7.text;
            if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.Instance == null)
            {
                    throw new NullReferenceException();
            }
            
            val_5.InitShiny(uiShiny:  this.uiShiny, nickLength:  val_5.m_stringLength);
        }
        private void DisableGoldNickName()
        {
            if(this.uiShiny == 0)
            {
                    return;
            }
            
            if(this.uiShiny == null)
            {
                    throw new NullReferenceException();
            }
            
            this.uiShiny.Stop();
            this.uiShiny.enabled = false;
        }
        public GoldNickName()
        {
        
        }
    
    }

}
