using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RequestNotification
{
    public class RequestNotificationDialog : UiDialog
    {
        // Fields
        public UnityEngine.RectTransform title;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener listener;
        
        // Methods
        public void Init()
        {
            this.listener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = this.title.sizeDelta;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  0.35f);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.title.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector3 val_6 = this.title.localPosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.025f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.title.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            throw new NullReferenceException();
        }
        public void OnCloseButton()
        {
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RequestNotification.RequestNotificationDialog).__il2cppRuntimeField_250;
        }
        public void OnContinueButton()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19).StartIntentAction(actionName:  Royal.Infrastructure.Services.Notification.GameNotificationService.NotificationSettingsUrl);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.RequestNotification.RequestNotificationDialog).__il2cppRuntimeField_250;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            bool val_3;
            float val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldCloseOnSwipe = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeOutDelay = val_4;
            val_0.shouldSkipFastOnTouch = val_3;
            return val_0;
        }
        public RequestNotificationDialog()
        {
        
        }
    
    }

}
