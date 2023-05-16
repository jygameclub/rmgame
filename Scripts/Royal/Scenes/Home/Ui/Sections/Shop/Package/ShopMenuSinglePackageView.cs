using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class ShopMenuSinglePackageView : ShopMenuPackageView
    {
        // Fields
        public TMPro.TextMeshPro priceText;
        public TMPro.TextMeshPro coinAmountText;
        private Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData <ShopPackageRowData>k__BackingField;
        
        // Properties
        protected override Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData ShopPackageRowData { get; set; }
        
        // Methods
        protected override Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData get_ShopPackageRowData()
        {
            return (Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData)this.<ShopPackageRowData>k__BackingField;
        }
        protected override void set_ShopPackageRowData(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData value)
        {
            this.<ShopPackageRowData>k__BackingField = value;
        }
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            this.priceText.text = typeof(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuSinglePackageView).__il2cppRuntimeField_198;
            this.coinAmountText.text = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView.GetCoinAmountTextInFormat(coinAmount:  this.priceText);
        }
        public ShopMenuSinglePackageView()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem();
        }
    
    }

}
