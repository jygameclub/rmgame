using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.MyTeam
{
    public class TeamEditDialog : UiDialog
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView logoView;
        public TMPro.TextMeshPro nameText;
        public TMPro.TextMeshPro typeText;
        public TMPro.TextMeshPro levelText;
        public TMPro.TMP_InputField descField;
        public UnityEngine.GameObject saveButton;
        public TMPro.TextMeshPro titleText;
        public UnityEngine.RectTransform titleRect;
        public UnityEngine.RectTransform descriptionHeaderRect;
        public TMPro.TextMeshPro typeHeaderText;
        public UnityEngine.RectTransform typeHeaderRect;
        public TMPro.TextMeshPro levelHeaderText;
        public UnityEngine.RectTransform levelHeaderRect;
        private int logo;
        private long teamId;
        private bool isTypeOpen;
        private int requiredLevel;
        
        // Methods
        public void Show(Royal.Infrastructure.Services.Backend.Protocol.GetTeamInfoResponse info)
        {
            this.descField.m_TextComponent.enableWordWrapping = true;
            this.logo = ;
            this.logoView.InitById(logoId:  1483327296);
            this.teamId = ;
            this.isTypeOpen = false;
            this.requiredLevel = ;
            this.nameText.text = info.__p.bb_pos;
            this.descField.text = Royal.Infrastructure.Utils.Text.EmojiHelper.ReplaceWithCustomEmojis(str:  info.__p.bb_pos);
            this.levelText.text = ToString();
            this.typeText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  Royal.Player.Context.Units.SocialManager.TeamType(type:  false));
            this.ArrangeComponents();
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.Show();
        }
        private void ArrangeComponents()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return;
            }
            
            this.titleText.enableAutoSizing = false;
            this.titleText.fontSize = 10f;
            this.titleRect.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.descriptionHeaderRect.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.typeHeaderText.enableAutoSizing = false;
            this.typeHeaderText.fontSize = 3.6f;
            this.typeHeaderRect.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  2.37f, y:  0.6114811f);
            this.typeHeaderRect.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            this.levelHeaderText.enableAutoSizing = false;
            this.levelHeaderText.fontSize = 3.6f;
            this.levelHeaderRect.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this = this.levelHeaderRect;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  2.38f, y:  0.6114811f);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        public void OnDescChange()
        {
            this.descField.text = Royal.Infrastructure.Utils.Text.EmojiHelper.ReplaceWithCustomEmojis(str:  Royal.Infrastructure.Utils.String.StringExtensions.StripHtmlTags(input:  this.descField.m_Text));
        }
        public void UpdateTeam()
        {
            string val_1 = Royal.Infrastructure.Utils.Text.EmojiHelper.RemoveCustomEmojis(str:  this.descField.m_Text);
            if((Royal.Infrastructure.Utils.BadWords.BadWordsFilter.IsBadWord(text:  val_1)) != false)
            {
                    UnityEngine.Vector3 val_4 = this.SlidingTextPosition(lineCount:  1);
                Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Description is invalid"), position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, width:  7f, speed:  1f);
                return;
            }
            
            this.saveButton.SetActive(value:  false);
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_6 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_6.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.CreateTeamHttpCommand(teamId:  this.teamId, teamName:  this.nameText.text, userName:  System.String.alignConst, logo:  this.logo, description:  val_1, minLevel:  this.requiredLevel, isOpen:  this.isTypeOpen));
            val_6.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.GetTeamHttpCommand(teamId:  this.teamId, includeMembers:  true));
            val_6.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.MyTeam.TeamEditDialog::TeamInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_6, timeOut:  10f);
        }
        private void TeamInfoReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(isSuccess != false)
            {
                    Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_1 = container.FindCommandByType(responseType:  9);
                .teamInfoResponse = isSuccess;
                mem[1152921518975894056] = 1;
                .animate = false;
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).PushToSameRunningFlowAction<Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction>(action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction());
                return;
            }
            
            this.saveButton.SetActive(value:  true);
            UnityEngine.Vector3 val_5 = this.SlidingTextPosition(lineCount:  2);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Couldn\'t update team. Try again later."), position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, width:  7f, speed:  1f);
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
        public void OnSelectField()
        {
            this.descField.m_Placeholder.gameObject.SetActive(value:  false);
        }
        public void OnDeSelectField()
        {
            this.descField.m_Placeholder.gameObject.SetActive(value:  true);
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
        private UnityEngine.Vector3 SlidingTextPosition(int lineCount = 1)
        {
            UnityEngine.Vector3 val_2 = this.saveButton.transform.position;
            var val_3 = (lineCount == 2) ? 1 : 0;
            val_2.y = val_2.y + 2.9f;
            val_2.y = val_2.y + ((lineCount == 3) ? 0.64f : (36529952 + lineCount == 2 ? 1 : 0));
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public TeamEditDialog()
        {
        
        }
    
    }

}
