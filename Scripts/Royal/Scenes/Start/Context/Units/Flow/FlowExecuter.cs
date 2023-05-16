using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public class FlowExecuter
    {
        // Fields
        private readonly System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> list;
        private readonly System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> autoList;
        private readonly System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> nextList;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>> innerFlowDictionary;
        private readonly Royal.Infrastructure.Utils.Counters.DisableCounter nextActionMode;
        private readonly Royal.Infrastructure.Utils.Counters.DisableCounter pauseCounter;
        private readonly Royal.Infrastructure.Utils.Counters.EnableCounter nextActionOnPush;
        private System.Guid innerFlowStartActionId;
        private Royal.Scenes.Start.Context.Units.Flow.FlowAction runningAction;
        private bool <IsInnerFlowExecuting>k__BackingField;
        private bool <IsInnerFlowInitializing>k__BackingField;
        
        // Properties
        public bool IsOnNextActionMode { get; }
        public bool IsPaused { get; }
        public bool IsInnerFlowExecuting { get; set; }
        public bool IsInnerFlowInitializing { get; set; }
        public bool HasAutoAction { get; }
        public bool HasInnerAutoAction { get; }
        
        // Methods
        public bool get_IsOnNextActionMode()
        {
            if(this.nextActionMode != null)
            {
                    return this.nextActionMode.IsEnabled();
            }
            
            throw new NullReferenceException();
        }
        public bool get_IsPaused()
        {
            if(this.pauseCounter != null)
            {
                    return this.pauseCounter.IsEnabled();
            }
            
            throw new NullReferenceException();
        }
        public bool get_IsInnerFlowExecuting()
        {
            return (bool)this.<IsInnerFlowExecuting>k__BackingField;
        }
        private void set_IsInnerFlowExecuting(bool value)
        {
            this.<IsInnerFlowExecuting>k__BackingField = value;
        }
        public bool get_IsInnerFlowInitializing()
        {
            return (bool)this.<IsInnerFlowInitializing>k__BackingField;
        }
        private void set_IsInnerFlowInitializing(bool value)
        {
            this.<IsInnerFlowInitializing>k__BackingField = value;
        }
        public bool get_HasAutoAction()
        {
            return (bool)(this.autoList > 0) ? 1 : 0;
        }
        public bool get_HasInnerAutoAction()
        {
            var val_3;
            var val_4;
            var val_9;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_9 = this;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.innerFlowDictionary.Values.GetEnumerator();
            val_11 = 0;
            label_14:
            val_12 = public System.Boolean Dictionary.ValueCollection.Enumerator<System.Guid, System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>>::MoveNext();
            if((1420550704 & 1) == 0)
            {
                goto label_3;
            }
            
            val_13 = val_3;
            if(val_13 == 0)
            {
                    throw new NullReferenceException();
            }
            
            LinkedList.Enumerator<T> val_5 = val_13.GetEnumerator();
            label_7:
            if((1420550656 & 1) == 0)
            {
                goto label_5;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_3 != 3)
            {
                goto label_7;
            }
            
            val_14 = 0 + 1;
            val_9 = 0;
            mem2[0] = 105;
            val_11 = 1;
            goto label_19;
            label_5:
            val_14 = 0 + 1;
            val_9 = 0;
            mem2[0] = 78;
            label_19:
            val_4.Dispose();
            if(val_9 != 0)
            {
                goto label_15;
            }
            
            if(val_14 == 1)
            {
                goto label_14;
            }
            
            if((1152921518912299456 + ((0 + 1)) << 2) == 78)
            {
                goto label_11;
            }
            
            if((1152921518912299456 + ((0 + 1)) << 2) != 105)
            {
                goto label_14;
            }
            
            goto label_13;
            label_11:
            var val_9 = 0;
            val_9 = val_9 ^ (val_14 >> 31);
            var val_7 = val_14 + val_9;
            goto label_14;
            label_3:
            val_14 = 0 + 1;
            mem2[0] = 103;
            label_13:
            val_4.Dispose();
            if(val_14 != 1)
            {
                    val_15 = val_11 & (((1152921518912299456 + ((0 + 1)) << 2) == 105) ? 1 : 0);
                return (bool)val_15;
            }
            
            val_15 = 0;
            return (bool)val_15;
            label_15:
            val_13 = val_9;
            val_12 = 0;
            throw val_13;
        }
        public void Clear(bool alsoRunningAction = True)
        {
            var val_1;
            this.list.Clear();
            this.autoList.Clear();
            this.innerFlowDictionary.Clear();
            val_1 = null;
            val_1 = null;
            this.innerFlowStartActionId = System.Guid.Empty;
            this.pauseCounter.Reset();
            this.<IsInnerFlowExecuting>k__BackingField = false;
            this.<IsInnerFlowInitializing>k__BackingField = false;
            if(alsoRunningAction == false)
            {
                    return;
            }
            
            if(this.runningAction == null)
            {
                    return;
            }
            
            this.runningAction = 0;
        }
        public void ManualUpdate()
        {
            this.NextAction();
        }
        public void Push(Royal.Scenes.Start.Context.Units.Flow.FlowAction action)
        {
            if(action != null)
            {
                    this.InitializeInnerFlowFinishAction();
                this.AddActionToList(newAction:  action);
                if(this.nextActionOnPush.IsEnabled() != false)
            {
                    this.NextAction();
            }
            
                var val_2 = (((Royal.Scenes.Start.Context.Units.Flow.FlowAction.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Start.Context.Units.Flow.InnerFlowStartAction.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? action : 0;
                return;
            }
            
            this.AddActionToList(newAction:  action);
            throw new NullReferenceException();
        }
        private void InitializeInnerFlowFinishAction()
        {
            var val_3;
            System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_1 = this.innerFlowDictionary.Item[new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId}];
            if((public System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>>::get_Item(System.Guid key)) == 0)
            {
                    bool val_2 = this.innerFlowDictionary.Remove(key:  new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId});
            }
            
            this.<IsInnerFlowInitializing>k__BackingField = false;
            val_3 = null;
            val_3 = null;
            this.innerFlowStartActionId = System.Guid.Empty;
        }
        private void InitializeInnerFlowStartAction(System.Guid actionId)
        {
            this.innerFlowStartActionId = actionId;
            mem[1152921518912984416] = actionId._d;
            mem[1152921518912984417] = actionId._e;
            mem[1152921518912984418] = actionId._f;
            mem[1152921518912984419] = actionId._g;
            mem[1152921518912984420] = actionId._h;
            mem[1152921518912984421] = actionId._i;
            mem[1152921518912984422] = actionId._j;
            mem[1152921518912984423] = actionId._k;
            this.<IsInnerFlowInitializing>k__BackingField = true;
            this.innerFlowDictionary.Add(key:  new System.Guid() {_a = actionId._a, _b = actionId._b, _c = actionId._c, _d = actionId._d, _e = actionId._e, _f = actionId._f, _g = actionId._g, _h = actionId._h, _i = actionId._i, _j = actionId._j, _k = actionId._k}, value:  new System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>());
        }
        public Royal.Scenes.Start.Context.Units.Flow.FlowAction GetRunningAction()
        {
            return (Royal.Scenes.Start.Context.Units.Flow.FlowAction)this.runningAction;
        }
        private void AddActionToList(Royal.Scenes.Start.Context.Units.Flow.FlowAction newAction)
        {
            object val_15;
            Royal.Infrastructure.Utils.Counters.DisableCounter val_16;
            System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_17;
            Royal.Infrastructure.Services.Logs.LogTag val_18;
            var val_19;
            System.Type val_20;
            val_15 = this;
            val_16 = this.nextActionMode;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_16.IsEnabled() == false)
            {
                goto label_2;
            }
            
            val_17 = this.nextList;
            object[] val_2 = new object[2];
            if(newAction == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_2[0] = newAction.GetType();
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_2[1] = val_2.Length;
            val_18 = 4;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  val_18, log:  "Action added to next list {0} - count: {1}", values:  val_2);
            goto label_43;
            label_2:
            if(newAction == null)
            {
                    throw new NullReferenceException();
            }
            
            if(newAction != 3)
            {
                goto label_14;
            }
            
            if((this.<IsInnerFlowInitializing>k__BackingField) == true)
            {
                goto label_17;
            }
            
            val_17 = this.autoList;
            goto label_43;
            label_14:
            if((this.<IsInnerFlowInitializing>k__BackingField) != true)
            {
                    if((this.<IsInnerFlowExecuting>k__BackingField) == false)
            {
                goto label_43;
            }
            
            }
            
            label_17:
            val_16 = this.innerFlowDictionary;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_18 = this.innerFlowStartActionId;
            val_17 = val_16.Item[new System.Guid() {_a = val_18, _b = val_18, _c = val_18}];
            label_43:
            if((newAction & 1) != 0)
            {
                goto label_47;
            }
            
            val_16 = this.nextActionMode;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_19 = 0;
            if(val_16.IsEnabled() == false)
            {
                goto label_22;
            }
            
            label_47:
            if(newAction == 1)
            {
                goto label_23;
            }
            
            val_16 = newAction;
            if(val_16 != 2)
            {
                goto label_24;
            }
            
            label_23:
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.Collections.Generic.LinkedListNode<T> val_6 = val_17.AddFirst(value:  newAction);
            return;
            label_22:
            if((newAction & 1) != 0)
            {
                goto label_27;
            }
            
            if(this.runningAction == null)
            {
                goto label_28;
            }
            
            val_20 = this.runningAction.GetType();
            goto label_29;
            label_24:
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            System.Collections.Generic.LinkedListNode<T> val_8 = val_17.AddLast(value:  newAction);
            return;
            label_28:
            val_20 = 0;
            label_29:
            System.Type val_9 = newAction.GetType();
            val_16 = val_20;
            if((System.Type.op_Equality(left:  val_16, right:  val_9)) == true)
            {
                    return;
            }
            
            label_27:
            if(val_17 == null)
            {
                    throw new NullReferenceException();
            }
            
            if((Royal.Scenes.Start.Context.Units.Flow.FlowExecuter.ReplaceActionInList(newAction:  newAction, node:  val_9)) == true)
            {
                    return;
            }
            
            val_16 = this.innerFlowDictionary;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.ValueCollection<TKey, TValue> val_12 = val_16.Values;
            if(val_12 == null)
            {
                    throw new NullReferenceException();
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_13 = val_12.GetEnumerator();
            val_15 = 1152921518912282576;
            label_41:
            if((1421539720 & 1) == 0)
            {
                goto label_39;
            }
            
            if((Royal.Scenes.Start.Context.Units.Flow.FlowExecuter.ReplaceActionInList(newAction:  newAction, node:  11993091)) == false)
            {
                goto label_41;
            }
            
            0.Dispose();
            return;
            label_39:
            0.Dispose();
            goto label_47;
        }
        private static bool ReplaceActionInList(Royal.Scenes.Start.Context.Units.Flow.FlowAction newAction, System.Collections.Generic.LinkedListNode<Royal.Scenes.Start.Context.Units.Flow.FlowAction> node)
        {
            var val_6;
            if(node == null)
            {
                goto label_1;
            }
            
            label_7:
            if((System.Type.op_Equality(left:  newAction.GetType(), right:  GetType())) == true)
            {
                goto label_6;
            }
            
            if(node.Next != null)
            {
                goto label_7;
            }
            
            return (bool)val_6;
            label_1:
            val_6 = 0;
            return (bool)val_6;
            label_6:
            node = newAction;
            val_6 = 1;
            return (bool)val_6;
        }
        private void NextAction()
        {
            object val_18;
            Royal.Scenes.Start.Context.Units.Flow.FlowAction val_19;
            label_47:
            val_18 = this;
            if(this.pauseCounter.IsEnabled() == true)
            {
                    return;
            }
            
            if(this.runningAction != null)
            {
                    return;
            }
            
            if((this.<IsInnerFlowExecuting>k__BackingField) == false)
            {
                goto label_4;
            }
            
            if((this.innerFlowDictionary.ContainsKey(key:  new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId})) == false)
            {
                goto label_6;
            }
            
            System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_3 = this.innerFlowDictionary.Item[new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId}];
            if(1152921518913628688 < 1)
            {
                goto label_9;
            }
            
            System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_4 = this.innerFlowDictionary.Item[new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId}];
            this.runningAction = public System.Void Royal.Scenes.Game.Levels.Units.Pool.LevelGameObjectPool::CreatePool<Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView>(Royal.Scenes.Game.Mechanics.Items.PiggyItem.View.PiggyItemView go, int amount);
            this.innerFlowDictionary.Item[new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId}].RemoveFirst();
            object[] val_6 = new object[2];
            val_6[0] = this.runningAction.GetType();
            val_6[1] = this.innerFlowStartActionId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  16, log:  "{0} Is Executed In InnerFlow With Id:{1}", values:  val_6);
            this.runningAction.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Flow.FlowExecuter::ActionCompleted()));
            return;
            label_4:
            if((this.<IsInnerFlowExecuting>k__BackingField) < true)
            {
                goto label_28;
            }
            
            this.runningAction = this.<IsInnerFlowExecuting>k__BackingField + 40;
            this.list.RemoveFirst();
            label_52:
            this.runningAction.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Flow.FlowExecuter::ActionCompleted()));
            val_18 = ???;
            goto typeof(Royal.Scenes.Start.Context.Units.Flow.FlowAction).__il2cppRuntimeField_190;
            label_6:
            object[] val_10 = new object[1];
            val_10[0] = val_18 + 72;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_18, logTag:  16, log:  "Not In Dictionary InnerFlow With Id:{0}", values:  val_10);
            val_18 = 0;
            return;
            label_28:
            if((this.<IsInnerFlowExecuting>k__BackingField) < true)
            {
                    return;
            }
            
            val_19 = mem[this.<IsInnerFlowExecuting>k__BackingField + 40];
            val_19 = this.<IsInnerFlowExecuting>k__BackingField + 40;
            this.autoList.RemoveFirst();
            if(Royal.Scenes.Home.Context.HomeContext.ShouldDelayAutoActions() == false)
            {
                goto label_42;
            }
            
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12).DelayAutoAction(action:  val_19);
            return;
            label_9:
            this.<IsInnerFlowExecuting>k__BackingField = false;
            bool val_13 = this.innerFlowDictionary.Remove(key:  new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId});
            goto label_47;
            label_42:
            if((val_19 & 1) == 0)
            {
                    Royal.Scenes.Start.Context.Units.Flow.FlowAction val_14 = this.FindClaimAction();
                if(val_14 != null)
            {
                    System.Collections.Generic.LinkedListNode<T> val_15 = this.autoList.AddFirst(value:  val_19);
                val_19 = val_14;
            }
            
            }
            
            this.runningAction = val_19;
            System.Action val_16 = new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Flow.FlowExecuter::ActionCompleted());
            goto label_52;
        }
        private Royal.Scenes.Start.Context.Units.Flow.FlowAction FindClaimAction()
        {
            var val_2;
            if((W9 == 0) || (1 == 0))
            {
                goto label_3;
            }
            
            label_6:
            if(((public static System.String UnityEngine.JsonUtility::ToJson(object obj)) & 1) != 0)
            {
                goto label_5;
            }
            
            if(Next != null)
            {
                goto label_6;
            }
            
            return (Royal.Scenes.Start.Context.Units.Flow.FlowAction)val_2;
            label_3:
            val_2 = 0;
            return (Royal.Scenes.Start.Context.Units.Flow.FlowAction)val_2;
            label_5:
            this.autoList.Remove(node:  47587328);
            val_2 = public static System.String UnityEngine.JsonUtility::ToJson(object obj);
            return (Royal.Scenes.Start.Context.Units.Flow.FlowAction)val_2;
        }
        private void ActionCompleted()
        {
            this.runningAction.remove_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Start.Context.Units.Flow.FlowExecuter::ActionCompleted()));
            this.runningAction = 0;
            this.NextAction();
        }
        public bool HasActionInFlow(System.Type actionType)
        {
            var val_3;
            var val_4;
            var val_23;
            var val_24;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_24 = this;
            LinkedList.Enumerator<T> val_1 = this.list.GetEnumerator();
            label_6:
            if((1422532192 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.Type.op_Equality(left:  val_3.GetType(), right:  actionType)) == false)
            {
                goto label_6;
            }
            
            val_26 = 1;
            val_27 = 242;
            goto label_7;
            label_2:
            val_26 = 0;
            val_27 = 66;
            label_7:
            val_4.Dispose();
            if(66 == 242)
            {
                    return (bool)val_33;
            }
            
            LinkedList.Enumerator<T> val_8 = this.autoList.GetEnumerator();
            label_14:
            val_28 = public System.Boolean LinkedList.Enumerator<Royal.Scenes.Start.Context.Units.Flow.FlowAction>::MoveNext();
            if((1422532192 & 1) == 0)
            {
                goto label_10;
            }
            
            val_29 = val_3;
            if(val_29 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.Type.op_Equality(left:  val_29.GetType(), right:  actionType)) == false)
            {
                goto label_14;
            }
            
            val_26 = 1;
            val_30 = 242;
            goto label_15;
            label_10:
            val_30 = 132;
            label_15:
            val_31 = ((long)(66 == 66) ? -1 : 0) + 1;
            mem2[0] = 132;
            val_4.Dispose();
            if(val_31 != 1)
            {
                    if((1152921518914280944 + (((long)(int)(0x42 == 0x42 ? -1 : 0) + 1)) << 2) == 242)
            {
                    return (bool)val_33;
            }
            
                var val_11 = ((1152921518914280944 + (((long)(int)(0x42 == 0x42 ? -1 : 0) + 1)) << 2) == 132) ? 1 : 0;
                val_11 = ((val_31 >= 0) ? 1 : 0) & val_11;
                val_31 = val_31 - val_11;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_14 = this.innerFlowDictionary.Values.GetEnumerator();
            label_33:
            val_28 = public System.Boolean Dictionary.ValueCollection.Enumerator<System.Guid, System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>>::MoveNext();
            if((1422532160 & 1) == 0)
            {
                goto label_20;
            }
            
            val_29 = val_3;
            if(val_29 == 0)
            {
                    throw new NullReferenceException();
            }
            
            LinkedList.Enumerator<T> val_15 = val_29.GetEnumerator();
            label_26:
            if((1422532192 & 1) == 0)
            {
                goto label_22;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.Type.op_Equality(left:  val_3.GetType(), right:  actionType)) == false)
            {
                goto label_26;
            }
            
            val_32 = val_31 + 1;
            val_24 = 0;
            mem2[0] = 242;
            val_23 = 1;
            goto label_40;
            label_22:
            val_32 = val_31 + 1;
            val_24 = 0;
            mem2[0] = 215;
            label_40:
            val_4.Dispose();
            if(val_24 != 0)
            {
                goto label_28;
            }
            
            if(val_32 == 1)
            {
                goto label_33;
            }
            
            if((1152921518914280944 + (((((long)(int)(0x42 == 0x42 ? -1 : 0) + 1) - (val_31 >= 0x0 ? 1 : 0 & 1152921518914280944 + (((long)(int)(0x42 == 0x42 ? -1 : 0) + 1)) << 2 == 0x84 ? 1 : 0)) + 1)) << 2) == 215)
            {
                goto label_30;
            }
            
            if((1152921518914280944 + (((((long)(int)(0x42 == 0x42 ? -1 : 0) + 1) - (val_31 >= 0x0 ? 1 : 0 & 1152921518914280944 + (((long)(int)(0x42 == 0x42 ? -1 : 0) + 1)) << 2 == 0x84 ? 1 : 0)) + 1)) << 2) != 242)
            {
                goto label_33;
            }
            
            goto label_32;
            label_30:
            var val_20 = 0;
            val_20 = val_20 ^ (val_32 >> 31);
            var val_18 = val_32 + val_20;
            goto label_33;
            label_20:
            val_32 = val_31 + 1;
            mem2[0] = 240;
            label_32:
            val_4.Dispose();
            if(val_32 != 1)
            {
                    val_33 = val_26 & (((1152921518914280944 + (((((long)(int)(0x42 == 0x42 ? -1 : 0) + 1) - (val_31 >= 0x0 ? 1 : 0 & 1152921518914280944 + (((long)(int)(0x42 == 0x42 ? -1 : 0) + 1)) << 2 == 0x84 ? 1 : 0)) + 1)) << 2) == 242) ? 1 : 0);
                return (bool)val_33;
            }
            
            val_33 = 0;
            return (bool)val_33;
            label_28:
            val_29 = val_24;
            val_28 = 0;
            throw val_29;
        }
        public void StartInnerFlow(System.Guid id)
        {
            object[] val_1 = new object[1];
            val_1[0] = id;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  16, log:  "InnerFlow Started With Id:{0}", values:  val_1);
            this.innerFlowStartActionId = id;
            mem[1152921518914447408] = id._d;
            mem[1152921518914447409] = id._e;
            mem[1152921518914447410] = id._f;
            mem[1152921518914447411] = id._g;
            mem[1152921518914447412] = id._h;
            mem[1152921518914447413] = id._i;
            mem[1152921518914447414] = id._j;
            mem[1152921518914447415] = id._k;
            this.<IsInnerFlowExecuting>k__BackingField = true;
        }
        public void FinishInnerFlow()
        {
            var val_2;
            object[] val_1 = new object[1];
            val_1[0] = this.innerFlowStartActionId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  16, log:  "InnerFlow Finished With Id:{0} ", values:  val_1);
            val_2 = null;
            val_2 = null;
            this.<IsInnerFlowExecuting>k__BackingField = false;
            this.innerFlowStartActionId = System.Guid.Empty;
        }
        public void Pause()
        {
            if(this.pauseCounter != null)
            {
                    this.pauseCounter.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Resume()
        {
            if(this.pauseCounter != null)
            {
                    this.pauseCounter.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void EnableNextActionOnPush()
        {
            if(this.nextActionOnPush != null)
            {
                    this.nextActionOnPush.Enable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void DisableNextActionOnPush()
        {
            if(this.nextActionOnPush != null)
            {
                    this.nextActionOnPush.Disable();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void StartNextActionMode()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Start Next Action Mode", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.pauseCounter.Enable();
            this.nextActionMode.Enable();
        }
        public void FinishNextActionMode()
        {
            object[] val_1 = new object[3];
            val_1[0] = this.<IsInnerFlowExecuting>k__BackingField;
            val_1[1] = this.innerFlowStartActionId;
            val_1[2] = this.nextList;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Finish Next Action Mode - isInner: {0} {1} {2}", values:  val_1);
            this.pauseCounter.Disable();
            this.nextActionMode.Disable();
            label_22:
            if(("Finish Next Action Mode - isInner: {0} {1} {2}") <= 0)
            {
                goto label_15;
            }
            
            this.nextList.RemoveLast();
            if((this.<IsInnerFlowExecuting>k__BackingField) != false)
            {
                    if((this.innerFlowDictionary.Item[new System.Guid() {_a = this.innerFlowStartActionId, _b = this.innerFlowStartActionId, _c = this.innerFlowStartActionId, _d = 240, _e = 181, _f = 217, _g = 84, _h = 3, _k = 16}]) != null)
            {
                goto label_19;
            }
            
            }
            
            label_19:
            this.list.AddFirst(node:  this.nextList.Last);
            if(this.nextList != null)
            {
                goto label_22;
            }
            
            throw new NullReferenceException();
            label_15:
            this.NextAction();
        }
        public FlowExecuter()
        {
            this.list = new System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>();
            this.autoList = new System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>();
            this.nextList = new System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>();
            this.innerFlowDictionary = new System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.LinkedList<Royal.Scenes.Start.Context.Units.Flow.FlowAction>>();
            this.nextActionMode = new Royal.Infrastructure.Utils.Counters.DisableCounter();
            this.pauseCounter = new Royal.Infrastructure.Utils.Counters.DisableCounter();
            this.nextActionOnPush = new Royal.Infrastructure.Utils.Counters.EnableCounter();
        }
    
    }

}
