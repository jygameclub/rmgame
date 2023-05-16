using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public struct RoyalPassProgress
    {
        // Fields
        private const int EventIdLimit = 256;
        public const int IsGoldStart = 0;
        public const int EventIdStart = 1;
        public const int EventIdEnd = 8;
        public const int StepStart = 9;
        public const int StepEnd = 14;
        public const int CountStart = 15;
        public const int CountEnd = 31;
        public const int TutorialStateStart = 32;
        public const int TutorialStateEnd = 33;
        private long <PassProgress>k__BackingField;
        private long <FreeProgress>k__BackingField;
        private long <GoldProgress>k__BackingField;
        private bool isGold;
        private int eventId;
        private int step;
        private int count;
        private int tutorialState;
        
        // Properties
        public bool IsGold { get; set; }
        public int EventId { get; set; }
        public int Step { get; set; }
        public int Count { get; set; }
        public int TutorialState { get; set; }
        public long PassProgress { get; set; }
        public long FreeProgress { get; set; }
        public long GoldProgress { get; set; }
        
        // Methods
        public bool get_IsGold()
        {
            return (bool)this.tutorialState;
        }
        public void set_IsGold(bool value)
        {
            long val_4 = this.<GoldProgress>k__BackingField;
            this.tutorialState = value;
            val_4 = val_4 & (-2);
            this.<GoldProgress>k__BackingField = (value != true) ? (val_4 | 1) : (val_4);
        }
        public int get_EventId()
        {
            return (int)this;
        }
        public void set_EventId(int value)
        {
            mem[1152921524228060732] = value;
            this.<GoldProgress>k__BackingField = Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<GoldProgress>k__BackingField, number:  value, fromPosition:  1, toPosition:  8);
        }
        public int get_Step()
        {
            return (int)this;
        }
        public void set_Step(int value)
        {
            mem[1152921524228284736] = value;
            this.<GoldProgress>k__BackingField = Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<GoldProgress>k__BackingField, number:  value, fromPosition:  9, toPosition:  14);
        }
        public int get_Count()
        {
            return (int)this;
        }
        public void set_Count(int value)
        {
            mem[1152921524228508740] = value;
            this.<GoldProgress>k__BackingField = Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<GoldProgress>k__BackingField, number:  value, fromPosition:  15, toPosition:  31);
        }
        public int get_TutorialState()
        {
            return (int)this;
        }
        private void set_TutorialState(int value)
        {
            mem[1152921524228732744] = value;
            this.<GoldProgress>k__BackingField = Royal.Infrastructure.Utils.Math.BitwiseOperations.UpdateLong(toNumber:  this.<GoldProgress>k__BackingField, number:  value, fromPosition:  32, toPosition:  33);
        }
        public long get_PassProgress()
        {
            return (long)this.<GoldProgress>k__BackingField;
        }
        private void set_PassProgress(long value)
        {
            this.<GoldProgress>k__BackingField = value;
        }
        public long get_FreeProgress()
        {
            return (long)this.isGold;
        }
        private void set_FreeProgress(long value)
        {
            this.isGold = value;
        }
        public long get_GoldProgress()
        {
            return (long)this.step;
        }
        private void set_GoldProgress(long value)
        {
            this.step = value;
        }
        public RoyalPassProgress(long passProgress, long freeProgress, long goldProgress)
        {
            this.tutorialState = passProgress & 1;
            this.<GoldProgress>k__BackingField = passProgress;
            this.isGold = freeProgress;
            mem[1152921524229516732] = (-) & ;
            this.step = goldProgress;
        }
        public bool IsValidEvent()
        {
            if(W8 < 1)
            {
                    return false;
            }
            
            return (bool)(W8 > 0) ? 1 : 0;
        }
        public bool IsClaimedEvent(int newEventId)
        {
            if(W8 != 0)
            {
                    return false;
            }
            
            var val_2 = (newEventId < 0) ? (newEventId + 255) : newEventId;
            val_2 = val_2 & 4294967040;
            val_2 = newEventId - val_2;
            return (bool)(val_2 == W8) ? 1 : 0;
        }
        public bool IsSameEvent(int newEventId)
        {
            var val_2 = (newEventId < 0) ? (newEventId + 255) : newEventId;
            val_2 = val_2 & 4294967040;
            val_2 = newEventId - val_2;
            return (bool)(val_2 == W8) ? 1 : 0;
        }
        public void ClaimProgressOfThisEvent()
        {
        
        }
        public void ResetProgressOfThisEvent()
        {
        
        }
        public void ResetProgressForNewEvent(int newEventId)
        {
        
        }
        public bool IsStepClaimed(int step, bool isFree)
        {
            var val_1 = (isFree != true) ? 24 : 32;
            var val_3 = 1;
            val_3 = val_3 << step;
            return (bool)(new Royal.Player.Context.Data.Persistent.RoyalPassProgress() != (long)val_3) ? 1 : 0;
        }
        public void ClaimStep(int step, bool isFree, bool sendDataToBackend = True)
        {
            bool val_1 = isFree;
            bool val_2 = sendDataToBackend;
        }
        public override string ToString()
        {
        
        }
        public void UpdateTutorialState(int newState)
        {
            newState = this.<GoldProgress>k__BackingField;
            newState = this.<GoldProgress>k__BackingField + 8;
            newState = this.<GoldProgress>k__BackingField + 16;
            newState = this.<GoldProgress>k__BackingField + 24;
            newState = this.<GoldProgress>k__BackingField + 32;
            newState = this.<GoldProgress>k__BackingField + 40;
        }
    
    }

}
