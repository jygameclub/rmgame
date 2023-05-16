using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Logo
{
    public class TeamLogoCatalog : ScriptableObject
    {
        // Fields
        public int selectedItem;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig[] configsArray;
        
        // Methods
        private void Init()
        {
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig val_2 = 0;
            do
            {
                if(val_2 >= this.configsArray.Length)
            {
                    return;
            }
            
                this.configsArray[val_2] = val_2;
                val_2 = val_2 + 1;
            }
            while(this.configsArray != null);
            
            throw new NullReferenceException();
        }
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig GetLogoById(int id)
        {
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig val_1;
            if(this.configsArray.Length > id)
            {
                    val_1 = this.configsArray[id];
                return (Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig)val_1;
            }
            
            val_1 = 0;
            return (Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig)val_1;
        }
        public System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig> GetConfigsByVisualOrder()
        {
            var val_3;
            System.Func<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig, System.Int32> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = TeamLogoCatalog.<>c.<>9__4_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig>(source:  System.Linq.Enumerable.OrderBy<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig, System.Int32>(source:  this.configsArray, keySelector:  System.Func<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig, System.Int32> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig, System.Int32>(object:  TeamLogoCatalog.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 TeamLogoCatalog.<>c::<GetConfigsByVisualOrder>b__4_0(Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig c));
            TeamLogoCatalog.<>c.<>9__4_0 = val_5;
            return System.Linq.Enumerable.ToList<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig>(source:  System.Linq.Enumerable.OrderBy<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig, System.Int32>(source:  this.configsArray, keySelector:  val_1));
        }
        public static Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog GetConfig()
        {
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog val_1 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog>(path:  "TeamLogoCatalog");
            val_1.Init();
            return val_1;
        }
        public TeamLogoCatalog()
        {
        
        }
    
    }

}
