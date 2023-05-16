using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelQuit
{
    public class LevelQuitDialog : UiDialog
    {
        // Fields
        public UnityEngine.GameObject lifeWarnContainer;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.ExtraWarn extraWarn;
        public UnityEngine.GameObject defaultHeart;
        public UnityEngine.GameObject unlimitedLivesHeart;
        public UnityEngine.GameObject unlimitedSign;
        public TMPro.TextMeshPro infoText;
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve titleCurve;
        private Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private int lastClickedButton;
        private const int Quit = 1;
        private const int Cancel = 2;
        private const int QuitOnBonusLevel = 3;
        private bool didWarnForExtra;
        private bool didWarnForRoyalPassOrMadnessClaim;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Player.Context.Units.LevelManager levelManager;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        
        // Methods
        private void Awake()
        {
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.levelManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2);
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.ArrangeTitle();
            bool val_9 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LifeHelper>(id:  3).HasUnlimitedLives();
            this.defaultHeart.SetActive(value:  (~val_9) & 1);
            bool val_11 = val_9;
            this.unlimitedLivesHeart.SetActive(value:  val_11);
            this.unlimitedSign.SetActive(value:  val_11);
            this.infoText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  (val_9 != true) ? "Are you sure you want to quit?" : "LoseLife");
        }
        private void ArrangeTitle()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            this.titleCurve = 1086324736;
            UnityEngine.Transform val_1 = this.titleCurve.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.2f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void OnCloseButton()
        {
            this.lastClickedButton = 2;
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelQuit.LevelQuitDialog).__il2cppRuntimeField_250;
        }
        public void OnQuitButton()
        {
            var val_10;
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.IsEventValid()) != false)
            {
                    val_10 = Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.GetCollectedAmount();
            }
            else
            {
                    val_10 = 0;
            }
            
            if(this.didWarnForExtra != true)
            {
                    if(val_10 >= 1)
            {
                goto label_11;
            }
            
            }
            
            if(this.didWarnForRoyalPassOrMadnessClaim == false)
            {
                goto label_13;
            }
            
            label_29:
            this.lastClickedButton = 3;
            this.gameStateManager.SetStateToQuit();
            this.StartQuitFlowForBonusLevel();
            return;
            label_13:
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 64.CanClaimDuringLevel()) == false)
            {
                goto label_17;
            }
            
            this.didWarnForRoyalPassOrMadnessClaim = true;
            if(this.didWarnForExtra != true)
            {
                    this.lifeWarnContainer.SetActive(value:  false);
            }
            
            this.extraWarn.WarnRoyalPassClaim(royalPassStep:  this.royalPassManager.GetStepInfo(step:  this.royalPassManager.GetStep()), hasRoyalPass:  Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass, didWarnForExtra:  this.didWarnForExtra);
            return;
            label_11:
            this.didWarnForExtra = true;
            this.lifeWarnContainer.SetActive(value:  false);
            this.extraWarn.Warn(clocheCount:  Royal.Player.Context.Data.Session.__il2cppRuntimeField_60 + 20, madnessCount:  0, eventType:  this.madnessManager.type);
            return;
            label_17:
            if((this.didWarnForRoyalPassOrMadnessClaim == true) || ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.CanClaimDuringLevel()) == false))
            {
                goto label_29;
            }
            
            this.didWarnForRoyalPassOrMadnessClaim = true;
            this.extraWarn.WarnMadnessClaim(madnessStep:  this.madnessManager.GetCurrentStep(), eventType:  this.madnessManager.type);
        }
        private void StartQuitFlow()
        {
            var val_3;
            var val_4;
            this.audioManager.StopGameMusic();
            Quit(moveManager:  this.moveManager);
            this.levelManager.LevelEnd();
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Game.Ui.__il2cppRuntimeField_58.BeSad();
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Quit flow started.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.audioManager.PlaySound(type:  150, offset:  0.04f);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowFailDialogAction(clearBoosterSelectionData:  true));
        }
        private void StartQuitFlowForBonusLevel()
        {
            var val_2;
            this.audioManager.StopGameMusic();
            Quit(moveManager:  this.moveManager);
            this.levelManager.LevelEnd();
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Quit flow started for bonus level.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldCloseOnTouch = true;
            val_0.shouldCloseOnSwipe = true;
            val_0.backgroundFadeOutDelay = val_3;
            val_0.shouldHideBackground = (this.lastClickedButton != 1) ? 1 : 0;
            val_0.shouldSkipFastOnTouch = val_2;
            return val_0;
        }
        private bool ShouldHideBackground()
        {
            return (bool)(this.lastClickedButton != 1) ? 1 : 0;
        }
        public LevelQuitDialog()
        {
            this.lastClickedButton = 2;
        }
    
    }

}
