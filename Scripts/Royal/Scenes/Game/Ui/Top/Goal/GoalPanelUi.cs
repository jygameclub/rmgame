using UnityEngine;

namespace Royal.Scenes.Game.Ui.Top.Goal
{
    public class GoalPanelUi : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Game.Ui.Top.Goal.GoalUi GoalUiPrefab;
        private static readonly UnityEngine.Vector2 CountPositionFor1;
        private static readonly UnityEngine.Vector2 CountPositionFor2;
        private static readonly UnityEngine.Vector2 CountPositionFor3;
        private static readonly UnityEngine.Vector2 CountPositionFor4;
        private static readonly UnityEngine.Vector3[] PositionsFor2;
        private static readonly UnityEngine.Vector3[] PositionsFor3;
        private static readonly UnityEngine.Vector3[] PositionsFor4;
        private System.Collections.Generic.Dictionary<int, Royal.Scenes.Game.Ui.Top.Goal.GoalUi> goalUiDictionary;
        
        // Methods
        private void Awake()
        {
            Royal.Scenes.Game.Levels.Units.GoalManager val_16 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory val_2 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            UnityEngine.Vector3 val_4 = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.GetScaleForGoal(maxGoals:  val_1.goals.Length);
            this.goalUiDictionary = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Ui.Top.Goal.GoalUi>(capacity:  val_1.goals.Length);
            if(val_1.goals.Length >= 1)
            {
                    var val_15 = 0;
                Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] val_14 = val_1.goals[32];
                do
            {
                UnityEngine.Vector3 val_6 = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.GetPositionForGoal(maxGoals:  val_1.goals.Length, goalIndex:  0);
                Royal.Scenes.Game.Ui.Top.Goal.GoalUi val_8 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Ui.Top.Goal.GoalUi>(original:  this.GoalUiPrefab, parent:  this.transform);
                val_8.Init(goalTuple:  val_1.goals[0x20] + 0, goalAsset:  val_2.assetsLibrary.GetItemGoalAsset(goalType:  val_1.goals[0x20] + 0 + 16));
                this.goalUiDictionary.Add(key:  val_1.goals[0x20] + 0 + 16, value:  val_8);
                UnityEngine.Vector2 val_10 = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.GetCountPositionForGoal(maxGoals:  val_1.goals.Length);
                val_8.SetCountPosition(position:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
                val_16.add_OnGoalUpdatedUi(value:  new GoalManager.GoalUpdatedUi(object:  val_8, method:  public System.Void Royal.Scenes.Game.Ui.Top.Goal.GoalUi::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType type, int count, bool hasPrerequisite, bool isUpdatedForStartValue, bool isGoalCompleted)));
                Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).add_OnCellGridInitialized(value:  new System.Action(object:  val_8, method:  public System.Void Royal.Scenes.Game.Ui.Top.Goal.GoalUi::Reset()));
                UnityEngine.Transform val_13 = val_8.transform;
                val_13.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                val_13.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                val_15 = val_15 + 1;
            }
            while(val_15 < val_1.goals.Length);
            
            }
            
            val_16 = this;
        }
        private static UnityEngine.Vector2 GetCountPositionForGoal(int maxGoals)
        {
            if((maxGoals - 1) <= 3)
            {
                    var val_3 = 36532648 + ((maxGoals - 1)) << 2;
                val_3 = val_3 + 36532648;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.CountPositionFor4, y = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.CountPositionFor1.__il2cppRuntimeField_1C};
            }
        
        }
        private static UnityEngine.Vector3 GetPositionForGoal(int maxGoals, int goalIndex)
        {
            if((maxGoals - 1) <= 3)
            {
                    var val_3 = 36532632 + ((maxGoals - 1)) << 2;
                val_3 = val_3 + 36532632;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
                return new UnityEngine.Vector3() {x = ((long)(int)(goalIndex) * 12) + Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.PositionsFor3 + 32, y = ((long)(int)(goalIndex) * 12) + Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.PositionsFor3 + 32 + 4, z = ((long)(int)(goalIndex) * 12) + Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.PositionsFor3 + 40};
            }
        
        }
        private static UnityEngine.Vector3 GetScaleForGoal(int maxGoals)
        {
            if((maxGoals - 3) < 2)
            {
                goto label_1;
            }
            
            if(maxGoals == 2)
            {
                goto label_2;
            }
            
            return UnityEngine.Vector3.one;
            label_1:
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.9f);
            label_2:
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.9f);
        }
        public UnityEngine.Vector3 GetGoalPosition(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType)
        {
            Royal.Scenes.Game.Ui.Top.Goal.GoalUi val_1 = 0;
            if((this.goalUiDictionary.TryGetValue(key:  goalType, value: out  val_1)) != false)
            {
                    if(val_1 != 0)
            {
                goto label_3;
            }
            
            }
            
            object[] val_3 = new object[1];
            val_3[0] = goalType;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Goal [{0}] is missing from goal ui.", values:  val_3);
            label_3:
            UnityEngine.Vector3 val_5 = this.transform.position;
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void ReplaceGoalsWithCoin()
        {
            var val_3;
            var val_4;
            System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Ui.Top.Goal.GoalUi> val_21;
            System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Ui.Top.Goal.GoalUi> val_22;
            val_21 = null;
            val_21 = null;
            if((Royal.Scenes.Game.Context.GameContext.<Controller>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(Royal.Scenes.Game.Ui == null)
            {
                    throw new NullReferenceException();
            }
            
            AnimateTargetTextAsReward();
            val_21 = this.goalUiDictionary;
            if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.ValueCollection<TKey, TValue> val_1 = val_21.Values;
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = val_1.GetEnumerator();
            label_15:
            if(((-1893629728) & 1) == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Object.Destroy(obj:  val_3.gameObject);
            goto label_15;
            label_11:
            val_4.Dispose();
            Royal.Scenes.Game.Levels.Units.GoalManager val_21 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_6.goals == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_8 = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.GetScaleForGoal(maxGoals:  val_6.goals.Length);
            System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Ui.Top.Goal.GoalUi> val_9 = null;
            val_22 = val_9;
            val_9 = new System.Collections.Generic.Dictionary<System.Int32, Royal.Scenes.Game.Ui.Top.Goal.GoalUi>(capacity:  val_6.goals.Length);
            this.goalUiDictionary = val_22;
            if(val_6.goals.Length >= 1)
            {
                    Royal.Scenes.Game.Mechanics.Goal.GoalTuple[] val_20 = val_6.goals[32];
                do
            {
                UnityEngine.Vector3 val_10 = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.GetPositionForGoal(maxGoals:  val_6.goals.Length, goalIndex:  0);
                Royal.Scenes.Game.Ui.Top.Goal.GoalUi val_12 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Ui.Top.Goal.GoalUi>(original:  this.GoalUiPrefab, parent:  this.transform);
                if((Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1)) == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_6.goals[0x20] + 0) == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_21 = val_7.assetsLibrary;
                if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_12 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_12.Init(goalTuple:  val_6.goals[0x20] + 0, goalAsset:  val_21.GetItemGoalAsset(goalType:  val_6.goals[0x20] + 0 + 16));
                val_21 = this.goalUiDictionary;
                if(val_21 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_21.Add(key:  val_6.goals[0x20] + 0 + 16, value:  val_12);
                UnityEngine.Vector2 val_14 = Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.GetCountPositionForGoal(maxGoals:  val_6.goals.Length);
                val_12.SetCountPosition(position:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
                val_21.add_OnGoalUpdatedUi(value:  new GoalManager.GoalUpdatedUi(object:  val_12, method:  public System.Void Royal.Scenes.Game.Ui.Top.Goal.GoalUi::OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType type, int count, bool hasPrerequisite, bool isUpdatedForStartValue, bool isGoalCompleted)));
                UnityEngine.Transform val_16 = val_12.transform;
                if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_16.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
                val_16.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_16, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.25f), ease:  27);
                val_22 = 0 + 1;
            }
            while(val_22 < val_6.goals.Length);
            
            }
            
            val_21 = this;
        }
        public GoalPanelUi()
        {
        
        }
        private static GoalPanelUi()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0.353f, y:  -0.336f);
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.CountPositionFor1 = val_1.x;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.261f, y:  -0.353f);
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.CountPositionFor2 = val_2.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0.353f, y:  -0.336f);
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.CountPositionFor3 = val_3.x;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0.353f, y:  -0.336f);
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.CountPositionFor4 = val_4.x;
            UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[2];
            val_5[0] = 0;
            val_5[1] = 0;
            val_5[1] = 0;
            val_5[2] = 0;
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.PositionsFor2 = val_5;
            UnityEngine.Vector3[] val_6 = new UnityEngine.Vector3[3];
            val_6[0] = 0;
            val_6[1] = 0;
            val_6[1] = 0;
            val_6[2] = 0;
            val_6[3] = 0;
            val_6[4] = 0;
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.PositionsFor3 = val_6;
            UnityEngine.Vector3[] val_7 = new UnityEngine.Vector3[4];
            val_7[0] = 0;
            val_7[1] = 0;
            val_7[1] = 0;
            val_7[2] = 0;
            val_7[3] = 0;
            val_7[4] = 0;
            val_7[4] = 0;
            val_7[5] = 0;
            Royal.Scenes.Game.Ui.Top.Goal.GoalPanelUi.PositionsFor4 = val_7;
        }
    
    }

}
