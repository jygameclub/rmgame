using UnityEngine;
private sealed class LogUploader.<StateLoop>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Services.Logs.LogUploader <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LogUploader.<StateLoop>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_1;
        var val_2;
        var val_3;
        int val_4;
        var val_5;
        var val_6;
        var val_7;
        Royal.Infrastructure.Services.Logs.UploadLogState val_8;
        if((this.<>1__state) < 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 2)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 3)
        {
            goto label_28;
        }
        
        this.<>1__state = 0;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_1 = 1152921505134747648;
        val_2 = null;
        val_2 = null;
        if(Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState != 1)
        {
            goto label_8;
        }
        
        if((this.<>4__this.logService.logWriter.fileCompressed) != false)
        {
                val_3 = 1152921505134751748;
            Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState = 2;
        }
        
        val_4 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_2:
        this.<>1__state = 0;
        goto label_15;
        label_8:
        this.<>4__this.StartLogin();
        label_15:
        val_1 = 1152921505134747648;
        val_5 = null;
        val_5 = null;
        if(Royal.Infrastructure.Services.Logs.LogUploader.FirebaseLoginState == 0)
        {
            goto label_18;
        }
        
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
        val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this.<>4__this, logTag:  2, log:  "Logged in", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        this.<>4__this.StartUpload();
        label_4:
        val_7 = null;
        val_7 = null;
        val_8 = Royal.Infrastructure.Services.Logs.LogUploader.UploadLogState;
        if(val_8 != 3)
        {
            goto label_28;
        }
        
        this.<>2__current = 0;
        goto label_29;
        label_28:
        val_4 = 0;
        return (bool)val_4;
        label_18:
        this.<>2__current = 0;
        val_8 = 2;
        label_29:
        val_4 = 1;
        this.<>1__state = val_8;
        return (bool)val_4;
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
