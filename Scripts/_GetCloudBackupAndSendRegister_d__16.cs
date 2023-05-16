using UnityEngine;
private sealed class UserManager.<GetCloudBackupAndSendRegister>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Player.Context.Units.UserManager <>4__this;
    private int <count>5__2;
    private Royal.Infrastructure.Services.Native.CloudBackup.BackupManager <backupManager>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UserManager.<GetCloudBackupAndSendRegister>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_4 = this;
        this.<count>5__2 = 0;
        this.<>1__state = 0;
        Royal.Infrastructure.Services.Native.NativeService val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Native.NativeService>(id:  19);
        this.<backupManager>5__3 = val_1.backupManager;
        goto label_6;
        label_1:
        val_4 = this.<count>5__2;
        this.<>1__state = 0;
        label_6:
        int val_4 = val_4;
        if(val_4 < 3)
        {
                val_4 = val_4 + 1;
            this.<count>5__2 = val_4;
            if((this.<backupManager>5__3.GetUserValues()) != false)
        {
                val_5 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        }
        
        this.<>4__this.SendRegisterCommand();
        label_2:
        val_5 = 0;
        return (bool)val_5;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
