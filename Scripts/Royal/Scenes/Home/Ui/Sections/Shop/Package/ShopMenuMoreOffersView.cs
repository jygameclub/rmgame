using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class ShopMenuMoreOffersView : UiScrollCustomContentItem
    {
        // Fields
        private Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView shopScrollView;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
        
        }
        public void Init(Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView shopScrollView)
        {
            this.shopScrollView = shopScrollView;
        }
        public void ShowMoreOffers()
        {
            if(this.shopScrollView != null)
            {
                    this.shopScrollView.ShowMoreOffers();
                return;
            }
            
            throw new NullReferenceException();
        }
        public ShopMenuMoreOffersView()
        {
        
        }
    
    }

}
