using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.SocialConnect
{
    public class SocialConnectResultDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform titleTransform;
        public TMPro.TextMeshPro title;
        public UnityEngine.RectTransform titleRect;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        public TMPro.TextMeshPro facebookMessage;
        public TMPro.TextMeshPro appleMessage;
        public UnityEngine.GameObject check;
        public UnityEngine.GameObject cross;
        public UnityEngine.GameObject continueButton;
        public UnityEngine.RectTransform continueButtonRect;
        public UnityEngine.GameObject connectButton;
        public TMPro.TextMeshPro connectButtonText;
        public UnityEngine.GameObject appleCheckIcon;
        public UnityEngine.GameObject appleCrossIcon;
        public UnityEngine.GameObject facebookIcon;
        private bool isFacebook;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Methods
        public void Init(byte platform, bool success, bool isConnect)
        {
            byte val_1 = platform & 255;
            this.isFacebook = (val_1 == 1) ? 1 : 0;
            this.facebookIcon.SetActive(value:  (val_1 == 1) ? 1 : 0);
            this.facebookMessage.gameObject.SetActive(value:  this.isFacebook);
            this.appleMessage.gameObject.SetActive(value:  (this.isFacebook == false) ? 1 : 0);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            if(success != false)
            {
                    this.ArrangeButtonText();
                this.continueButton.SetActive(value:  true);
                this.ShowSuccess(isConnect:  isConnect);
                return;
            }
            
            this.ShowFail();
        }
        private void ArrangeButtonText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  4.2f, y:  1.4194f);
            this.continueButtonRect.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Transform val_2 = this.continueButtonRect.transform;
            this = val_2;
            UnityEngine.Vector3 val_3 = val_2.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.0463f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private void ArrangeTryAgainButtonText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.connectButtonText.enableAutoSizing = false;
            this.connectButtonText.fontSize = 7f;
            this.connectButtonText.lineSpacing = -25f;
        }
        private void ArrangeSuccessDisconnectTitle()
        {
            UnityEngine.Transform val_17 = this;
            this.title.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Disconnected!");
            this.title.fontSize = 9f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                    UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  6.374711f, y:  1.169929f);
                this.titleRect.sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  -0.266f, y:  5.339f);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.titleRect.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0.8f);
                this.titleRect.transform.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
                this.titleCurve = 1086324736;
                return;
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false)
            {
                    UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  6.501173f, y:  1.169929f);
                this.titleRect.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  -0.087f, y:  5.402f);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
                this.titleRect.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                val_17 = this.titleRect.transform;
                UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0.8f);
                val_17.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
                return;
            }
            
            this.titleCurve = 1083179008;
            val_17 = this.titleTransform;
            UnityEngine.Vector3 val_14 = val_17.localPosition;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_14.x, y:  5.4f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_17.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        private void ShowSuccess(bool isConnect)
        {
            if(isConnect != false)
            {
                    this.title.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Successful!");
                this.title.fontSize = 10f;
                this.titleCurve = (Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean == false) ? 3.4f : 1f;
                UnityEngine.Vector3 val_3 = this.titleTransform.localPosition;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3.x, y:  5.48f);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.titleTransform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                this.appleCheckIcon.SetActive(value:  (this.isFacebook == false) ? 1 : 0);
                this.check.SetActive(value:  this.isFacebook);
                this.facebookMessage.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "FacebookConnected!");
                this.appleMessage.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AppleConnected!");
                return;
            }
            
            this.ArrangeSuccessDisconnectTitle();
            this.appleCrossIcon.SetActive(value:  (this.isFacebook == false) ? 1 : 0);
            this.cross.SetActive(value:  this.isFacebook);
            this.facebookMessage.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "FacebookDisconnected!");
            this.appleMessage.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AppleDisconnected!");
        }
        private void ShowFail()
        {
            this.title.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Fail!");
            this.title.fontSize = 10f;
            this.titleCurve = (Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false) ? 1f : 4f;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false)
            {
                
            }
            
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  5.6f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.title.transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.facebookMessage.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Facebook Connection Failed!");
            this.appleMessage.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "AppleConnectFailed!");
            this.facebookMessage.fontSize = 5.2f;
            this.appleMessage.fontSize = 5.2f;
            this.appleCrossIcon.SetActive(value:  (this.isFacebook == false) ? 1 : 0);
            this.cross.SetActive(value:  this.isFacebook);
            this.ArrangeTryAgainButtonText();
            this.connectButton.SetActive(value:  true);
        }
        public void Connect()
        {
            if(this.isFacebook != false)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20).ConnectWithFacebook(origin:  0);
                return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Login.LoginService>(id:  20).ConnectWithApple();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
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
        public SocialConnectResultDialog()
        {
        
        }
    
    }

}
