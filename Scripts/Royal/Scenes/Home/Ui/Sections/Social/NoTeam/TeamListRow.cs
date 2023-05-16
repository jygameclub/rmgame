using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public class TeamListRow : UiScrollContentItem
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogo;
        public TMPro.TextMeshPro teamName;
        public TMPro.TextMeshPro teamCapacity;
        public Royal.Infrastructure.UiComponents.Button.UiSelectButton viewButton;
        private Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData teamData;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            data.System.IDisposable.Dispose();
            mem[1152921518969258160] = Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData.__il2cppRuntimeField_element_class;
            this.teamData = new Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData();
            mem[1152921518969258144] = ???;
            this.teamName.text = null;
            string val_1 = null + "/50"("/50");
            this.teamCapacity.text = val_1;
            this.teamLogo.InitTeamLogo(config:  val_1);
            this.viewButton.Select(select:  (null == 0) ? 1 : 0);
        }
        public void OnView()
        {
            if(true != 0)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Your join request has been sent. Waiting for approval."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
                return;
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_2.mainFlow.Push(action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction(teamId:  this.teamData));
        }
        public TeamListRow()
        {
        
        }
    
    }

}
