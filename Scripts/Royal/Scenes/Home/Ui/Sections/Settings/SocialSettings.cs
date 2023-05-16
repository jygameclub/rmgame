using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Settings
{
    public class SocialSettings : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton changeNameButton;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton chatOnOffButton;
        
        // Methods
        public void Start()
        {
            Royal.Player.Context.Units.SocialManager val_1 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.chatOnOffButton.Select(select:  val_1.<ChatEnabled>k__BackingField);
            this.changeNameButton.Select(select:  (~IsNameChangedOnce()) & 1);
        }
        public void ChangeName()
        {
            if(IsNameChangedOnce() != false)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You have already changed your name once!"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
                return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.EnterName.ShowEnterNameDialogAction(changeName:  true, controlName:  0));
        }
        public void LeaveTeam()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9).ShouldShowWarningInTeamLeave) != false)
            {
                    val_2.Push(type:  this.GetType(), action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowLeaveTeamWithWarningDialogAction(onConfirm:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SocialSettings::OnLeaveTeam())));
                return;
            }
            
            val_2.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Confirm.ShowConfirmDialogAction(title:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Leave Team?"), message:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Are you sure you want to leave your team?"), onConfirm:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SocialSettings::OnLeaveTeam())));
        }
        private void OnLeaveTeam()
        {
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Settings.SocialSettings::TeamLeft(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.LeaveTeamHttpCommand(teamId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_this_arg));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void TeamLeft(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            var val_2;
            if(isSuccess != false)
            {
                    val_2 = null;
                val_2 = null;
                Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(section:  Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.SocialSection);
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowConnectionProblem();
        }
        public void ChangeChatOnOff()
        {
            var val_5;
            var val_6;
            bool val_2 = ((val_1.<ChatEnabled>k__BackingField) == false) ? 1 : 0;
            this.chatOnOffButton.Select(select:  val_2);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4).UpdateChatEnabled(enable:  val_2);
            if((val_1.<ChatEnabled>k__BackingField) == true)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.SocialSection;
            bool val_4 = UnityEngine.Object.op_Inequality(x:  47587328, y:  0);
            if(val_4 == false)
            {
                    return;
            }
            
            val_4.OnChatDisabled();
        }
        public void UpdateChangeNameButton()
        {
            this.changeNameButton.Select(select:  (~IsNameChangedOnce()) & 1);
        }
        public void SearchTeam()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Social.SearchTeam.ShowSearchTeamPopupAction());
        }
        public SocialSettings()
        {
        
        }
    
    }

}
