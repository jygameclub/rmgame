using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.NoConnection
{
    public class NoConnectionDialog : UiDialog
    {
        // Fields
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        public UnityEngine.RectTransform titleRect;
        public UnityEngine.RectTransform messageRect;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        
        // Methods
        public void Init()
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.ArrangeTexts();
        }
        private void ArrangeTexts()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.titleCurve = 1086324736;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  6.567564f, y:  2f);
            this.titleRect.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  -0.272f, y:  5.32f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.titleRect.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0.8f);
            this.titleRect.transform.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  4.16f, y:  2.203f);
            this.messageRect.sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Transform val_8 = this.messageRect.transform;
            this = val_8;
            UnityEngine.Vector3 val_9 = val_8.localPosition;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.117f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
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
        public NoConnectionDialog()
        {
        
        }
    
    }

}
