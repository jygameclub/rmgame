using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.BuyBooster
{
    public class BuyBoosterDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform boosterContainer;
        public TMPro.TextMeshPro infoText;
        public TMPro.TextMeshPro priceText;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        private int price;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private bool shouldReturnOrigin;
        private bool coinClickEnabled;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        private UnityEngine.RectTransform titleRect;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type)
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.boosterType = type;
            this.shouldReturnOrigin = true;
            if((type - 1) <= 6)
            {
                    var val_17 = 36587696 + ((type - 1)) << 2;
                val_17 = val_17 + 36587696;
            }
            else
            {
                    UnityEngine.GameObject val_12 = this.coinInfoView.gameObject;
                if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene) != false)
            {
                    val_12.SetActive(value:  false);
            }
            else
            {
                    val_12.SetActive(value:  true);
                this.coinClickEnabled = true;
                UnityEngine.Vector3 val_14 = this.GetCoinStartPosition();
                this.coinInfoView.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                UnityEngine.Vector3 val_15 = this.GetCoinEndPosition();
                this.coinInfoView.ShowAnimated(finalPosition:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, delaySeconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f));
            }
            
                this.ArrangeTitle();
            }
        
        }
        private void InitBooster(Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterData data)
        {
            this.price = data.price;
            this.priceText.text = this.price.ToString();
            this.infoText.text = data.info;
            if(null == null)
            {
                    Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterView val_4 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  data.name), parent:  this.boosterContainer, instantiateInWorldSpace:  false).GetComponent<Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterView>();
                this.titleCurve = val_4.titleCurve;
                this.titleRect = val_4.titleRect;
                return;
            }
        
        }
        private void ArrangeTitle()
        {
            UnityEngine.RectTransform val_6 = this;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_6 = this.boosterType;
            val_6 = val_6 - 4;
            if(val_6 > 3)
            {
                    return;
            }
            
            var val_7 = 36587724 + ((this.boosterType - 4)) << 2;
            val_7 = val_7 + 36587724;
            goto (36587724 + ((this.boosterType - 4)) << 2 + 36587724);
        }
        public void BuyBooster()
        {
            if((Royal.Player.Context.Units.UserManager.BuyBooster(boosterType:  this.boosterType)) != false)
            {
                    if((Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsPrelevel(boosterType:  this.boosterType)) != false)
            {
                    Toggle(type:  this.boosterType);
            }
            
                this = ???;
            }
            else
            {
                    this = 0;
                .boosterType = val_12 + 76;
                .originType = val_12 + 32;
                .origin = 0;
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BoosterPurchaseStrategy()));
            }
        
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnSwipe = val_4;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            if(this.shouldReturnOrigin == false)
            {
                    return;
            }
            
            this = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(1152921518897325840 == 3)
            {
                goto label_5;
            }
            
            if(1152921518897325840 != 2)
            {
                    return;
            }
            
            label_8:
            this.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  false));
            return;
            label_5:
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction val_3 = new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction(clearBoosterSelectionData:  false);
            if(this != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
        }
        public void OnCoinIconClicked()
        {
            if(this.coinClickEnabled == false)
            {
                    return;
            }
            
            this.coinClickEnabled = false;
            .boosterType = this.boosterType;
            .originType = 1152921518897325840;
            .origin = 1;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BoosterPurchaseStrategy()));
            this = ???;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.BuyBooster.BuyBoosterDialog).__il2cppRuntimeField_250;
        }
        private UnityEngine.Vector3 GetCoinEndPosition()
        {
            float val_3;
            if(this.camManager.IsDeviceWide() != false)
            {
                    val_3 = 7.75f;
            }
            else
            {
                    if(this.camManager.IsDeviceTall() != false)
            {
                    val_3 = 8.25f;
            }
            else
            {
                    val_3 = 8f;
            }
            
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private UnityEngine.Vector3 GetCoinStartPosition()
        {
            float val_3;
            if(this.camManager.IsDeviceWide() != false)
            {
                    val_3 = 7.75f;
            }
            else
            {
                    if(this.camManager.IsDeviceTall() != false)
            {
                    val_3 = 8.25f;
            }
            else
            {
                    val_3 = 8f;
            }
            
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public BuyBoosterDialog()
        {
        
        }
    
    }

}
