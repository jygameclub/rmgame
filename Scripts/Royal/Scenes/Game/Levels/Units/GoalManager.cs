using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class GoalManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi <GoalPanel>k__BackingField;
        private Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] goals;
        private System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, int> OnGoalUpdated;
        private Royal.Scenes.Game.Levels.Units.GoalManager.GoalUpdatedUi OnGoalUpdatedUi;
        private System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, int> prerequisiteItems;
        private readonly System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, int> flyingMatchItemsCount;
        
        // Properties
        public int Id { get; }
        public Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi GoalPanel { get; set; }
        
        // Methods
        public int get_Id()
        {
            return 11;
        }
        public Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi get_GoalPanel()
        {
            return (Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi)this.<GoalPanel>k__BackingField;
        }
        public void set_GoalPanel(Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi value)
        {
            this.<GoalPanel>k__BackingField = value;
        }
        public void add_OnGoalUpdated(System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, int> value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnGoalUpdated, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGoalUpdated != 1152921523955380096);
            
            return;
            label_2:
        }
        public void remove_OnGoalUpdated(System.Action<Royal.Scenes.Game.Mechanics.Goal.GoalType, int> value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnGoalUpdated, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGoalUpdated != 1152921523955516672);
            
            return;
            label_2:
        }
        public void add_OnGoalUpdatedUi(Royal.Scenes.Game.Levels.Units.GoalManager.GoalUpdatedUi value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnGoalUpdatedUi, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGoalUpdatedUi != 1152921523955653256);
            
            return;
            label_2:
        }
        public void remove_OnGoalUpdatedUi(Royal.Scenes.Game.Levels.Units.GoalManager.GoalUpdatedUi value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnGoalUpdatedUi, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnGoalUpdatedUi != 1152921523955789832);
            
            return;
            label_2:
        }
        public void InitWithGoals(System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, Royal.Scenes.Game.Mechanics.Goal.GoalTuple> allGoals)
        {
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_4;
            object val_6;
            object val_10;
            this.ClearPrerequisiteItems();
            int val_1 = allGoals.Count;
            this.goals = new Royal.Scenes.Game.Mechanics.Goal.GoalTuple[0];
            Dictionary.Enumerator<TKey, TValue> val_3 = allGoals.GetEnumerator();
            var val_10 = 0;
            label_19:
            if(((-2125708704) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_4 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_10 = val_4;
            val_10.Reset();
            if(this.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            if(val_10 >= this.goals.Length)
            {
                    throw new IndexOutOfRangeException();
            }
            
            this.goals[val_10] = val_4;
            object[] val_7 = new object[2];
            val_6 = val_4;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_7.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[0] = val_6;
            if((val_4 + 24) != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_7[1] = val_4 + 24;
            val_10 = this;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "{0} goal = {1}", values:  val_7);
            var val_8 = (this.OnGoalUpdated == 0) ? 0 : this.OnGoalUpdated;
            if(this.OnGoalUpdated != null)
            {
                    if(val_8 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_10 = val_8;
                val_10.Invoke(arg1:  val_4, arg2:  val_4 + 24);
            }
            
            var val_9 = (this.OnGoalUpdatedUi == 0) ? 0 : this.OnGoalUpdatedUi;
            if(this.OnGoalUpdatedUi != null)
            {
                    if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_9.Invoke(goalType:  val_4, uiCount:  val_4 + 28, hasPrerequisite:  true, forStart:  true, isGoalCompleted:  false);
            }
            
            val_10 = this.flyingMatchItemsCount;
            if(val_10 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_10 = val_10 + 1;
            val_10.set_Item(key:  val_4, value:  0);
            goto label_19;
            label_2:
            val_6.Dispose();
        }
        public void ClearPrerequisiteItems()
        {
            this.prerequisiteItems.Clear();
        }
        public void AddToPrerequisite(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            if((this.prerequisiteItems.TryGetValue(key:  goalType, value: out  0)) != false)
            {
                    this.prerequisiteItems.set_Item(key:  goalType, value:  1);
                return;
            }
            
            this.prerequisiteItems.Add(key:  goalType, value:  1);
        }
        public void RemoveFromPrerequisite(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            if((this.prerequisiteItems.TryGetValue(key:  goalType, value: out  0)) == false)
            {
                    return;
            }
            
            if()
            {
                    this.prerequisiteItems.set_Item(key:  goalType, value:  -1);
                return;
            }
            
            bool val_3 = this.prerequisiteItems.Remove(key:  goalType);
        }
        public Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] GetGoals()
        {
            return (Royal.Scenes.Game.Mechanics.Goal.GoalTuple[])this.goals;
        }
        public void DecreaseGoal(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            int val_4;
            int val_1 = this.GetGoalIndex(goalType:  goalType);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            int val_2 = this.goals[val_1].DecreaseGoal();
            val_4 = val_2;
            if(val_2 <= 9)
            {
                    object[] val_3 = new object[2];
                val_3[0] = goalType;
                val_3[1] = val_4;
                Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "{0} goal = {1}", values:  val_3);
            }
            
            if(this.OnGoalUpdated == null)
            {
                    return;
            }
            
            this.OnGoalUpdated.Invoke(arg1:  goalType, arg2:  val_4);
        }
        public void DecreaseGoalUi(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32> val_10;
            if((this.flyingMatchItemsCount.ContainsKey(key:  goalType)) != false)
            {
                    val_10 = this.flyingMatchItemsCount;
                val_10.set_Item(key:  goalType, value:  val_10.Item[goalType] - 1);
            }
            
            int val_4 = this.GetGoalIndex(goalType:  goalType);
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            val_10 = val_4;
            1152921523956970816 = this.OnGoalUpdatedUi;
            if(1152921523956970816 == null)
            {
                    return;
            }
            
            1152921523956970816.Invoke(goalType:  goalType, uiCount:  this.goals[(long)val_10].DecreaseGoalUi(), hasPrerequisite:  this.prerequisiteItems.ContainsKey(key:  goalType), forStart:  false, isGoalCompleted:  this.goals[(long)val_10].IsGoalCompleted());
        }
        public void ForceUpdateGoal(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            var val_6;
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] val_7;
            int val_1 = this.GetGoalIndex(goalType:  goalType);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            val_7 = this.goals;
            val_6 = val_1;
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_6 = val_7[(long)val_6];
            if(this.OnGoalUpdated != null)
            {
                    this.OnGoalUpdated.Invoke(arg1:  goalType, arg2:  this.goals[(long)(int)(val_1)][0].<LeftCount>k__BackingField);
                val_7 = this.goals;
            }
            
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_7 = val_7[(long)val_6];
            if(this.OnGoalUpdatedUi == null)
            {
                    return;
            }
            
            this.OnGoalUpdatedUi.Invoke(goalType:  goalType, uiCount:  this.goals[(long)(int)(val_1)][0].<LeftCountUi>k__BackingField, hasPrerequisite:  this.prerequisiteItems.ContainsKey(key:  goalType), forStart:  false, isGoalCompleted:  this.goals[(long)val_6].IsGoalCompleted());
        }
        public void IncreaseGoal(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            int val_1 = this.GetGoalIndex(goalType:  goalType);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.OnGoalUpdated == null)
            {
                    return;
            }
            
            this.OnGoalUpdated.Invoke(arg1:  goalType, arg2:  this.goals[val_1].IncreaseGoal());
        }
        public void IncreaseGoalUi(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            var val_7;
            int val_1 = this.GetGoalIndex(goalType:  goalType);
            if((val_1 & 2147483648) != 0)
            {
                    return;
            }
            
            val_7 = val_1;
            if(this.OnGoalUpdatedUi == null)
            {
                    return;
            }
            
            this.OnGoalUpdatedUi.Invoke(goalType:  goalType, uiCount:  this.goals[(long)val_7].IncreaseGoalUi(), hasPrerequisite:  this.prerequisiteItems.ContainsKey(key:  goalType), forStart:  false, isGoalCompleted:  this.goals[(long)val_7].IsGoalCompleted());
        }
        public int GetGoalTargetCount(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            int val_2;
            if(this.goals != null)
            {
                    int val_1 = this.GetGoalIndex(goalType:  goalType);
                if((val_1 & 2147483648) == 0)
            {
                    Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_2 = this.goals[val_1];
                val_2 = this.goals[val_1][0].<TargetCount>k__BackingField;
                return (int)val_2;
            }
            
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public int GetGoalLeftCount(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            int val_2;
            int val_1 = this.GetGoalIndex(goalType:  goalType);
            if((val_1 & 2147483648) == 0)
            {
                    Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_2 = this.goals[val_1];
                val_2 = this.goals[val_1][0].<LeftCount>k__BackingField;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public int GetGoalUiLeftCount(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            int val_2;
            int val_1 = this.GetGoalIndex(goalType:  goalType);
            if((val_1 & 2147483648) == 0)
            {
                    Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_2 = this.goals[val_1];
                val_2 = this.goals[val_1][0].<LeftCountUi>k__BackingField;
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public bool IsAllGoalsReached()
        {
            if(this.prerequisiteItems.Count > 0)
            {
                    return false;
            }
            
            var val_4 = 0;
            do
            {
                if(val_4 >= this.goals.Length)
            {
                    return false;
            }
            
                if(this.goals[val_4].IsGoalCompleted() == false)
            {
                    return false;
            }
            
                val_4 = val_4 + 1;
            }
            while(this.goals != null);
            
            throw new NullReferenceException();
        }
        public int GetGoalIndex(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            var val_1;
            if(this.goals.Length >= 1)
            {
                    val_1 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_1 = this.goals[val_1];
                if((this.goals[0x0][0].<GoalType>k__BackingField) == goalType)
            {
                    return (int)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < this.goals.Length);
            
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        public void Bind()
        {
        
        }
        public void Clear(bool gameExit)
        {
            this.goals = 0;
            if(gameExit == false)
            {
                    return;
            }
            
            this.OnGoalUpdated = 0;
            this.OnGoalUpdatedUi = 0;
        }
        public UnityEngine.Vector3 GetGoalPosition(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            if((this.<GoalPanel>k__BackingField) != null)
            {
                    return this.<GoalPanel>k__BackingField.GetGoalPosition(goalType:  goalType);
            }
            
            throw new NullReferenceException();
        }
        public void FlyingToBeCollected(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            this.flyingMatchItemsCount.set_Item(key:  goalType, value:  this.flyingMatchItemsCount.Item[goalType] + 1);
        }
        public int GetFlyingGoalCount(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            return this.flyingMatchItemsCount.Item[goalType];
        }
        public bool HaveAnyFlyingMatchItemsToCollect(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            return (bool)(this.flyingMatchItemsCount.Item[goalType] > 0) ? 1 : 0;
        }
        public void ReplaceGoalsWithCoin(int coinAmount)
        {
            this.ClearPrerequisiteItems();
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] val_1 = new Royal.Scenes.Game.Mechanics.Goal.GoalTuple[1];
            this.goals = val_1;
            val_1[0] = new Royal.Scenes.Game.Mechanics.Goal.GoalTuple(goalType:  21, targetCount:  coinAmount, isFromSettings:  false);
            this.flyingMatchItemsCount.set_Item(key:  21, value:  0);
            this.<GoalPanel>k__BackingField.ReplaceGoalsWithCoin();
        }
        public GoalManager()
        {
            this.prerequisiteItems = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>();
            this.flyingMatchItemsCount = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Goal.GoalType, System.Int32>();
        }
    
    }

}
