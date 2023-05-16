using UnityEngine;

namespace Royal.Player.Context.Data.Persistent
{
    public class UserLogData
    {
        // Fields
        private string <LevelWinMultipliers>k__BackingField;
        
        // Properties
        public string LevelWinMultipliers { get; set; }
        
        // Methods
        public string get_LevelWinMultipliers()
        {
            return (string)this.<LevelWinMultipliers>k__BackingField;
        }
        public void set_LevelWinMultipliers(string value)
        {
            this.<LevelWinMultipliers>k__BackingField = value;
        }
        public int[] GetLevelWinMultiplierArray()
        {
            var val_8;
            System.Func<System.String, System.Boolean> val_10;
            if((System.String.IsNullOrEmpty(value:  this.<LevelWinMultipliers>k__BackingField)) != false)
            {
                    return 0;
            }
            
            char[] val_2 = new char[1];
            val_2[0] = '§';
            val_8 = null;
            val_8 = null;
            val_10 = UserLogData.<>c.<>9__4_0;
            if(val_10 != null)
            {
                    return System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<System.String, System.Int32>(source:  System.Linq.Enumerable.Where<System.String>(source:  this.<LevelWinMultipliers>k__BackingField.Split(separator:  val_2), predicate:  System.Func<System.String, System.Boolean> val_4 = null), selector:  new System.Func<System.String, System.Int32>(object:  0, method:  public static System.Int32 System.Int32::Parse(string s))));
            }
            
            val_10 = val_4;
            val_4 = new System.Func<System.String, System.Boolean>(object:  UserLogData.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean UserLogData.<>c::<GetLevelWinMultiplierArray>b__4_0(string s));
            UserLogData.<>c.<>9__4_0 = val_10;
            return System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<System.String, System.Int32>(source:  System.Linq.Enumerable.Where<System.String>(source:  this.<LevelWinMultipliers>k__BackingField.Split(separator:  val_2), predicate:  val_4), selector:  new System.Func<System.String, System.Int32>(object:  0, method:  public static System.Int32 System.Int32::Parse(string s))));
        }
        public void ResetLevelWinMultipliers()
        {
            this.<LevelWinMultipliers>k__BackingField = System.String.alignConst;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "LWM", value:  System.String.alignConst);
        }
        public void UpdateLevelWinMultipliers(System.Nullable<Royal.Infrastructure.Services.Backend.Protocol.LogData> logData)
        {
            var val_1;
            var val_5;
            if((logData.HasValue + 16) == 0)
            {
                    return;
            }
            
            if(logData.HasValue == false)
            {
                    return;
            }
            
            if((-1835531808) >= 1)
            {
                    do
            {
                var val_4 = val_1;
                val_4 = val_4 & 255;
                if(val_4 != 0)
            {
                    this.RemoveLevelWinMultiplier(levelOrLeagueLevel:  -1835531856, multiplier:  -1835531856);
            }
            
                val_5 = 0 + 1;
            }
            while(val_5 < (-1835531808));
            
            }
            
            bool val_3 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "LWM", value:  this.<LevelWinMultipliers>k__BackingField);
        }
        public void AddLevelWinMultiplier(int levelOrLeagueLevel, int multiplier)
        {
            string val_1 = Royal.Player.Context.Data.Persistent.UserLogData.LevelWinMultiplierString(level:  levelOrLeagueLevel, multiplier:  multiplier);
            this.<LevelWinMultipliers>k__BackingField = this.<LevelWinMultipliers>k__BackingField(this.<LevelWinMultipliers>k__BackingField) + val_1;
            object[] val_3 = new object[1];
            val_3[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "AddLevelWinMultiplier: {0}", values:  val_3);
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "LWM", value:  this.<LevelWinMultipliers>k__BackingField);
        }
        private void RemoveLevelWinMultiplier(int levelOrLeagueLevel, int multiplier = 10)
        {
            string val_1 = Royal.Player.Context.Data.Persistent.UserLogData.LevelWinMultiplierString(level:  levelOrLeagueLevel, multiplier:  multiplier);
            object[] val_2 = new object[1];
            val_2[0] = val_1;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "RemoveLevelWinMultiplier: {0}", values:  val_2);
            this.<LevelWinMultipliers>k__BackingField = this.<LevelWinMultipliers>k__BackingField.Replace(oldValue:  val_1, newValue:  System.String.alignConst);
        }
        private static string LevelWinMultiplierString(int level, int multiplier = 10)
        {
            int val_4;
            int val_5;
            object[] val_1 = new object[4];
            val_4 = val_1.Length;
            val_1[0] = level.ToString();
            val_4 = val_1.Length;
            val_1[1] = "§";
            val_5 = val_1.Length;
            val_1[2] = multiplier;
            val_5 = val_1.Length;
            val_1[3] = "§";
            return (string)+val_1;
        }
        public UserLogData()
        {
        
        }
    
    }

}
