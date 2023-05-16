using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Life
{
    public class OutOfLivesDialog : UiDialog
    {
        // Fields
        public const int LifeRefillPrice = 900;
        public UnityEngine.GameObject freeLivesEnabledButton;
        public UnityEngine.GameObject freeLivesDisabledButton;
        public UnityEngine.Transform closeButton;
        public UnityEngine.Transform dialogTransform;
        public TMPro.TextMeshPro countDownText;
        public TMPro.TextMeshPro priceText;
        public TMPro.TextMeshPro currentLifeText;
        private int lastRemainingTime;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        public bool shouldReturnOrigin;
        private Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType;
        private Royal.Infrastructure.Contexts.Units.App.AppManager appManager;
        private int usableFreeLivesCount;
        public TMPro.TextMeshPro freeLivesCountToBeUsed;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private bool coinClickEnabled;
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
        
        // Methods
        private void Awake()
        {
            float val_25;
            Royal.Infrastructure.Contexts.Units.App.AppManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.App.AppManager>(id:  3);
            this.appManager = val_1;
            val_1.add_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog::OnApplicationResume()));
            Royal.Player.Context.Units.LifeHelper val_3 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.lifeHelper = val_3;
            this.lastRemainingTime = val_3.RemainingSecondsToNextLife();
            this.priceText.text = 900.ToString();
            this.shouldReturnOrigin = true;
            this.FillTexts();
            System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox> val_6 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.GetAllHelps();
            this.usableFreeLivesCount = UnityEngine.Mathf.Min(a:  this.priceText, b:  Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave);
            this.freeLivesCountToBeUsed.text = this.usableFreeLivesCount.ToString();
            this.freeLivesEnabledButton.SetActive(value:  (this.usableFreeLivesCount > 0) ? 1 : 0);
            this.freeLivesDisabledButton.SetActive(value:  (this.usableFreeLivesCount < 1) ? 1 : 0);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2).IsHomeScene) != false)
            {
                    this.coinInfoView.gameObject.SetActive(value:  false);
            }
            else
            {
                    this.coinClickEnabled = true;
                this.coinInfoView.gameObject.SetActive(value:  true);
                UnityEngine.Vector3 val_18 = this.GetCoinStartPosition();
                this.coinInfoView.transform.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
                UnityEngine.Vector3 val_19 = this.GetCoinStartPosition();
                this.coinInfoView.ShowAnimated(finalPosition:  new UnityEngine.Vector3() {x = -2.58f, y = val_19.y, z = val_19.z}, delaySeconds:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  10f));
            }
            
            if(this.camManager.IsDeviceTall() != false)
            {
                    val_25 = 0.44f;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Life.LifeRefillRoyalPassPopup.CreatePopup(uiDialog:  this, rootTransform:  this.dialogTransform, rootOffset:  (this.camManager.IsDeviceWide() != true) ? 0.33f : 0.28f, arrange:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog::ArrangePopup()), type:  1);
        }
        private void ArrangePopup()
        {
            do
            {
                UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  4.112f, y:  11f);
                this.background[0].size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
                this.background[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  3.3f, y:  3.54f);
                this.containerBackground[0].size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                this.containerBackground[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  3.86f, y:  1.592f);
                this.timeBackground[0].size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            }
            while(0 == 0);
            
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  6.778f, y:  3.724f);
            this.centerBackground.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            this.centerBackground.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.heart.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.heart.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.sunburst.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.sunburstWrite.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  2.101f, y:  1.110247f);
            this.sunburstWrite.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            this.timeText.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.timeRoot.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.timeRoot.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.countDownText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.freeLivesBackground.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.freeLivesDisabledButton.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.freeLivesEnabledButton.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.refillBackground.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.refillButton.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void OnDestroy()
        {
            this.appManager.remove_OnApplicationResume(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog::OnApplicationResume()));
        }
        private void Update()
        {
            int val_1 = this.lifeHelper.RemainingSecondsToNextLife();
            if(val_1 == this.lastRemainingTime)
            {
                    return;
            }
            
            this.countdownAnimation.Rotate();
            this.lastRemainingTime = val_1;
            if(this.lifeHelper.HasLives() != false)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.HideText();
            }
            
            this.FillTexts();
        }
        private void FillTexts()
        {
            this.currentLifeText.text = this.lifeHelper.GetLives().ToString();
            this.countDownText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormat(time:  this.lastRemainingTime);
        }
        public void UseFreeLives()
        {
            if(this.usableFreeLivesCount != 0)
            {
                    System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox> val_1 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.GetAllHelps();
                if(this.usableFreeLivesCount >= 1)
            {
                    var val_17 = 0;
                var val_18 = 32;
                do
            {
                this.lifeHelper.IncrementLives();
                if(val_17 >= this.usableFreeLivesCount)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.UseHelp(id:  this.usableFreeLivesCount + 32);
                val_17 = val_17 + 1;
                val_18 = val_18 + 40;
            }
            while(val_17 < this.usableFreeLivesCount);
            
            }
            
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).LifeUse(life:  this.usableFreeLivesCount, scene:  2);
                this = ???;
            }
            else
            {
                    UnityEngine.Vector3 val_6 = val_17 + 48.transform.position;
                Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "You don\'t have any free lives."), position:  new UnityEngine.Vector3() {x = 0f, y = val_6.y + 2f, z = val_6.z}, width:  7f, speed:  1f);
            }
        
        }
        public void Refill()
        {
            Royal.Player.Context.Data.User val_10 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((HasEnoughCoins(delta:  132)) != false)
            {
                    if(this.lifeHelper.HasLives() != true)
            {
                    val_10 = mem[Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField + 32];
                val_10 = Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField;
                if((SpendCoins(spendingData:  new Royal.Player.Context.Data.Session.SpendingData())) == false)
            {
                    return;
            }
            
                Royal.Scenes.Start.Context.Units.Audio.AudioManager val_5 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
                val_5.PlaySound(type:  75, offset:  0.04f);
                if(val_5 == 1)
            {
                    Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction val_6 = null;
                val_10 = val_6;
                val_6 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.PlayLifeCollectAnimationAction(delay:  0f, minutes:  0, lifeCount:  0);
                val_1.Push(action:  val_6);
            }
            
                this.lifeHelper.RefillLives();
                Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            }
            
                Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.HideText();
                return;
            }
            
            this.shouldReturnOrigin = false;
            .originType = this;
            .origin = 0;
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesPurchaseStrategy()));
        }
        public override void OnClose(System.Action dialogClosed)
        {
            var val_4;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_5;
            val_4 = this;
            this.OnClose(dialogClosed:  dialogClosed);
            if(this.shouldReturnOrigin == false)
            {
                    return;
            }
            
            val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((1152921518897325840 == 7) || (1152921518897325840 == 3))
            {
                goto label_6;
            }
            
            if(1152921518897325840 != 2)
            {
                    return;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction val_2 = null;
            val_5 = val_2;
            val_2 = new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  false);
            if(val_4 != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_6:
            Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction val_3 = null;
            val_5 = val_3;
            val_3 = new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction(clearBoosterSelectionData:  false);
            label_8:
            val_4.Push(action:  val_3);
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
        public void OnCoinIconClicked()
        {
            if(this.coinClickEnabled == false)
            {
                    return;
            }
            
            this.coinClickEnabled = false;
            this.shouldReturnOrigin = false;
            .originType = 1152921518897325840;
            .origin = 1;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Shop.ShowShopPopupViewAction(purchaseStrategy:  new Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesPurchaseStrategy()));
            this = ???;
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.Life.OutOfLivesDialog).__il2cppRuntimeField_250;
        }
        private UnityEngine.Vector3 GetCoinEndPosition()
        {
            UnityEngine.Vector3 val_1 = this.GetCoinStartPosition();
            return new UnityEngine.Vector3() {x = -2.58f, y = val_1.y, z = val_1.z};
        }
        private UnityEngine.Vector3 GetCoinStartPosition()
        {
            UnityEngine.Vector3 val_3 = this.camManager.GetSafeTopCenterOfCamera();
            UnityEngine.Vector3 val_4 = this.closeButton.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
            UnityEngine.Vector3 val_7 = this.coinInfoView.transform.parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            float val_8 = val_7.y + 0.3f;
            if(this.camManager.IsDeviceWide() != false)
            {
                
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public OutOfLivesDialog()
        {
        
        }
    
    }

}
