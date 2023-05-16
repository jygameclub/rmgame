using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Prelevel
{
    public class PrelevelBoosterButton : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Ui.Bottom.Boosters.BoosterLockedAssets boosterLockedAssets;
        public Royal.Infrastructure.UiComponents.Button.UiBoosterButton button;
        public UnityEngine.GameObject yellowContainer;
        public UnityEngine.GameObject greenContainer;
        public UnityEngine.GameObject countHolder;
        public UnityEngine.GameObject iconHolder;
        public UnityEngine.GameObject checkIcon;
        public UnityEngine.GameObject plusIcon;
        public UnityEngine.GameObject unlimitedIcon;
        public TMPro.TextMeshPro countText;
        public UnityEngine.SpriteRenderer icon;
        public UnityEngine.GameObject iconShadow;
        public TMPro.TextMeshPro counter;
        private System.Action OnClicked;
        private Royal.Scenes.Start.Context.Units.Flow.DialogOriginType originType;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        private System.Action onBuyBooster;
        private int remainingTime;
        private byte secondsCounter;
        private const int OneHourInSeconds = 3600;
        private const int DefaultTimerPosition = 0;
        private const int AutoSizedTimerPosition = 1;
        private int currentTimerPosition;
        
        // Methods
        public void add_OnClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnClicked, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnClicked != 1152921519320305984);
            
            return;
            label_2:
        }
        public void remove_OnClicked(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnClicked, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnClicked != 1152921519320442560);
            
            return;
            label_2:
        }
        public void Init(Royal.Scenes.Game.Mechanics.Boosters.BoosterType type, Royal.Scenes.Start.Context.Units.Flow.DialogOriginType origin, System.Action onBuyBoosterClick)
        {
            this.originType = origin;
            this.boosterType = type;
            this.onBuyBooster = onBuyBoosterClick;
            this.remainingTime = RemainingTime(type:  this.boosterType);
            this.PrepareButton(count:  GetBooster(type:  this.boosterType), selected:  IsSelected(type:  this.boosterType));
        }
        private string GetCounterText(int timeInSeconds)
        {
            if(timeInSeconds > 3600)
            {
                    return Royal.Infrastructure.Utils.Time.TimeUtil.GetDurationInMinutesOrHours(totalMinutes:  0);
            }
            
            return Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithMinutes(totalSeconds:  (long)timeInSeconds);
        }
        private void SetCounterTextPosition(int timeInSeconds)
        {
            if(timeInSeconds >= 3601)
            {
                    if(this.currentTimerPosition == 1)
            {
                    return;
            }
            
                this.counter.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.currentTimerPosition = 1;
                return;
            }
            
            if(timeInSeconds == 3600)
            {
                    return;
            }
            
            if(this.currentTimerPosition == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0.8437058f, y:  0.3076186f);
            this.counter.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.counter.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.counter.enableAutoSizing = false;
            this.counter.alignment = 1;
            this.counter.fontSize = 3f;
            this.currentTimerPosition = 0;
        }
        private void FixedUpdate()
        {
            int val_1 = this.remainingTime - 1;
            if()
            {
                    return;
            }
            
            byte val_7 = this.secondsCounter;
            val_7 = val_7 + 1;
            this.secondsCounter = val_7;
            if((val_7 & 255) < 50)
            {
                    return;
            }
            
            this.remainingTime = val_1;
            this.SetCounterTextPosition(timeInSeconds:  val_1);
            this.counter.text = this.GetCounterText(timeInSeconds:  this.remainingTime);
            if(this.remainingTime == 0)
            {
                    this.PrepareButton(count:  GetBooster(type:  this.boosterType), selected:  IsSelected(type:  this.boosterType));
            }
            
            this.secondsCounter = 0;
        }
        private void OnApplicationPause(bool paused)
        {
            if(paused == true)
            {
                    return;
            }
            
            this.remainingTime = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.RemainingTime(boosterType:  this.boosterType);
        }
        public void AutoSelectIfHasTime()
        {
            ToggleForTime(type:  this.boosterType, hasTime:  (this.remainingTime > 0) ? 1 : 0);
        }
        public void ToggleSelection()
        {
            string val_11;
            int val_12;
            val_11 = this;
            if(this.remainingTime < 1)
            {
                goto label_1;
            }
            
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_11 = this.boosterType;
            val_11 = val_11 - 1;
            if(val_11 > 2)
            {
                goto label_2;
            }
            
            val_11 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  45126192 + ((this.boosterType - 1)) << 3);
            goto label_3;
            label_1:
            if(this.OnClicked != null)
            {
                    this.OnClicked.Invoke();
            }
            
            int val_2 = GetBooster(type:  this.boosterType);
            if(val_2 < 1)
            {
                goto label_9;
            }
            
            val_12 = val_2;
            Toggle(type:  this.boosterType);
            this.PrepareButton(count:  val_12, selected:  IsSelected(type:  this.boosterType));
            goto label_11;
            label_2:
            label_3:
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.8f);
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  this, position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, width:  7f, speed:  1f);
            return;
            label_9:
            val_12 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_12.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.BuyBooster.ShowBuyBoosterDialogAction(type:  this.boosterType, origin:  this.originType));
            this.onBuyBooster.Invoke();
            label_11:
            if((IsSelected(type:  this.boosterType)) == false)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  40, offset:  0.04f);
        }
        private void PrepareButton(int count, bool selected)
        {
            var val_27;
            bool val_1 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.IsUnlocked(boosterType:  this.boosterType);
            if(val_1 == false)
            {
                goto label_1;
            }
            
            if(this.remainingTime < 1)
            {
                goto label_2;
            }
            
            this.greenContainer.SetActive(value:  true);
            this.iconHolder.SetActive(value:  true);
            this.unlimitedIcon.SetActive(value:  true);
            this.counter.transform.parent.gameObject.SetActive(value:  true);
            this.SetCounterTextPosition(timeInSeconds:  this.remainingTime);
            this.counter.text = this.GetCounterText(timeInSeconds:  this.remainingTime);
            return;
            label_1:
            this.countHolder.SetActive(value:  false);
            this.yellowContainer.SetActive(value:  true);
            this.yellowContainer.enabled = false;
            this.iconShadow.SetActive(value:  false);
            this.icon.sprite = this.boosterLockedAssets.prelevelLockIcon;
            UnityEngine.Transform val_6 = this.icon.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.56f);
            val_6.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_6.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            return;
            label_2:
            val_1.enabled = true;
            this.counter.transform.parent.gameObject.SetActive(value:  false);
            this.countText.text = count.ToString();
            bool val_14 = selected ^ 1;
            bool val_15 = (count == 0) ? 1 : 0;
            val_15 = val_15 | val_14;
            this.yellowContainer.SetActive(value:  val_15);
            this.countHolder.SetActive(value:  ((count > 0) ? 1 : 0) & val_14);
            this.greenContainer.SetActive(value:  ((count > 0) ? 1 : 0) & selected);
            if(count == 0)
            {
                goto label_32;
            }
            
            val_27 = ((count > 0) ? 1 : 0) & selected;
            if(this.iconHolder != null)
            {
                goto label_33;
            }
            
            label_32:
            val_27 = 1;
            label_33:
            this.iconHolder.SetActive(value:  true);
            this.checkIcon.SetActive(value:  ((count > 0) ? 1 : 0) & selected);
            this.plusIcon.SetActive(value:  (count == 0) ? 1 : 0);
            this.button = (count != 0) ? 1 : 0;
        }
        public void UpdateCountText(bool selected)
        {
            this.PrepareButton(count:  GetBooster(type:  this.boosterType), selected:  selected);
        }
        public PrelevelBoosterButton()
        {
            this.currentTimerPosition = 1;
        }
    
    }

}
