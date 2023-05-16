using UnityEngine;
private sealed class AFeatureBundle.<LoadBundleFromGooglePlayAsync>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action<UnityEngine.AssetBundle> onComplete;
    public string name;
    private Google.Play.AssetDelivery.PlayAssetPackRequest <request>5__2;
    private UnityEngine.AssetBundleCreateRequest <loadedAssetBundleAsync>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AFeatureBundle.<LoadBundleFromGooglePlayAsync>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action<UnityEngine.AssetBundle> val_9;
        var val_10;
        UnityEngine.AssetBundleCreateRequest val_11;
        Google.Play.AssetDelivery.PlayAssetPackRequest val_12;
        var val_13;
        var val_14;
        System.Action<UnityEngine.AssetBundle> val_15;
        var val_16;
        UnityEngine.AssetBundle val_17;
        val_9 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_43;
        }
        
        this.<>1__state = 0;
        val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_10 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_10 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
        val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Start load asset pack: DefaultAssetPack", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        Google.Play.AssetDelivery.PlayAssetPackRequest val_2 = Google.Play.AssetDelivery.PlayAssetDelivery.RetrieveAssetPackAsync(assetPackName:  "DefaultAssetPack");
        val_13 = val_9;
        this.<request>5__2 = val_2;
        if(val_2 != null)
        {
            goto label_12;
        }
        
        label_2:
        val_13 = val_9;
        val_12 = this.<request>5__2;
        this.<>1__state = 0;
        label_12:
        if((this.<request>5__2.<IsDone>k__BackingField) == false)
        {
            goto label_15;
        }
        
        val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30];
        val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Result load asset pack: DefaultAssetPack", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        if((val_2.<Error>k__BackingField) == 0)
        {
            goto label_25;
        }
        
        val_15 = this.onComplete;
        if(val_15 == null)
        {
                return (bool)val_15;
        }
        
        val_16 = 1152921518922798112;
        val_17 = 0;
        goto label_27;
        label_1:
        val_11 = val_9;
        this.<>1__state = 0;
        if((this.<loadedAssetBundleAsync>5__3) != null)
        {
            goto label_28;
        }
        
        label_15:
        val_15 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_25:
        object[] val_5 = new object[1];
        val_5[0] = val_2.<DownloadProgress>k__BackingField;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClassType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), logTag:  22, log:  "Start load asset bundle from: {0}", values:  val_5);
        val_11 = this.<loadedAssetBundleAsync>5__3;
        this.<loadedAssetBundleAsync>5__3 = this.<request>5__2;
        label_28:
        if((UnityEngine.Object.op_Implicit(exists:  this.<request>5__2.assetBundle)) == false)
        {
            goto label_42;
        }
        
        val_9 = this.onComplete;
        if(val_9 == null)
        {
            goto label_43;
        }
        
        val_16 = 1152921518922798112;
        val_17 = mem[this.<loadedAssetBundleAsync>5__3].assetBundle;
        label_27:
        val_9.Invoke(obj:  val_17);
        label_43:
        val_15 = 0;
        return (bool)val_15;
        label_42:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_15 = 1;
        return (bool)val_15;
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
