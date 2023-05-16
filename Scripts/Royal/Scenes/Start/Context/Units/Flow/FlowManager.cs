using UnityEngine;

namespace Royal.Scenes.Start.Context.Units.Flow
{
    public class FlowManager : IContextBehaviour, IContextUnit
    {
        // Fields
        private readonly Royal.Scenes.Start.Context.Units.Flow.FlowExecuter mainFlow;
        private System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Start.Context.Units.Flow.FlowExecuter> subFlows;
        private System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.Flow.FlowAction> delayedActions;
        
        // Properties
        public int Id { get; }
        public bool HasAutoActionInTheFlow { get; }
        
        // Methods
        public int get_Id()
        {
            return 12;
        }
        public bool get_HasAutoActionInTheFlow()
        {
            if(this.mainFlow.HasAutoAction == true)
            {
                    return true;
            }
            
            if(this.delayedActions == null)
            {
                    return this.mainFlow.HasInnerAutoAction;
            }
            
            if(this.delayedActions <= 0)
            {
                    return this.mainFlow.HasInnerAutoAction;
            }
            
            return true;
        }
        public FlowManager()
        {
            this.mainFlow = new Royal.Scenes.Start.Context.Units.Flow.FlowExecuter();
        }
        public void Bind()
        {
        
        }
        public void Clear(bool alsoRunningAction = True)
        {
            alsoRunningAction = alsoRunningAction;
            this.mainFlow.Clear(alsoRunningAction:  alsoRunningAction);
            if(this.delayedActions != null)
            {
                    this.delayedActions.Clear();
            }
            
            if(this.subFlows == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.subFlows.GetEnumerator();
            label_6:
            if((1424442936 & 1) == 0)
            {
                goto label_4;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.Clear(alsoRunningAction:  alsoRunningAction);
            goto label_6;
            label_4:
            0.Dispose();
        }
        public void ManualUpdate()
        {
            this.mainFlow.NextAction();
            if(this.subFlows == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.subFlows.GetEnumerator();
            this = 1152921518916177840;
            label_5:
            if((1424575432 & 1) == 0)
            {
                goto label_3;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.NextAction();
            goto label_5;
            label_3:
            0.Dispose();
        }
        public void Push(Royal.Scenes.Start.Context.Units.Flow.FlowAction action)
        {
            if(this.mainFlow != null)
            {
                    this.mainFlow.Push(action:  action);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Push(System.Type type, Royal.Scenes.Start.Context.Units.Flow.FlowAction action)
        {
            System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Start.Context.Units.Flow.FlowExecuter> val_5;
            Royal.Scenes.Start.Context.Units.Flow.FlowExecuter val_2 = 0;
            val_5 = this.subFlows;
            if(val_5 == null)
            {
                    System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Start.Context.Units.Flow.FlowExecuter> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.Type, Royal.Scenes.Start.Context.Units.Flow.FlowExecuter>(capacity:  5);
                this.subFlows = val_5;
            }
            
            bool val_3 = val_1.TryGetValue(key:  type, value: out  val_2);
            if(val_2 == 0)
            {
                    Royal.Scenes.Start.Context.Units.Flow.FlowExecuter val_4 = new Royal.Scenes.Start.Context.Units.Flow.FlowExecuter();
                this.subFlows.set_Item(key:  type, value:  val_4);
            }
            
            val_4.Push(action:  action);
        }
        public void PushToSameRunningFlowAction<T>(T action)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_11;
            System.Type val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = __RuntimeMethodHiddenParam;
            if(this.subFlows == null)
            {
                goto label_16;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.subFlows.GetEnumerator();
            label_9:
            if((1425008656 & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_5 = ((val_3 + 88) == 0) ? 0 : (val_3 + 88);
            if((val_3 + 88) != 0)
            {
                    if(val_5 == 0)
            {
                    throw new NullReferenceException();
            }
            
                val_12 = val_5.GetType();
            }
            else
            {
                    val_12 = 0;
            }
            
            if((System.Type.op_Equality(left:  val_12, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}))) == false)
            {
                goto label_9;
            }
            
            val_3.Push(action:  action);
            val_13 = 0;
            val_11 = 0;
            val_14 = 129;
            goto label_10;
            label_2:
            val_13 = 0;
            val_11 = 0;
            val_14 = 112;
            label_10:
            var val_10 = null;
            val_2 = val_3;
            val_3 = val_4;
            val_4 = val_10;
            var val_9 = 0;
            if(mem[1152921504683134976] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    val_10 = val_10 + ((mem[1152921504683134984]) << 4);
                val_15 = val_10 + 304;
            }
            
            val_4.Dispose();
            if(val_11 != 0)
            {
                    throw val_11;
            }
            
            if(val_13 != 1)
            {
                    if(val_14 == 129)
            {
                    return;
            }
            
            }
            
            label_16:
            this.mainFlow.Push(action:  action);
        }
        public void DelayAutoAction(Royal.Scenes.Start.Context.Units.Flow.FlowAction action)
        {
            System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_4 = this.delayedActions;
            if(val_4 == null)
            {
                    System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.Flow.FlowAction>();
                this.delayedActions = val_4;
            }
            
            val_1.Add(item:  action);
            object[] val_2 = new object[1];
            val_2[0] = action.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "{0} is delayed.", values:  val_2);
        }
        public void PushDelayedAutoActions(float executeAfter = 0)
        {
            System.Collections.Generic.List<Royal.Scenes.Start.Context.Units.Flow.FlowAction> val_4;
            if(Royal.Scenes.Home.Context.HomeContext.ShouldDelayAutoActions() == true)
            {
                    return;
            }
            
            if(this.delayedActions == null)
            {
                    return;
            }
            
            if(this.delayedActions == null)
            {
                    return;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = this.delayedActions;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  "Delayed {0} action will be pushed", values:  val_2);
            if(executeAfter > 0f)
            {
                    this.mainFlow.Push(action:  new Royal.Scenes.Start.Context.Units.Flow.IntervalAction(duration:  executeAfter, disableUiTouch:  true, flowType:  1));
            }
            
            val_4 = this.delayedActions;
            var val_4 = 0;
            label_17:
            if(val_4 >= 1152921505022181376)
            {
                goto label_14;
            }
            
            if(val_4 >= 47710688)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.mainFlow.Push(action:  public static System.TypedReference System.TypedReference::MakeTypedReference(object target, System.Reflection.FieldInfo[] flds));
            val_4 = this.delayedActions;
            val_4 = val_4 + 1;
            if(val_4 != null)
            {
                goto label_17;
            }
            
            throw new NullReferenceException();
            label_14:
            val_4.Clear();
        }
        public bool HasActionInFlow(System.Type actionType)
        {
            var val_5;
            var val_6;
            if((this.mainFlow.HasActionInFlow(actionType:  actionType)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
            if(this.delayedActions == null)
            {
                goto label_4;
            }
            
            List.Enumerator<T> val_2 = this.delayedActions.GetEnumerator();
            val_5 = 1152921518917233552;
            label_9:
            if((1425502760 & 1) == 0)
            {
                goto label_5;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if((System.Type.op_Equality(left:  0.GetType(), right:  actionType)) == false)
            {
                goto label_9;
            }
            
            val_6 = 1;
            goto label_10;
            label_4:
            val_6 = 0;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            label_10:
            0.Dispose();
            return (bool)val_6;
        }
        public void PauseMainFlow()
        {
            this.mainFlow.pauseCounter.Enable();
        }
        public void ResumeMainFlow()
        {
            this.mainFlow.pauseCounter.Disable();
        }
        public void EnableNextActionOnPush()
        {
            this.mainFlow.nextActionOnPush.Enable();
        }
        public void DisableNextActionOnPush()
        {
            this.mainFlow.nextActionOnPush.Disable();
        }
        public void StartMainFlowInnerFlow(System.Guid id)
        {
            if(this.mainFlow != null)
            {
                    this.mainFlow.StartInnerFlow(id:  new System.Guid() {_a = id._a, _b = id._b, _c = id._c, _d = id._d, _e = id._e, _f = id._f, _g = id._g, _h = id._h, _i = id._i, _j = id._j, _k = id._k});
                return;
            }
            
            throw new NullReferenceException();
        }
        public void FinishMainFlowInnerFlow()
        {
            if(this.mainFlow != null)
            {
                    this.mainFlow.FinishInnerFlow();
                return;
            }
            
            throw new NullReferenceException();
        }
        public bool IsInnerFlowExecuting()
        {
            if(this.mainFlow != null)
            {
                    return (bool)this.mainFlow.<IsInnerFlowExecuting>k__BackingField;
            }
            
            throw new NullReferenceException();
        }
        public bool IsInnerFlowInitializing()
        {
            if(this.mainFlow != null)
            {
                    return (bool)this.mainFlow.<IsInnerFlowInitializing>k__BackingField;
            }
            
            throw new NullReferenceException();
        }
        public bool IsMainFlowPaused()
        {
            return this.mainFlow.pauseCounter.IsEnabled();
        }
        public void StartNextActionMode()
        {
            if(this.mainFlow != null)
            {
                    this.mainFlow.StartNextActionMode();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void FinishNextActionMode()
        {
            if(this.mainFlow != null)
            {
                    this.mainFlow.FinishNextActionMode();
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
