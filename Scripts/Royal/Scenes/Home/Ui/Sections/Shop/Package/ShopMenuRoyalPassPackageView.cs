using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class ShopMenuRoyalPassPackageView : ShopMenuPackageView
    {
        // Fields
        public TMPro.TextMeshPro priceText;
        public UnityEngine.GameObject personalAvatar;
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.SpriteRenderer selfPicture;
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
            this.priceText.text = typeof(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuRoyalPassPackageView).__il2cppRuntimeField_198;
            this.ArrangePersonalInfo();
        }
        private void ArrangePersonalInfo()
        {
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    0 = Royal.Infrastructure.Services.Login.FacebookConnect.LoadProfilePicture(facebookId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg);
            }
            
            UnityEngine.GameObject val_4 = this.kingPicture.gameObject;
            if(0 != 0)
            {
                    val_4.SetActive(value:  false);
                this.personalAvatar.SetActive(value:  true);
                this.selfPicture.sprite = 0;
                return;
            }
            
            val_4.SetActive(value:  true);
            this.personalAvatar.SetActive(value:  false);
        }
        public ShopMenuRoyalPassPackageView()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem();
        }
    
    }

}
