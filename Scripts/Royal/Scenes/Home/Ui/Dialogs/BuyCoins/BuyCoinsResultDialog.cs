using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BuyCoins
{
    public class BuyCoinsResultDialog : UiDialog
    {
        // Fields
        public TMPro.TextMeshPro title;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        public TMPro.TextMeshPro message;
        public UnityEngine.SpriteRenderer coinImage;
        public UnityEngine.SpriteRenderer bundleImage;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Scenes.Home.Ui.Dialogs.BuyCoins.PurchaseResultType purchaseResultType;
        
        // Methods
        public void Init(Royal.Scenes.Home.Ui.Dialogs.BuyCoins.PurchaseResultType resultType, Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.purchaseResultType = resultType;
            this.PrepareTitle(status:  status);
            this.PrepareMessage(status:  status);
            this.PrepareImage(status:  status);
            throw new NullReferenceException();
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            var val_2;
            this.OnShow(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  this.message.text, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public override void OnClose(System.Action dialogClosed)
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_2;
            if(this.purchaseResultType == 2)
            {
                    val_2 = this.flowManager;
                val_2.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction(disableTouch:  false, newPiggy:  false, fromAnotherDialog:  true));
            }
            
            this.OnClose(dialogClosed:  dialogClosed);
        }
        private void PrepareImage(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            if(status != 3)
            {
                    return;
            }
            
            this.coinImage.enabled = (this.purchaseResultType == 0) ? 1 : 0;
            this.bundleImage.enabled = (this.purchaseResultType == 1) ? 1 : 0;
        }
        private void PrepareMessage(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            if(status > 4)
            {
                    return;
            }
            
            var val_2 = 36587760 + (status) << 2;
            val_2 = val_2 + 36587760;
            goto (36587760 + (status) << 2 + 36587760);
        }
        private void PrepareTitle(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            if(status <= 4)
            {
                    var val_2 = 36587740 + (status) << 2;
                val_2 = val_2 + 36587740;
            }
            else
            {
                    this.ArrangeTitle(status:  status);
            }
        
        }
        private void ArrangeTitle(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve val_1;
            float val_2;
            if((status == 3) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman != false))
            {
                    this.title.enableAutoSizing = false;
                this.title.fontSize = 10.25f;
                val_1 = this.titleCurve;
                val_2 = 3f;
            }
            else
            {
                    if(status != 0)
            {
                    return;
            }
            
                if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return;
            }
            
                this.title.enableAutoSizing = false;
                this.title.fontSize = 4.6f;
                val_1 = this.titleCurve;
                val_2 = 5f;
            }
            
            val_1 = val_2;
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
        public BuyCoinsResultDialog()
        {
        
        }
    
    }

}
