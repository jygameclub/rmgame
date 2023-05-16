using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public class UserAreaData
    {
        // Fields
        private int <AreaId>k__BackingField;
        private int <RealAreaId>k__BackingField;
        private int <ChestStatus>k__BackingField;
        private Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] <Tasks>k__BackingField;
        
        // Properties
        public int AreaId { get; set; }
        public int RealAreaId { get; set; }
        public int ChestStatus { get; set; }
        public Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] Tasks { get; set; }
        
        // Methods
        public int get_AreaId()
        {
            return (int)this.<AreaId>k__BackingField;
        }
        public void set_AreaId(int value)
        {
            this.<AreaId>k__BackingField = value;
        }
        public int get_RealAreaId()
        {
            return (int)this.<RealAreaId>k__BackingField;
        }
        public void set_RealAreaId(int value)
        {
            this.<RealAreaId>k__BackingField = value;
        }
        public int get_ChestStatus()
        {
            return (int)this.<ChestStatus>k__BackingField;
        }
        public void set_ChestStatus(int value)
        {
            this.<ChestStatus>k__BackingField = value;
        }
        public Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] get_Tasks()
        {
            return (Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[])this.<Tasks>k__BackingField;
        }
        public void set_Tasks(Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] value)
        {
            this.<Tasks>k__BackingField = value;
        }
        public int GetTaskValue()
        {
            var val_3;
            int val_3 = this.<Tasks>k__BackingField.Length;
            val_3 = 0;
            int val_1 = val_3 - 1;
            if(<0)
            {
                    return (int)val_3;
            }
            
            val_3 = val_3 & 4294967295;
            var val_4 = (long)val_1;
            do
            {
                if(null != null)
            {
                    val_3 = (1 << val_4) | val_3;
            }
            
                val_4 = val_4 - 1;
                this.<Tasks>k__BackingField[val_1 << 3][36] = (this.<Tasks>k__BackingField[val_1 << 3][36]) - 8;
            }
            while((val_4 & 2147483648) == 0);
            
            return (int)val_3;
        }
        public int GetCompletedTaskCount()
        {
            var val_2;
            int val_2 = this.<Tasks>k__BackingField.Length;
            val_2 = 0;
            int val_1 = val_2 - 1;
            if(<0)
            {
                    return (int)val_2;
            }
            
            val_2 = val_2 & 4294967295;
            var val_3 = (long)val_1;
            do
            {
                val_3 = val_3 - 1;
                val_2 = val_2 + 1152921509031082064;
            }
            while((val_3 & 2147483648) == 0);
            
            return (int)val_2;
        }
        public bool AreAllTasksCompleted()
        {
            return (bool)(this.GetCompletedTaskCount() == (this.<Tasks>k__BackingField.Length)) ? 1 : 0;
        }
        public bool IsLastArea()
        {
            return (bool)((this.<AreaId>k__BackingField) == 28) ? 1 : 0;
        }
        private byte[] ToByteArray()
        {
            System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.<AreaId>k__BackingField));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.<ChestStatus>k__BackingField));
            val_1.AddRange(collection:  System.BitConverter.GetBytes(value:  this.GetTaskValue()));
            return val_1.ToArray();
        }
        private string EncodeAsString()
        {
            int val_1 = this.GetTaskValue();
            return System.Convert.ToBase64String(inArray:  this.ToByteArray());
        }
        public void UpdateAreaData(int areaId, int status, Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] taskData, int realAreaId = 0)
        {
            this.<AreaId>k__BackingField = areaId;
            this.<Tasks>k__BackingField = taskData;
            this.<RealAreaId>k__BackingField = (realAreaId == 0) ? areaId : realAreaId;
            this.<ChestStatus>k__BackingField = status;
            object[] val_2 = new object[3];
            val_2[0] = this;
            val_2[1] = areaId;
            val_2[2] = realAreaId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  10, log:  "Saved: {0}, areaId: {1}, realAreaId: {2}", values:  val_2);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "Area", value:  this.EncodeAsString());
        }
        public void UpdateAreaTask(Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData taskData)
        {
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] val_3 = this.<Tasks>k__BackingField;
            var val_4 = 0;
            var val_5 = 32;
            label_5:
            if(val_4 >= ((this.<Tasks>k__BackingField.Length) << ))
            {
                goto label_2;
            }
            
            if(val_3[0] == taskData.taskId)
            {
                    val_3 = taskData.taskId;
                val_3 = this.<Tasks>k__BackingField;
            }
            
            val_4 = val_4 + 1;
            val_5 = val_5 + 8;
            if(val_3 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "Area", value:  this.EncodeAsString());
        }
        public Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData GetTaskData(int taskId)
        {
            int val_1;
            if((this.<Tasks>k__BackingField.Length) < 1)
            {
                goto label_1;
            }
            
            var val_2 = 0;
            label_4:
            if((this.<Tasks>k__BackingField[0]) == taskId)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (this.<Tasks>k__BackingField.Length))
            {
                goto label_4;
            }
            
            label_1:
            val_1 = 0;
            return new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData() {taskId = val_1, isCompleted = val_1};
            label_3:
            val_1 = mem[this.<Tasks>k__BackingField[0x0] + 32];
            val_1 = this.<Tasks>k__BackingField[0x0] + 32;
            return new Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData() {taskId = val_1, isCompleted = val_1};
        }
        public bool PreRequisitesPass(Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig config)
        {
            var val_2;
            var val_3;
            if(config.dependencies == null)
            {
                    return this.IsDependencySatisfied(dependency:  config.dependency);
            }
            
            if(config.dependencies.Length == 0)
            {
                    return this.IsDependencySatisfied(dependency:  config.dependency);
            }
            
            if(config.dependencies.Length < 1)
            {
                goto label_3;
            }
            
            val_2 = 0;
            label_6:
            if((this.IsDependencySatisfied(dependency:  -913495616)) == false)
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(val_2 < (config.dependencies.Length << ))
            {
                goto label_6;
            }
            
            label_3:
            val_3 = 1;
            return (bool)val_3;
            label_5:
            val_3 = 0;
            return (bool)val_3;
        }
        private bool IsDependencySatisfied(int dependency)
        {
            var val_2;
            if(dependency != 1)
            {
                    if(((this.<Tasks>k__BackingField.Length) << 32) >= 1)
            {
                    var val_2 = 0;
                do
            {
                if(null == dependency)
            {
                    if(null != null)
            {
                goto label_5;
            }
            
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 < ((long)this.<Tasks>k__BackingField.Length));
            
            }
            
                val_2 = 0;
                return (bool)val_2;
            }
            
            label_5:
            val_2 = 1;
            return (bool)val_2;
        }
        public int GetAvailableTaskCount(Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig config, int stars)
        {
            var val_4;
            if(config.tasks.Length >= 1)
            {
                    var val_5 = 0;
                val_4 = 0;
                do
            {
                if(config.tasks[0x0][0].price <= stars)
            {
                    Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData val_1 = this.GetTaskData(taskId:  config.tasks[0x0][0].id);
                if(((ulong)(val_1.taskId >> 32) & 255) == 0)
            {
                    val_4 = val_4 + (this.PreRequisitesPass(config:  config.tasks[val_5]));
            }
            
            }
            
                val_5 = val_5 + 1;
                if(val_5 >= config.tasks.Length)
            {
                    return (int)val_4;
            }
            
            }
            while(config.tasks != null);
            
                throw new NullReferenceException();
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        public bool ChestClaimed()
        {
            return (bool)((this.<ChestStatus>k__BackingField) == 1) ? 1 : 0;
        }
        public override string ToString()
        {
            var val_9;
            Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData[] val_10;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            System.Text.StringBuilder val_2 = val_1.AppendFormat(format:  "AreaId: {0} - Status: {1}", arg0:  this.<AreaId>k__BackingField, arg1:  this.<ChestStatus>k__BackingField);
            System.Text.StringBuilder val_3 = val_1.Append(value:  " - Tasks:[");
            val_9 = 0;
            label_7:
            if(val_9 >= ((this.<Tasks>k__BackingField.Length) << ))
            {
                goto label_3;
            }
            
            System.Text.StringBuilder val_5 = val_1.Append(value:  ((this.<Tasks>k__BackingField[0]) != 0) ? (48 + 1) : 48);
            val_10 = this.<Tasks>k__BackingField;
            if(val_9 < (((-4294967296) + ((this.<Tasks>k__BackingField.Length) << 32)) >> 32))
            {
                    System.Text.StringBuilder val_7 = val_1.Append(value:  ',');
                val_10 = this.<Tasks>k__BackingField;
            }
            
            val_9 = val_9 + 1;
            if(val_10 != null)
            {
                goto label_7;
            }
            
            throw new NullReferenceException();
            label_3:
            System.Text.StringBuilder val_8 = val_1.Append(value:  "]");
            return (string)val_1;
        }
        public bool IsUsingRealArea()
        {
            return (bool)((this.<RealAreaId>k__BackingField) == (this.<AreaId>k__BackingField)) ? 1 : 0;
        }
        public int GetRequiredStarCount(Royal.Scenes.Home.Context.Units.Area.Config.AreaConfig config)
        {
            var val_2;
            if(config.tasks.Length >= 1)
            {
                    var val_3 = 0;
                val_2 = 0;
                do
            {
                Royal.Scenes.Home.Context.Units.Area.Config.AreaTaskConfig val_2 = config.tasks[val_3];
                Royal.Scenes.Home.Context.Units.Area.Data.AreaTaskData val_1 = this.GetTaskData(taskId:  config.tasks[0x0][0].id);
                if(((ulong)(val_1.taskId >> 32) & 255) == 0)
            {
                    val_2 = config.tasks[0x0][0].price + val_2;
            }
            
                val_3 = val_3 + 1;
                if(val_3 >= config.tasks.Length)
            {
                    return (int)val_2;
            }
            
            }
            while(config.tasks != null);
            
                throw new NullReferenceException();
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        public UserAreaData()
        {
        
        }
    
    }

}
