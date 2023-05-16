using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.FreeLives
{
    public class FreeLivesDialog : UiDialog
    {
        // Fields
        public Royal.Infrastructure.UiComponents.Scroll.Content.UiExpandableScrollContent content;
        public UnityEngine.GameObject noFreeLivesContainer;
        public UnityEngine.RectTransform totalFreeLivesTitle;
        public TMPro.TextMeshPro totalFreeLivesText;
        public UnityEngine.GameObject requestButtonParent;
        public UnityEngine.GameObject inboxGo;
        public UnityEngine.GameObject joinTeamGo;
        public UnityEngine.RectTransform joinTeamText;
        public UnityEngine.Transform root;
        public UnityEngine.RectTransform titleRect;
        private int usableFreeLivesCount;
        private System.Collections.Generic.List<Royal.Infrastructure.Services.Storage.Tables.Inbox> helps;
        private int incomingLifeCount;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        public UnityEngine.TextAsset teamCharactersAsset;
        public UnityEngine.SpriteRenderer teamCharacters;
        
        // Methods
        public override void Show()
        {
            this.Show();
            this.lifeHelper = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.helps = Royal.Infrastructure.Services.Storage.Tables.UserInbox.GetAllHelps();
            this.usableFreeLivesCount = 1152921519027630000;
            this.ArrangeInboxOrJoinTeam();
            this.ArrangeTitleText();
            this.AddLives();
            var val_6 = ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceTall()) != true) ? 0.5f : 0.1f;
            this.root.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void ArrangeInboxOrJoinTeam()
        {
            if(this.usableFreeLivesCount == 0)
            {
                    if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) == false)
            {
                goto label_3;
            }
            
            }
            
            this.joinTeamGo.SetActive(value:  false);
            this.inboxGo.SetActive(value:  true);
            this.totalFreeLivesText.text = this.usableFreeLivesCount.ToString();
            this.requestButtonParent.SetActive(value:  (this.usableFreeLivesCount == 0) ? 1 : 0);
            label_12:
            this.noFreeLivesContainer.SetActive(value:  (this.usableFreeLivesCount == 0) ? 1 : 0);
            return;
            label_3:
            this.teamCharacters.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.teamCharactersAsset, width:  197, height:  121, format:  4);
            this.ArrangeJoinTeamText();
            this.joinTeamGo.SetActive(value:  true);
            goto label_12;
        }
        private void ArrangeTitleText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = this.totalFreeLivesTitle.sizeDelta;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  0.5f);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.totalFreeLivesTitle.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  4.64f, y:  1.64017f);
            this.titleRect.sizeDelta = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Transform val_6 = this.titleRect.transform;
            this = val_6;
            UnityEngine.Vector3 val_7 = val_6.localPosition;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.022f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        private void ArrangeJoinTeamText()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  6.496178f, y:  0.93592f);
            this.joinTeamText.sizeDelta = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Transform val_2 = this.joinTeamText.transform;
            this = val_2;
            UnityEngine.Vector3 val_3 = val_2.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.05f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private void AddLives()
        {
            var val_4;
            string val_5;
            bool val_4 = true;
            val_4 = 0;
            var val_5 = 0;
            do
            {
                if(val_5 >= val_4)
            {
                    return;
            }
            
                val_4 = val_4 & 4294967295;
                if(val_5 >= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + val_4;
                val_5 = mem[((true & 4294967295) + val_4) + 56];
                val_5 = ((true & 4294967295) + val_4) + 56;
                if((System.String.IsNullOrEmpty(value:  val_5)) != false)
            {
                    val_5 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "a mate");
            }
            
                Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLifeRowData val_3 = new Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLifeRowData();
                .lifeId = ((true & 4294967295) + val_4) + 32;
                .livesDialog = this;
                .senderName = val_5;
                val_5 = val_5 + 1;
                val_4 = val_4 + 40;
            }
            while(this.helps != null);
            
            throw new NullReferenceException();
        }
        public void AddLifeWithAnimation(Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLifeRow lifeRow, long lifeId, UnityEngine.Vector3 position)
        {
            var val_14;
            var val_15;
            .<>4__this = this;
            .lifeId = lifeId;
            if(this.lifeHelper.IsFull() != true)
            {
                    if((this.incomingLifeCount + this.lifeHelper.GetLives()) < Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave)
            {
                    this.content.RemoveItem(item:  lifeRow);
                int val_14 = this.usableFreeLivesCount;
                val_14 = val_14 - 1;
                this.usableFreeLivesCount = val_14;
                this.ArrangeInboxOrJoinTeam();
                int val_15 = this.incomingLifeCount;
                val_15 = val_15 + 1;
                this.incomingLifeCount = val_15;
                val_14 = null;
                val_14 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.StopLifeUpdate();
                val_15 = null;
                val_15 = null;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetDialogSorting();
                val_6.sortEverything = val_6.sortEverything & 4294967295;
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_7 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything}, offset:  100);
                ChangeSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_7.layer, order = val_7.order, sortEverything = val_7.sortEverything & 4294967295});
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.InboxLifeAnimation>(path:  "InboxLifeAnimation")).Play(startPosition:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, onComplete:  new System.Action(object:  new FreeLivesDialog.<>c__DisplayClass21_0(), method:  System.Void FreeLivesDialog.<>c__DisplayClass21_0::<AddLifeWithAnimation>b__0()), onLifeDestroy:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.FreeLives.FreeLivesDialog::OnLifeDestroyed()));
                return;
            }
            
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Your lives are full."), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        private void OnLifeReached(long lifeId)
        {
            var val_5;
            int val_5 = this.incomingLifeCount;
            val_5 = val_5 - 1;
            this.incomingLifeCount = val_5;
            this.lifeHelper.IncrementLives();
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserInbox.UseHelp(id:  lifeId);
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_2 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  0, count:  1);
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PlayHitAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_2.lifeCount, unlimitedMinutes = val_2.lifeCount});
            if(this.incomingLifeCount == 0)
            {
                    Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).LifeUse(life:  1, scene:  1);
        }
        private void OnLifeDestroyed()
        {
        
        }
        public override void OnClose(System.Action dialogClosed)
        {
            var val_1;
            this.OnClose(dialogClosed:  dialogClosed);
            val_1 = null;
            val_1 = null;
            ResetSorting();
        }
        public void OnRequestButtonClicked()
        {
            null = null;
            Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField.ChangeSection(section:  1);
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
        public FreeLivesDialog()
        {
        
        }
    
    }

}
