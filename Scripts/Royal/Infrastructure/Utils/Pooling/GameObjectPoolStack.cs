using UnityEngine;

namespace Royal.Infrastructure.Utils.Pooling
{
    public class GameObjectPoolStack
    {
        // Fields
        private UnityEngine.MonoBehaviour gameObject;
        private readonly System.Collections.Generic.Stack<Royal.Infrastructure.Utils.Pooling.IPoolable> stack;
        private readonly System.Collections.Generic.HashSet<int> set;
        
        // Methods
        public GameObjectPoolStack(UnityEngine.MonoBehaviour go, int size)
        {
            this.gameObject = go;
            this.stack = new System.Collections.Generic.Stack<Royal.Infrastructure.Utils.Pooling.IPoolable>(capacity:  size);
            this.set = new System.Collections.Generic.HashSet<System.Int32>();
        }
        public void Push(Royal.Infrastructure.Utils.Pooling.IPoolable poolable)
        {
            if((this.set.Contains(item:  poolable)) != false)
            {
                    object[] val_2 = new object[1];
                val_2[0] = poolable.GetType();
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Same item to push: {0}", values:  val_2);
                return;
            }
            
            bool val_4 = this.set.Add(item:  poolable);
            this.stack.Push(item:  poolable);
        }
        public Royal.Infrastructure.Utils.Pooling.IPoolable Pop()
        {
            System.Collections.Generic.HashSet<System.Int32> val_6;
            var val_7;
            if(true != 0)
            {
                    Royal.Infrastructure.Utils.Pooling.IPoolable val_1 = this.stack.Pop();
                val_6 = this.set;
                val_7 = val_1;
                bool val_2 = val_6.Remove(item:  val_1);
                return (Royal.Infrastructure.Utils.Pooling.IPoolable)val_7;
            }
            
            object[] val_3 = new object[1];
            val_3[0] = this.gameObject.GetType();
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "Requested item is not in the pool: {0}", values:  val_3);
            val_6 = this.gameObject;
            UnityEngine.MonoBehaviour val_5 = UnityEngine.Object.Instantiate<UnityEngine.MonoBehaviour>(original:  val_6);
            if(val_5 != null)
            {
                    val_6 = val_5;
                val_7 = X0;
                if(X0 == true)
            {
                    return (Royal.Infrastructure.Utils.Pooling.IPoolable)val_7;
            }
            
            }
            
            val_7 = 0;
            return (Royal.Infrastructure.Utils.Pooling.IPoolable)val_7;
        }
        public int Count()
        {
            return 17407;
        }
        public void Clear()
        {
            var val_3;
            var val_11;
            UnityEngine.Object val_14;
            this.gameObject = 0;
            if(this.set == null)
            {
                    throw new NullReferenceException();
            }
            
            this.set.Clear();
            if(this.stack == null)
            {
                    throw new NullReferenceException();
            }
            
            Stack.Enumerator<T> val_1 = this.stack.GetEnumerator();
            val_11 = val_3;
            label_25:
            var val_13 = 0;
            if(mem[1152921504759971840] != null)
            {
                    val_13 = val_13 + 1;
            }
            else
            {
                    Stack.Enumerator<T> val_4 = 1152921504759934976 + ((mem[1152921504759971848]) << 4);
            }
            
            if(val_3.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_14 = 0;
            if(mem[1152921504759971840] != null)
            {
                    val_14 = val_14 + 1;
            }
            else
            {
                    Stack.Enumerator<T> val_6 = 1152921504759934976 + ((mem[1152921504759971848]) << 4);
            }
            
            val_14 = val_3.Current;
            if(val_14 == 0)
            {
                goto label_25;
            }
            
            if(val_14 == 0)
            {
                    throw new NullReferenceException();
            }
            
            if(val_14.gameObject == 0)
            {
                goto label_25;
            }
            
            UnityEngine.Object.Destroy(obj:  val_14.gameObject);
            goto label_25;
            label_8:
            val_14 = 0;
            if(val_3 != 0)
            {
                    var val_15 = 0;
                if(mem[1152921504759971840] != null)
            {
                    val_15 = val_15 + 1;
            }
            else
            {
                    Stack.Enumerator<T> val_12 = 1152921504759934976 + ((mem[1152921504759971848]) << 4);
            }
            
                val_3.Dispose();
            }
            
            if(val_14 != 0)
            {
                    throw val_14;
            }
            
            if(this.stack == null)
            {
                    throw new NullReferenceException();
            }
            
            this.stack.Clear();
        }
    
    }

}
