using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferPackageView : UiScrollCustomContentItem
    {
        // Fields
        private static readonly int UnlockAnimation;
        public UnityEngine.GameObject[] backgrounds;
        public UnityEngine.GameObject[] buttonBorders;
        public UnityEngine.GameObject[] rewardItems2;
        public UnityEngine.GameObject[] rewardItems3;
        public UnityEngine.GameObject buyButton;
        public TMPro.TextMeshPro availableCountText;
        public TMPro.TextMeshPro availableText;
        public TMPro.TextMeshPro priceText;
        public UnityEngine.GameObject checkVisual;
        public UnityEngine.ParticleSystem checkParticles;
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPopupView ladderOfferPopupView;
        public UnityEngine.Transform lockPositioner;
        public UnityEngine.GameObject lockParent;
        public UnityEngine.Animator lockAnimator;
        public UnityEngine.SpriteRenderer[] lockSprites;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseManager purchaseManager;
        private Royal.Scenes.Start.Context.Units.Loading.LoadingManager loadingManager;
        private Royal.Player.Context.Units.LadderOfferManager ladderOfferManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRowData ladderOfferRowData;
        private Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus purchaseStatus;
        private Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config;
        private Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPurchaseStrategy purchaseStrategy;
        
        // Methods
        private void Awake()
        {
            Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
            this.purchaseManager = val_1.purchaseManager;
            this.loadingManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Loading.LoadingManager>(id:  21);
            this.ladderOfferManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData val_3 = data;
            if(val_3 != null)
            {
                    this.ladderOfferRowData = val_3;
                if(21591 == 0)
            {
                    throw new NullReferenceException();
            }
            
                Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig val_1 = 21591.CreateShopConfig();
                if(this.ladderOfferRowData == null)
            {
                    throw new NullReferenceException();
            }
            
                val_3 = this.ladderOfferRowData.ladderOfferStep;
                this.purchaseStrategy = new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPurchaseStrategy(step:  val_3);
                this.PreparePriceAndAvailabilityTexts();
                if(this.ladderOfferRowData == null)
            {
                    throw new NullReferenceException();
            }
            
                if(this.ladderOfferRowData.ladderOfferStep == null)
            {
                    throw new NullReferenceException();
            }
            
                this.PrepareBackground(backgroundColorIndex:  this.ladderOfferRowData.ladderOfferStep.backgroundColorIndex);
                this.PrepareLockImages();
                this.PrepareRewardItems();
                return;
            }
            
            this.ladderOfferRowData = val_3;
            throw new NullReferenceException();
        }
        private void PreparePriceAndAvailabilityTexts()
        {
            Royal.Player.Context.Data.Persistent.LadderOfferProgress val_1 = GetLadderOffer();
            if(S0 > 0f)
            {
                    this.priceText.isRightToLeftText = false;
                this.priceText.text = this.priceText.Replace(oldValue:  " ", newValue:  "");
            }
            
            int val_4 = this.ladderOfferRowData.ladderOfferStep.a;
            val_4 = val_4 - val_1.availability;
            this.availableCountText.text = val_4 + "/"("/") + this.ladderOfferRowData.ladderOfferStep.a;
        }
        private void PrepareRewardItems()
        {
            string val_15;
            var val_16;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep val_29;
            var val_30;
            var val_31;
            val_29 = 21590;
            if(this.ladderOfferRowData == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = this.ladderOfferRowData.ladderOfferStep;
            if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = val_29.GetPrefabNamesAndRewardTexts();
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.KeyCollection<TKey, TValue> val_2 = val_1.Keys;
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            int val_3 = val_2.Count;
            if(this.rewardItems2 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(this.rewardItems2.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_29 = this.rewardItems2[0];
            if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_4 = val_29.transform;
            if(val_4 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_5 = val_4.parent;
            if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_6 = val_5.gameObject;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_3 == 2)
            {
                    val_6.SetActive(value:  true);
                if(this.rewardItems3 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(this.rewardItems3.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_29 = this.rewardItems3[0];
                if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.Transform val_7 = val_29.transform;
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.Transform val_8 = val_7.parent;
                if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_8.gameObject == null)
            {
                    throw new NullReferenceException();
            }
            
                val_30 = 0;
            }
            else
            {
                    val_6.SetActive(value:  false);
                if(this.rewardItems3 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(this.rewardItems3.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_29 = this.rewardItems3[0];
                if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.Transform val_10 = val_29.transform;
                if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.Transform val_11 = val_10.parent;
                if(val_11 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.GameObject val_12 = val_11.gameObject;
                if(val_12 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_30 = 1;
            }
            
            val_12.SetActive(value:  true);
            Dictionary.KeyCollection<TKey, TValue> val_13 = val_1.Keys;
            if(val_13 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_14 = val_13.GetEnumerator();
            var val_29 = 0;
            label_48:
            if((1922882016 & 1) == 0)
            {
                goto label_26;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardView val_18 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardView>(path:  val_15);
            if(val_18 == 0)
            {
                goto label_48;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardView val_28 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRewardView>(original:  val_18);
            if(val_28 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_29 = val_28;
            val_29.SetItemAmountText(text:  val_1.Item[val_15]);
            if(this.ladderOfferRowData == null)
            {
                    throw new NullReferenceException();
            }
            
            val_28 = this.ladderOfferRowData.ladderOfferStep;
            if(val_3 == 1)
            {
                    UnityEngine.Transform val_22 = val_28.transform;
                if(this.rewardItems3 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(this.rewardItems3.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
                val_29 = this.rewardItems3[1];
                if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_22 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_22.SetParent(p:  val_29.transform);
            }
            else
            {
                    if((val_3 & 4294967294) == 2)
            {
                    val_31 = 0;
                if(this.rewardItems3 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_29 = this.rewardItems3[val_29];
                if(val_29 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_28.transform.SetParent(p:  val_29.transform);
                val_29 = val_29 + 1;
            }
            
            }
            
            UnityEngine.Transform val_26 = val_28.transform;
            val_29 = 0;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.zero;
            if(val_26 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_26.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            goto label_48;
            label_26:
            val_16.Dispose();
        }
        public void PrepareBackground(int backgroundColorIndex)
        {
            var val_1;
            var val_4 = 0;
            do
            {
                if(val_4 >= this.backgrounds.Length)
            {
                    return;
            }
            
                UnityEngine.GameObject val_1 = this.backgrounds[val_4];
                if(backgroundColorIndex == val_4)
            {
                    val_1.SetActive(value:  true);
                UnityEngine.GameObject val_2 = this.buttonBorders[val_4];
                val_1 = 1;
            }
            else
            {
                    val_1.SetActive(value:  false);
                val_1 = 0;
            }
            
                this.buttonBorders[val_4].SetActive(value:  false);
                val_4 = val_4 + 1;
            }
            while(this.backgrounds != null);
            
            throw new NullReferenceException();
        }
        private void SetButtonSilence()
        {
            this.buyButton.GetComponentInChildren<Royal.Infrastructure.UiComponents.Button.UiBasicButton>() = this.ladderOfferRowData.ladderOfferStep.isLocked;
        }
        private void PrepareLockImages()
        {
            this.SetButtonSilence();
            this.lockParent.SetActive(value:  this.ladderOfferRowData.ladderOfferStep.isLocked);
            if(this.ladderOfferRowData.ladderOfferStep.isChecked == false)
            {
                    return;
            }
            
            this.Check();
        }
        public void Unlock(bool hideLockParent)
        {
            if(hideLockParent != false)
            {
                    this.lockParent.SetActive(value:  false);
            }
            
            this.ladderOfferRowData.ladderOfferStep = 0;
            this.SetButtonSilence();
        }
        public void Check()
        {
            this.buyButton.SetActive(value:  false);
            this.checkVisual.SetActive(value:  true);
        }
        public void PlayCheckAnimation()
        {
            this.checkVisual.SetActive(value:  true);
            UnityEngine.Transform val_1 = this.checkVisual.transform;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_1.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.1f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f)), ease:  9));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_4, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView::<PlayCheckAnimation>b__34_0()));
        }
        public void PlayOpenLockAnimationDelayed()
        {
            this.Invoke(methodName:  "PlayOpenLockAnimation", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  17f));
        }
        private void PlayOpenLockAnimation()
        {
            var val_9;
            var val_12 = 4;
            label_6:
            if((val_12 - 4) >= (this.lockSprites.Length << ))
            {
                goto label_2;
            }
            
            val_9 = null;
            val_9 = null;
            var val_2 = val_12 + 1996;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.lockSprites[0], data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
            val_12 = val_12 + 1;
            if(this.lockSprites != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            this.lockPositioner.SetParent(p:  this.transform.parent);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles val_7 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassGoldRewardOpenLockParticles>(path:  "RoyalPassGoldRewardOpenLockParticles"), parent:  this.transform);
            UnityEngine.Vector3 val_10 = this.lockParent.transform.position;
            val_7.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_7.PlayAndDestroy();
            this.lockAnimator.enabled = true;
            this.lockAnimator.Play(stateNameHash:  Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView.UnlockAnimation, layer:  0, normalizedTime:  0f);
            this.audioManager.PlaySound(type:  146, offset:  0.04f);
        }
        public DG.Tweening.Tween PlayAvailabilityTextDisappearAnimation()
        {
            LadderOfferPackageView.<>c__DisplayClass37_0 val_1 = new LadderOfferPackageView.<>c__DisplayClass37_0();
            .<>4__this = this;
            .alpha = 0;
            return DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 LadderOfferPackageView.<>c__DisplayClass37_0::<PlayAvailabilityTextDisappearAnimation>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void LadderOfferPackageView.<>c__DisplayClass37_0::<PlayAvailabilityTextDisappearAnimation>b__1(int x)), endValue:  255, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f)), delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f));
        }
        public DG.Tweening.Tween PlayBackgroundColorChangeAnimation()
        {
            LadderOfferPackageView.<>c__DisplayClass38_0 val_1 = new LadderOfferPackageView.<>c__DisplayClass38_0();
            .yellowBackgroundParts = this.backgrounds[0].GetComponentsInChildren<UnityEngine.SpriteRenderer>();
            .yellowBuyButtonBorder = this.buttonBorders[0].GetComponent<UnityEngine.SpriteRenderer>();
            .alpha = 0;
            var val_13 = 4;
            label_14:
            if((val_13 - 4) >= ((LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].yellowBackgroundParts.Length))
            {
                goto label_9;
            }
            
            float val_11 = (float)(LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].alpha;
            val_11 = val_11 / 255f;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  (LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].yellowBackgroundParts[0], alpha:  val_11);
            (LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].yellowBackgroundParts[0].sortingOrder = 3;
            val_13 = val_13 + 1;
            if(((LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].yellowBackgroundParts) != null)
            {
                goto label_14;
            }
            
            label_9:
            float val_14 = (float)(LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].alpha;
            val_14 = val_14 / 255f;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  (LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].yellowBuyButtonBorder, alpha:  val_14);
            (LadderOfferPackageView.<>c__DisplayClass38_0)[1152921519417260464].yellowBuyButtonBorder.sortingOrder = 5;
            this.backgrounds[0].SetActive(value:  true);
            this.buttonBorders[0].SetActive(value:  true);
            return DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 LadderOfferPackageView.<>c__DisplayClass38_0::<PlayBackgroundColorChangeAnimation>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void LadderOfferPackageView.<>c__DisplayClass38_0::<PlayBackgroundColorChangeAnimation>b__1(int x)), endValue:  255, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  30f));
        }
        public void ChangeBackgroundColorToPurple()
        {
            this.backgrounds[1].SetActive(value:  true);
            this.backgrounds[2].SetActive(value:  false);
            this.buttonBorders[1].SetActive(value:  true);
            this.buttonBorders[2].SetActive(value:  false);
        }
        private void PlayPackageLockedAnimation()
        {
            UnityEngine.Transform val_1 = this.lockParent.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  0.9f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            float val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  val_3, mode:  0));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView::<PlayPackageLockedAnimation>b__40_0()));
            float val_12 = val_3 + val_3;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_12, mode:  0));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_12, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  -1f, a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  val_12, mode:  0));
            float val_36 = 3f;
            val_36 = val_3 * val_36;
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_36, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
            float val_37 = 4f;
            val_37 = val_3 * val_37;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_37, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_12, mode:  0));
            float val_38 = 5f;
            val_38 = val_3 * val_38;
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_38, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
            float val_39 = 6f;
            val_39 = val_3 * val_39;
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_39, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  val_3));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.ShortcutExtensions.DORotate(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3, mode:  0));
            float val_40 = 7f;
            val_40 = val_3 * val_40;
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  val_40, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  val_3));
        }
        public void TryBuy()
        {
            if(this.ladderOfferManager.isBuyAnimationsPlaying != false)
            {
                    return;
            }
            
            if(this.ladderOfferRowData.ladderOfferStep.isLocked != false)
            {
                    this.PlayPackageLockedAnimation();
                Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "LadderOfferTooltip"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
                return;
            }
            
            if(S0 > 0f)
            {
                    this.flowManager.Push(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), action:  new Royal.Scenes.Home.Ui.Dialogs.NoConnection.InternetConnectionAction(shouldCheckMaintenance:  false, onInternetConnection:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView::Buy()), onComplete:  0));
                return;
            }
            
            this.BuyFree();
        }
        private void BuyFree()
        {
            this.flowManager.StartNextActionMode();
            this.ladderOfferRowData.ladderOfferScrollView.content.PlayHideAnimation();
            this.ladderOfferManager.IncrementStepAndAvailability();
            Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  Royal.Player.Context.Data.InventoryPackage.GetLadderOfferPackage(step:  this.ladderOfferRowData.ladderOfferStep));
            this.purchaseStrategy.PlayCollectAnimation(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false});
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            .<Type>k__BackingField = 0;
            .enableTouches = true;
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Actions.ShowLadderOfferPopupViewAction());
            this.flowManager.FinishNextActionMode();
        }
        private void Buy()
        {
            this.purchaseStatus = 0;
            this.loadingManager.ShowShopLoading();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.StartPurchaseAfterDelay());
        }
        private System.Collections.IEnumerator StartPurchaseAfterDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new LadderOfferPackageView.<StartPurchaseAfterDelay>d__44();
        }
        private System.Collections.IEnumerator FinishPurchaseAfterDelay(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, bool maintenance)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .status = status;
            .maintenance = maintenance;
            return (System.Collections.IEnumerator)new LadderOfferPackageView.<FinishPurchaseAfterDelay>d__45();
        }
        private void AfterBuyCoinsResultDialogClosed()
        {
            this.flowManager.StartNextActionMode();
            this.OnComplete(status:  this.purchaseStatus);
            this.flowManager.FinishNextActionMode();
        }
        private void OnComplete(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status)
        {
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPurchaseStrategy val_1;
            if(status == 3)
            {
                    this.ladderOfferPopupView.Hide();
                val_1 = this.purchaseStrategy;
                return;
            }
            
            val_1 = status;
            this.purchaseStrategy.OnPurchaseFail(config:  new Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig() {purchaseProduct = new Royal.Infrastructure.Services.Native.Purchase.PurchaseProduct(), isBundlePackage = false, isSpecialOffer = false, isSpecialItemAlternative = false, isRoyalPassPackage = false}, status:  val_1);
        }
        public LadderOfferPackageView()
        {
        
        }
        private static LadderOfferPackageView()
        {
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView.UnlockAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.RoyalPassUnlockAnimation");
        }
        private void <PlayCheckAnimation>b__34_0()
        {
            this.audioManager.PlaySound(type:  254, offset:  0.04f);
            this.checkParticles.Play();
        }
        private void <PlayPackageLockedAnimation>b__40_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  145, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <StartPurchaseAfterDelay>b__44_0(Royal.Infrastructure.Services.Native.Purchase.PurchaseStatus status, long time, bool maintenance)
        {
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.FinishPurchaseAfterDelay(status:  status, maintenance:  maintenance));
        }
    
    }

}
