using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial
{
    public class HomeTutorialManager : IContextUnit
    {
        // Fields
        public const int AutoShowAreaDialogLevel = 11;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets assets;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView arrow;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView black;
        private Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView dialog;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 3;
        }
        public void Bind()
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
        }
        public bool TryAddTutorialActions(bool levelWin)
        {
            if(this.TryAddBoosterTutorialActions() != false)
            {
                    return false;
            }
            
            if(levelWin == false)
            {
                goto label_6;
            }
            
            if(Royal.Player.Context.Units.SocialManager.CanJoinTeam() == false)
            {
                    return false;
            }
            
            label_29:
            this.flowManager.Push(action:  new Royal.Scenes.Home.Context.Units.Tutorial.ShowTeamsTutorialAction());
            return false;
            label_6:
            if(Royal.Player.Context.Units.LevelManager.WasStoryLevel == true)
            {
                    return false;
            }
            
            Royal.Scenes.Home.Context.Units.Area.AreaManager val_5 = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0);
            if((GetAvailableTaskCount(config:  val_5.configContainer.LoadAreaConfig(id:  129259600), stars:  typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14>>0&0xFFFFFFFF)) < 1)
            {
                    return false;
            }
            
            if(val_6.areaId != 1)
            {
                goto label_23;
            }
            
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData val_8 = GetTaskData(taskId:  1);
            if(((ulong)(val_8.taskId >> 32) & 255) == 0)
            {
                goto label_25;
            }
            
            label_23:
            if(levelWin == false)
            {
                    return false;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction val_9 = new Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction(isUserAction:  false, disableTouch:  true, isAuto:  false);
            if(this.flowManager != null)
            {
                goto label_29;
            }
            
            label_25:
            Royal.Scenes.Home.Context.Units.Tutorial.ShowTasksButtonTutorialAction val_10 = new Royal.Scenes.Home.Context.Units.Tutorial.ShowTasksButtonTutorialAction();
            if(this.flowManager != null)
            {
                goto label_29;
            }
            
            throw new NullReferenceException();
        }
        private bool TryAddBoosterTutorialActions()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_8;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_9;
            Royal.Scenes.Game.Mechanics.Boosters.BoosterType val_10;
            var val_11;
            val_8 = this;
            val_10 = 5;
            int val_1 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  5);
            val_10 = 6;
            int val_2 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  6);
            val_10 = 4;
            int val_3 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  4);
            val_10 = 7;
            int val_4 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  7);
            val_11 = 0;
            if(val_10 == (Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetInt(key:  "LastClaimedUnlockedBooster", defaultValue:  0)))
            {
                    return (bool);
            }
            
            this.flowManager.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.BoosterUnlock.ShowBoosterUnlockDialogAction(type:  val_10));
            val_8 = this.flowManager;
            Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayBoosterUnlockAnimationAction val_7 = null;
            val_9 = val_7;
            val_7 = new Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.PlayBoosterUnlockAnimationAction(boosterType:  val_10);
            val_8.Push(action:  val_7);
            val_11 = 1;
            return (bool);
        }
        public static void ClaimUnlockedBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            FillBoosters(boosterType:  boosterType);
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetInt(key:  "LastClaimedUnlockedBooster", value:  boosterType);
        }
        public void ShowPrelevelTutorialIfNeeded(Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog prelevelDialog)
        {
            if((Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetBool(key:  "PrelevelBoosterTutorialShowed", defaultValue:  false)) == true)
            {
                    return;
            }
            
            this.LoadAssets();
            new Royal.Scenes.Home.Context.Units.Tutorial.View.HomePrelevelTutorial(dialog:  prelevelDialog, homeTutorialViewAssets:  this.assets).StartTutorial();
        }
        public static bool WillShowTutorial()
        {
            int val_1 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  5);
            int val_2 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  6);
            int val_3 = Royal.Scenes.Game.Mechanics.Boosters.BoosterTypeExtension.GetUnlockLevel(boosterType:  4);
            return true;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView CreateArrow()
        {
            this.LoadAssets();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialArrowView>(original:  this.assets.arrowView);
            this.arrow = val_1;
            return val_1;
        }
        public void DestroyArrow()
        {
            if(this.arrow == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.arrow.gameObject);
            this.arrow = 0;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView CreateBlack(bool isBlocker = False)
        {
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView val_2;
            this.LoadAssets();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialBlackView>(original:  this.assets.blackView);
            this.black = val_1;
            if(isBlocker == false)
            {
                    return val_2;
            }
            
            val_1.tag = "Blocker";
            val_2 = this.black;
            return val_2;
        }
        public void DestroyBlack()
        {
            if(this.black == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.black.gameObject);
            this.black = 0;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView CreateDialog()
        {
            this.LoadAssets();
            Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView val_1 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView>(original:  this.assets.dialogView);
            this.dialog = val_1;
            return val_1;
        }
        public void DestroyDialog()
        {
            if(this.dialog == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.dialog.gameObject);
            this.dialog = 0;
        }
        private void LoadAssets()
        {
            if(this.assets != 0)
            {
                    return;
            }
            
            this.assets = UnityEngine.Resources.Load<Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets>(path:  "HomeTutorialViewAssets");
        }
        public void HideBlack()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            this.black.background.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        public HomeTutorialManager()
        {
        
        }
    
    }

}
