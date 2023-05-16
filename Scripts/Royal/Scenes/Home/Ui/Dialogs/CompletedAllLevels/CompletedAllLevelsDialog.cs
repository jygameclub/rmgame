using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.CompletedAllLevels
{
    public class CompletedAllLevelsDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform titleTransform;
        public TMPro.TextMeshPro[] title;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve[] titleCurves;
        public TMPro.TextMeshPro message;
        public TMPro.TextMeshPro buttonText;
        private bool isNewLevelsPublished;
        
        // Methods
        public void Init(bool isNewLevelsPublished)
        {
            var val_17;
            var val_18;
            float val_19;
            float val_20;
            float val_21;
            Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve val_22;
            TMPro.TextMeshPro val_23;
            string val_24;
            this.isNewLevelsPublished = isNewLevelsPublished;
            if(isNewLevelsPublished == false)
            {
                goto label_1;
            }
            
            val_17 = 1152921505135546368;
            val_18 = 4;
            val_19 = 1f;
            label_18:
            if((val_18 - 4) >= this.title.Length)
            {
                goto label_3;
            }
            
            this.title[0].text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "NewLevels!");
            this.title[0].fontSizeMin = 7.5f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isRussian != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                goto label_13;
            }
            
            }
            
            }
            
            label_13:
            this.title[0].fontSizeMax = 8f;
            val_18 = val_18 + 1;
            this.titleCurves[0] = (Royal.Infrastructure.Services.Localization.LocalizationHelper.isFrench == false) ? 0.8f : (val_19);
            if(this.title != null)
            {
                goto label_18;
            }
            
            label_1:
            val_17 = 1152921505135546368;
            val_19 = 1.2f;
            val_18 = 4;
            val_20 = 7.5f;
            val_21 = 9.5f;
            label_44:
            if((val_18 - 4) >= this.title.Length)
            {
                goto label_21;
            }
            
            this.title[0].text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Congratulations!");
            this.title[0].fontSizeMin = val_20;
            if(((Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean != true) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != true)) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isItalian != true))
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isSpanish != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isRussian == false)
            {
                goto label_33;
            }
            
            }
            
            }
            
            label_33:
            this.title[0].fontSizeMax = 8.5f;
            val_22 = 0f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == true)
            {
                goto label_42;
            }
            
            val_22 = 0.75f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean == true)
            {
                goto label_42;
            }
            
            val_22 = 0.8f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isSpanish == true)
            {
                goto label_42;
            }
            
            val_22 = 0.8f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isTurkish == true)
            {
                goto label_42;
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == true)
            {
                goto label_41;
            }
            
            val_22 = val_19;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isPortuguese == false)
            {
                goto label_42;
            }
            
            label_41:
            val_22 = 1f;
            label_42:
            this.titleCurves[0] = val_22;
            val_18 = val_18 + 1;
            if(this.title != null)
            {
                goto label_44;
            }
            
            label_3:
            UnityEngine.Vector3 val_7 = this.titleTransform.position;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_7.x, y:  7.54f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            this.titleTransform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_20 = val_10.x;
            val_21 = val_10.z;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_20, y = val_10.y, z = val_21});
            this.titleTransform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            this.message.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Update game for more levels!");
            this.message.fontSize = 8f;
            val_23 = this.buttonText;
            val_24 = "Update";
            goto label_56;
            label_21:
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.titleTransform.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
            UnityEngine.Vector3 val_14 = this.titleTransform.position;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_14.x, y:  7.581f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            this.titleTransform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            this.message.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "NewLevelsComingSoon!");
            this.message.fontSize = 8f;
            val_23 = this.buttonText;
            val_24 = "Continue";
            label_56:
            val_23.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_24);
        }
        public void ClickButton()
        {
            if(this.isNewLevelsPublished != false)
            {
                    UnityEngine.Application.OpenURL(url:  Royal.Infrastructure.Contexts.Units.App.AppManager.StoreUrl);
            }
        
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public CompletedAllLevelsDialog()
        {
        
        }
    
    }

}
