using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleInfoDialog : UiDialog, ICounter
    {
        // Fields
        private const byte NoTeam = 0;
        private const byte NotInGroup = 1;
        private const byte InGroup = 2;
        private const byte MemberCountLimit = 10;
        public UnityEngine.TextAsset battleInfoAsset;
        public UnityEngine.SpriteRenderer battleInfo;
        public TMPro.TextMeshPro infoText;
        public TMPro.TextMeshPro buttonText;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        private bool buttonClicked;
        private bool isUserAction;
        private bool isInfoButton;
        private bool timerTextFinished;
        private Royal.Player.Context.Units.TeamBattleManager teamBattleManager;
        private Royal.Player.Context.Units.SocialManager socialManager;
        private byte state;
        
        // Methods
        private void Awake()
        {
            var val_4;
            this.battleInfo.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.battleInfoAsset, width:  238, height:  63, format:  4);
            this.teamBattleManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.TeamBattleManager>(id:  9);
            this.socialManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            this.UpdateSeconds();
            val_4 = null;
            val_4 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
        }
        public void Show(bool userAction, bool infoButton)
        {
            bool val_1 = userAction;
            bool val_2 = infoButton;
            this.Show();
            this.isInfoButton = val_2;
            this.isUserAction = val_1;
            object[] val_3 = new object[2];
            val_3[0] = val_1;
            val_3[1] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  25, log:  "Team battle info dialog: {0} {1}", values:  val_3);
        }
        private void Start()
        {
            TMPro.TextMeshPro val_8;
            string val_9;
            if(this.teamBattleManager.IsInAGroup == false)
            {
                goto label_2;
            }
            
            this.state = 2;
            label_14:
            this.infoText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  (this.isInfoButton == false) ? "TeamBattleInfoBattleStarted" : "TeamBattleInfoFromInfoButton");
            this.SelectButtonText();
            return;
            label_2:
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasTeam()) != false)
            {
                    this.state = 1;
                if(((this.socialManager.<MyTeamMemberCount>k__BackingField) == 0) || ((this.socialManager.<MyTeamMemberCount>k__BackingField) > 9))
            {
                goto label_14;
            }
            
                this.infoText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattleInfoAtLeast10Members");
                val_8 = this.buttonText;
                val_9 = "Continue";
            }
            else
            {
                    this.state = 0;
                this.infoText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TeamBattleInfoJoinATeam");
                val_8 = this.buttonText;
                val_9 = "Join";
            }
            
            val_8.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_9);
        }
        private void SelectButtonText()
        {
            this.buttonText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).HasAutoActionInTheFlow) != true) ? "Continue" : "Play");
        }
        public void UpdateSeconds()
        {
            if(this.timerTextFinished != false)
            {
                    this = ???;
            }
            else
            {
                    if((val_11 + 96.RemainingTimeInMs) < 1000)
            {
                    val_11 + 72.alignment = 2;
                string val_2 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this = 1;
            }
            else
            {
                    string val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if(((val_11 + 72.Chars[2]) & 65535) == (':'))
            {
                    val_11 + 72.alignment = 1;
            }
            
            }
            
                val_11 + 80.Rotate();
            }
        
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            bool val_3;
            float val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.shouldCloseOnTouch = this.isUserAction;
            val_0.backgroundFadeInDuration = val_4;
            val_0.shouldCloseOnSwipe = val_3;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            var val_3;
            if(((this.buttonClicked != true) && (this.timerTextFinished != true)) && (36707 == 5))
            {
                    .isUserAction = true;
                .<Type>k__BackingField = 2;
                .<IsForClaim>k__BackingField = false;
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Home.Ui.Dialogs.TeamBattle.ShowTeamBattlePopupAction());
            }
            
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.OnClose(dialogClosed:  dialogClosed);
        }
        public void OnButtonClicked()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_5;
            this.buttonClicked = true;
            if(this.timerTextFinished != true)
            {
                    Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
                if(this.state != 0)
            {
                    if(val_1.HasAutoActionInTheFlow == true)
            {
                goto typeof(Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleInfoDialog).__il2cppRuntimeField_250;
            }
            
                Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction val_3 = null;
                val_5 = val_3;
                val_3 = new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  true);
            }
            else
            {
                    Royal.Scenes.Home.Ui.Sections.PlayMoveToSectionAnimationAction val_4 = null;
                val_5 = val_4;
                val_4 = new Royal.Scenes.Home.Ui.Sections.PlayMoveToSectionAnimationAction(sectionType:  1, type:  2);
            }
            
                val_1.Push(action:  val_4);
            }
        
        }
        public TeamBattleInfoDialog()
        {
        
        }
    
    }

}
