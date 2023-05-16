using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public class CreateTeamView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView logoView;
        public UnityEngine.SpriteRenderer background;
        public TMPro.TextMeshPro typeText;
        public TMPro.TextMeshPro levelTitle;
        public TMPro.TextMeshPro levelText;
        public TMPro.TMP_InputField nameField;
        public TMPro.TMP_InputField descField;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public UnityEngine.Transform createButton;
        public UnityEngine.Transform coin;
        public UnityEngine.Transform price;
        private int logo;
        private bool isTypeOpen;
        private int requiredLevel;
        private bool isLogoSelectedByUser;
        private Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog teamLogoCatalog;
        
        // Methods
        private void Awake()
        {
            this.descField.m_TextComponent.enableWordWrapping = true;
            this.teamLogoCatalog = Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog.GetConfig();
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false)
            {
                    this.levelTitle.fontSizeMax = 4.3f;
                UnityEngine.RectTransform val_2 = this.levelTitle.rectTransform;
                UnityEngine.Vector2 val_3 = val_2.sizeDelta;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, d:  0.5f);
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
                val_2.sizeDelta = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                UnityEngine.RectTransform val_7 = this.levelTitle.rectTransform;
                UnityEngine.Vector3 val_8 = val_7.localPosition;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.183f);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_7.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            }
            
            this.ArrangeCreateButton();
            this.ChangeType();
            this.ChangeLevel(increase:  false);
        }
        private void SelectRandomLogo()
        {
            if(this.isLogoSelectedByUser != false)
            {
                    return;
            }
            
            int val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  100);
            this.logo = val_2;
            this.logoView.InitTeamLogo(config:  this.teamLogoCatalog.GetLogoById(id:  val_2));
        }
        private void ArrangeCreateButton()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = this.coin.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.18f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.coin.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = this.price.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.18f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.price.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        public void Reset()
        {
            this.requiredLevel = 0;
            this.isTypeOpen = false;
            this.isLogoSelectedByUser = false;
            this.nameField.text = System.String.alignConst;
            this.descField.text = System.String.alignConst;
            this.ChangeType();
            this.ChangeLevel(increase:  false);
            this.Enable(enable:  false);
        }
        public void Enable(bool enable)
        {
            this.gameObject.SetActive(value:  enable);
            if(enable == false)
            {
                    return;
            }
            
            this.SelectRandomLogo();
        }
        public void SetPosition(float bottomYPositionOfTopUi)
        {
            UnityEngine.Vector2 val_2 = this.background.size;
            float val_5 = -0.5f;
            val_5 = val_2.y * val_5;
            val_2.y = bottomYPositionOfTopUi + val_5;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  val_2.y);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public void SelectLogo()
        {
            this.EnableInputFields(enable:  false);
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            Royal.Scenes.Home.Ui.Sections.Social.Logo.ShowTeamLogoDialogAction val_2 = new Royal.Scenes.Home.Ui.Sections.Social.Logo.ShowTeamLogoDialogAction();
            val_2.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView::<SelectLogo>b__22_0()));
            val_1.mainFlow.Push(action:  val_2);
        }
        private void EnableInputFields(bool enable)
        {
            bool val_1 = enable;
            this.nameField.enabled = val_1;
            this.descField.enabled = val_1;
        }
        public void SelectLogo(int userSelectedLogo)
        {
            this.isLogoSelectedByUser = true;
            this.logo = userSelectedLogo;
            this.logoView.InitTeamLogo(config:  this.teamLogoCatalog.GetLogoById(id:  userSelectedLogo));
        }
        public void OnDescChange()
        {
            this.descField.text = Royal.Infrastructure.Utils.Text.EmojiHelper.ReplaceWithCustomEmojis(str:  Royal.Infrastructure.Utils.String.StringExtensions.StripHtmlTags(input:  this.descField.m_Text));
        }
        public void CreateTeam()
        {
            string val_15;
            string val_16;
            var val_17;
            if(val_1.m_stringLength <= 2)
            {
                goto label_8;
            }
            
            if((Royal.Infrastructure.Utils.BadWords.BadWordsFilter.IsBadWord(text:  this.nameField.m_Text.Trim())) == false)
            {
                goto label_11;
            }
            
            val_15 = "Team Name is invalid";
            goto label_12;
            label_8:
            val_16 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type at least three characters for Team Name.");
            val_17 = 3;
            goto label_13;
            label_11:
            if((Royal.Infrastructure.Utils.BadWords.BadWordsFilter.IsBadWord(text:  this.descField.m_Text)) == false)
            {
                goto label_17;
            }
            
            val_15 = "Description is invalid";
            label_12:
            val_16 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_15);
            val_17 = 1;
            label_13:
            UnityEngine.Vector3 val_9 = this.SlidingTextPosition(lineCount:  1);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  val_16, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, width:  7f, speed:  1f);
            return;
            label_17:
            if(IsNameEnteredOnce() != false)
            {
                    if((System.String.IsNullOrEmpty(value:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28)) == false)
            {
                goto label_23;
            }
            
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_12 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.EnableInputFields(enable:  false);
            Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction val_13 = new Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction(changeName:  false, controlName:  0);
            val_13.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView::<CreateTeam>b__26_0()));
            val_12.mainFlow.Push(action:  val_13);
            return;
            label_23:
            this.SendCreateTeamHttpCommand(newName:  System.String.alignConst);
        }
        private void SendCreateTeamHttpCommandWithNewName()
        {
            this.SendCreateTeamHttpCommand(newName:  typeof(Royal.Player.Context.Data.UserId).__il2cppRuntimeField_28);
        }
        private void SendCreateTeamHttpCommand(string newName)
        {
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.CreateTeamHttpCommand(teamId:  0, teamName:  this.nameField.m_Text, userName:  newName, logo:  this.logo, description:  Royal.Infrastructure.Utils.Text.EmojiHelper.RemoveCustomEmojis(str:  this.descField.m_Text), minLevel:  this.requiredLevel, isOpen:  this.isTypeOpen));
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.CreateTeamView::TeamCreated(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void TeamCreated(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(isSuccess != false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.SlidingTextPosition(lineCount:  2);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Couldn\'t create team, try again later."), position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, width:  7f, speed:  1f);
        }
        public void ChangeType()
        {
            this.isTypeOpen = this.isTypeOpen ^ 1;
            this.typeText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  Royal.Player.Context.Units.SocialManager.TeamType(type:  (this.isTypeOpen == false) ? 1 : 0));
        }
        public void ChangeLevel(bool increase)
        {
            int val_1 = ((increase & true) != 0) ? (-50) : 50;
            val_1 = this.requiredLevel + val_1;
            UnityEngine.Vector3 val_4 = this.SlidingTextPosition(lineCount:  3);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  System.String.Format(format:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Reach level X to increase Required Level limit."), arg0:  val_1), position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, width:  7f, speed:  1f);
        }
        public void OnSelectField(bool isNameField)
        {
            TMPro.TMP_InputField val_2;
            if(isNameField == false)
            {
                goto label_0;
            }
            
            val_2 = this.nameField;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            label_0:
            val_2 = this.descField;
            label_1:
            this.descField.m_Placeholder.gameObject.SetActive(value:  false);
        }
        public void OnDeSelectField(bool isNameField)
        {
            TMPro.TMP_InputField val_2;
            if(isNameField == false)
            {
                goto label_0;
            }
            
            val_2 = this.nameField;
            if(val_2 != null)
            {
                goto label_1;
            }
            
            label_0:
            val_2 = this.descField;
            label_1:
            this.descField.m_Placeholder.gameObject.SetActive(value:  true);
        }
        private UnityEngine.Vector3 SlidingTextPosition(int lineCount = 1)
        {
            UnityEngine.Vector3 val_1 = this.createButton.position;
            var val_2 = (lineCount == 3) ? 1 : 0;
            val_1.y = val_1.y + 2.98f;
            val_1.y = (36531268 + lineCount == 3 ? 1 : 0) + val_1.y;
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public CreateTeamView()
        {
        
        }
        private void <SelectLogo>b__22_0()
        {
            this.EnableInputFields(enable:  true);
        }
        private void <CreateTeam>b__26_0()
        {
            this.EnableInputFields(enable:  true);
            this.SendCreateTeamHttpCommandWithNewName();
        }
    
    }

}
