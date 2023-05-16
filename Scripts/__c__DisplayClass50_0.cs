using UnityEngine;
private sealed class EgoDialog.<>c__DisplayClass50_0
{
    // Fields
    public Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog <>4__this;
    public System.Action dialogClosed;
    
    // Methods
    public EgoDialog.<>c__DisplayClass50_0()
    {
    
    }
    internal void <OnClose>b__0()
    {
        var val_14;
        int val_17;
        var val_18;
        Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy val_19;
        Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy val_21;
        Royal.Scenes.Start.Context.Units.Flow.FlowAction val_22;
        if((this.<>4__this.lastClickedButton) == 3)
        {
            goto label_2;
        }
        
        if((this.<>4__this.lastClickedButton) == 2)
        {
            goto label_3;
        }
        
        if((this.<>4__this.lastClickedButton) != 1)
        {
            goto label_4;
        }
        
        val_14 = 0;
        this.<>4__this.egoManager.PlayOn(isRoyalPassPackage:  false);
        var val_14 = 0;
        if(mem[1152921505114656768] == null)
        {
            goto label_8;
        }
        
        val_14 = val_14 + 1;
        val_14 = 0;
        goto label_38;
        label_3:
        this.<>4__this.egoManager.CancelOffer();
        var val_15 = 0;
        if(mem[1152921505114656768] == null)
        {
            goto label_14;
        }
        
        val_15 = val_15 + 1;
        goto label_16;
        label_2:
        val_17 = this.<>4__this.egoManager.currentStep;
        val_18 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy val_3 = null;
        val_19 = val_3;
        val_3 = new Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy();
        .packagePrice = this.<>4__this.price;
        .egoStep = val_17;
        .origin = 1;
        goto label_21;
        label_4:
        if((this.<>4__this.lastClickedButton) != 4)
        {
            goto label_22;
        }
        
        Royal.Scenes.Start.Context.Units.Flow.FlowManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        val_17 = this.<>4__this.egoManager.currentStep;
        Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy val_5 = null;
        val_21 = val_5;
        val_5 = new Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy();
        .packagePrice = this.<>4__this.price;
        .egoStep = val_17;
        .origin = 2;
        Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_7 = Royal.Infrastructure.Services.Native.Purchase.PurchaseHelper.PricingStrategy.GetRoyalPassConfig();
        new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction() = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction(purchaseStrategy:  val_5, shopPackageConfig:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, dialogOriginType:  9);
        val_22 = new Royal.Scenes.Home.Ui.Dialogs.RoyalPass.Actions.ShowRoyalPassPurchaseDialogAction();
        goto label_31;
        label_22:
        val_17 = this.<>4__this.egoManager.currentStep;
        val_18 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy val_10 = null;
        val_19 = val_10;
        val_10 = new Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoPurchaseStrategy();
        .origin = 0;
        .packagePrice = this.<>4__this.price;
        .egoStep = val_17;
        label_21:
        Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction val_11 = null;
        val_21 = val_11;
        val_11 = new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  val_10);
        val_22 = val_21;
        label_31:
        val_18.Push(action:  val_11);
        goto label_37;
        label_8:
        Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager val_12 = 1152921505114619904 + ((mem[1152921505114656776]) << 4);
        goto label_38;
        label_14:
        Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager val_13 = 1152921505114619904 + ((mem[1152921505114656776]) << 4);
        label_16:
        label_38:
        Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager>(contextId:  15).Clear(gameExit:  true);
        label_37:
        this.<>4__this.OnClose(dialogClosed:  this.dialogClosed);
    }

}
