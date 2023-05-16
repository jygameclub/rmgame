using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class ShopPackageRowData : IUiScrollContentData
    {
        // Fields
        public readonly Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config;
        public readonly Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView shopScrollView;
        
        // Methods
        public ShopPackageRowData(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig packageConfig, Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView shopScrollView)
        {
            this.shopScrollView = shopScrollView;
        }
    
    }

}
