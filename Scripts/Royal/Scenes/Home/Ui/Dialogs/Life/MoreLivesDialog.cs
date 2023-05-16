using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class MoreLivesDialog : UiDialog
    {
        // Fields
        public const int LifeRefillPrice = 900;
        public UnityEngine.Transform root;
        public TMPro.TextMeshPro header;
        public TMPro.TextMeshPro countDownText;
        public TMPro.TextMeshPro priceText;
        public TMPro.TextMeshPro currentLifeText;
        private int lastRemainingTime;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        public bool shouldReturnOrigin;
        public Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType;
        private Royal.Infrastructure.Contexts.Units.App.AppManager appManager;
        private int freeLivesCount;
        public TMPro.TextMeshPro freeLivesNotificationCount;
        public UnityEngine.GameObject freeLivesNotificationBadge;
        public UnityEngine.GameObject freeLivesButtonBubble;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public UnityEngine.SpriteRenderer[] background;
        public UnityEngine.SpriteRenderer centerBackground;
        public UnityEngine.SpriteRenderer[] containerBackground;
        public UnityEngine.Transform heart;
        public UnityEngine.Transform sunburst;
        public UnityEngine.SpriteRenderer sunburstWrite;
        public UnityEngine.Transform timeRoot;
        public UnityEngine.SpriteRenderer[] timeBackground;
        public UnityEngine.Transform timeText;
        public UnityEngine.Transform freeLivesBackground;
        public UnityEngine.Transform refillBackground;
        public UnityEngine.Transform refillButton;
        public UnityEngine.Transform freeLivesButton;
        
        // Methods
        private void Awake()
        {
            var val_16;
            float val_17;
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            this.appManager = val_1;
            val_1.add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog::OnApplicationResume()));
            Royal.Player.Context.Units.LifeHelper val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.lifeHelper = val_3;
            this.lastRemainingTime = val_3.RemainingSecondsToNextLife();
            this.priceText.text = 900.ToString();
            this.shouldReturnOrigin = true;
            this.FillTexts();
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox> val_6 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.GetAllHelps();
            this.freeLivesCount = true;
            this.freeLivesNotificationCount.text = this.freeLivesCount.ToString();
            if(this.freeLivesCount != 0)
            {
                    this.freeLivesNotificationBadge.SetActive(value:  true);
                val_16 = 0;
            }
            else
            {
                    this.freeLivesNotificationBadge.SetActive(value:  false);
                val_16 = 1;
            }
            
            this.freeLivesButtonBubble.SetActive(value:  true);
            Royal.Infrastructure.Contexts.Units.CameraManager val_8 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            if(val_8.IsDeviceTall() != false)
            {
                    val_17 = 0.59f;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup.CreatePopup(uiDialog:  this, rootTransform:  this.root, rootOffset:  (val_8.IsDeviceWide() != true) ? 0.33f : 0.28f, arrange:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog::ArrangeDialog()), type:  0);
            this.header.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  (this.lifeHelper.HasLives() != true) ? "More Lives" : "No More Lives");
        }
        private void ArrangeDialog()
        {
            do
            {
                UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  4.112f, y:  10.734f);
                this.background[0].size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
                this.background[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  3.278043f, y:  3.579657f);
                this.containerBackground[0].size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                this.containerBackground[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  3.86f, y:  1.592f);
                this.timeBackground[0].size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            }
            while(0 == 0);
            
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  6.765019f, y:  3.771703f);
            this.centerBackground.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            this.centerBackground.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.heart.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.heart.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.sunburst.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.sunburstWrite.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  2.086297f, y:  1.117926f);
            this.sunburstWrite.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            this.timeText.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.timeRoot.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.timeRoot.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.countDownText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.freeLivesBackground.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.freeLivesButton.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.refillBackground.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.refillButton.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void OnDestroy()
        {
            this.appManager.remove_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesDialog::OnApplicationResume()));
        }
        private void Update()
        {
            int val_1 = this.lifeHelper.RemainingSecondsToNextLife();
            if(val_1 == this.lastRemainingTime)
            {
                    return;
            }
            
            this.lastRemainingTime = val_1;
            this.countdownAnimation.Rotate();
            this.FillTexts();
        }
        private void FillTexts()
        {
            this.currentLifeText.text = this.lifeHelper.GetLives().ToString();
            this.countDownText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormat(time:  this.lastRemainingTime);
        }
        public void OnFreeLivesClicked()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.FreeLives.ShowFreeLivesDialogAction(originType:  4));
        }
        public void OnRefillClicked()
        {
            Royal.Player.Context.Data.Persistent.UserInventory val_12;
            if(this.lifeHelper.IsFull() != false)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Your lives are full."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
                return;
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((HasEnoughCoins(delta:  132)) != false)
            {
                    val_12 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 32];
                val_12 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
                if((SpendCoins(spendingData:  new Royal.Player.Context.Data.Session.SpendingData())) == false)
            {
                    return;
            }
            
                Royal.Scenes.Start.Context.Units.Audio.AudioManager val_6 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
                val_6.PlaySound(type:  75, offset:  0.04f);
                if(val_6 == 1)
            {
                    Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction val_8 = null;
                val_12 = val_8;
                val_8 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction(delay:  0f, minutes:  0, lifeCount:  this.lifeHelper.GetLives());
                val_3.Push(action:  val_8);
            }
            
                this.lifeHelper.RefillLives();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
                return;
            }
            
            this.shouldReturnOrigin = false;
            .originType = this;
            val_3.Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Dialogs.Life.MoreLivesPurchaseStrategy()));
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
        private void OnApplicationResume()
        {
            bool val_1 = this.lifeHelper.HasLives();
            if(val_1 == false)
            {
                    return;
            }
            
            if(val_1 == true)
            {
                    this.shouldReturnOrigin = false;
            }
        
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            var val_3;
            float val_4;
            bool val_5;
            var val_6;
            var val_7;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            bool val_9 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene;
            val_0.shouldHideBackground = val_2;
            val_0.shouldCloseOnEscape = ((val_9 & true) != 0) ? (val_3) : (0 + 1);
            val_0.shouldCloseOnTouch = ((val_9 & true) != 0) ? (val_6) : (0 + 1);
            val_0.shouldCloseOnSwipe = ((val_9 & true) != 0) ? (val_7) : (0 + 1);
            val_0.backgroundFadeOutDelay = val_4;
            val_0.shouldSkipFastOnTouch = val_5;
            return val_0;
        }
        public MoreLivesDialog()
        {
        
        }
    
    }

}
