using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class ShopMenuBundlePackageView : ShopMenuPackageView
    {
        // Fields
        public UnityEngine.GameObject boosterPack;
        public Royal.Scenes.Home.Ui.Sections.Shop.Package.AlternativeBoosterPackView alternativeBoosterPack;
        public UnityEngine.GameObject unlimitedLivesPack;
        public UnityEngine.Transform heart;
        public TMPro.TextMeshPro priceText;
        public TMPro.TextMeshPro coinAmountText;
        public UnityEngine.GameObject inGameBoosterContainer;
        public UnityEngine.GameObject prelevelBoosterContainer;
        public TMPro.TextMeshPro hammerCountText;
        public TMPro.TextMeshPro cannonCountText;
        public TMPro.TextMeshPro arrowCountText;
        public TMPro.TextMeshPro jesterHatCountText;
        public TMPro.TextMeshPro lightballCountText;
        public TMPro.TextMeshPro tntCountText;
        public TMPro.TextMeshPro rocketCountText;
        public UnityEngine.Transform hammerXSign;
        public UnityEngine.Transform cannonXSign;
        public UnityEngine.Transform arrowXSign;
        public UnityEngine.Transform jesterHatXSign;
        public UnityEngine.Transform lightballXSign;
        public UnityEngine.Transform tntXSign;
        public UnityEngine.Transform rocketXSign;
        public TMPro.TextMeshPro unlimitedLivesLimitText;
        public TMPro.TextMeshPro bundleName;
        public UnityEngine.GameObject[] defaultBackgrounds;
        public UnityEngine.GameObject[] specialOfferBackgrounds;
        public UnityEngine.Material specialOfferTextMaterial;
        public UnityEngine.SpriteRenderer sunBurst;
        public UnityEngine.Sprite[] coinSprites;
        public UnityEngine.SpriteRenderer coinIcon;
        public TMPro.TextMeshPro ribbonText;
        public UnityEngine.GameObject ribbonObject;
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
            int val_22;
            float val_23;
            TMPro.TextMeshPro val_24;
            float val_25;
            float val_26;
            float val_27;
            TMPro.TextMeshPro val_29;
            var val_30;
            var val_23 = 0;
            label_9:
            if(val_23 >= this.specialOfferBackgrounds.Length)
            {
                goto label_6;
            }
            
            this.specialOfferBackgrounds[val_23].SetActive(value:  (data != 0) ? 1 : 0);
            val_23 = val_23 + 1;
            if(this.specialOfferBackgrounds != null)
            {
                goto label_9;
            }
            
            label_6:
            var val_25 = 0;
            label_15:
            if(val_25 >= this.defaultBackgrounds.Length)
            {
                goto label_12;
            }
            
            this.defaultBackgrounds[val_25].SetActive(value:  (data == 0) ? 1 : 0);
            val_25 = val_25 + 1;
            if(this.defaultBackgrounds != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_12:
            if(data != null)
            {
                    this.bundleName.fontSharedMaterial = this.specialOfferTextMaterial;
                val_23 = 0f;
                val_24 = this.bundleName;
                this.sunBurst.color = new UnityEngine.Color() {r = 0f, g = 0f, b = val_23, a = 0f};
            }
            else
            {
                    val_23 = 0f;
                this.sunBurst.color = new UnityEngine.Color() {r = 0f, g = 0f, b = val_23, a = 0f};
                val_24 = this.bundleName;
            }
            
            val_25 = 27f;
            mem[this.bundleName].fontSize = ((X22 + 16) > 18) ? (val_25) : 30f;
            this.priceText.text = X25;
            this.coinAmountText.text = Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuPackageView.GetCoinAmountTextInFormat(coinAmount:  this.boosterPack);
            this.PrepareAssetsByCoinAmount(coinAmount:  this.boosterPack);
            if(this.prelevelBoosterContainer != 0)
            {
                    this.ribbonObject.SetActive(value:  true);
                this.ribbonText.text = this.prelevelBoosterContainer;
            }
            
            if(((this.unlimitedLivesPack <= 0) && (this.alternativeBoosterPack <= 0)) && (W27 < 1))
            {
                    this.inGameBoosterContainer.SetActive(value:  false);
                UnityEngine.Transform val_5 = this.prelevelBoosterContainer.transform;
                UnityEngine.Vector3 val_6 = val_5.localPosition;
                val_27 = val_6.x;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.5f);
                val_26 = val_27;
                val_25 = val_6.y;
                val_23 = val_6.z;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26, y = val_25, z = val_23}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                val_5.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            }
            else
            {
                    val_22 = W27;
                this.ribbonText.PrepareBooster(boosterText:  this.hammerCountText, boosterCount:  typeof(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuBundlePackageView).__il2cppRuntimeField_190, xSign:  this.hammerXSign);
                this.ribbonText.PrepareBooster(boosterText:  this.cannonCountText, boosterCount:  this.alternativeBoosterPack, xSign:  this.cannonXSign);
                this.ribbonText.PrepareBooster(boosterText:  this.arrowCountText, boosterCount:  val_22, xSign:  this.arrowXSign);
                this.ribbonText.PrepareBooster(boosterText:  this.jesterHatCountText, boosterCount:  this.unlimitedLivesPack, xSign:  this.jesterHatXSign);
            }
            
            this.ArrangePrelevelBoosters(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct() {priceText = X25, priceString = ???, price = ???}, isBundlePackage = false, isSpecialOffer = false, title = 1, coins = ???, hammerAmount = ???, cannonAmount = this.boosterPack, arrowAmount = typeof(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopMenuBundlePackageView).__il2cppRuntimeField_190, jesterHatAmount = this.alternativeBoosterPack, rocketAmount = val_22, rocketMinutes = this.unlimitedLivesPack, tntAmount = this.unlimitedLivesPack, tntMinutes = this.heart, lightballAmount = this.heart, lightballMinutes = this.priceText, lifetime = this.priceText, isSpecialItemAlternative = this.coinAmountText, ribbonText = this.inGameBoosterContainer, isRoyalPassPackage = this.prelevelBoosterContainer});
            if(W26 == 0)
            {
                goto label_39;
            }
            
            if(((this.heart > 0) || (this.coinAmountText > 0)) || (this.priceText > 0))
            {
                goto label_42;
            }
            
            val_29 = this.unlimitedLivesLimitText;
            goto label_43;
            label_39:
            this.unlimitedLivesPack.SetActive(value:  false);
            UnityEngine.Transform val_10 = this.boosterPack.transform;
            val_30 = val_10;
            UnityEngine.Vector3 val_11 = val_10.position;
            val_27 = val_11.x;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  0.8f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_30.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            return;
            label_42:
            UnityEngine.Vector3 val_16 = this.heart.transform.localPosition;
            this.heart.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = 0.145f, z = val_16.z};
            val_29 = this.unlimitedLivesLimitText;
            this.unlimitedLivesLimitText.fontSizeMax = 4.8f;
            UnityEngine.Vector3 val_19 = mem[this.unlimitedLivesLimitText].transform.localPosition;
            val_27 = val_19.x;
            UnityEngine.Transform val_20 = mem[this.unlimitedLivesLimitText].transform;
            val_20.localPosition = new UnityEngine.Vector3() {x = val_27, y = -1.4f, z = val_19.z};
            label_43:
            val_30 = mem[this.unlimitedLivesLimitText];
            string val_21 = val_20.GetLocalizedTimeText(lifeTime:  W26);
        }
        private void ArrangePrelevelBoosters(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            if(((config.tntMinutes <= 0) && (config.lightballMinutes <= 0)) && (config.isSpecialItemAlternative < true))
            {
                    this.PrepareBooster(boosterText:  this.lightballCountText, boosterCount:  config.lifetime, xSign:  this.lightballXSign);
                this.PrepareBooster(boosterText:  this.tntCountText, boosterCount:  config.lightballAmount, xSign:  this.tntXSign);
                this.PrepareBooster(boosterText:  this.rocketCountText, boosterCount:  config.tntAmount, xSign:  this.rocketXSign);
                return;
            }
            
            this.boosterPack.SetActive(value:  false);
            this.alternativeBoosterPack.Prepare(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
        }
        private void PrepareAssetsByCoinAmount(int coinAmount)
        {
            this.coinIcon.sprite = this.coinSprites[Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig.GetCoinSpriteIndex(coinAmount:  coinAmount)];
        }
        private void PrepareBooster(TMPro.TextMeshPro boosterText, int boosterCount, UnityEngine.Transform xSign)
        {
            int val_12 = boosterCount;
            if(val_12 >= 10)
            {
                    boosterText.fontSize = 4f;
                UnityEngine.Transform val_1 = boosterText.transform;
                val_12 = val_1;
                UnityEngine.Vector3 val_2 = val_1.localPosition;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.15f);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                val_12.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = xSign.localPosition;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.15f);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                xSign.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
                string val_10 = boosterCount.ToString();
            }
            
            boosterText.text = boosterCount.ToString();
        }
        private string GetLocalizedTimeText(int lifeTime)
        {
            int val_4;
            object val_5;
            object val_6;
            val_4 = lifeTime;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    val_5 = val_4;
                val_6 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h");
                return (string)val_4 + val_5;
            }
            
            val_4 = val_4;
            val_5 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h");
            val_6 = val_4;
            return (string)val_4 + val_5;
        }
        private bool HasInGameBoosters(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            if(config.arrowAmount > 0)
            {
                    return true;
            }
            
            if(config.jesterHatAmount > 0)
            {
                    return true;
            }
            
            if(config.rocketAmount <= 0)
            {
                    return (bool)(config.rocketMinutes > 0) ? 1 : 0;
            }
            
            return true;
        }
        private bool HasPrelevelBoosters(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            if(config.tntAmount > 0)
            {
                    return true;
            }
            
            if(config.lightballAmount <= 0)
            {
                    return (bool)(config.lifetime > 0) ? 1 : 0;
            }
            
            return true;
        }
        private bool HasUnlimitedPrelevelBoosters(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            if(config.isSpecialItemAlternative > false)
            {
                    return true;
            }
            
            if(config.lightballMinutes <= 0)
            {
                    return (bool)(config.tntMinutes > 0) ? 1 : 0;
            }
            
            return true;
        }
        public ShopMenuBundlePackageView()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Scroll.Content.UiScrollCustomContentItem();
        }
    
    }

}
