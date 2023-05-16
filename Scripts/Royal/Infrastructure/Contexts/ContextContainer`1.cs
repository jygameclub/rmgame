using UnityEngine;

namespace Royal.Infrastructure.Contexts
{
    public class ContextContainer<T>
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Infrastructure.Contexts.IContextBehaviour> behaviours;
        private readonly T[] units;
        
        // Methods
        public ContextContainer<T>(int contextUnitCount)
        {
            mem[1152921528700191744] = new System.Collections.Generic.List<Royal.Infrastructure.Contexts.IContextBehaviour>();
            mem[1152921528700191752] = __RuntimeMethodHiddenParam + 24 + 192;
        }
        public void Add(T unit)
        {
            var val_4 = 0;
            if(mem[1152921505146073088] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    Royal.Infrastructure.Contexts.IContextUnit val_1 = 1152921505146036224 + ((mem[1152921505146073096]) << 4);
            }
            
            47620096 + (unit.Id << 3) = unit;
            if(X0 == false)
            {
                    return;
            }
            
            X0.Add(item:  X0);
        }
        public T GetLate<T2>(int id)
        {
            var val_2;
            var val_3;
            bool val_1 = true;
            val_1 = val_1 + (((long)(int)(id)) << 3);
            val_2 = mem[(true + ((long)(int)(id)) << 3) + 32];
            val_2 = (true + ((long)(int)(id)) << 3) + 32;
            if(val_2 != 0)
            {
                    return (object)val_2;
            }
            
            var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 8 + 302;
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                goto label_5;
            }
            
            val_2 = X0;
            if(X0 == true)
            {
                goto label_6;
            }
            
            label_5:
            val_2 = 0;
            label_6:
            val_2 = val_2 + (((long)(int)(id)) << 3);
            val_2 = val_2;
            if(X0 != false)
            {
                    X0.Add(item:  X0);
            }
            
            var val_6 = 1179403647;
            if(mem[282584257676965] == 0)
            {
                goto label_15;
            }
            
            var val_3 = mem[282584257676847];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_14:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < mem[282584257676965])
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_6 = val_6 + val_5;
            val_3 = val_6 + 304;
            label_15:
            val_2.Bind();
            return (object)val_2;
        }
        public void AddToFirst(T unit)
        {
            var val_4 = 0;
            if(mem[1152921505122963456] != null)
            {
                    val_4 = val_4 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Context.IGameContextUnit val_1 = 1152921505122926592 + ((mem[1152921505122963464]) << 4);
            }
            
            47620096 + (unit.Id << 3) = unit;
            if(X0 == false)
            {
                    return;
            }
            
            X0.Insert(index:  0, item:  X0);
        }
        public void Replace(T unit)
        {
            System.Type val_14;
            var val_16;
            var val_16 = 0;
            if(mem[1152921505122963456] != null)
            {
                    val_16 = val_16 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Context.IGameContextUnit val_1 = 1152921505122926592 + ((mem[1152921505122963464]) << 4);
            }
            
            var val_3 = 47620096 + (unit.Id << 3);
            if(((47620096 + (val_2) << 3) + 32) != 0)
            {
                    var val_17 = 0;
                if(mem[1152921505122963456] != null)
            {
                    val_17 = val_17 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Context.IGameContextUnit val_4 = 1152921505122926592 + ((mem[1152921505122963464]) << 4);
            }
            
                var val_6 = 47620096 + (unit.Id << 3);
                val_14 = (47620096 + (val_5) << 3) + 32.GetType();
                if((System.Type.op_Equality(left:  val_14, right:  unit.GetType())) == true)
            {
                    return;
            }
            
            }
            
            var val_18 = 0;
            if(mem[1152921505122963456] != null)
            {
                    val_18 = val_18 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Context.IGameContextUnit val_10 = 1152921505122926592 + ((mem[1152921505122963464]) << 4);
            }
            
            System.Type val_12 = val_14 + (unit.Id << 3);
            val_12 = unit;
            val_14 = 0;
            label_38:
            if(val_14 >= val_12)
            {
                goto label_26;
            }
            
            if(val_12 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = val_8._impl.value + 32;
            if((val_8._impl.value + 32 + 294) == 0)
            {
                goto label_32;
            }
            
            var val_19 = val_8._impl.value + 32 + 176;
            var val_20 = 0;
            val_19 = val_19 + 8;
            label_31:
            if(((val_8._impl.value + 32 + 176 + 8) + -8) == null)
            {
                goto label_30;
            }
            
            val_20 = val_20 + 1;
            val_19 = val_19 + 16;
            if(val_20 < (val_8._impl.value + 32 + 294))
            {
                goto label_31;
            }
            
            goto label_32;
            label_30:
            val_21 = val_21 + (((val_8._impl.value + 32 + 176 + 8)) << 4);
            val_16 = val_21 + 304;
            label_32:
            int val_13 = val_8._impl.value + 32.Id;
            var val_22 = 0;
            if(mem[1152921505122963456] != null)
            {
                    val_22 = val_22 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Context.IGameContextUnit val_14 = 1152921505122926592 + ((mem[1152921505122963464]) << 4);
            }
            
            if(val_13 == unit.Id)
            {
                goto label_37;
            }
            
            val_14 = val_14 + 1;
            if(val_13 != 0)
            {
                goto label_38;
            }
            
            throw new NullReferenceException();
            label_26:
            val_14 = 0;
            label_37:
            if(X0 == false)
            {
                    return;
            }
            
            if((val_14 & 2147483648) == 0)
            {
                    X0.set_Item(index:  0, value:  X0);
                return;
            }
            
            X0.Add(item:  X0);
        }
        public void Remove(int id)
        {
            var val_2;
            var val_3;
            bool val_2 = true;
            val_2 = val_2 + (id << 3);
            val_2 = 0;
            val_2 = 0;
            label_12:
            if(val_2 >= (X22 + 24))
            {
                    return;
            }
            
            if((X22 + 24) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = X22 + 16;
            val_3 = val_3 + 0;
            var val_6 = (X22 + 16 + 0) + 32;
            if(((X22 + 16 + 0) + 32 + 294) == 0)
            {
                goto label_10;
            }
            
            var val_4 = (X22 + 16 + 0) + 32 + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_9:
            if((((X22 + 16 + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < ((X22 + 16 + 0) + 32 + 294))
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            val_6 = val_6 + ((((X22 + 16 + 0) + 32 + 176 + 8)) << 4);
            val_3 = val_6 + 304;
            label_10:
            int val_1 = (X22 + 16 + 0) + 32.Id;
            if(val_1 == id)
            {
                goto label_11;
            }
            
            val_2 = val_2 + 1;
            if(((X22 + 16 + 0) + 32) != 0)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_11:
            val_1.RemoveAt(index:  0);
        }
        public T2 Get<T2>(int id)
        {
            var val_2;
            var val_3;
            var val_4;
            bool val_2 = true;
            val_2 = val_2 + (id << 3);
            val_2 = mem[__RuntimeMethodHiddenParam + 48];
            val_2 = __RuntimeMethodHiddenParam + 48;
            if(((true + (id) << 3) + 32) != 0)
            {
                    if(X0 == true)
            {
                    return (Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager)val_3;
            }
            
            }
            
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  1, log:  "Missing ContextUnitId: "("Missing ContextUnitId: ") + id, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_3 = 0;
            return (Royal.Scenes.Game.Levels.Units.WinFail.IWinFailManager)val_3;
        }
        public bool Has(int id)
        {
            var val_1 = X8 + (id << 3);
            return (bool)(((X8 + (id) << 3) + 32) != 0) ? 1 : 0;
        }
        public void Clear()
        {
            9218.Clear();
            var val_1 = 0;
            do
            {
                if(val_1 >= ("calendar" << ))
            {
                    return;
            }
            
                val_1 = val_1 + 1;
            }
            while((public System.Void System.Collections.Generic.List<Royal.Infrastructure.Contexts.IContextBehaviour>::Clear()) != 0);
            
            throw new NullReferenceException();
        }
        public void RemoveLateUnits()
        {
            var val_3;
            System.Predicate<T> val_4;
            var val_5;
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16 + 302];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 16 + 302;
            if((val_3 & 1) == 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16 + 302];
                val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 16 + 302;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16 + 184 + 8];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 16 + 184 + 8;
            if(val_4 == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16 + 302];
                val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 16 + 302;
                if((val_5 & 1) == 0)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 16 + 302];
                val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 16 + 302;
            }
            
                System.Predicate<Royal.Infrastructure.Contexts.IContextBehaviour> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Predicate<Royal.Infrastructure.Contexts.IContextBehaviour>(object:  __RuntimeMethodHiddenParam + 24 + 192 + 16 + 184, method:  __RuntimeMethodHiddenParam + 24 + 192 + 24);
                __RuntimeMethodHiddenParam + 24 + 192 + 16 + 184 = val_4;
            }
            
            int val_2 = RemoveAll(match:  val_1);
            var val_5 = 4;
            do
            {
                if((val_5 - 4) >= (null << ))
            {
                    return;
            }
            
                val_5 = val_5 + 1;
            }
            while((public System.Int32 System.Collections.Generic.List<Royal.Infrastructure.Contexts.IContextBehaviour>::RemoveAll(System.Predicate<T> match)) != 0);
            
            throw new NullReferenceException();
        }
        public void ManualUpdate()
        {
            var val_2;
            var val_3;
            val_2 = 0;
            label_9:
            if(val_2 >= mem[47620120])
            {
                    return;
            }
            
            if(mem[47620120] <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[47620112];
            val_1 = val_1 + 0;
            var val_4 = (mem[47620112] + 0) + 32;
            if(((mem[47620112] + 0) + 32 + 294) == 0)
            {
                goto label_8;
            }
            
            var val_2 = (mem[47620112] + 0) + 32 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_7:
            if((((mem[47620112] + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < ((mem[47620112] + 0) + 32 + 294))
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            val_4 = val_4 + ((((mem[47620112] + 0) + 32 + 176 + 8)) << 4);
            val_3 = val_4 + 304;
            label_8:
            (mem[47620112] + 0) + 32.ManualUpdate();
            val_2 = val_2 + 1;
            if(((mem[47620112] + 0) + 32) != 0)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
        }
        public T[] GetAllUnits()
        {
            return (T[])this;
        }
        public void BindAll()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            label_9:
            if(val_3 >= (40472 << ))
            {
                    return;
            }
            
            var val_1 = true + 0;
            if(((true + 0) + 32) == 0)
            {
                goto label_4;
            }
            
            var val_5 = (true + 0) + 32;
            if(((true + 0) + 32 + 294) == 0)
            {
                goto label_8;
            }
            
            var val_2 = (true + 0) + 32 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_7:
            if((((true + 0) + 32 + 176 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < ((true + 0) + 32 + 294))
            {
                goto label_7;
            }
            
            goto label_8;
            label_6:
            var val_4 = val_2;
            val_4 = val_4 + 1;
            val_5 = val_5 + val_4;
            val_4 = val_5 + 304;
            label_8:
            (true + 0) + 32.Bind();
            label_4:
            val_3 = val_3 + 1;
            if((public System.Void Royal.Infrastructure.Contexts.IContextUnit::Bind()) != 0)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
