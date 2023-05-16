using UnityEngine;

namespace Royal.Infrastructure.Utils.Pooling
{
    public class GameObjectPool
    {
        // Fields
        private readonly Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack[] poolArray;
        private UnityEngine.Transform pool;
        
        // Methods
        public GameObjectPool(System.Type poolIdType)
        {
            System.String[] val_1 = System.Enum.GetNames(enumType:  poolIdType);
            this.poolArray = new Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack[0];
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject();
            val_3.name = poolIdType;
            UnityEngine.Transform val_4 = val_3.transform;
            this.pool = val_4;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_4);
        }
        public void CreatePool<T>(T go, int amount)
        {
            Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack val_7;
            Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack[] val_8;
            var val_8 = 0;
            if(mem[1152921505127862272] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_1 = 1152921505127825408 + ((mem[1152921505127862280]) << 4);
            }
            
            val_7 = this.poolArray[go.GetPoolId()];
            if(val_7 == null)
            {
                    Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack val_3 = null;
                val_7 = val_3;
                val_3 = new Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack(go:  go, size:  amount);
                val_8 = this.poolArray;
                var val_9 = 0;
                if(mem[1152921505127862272] != null)
            {
                    val_9 = val_9 + 1;
            }
            else
            {
                    Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_4 = 1152921505127825408 + ((mem[1152921505127862280]) << 4);
            }
            
                val_8[go.GetPoolId()] = val_7;
            }
            
            int val_6 = val_3.Count();
            if(val_6 >= amount)
            {
                    return;
            }
            
            var val_10 = val_6;
            do
            {
                val_8 = go;
                go.gameObject.SetActive(value:  false);
                val_3.Push(poolable:  val_8);
                val_10 = val_10 + 1;
            }
            while(val_10 < amount);
        
        }
        public T Spawn<T>(int poolId, bool activate)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = poolId;
            Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack val_3 = this.poolArray[val_4];
            if(val_3 == null)
            {
                goto label_3;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 48];
            val_4 = __RuntimeMethodHiddenParam + 48;
            if(val_3.Pop() == null)
            {
                goto label_5;
            }
            
            val_5 = X0;
            if(X0 == false)
            {
                goto label_6;
            }
            
            if(activate == false)
            {
                goto label_7;
            }
            
            label_12:
            val_5.gameObject.SetActive(value:  true);
            goto label_10;
            label_3:
            val_5 = 0;
            return (Royal.Infrastructure.Utils.Pooling.PoolableAudioSource)val_5;
            label_5:
            val_5 = 0;
            if(activate == true)
            {
                goto label_12;
            }
            
            label_7:
            label_10:
            var val_7 = 1179403647;
            if(mem[282584257676965] == 0)
            {
                goto label_17;
            }
            
            var val_4 = mem[282584257676847];
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_16:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < mem[282584257676965])
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_6 = val_4;
            val_6 = val_6 + 1;
            val_7 = val_7 + val_6;
            val_6 = val_7 + 304;
            label_17:
            val_5.OnSpawn();
            return (Royal.Infrastructure.Utils.Pooling.PoolableAudioSource)val_5;
            label_6:
        }
        public void Recycle<T>(T go)
        {
            var val_6 = 0;
            if(mem[1152921505127862272] != null)
            {
                    val_6 = val_6 + 1;
            }
            else
            {
                    Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_1 = 1152921505127825408 + ((mem[1152921505127862280]) << 4);
            }
            
            Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack val_7 = this.poolArray[go.GetPoolId()];
            if(val_7 == null)
            {
                    return;
            }
            
            go.gameObject.SetActive(value:  false);
            go.transform.SetParent(p:  this.pool);
            var val_8 = 0;
            if(mem[1152921505127862272] != null)
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    var val_9 = mem[1152921505127862280];
                val_9 = val_9 + 2;
                Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_5 = 1152921505127825408 + val_9;
            }
            
            go.OnRecycle();
            val_7.Push(poolable:  go);
        }
        public void ClearPool(int poolId)
        {
            Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack[] val_1 = this.poolArray;
            Royal.Infrastructure.Utils.Pooling.GameObjectPoolStack val_1 = val_1[(long)poolId];
            if(val_1 != null)
            {
                    val_1.Clear();
                val_1 = this.poolArray;
            }
            
            val_1[(long)poolId] = 0;
        }
        public void ClearAllPools()
        {
            var val_1 = 0;
            do
            {
                if(val_1 >= this.poolArray.Length)
            {
                    return;
            }
            
                this.ClearPool(poolId:  0);
                val_1 = val_1 + 1;
            }
            while(this.poolArray != null);
            
            throw new NullReferenceException();
        }
        public bool IsPoolAlive()
        {
            return UnityEngine.Object.op_Inequality(x:  this.pool, y:  0);
        }
        public void Destroy()
        {
            UnityEngine.Object.Destroy(obj:  this.pool.gameObject);
            this.pool = 0;
        }
    
    }

}
