using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Logo
{
    public class TeamLogoView : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer frame;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.SpriteRenderer logo;
        
        // Methods
        public void InitTeamLogo(Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoConfig config)
        {
            if(config == null)
            {
                    return;
            }
            
            this.logo.sprite = config.logo;
            this.background.sprite = config.background;
        }
        public void InitById(int logoId)
        {
            this.InitTeamLogo(config:  Royal.Scenes.Home.Ui.Sections.Social.Logo.TeamLogoCatalog.GetConfig().GetLogoById(id:  logoId));
        }
        public void InitWithEmptyYellowBackground()
        {
            this.InitById(logoId:  5);
            this.logo.sprite = 0;
        }
        public void UpdateSorting(Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            bool val_5 = sortingData.sortEverything;
            val_5 = val_5 & 4294967295;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.frame, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5}, offset:  1);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.background, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = val_1.sortEverything & 4294967295});
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = val_5}, offset:  2);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.logo, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
        }
        public TeamLogoView()
        {
        
        }
    
    }

}
