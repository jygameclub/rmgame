using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.State
{
    public class GameOperationContainer
    {
        // Fields
        private readonly int[] container;
        
        // Methods
        public void Reset(int operationType)
        {
            this.container[operationType] = 0;
        }
        public void Start(int operationType)
        {
            int val_1 = this.container[operationType];
            val_1 = val_1 + 1;
            this.container[operationType] = val_1;
        }
        public void Finish(int operationType)
        {
            int val_2 = this.container[operationType];
            if(val_2 != 0)
            {
                    val_2 = val_2 - 1;
                mem2[0] = val_2;
                return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = operationType;
            Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Operation {0} can\'t be below zero", values:  val_1);
        }
        public int GetCount(int operationType)
        {
            return (int)this.container[operationType];
        }
        public bool Has(int operationType)
        {
            return (bool)(this.container[operationType] > 0) ? 1 : 0;
        }
        public bool HasAny()
        {
            var val_1;
            if(this.container.Length < 1)
            {
                goto label_1;
            }
            
            var val_2 = 0;
            label_4:
            if(this.container[val_2] >= 1)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < this.container.Length)
            {
                goto label_4;
            }
            
            label_1:
            val_1 = 0;
            return (bool)val_1;
            label_3:
            val_1 = 1;
            return (bool)val_1;
        }
        public bool HasMask(int mask)
        {
            var val_3;
            if((this.container.Length << 32) >= 1)
            {
                    val_3 = 0;
                var val_3 = 0;
                do
            {
                if(null >= 1)
            {
                    val_3 = 0 | val_3;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < (long)this.container.Length);
            
                return (bool)(val_3 == mask) ? 1 : 0;
            }
            
            val_3 = 0;
            return (bool)(val_3 == mask) ? 1 : 0;
        }
        public void Clear()
        {
            var val_1 = 0;
            do
            {
                if(val_1 >= (this.container.Length << ))
            {
                    return;
            }
            
                this.container[val_1] = 0;
                val_1 = val_1 + 1;
            }
            while(this.container != null);
            
            throw new NullReferenceException();
        }
        public override string ToString()
        {
            System.Int32[] val_3;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_3 = this.container;
            object val_5 = 0;
            do
            {
                if(val_5 >= (this.container.Length << ))
            {
                    return (string)val_1;
            }
            
                if(val_3[val_5] >= 1)
            {
                    System.Text.StringBuilder val_2 = val_1.AppendFormat(format:  "OpCode:{0} Value:{1}\n", arg0:  val_5, arg1:  this.container[val_5]);
                val_3 = this.container;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_3 != null);
            
            return (string)val_1;
        }
        public GameOperationContainer()
        {
            this.container = new int[13];
        }
    
    }

}
