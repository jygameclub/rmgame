using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public class SuggestTeamView : MonoBehaviour
    {
        // Fields
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        public Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionView noConnection;
        private Royal.Scenes.Home.Ui.Sections.Social.SocialSection parent;
        private bool suggestCallInProgress;
        private int counter;
        
        // Methods
        private void Awake()
        {
            this.parent = this.GetComponentInParent<Royal.Scenes.Home.Ui.Sections.Social.SocialSection>();
            Royal.Infrastructure.Contexts.Units.App.AppManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            val_2.add_OnApplicationPause(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView::Paused()));
            val_2.add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView::Resumed()));
        }
        public void Enable(bool enable)
        {
            this.gameObject.SetActive(value:  enable);
            this.parent.suggestList.gameObject.SetActive(value:  enable);
            if(enable == false)
            {
                    return;
            }
            
            this.SuggestTeam();
        }
        private void SuggestTeam()
        {
            if(this.suggestCallInProgress != false)
            {
                    return;
            }
            
            this.suggestCallInProgress = true;
            this.spinner.Hide();
            this.spinner.Show();
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_2 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_2.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.SearchTeamHttpCommand(searchText:  System.String.alignConst));
            val_2.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView::SuggestedTeamsReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_2, timeOut:  10f);
        }
        private void SuggestedTeamsReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            var val_8;
            int val_9;
            this.suggestCallInProgress = false;
            if(this.spinner == 0)
            {
                    return;
            }
            
            if(isSuccess != false)
            {
                    this.counter = 0;
                this.spinner.Hide();
                this.noConnection.SetActive(activate:  false);
                this.parent.noTeamsTab.SetActive(value:  true);
                this.CancelInvoke(methodName:  "SuggestTeam");
                val_8 = null;
                val_8 = null;
                Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_3 = container.FindCommandByType(responseType:  15);
                this.parent.suggestList.PrepareContent(response:  new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table() {bb_pos = 537006080}}, hideMyTeam:  false, createSlowly:  (Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.AtSection(type:  1)) ^ 1);
                return;
            }
            
            int val_8 = this.counter;
            val_8 = val_8 + 1;
            this.counter = val_8;
            object[] val_6 = new object[1];
            val_6[0] = this.counter;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  20, log:  "Get suggested team list try count: {0}", values:  val_6);
            val_9 = this.counter;
            if(val_9 == 2)
            {
                    Royal.Scenes.Home.Ui.Dialogs.NoConnection.NoConnectionView.CheckMaintenanceMode();
                val_9 = this.counter;
            }
            
            if(val_9 <= 4)
            {
                    this.Invoke(methodName:  "SuggestTeam", time:  5f);
                if(this.counter < 3)
            {
                    return;
            }
            
            }
            
            if(this.noConnection.IsActive() == true)
            {
                    return;
            }
            
            this.parent.noTeamsTab.SetActive(value:  false);
            this.noConnection.SetActive(activate:  true);
            this.parent.SelectJoin();
        }
        private void Paused()
        {
            this.counter = 0;
            this.CancelInvoke(methodName:  "SuggestTeam");
        }
        private void Resumed()
        {
            this.SuggestTeam();
        }
        private void OnDestroy()
        {
            this.CancelInvoke(methodName:  "SuggestTeam");
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.remove_OnApplicationPause(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView::Paused()));
            val_1.remove_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SuggestTeamView::Resumed()));
        }
        public SuggestTeamView()
        {
        
        }
    
    }

}
