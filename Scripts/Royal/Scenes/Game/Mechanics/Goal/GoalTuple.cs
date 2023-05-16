using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Goal
{
    public class GoalTuple
    {
        // Fields
        private Royal.Scenes.Game.Mechanics.Goal.GoalType <GoalType>k__BackingField;
        private int <TargetCount>k__BackingField;
        private int <LeftCount>k__BackingField;
        private int <LeftCountUi>k__BackingField;
        private bool <IsFromSettings>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Goal.Conditions.IGoalCondition goalCondition;
        
        // Properties
        public Royal.Scenes.Game.Mechanics.Goal.GoalType GoalType { get; set; }
        public int TargetCount { get; set; }
        public int LeftCount { get; set; }
        public int LeftCountUi { get; set; }
        public bool IsFromSettings { get; set; }
        
        // Methods
        public Royal.Scenes.Game.Mechanics.Goal.GoalType get_GoalType()
        {
            return (Royal.Scenes.Game.Mechanics.Goal.GoalType)this.<GoalType>k__BackingField;
        }
        private void set_GoalType(Royal.Scenes.Game.Mechanics.Goal.GoalType value)
        {
            this.<GoalType>k__BackingField = value;
        }
        public int get_TargetCount()
        {
            return (int)this.<TargetCount>k__BackingField;
        }
        private void set_TargetCount(int value)
        {
            this.<TargetCount>k__BackingField = value;
        }
        public int get_LeftCount()
        {
            return (int)this.<LeftCount>k__BackingField;
        }
        private void set_LeftCount(int value)
        {
            this.<LeftCount>k__BackingField = value;
        }
        public int get_LeftCountUi()
        {
            return (int)this.<LeftCountUi>k__BackingField;
        }
        private void set_LeftCountUi(int value)
        {
            this.<LeftCountUi>k__BackingField = value;
        }
        public bool get_IsFromSettings()
        {
            return (bool)this.<IsFromSettings>k__BackingField;
        }
        private void set_IsFromSettings(bool value)
        {
            this.<IsFromSettings>k__BackingField = value;
        }
        public GoalTuple(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int targetCount, bool isFromSettings)
        {
            this.<GoalType>k__BackingField = goalType;
            this.<TargetCount>k__BackingField = targetCount;
            this.<LeftCount>k__BackingField = targetCount;
            this.<LeftCountUi>k__BackingField = targetCount;
            this.<IsFromSettings>k__BackingField = isFromSettings;
            this.goalCondition = this.GetGoalCondition();
        }
        public int DecreaseGoal()
        {
            int val_2 = UnityEngine.Mathf.Max(a:  (this.<LeftCount>k__BackingField) - 1, b:  0);
            this.<LeftCount>k__BackingField = val_2;
            return val_2;
        }
        public int DecreaseGoalUi()
        {
            int val_2 = UnityEngine.Mathf.Max(a:  (this.<LeftCountUi>k__BackingField) - 1, b:  0);
            this.<LeftCountUi>k__BackingField = val_2;
            return val_2;
        }
        public int IncreaseGoal()
        {
            int val_1 = this.<LeftCount>k__BackingField;
            val_1 = val_1 + 1;
            this.<LeftCount>k__BackingField = val_1;
            return val_1;
        }
        public int IncreaseGoalUi()
        {
            int val_1 = this.<LeftCountUi>k__BackingField;
            val_1 = val_1 + 1;
            this.<LeftCountUi>k__BackingField = val_1;
            return val_1;
        }
        public void Reset()
        {
            this.<LeftCount>k__BackingField = this.<TargetCount>k__BackingField;
            this.<LeftCountUi>k__BackingField = this.<TargetCount>k__BackingField;
        }
        public bool IsGoalCompleted()
        {
            if((this.<LeftCount>k__BackingField) > 0)
            {
                    return false;
            }
            
            var val_2 = 0;
            if(mem[1152921505110024192] != null)
            {
                    val_2 = val_2 + 1;
                return this.goalCondition.IsSatisfied();
            }
            
            Royal.Scenes.Game.Mechanics.Goal.Conditions.IGoalCondition val_1 = 1152921505109987328 + ((mem[1152921505110024200]) << 4);
            return this.goalCondition.IsSatisfied();
        }
        private Royal.Scenes.Game.Mechanics.Goal.Conditions.IGoalCondition GetGoalCondition()
        {
            var val_3;
            var val_4;
            if((this.<GoalType>k__BackingField) == 13)
            {
                goto label_1;
            }
            
            if((this.<GoalType>k__BackingField) == 21)
            {
                goto label_2;
            }
            
            if((this.<GoalType>k__BackingField) != 30)
            {
                goto label_3;
            }
            
            label_1:
            Royal.Scenes.Game.Mechanics.Goal.Conditions.GrassGoalCondition val_1 = null;
            val_3 = val_1;
            val_1 = new Royal.Scenes.Game.Mechanics.Goal.Conditions.GrassGoalCondition();
            return (Royal.Scenes.Game.Mechanics.Goal.Conditions.IGoalCondition)val_3;
            label_2:
            val_4 = 1152921505109827584;
            goto label_5;
            label_3:
            val_4 = 1152921505109880832;
            label_5:
            Royal.Scenes.Game.Mechanics.Goal.Conditions.DefaultGoalCondition val_2 = null;
            val_3 = val_2;
            val_2 = new Royal.Scenes.Game.Mechanics.Goal.Conditions.DefaultGoalCondition();
            return (Royal.Scenes.Game.Mechanics.Goal.Conditions.IGoalCondition)val_3;
        }
    
    }

}
