using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Actions
{
    public class PlayMadnessClaimAction : AMadnessFlowAction
    {
        // Fields
        private readonly Royal.Player.Context.Units.MadnessStep stepConfig;
        
        // Methods
        public PlayMadnessClaimAction(int eventId, Royal.Player.Context.Units.MadnessStep stepConfig)
        {
            object[] val_1 = new object[2];
            val_1[0] = eventId;
            val_1[1] = stepConfig.s;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  26, log:  "Madness claim action added for event: {0} - step: {1}", values:  val_1);
            this.stepConfig = stepConfig;
        }
        public override bool SupportsMultiple()
        {
            return true;
        }
        public override void Execute()
        {
            if(this.ShouldPlayAnimation() != false)
            {
                    this.GiveRewards();
                UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation>(path:  "MadnessClaimAnimation")).Play(stepConfig:  this.stepConfig, onComplete:  new System.Action(object:  this, method:  public System.Void Royal.Scenes.Start.Context.Units.Flow.FlowAction::Complete()));
                return;
            }
            
            object[] val_5 = new object[2];
            val_5[0] = 1152921505160379072;
            val_5[1] = this.stepConfig.s;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  26, log:  "Can\'t play madness claim animation for event: {0} - step: {1}", values:  val_5);
            this.Complete();
        }
        private void GiveRewards()
        {
            Royal.Player.Context.Data.InventoryPackage val_10;
            var val_11;
            var val_12;
            var val_13;
            Royal.Player.Context.Data.InventoryPackage val_2 = Royal.Player.Context.Data.InventoryPackage.GetMadnessPackage(step:  this.stepConfig);
            val_10 = val_2;
            Royal.Player.Context.Units.UserManager.AddInventoryPackage(package:  val_2);
            if(val_2.coins >= 1)
            {
                    val_11 = 1152921505056579584;
                val_12 = null;
                val_12 = null;
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation(previousCoin:  130671888);
            }
            
            if(val_2.unlimitedLifetimeMin >= 1)
            {
                    val_13 = null;
                val_13 = null;
                Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData val_3 = new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData(minutes:  val_2.unlimitedLifetimeMin, count:  0);
                Royal.Scenes.Home.Ui.__il2cppRuntimeField_38.PrepareTextForAnimation(animationData:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.LifeCollect.LifeCollectAnimationData() {lifeCount = val_3.lifeCount, unlimitedMinutes = val_3.lifeCount});
            }
            
            .madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Analytics.AnalyticsManager>(id:  17).MadnessClaim(type:  (PlayMadnessClaimAction.<>c__DisplayClass4_0)[1152921519382191904].madnessManager.type, eventId:  (PlayMadnessClaimAction.<>c__DisplayClass4_0)[1152921519382191904].madnessManager.eventId, step:  this.stepConfig.s, target:  this.stepConfig.t, package:  val_10);
            (PlayMadnessClaimAction.<>c__DisplayClass4_0)[1152921519382191904].madnessManager.UpdateStep(newStep:  this.stepConfig.s + 1);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.UserManager>(id:  1).SendDataToBackend(forceToSend:  false, forceScoreData:  false);
            if(((PlayMadnessClaimAction.<>c__DisplayClass4_0)[1152921519382191904].madnessManager.IsCompleted()) == false)
            {
                    return;
            }
            
            (PlayMadnessClaimAction.<>c__DisplayClass4_0)[1152921519382191904].madnessManager = 1;
            System.Action val_9 = null;
            val_10 = val_9;
            val_9 = new System.Action(object:  new PlayMadnessClaimAction.<>c__DisplayClass4_0(), method:  System.Void PlayMadnessClaimAction.<>c__DisplayClass4_0::<GiveRewards>b__0());
            this.add_OnComplete(value:  val_9);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
