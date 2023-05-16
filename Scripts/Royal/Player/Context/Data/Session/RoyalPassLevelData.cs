using UnityEngine;

namespace Royal.Player.Context.Data.Session
{
    public class RoyalPassLevelData : BeforeAfterData
    {
        // Fields
        private int eventId;
        
        // Properties
        public Royal.Player.Context.Units.RoyalPassManager RoyalPassManager { get; }
        public int EventId { get; }
        
        // Methods
        public Royal.Player.Context.Units.RoyalPassManager get_RoyalPassManager()
        {
            return Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
        }
        public int get_EventId()
        {
            return (int)this.eventId;
        }
        public void Init(bool isStory, bool isRestart)
        {
            if((isStory != true) && (this.RoyalPassManager.IsEventActive != false))
            {
                    bool val_3 = Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial();
                if(val_3 != true)
            {
                    bool val_5 = val_3.RoyalPassManager.IsSafeFull();
                if(val_5 != true)
            {
                    if((this.eventId == (val_6.<EventId>k__BackingField)) || (isRestart == false))
            {
                goto label_8;
            }
            
            }
            
            }
            
            }
            
            this.eventId = 0;
            label_11:
            mem[1152921524215525568] = 0;
            mem[1152921524215525572] = 0;
            mem[1152921524215525576] = 0;
            return;
            label_8:
            Royal.Player.Context.Units.RoyalPassManager val_9 = val_5.RoyalPassManager.RoyalPassManager.GetCount().RoyalPassManager;
            this.eventId = val_9.<EventId>k__BackingField;
            goto label_11;
        }
        public bool CanClaimDuringLevel()
        {
            int val_9;
            var val_10;
            val_9 = this;
            bool val_5 = this.IsEventValid();
            if(val_5 == false)
            {
                goto label_6;
            }
            
            val_9 = this.RoyalPassManager.GetCount() + ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 1) ? 3 : ((Royal.Player.Context.Data.Session.__il2cppRuntimeField_2C == 2) ? 5 : (0 + 1)));
            int val_7 = val_5.RoyalPassManager.GetCurrentTarget();
            if(val_9 >= val_7)
            {
                goto label_8;
            }
            
            return val_7.WillStepUpInSafeDuringLevel(collectAmount:  val_9);
            label_6:
            val_10 = 0;
            return (bool)val_10;
            label_8:
            val_10 = 1;
            return (bool)val_10;
        }
        public bool WillStepUpInSafeDuringLevel(int collectAmount)
        {
            int val_8;
            var val_9;
            val_8 = collectAmount;
            Royal.Player.Context.Units.RoyalPassManager val_1 = this.RoyalPassManager;
            if(val_1.GetStep() == val_1.GetSafeStepIndex())
            {
                    int val_5 = this.RoyalPassManager.GetSafeKeyStage(key:  val_8);
                val_8 = val_5;
                if(val_8 > (val_5.RoyalPassManager.GetSafeKeyStage(key:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 64 + 20)))
            {
                    val_9 = 1;
                return (bool)val_9;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public bool IsEventValid()
        {
            var val_7;
            if((W8 != 1) && (this.eventId == (val_1.<EventId>k__BackingField)))
            {
                    bool val_3 = this.RoyalPassManager.RoyalPassManager.IsEventActive;
                if(val_3 != false)
            {
                    val_7 = val_3.RoyalPassManager.IsSafeFull() ^ 1;
                return (bool)val_7 & 1;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7 & 1;
        }
        public bool ShouldShowRoyalPassInEgo()
        {
            var val_4;
            if(this.IsEventValid() != false)
            {
                    if(Royal.Player.Context.Units.RoyalPassManager.ShouldShowFirstTimeTutorial() == false)
            {
                    return (bool)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_typeDefinition == 0) ? 1 : 0;
            }
            
            }
            
            val_4 = 0;
            return (bool)(Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_typeDefinition == 0) ? 1 : 0;
        }
        public RoyalPassLevelData()
        {
            this.eventId = 0;
            val_1 = new System.Object();
        }
    
    }

}
