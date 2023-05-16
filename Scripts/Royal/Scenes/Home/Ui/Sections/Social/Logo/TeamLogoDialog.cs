using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Logo
{
    public class TeamLogoDialog : UiDialog
    {
        // Fields
        private const int ItemCountInRow = 4;
        public Royal.Infrastructure.UiComponents.Scroll.UiScroll scroll;
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiOptimizedScrollContent content;
        
        // Methods
        public override void Show()
        {
            this.Show();
            this.PopulateContent();
        }
        private void PopulateContent()
        {
            this.scroll.UpdateMaskBounds();
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig> val_2 = Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog.GetConfig().GetConfigsByVisualOrder();
            if(true < 4)
            {
                    return;
            }
            
            var val_7 = 0;
            var val_6 = 0;
            var val_8 = 32;
            do
            {
                Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoRowData val_3 = new Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoRowData(count:  4, dialog:  this);
                var val_5 = 0;
                do
            {
                if((val_7 + val_5) >= 1152921505025695744)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 1;
                (Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoRowData)[1152921518992417968].logoConfigs[val_5] = "tn-ZA";
            }
            while(val_5 < 3);
            
                val_6 = val_6 + 1;
                val_7 = val_7 + 4;
                val_8 = val_8 + 32;
            }
            while(val_6 < 0);
        
        }
        public void OnLogoSelected(int logoId)
        {
            var val_2;
            Royal.Scenes.Home.Ui.Sections.SectionType val_3;
            val_2 = null;
            val_2 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_3 = 1;
            Royal.Scenes.Home.Ui.Sections.Section val_1 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  val_3);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_3 = null;
            val_1.SelectLogo(userSelectedLogo:  logoId);
            val_2 = this;
            goto typeof(Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoDialog).__il2cppRuntimeField_250;
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
        public TeamLogoDialog()
        {
        
        }
    
    }

}
