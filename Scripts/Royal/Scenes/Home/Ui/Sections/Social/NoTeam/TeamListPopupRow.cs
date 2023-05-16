using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.NoTeam
{
    public class TeamListPopupRow : UiScrollContentItem
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView teamLogo;
        public TMPro.TextMeshPro teamName;
        public TMPro.TextMeshPro teamCapacity;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton rootButton;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton viewButton;
        private Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData teamData;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            data.System.IDisposable.Dispose();
            mem[1152921518968691272] = Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData.__il2cppRuntimeField_element_class;
            mem[1152921518968691256] = ???;
            this.teamData = new Royal.Scenes.Home.Ui.Sections.Social.NoTeam.TeamListRowData();
            this.viewButton = maskBounds.m_Extents.y;
            this.viewButton = maskBounds.m_Center.x;
            this.rootButton = maskBounds.m_Extents.y;
            this.rootButton = maskBounds.m_Center.x;
            this.teamName.text = null;
            string val_1 = null + "/50"("/50");
            this.teamCapacity.text = val_1;
            this.teamLogo.InitTeamLogo(config:  val_1);
        }
        public void OnView()
        {
            if(true != 0)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Your join request has been sent. Waiting for approval."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
                return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), action:  new Royal.Scenes.Home.Ui.Sections.Social.MyTeam.ShowTeamInfoPopupAction(teamId:  this.teamData));
        }
        public TeamListPopupRow()
        {
        
        }
    
    }

}
