using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class LifeInfoView : MonoBehaviour, ICounter
    {
        // Fields
        public TMPro.TextMeshPro countDownText;
        public TMPro.TextMeshPro countDownTextForHours;
        public TMPro.TextMeshPro fullText;
        public TMPro.TextMeshPro lifeText;
        public UnityEngine.GameObject lifePlusSign;
        public UnityEngine.Transform heart;
        public UnityEngine.GameObject unlimitedLifeSign;
        public UnityEngine.GameObject inboxBadge;
        public TMPro.TextMeshPro inboxCountText;
        public Royal.Infrastructure.UiComponents.Button.UiButton lifeButton;
        private Royal.Player.Context.Units.LifeHelper lifeHelper;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private int lastInbox;
        private int lastLives;
        private int lastRemainingSeconds;
        private int lastRemainingTimeToNextLife;
        private int lastMinutes;
        private Royal.Infrastructure.Utils.Counters.EnableCounter enableCounter;
        private System.Text.StringBuilder stringBuilder;
        private bool shouldShowPausedUnlimitedLivesTooltip;
        private System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData> animationDataList;
        private int lastMaxPossibleLivesToHave;
        private readonly UnityEngine.Vector3[] countDownTextPosArrayForEmpty;
        private readonly UnityEngine.Vector3[] countDownTextPosArrayForBadge;
        private readonly UnityEngine.Vector3[] countDownTextPosArrayForEmptyHours;
        private readonly UnityEngine.Vector3[] countDownTextPosArrayForBadgeHours;
        
        // Properties
        private bool MaxPossibleLivesToHaveIncreased { get; }
        
        // Methods
        private bool get_MaxPossibleLivesToHaveIncreased()
        {
            return (bool)(this.lastMaxPossibleLivesToHave < Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave) ? 1 : 0;
        }
        private void Awake()
        {
            this.lifeHelper = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.lifePlusSign.SetActive(value:  (~this.lifeHelper.IsFull()) & 1);
            this.ArrangeInboxBadge(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
            this.lastLives = this.lifeHelper.GetLives();
            this.lifeText.text = this.lastLives.ToString();
            this.stringBuilder = new System.Text.StringBuilder();
            Royal.Infrastructure.Utils.Counters.EnableCounter val_8 = new Royal.Infrastructure.Utils.Counters.EnableCounter();
            this.enableCounter = val_8;
            val_8.Reset();
            this.lastMaxPossibleLivesToHave = Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave;
            this.CheckPausedUnlimitedLivesTime(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
            this.CalculateLivesAndTimerToShow();
            this.CheckPausedUnlimitedBoostersTimes(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
            this.CalculateUnlimitedBoosterTimes();
        }
        public void UpdateSeconds()
        {
            if(this.enableCounter.IsEnabled() == false)
            {
                    return;
            }
            
            if(this.lastMaxPossibleLivesToHave < Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave)
            {
                    return;
            }
            
            this.CalculateLivesAndTimerToShow();
            this.CalculateUnlimitedBoosterTimes();
        }
        private void CalculateLivesAndTimerToShow()
        {
            this.ArrangeInboxBadge(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
            if(this.lifeHelper.HasUnlimitedLives() != false)
            {
                    int val_2 = this.lifeHelper.RemainingSecondsToEndUnlimitedTimes();
                if(this.lastRemainingSeconds != val_2)
            {
                    this.lastRemainingSeconds = val_2;
                if(this.unlimitedLifeSign.activeSelf != true)
            {
                    this.lastLives = 0;
                this.unlimitedLifeSign.SetActive(value:  true);
                this.lifeText.gameObject.SetActive(value:  false);
                this.fullText.gameObject.SetActive(value:  false);
                this.lifePlusSign.SetActive(value:  false);
            }
            
                if((this.levelManager.<IsThereAnyLevelToPlay>k__BackingField) != true)
            {
                    this.shouldShowPausedUnlimitedLivesTooltip = true;
                this.UpdatePausedUnlimitedLivesTime(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
            }
            
                this.SetRemainingTimeTexts(time:  this.lastRemainingSeconds, hasUnlimitedLives:  true);
            }
            
                if(val_2 != 0)
            {
                    return;
            }
            
                this.lastRemainingSeconds = (this.lastRemainingSeconds != 0) ? this.lastRemainingSeconds : (!0);
            }
            
            int val_7 = this.lifeHelper.GetLives();
            if(this.lastLives != val_7)
            {
                    this.lastLives = val_7;
                this.unlimitedLifeSign.gameObject.SetActive(value:  false);
                this.lifeText.gameObject.SetActive(value:  true);
                this.lifeText.text = this.lastLives.ToString();
                this.lifePlusSign.SetActive(value:  (~this.lifeHelper.IsFull()) & 1);
                this.lastMaxPossibleLivesToHave = Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave;
            }
            
            int val_14 = this.lifeHelper.RemainingSecondsToNextLife();
            if(this.lastRemainingSeconds == val_14)
            {
                    return;
            }
            
            this.lastRemainingSeconds = val_14;
            this.lastRemainingTimeToNextLife = this.lastRemainingSeconds;
            this.SetRemainingTimeTexts(time:  (long)val_14, hasUnlimitedLives:  false);
        }
        private void ArrangeInboxBadge(Royal.Player.Context.Data.Persistent.UserInventory inventory)
        {
            TMPro.TextMeshPro val_28;
            float val_29;
            UnityEngine.Vector3[] val_31;
            this.lastInbox = inventory.<Inbox>k__BackingField;
            TMPro.TextMeshPro val_29 = this.countDownText;
            var val_28 = this.countDownText.text.Chars[0];
            val_28 = val_28 & 65535;
            val_29 = val_29.text.Chars[1] & 65535;
            var val_15 = ((this.countDownTextForHours.text.Chars[1] & 65535) == '1') ? 1 : 0;
            val_28 = val_15 + (((this.countDownTextForHours.text.Chars[0] & 65535) == '1') ? 1 : 0);
            var val_30 = this.countDownTextForHours.text.Chars[4];
            val_30 = val_30 & 65535;
            var val_22 = val_28 + (((this.countDownTextForHours.text.Chars[3] & 65535) == '1') ? 1 : 0);
            val_15 = (val_30 == '1') ? (val_22 + 1) : (val_22);
            if(this.lastInbox < 1)
            {
                goto label_14;
            }
            
            this.inboxBadge.SetActive(value:  true);
            val_28 = this.inboxCountText;
            val_28.text = this.lastInbox.ToString();
            UnityEngine.Vector3[] val_31 = this.countDownTextPosArrayForBadgeHours;
            val_31 = val_31 + (val_15 * 12);
            val_29 = mem[(val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForBadgeHours + 32 + 4];
            val_29 = (val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForBadgeHours + 32 + 4;
            this.countDownTextForHours.transform.localPosition = new UnityEngine.Vector3() {x = (val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForBadgeHours + 32, y = val_29, z = (val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForBadgeHours + 40};
            UnityEngine.Transform val_25 = this.countDownText.transform;
            val_31 = this.countDownTextPosArrayForBadge;
            if(val_31 != null)
            {
                goto label_21;
            }
            
            label_14:
            this.inboxBadge.SetActive(value:  false);
            UnityEngine.Vector3[] val_32 = this.countDownTextPosArrayForEmptyHours;
            val_32 = val_32 + (val_15 * 12);
            val_29 = mem[(val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForEmptyHours + 32 + 4];
            val_29 = (val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForEmptyHours + 32 + 4;
            this.countDownTextForHours.transform.localPosition = new UnityEngine.Vector3() {x = (val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForEmptyHours + 32, y = val_29, z = (val_21 == '1' ? (((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) + 1) : ((val_14 == '1' ? 1 : 0 + val_11 == '1' ? 1 : 0) + val_18 == '1' ? 1 : 0) * 12) + this.countDownTextPosArrayForEmptyHours + 40};
            val_31 = this.countDownTextPosArrayForEmpty;
            label_21:
            val_31 = val_31 + (((val_29 != '1') ? ((val_28 == '1') ? 1 : 0) : ((val_28 == '1') ? 2 : (0 + 1))) * 12);
            this.countDownText.transform.localPosition = new UnityEngine.Vector3() {x = (this.countDownText != '1' ? val_2 == '1' ? 1 : 0 : val_2 == '1' ? 2 : (0 + 1) * 12) + this.countDownTextPosArrayForEmpty + 32, y = (this.countDownText != '1' ? val_2 == '1' ? 1 : 0 : val_2 == '1' ? 2 : (0 + 1) * 12) + this.countDownTextPosArrayForEmpty + 32 + 4, z = (this.countDownText != '1' ? val_2 == '1' ? 1 : 0 : val_2 == '1' ? 2 : (0 + 1) * 12) + this.countDownTextPosArrayForEmpty + 40};
        }
        private void SetRemainingTimeTexts(long time, bool hasUnlimitedLives)
        {
            TMPro.TextMeshPro val_32;
            int val_33;
            string val_34;
            System.Text.StringBuilder val_35;
            TMPro.TextMeshPro val_37;
            int val_38;
            val_32 = this;
            if(hasUnlimitedLives == false)
            {
                goto label_1;
            }
            
            label_38:
            val_33 = 5124095576030431;
            this.fullText.gameObject.SetActive(value:  false);
            this.countDownText.gameObject.SetActive(value:  (time < 3600) ? 1 : 0);
            this.countDownTextForHours.gameObject.SetActive(value:  (time > 3599) ? 1 : 0);
            System.Text.StringBuilder val_6 = this.stringBuilder.Clear();
            int val_33 = this.lastRemainingSeconds;
            if(time < 3600)
            {
                goto label_9;
            }
            
            System.Text.StringBuilder val_8 = this.stringBuilder.Append(value:  val_33.ToString(format:  "D2"));
            System.Text.StringBuilder val_9 = this.stringBuilder.Append(value:  ':');
            System.Text.StringBuilder val_11 = this.stringBuilder.Append(value:  576300624316672650.ToString(format:  "D2"));
            System.Text.StringBuilder val_12 = this.stringBuilder.Append(value:  ':');
            int val_32 = this.lastRemainingSeconds;
            int val_13 = val_32 * 2290644854;
            val_13 = val_13 >> 32;
            val_13 = val_13 + val_32;
            val_13 = (val_13 >> 5) + (val_13 >> 31);
            val_32 = val_32 - (val_13 * 60);
            val_34 = val_32.ToString(format:  "D2");
            System.Text.StringBuilder val_16 = this.stringBuilder.Append(value:  val_34);
            val_35 = this.stringBuilder;
            val_37 = this.countDownTextForHours;
            goto label_16;
            label_1:
            val_33 = this.lastLives;
            if(val_33 != Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave)
            {
                goto label_17;
            }
            
            label_39:
            this.countDownText.gameObject.SetActive(value:  false);
            this.countDownTextForHours.gameObject.SetActive(value:  false);
            this.fullText.gameObject.SetActive(value:  true);
            val_32 = this.fullText;
            val_32.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Full");
            return;
            label_9:
            int val_22 = val_33 * 2290644854;
            val_33 = "D2";
            val_22 = val_22 >> 32;
            val_33 = val_22 + val_33;
            val_22 = val_33 >> 5;
            val_33 = val_22 + (val_33 >> 31);
            System.Text.StringBuilder val_24 = this.stringBuilder.Append(value:  val_33.ToString(format:  "D2"));
            System.Text.StringBuilder val_25 = this.stringBuilder.Append(value:  ':');
            int val_34 = this.lastRemainingSeconds;
            int val_26 = val_34 * 2290644854;
            val_26 = val_26 >> 32;
            val_26 = val_26 + val_34;
            val_26 = (val_26 >> 5) + (val_26 >> 31);
            val_34 = val_34 - (val_26 * 60);
            val_34 = val_34.ToString(format:  "D2");
            System.Text.StringBuilder val_29 = this.stringBuilder.Append(value:  val_34);
            val_35 = this.stringBuilder;
            val_37 = this.countDownText;
            label_16:
            val_37.text = val_35;
            val_38 = this.lastMinutes;
            if(val_38 != val_33)
            {
                    this.ArrangeInboxBadge(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
                val_38 = val_33;
            }
            
            this.lastMinutes = val_38;
            return;
            label_17:
            if(this.lastLives != (Royal.Player.Context.Units.LifeHelper.MaxPossibleLivesToHave - 1))
            {
                goto label_34;
            }
            
            if(time == 1)
            {
                goto label_39;
            }
            
            if(this.lastRemainingSeconds != 0)
            {
                goto label_38;
            }
            
            goto label_39;
            label_34:
            if(time != 1)
            {
                goto label_38;
            }
            
            goto label_39;
        }
        public void AddLives()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_8;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((this.levelManager.<IsThereAnyLevelToPlay>k__BackingField) == false)
            {
                goto label_4;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  40, offset:  0.04f);
            if(this.lifeHelper.HasUnlimitedLives() != true)
            {
                    if(this.lifeHelper.IsFull() == false)
            {
                goto label_11;
            }
            
            }
            
            Royal.Scenes.Home.Ui.Dialogs.FreeLives.ShowFreeLivesDialogAction val_5 = null;
            val_8 = val_5;
            val_5 = new Royal.Scenes.Home.Ui.Dialogs.FreeLives.ShowFreeLivesDialogAction(originType:  1);
            if(val_1 != null)
            {
                goto label_16;
            }
            
            label_4:
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.ShowPausedUnlimitedLifeTooltipAction val_6 = null;
            val_8 = val_6;
            val_6 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.ShowPausedUnlimitedLifeTooltipAction();
            .parentButton = this.lifeButton;
            .<Type>k__BackingField = 3;
            label_16:
            val_1.Push(action:  val_6);
            return;
            label_11:
            Royal.Scenes.Home.Ui.Dialogs.Life.ShowMoreLivesDialogAction val_7 = new Royal.Scenes.Home.Ui.Dialogs.Life.ShowMoreLivesDialogAction(originType:  1);
            if(val_1 != null)
            {
                goto label_16;
            }
            
            throw new NullReferenceException();
        }
        public void PlayHitAnimation(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData animationData)
        {
            .<>4__this = this;
            .animationData = animationData;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.8f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  3f)), action:  new DG.Tweening.TweenCallback(object:  new LifeInfoView.<>c__DisplayClass34_0(), method:  System.Void LifeInfoView.<>c__DisplayClass34_0::<PlayHitAnimation>b__0()));
        }
        public void PrepareTextForAnimation(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData animationData)
        {
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData> val_2 = this.animationDataList;
            if(val_2 == null)
            {
                    System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData> val_1 = null;
                val_2 = val_1;
                val_1 = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData>(capacity:  10);
                this.animationDataList = val_2;
            }
            
            val_1.Add(item:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = animationData.lifeCount, unlimitedMinutes = animationData.unlimitedMinutes});
            this.enableCounter.Disable();
            this.PrepareTextForAnimation();
        }
        private void PrepareTextForAnimation()
        {
            if(this.lifeHelper.HasUnlimitedLives() != false)
            {
                    this.PrepareTextForAnimationForUnlimitedLives();
                return;
            }
            
            this.PrepareTextForAnimationForLifeCount();
        }
        private void PrepareTextForAnimationForLifeCount()
        {
            this.lifeText.text = Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData.TotalLifeCount(list:  this.animationDataList).ToString();
            this.lastLives = 0;
        }
        private void PrepareTextForAnimationForUnlimitedLives()
        {
            var val_6;
            long val_7;
            var val_8;
            val_6 = this.lifeHelper.RemainingSecondsToEndUnlimitedTimes() + ((Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData.TotalUnlimitedMinutes(list:  this.animationDataList)) * 59);
            if(val_6 > 99)
            {
                    val_7 = (long)val_6;
                val_8 = 1;
            }
            else
            {
                    this.unlimitedLifeSign.gameObject.SetActive(value:  false);
                this.lifeText.gameObject.SetActive(value:  true);
                val_8 = 0;
                int val_5 = (this.lastRemainingTimeToNextLife != 0) ? this.lastRemainingTimeToNextLife : (!0);
                val_7 = (long)val_5;
            }
            
            this.lastRemainingSeconds = val_5;
            this.SetRemainingTimeTexts(time:  val_7, hasUnlimitedLives:  false);
        }
        public void StopLifeUpdate()
        {
            if(this.enableCounter != null)
            {
                    this.enableCounter.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void ShowTooltip()
        {
            .parentButton = this.lifeButton;
            .<Type>k__BackingField = 3;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.ShowPausedUnlimitedLifeTooltipAction());
        }
        private void CheckPausedUnlimitedLivesTime(Royal.Player.Context.Data.Persistent.UserInventory inventory)
        {
            int val_1 = inventory.GetPausedUnlimitedLivesTimeInMinutes();
            if(val_1 < 1)
            {
                    return;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Paused unlimited time will be set: {0}", values:  val_2);
            inventory.UpdatePausedUnlimitedLivesTimeInMinutes(lifeTimeMinutes:  0);
            int val_3 = this.lifeHelper.RemainingSecondsToEndUnlimitedTimes();
            var val_7 = 0;
            val_7 = val_7 + val_3;
            var val_8 = -val_3;
            val_7 = (val_7 >> 5) + (val_7 >> 31);
            val_8 = val_8 + (val_7 * 60);
            val_7 = val_1 - val_7;
            val_7 = val_8 + (val_7 * 60);
            this.lifeHelper.AddUnlimitedLivesInSeconds(deltaSeconds:  val_7 + 59);
            if((this.levelManager.<IsThereAnyLevelToPlay>k__BackingField) == false)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        private void UpdatePausedUnlimitedLivesTime(Royal.Player.Context.Data.Persistent.UserInventory inventory)
        {
            int val_6;
            if(inventory.GetPausedUnlimitedLivesTimeInMinutes() > 0)
            {
                    return;
            }
            
            this.enableCounter.Disable();
            int val_5 = this.lastRemainingSeconds;
            int val_2 = val_5 * 2290644854;
            val_2 = val_2 >> 32;
            val_5 = val_2 + val_5;
            val_2 = val_5 >> 5;
            val_6 = val_2 + (val_5 >> 31);
            object[] val_3 = new object[1];
            val_3[0] = val_6;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Stop countdown for unlimited time: {0}", values:  val_3);
            inventory.UpdatePausedUnlimitedLivesTimeInMinutes(lifeTimeMinutes:  val_6);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        private void CalculateUnlimitedBoosterTimes()
        {
            if(HasUnlimitedBooster() == false)
            {
                    return;
            }
            
            if((this.levelManager.<IsThereAnyLevelToPlay>k__BackingField) != false)
            {
                    return;
            }
            
            this.UpdatePausedUnlimitedBoostersTimes(inventory:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.<Inventory>k__BackingField);
        }
        private void CheckPausedUnlimitedBoostersTimes(Royal.Player.Context.Data.Persistent.UserInventory inventory)
        {
            this.CheckPausedUnlimitedBoosterTime(inventory:  inventory, boosterType:  1);
            this.CheckPausedUnlimitedBoosterTime(inventory:  inventory, boosterType:  2);
            this.CheckPausedUnlimitedBoosterTime(inventory:  inventory, boosterType:  3);
        }
        private void CheckPausedUnlimitedBoosterTime(Royal.Player.Context.Data.Persistent.UserInventory inventory, Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_9 = boosterType;
            int val_1 = inventory.GetPausedUnlimitedBoosterTimeInMinutes(boosterType:  val_9 = boosterType);
            if(val_1 < 1)
            {
                    return;
            }
            
            val_9 = val_1;
            object[] val_2 = new object[2];
            string val_4 = boosterType.ToString();
            val_2[0] = boosterType.ToString();
            val_2[1] = val_9;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Paused {0} unlimited time will be set: {1}", values:  val_2);
            inventory.UpdatePausedUnlimitedBoosterTimeInMinutes(boosterType:  null, lifeTimeMinutes:  0);
            int val_5 = inventory.RemainingTime(type:  null);
            var val_9 = 0;
            val_9 = val_9 + val_5;
            int val_6 = val_9 >> 5;
            val_9 = val_6 + (val_9 >> 31);
            val_6 = val_9 - val_9;
            val_9 = (-val_5) + (val_9 * 60);
            val_9 = val_9 + (val_6 * 60);
            inventory.AddTime(boosterType:  null, deltaSeconds:  val_9 + 59);
            if((this.levelManager.<IsThereAnyLevelToPlay>k__BackingField) == false)
            {
                    return;
            }
            
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        private void UpdatePausedUnlimitedBoostersTimes(Royal.Player.Context.Data.Persistent.UserInventory inventory)
        {
            this.UpdatePausedUnlimitedBoosterTime(inventory:  inventory, boosterType:  1);
            this.UpdatePausedUnlimitedBoosterTime(inventory:  inventory, boosterType:  2);
            this.UpdatePausedUnlimitedBoosterTime(inventory:  inventory, boosterType:  3);
        }
        private void UpdatePausedUnlimitedBoosterTime(Royal.Player.Context.Data.Persistent.UserInventory inventory, Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_8 = boosterType;
            if((inventory.GetPausedUnlimitedBoosterTimeInMinutes(boosterType:  val_8 = boosterType)) > 0)
            {
                    return;
            }
            
            int val_9 = inventory.RemainingTime(type:  val_8);
            object[] val_3 = new object[2];
            val_8 = val_3;
            string val_5 = boosterType.ToString();
            val_8[0] = boosterType.ToString();
            var val_8 = 0;
            val_8 = val_8 + val_9;
            val_9 = (val_8 >> 5) + (val_8 >> 31);
            val_8[1] = val_9;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "Stop countdown for {0} unlimited time: {1}", values:  val_3);
            inventory.UpdatePausedUnlimitedBoosterTimeInMinutes(boosterType:  null, lifeTimeMinutes:  val_9);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
        }
        public LifeInfoView()
        {
            this.lastRemainingSeconds = 0;
            this.lastMinutes = 0;
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[3];
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[2] = 0;
            val_1[3] = 0;
            val_1[4] = 0;
            this.countDownTextPosArrayForEmpty = val_1;
            UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[3];
            val_2[0] = 0;
            val_2[1] = 0;
            val_2[1] = 0;
            val_2[2] = 0;
            val_2[3] = 0;
            val_2[4] = 0;
            this.countDownTextPosArrayForBadge = val_2;
            UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[5];
            val_3[0] = 0;
            val_3[1] = 0;
            val_3[1] = 0;
            val_3[2] = 0;
            val_3[3] = 0;
            val_3[4] = 0;
            val_3[4] = 0;
            val_3[5] = 0;
            val_3[6] = 0;
            val_3[7] = 0;
            this.countDownTextPosArrayForEmptyHours = val_3;
            UnityEngine.Vector3[] val_4 = new UnityEngine.Vector3[5];
            val_4[0] = 0;
            val_4[1] = 0;
            val_4[1] = 0;
            val_4[2] = 0;
            val_4[3] = 0;
            val_4[4] = 0;
            val_4[4] = 0;
            val_4[5] = 0;
            val_4[6] = 0;
            val_4[7] = 0;
            this.countDownTextPosArrayForBadgeHours = val_4;
        }
    
    }

}
