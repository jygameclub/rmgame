using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class ShowShopPopupViewAction : FlowAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        
        // Methods
        public ShowShopPopupViewAction(Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy)
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.TimeHelper>(id:  14).SendPing();
            this.purchaseStrategy = purchaseStrategy;
        }
        public override void Execute()
        {
            Royal.Infrastructure.UiComponents.Dialog.UiPopup.Instantiate<Royal.Scenes.Home.Ui.Sections.Shop.ShopPopupView>(assetName:  "ShopPopup", action:  this).SetStrategy(strategy:  this.purchaseStrategy);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
