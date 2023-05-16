using UnityEngine;
private sealed class FacebookConnect.<>c__DisplayClass22_0
{
    // Fields
    public Royal.Infrastructure.Services.Login.FacebookConnect <>4__this;
    public System.Action<bool> onComplete;
    
    // Methods
    public FacebookConnect.<>c__DisplayClass22_0()
    {
    
    }
    internal void <PrepareRequiredData>b__0(Facebook.Unity.IGraphResult result)
    {
        var val_13;
        Royal.Infrastructure.Services.Login.FacebookConnect val_15;
        string val_16;
        var val_22;
        var val_23;
        var val_24;
        TValue val_13 = 0;
        var val_21 = 0;
        if(mem[1152921504958480384] != null)
        {
                val_21 = val_21 + 1;
            val_13 = 0;
        }
        else
        {
                Facebook.Unity.IGraphResult val_1 = 1152921504958443520 + ((mem[1152921504958480392]) << 4);
        }
        
        val_15 = this.<>4__this;
        if(result.Error == null)
        {
            goto label_6;
        }
        
        object[] val_3 = new object[2];
        val_16 = this.<>4__this.<UserId>k__BackingField;
        val_3[0] = val_16;
        var val_22 = 0;
        if(mem[1152921504958480384] == null)
        {
            goto label_13;
        }
        
        val_22 = val_22 + 1;
        goto label_15;
        label_6:
        var val_23 = 0;
        if(mem[1152921504958480384] == null)
        {
            goto label_17;
        }
        
        val_23 = val_23 + 1;
        val_13 = 1;
        goto label_19;
        label_13:
        Facebook.Unity.IGraphResult val_4 = 1152921504958443520 + ((mem[1152921504958480392]) << 4);
        label_15:
        val_3[1] = result.Error;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_15, logTag:  14, log:  "Cannot get facebook name of id:{0}, error: {1}", values:  val_3);
        this.onComplete.Invoke(obj:  false);
        return;
        label_17:
        var val_24 = mem[1152921504958480392];
        val_24 = val_24 + 1;
        Facebook.Unity.IGraphResult val_6 = 1152921504958443520 + val_24;
        label_19:
        System.Collections.Generic.IDictionary<System.String, System.Object> val_7 = result.ResultDictionary;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        val_16 = "name";
        var val_25 = 0;
        if(mem[1152921504684625920] != null)
        {
                val_25 = val_25 + 1;
            val_13 = 0;
        }
        else
        {
                System.Collections.Generic.IDictionary<System.String, System.Object> val_8 = 1152921504684589056 + ((mem[1152921504684625928]) << 4);
        }
        
        TValue val_9 = val_7.Item[null];
        if(val_9 == 0)
        {
                throw new NullReferenceException();
        }
        
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        val_15 = val_9;
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        this.<>4__this.GetPicture(fbId:  this.<>4__this.<UserId>k__BackingField);
        var val_26 = 0;
        if(mem[1152921504958480384] != null)
        {
                val_26 = val_26 + 1;
        }
        else
        {
                var val_27 = mem[1152921504958480392];
            val_27 = val_27 + 1;
            Facebook.Unity.IGraphResult val_10 = 1152921504958443520 + val_27;
        }
        
        System.Collections.Generic.IDictionary<System.String, System.Object> val_11 = result.ResultDictionary;
        val_15 = val_11;
        if(val_11 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_28 = 0;
        if(mem[1152921504684625920] != null)
        {
                val_28 = val_28 + 1;
        }
        else
        {
                var val_29 = mem[1152921504684625928];
            val_29 = val_29 + 7;
            System.Collections.Generic.IDictionary<System.String, System.Object> val_12 = 1152921504684589056 + val_29;
        }
        
        bool val_30 = val_15.TryGetValue(key:  null, value: out  val_13);
        if(0 == 0)
        {
            goto label_49;
        }
        
        val_30 = val_30 ^ 1;
        if((val_30 == true) || (X0 == false))
        {
            goto label_49;
        }
        
        var val_34 = X0;
        if((X0 + 294) == 0)
        {
            goto label_48;
        }
        
        var val_31 = X0 + 176;
        var val_32 = 0;
        val_31 = val_31 + 8;
        label_47:
        if(((X0 + 176 + 8) + -8) == null)
        {
            goto label_46;
        }
        
        val_32 = val_32 + 1;
        val_31 = val_31 + 16;
        if(val_32 < (X0 + 294))
        {
            goto label_47;
        }
        
        goto label_48;
        label_46:
        var val_33 = val_31;
        val_33 = val_33 + 7;
        val_34 = val_34 + val_33;
        val_22 = val_34 + 304;
        label_48:
        val_23 = "data";
        if((X0.TryGetValue(key:  null, value: out  val_13)) == false)
        {
            goto label_49;
        }
        
        val_24 = 0;
        Royal.Player.Context.Units.LeaderboardManager.ClearFacebookLeaderboard();
        if((this.<>4__this) == null)
        {
                throw new NullReferenceException();
        }
        
        val_15 = val_13;
        if(val_15 != 0)
        {
                val_23 = null;
        }
        
        this.<>4__this.ParseFriendsDataComingFromFacebook(friendsList:  val_15, myFacebookId:  System.Int64.Parse(s:  this.<>4__this.<UserId>k__BackingField));
        goto label_54;
        label_49:
        val_15 = this.<>4__this;
        object[] val_17 = new object[1];
        var val_35 = 0;
        if(mem[1152921504958480384] != null)
        {
                val_35 = val_35 + 1;
        }
        else
        {
                var val_36 = mem[1152921504958480392];
            val_36 = val_36 + 2;
            Facebook.Unity.IGraphResult val_18 = 1152921504958443520 + val_36;
        }
        
        string val_19 = result.RawResult;
        if(val_17 == null)
        {
                throw new NullReferenceException();
        }
        
        if(val_19 != null)
        {
                if(X0 == false)
        {
            goto label_61;
        }
        
        }
        
        if(val_17.Length == 0)
        {
                throw new IndexOutOfRangeException();
        }
        
        val_17[0] = val_19;
        Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  val_15, logTag:  14, log:  "Couldn\'t get facebook friends. RawResult:{0}", values:  val_17);
        label_54:
        if(this.onComplete == null)
        {
                throw new NullReferenceException();
        }
        
        this.onComplete.Invoke(obj:  true);
        return;
        label_61:
        val_23 = 0;
        throw new ArrayTypeMismatchException();
    }

}
