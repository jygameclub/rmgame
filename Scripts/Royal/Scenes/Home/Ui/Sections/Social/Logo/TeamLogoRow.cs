using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Logo
{
    public class TeamLogoRow : UiScrollContentItem
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton[] selectButtons;
        public Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoView[] logoViews;
        private Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoRowData rowData;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoRowData val_4;
            UnityEngine.SpriteMaskInteraction val_5;
            var val_6;
            var val_7;
            val_4 = data;
            this.rowData = val_4;
            var val_6 = 0;
            label_8:
            if(val_6 >= this.selectButtons.Length)
            {
                goto label_5;
            }
            
            Royal.Infrastructure.UiComponents.Button.UiScrollButton val_5 = this.selectButtons[val_6];
            val_6 = val_6 + 1;
            val_5 = maskBounds.m_Extents.y;
            val_5 = maskBounds.m_Center.x;
            if(this.selectButtons != null)
            {
                goto label_8;
            }
            
            label_5:
            var val_9 = 4;
            label_17:
            if((val_9 - 4) >= this.logoViews.Length)
            {
                goto label_11;
            }
            
            this.logoViews[0].InitTeamLogo(config:  this.rowData.logoConfigs[0]);
            val_9 = val_9 + 1;
            if(this.logoViews != null)
            {
                goto label_17;
            }
            
            label_11:
            val_5 = 1;
            if(val_2.Length >= 1)
            {
                    do
            {
                val_5 = 1;
                this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true)[0].maskInteraction = val_5;
                val_6 = 0 + 1;
            }
            while(val_6 < val_2.Length);
            
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogScrollContentSorting();
            bool val_4 = val_3.sortEverything & 4294967295;
            val_7 = ???;
            goto typeof(Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoRow).__il2cppRuntimeField_180;
        }
        public override void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sorting)
        {
            var val_5 = 0;
            do
            {
                if(val_5 >= this.logoViews.Length)
            {
                    return;
            }
            
                this.logoViews[val_5].UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sorting.layer, order = sorting.order, sortEverything = (X21 & (-4294967296)) | (sorting.sortEverything & 4294967295)});
                val_5 = val_5 + 1;
            }
            while(this.logoViews != null);
            
            throw new NullReferenceException();
        }
        public void ButtonClicked(int index)
        {
            Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig val_1 = this.rowData.logoConfigs[index];
            this.rowData.dialog.OnLogoSelected(logoId:  this.rowData.logoConfigs[index][0].id);
        }
        public TeamLogoRow()
        {
        
        }
    
    }

}
