using UnityEngine;
private sealed class AndroidGameNotificationPlatform.<RequestAuthorization>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Infrastructure.Services.Notification.AndroidGameNotificationPlatform <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AndroidGameNotificationPlatform.<RequestAuthorization>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_2;
        var val_5;
        Unity.Notifications.Android.AndroidNotificationChannel val_6;
        var val_7;
        int val_8;
        val_5 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            val_6 = this.<>4__this.defaultNotificationChannel;
            Unity.Notifications.Android.AndroidNotificationChannel val_1 = Unity.Notifications.Android.AndroidNotificationCenter.GetNotificationChannel(channelId:  val_6);
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
        {
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this.<>4__this, logTag:  13, log:  "Register notification channel", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_2 = this.<>4__this.defaultNotificationChannel;
            Unity.Notifications.Android.AndroidNotificationCenter.RegisterNotificationChannel(channel:  new Unity.Notifications.Android.AndroidNotificationChannel() {<Id>k__BackingField = val_2, <Name>k__BackingField = val_2, <Description>k__BackingField = ???, <Importance>k__BackingField = ???, <CanBypassDnd>k__BackingField = ???, <CanShowBadge>k__BackingField = ???, <EnableLights>k__BackingField = ???, <EnableVibration>k__BackingField = ???, <VibrationPattern>k__BackingField = ???, <LockScreenVisibility>k__BackingField = val_2});
        }
        
            val_8 = 1;
            val_5 = 1;
            this.<>2__current = 0;
        }
        else
        {
                val_8 = 0;
        }
        
        this.<>1__state = val_8;
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
