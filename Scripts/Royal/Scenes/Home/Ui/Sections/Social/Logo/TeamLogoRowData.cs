using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Logo
{
    public class TeamLogoRowData : IUiScrollContentData
    {
        // Fields
        public readonly Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig[] logoConfigs;
        public readonly Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoDialog dialog;
        
        // Methods
        public TeamLogoRowData(int count, Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoDialog dialog)
        {
            this.logoConfigs = new Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig[0];
            this.dialog = dialog;
        }
    
    }

}
