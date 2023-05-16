using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EnterName
{
    public class ChangeNameConfirmDialog : UiDialog
    {
        // Fields
        public TMPro.TextMeshPro nameText;
        public UnityEngine.GameObject yesButton;
        
        // Methods
        public void Show(string newName)
        {
            this.nameText.text = newName;
            this.Show();
        }
        public void Confirm()
        {
            this.yesButton.SetActive(value:  false);
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_1 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_1.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.ChangeUserNameHttpCommand(newName:  this.nameText.text, trigger:  0));
            val_1.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EnterName.ChangeNameConfirmDialog::NameChanged(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_1, timeOut:  10f);
        }
        private void NameChanged(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(isSuccess == false)
            {
                goto label_1;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_1 = container.FindCommandByType(responseType:  16);
            if(( & 255) != 0)
            {
                goto label_6;
            }
            
            label_1:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
            return;
            label_6:
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Name change successful"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public ChangeNameConfirmDialog()
        {
        
        }
    
    }

}
