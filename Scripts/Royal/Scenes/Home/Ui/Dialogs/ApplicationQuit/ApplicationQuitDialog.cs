using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit
{
    public class ApplicationQuitDialog : UiDialog
    {
        // Fields
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener listener;
        
        // Methods
        public void Init()
        {
            this.listener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            throw new NullReferenceException();
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            throw new NullReferenceException();
        }
        public void OnCloseButton()
        {
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.ApplicationQuit.ApplicationQuitDialog).__il2cppRuntimeField_250;
        }
        public void OnQuitButton()
        {
            object[] val_3 = new object[1];
            val_3[0] = true;
            bool val_4 = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity").Call<System.Boolean>(methodName:  "moveTaskToBack", args:  val_3);
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
        public ApplicationQuitDialog()
        {
        
        }
    
    }

}
