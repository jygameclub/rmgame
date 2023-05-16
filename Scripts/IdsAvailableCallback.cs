using UnityEngine;
public sealed class OneSignal.IdsAvailableCallback : MulticastDelegate
{
    // Methods
    public OneSignal.IdsAvailableCallback(object object, IntPtr method)
    {
        mem[1152921518869707408] = object;
        mem[1152921518869707416] = method;
        mem[1152921518869707392] = method;
    }
    public virtual void Invoke(string playerID, string pushToken)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        if(X8 != 0)
        {
                val_15 = mem[X8 + 24];
            val_15 = X8 + 24;
            if(val_15 == 0)
        {
                return;
        }
        
            val_16 = X8 + 32;
        }
        else
        {
                val_15 = 1;
        }
        
        var val_25 = 0;
        string val_1 = playerID - 16;
        string val_2 = pushToken - 16;
        goto label_49;
        label_39:
        val_17 = mem[X24 + 72];
        val_17 = X24 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_13 = 0;
        if(mem[1152921504621686784] == X24.ByteBuffer)
        {
            goto label_6;
        }
        
        val_13 = val_13 + 1;
        goto label_25;
        label_40:
        string val_4 = 1152921504621649920 + ((X24 + 72) << 4);
        val_19 = mem[(1152921504621649920 + (X24 + 72) << 4) + 312];
        goto label_25;
        label_4:
        string val_5 = 1152921504621649920 + val_17;
        goto label_25;
        label_31:
        if((playerID & 1) == 0)
        {
            goto label_11;
        }
        
        var val_21 = val_17;
        if((X24 + 72 + 294) == 0)
        {
            goto label_25;
        }
        
        var val_14 = X24 + 72 + 176;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_14:
        if(((X24 + 72 + 176 + 8) + -8) == X24.ByteBuffer)
        {
            goto label_13;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X24 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_25;
        label_32:
        var val_7 = val_17 + ((X24 + 72) << 4);
        val_21 = mem[(X24 + 72 + (X24 + 72) << 4) + 312];
        val_21 = (X24 + 72 + (X24 + 72) << 4) + 312;
        goto label_25;
        label_42:
        var val_16 = val_14;
        val_16 = val_16 + (X24 + 72);
        val_7 = val_7 + val_16;
        var val_8 = val_7 + 304;
        label_44:
        val_19 = mem[(((X24 + 72 + (X24 + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8];
        val_19 = (((X24 + 72 + (X24 + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8;
        goto label_25;
        label_6:
        var val_17 = mem[1152921504621686792];
        val_17 = val_17 + val_17;
        string val_9 = 1152921504621649920 + val_17;
        goto label_25;
        label_11:
        var val_18 = val_17;
        val_18 = val_18 + (X24 + 72);
        goto label_25;
        label_34:
        var val_19 = X11;
        val_19 = val_19 + pushToken;
        val_18 = val_18 + val_19;
        string val_10 = val_18 + 304;
        goto label_25;
        label_13:
        var val_20 = val_14;
        val_20 = val_20 + (X24 + 72);
        val_21 = val_21 + val_20;
        val_20 = val_21 + 304;
        goto label_25;
        label_49:
        val_17 = mem[1152921518869848080];
        if((mem[1152921518869848088] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921518869848088] + 74) == 2)
        {
            goto label_48;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921518869848088] + 74) != 2)
        {
            goto label_26;
        }
        
        if(val_17 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921518869848088] + 72) == 1) || (((mem[1152921518869848080] + 273) & 1) != 0)) || ((mem[1152921518869848080] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921518869848088] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921518869848088] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921518869848080] + 294) == 0)
        {
            goto label_25;
        }
        
        var val_22 = mem[1152921518869848080] + 176;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_35:
        if(((mem[1152921518869848080] + 176 + 8) + -8) == (mem[1152921518869848088] + 24))
        {
            goto label_34;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (mem[1152921518869848080] + 294))
        {
            goto label_35;
        }
        
        goto label_25;
        label_26:
        if(((mem[1152921518869848088] + 72) == 1) || ((mem[1152921518869848088] + 72) == 0))
        {
            goto label_38;
        }
        
        if((mem[1152921518869848088] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921518869848088] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_24 = 0;
        if(mem[1152921504621686784] == (mem[1152921518869848088] + 24))
        {
            goto label_42;
        }
        
        val_24 = val_24 + 1;
        goto label_44;
        label_38:
        if((val_17 != 0) || ((mem[1152921518869848088].ByteBuffer & 1) == 0))
        {
            goto label_48;
        }
        
        goto label_48;
        label_27:
        FlatBuffers.ByteBuffer val_12 = mem[1152921518869848088].ByteBuffer;
        label_48:
        label_25:
        val_25 = val_25 + 1;
        if(val_25 != val_15)
        {
            goto label_49;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(string playerID, string pushToken, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
