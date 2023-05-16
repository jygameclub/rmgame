using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.League
{
    public class CompleteAllAreasDialog : UiDialog
    {
        // Fields
        public Royal.Infrastructure.Utils.Text.TextProOnAnAnimationCurve[] titleCurves;
        public UnityEngine.TextAsset royalLeagueEpisodeAsset;
        public UnityEngine.SpriteRenderer royalLeagueEpisode;
        
        // Methods
        private void Start()
        {
            this.royalLeagueEpisode.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.royalLeagueEpisodeAsset, width:  52, height:  512, format:  4);
            if((Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false) && (this.titleCurves.Length >= 1))
            {
                    var val_3 = 0;
                do
            {
                this.titleCurves[val_3] = 0;
                val_3 = val_3 + 1;
            }
            while(val_3 < this.titleCurves.Length);
            
            }
            
            this.CheckRequiredStarCount();
        }
        public void Continue()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_6;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if((AreAllTasksCompleted() == false) || (ChestClaimed() == false))
            {
                goto label_8;
            }
            
            Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.ShowAreaUnlockedDialogAction val_4 = null;
            val_6 = val_4;
            val_4 = new Royal.Scenes.Home.Ui.Dialogs.AreaUnlocked.ShowAreaUnlockedDialogAction(isButtonClicked:  true);
            if(val_1 != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_8:
            Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction val_5 = null;
            val_6 = val_5;
            val_5 = new Royal.Scenes.Home.Ui.Dialogs.Area.ShowAreaDialogAction(isUserAction:  true, disableTouch:  false, isAuto:  false);
            label_9:
            val_1.Push(action:  val_5);
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
        private void CheckRequiredStarCount()
        {
            object[] val_4 = new object[2];
            val_4[0] = typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14;
            val_4[1] = GetRequiredStarCount(config:  Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Area.AreaManager>(id:  0).LoadConfig(id:  129259600));
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  10, log:  "Star Status: {0}/{1}", values:  val_4);
            if(val_4.Length <= 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "missing_stars");
            AddStars(delta:  (val_3 - typeof(Royal.Player.Context.Data.Persistent.UserInventory).__il2cppRuntimeField_14));
        }
        public CompleteAllAreasDialog()
        {
        
        }
    
    }

}
