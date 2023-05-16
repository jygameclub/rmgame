using UnityEngine;

namespace Royal.Infrastructure.Services.Native.CloudBackup
{
    public class BackupManager
    {
        // Fields
        public long cloudUserId;
        public string cloudUserToken;
        private readonly Plugins.Dream.NativeLibrary library;
        
        // Methods
        public BackupManager(Plugins.Dream.NativeLibrary nativeLibrary)
        {
            this.cloudUserToken = System.String.alignConst;
            this.library = nativeLibrary;
        }
        public bool GetUserValues()
        {
            System.Object[] val_11;
            var val_12;
            object[] val_1 = new object[1];
            val_11 = val_1;
            val_11[0] = this.cloudUserId;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Try GetCloudUser {0}", values:  val_1);
            if(this.cloudUserId != 0)
            {
                    if((System.String.op_Inequality(a:  this.cloudUserToken, b:  System.String.alignConst)) == true)
            {
                goto label_6;
            }
            
            }
            
            val_11 = this.library.GetCloudBackupValue(key:  "UserIdAndToken");
            object[] val_4 = new object[1];
            val_4[0] = val_11;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "CloudUser: {0}", values:  val_4);
            if((System.String.op_Equality(a:  val_11, b:  System.String.alignConst)) == true)
            {
                goto label_17;
            }
            
            char[] val_6 = new char[1];
            val_6[0] = '§';
            val_11 = val_11.Split(separator:  val_6);
            if(val_7.Length != 2)
            {
                goto label_17;
            }
            
            bool val_9 = System.Int64.TryParse(s:  val_11[0], result: out  1152921527574823536);
            string val_12 = val_11[1];
            this.cloudUserToken = val_12;
            if(this.cloudUserId == 0)
            {
                goto label_19;
            }
            
            label_6:
            val_12 = 0;
            goto label_21;
            label_17:
            val_12 = 1;
            label_21:
            val_12 = val_12 & 1;
            return (bool)val_12;
            label_19:
            bool val_10 = System.String.op_Equality(a:  val_12, b:  System.String.alignConst);
            goto label_21;
        }
        private void SetUserValues(long id, string token)
        {
            string val_2 = id.ToString() + 167 + token;
            object[] val_3 = new object[1];
            val_3[0] = val_2;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  13, log:  "Set CloudUser: {0}", values:  val_3);
            this.library.SetCloudBackupValue(key:  "UserIdAndToken", value:  val_2);
            this.cloudUserId = id;
            this.cloudUserToken = token;
        }
        public void UpdateUserId(bool force = False)
        {
            bool val_1 = this.GetUserValues();
            if((this.cloudUserId != 0) && (force != true))
            {
                    return;
            }
            
            if(UserId == null)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_namespaze)) == true)
            {
                    return;
            }
            
            this.SetUserValues(id:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_name, token:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_namespaze);
        }
        public void ResetUserId()
        {
            this.SetUserValues(id:  0, token:  System.String.alignConst);
        }
    
    }

}
