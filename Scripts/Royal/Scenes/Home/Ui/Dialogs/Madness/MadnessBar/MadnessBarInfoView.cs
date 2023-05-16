using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar
{
    public class MadnessBarInfoView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarProgress bar;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarTargetView targetIcon;
        public Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar.MadnessBarRewardView rewardIcon;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countDownAnimation;
        public TMPro.TextMeshPro remainingText;
        public UnityEngine.Transform collectIcon;
        public UnityEngine.GameObject icon;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        private bool isActive;
        private int eventId;
        private UnityEngine.Vector3 longRemainingTextPosition;
        public UnityEngine.Sprite[] barBackgroundSprites;
        public UnityEngine.Sprite[] creamBackgroundSprites;
        public UnityEngine.Sprite[] clockBackgroundSprites;
        public UnityEngine.Material[] clockTextMaterials;
        public UnityEngine.SpriteRenderer[] barBackgrounds;
        public UnityEngine.SpriteRenderer[] creamBackgrounds;
        public UnityEngine.SpriteRenderer[] clockBackgrounds;
        
        // Methods
        public void Awake()
        {
            UnityEngine.GameObject val_3 = this.icon;
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            val_3 = val_3.activeInHierarchy;
            this.isActive = val_3;
            this.ArrangeBar();
        }
        private void ArrangeBar()
        {
            this.InitColorTheme();
            this.bar.Init();
            this.longRemainingTextPosition = 0;
            mem[1152921519363601240] = 0;
            this.targetIcon.CreateTarget(eventType:  this.madnessManager.type, isInGameBar:  false);
            this.rewardIcon.CreateReward(madnessStep:  this.madnessManager.GetCurrentStep());
            this.eventId = this.madnessManager.eventId;
            this.countDownAnimation.Reset();
        }
        public bool IsVisible()
        {
            return (bool)this.isActive;
        }
        private void InitColorTheme()
        {
            var val_1 = (this.madnessManager.type == 3) ? 1 : 0;
            var val_2 = (this.madnessManager.type == 3) ? 1 : 0;
            this.remainingText.fontMaterial = this.clockTextMaterials[val_1];
            if(this.barBackgrounds.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                this.barBackgrounds[val_6].sprite = this.barBackgroundSprites[val_1];
                val_6 = val_6 + 1;
            }
            while(val_6 < this.barBackgrounds.Length);
            
            }
            
            if(this.creamBackgrounds.Length >= 1)
            {
                    var val_9 = 0;
                do
            {
                this.creamBackgrounds[val_9].sprite = this.creamBackgroundSprites[val_1];
                val_9 = val_9 + 1;
            }
            while(val_9 < this.creamBackgrounds.Length);
            
            }
            
            if(this.clockBackgrounds.Length < 1)
            {
                    return;
            }
            
            var val_12 = 0;
            do
            {
                this.clockBackgrounds[val_12].sprite = this.clockBackgroundSprites[val_1];
                val_12 = val_12 + 1;
            }
            while(val_12 < this.clockBackgrounds.Length);
        
        }
        private void InitRemainingTextPosition()
        {
            this.longRemainingTextPosition = 0;
            mem[1152921519364572120] = 0;
        }
        public bool UpdateIcon()
        {
            var val_4;
            if(this.madnessManager.ShouldShowIcon == false)
            {
                goto label_2;
            }
            
            if(this.madnessManager.eventId != this.eventId)
            {
                    bool val_2 = this.madnessManager.TryAddAutoDialog(origin:  "icon", isWin:  false);
                this.ArrangeBar();
            }
            
            if(this.isActive == false)
            {
                goto label_5;
            }
            
            val_4 = 0;
            goto label_6;
            label_2:
            if(this.isActive != false)
            {
                    this.isActive = false;
                this.icon.SetActive(value:  false);
                val_4 = 1;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_5:
            bool val_3 = this.madnessManager.TryAddAutoDialog(origin:  "icon", isWin:  false);
            this.ArrangeBar();
            this.isActive = true;
            val_4 = 1;
            this.icon.SetActive(value:  true);
            label_6:
            this.UpdateSeconds();
            return (bool)val_4;
        }
        public void UpdateSeconds()
        {
            if(this.madnessManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                this.remainingText.alignment = ((this.remainingText.text.Chars[2] & 65535) != (':')) ? (513 + 1) : 513;
                this.SetTextPosition();
            }
            
            this.countDownAnimation.Rotate();
        }
        public void SetTextPosition()
        {
            if((Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false) && ((this.remainingText.text.Chars[2] & 65535) != (':')))
            {
                    string val_4 = this.remainingText.text;
                if(val_4.m_stringLength >= 6)
            {
                    this.remainingText.transform.localPosition = new UnityEngine.Vector3() {x = this.longRemainingTextPosition};
                string val_6 = this.remainingText.text;
                this.remainingText.fontSize = (val_6.m_stringLength > 6) ? 4f : 4.6f;
            }
            
            }
            
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean == false)
            {
                    return;
            }
            
            if((this.remainingText.text.Chars[2] & 65535) == (':'))
            {
                    return;
            }
            
            this.remainingText.transform.localPosition = new UnityEngine.Vector3() {x = this.longRemainingTextPosition, y = 4f};
            string val_12 = this.remainingText.text;
            var val_13 = (val_12.m_stringLength > 6) ? 1 : 0;
            this.remainingText.fontSize = 36596352 + val_12.m_stringLength > 6 ? 1 : 0;
        }
        public void OnClick()
        {
            .<Type>k__BackingField = 2;
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Madness.Actions.ShowPropellerMadnessInfoDialogAction());
        }
        public void BringToFront()
        {
            UnityEngine.Rendering.SortingGroup val_2 = this.gameObject.AddComponent<UnityEngine.Rendering.SortingGroup>();
            val_2.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId;
            val_2.sortingOrder = 1;
        }
        public void BringBackToOriginal()
        {
            UnityEngine.Rendering.SortingGroup val_2 = this.gameObject.GetComponent<UnityEngine.Rendering.SortingGroup>();
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  val_2);
        }
        public MadnessBarInfoView()
        {
        
        }
    
    }

}
