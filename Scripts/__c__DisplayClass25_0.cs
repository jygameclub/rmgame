using UnityEngine;
private sealed class FacebookConnect.<>c__DisplayClass25_0
{
    // Fields
    public Royal.Infrastructure.Services.Login.FacebookConnect <>4__this;
    public string fbId;
    public BestHTTP.OnRequestFinishedDelegate <>9__1;
    
    // Methods
    public FacebookConnect.<>c__DisplayClass25_0()
    {
    
    }
    internal void <GetPicture>b__0(Facebook.Unity.IGraphResult result)
    {
        var val_12;
        var val_17;
        var val_18;
        string val_19;
        BestHTTP.OnRequestFinishedDelegate val_20;
        var val_15 = 0;
        if(mem[1152921504958480384] != null)
        {
                val_15 = val_15 + 1;
            val_12 = 0;
        }
        else
        {
                Facebook.Unity.IGraphResult val_1 = 1152921504958443520 + ((mem[1152921504958480392]) << 4);
        }
        
        if(result.Error == null)
        {
            goto label_6;
        }
        
        object[] val_3 = new object[2];
        val_3[0] = this.fbId;
        var val_16 = 0;
        if(mem[1152921504958480384] == null)
        {
            goto label_12;
        }
        
        val_16 = val_16 + 1;
        goto label_14;
        label_6:
        var val_17 = 0;
        if(mem[1152921504958480384] == null)
        {
            goto label_16;
        }
        
        val_17 = val_17 + 1;
        val_12 = 1;
        goto label_18;
        label_12:
        Facebook.Unity.IGraphResult val_4 = 1152921504958443520 + ((mem[1152921504958480392]) << 4);
        label_14:
        val_3[1] = result.Error;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this.<>4__this, logTag:  14, log:  "Cannot get facebook picture of id:{0}, error: {1} ", values:  val_3);
        return;
        label_16:
        var val_18 = mem[1152921504958480392];
        val_18 = val_18 + 1;
        Facebook.Unity.IGraphResult val_6 = 1152921504958443520 + val_18;
        label_18:
        var val_19 = 0;
        if(mem[1152921504684625920] != null)
        {
                val_19 = val_19 + 1;
            val_12 = 0;
        }
        else
        {
                System.Collections.Generic.IDictionary<System.String, System.Object> val_8 = 1152921504684589056 + ((mem[1152921504684625928]) << 4);
        }
        
        val_17 = public TValue System.Collections.Generic.IDictionary<TKey, TValue>::get_Item(TKey key);
        TValue val_9 = result.ResultDictionary.Item[???];
        var val_22 = X0;
        if((X0 + 294) == 0)
        {
            goto label_28;
        }
        
        var val_20 = X0 + 176;
        var val_21 = 0;
        val_20 = val_20 + 8;
        label_30:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_29;
        }
        
        val_21 = val_21 + 1;
        val_20 = val_20 + 16;
        if(val_21 < (X0 + 294))
        {
            goto label_30;
        }
        
        label_28:
        val_17 = 0;
        goto label_31;
        label_29:
        val_22 = val_22 + (((X0 + 176 + 8)) << 4);
        val_18 = val_22 + 304;
        label_31:
        string val_23 = "url";
        object val_10 = X0.Item[val_23];
        if(val_10 != null)
        {
                val_23 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_19 = 0;
        }
        
        new System.Uri() = new System.Uri(uriString:  val_19);
        val_20 = this.<>9__1;
        if(val_20 == null)
        {
                BestHTTP.OnRequestFinishedDelegate val_12 = null;
            val_20 = val_12;
            val_12 = new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void FacebookConnect.<>c__DisplayClass25_0::<GetPicture>b__1(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response));
            this.<>9__1 = val_20;
        }
        
        BestHTTP.HTTPRequest val_14 = new BestHTTP.HTTPRequest(uri:  new System.Uri(), callback:  val_12).Send();
    }
    internal void <GetPicture>b__1(BestHTTP.HTTPRequest request, BestHTTP.HTTPResponse response)
    {
        System.IO.File.WriteAllBytes(path:  Royal.Infrastructure.Services.Login.FacebookConnect.GetLocalProfilePicturePath(fbId:  this.fbId), bytes:  UnityEngine.ImageConversion.EncodeToJPG(tex:  response.DataAsTexture2D));
        this.<>4__this.loginService.FbPictureDownloaded(fbId:  System.Int64.Parse(s:  this.fbId));
    }

}
