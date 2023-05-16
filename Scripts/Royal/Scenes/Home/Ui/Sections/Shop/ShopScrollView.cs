using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop
{
    public class ShopScrollView : MonoBehaviour
    {
        // Fields
        private Royal.Scenes.Home.Ui.Sections.Shop.ShopPopupView shopPopupView;
        public Royal.Scenes.Home.Ui.Sections.Shop.ShopUiScrollContent content;
        public UnityEngine.BoxCollider2D boxCollider;
        public Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        private int filterCoin;
        
        // Methods
        public void PrepareContent(Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy strategy, int filterCoin, Royal.Scenes.Home.Ui.Sections.Shop.ShopPopupView shopPopupView)
        {
            int val_20;
            var val_21;
            val_20 = filterCoin;
            this.purchaseStrategy = strategy;
            this.shopPopupView = shopPopupView;
            this.filterCoin = val_20;
            val_21 = 1152921505124790272;
            this.content = -1102263091;
            this.content = -1082130432;
            int val_19 = val_5.Length;
            if(val_19 >= 1)
            {
                    var val_24 = 0;
                val_19 = val_19 & 4294967295;
                do
            {
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_23 = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetOffers(filterCoin:  val_20, highestBoughtBundle:  GetHighestBoughtBundle & 255, highestBoughtSinglePackage:  GetHighestBoughtSinglePackage & 255)[80];
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView val_12 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(original:  (val_23 == 0) ? ((null == null) ? UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(path:  "ShopMenuSinglePackage") : UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(path:  "ShopMenuBundlePackage")) : UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(path:  "ShopMenuRoyalPassPackage"), parent:  this.content.transform);
                var val_13 = (val_23 == 0) ? 1 : 0;
                val_12 = null;
                val_12 = 36529888 + val_5[80] == null ? 1 : 0;
                val_12 = shopPopupView;
                .config = new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig();
                mem[1152921519029823104] = null;
                mem[1152921519029823096] = null;
                mem[1152921519029823080] = null;
                mem[1152921519029823064] = null;
                mem[1152921519029823184] = val_23;
                .shopScrollView = this;
                mem[1152921519029823191] = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetOffers(filterCoin:  val_20, highestBoughtBundle:  GetHighestBoughtBundle & 255, highestBoughtSinglePackage:  GetHighestBoughtSinglePackage & 255)[80];
                mem[1152921519029823189] = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetOffers(filterCoin:  val_20, highestBoughtBundle:  GetHighestBoughtBundle & 255, highestBoughtSinglePackage:  GetHighestBoughtSinglePackage & 255)[80];
                mem[1152921519029823185] = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetOffers(filterCoin:  val_20, highestBoughtBundle:  GetHighestBoughtBundle & 255, highestBoughtSinglePackage:  GetHighestBoughtSinglePackage & 255)[80];
                this.content.AddData(item:  val_12, data:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData());
                bool val_15 = UnityEngine.Object.op_Equality(x:  val_12, y:  0);
                if(val_15 != true)
            {
                    val_15.AnimateItem(item:  val_12, order:  0, delay:  0f);
            }
            
                val_24 = val_24 + 1;
            }
            while(val_24 < (val_5.Length << ));
            
            }
            
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuMoreOffersView val_18 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuMoreOffersView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuMoreOffersView>(path:  "ShopMoreOffers"), parent:  this.content.transform);
            val_18 = this;
            this.content.AddItemWithoutData(item:  val_18);
            this.content.AnimateItem(item:  val_18, order:  val_5.Length, delay:  0f);
        }
        private float GetItemSpacing(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig package)
        {
            var val_1 = (mem[1152921519029988528] == false) ? 1 : 0;
            return (float)36529888 + mem[1152921519029988528] == false ? 1 : 0;
        }
        private void AnimateItem(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollContentItem item, int order, float delay = 0)
        {
            .item = item;
            UnityEngine.Transform val_2 = item.transform;
            float val_16 = 0.3f;
            UnityEngine.Vector3 val_5 = val_2.localPosition;
            float val_15 = 5f;
            val_15 = val_5.x + val_15;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_15, y:  val_5.y);
            val_16 = (((float)order + 1) * 0.07f) + val_16;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_2.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_8, delay:  delay);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_8, callback:  new DG.Tweening.TweenCallback(object:  new ShopScrollView.<>c__DisplayClass7_0(), method:  System.Void ShopScrollView.<>c__DisplayClass7_0::<AnimateItem>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMoveX(target:  val_2, endValue:  val_5.x, duration:  val_16, snapping:  false), ease:  27));
        }
        public void SetSize(float width, float height)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  width, y:  height);
            this.boxCollider.size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public void OnComplete(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus val_1 = status;
            if(status == 3)
            {
                    this.shopPopupView.Hide();
                return;
            }
        
        }
        public void ShowMoreOffers()
        {
            Royal.Scenes.Home.Ui.Sections.Shop.ShopScrollView val_24;
            var val_25;
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig[] val_26;
            object val_27;
            Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView val_28;
            val_24 = this;
            this.shopPopupView = 1;
            System.Collections.Generic.List<System.Type> val_1 = new System.Collections.Generic.List<System.Type>();
            val_1.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.content.ClearSpecificPrefabs(types:  val_1);
            this.content.items.Clear();
            this.content.Size = 0f;
            val_26 = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.FilteredAndSortedPackages(filterCoin:  this.filterCoin, highestBoughtBundle:  GetHighestBoughtBundle & 255, highestBoughtSinglePackage:  GetHighestBoughtSinglePackage & 255);
            if(val_9.Length >= 1)
            {
                    val_25 = 1152921505027506176;
                var val_26 = 0;
                do
            {
                ShopScrollView.<>c__DisplayClass10_0 val_13 = null;
                val_27 = val_13;
                val_13 = new ShopScrollView.<>c__DisplayClass10_0();
                var val_24 = val_26[32];
                Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem val_15 = System.Linq.Enumerable.FirstOrDefault<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem>(source:  new System.Collections.Generic.List<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem>(collection:  this.content.items), predicate:  new System.Func<Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem, System.Boolean>(object:  val_13, method:  System.Boolean ShopScrollView.<>c__DisplayClass10_0::<ShowMoreOffers>b__0(Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem d)));
                if(val_15 != 0)
            {
                    this.content.PutItemNextPosition(item:  val_15);
            }
            else
            {
                    val_28 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(path:  "ShopMenuRoyalPassPackage");
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView val_19 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(original:  (null == 0) ? UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(path:  "ShopMenuSinglePackage") : UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView>(path:  "ShopMenuBundlePackage"), parent:  this.content.transform);
                Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem val_25 = val_19;
                val_19 = (ShopScrollView.<>c__DisplayClass10_0)[1152921519030877056].package.purchaseProduct;
                val_24 = val_24;
                val_19.gameObject.SetActive(value:  false);
                var val_21 = (((ShopScrollView.<>c__DisplayClass10_0)[1152921519030877056].package.purchaseProduct) == 0) ? 1 : 0;
                val_25 = 36529888 + (ShopScrollView.<>c__DisplayClass10_0)[1152921519030877056].package.purchaseProduct == null ? 1 : 0;
                val_27 = this.content;
                .shopScrollView = val_24;
                val_26 = val_26;
                val_27.AddData(item:  val_25, data:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageRowData());
                bool val_23 = UnityEngine.Object.op_Equality(x:  val_25, y:  0);
                if(val_23 != true)
            {
                    float val_27 = 0.1f;
                val_23.AnimateItem(item:  val_25, order:  0, delay:  0.1f);
            }
            
            }
            
                val_26 = val_26 + 1;
            }
            while(val_26 < (val_9 + 24));
            
            }
            
            val_27 = val_27 + 1.5f;
            this.content.Size = val_27;
        }
        public ShopScrollView()
        {
        
        }
    
    }

}
