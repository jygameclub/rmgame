using UnityEngine;
private sealed class ShopMenuPackageView.<FinishPurchaseAfterDelay>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool maintenance;
    public Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView <>4__this;
    public Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopMenuPackageView.<FinishPurchaseAfterDelay>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView val_10;
        int val_11;
        val_9 = this;
        val_10 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if(this.maintenance != false)
        {
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView val_1 = val_10 + 16;
            Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  Royal.Player.Context.Data.InventoryPackage.GetInventoryPackageFromShop(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}));
        }
        
        val_11 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  80f));
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.loadingManager.HideShopLoading();
        Royal.Scenes.Home.Ui.Dialogs.BuyCoins.ShowBuyCoinsResultDialogAction val_5 = new Royal.Scenes.Home.Ui.Dialogs.BuyCoins.ShowBuyCoinsResultDialogAction(purchaseResultType:  this.<>4__this.purchaseStatus, status:  this.status, type:  1);
        val_5.add_OnComplete(value:  new System.Action(object:  val_10, method:  System.Void Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView::AfterBuyCoinsResultDialogClosed()));
        val_10 = this.status;
        val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        val_10 = null;
        val_9.Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_10}), action:  val_5);
        label_2:
        val_11 = 0;
        return (bool)val_11;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
