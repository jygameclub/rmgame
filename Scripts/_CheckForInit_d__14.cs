using UnityEngine;
private sealed class AnalyticsManager.<CheckForInit>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Services.Analytics.AnalyticsManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnalyticsManager.<CheckForInit>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        Royal.Infrastructure.Services.Analytics.IEventSender val_4;
        var val_6;
        string val_7;
        int val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this.<>4__this, logTag:  19, log:  "CheckForInit started", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        label_1:
        this.<>1__state = 0;
        label_9:
        val_4 = this.<>4__this.eventSender;
        var val_4 = 0;
        if(mem[1152921505145434112] != null)
        {
                val_4 = val_4 + 1;
        }
        else
        {
                Royal.Infrastructure.Services.Analytics.IEventSender val_1 = 1152921505145397248 + ((mem[1152921505145434120]) << 4);
        }
        
        if(val_4.IsReady == false)
        {
            goto label_17;
        }
        
        val_4 = public static T[] System.Array::Empty<System.Object>();
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_7 = "CheckForInit finished";
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this.<>4__this, logTag:  19, log:  val_7, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        var val_5 = 0;
        if(mem[1152921505145434112] == null)
        {
            goto label_26;
        }
        
        val_5 = val_5 + 1;
        val_7 = 1;
        goto label_28;
        label_17:
        val_9 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_26:
        var val_6 = mem[1152921505145434120];
        val_6 = val_6 + 1;
        Royal.Infrastructure.Services.Analytics.IEventSender val_3 = 1152921505145397248 + val_6;
        label_28:
        this.<>4__this.eventSender.SetAnalyticsEnabled(isEnabled:  true);
        this.<>4__this.UpdateUserId();
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
