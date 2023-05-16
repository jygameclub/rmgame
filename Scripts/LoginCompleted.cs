using UnityEngine;
private sealed class SignInWithApple.LoginCompleted : MulticastDelegate
{
    // Methods
    public SignInWithApple.LoginCompleted(object object, IntPtr method)
    {
        mem[1152921518885878864] = object;
        mem[1152921518885878872] = method;
        mem[1152921518885878848] = method;
    }
    public virtual void Invoke(int result, UnityEngine.SignInWithApple.UserInfo info)
    {
        string val_4;
        string val_5;
        string val_6;
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        var val_15;
        if(X8 != 0)
        {
                val_11 = mem[X8 + 24];
            val_11 = X8 + 24;
            if(val_11 == 0)
        {
                return;
        }
        
            val_12 = X8 + 32;
        }
        else
        {
                val_11 = 1;
        }
        
        var val_16 = 0;
        goto label_29;
        label_21:
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        val_13 = result;
        var val_13 = X22;
        if((X22 + 294) == 0)
        {
            goto label_16;
        }
        
        var val_8 = X22 + 176;
        var val_9 = 0;
        val_8 = val_8 + 8;
        label_7:
        if(((X22 + 176 + 8) + -8) == X23.ByteBuffer)
        {
            goto label_6;
        }
        
        val_9 = val_9 + 1;
        val_8 = val_8 + 16;
        if(val_9 < (X22 + 294))
        {
            goto label_7;
        }
        
        goto label_16;
        label_22:
        var val_2 = X22 + ((result + 72) << 4);
        val_15 = mem[(X22 + (result + 72) << 4) + 312];
        val_15 = (X22 + (result + 72) << 4) + 312;
        goto label_16;
        label_4:
        var val_10 = X22;
        val_10 = val_10 + (X23 + 72);
        goto label_16;
        label_24:
        var val_11 = X11;
        val_11 = val_11 + 1152921518886019600;
        val_10 = val_10 + val_11;
        var val_3 = val_10 + 304;
        label_26:
        val_15 = mem[(((X22 + X23 + 72) + (X11 + 1152921518886019600)) + 304) + 8];
        val_15 = (((X22 + X23 + 72) + (X11 + 1152921518886019600)) + 304) + 8;
        goto label_16;
        label_6:
        var val_12 = val_8;
        val_12 = val_12 + (X23 + 72);
        val_13 = val_13 + val_12;
        val_14 = val_13 + 304;
        goto label_16;
        label_29:
        val_13 = mem[1152921518886031800];
        if((val_13 & 1) == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921518886031800] + 74) != 2)
        {
            goto label_27;
        }
        
        goto label_16;
        label_14:
        if(mem[1152921518886031792] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921518886031800] + 72) == 1) || (((mem[1152921518886031792] + 273) & 1) != 0)) || ((mem[1152921518886031792] + 273) == 0))
        {
            goto label_28;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_21;
        }
        
        if((val_13 & 1) == 0)
        {
            goto label_22;
        }
        
        val_4 = info.displayName;
        val_5 = info.error;
        val_6 = info.userId;
        if((mem[1152921518886031792] + 294) == 0)
        {
            goto label_26;
        }
        
        var val_14 = mem[1152921518886031792] + 176;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_25:
        if(((mem[1152921518886031792] + 176 + 8) + -8) == (mem[1152921518886031800] + 24))
        {
            goto label_24;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (mem[1152921518886031792] + 294))
        {
            goto label_25;
        }
        
        goto label_26;
        label_17:
        if((val_13.ByteBuffer & 1) != 0)
        {
            
        }
        
        label_28:
        label_27:
        label_16:
        val_16 = val_16 + 1;
        if(val_16 != val_11)
        {
            goto label_29;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(int result, UnityEngine.SignInWithApple.UserInfo info, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
