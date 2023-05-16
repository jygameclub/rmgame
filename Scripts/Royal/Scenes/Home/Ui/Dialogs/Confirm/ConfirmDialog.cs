using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Confirm
{
    public class ConfirmDialog : UiDialog
    {
        // Fields
        public TMPro.TextMeshPro titleLabel;
        public TMPro.TextMeshPro messageLabel;
        public TMPro.TextMeshPro yesLabel;
        public TMPro.TextMeshPro noLabel;
        private System.Action onConfirm;
        
        // Methods
        public void Show(string title, string message, string yesString, string noString, System.Action confirm)
        {
            this.titleLabel.text = title;
            this.messageLabel.text = message;
            this.yesLabel.text = yesString;
            this.noLabel.text = noString;
            this.onConfirm = confirm;
            this.ArrangeTitle();
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.Show();
        }
        private void Start()
        {
            float val_12;
            float val_13;
            string val_1 = this.titleLabel.text;
            if(val_1.m_stringLength < 4)
            {
                goto label_3;
            }
            
            string val_2 = this.titleLabel.text;
            if(val_2.m_stringLength < 7)
            {
                goto label_6;
            }
            
            string val_3 = this.titleLabel.text;
            if(val_3.m_stringLength <= 9)
            {
                goto label_9;
            }
            
            string val_4 = this.titleLabel.text;
            var val_5 = (val_4.m_stringLength > 13) ? 1 : 0;
            val_12 = mem[36587800 + val_4.m_stringLength > 13 ? 1 : 0];
            val_12 = 36587800 + val_4.m_stringLength > 13 ? 1 : 0;
            var val_6 = (val_4.m_stringLength > 13) ? 5f : 4f;
            goto label_14;
            label_3:
            val_12 = 5.6f;
            val_13 = 1f;
            goto label_14;
            label_6:
            val_12 = 5.55f;
            val_13 = 2f;
            goto label_14;
            label_9:
            val_13 = 3f;
            label_14:
            Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve val_8 = this.titleLabel.GetComponentInChildren<Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve>();
            val_8 = 1;
            val_8 = val_13;
            val_8.ForceUpdate();
            val_8 = 0;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  (Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false) ? 5.5f : 5.58f);
            this.titleLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            if((this.titleLabel.text.Equals(value:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Warning!"))) == false)
            {
                    return;
            }
            
            this = this.titleLabel.rectTransform;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  4.5f, y:  2f);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        public void Confirm()
        {
            if(this.onConfirm == null)
            {
                    return;
            }
            
            this.onConfirm.Invoke();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
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
        public ConfirmDialog()
        {
        
        }
    
    }

}
