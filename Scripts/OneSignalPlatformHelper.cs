using UnityEngine;
internal class OneSignalPlatformHelper
{
    // Methods
    internal static OSPermissionSubscriptionState ParsePermissionSubscriptionState(OneSignalPlatform platform, string jsonStr)
    {
        object val_11;
        var val_12;
        var val_14;
        var val_16;
        if(jsonStr != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  jsonStr);
        }
        
        val_11 = 0;
        val_12 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_14 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_14 = val_14 + 1;
            val_12 = 39;
        }
        else
        {
                var val_15 = mem[1152921505019609096];
            val_15 = val_15 + 39;
            OneSignalPlatform val_4 = 1152921505019572224 + val_15;
        }
        
        .permissionStatus = platform.ParseOSPermissionState(stateDict:  val_11.Item["permissionStatus"]);
        val_14 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_16 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_16 = val_16 + 1;
            val_14 = 40;
        }
        else
        {
                var val_17 = mem[1152921505019609096];
            val_17 = val_17 + 40;
            OneSignalPlatform val_7 = 1152921505019572224 + val_17;
        }
        
        .subscriptionStatus = platform.ParseOSSubscriptionState(stateDict:  val_11.Item["subscriptionStatus"]);
        if((val_11.ContainsKey(key:  "emailSubscriptionStatus")) == false)
        {
                return (OSPermissionSubscriptionState)new OSPermissionSubscriptionState();
        }
        
        val_16 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        val_11 = val_11.Item["emailSubscriptionStatus"];
        var val_18 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_18 = val_18 + 1;
            val_16 = 41;
        }
        else
        {
                var val_19 = mem[1152921505019609096];
            val_19 = val_19 + 41;
            OneSignalPlatform val_12 = 1152921505019572224 + val_19;
        }
        
        .emailSubscriptionStatus = platform.ParseOSEmailSubscriptionState(stateDict:  val_11);
        return (OSPermissionSubscriptionState)new OSPermissionSubscriptionState();
    }
    internal static OSPermissionStateChanges ParseOSPermissionStateChanges(OneSignalPlatform platform, string stateChangesJSONString)
    {
        var val_8;
        var val_10;
        if(stateChangesJSONString != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  stateChangesJSONString);
        }
        
        val_8 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_10 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_10 = val_10 + 1;
            val_8 = 39;
        }
        else
        {
                var val_11 = mem[1152921505019609096];
            val_11 = val_11 + 39;
            OneSignalPlatform val_4 = 1152921505019572224 + val_11;
        }
        
        .to = platform.ParseOSPermissionState(stateDict:  0.Item["to"]);
        val_10 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_12 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_12 = val_12 + 1;
            val_10 = 39;
        }
        else
        {
                var val_13 = mem[1152921505019609096];
            val_13 = val_13 + 39;
            OneSignalPlatform val_7 = 1152921505019572224 + val_13;
        }
        
        .from = platform.ParseOSPermissionState(stateDict:  0.Item["from"]);
        return (OSPermissionStateChanges)new OSPermissionStateChanges();
    }
    internal static OSSubscriptionStateChanges ParseOSSubscriptionStateChanges(OneSignalPlatform platform, string stateChangesJSONString)
    {
        var val_8;
        var val_10;
        if(stateChangesJSONString != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  stateChangesJSONString);
        }
        
        val_8 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_10 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_10 = val_10 + 1;
            val_8 = 40;
        }
        else
        {
                var val_11 = mem[1152921505019609096];
            val_11 = val_11 + 40;
            OneSignalPlatform val_4 = 1152921505019572224 + val_11;
        }
        
        .to = platform.ParseOSSubscriptionState(stateDict:  0.Item["to"]);
        val_10 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_12 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_12 = val_12 + 1;
            val_10 = 40;
        }
        else
        {
                var val_13 = mem[1152921505019609096];
            val_13 = val_13 + 40;
            OneSignalPlatform val_7 = 1152921505019572224 + val_13;
        }
        
        .from = platform.ParseOSSubscriptionState(stateDict:  0.Item["from"]);
        return (OSSubscriptionStateChanges)new OSSubscriptionStateChanges();
    }
    internal static OSEmailSubscriptionStateChanges ParseOSEmailSubscriptionStateChanges(OneSignalPlatform platform, string stateChangesJSONString)
    {
        var val_8;
        var val_10;
        if(stateChangesJSONString != null)
        {
                object val_1 = Json.Parser.Parse(jsonString:  stateChangesJSONString);
        }
        
        val_8 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_10 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_10 = val_10 + 1;
            val_8 = 41;
        }
        else
        {
                var val_11 = mem[1152921505019609096];
            val_11 = val_11 + 41;
            OneSignalPlatform val_4 = 1152921505019572224 + val_11;
        }
        
        .to = platform.ParseOSEmailSubscriptionState(stateDict:  0.Item["to"]);
        val_10 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        var val_12 = 0;
        if(mem[1152921505019609088] != null)
        {
                val_12 = val_12 + 1;
            val_10 = 41;
        }
        else
        {
                var val_13 = mem[1152921505019609096];
            val_13 = val_13 + 41;
            OneSignalPlatform val_7 = 1152921505019572224 + val_13;
        }
        
        .from = platform.ParseOSEmailSubscriptionState(stateDict:  0.Item["from"]);
        return (OSEmailSubscriptionStateChanges)new OSEmailSubscriptionStateChanges();
    }
    public OneSignalPlatformHelper()
    {
    
    }

}
