using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public class SearchTeamView : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject bottom;
        public TMPro.TMP_InputField queryField;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        private Royal.Scenes.Home.Ui.Sections.Social.SocialSection parent;
        
        // Methods
        private void Awake()
        {
            this.parent = this.GetComponentInParent<Royal.Scenes.Home.Ui.Sections.Social.SocialSection>();
        }
        public void Reset()
        {
            this.Clear();
            this.Enable(enable:  false);
        }
        public void Enable(bool enable)
        {
            var val_8;
            this.gameObject.SetActive(value:  enable);
            this.parent.searchList.gameObject.SetActive(value:  enable);
            if(enable != false)
            {
                    if(this.parent.searchList.content.dataList != null)
            {
                
            }
            else
            {
                    val_8 = 0;
            }
            
                this.bottom.SetActive(value:  (val_8 == 0) ? 1 : 0);
                this.parent.searchList.gameObject.SetActive(value:  (val_8 > 0) ? 1 : 0);
            }
            
            this.spinner.Hide();
        }
        public void Suggest()
        {
            this.SearchTeam(query:  System.String.alignConst);
        }
        public void Search()
        {
            if(val_1.m_stringLength > 2)
            {
                    this.SearchTeam(query:  this.queryField.m_Text.Trim());
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Type at least three characters."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public void Clear()
        {
            this.spinner.Hide();
            this.queryField.text = System.String.alignConst;
            this.bottom.SetActive(value:  true);
            this.parent.searchList.gameObject.SetActive(value:  false);
            if(this.parent.searchList.content.dataList == null)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent).__il2cppRuntimeField_170;
        }
        private void SearchTeam(string query)
        {
            this.spinner.Show();
            this.parent.searchList.gameObject.SetActive(value:  true);
            Royal.Infrastructure.Services.Backend.Http.Command.Commands val_3 = new Royal.Infrastructure.Services.Backend.Http.Command.Commands();
            val_3.Add(httpCommand:  new Royal.Infrastructure.Services.Backend.Http.Command.Social.SearchTeamHttpCommand(searchText:  query));
            val_3.add_OnComplete(value:  new Commands.ConnectionComplete(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.NoTeam.SearchTeamView::SearchedTeamsReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)));
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).SendImmediately(commandsToSend:  val_3, timeOut:  10f);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).Search(query:  query);
        }
        private void SearchedTeamsReceived(bool isSuccess, Royal.Infrastructure.Services.Backend.Http.Command.Commands container)
        {
            if(this.spinner == 0)
            {
                    return;
            }
            
            this.spinner.Hide();
            if(isSuccess == false)
            {
                    return;
            }
            
            Royal.Infrastructure.Services.Backend.Http.Command.BaseHttpCommand val_2 = container.FindCommandByType(responseType:  15);
            if( > 0)
            {
                    this.bottom.SetActive(value:  false);
                this.parent.searchList.PrepareContent(response:  new Royal.Infrastructure.Services.Backend.Protocol.SearchTeamResponse() {__p = new FlatBuffers.Table()}, hideMyTeam:  false, createSlowly:  false);
                return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "There are no results for this name."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public void OnSelectField()
        {
            this.queryField.m_Placeholder.gameObject.SetActive(value:  false);
        }
        public void OnDeSelectField()
        {
            this.queryField.m_Placeholder.gameObject.SetActive(value:  true);
        }
        public void EnableQueryField(bool enable)
        {
            if(this.queryField != null)
            {
                    this.queryField.enabled = enable;
                return;
            }
            
            throw new NullReferenceException();
        }
        public SearchTeamView()
        {
        
        }
    
    }

}
