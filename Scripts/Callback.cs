using UnityEngine;
public sealed class SignInWithApple.Callback : MulticastDelegate
{
    // Methods
    public SignInWithApple.Callback(object object, IntPtr method)
    {
        mem[1152921518885226096] = object;
        mem[1152921518885226104] = method;
        mem[1152921518885226080] = method;
    }
    public virtual void Invoke(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args)
    {
        string val_4;
        UnityEngine.SignInWithApple.UserDetectionStatus val_5;
        UnityEngine.SignInWithApple.UserCredentialState val_6;
        string val_7;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(X8 != 0)
        {
                val_12 = mem[X8 + 24];
            val_12 = X8 + 24;
            if(val_12 == 0)
        {
                return;
        }
        
            val_13 = X8 + 32;
        }
        else
        {
                val_12 = 1;
        }
        
        var val_17 = 0;
        goto label_30;
        label_21:
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_14 = X22;
        if((X22 + 294) == 0)
        {
            goto label_28;
        }
        
        var val_9 = X22 + 176;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_7:
        if(((X22 + 176 + 8) + -8) == X23.ByteBuffer)
        {
            goto label_6;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X22 + 294))
        {
            goto label_7;
        }
        
        goto label_28;
        label_22:
        var val_2 = X22 + ((X23 + 72) << 4);
        val_15 = mem[(X22 + (X23 + 72) << 4) + 312];
        val_15 = (X22 + (X23 + 72) << 4) + 312;
        goto label_28;
        label_4:
        var val_11 = X22;
        val_11 = val_11 + (X23 + 72);
        goto label_28;
        label_24:
        var val_12 = X11;
        val_12 = val_12 + ((X22 + X23 + 72) + 312);
        val_11 = val_11 + val_12;
        var val_3 = val_11 + 304;
        label_26:
        val_15 = mem[(((X22 + X23 + 72) + (X11 + (X22 + X23 + 72) + 312)) + 304) + 8];
        val_15 = (((X22 + X23 + 72) + (X11 + (X22 + X23 + 72) + 312)) + 304) + 8;
        goto label_28;
        label_6:
        var val_13 = val_9;
        val_13 = val_13 + (X23 + 72);
        val_14 = val_14 + val_13;
        val_14 = val_14 + 304;
        goto label_28;
        label_30:
        if((mem[1152921518885387240] & 1) == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921518885387240] + 74) != 1)
        {
            goto label_28;
        }
        
        goto label_16;
        label_14:
        if(mem[1152921518885387232] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921518885387240] + 72) == 1) || (((mem[1152921518885387232] + 273) & 1) != 0)) || ((mem[1152921518885387232] + 273) == 0))
        {
            goto label_20;
        }
        
        if((mem[1152921518885387240] & 1) == 0)
        {
            goto label_21;
        }
        
        if((mem[1152921518885387240] & 1) == 0)
        {
            goto label_22;
        }
        
        val_4 = args.userInfo.idToken;
        val_5 = args.userInfo.userDetectionStatus;
        val_6 = args.credentialState;
        val_7 = args.userInfo.email;
        if((mem[1152921518885387232] + 294) == 0)
        {
            goto label_26;
        }
        
        var val_15 = mem[1152921518885387232] + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_25:
        if(((mem[1152921518885387232] + 176 + 8) + -8) == (mem[1152921518885387240] + 24))
        {
            goto label_24;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < (mem[1152921518885387232] + 294))
        {
            goto label_25;
        }
        
        goto label_26;
        label_20:
        goto label_28;
        label_17:
        FlatBuffers.ByteBuffer val_8 = mem[1152921518885387240].ByteBuffer;
        label_16:
        label_28:
        val_17 = val_17 + 1;
        if(val_17 != val_12)
        {
            goto label_30;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.SignInWithApple.SignInWithApple.CallbackArgs args, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
