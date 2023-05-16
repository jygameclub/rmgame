using UnityEngine;

namespace Royal.Player.Context.Data
{
    public class UserId
    {
        // Fields
        public readonly long id;
        public readonly string token;
        private long <FacebookId>k__BackingField;
        private string <Name>k__BackingField;
        private long <Team>k__BackingField;
        private string <AppleId>k__BackingField;
        
        // Properties
        public long FacebookId { get; set; }
        public string Name { get; set; }
        public long Team { get; set; }
        public string AppleId { get; set; }
        
        // Methods
        public long get_FacebookId()
        {
            return (long)this.<FacebookId>k__BackingField;
        }
        private void set_FacebookId(long value)
        {
            this.<FacebookId>k__BackingField = value;
        }
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public long get_Team()
        {
            return (long)this.<Team>k__BackingField;
        }
        private void set_Team(long value)
        {
            this.<Team>k__BackingField = value;
        }
        public string get_AppleId()
        {
            return (string)this.<AppleId>k__BackingField;
        }
        private void set_AppleId(string value)
        {
            this.<AppleId>k__BackingField = value;
        }
        public UserId(long id, string token)
        {
            val_1 = new System.Object();
            this.id = id;
            this.token = val_1;
        }
        public void FillFromLocal()
        {
            this.<Name>k__BackingField = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "UserName", defaultValue:  System.String.alignConst);
            this.<Team>k__BackingField = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "TeamId", defaultValue:  0);
            this.<FacebookId>k__BackingField = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetLong(key:  "FacebookId", defaultValue:  0);
            this.<AppleId>k__BackingField = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.GetString(key:  "AppleId", defaultValue:  System.String.alignConst);
        }
        public void UpdateFacebookId(long newFacebookId)
        {
            this.<FacebookId>k__BackingField = newFacebookId;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "FacebookId", value:  newFacebookId);
        }
        public void UpdateAppleId(string newAppleId)
        {
            this.<AppleId>k__BackingField = newAppleId;
            bool val_1 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "AppleId", value:  newAppleId);
        }
        public void UpdateName(string newName)
        {
            int val_5;
            if((System.String.IsNullOrEmpty(value:  newName)) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  this.<Name>k__BackingField, b:  newName)) != false)
            {
                    return;
            }
            
            object[] val_3 = new object[2];
            val_5 = val_3.Length;
            val_3[0] = this.<Name>k__BackingField;
            if(newName != null)
            {
                    val_5 = val_3.Length;
            }
            
            val_3[1] = newName;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "UserName: {0} -> {1}", values:  val_3);
            this.<Name>k__BackingField = newName;
            bool val_4 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetString(key:  "UserName", value:  newName);
        }
        public void UpdateTeam(long teamId)
        {
            System.Object[] val_3;
            if((this.<Team>k__BackingField) == teamId)
            {
                    return;
            }
            
            object[] val_1 = new object[2];
            val_3 = val_1;
            val_3[0] = this.<Team>k__BackingField;
            val_3[1] = teamId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  9, log:  "TeamId: {0} -> {1}", values:  val_1);
            this.<Team>k__BackingField = teamId;
            bool val_2 = Royal.Infrastructure.Services.Storage.Tables.UserKeyValue.SetLong(key:  "TeamId", value:  teamId);
        }
    
    }

}
