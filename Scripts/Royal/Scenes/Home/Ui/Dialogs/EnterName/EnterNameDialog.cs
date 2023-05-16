using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EnterName
{
    public class EnterNameDialog : UiDialog
    {
        // Fields
        public UnityEngine.GameObject changeTitle;
        public UnityEngine.GameObject enterTitle;
        public TMPro.TextMeshPro message;
        public TMPro.TextMeshProUGUI placeholder;
        public UnityEngine.Transform center;
        public UnityEngine.GameObject closeButton;
        public TMPro.TMP_InputField nameField;
        private string trigger;
        private bool changeName;
        private string firstEnteredName;
        private bool openSecondEnterNameDialog;
        private bool openConfirmNameDialog;
        private static System.Text.RegularExpressions.Regex nameValidateRegex;
        
        // Methods
        public void Show(bool change, string firstName, string origin)
        {
            OnValidateInput val_12;
            var val_13;
            this.trigger = origin;
            this.changeName = change;
            this.firstEnteredName = firstName;
            val_12 = this.nameField.m_OnValidateInput;
            System.Delegate val_3 = System.Delegate.Combine(a:  val_12, b:  new TMP_InputField.OnValidateInput(object:  this, method:  System.Char Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog::ValidateInput(string text, int charIndex, char addedChar)));
            if(val_3 != null)
            {
                    if(null != null)
            {
                goto label_3;
            }
            
            }
            
            this.nameField.onValidateInput = val_3;
            if(this.changeName == false)
            {
                goto label_4;
            }
            
            if(this.firstEnteredName == null)
            {
                goto label_5;
            }
            
            val_12 = "Type your new name again";
            this.message.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type your new name again");
            this.placeholder.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type your new name again")(Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type your new name again")) + "...";
            this.changeTitle.SetActive(value:  true);
            this.enterTitle.SetActive(value:  false);
            this.closeButton.SetActive(value:  true);
            this.nameField.ActivateInputField();
            this.nameField.Select();
            goto label_13;
            label_4:
            this.message.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "What is your name?");
            this.placeholder.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type your name...");
            this.changeTitle.SetActive(value:  false);
            this.enterTitle.SetActive(value:  true);
            val_13 = 0;
            goto label_19;
            label_5:
            this.message.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You have one chance to change your name!");
            this.placeholder.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type your new name...");
            this.changeTitle.SetActive(value:  true);
            this.enterTitle.SetActive(value:  false);
            val_13 = 1;
            label_19:
            this.closeButton.SetActive(value:  true);
            label_13:
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_11 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.Show();
            return;
            label_3:
        }
        private char ValidateInput(string text, int charIndex, char addedChar)
        {
            System.Text.RegularExpressions.Regex val_4;
            char val_5;
            if(text.m_stringLength < this.nameField.m_CharacterLimit)
            {
                    val_4 = Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog.nameValidateRegex;
                if(val_4 == null)
            {
                    System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  "^[a-zA-Z0-9 ığüşöçİĞÜŞÖÇ]*$", options:  9);
                Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog.nameValidateRegex = val_1;
                val_4 = Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog.nameValidateRegex;
            }
            
                if((val_1.IsMatch(input:  System.String.alignConst + addedChar)) != false)
            {
                    val_5 = addedChar;
                return (char)val_5;
            }
            
                this.ShowSlidingText(text:  "CharacterIsNotSupported");
            }
            
            val_5 = 0;
            return (char)val_5;
        }
        public void OnContinueClicked()
        {
            string val_8;
            var val_9;
            string val_1 = this.nameField.m_Text.Trim();
            if(val_1.m_stringLength <= 2)
            {
                goto label_4;
            }
            
            if((this.firstEnteredName != null) || ((Royal.Infrastructure.Utils.BadWords.BadWordsFilter.IsBadWord(text:  val_1)) == false))
            {
                goto label_8;
            }
            
            val_8 = "Name is invalid";
            goto label_13;
            label_4:
            val_8 = "Type at least three characters.";
            label_13:
            this.ShowSlidingText(text:  val_8);
            return;
            label_8:
            if(this.changeName == false)
            {
                goto label_10;
            }
            
            if(this.firstEnteredName == null)
            {
                goto label_11;
            }
            
            if((System.String.op_Inequality(a:  val_1, b:  this.firstEnteredName)) == false)
            {
                goto label_12;
            }
            
            goto label_13;
            label_10:
            UpdateName(newName:  val_1);
            if((System.String.IsNullOrEmpty(value:  this.trigger)) == true)
            {
                goto typeof(Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog).__il2cppRuntimeField_250;
            }
            
            val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7);
            bool val_7 = val_9.Send(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.ChangeUserNameHttpCommand(newName:  val_1, trigger:  this.trigger), onComplete:  0, syncRequired:  false);
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog).__il2cppRuntimeField_250;
            label_11:
            this.openSecondEnterNameDialog = true;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog).__il2cppRuntimeField_250;
            label_12:
            this.openConfirmNameDialog = true;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.EnterName.EnterNameDialog).__il2cppRuntimeField_250;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_5;
            this.OnClose(dialogClosed:  dialogClosed);
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(this.changeName == false)
            {
                    return;
            }
            
            if(this.openSecondEnterNameDialog == false)
            {
                goto label_5;
            }
            
            if(this.firstEnteredName != null)
            {
                goto label_6;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction val_3 = null;
            val_5 = val_3;
            val_3 = new Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction();
            .controlName = this.nameField.m_Text;
            .changeName = true;
            .<Type>k__BackingField = 2;
            if(val_2 != null)
            {
                goto label_8;
            }
            
            label_5:
            if(this.firstEnteredName == null)
            {
                    return;
            }
            
            label_6:
            if(this.openConfirmNameDialog == false)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowChangeNameConfirmDialogAction val_4 = null;
            val_5 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowChangeNameConfirmDialogAction();
            .newName = this.nameField.m_Text;
            label_8:
            val_2.Push(action:  val_4);
        }
        public void OnSelectField()
        {
            this.nameField.m_Placeholder.gameObject.SetActive(value:  false);
        }
        public void OnDeSelectField()
        {
            this.nameField.m_Placeholder.gameObject.SetActive(value:  true);
        }
        private void ShowSlidingText(string text)
        {
            UnityEngine.Vector3 val_1 = this.center.position;
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  text), position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y + (-1.375f), z = val_1.z}, width:  7f, speed:  1f);
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
        public EnterNameDialog()
        {
        
        }
    
    }

}
