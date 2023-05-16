using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class EgoDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform root;
        public UnityEngine.GameObject packagesContainer;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.ExtraWarn extraWarn;
        public TMPro.TextMeshPro priceText;
        public UnityEngine.SpriteRenderer firstSpecialItemForPackage2;
        public UnityEngine.SpriteRenderer firstSpecialItemForPackage3;
        public UnityEngine.SpriteRenderer secondSpecialItemForPackage3;
        public UnityEngine.Transform rootBackground;
        public UnityEngine.SpriteRenderer rootBackgroundSprite;
        public TMPro.TextMeshPro headerText;
        public UnityEngine.Transform egoPackageContainer;
        public UnityEngine.Transform egoPackageBackgroundRoot;
        public UnityEngine.SpriteRenderer egoPackageBackgroundLeft;
        public UnityEngine.SpriteRenderer egoPackageBackgroundRight;
        public UnityEngine.SpriteRenderer egoPackageBackgroundBorder;
        public UnityEngine.Transform bottomPatternTransform;
        public UnityEngine.SpriteRenderer bottomPatternSpriteRenderer;
        public UnityEngine.Transform topPatternTransform;
        public UnityEngine.SpriteRenderer topPatternSpriteRenderer;
        public UnityEngine.Transform leftCornerPattern;
        public UnityEngine.Transform rightCornerPattern;
        public UnityEngine.Transform bottom;
        public UnityEngine.GameObject package1;
        public UnityEngine.GameObject package2;
        public UnityEngine.GameObject package3;
        public UnityEngine.Transform closeButton;
        public TMPro.TextMeshPro infoText;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private UnityEngine.Vector2 rootPositionDiffOnRoyalPass;
        private int lastClickedButton;
        private const int Play = 1;
        private const int Exit = 2;
        private const int Coin = 3;
        private const int RoyalPass = 4;
        private int price;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        private bool didWarnForExtra;
        private bool didWarnForRoyalPassOrMadnessClaim;
        private Royal.Scenes.Game.Levels.Units.Ego.EgoManager egoManager;
        private Royal.Scenes.Game.Ui.Dialogs.LevelFail.RoyalPassEgoDialogFooter royalPassEgoDialogFooter;
        private bool isRoyalPassFooterActive;
        
        // Methods
        private void Awake()
        {
            float val_32;
            int val_35;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            this.egoManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Ego.EgoManager>(contextId:  32);
            if(this.camManager.IsDeviceWide() != false)
            {
                    UnityEngine.Transform val_8 = this.closeButton.transform;
                UnityEngine.Vector3 val_9 = val_8.position;
                val_32 = val_9.x;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_8.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            }
            
            UnityEngine.Vector3 val_12 = this.GetCoinStartPosition();
            this.coinInfoView.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            Royal.Scenes.Game.Levels.Units.Ego.EgoPackage val_13 = this.egoManager.GetEgoPackage();
            val_35 = this.price;
            this.price = val_13.<Price>k__BackingField;
            string val_14 = val_35.ToString();
            this.priceText.fontSize = (val_14.m_stringLength < 4) ? 6.5f : 5.6f;
            this.priceText.text = val_35.ToString();
            if((val_13.<DifferentRewardCount>k__BackingField) == 2)
            {
                goto label_18;
            }
            
            if((val_13.<DifferentRewardCount>k__BackingField) != 1)
            {
                goto label_19;
            }
            
            this.package1.SetActive(value:  true);
            goto label_21;
            label_18:
            this.package2.SetActive(value:  true);
            this.firstSpecialItemForPackage2.sprite = this.GetSpecialItemToInsert(itemType:  val_13.<FirstItemType>k__BackingField);
            UnityEngine.Transform val_18 = this.firstSpecialItemForPackage2.transform;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  1.4f);
            goto label_28;
            label_19:
            this.package3.SetActive(value:  true);
            val_35 = val_13.<FirstItemType>k__BackingField;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  1.4f);
            val_32 = val_22.x;
            this.firstSpecialItemForPackage3.sprite = this.GetSpecialItemToInsert(itemType:  val_35);
            this.firstSpecialItemForPackage3.transform.localScale = new UnityEngine.Vector3() {x = val_32, y = val_22.y, z = val_22.z};
            this.secondSpecialItemForPackage3.sprite = this.GetSpecialItemToInsert(itemType:  val_13.<SecondItemType>k__BackingField);
            label_28:
            this.secondSpecialItemForPackage3.transform.localScale = new UnityEngine.Vector3() {x = val_32, y = val_22.y, z = val_22.z};
            label_21:
            this.audioManager.PlaySound(type:  115, offset:  0.04f);
            bool val_27 = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64.ShouldShowRoyalPassInEgo();
            this.isRoyalPassFooterActive = val_27;
            if(val_27 == false)
            {
                    return;
            }
            
            val_35 = this.transform;
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.RoyalPassEgoDialogFooter val_31 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Ui.Dialogs.LevelFail.RoyalPassEgoDialogFooter>(original:  UnityEngine.Resources.Load<Royal.Scenes.Game.Ui.Dialogs.LevelFail.RoyalPassEgoDialogFooter>(path:  "RoyalPassEgoDialogFooter"), parent:  val_35);
            this.royalPassEgoDialogFooter = val_31;
            val_31 = this;
            this.ArrangeEgoDialogForRoyalPass();
            this.royalPassEgoDialogFooter.ArrangeRoyalPassFooterForScreens(rootPositionDiffOnRoyalPass:  new UnityEngine.Vector2() {x = this.rootPositionDiffOnRoyalPass, y = val_22.y});
        }
        private UnityEngine.Sprite GetSpecialItemToInsert(Royal.Scenes.Game.Mechanics.Items.Config.ItemType itemType)
        {
            if(itemType == 5)
            {
                    return this.itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.View.LightballItemAssets>().GetSprite();
            }
            
            if(itemType == 4)
            {
                    return this.itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.TntItem.View.TntItemAssets>().GetSprite();
            }
            
            if(itemType != 2)
            {
                    return 0;
            }
            
            return this.itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets>().GetVerticalSprite();
        }
        public void OnPlayOnButton()
        {
            if(this.lastClickedButton != 0)
            {
                    return;
            }
            
            this.lastClickedButton = 1;
            if(this.egoManager.CanPlayOn() != false)
            {
                    this.audioManager.PlaySound(type:  114, offset:  0.04f);
            }
            else
            {
                    this.lastClickedButton = 0;
            }
        
        }
        public void OnExitButton()
        {
            var val_19;
            var val_20;
            int val_21;
            int val_22;
            val_20 = this;
            val_21 = mem[Royal.Player.Context.Data.Session.__il2cppRuntimeField_60 + 20];
            val_21 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_60 + 20;
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.IsEventValid()) != false)
            {
                    val_22 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.GetCollectedAmount();
            }
            else
            {
                    val_22 = 0;
            }
            
            if(this.didWarnForExtra != true)
            {
                    if((val_21 > 0) || (val_22 >= 1))
            {
                goto label_11;
            }
            
            }
            
            if(this.didWarnForRoyalPassOrMadnessClaim == false)
            {
                goto label_13;
            }
            
            label_27:
            if(this.lastClickedButton == 0)
            {
                goto label_14;
            }
            
            return;
            label_13:
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64.CanClaimDuringLevel()) == false)
            {
                goto label_16;
            }
            
            this.didWarnForRoyalPassOrMadnessClaim = true;
            if(this.didWarnForExtra != true)
            {
                    this.packagesContainer.SetActive(value:  false);
            }
            
            this.extraWarn.WarnRoyalPassClaim(royalPassStep:  this.royalPassManager.GetStepInfo(step:  this.royalPassManager.GetStep()), hasRoyalPass:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass, didWarnForExtra:  this.didWarnForExtra);
            return;
            label_14:
            this.lastClickedButton = 2;
            val_20 = ???;
            val_22 = ???;
            val_21 = ???;
            val_19 = ???;
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog).__il2cppRuntimeField_250;
            label_11:
            val_20 = 1;
            val_20 + 48.SetActive(value:  false);
            val_20 + 56.Warn(clocheCount:  val_21, madnessCount:  val_22, eventType:  val_20 + 312 + 52);
            return;
            label_16:
            if((this.didWarnForRoyalPassOrMadnessClaim == true) || ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.CanClaimDuringLevel()) == false))
            {
                goto label_27;
            }
            
            this.didWarnForRoyalPassOrMadnessClaim = true;
            this.extraWarn.WarnMadnessClaim(madnessStep:  this.madnessManager.GetCurrentStep(), eventType:  this.madnessManager.type);
        }
        public void SetRoyalPassClicked()
        {
            this.lastClickedButton = 4;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            float val_23;
            float val_24;
            float val_25;
            .<>4__this = this;
            .dialogClosed = dialogClosed;
            UnityEngine.Vector3 val_2 = this.camManager.GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_23 = val_4.x;
            val_24 = val_4.y;
            val_25 = val_4.z;
            if(this.isRoyalPassFooterActive != false)
            {
                    this.royalPassEgoDialogFooter.transform.SetParent(p:  this.root);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.rootPositionDiffOnRoyalPass, y = V12.16B});
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_23 = val_7.x;
                val_24 = val_7.y;
                val_25 = val_7.z;
            }
            
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}, duration:  0.3f, snapping:  false), ease:  26));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_8, callback:  new DG.Tweening.TweenCallback(object:  new EgoDialog.<>c__DisplayClass50_0(), method:  System.Void EgoDialog.<>c__DisplayClass50_0::<OnClose>b__0()));
            UnityEngine.Transform val_14 = this.coinInfoView.transform;
            UnityEngine.Vector3 val_15 = this.GetCoinStartPosition();
            if(this.isRoyalPassFooterActive != false)
            {
                    DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_14, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.115f, snapping:  false), ease:  3);
                return;
            }
            
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_14, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.3f, snapping:  false), ease:  26, overshoot:  1.2f);
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector2 val_1 = this.camManager.GetSafeCenterPosition();
            UnityEngine.Vector3 val_2 = this.camManager.GetTopCenterOfCamera();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.root.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(d:  0.6f, a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = this.rootPositionDiffOnRoyalPass, y = val_7.y});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.25f, snapping:  false), ease:  3));
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(d:  0.1f, a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, b:  new UnityEngine.Vector2() {x = this.rootPositionDiffOnRoyalPass, y = val_15.y});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, duration:  0.1666667f, snapping:  false), ease:  3));
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = this.rootPositionDiffOnRoyalPass, y = 0.1666667f});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.root, endValue:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, duration:  0.1f, snapping:  false), ease:  3));
            UnityEngine.Vector3 val_28 = this.GetCoinEndPosition();
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_32 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.coinInfoView.transform, endValue:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, duration:  0.3f, snapping:  false), ease:  27, overshoot:  1.2f), delay:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  16f));
            this.AnimateRoyalPassFooterOnShow();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            var val_3;
            bool val_4;
            var val_5;
            float val_6;
            bool val_7;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_7 = val_5;
            if(this.lastClickedButton != 4)
            {
                    if(this.lastClickedButton != 2)
            {
                goto label_1;
            }
            
            }
            
            val_7 = false;
            label_1:
            val_0.shouldHideBackground = val_7;
            mem[1152921519923844635] = val_2;
            mem[1152921519923844633] = val_3;
            val_0.shouldCloseOnEscape = val_4;
            val_0.backgroundFadeInDuration = 0.2f;
            val_0.backgroundFadeOutDuration = 0.31f;
            val_0.backgroundFadeOutDelay = 0.35f;
            val_0.backgroundFadeAlpha = val_6;
            return val_0;
        }
        public void OnCoinIconClicked()
        {
            if(this.lastClickedButton != 0)
            {
                    return;
            }
            
            this.lastClickedButton = 3;
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.EgoDialog).__il2cppRuntimeField_250;
        }
        private UnityEngine.Vector3 GetCoinEndPosition()
        {
            var val_6;
            float val_7;
            float val_1 = this.camManager.GetTopSafeHeightDiff();
            if(this.camManager.IsDeviceWide() != false)
            {
                    val_6 = val_1 + 6.64f;
            }
            else
            {
                    if(this.camManager.IsDeviceTall() != false)
            {
                    val_7 = 8.54f;
            }
            else
            {
                    val_7 = 6.6f;
            }
            
                val_6 = val_1 + val_7;
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private UnityEngine.Vector3 GetCoinStartPosition()
        {
            var val_6;
            float val_7;
            float val_1 = this.camManager.GetTopSafeHeightDiff();
            if(this.camManager.IsDeviceWide() != false)
            {
                    val_6 = val_1 + 6.64f;
            }
            else
            {
                    if(this.camManager.IsDeviceTall() != false)
            {
                    val_7 = 8.54f;
            }
            else
            {
                    val_7 = 6.6f;
            }
            
                val_6 = val_1 + val_7;
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void AnimateRoyalPassFooterOnShow()
        {
            if(this.isRoyalPassFooterActive == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.royalPassEgoDialogFooter.transform;
            UnityEngine.Vector3 val_2 = val_1.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_1.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_4, interval:  0.35f);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.3f), ease:  27, overshoot:  1.33f));
        }
        private void ArrangeEgoDialogForRoyalPass()
        {
            float val_93;
            if(this.camManager.IsDeviceTall() != false)
            {
                    UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
                val_93 = 1.2f;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  val_93);
                this.rootPositionDiffOnRoyalPass = val_3;
                mem[1152921519924647244] = val_3.y;
            }
            
            if(this.camManager.IsDeviceWide() != false)
            {
                    UnityEngine.Vector2 val_5 = UnityEngine.Vector2.down;
                val_93 = 0.39f;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, d:  val_93);
                this.rootPositionDiffOnRoyalPass = val_6;
                mem[1152921519924647244] = val_6.y;
            }
            
            UnityEngine.Vector3 val_7 = this.rootBackground.localPosition;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  1.179f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.rootBackground.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector2 val_11 = this.rootBackgroundSprite.size;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, d:  0.608255f);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            this.rootBackgroundSprite.size = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            UnityEngine.Vector3 val_15 = this.closeButton.localPosition;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  0.31f);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            this.closeButton.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.RectTransform val_19 = this.headerText.rectTransform;
            UnityEngine.Vector3 val_20 = val_19.localPosition;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  0.92f);
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            val_19.localPosition = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
            UnityEngine.Vector3 val_24 = this.egoPackageContainer.localPosition;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  1.07f);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            this.egoPackageContainer.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  0.895f);
            this.extraWarn.transform.localScale = new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z};
            UnityEngine.Transform val_31 = this.extraWarn.transform;
            UnityEngine.Vector3 val_32 = val_31.localPosition;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, d:  0.089f);
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            val_31.localPosition = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
            UnityEngine.Vector3 val_36 = this.egoPackageBackgroundRoot.localPosition;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  0.215f);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            this.egoPackageBackgroundRoot.localPosition = new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z};
            UnityEngine.Vector2 val_40 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y}, d:  0.43f);
            UnityEngine.Vector2 val_42 = this.egoPackageBackgroundLeft.size;
            UnityEngine.Vector2 val_43 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y}, b:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y});
            this.egoPackageBackgroundLeft.size = new UnityEngine.Vector2() {x = val_43.x, y = val_43.y};
            UnityEngine.Vector2 val_44 = this.egoPackageBackgroundRight.size;
            UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_44.x, y = val_44.y}, b:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y});
            this.egoPackageBackgroundRight.size = new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
            UnityEngine.Vector2 val_46 = this.egoPackageBackgroundBorder.size;
            UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_46.x, y = val_46.y}, b:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y});
            this.egoPackageBackgroundBorder.size = new UnityEngine.Vector2() {x = val_47.x, y = val_47.y};
            UnityEngine.Vector2 val_48 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y}, d:  0.3273f);
            UnityEngine.Vector2 val_50 = this.bottomPatternSpriteRenderer.size;
            UnityEngine.Vector2 val_51 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_50.x, y = val_50.y}, b:  new UnityEngine.Vector2() {x = val_49.x, y = val_49.y});
            this.bottomPatternSpriteRenderer.size = new UnityEngine.Vector2() {x = val_51.x, y = val_51.y};
            UnityEngine.Vector3 val_52 = this.bottomPatternTransform.localPosition;
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, d:  0.157f);
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, b:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
            this.bottomPatternTransform.localPosition = new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z};
            UnityEngine.Vector2 val_56 = this.topPatternSpriteRenderer.size;
            UnityEngine.Vector2 val_57 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_56.x, y = val_56.y}, b:  new UnityEngine.Vector2() {x = val_49.x, y = val_49.y});
            this.topPatternSpriteRenderer.size = new UnityEngine.Vector2() {x = val_57.x, y = val_57.y};
            UnityEngine.Vector3 val_58 = this.topPatternTransform.localPosition;
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z}, d:  0.1703f);
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_58.x, y = val_58.y, z = val_58.z}, b:  new UnityEngine.Vector3() {x = val_60.x, y = val_60.y, z = val_60.z});
            this.topPatternTransform.localPosition = new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z};
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, d:  1.85f);
            this.leftCornerPattern.localScale = new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z};
            UnityEngine.Vector3 val_64 = this.leftCornerPattern.localPosition;
            UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.leftCornerPattern.localPosition = new UnityEngine.Vector3() {x = val_65.x, y = val_65.y, z = val_65.z};
            this.rightCornerPattern.localScale = new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z};
            UnityEngine.Vector3 val_66 = this.rightCornerPattern.localPosition;
            UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.rightCornerPattern.localPosition = new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z};
            UnityEngine.Vector3 val_68 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_69 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z}, d:  0.317f);
            UnityEngine.Vector3 val_70 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_71 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_70.x, y = val_70.y, z = val_70.z}, d:  0.828f);
            this.package1.transform.localScale = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z};
            this.package2.transform.localScale = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z};
            this.package3.transform.localScale = new UnityEngine.Vector3() {x = val_71.x, y = val_71.y, z = val_71.z};
            UnityEngine.Transform val_75 = this.package1.transform;
            UnityEngine.Vector3 val_76 = val_75.localPosition;
            UnityEngine.Vector3 val_77 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_76.x, y = val_76.y, z = val_76.z}, b:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z});
            val_75.localPosition = new UnityEngine.Vector3() {x = val_77.x, y = val_77.y, z = val_77.z};
            UnityEngine.Transform val_78 = this.package2.transform;
            UnityEngine.Vector3 val_79 = val_78.localPosition;
            UnityEngine.Vector3 val_80 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_79.x, y = val_79.y, z = val_79.z}, b:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z});
            val_78.localPosition = new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z};
            UnityEngine.Transform val_81 = this.package3.transform;
            UnityEngine.Vector3 val_82 = val_81.localPosition;
            UnityEngine.Vector3 val_83 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_82.x, y = val_82.y, z = val_82.z}, b:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z});
            val_81.localPosition = new UnityEngine.Vector3() {x = val_83.x, y = val_83.y, z = val_83.z};
            UnityEngine.RectTransform val_84 = this.infoText.rectTransform;
            UnityEngine.Vector3 val_85 = val_84.localPosition;
            UnityEngine.Vector3 val_86 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_87 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_86.z}, d:  0.56f);
            UnityEngine.Vector3 val_88 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z}, b:  new UnityEngine.Vector3() {x = val_87.x, y = val_87.y, z = val_87.z});
            val_84.localPosition = new UnityEngine.Vector3() {x = val_88.x, y = val_88.y, z = val_88.z};
            UnityEngine.Vector3 val_89 = this.bottom.localPosition;
            UnityEngine.Vector3 val_90 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_91 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_90.x, y = val_90.y, z = val_90.z}, d:  1.475f);
            UnityEngine.Vector3 val_92 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_89.x, y = val_89.y, z = val_89.z}, b:  new UnityEngine.Vector3() {x = val_91.x, y = val_91.y, z = val_91.z});
            this.bottom.localPosition = new UnityEngine.Vector3() {x = val_92.x, y = val_92.y, z = val_92.z};
        }
        public EgoDialog()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.rootPositionDiffOnRoyalPass = val_1;
            mem[1152921519924918988] = val_1.y;
        }
        private void <>n__0(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
        }
    
    }

}
