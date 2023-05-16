using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class ShopPopupView : UiPopup, IBackable
    {
        // Fields
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer headerBackground;
        public UnityEngine.BoxCollider2D headerBackgroundBoxCollider2D;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        public UnityEngine.Transform[] headerTransforms;
        public TMPro.TextMeshPro[] titleTexts;
        public bool moreOffersClicked;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView shopScrollView;
        private Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        private float awakeTime;
        
        // Methods
        protected void Awake()
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.PrepareHeader();
            this.ArrangeTitle();
            this.coinInfoView.transform.position = new UnityEngine.Vector3() {x = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel.coinInfoViewPosition, y = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel.coinInfoViewPosition.__il2cppRuntimeField_4, z = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel.coinInfoViewPosition.__il2cppRuntimeField_8};
            this.shopScrollView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView>(path:  "ShopScroll"), parent:  this.transform);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetShopUiSorting();
            this.shopScrollView.GetComponent<UnityEngine.Rendering.SortingGroup>().sortingLayerID = val_9.layer;
            this.shopScrollView.GetComponent<UnityEngine.Rendering.SortingGroup>().sortingOrder = val_9.layer >> 32;
            UnityEngine.Vector3 val_14 = this.header.transform.position;
            float val_26 = val_14.y;
            UnityEngine.Bounds val_15 = this.headerBackground.bounds;
            float val_25 = val_14.y;
            UnityEngine.Vector3 val_18 = this.camManager.GetBottomCenterOfCamera();
            val_25 = val_26 - val_25;
            val_26 = val_25 - val_18.y;
            this.shopScrollView.SetSize(width:  this.camManager.cameraWidth, height:  val_26);
            float val_27 = -0.5f;
            val_27 = val_26 * val_27;
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  0f, y:  val_25 + val_27);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            this.shopScrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager val_23 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            if((val_23.<CurrentScene>k__BackingField) == 1)
            {
                goto label_28;
            }
            
            if((val_23.<CurrentScene>k__BackingField) != 2)
            {
                goto label_31;
            }
            
            goto label_31;
            label_28:
            label_31:
            this.awakeTime = UnityEngine.Time.time;
            this.moreOffersClicked = false;
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return;
            }
            
            var val_4 = 4;
            do
            {
                if((val_4 - 4) >= this.titleTexts.Length)
            {
                    return;
            }
            
                this.titleTexts[0].enableAutoSizing = false;
                this.titleTexts[0].fontSize = 6.75f;
                val_4 = val_4 + 1;
            }
            while(this.titleTexts != null);
            
            throw new NullReferenceException();
        }
        public void SetStrategy(Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy strategy)
        {
            this.purchaseStrategy = strategy;
            this.shopScrollView.PrepareContent(strategy:  strategy, filterCoin:  (strategy - Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name)>>0&0xFFFFFFFF, shopPopupView:  this);
            if((strategy & 1) != 0)
            {
                    return;
            }
            
            this.coinInfoView.UnregisterFromCoinUpdates();
        }
        private void PrepareHeader()
        {
            float val_20;
            var val_21;
            if(this.camManager.IsDeviceWide() != false)
            {
                    UnityEngine.Vector2 val_2 = this.headerBackground.size;
                val_20 = val_2.x;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  4f);
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_20, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.headerBackground.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
                UnityEngine.Vector2 val_6 = this.headerBackground.size;
                this.headerBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            }
            
            if(this.camManager.IsDeviceTall() == true)
            {
                goto label_17;
            }
            
            UnityEngine.Vector2 val_8 = this.headerBackground.size;
            UnityEngine.Vector2 val_9 = this.headerBackground.size;
            val_9.y = val_9.y * 0.75f;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.headerBackground.size = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            UnityEngine.Vector2 val_11 = this.headerBackground.size;
            this.headerBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            val_20 = 0.6f;
            val_21 = 0;
            label_26:
            if(val_21 >= this.headerTransforms.Length)
            {
                goto label_17;
            }
            
            UnityEngine.Transform val_20 = this.headerTransforms[val_21];
            UnityEngine.Vector3 val_12 = val_20.localPosition;
            if(val_21 != 0)
            {
                    UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            }
            else
            {
                    UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  val_20);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_20.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            val_21 = val_21 + 1;
            if(this.headerTransforms != null)
            {
                goto label_26;
            }
            
            throw new NullReferenceException();
            label_17:
            UnityEngine.Vector3 val_19 = this.transform.position;
            float val_21 = 0.5f;
            val_21 = this.camManager.cameraHeight * val_21;
            this.header.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void Close()
        {
            this.Hide();
        }
        public void Hide()
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_6;
            Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            if((val_1.<CurrentScene>k__BackingField) == 1)
            {
                goto label_4;
            }
            
            if((val_1.<CurrentScene>k__BackingField) != 2)
            {
                goto label_5;
            }
            
            val_6 = this;
            goto label_9;
            label_4:
            val_6 = this;
            goto label_9;
            label_5:
            val_6 = this.uiTouchListener;
            label_9:
            var val_2 = mem[this.uiTouchListener] + 64;
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 - this.awakeTime;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).ShopOpen(timeSpent:  (int)val_3, moreOffersClicked:  (this.moreOffersClicked == true) ? 1 : 0, purchaseType:  this.purchaseStrategy.trigger);
            this.Destroy();
        }
        public void PressBack()
        {
            this.Close();
        }
        public ShopPopupView()
        {
        
        }
    
    }

}
