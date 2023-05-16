using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassGoldNameAssets : ScriptableObject
    {
        // Fields
        private const int MaxChars = 15;
        private const int MinChars = 3;
        private const float MaxDur = 3;
        private const float MinDur = 2;
        public const int BrownBorder = 0;
        public const int PurpleBorder = 1;
        private static Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets NameAssets;
        public UnityEngine.Material goldMaterialPurple;
        public UnityEngine.Material goldMaterialBrown;
        public TMPro.TMP_ColorGradient goldGradient;
        public TMPro.TMP_ColorGradient royalGradient;
        
        // Properties
        public static Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets Instance { get; }
        
        // Methods
        public static Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets get_Instance()
        {
            if(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.NameAssets != 0)
            {
                    return (Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets)Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.NameAssets;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.NameAssets = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets>(path:  "RoyalPassGoldNameAssets");
            return (Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets)Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldNameAssets.NameAssets;
        }
        public UnityEngine.Material GetMaterialByBorderType(int borderType)
        {
            var val_1 = (borderType == 1) ? 24 : 32;
            return (UnityEngine.Material)null;
        }
        public void InitShiny(Coffee.UIExtensions.UIShiny uiShiny, int nickLength)
        {
            float val_5 = UnityEngine.Mathf.Lerp(a:  2f, b:  3f, t:  ((float)nickLength - 3) / 12f);
            float val_4 = UnityEngine.Random.value;
            val_4 = val_4 * 0.3f;
            val_5 = val_5 + val_4;
            uiShiny.effectFactor = 0f;
            uiShiny.width = 0.3f;
            uiShiny.rotation = 130f;
            uiShiny.softness = 0.75f;
            uiShiny.brightness = 0.75f;
            uiShiny.gloss = 0.2f;
            uiShiny.duration = val_5;
            uiShiny.loopDelay = 0f;
            uiShiny.loop = true;
            uiShiny.effectArea = 1;
            uiShiny.Play();
        }
        public RoyalPassGoldNameAssets()
        {
        
        }
    
    }

}
