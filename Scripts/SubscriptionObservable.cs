using UnityEngine;
public sealed class OneSignal.SubscriptionObservable : MulticastDelegate
{
    // Methods
    public OneSignal.SubscriptionObservable(object object, IntPtr method)
    {
        mem[1152921518872845968] = object;
        mem[1152921518872845976] = method;
        mem[1152921518872845952] = method;
    }
    public virtual void Invoke(OSSubscriptionStateChanges stateChanges)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_18;
        var val_19;
        var val_20;
        if(X8 != 0)
        {
                val_14 = mem[X8 + 24];
            val_14 = X8 + 24;
            if(val_14 == 0)
        {
                return;
        }
        
            val_15 = X8 + 32;
        }
        else
        {
                val_14 = 1;
        }
        
        var val_24 = 0;
        OSSubscriptionStateChanges val_1 = stateChanges - 16;
        goto label_46;
        label_39:
        val_16 = mem[X22 + 72];
        val_16 = X22 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_12 = 0;
        if(mem[1152921505018224640] == X22.ByteBuffer)
        {
            goto label_6;
        }
        
        val_12 = val_12 + 1;
        goto label_25;
        label_40:
        OSSubscriptionStateChanges val_3 = 1152921505018187776 + ((X22 + 72) << 4);
        val_18 = mem[(1152921505018187776 + (X22 + 72) << 4) + 312];
        goto label_25;
        label_4:
        OSSubscriptionStateChanges val_4 = 1152921505018187776 + val_16;
        goto label_25;
        label_31:
        if((stateChanges.Equals(obj:  mem[(1152921505018187776 + X22 + 72) + 304 + 8])) == false)
        {
            goto label_11;
        }
        
        var val_20 = val_16;
        if((X22 + 72 + 294) == 0)
        {
            goto label_25;
        }
        
        var val_13 = X22 + 72 + 176;
        var val_14 = 0;
        val_13 = val_13 + 8;
        label_14:
        if(((X22 + 72 + 176 + 8) + -8) == X22.ByteBuffer)
        {
            goto label_13;
        }
        
        val_14 = val_14 + 1;
        val_13 = val_13 + 16;
        if(val_14 < (X22 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_25;
        label_32:
        var val_7 = val_16 + ((X22 + 72) << 4);
        val_20 = mem[(X22 + 72 + (X22 + 72) << 4) + 312];
        val_20 = (X22 + 72 + (X22 + 72) << 4) + 312;
        goto label_25;
        label_42:
        var val_15 = val_13;
        val_15 = val_15 + (X22 + 72);
        val_7 = val_7 + val_15;
        var val_8 = val_7 + 304;
        label_44:
        val_18 = mem[(((X22 + 72 + (X22 + 72) << 4) + (((X22 + 72 + 176 + 8) + 16) + X22 + 72)) + 304) + 8];
        val_18 = (((X22 + 72 + (X22 + 72) << 4) + (((X22 + 72 + 176 + 8) + 16) + X22 + 72)) + 304) + 8;
        goto label_25;
        label_6:
        var val_16 = mem[1152921505018224648];
        val_16 = val_16 + val_16;
        OSSubscriptionStateChanges val_9 = 1152921505018187776 + val_16;
        goto label_25;
        label_11:
        var val_17 = val_16;
        val_17 = val_17 + (X22 + 72);
        goto label_25;
        label_34:
        var val_18 = X11;
        val_18 = val_18 + ((X22 + 72 + X22 + 72) + 304 + 8);
        val_17 = val_17 + val_18;
        var val_10 = val_17 + 304;
        label_36:
        val_20 = mem[(((X22 + 72 + X22 + 72) + (X11 + (X22 + 72 + X22 + 72) + 304 + 8)) + 304) + 8];
        val_20 = (((X22 + 72 + X22 + 72) + (X11 + (X22 + 72 + X22 + 72) + 304 + 8)) + 304) + 8;
        goto label_25;
        label_13:
        var val_19 = val_13;
        val_19 = val_19 + (X22 + 72);
        val_20 = val_20 + val_19;
        val_19 = val_20 + 304;
        goto label_25;
        label_46:
        val_16 = mem[1152921518872978448];
        if((mem[1152921518872978456] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921518872978456] + 74) == 1)
        {
            goto label_45;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921518872978456] + 74) != 1)
        {
            goto label_26;
        }
        
        if(val_16 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921518872978456] + 72) == 1) || (((mem[1152921518872978448] + 273) & 1) != 0)) || ((mem[1152921518872978448] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921518872978456] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921518872978456] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921518872978448] + 294) == 0)
        {
            goto label_36;
        }
        
        var val_21 = mem[1152921518872978448] + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_35:
        if(((mem[1152921518872978448] + 176 + 8) + -8) == (mem[1152921518872978456] + 24))
        {
            goto label_34;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (mem[1152921518872978448] + 294))
        {
            goto label_35;
        }
        
        goto label_36;
        label_26:
        if(((mem[1152921518872978456] + 72) == 1) || ((mem[1152921518872978456] + 72) == 0))
        {
            goto label_45;
        }
        
        if((mem[1152921518872978456] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921518872978456] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_23 = 0;
        if(mem[1152921505018224640] == (mem[1152921518872978456] + 24))
        {
            goto label_42;
        }
        
        val_23 = val_23 + 1;
        goto label_44;
        label_27:
        FlatBuffers.ByteBuffer val_11 = mem[1152921518872978456].ByteBuffer;
        label_45:
        label_25:
        val_24 = val_24 + 1;
        if(val_24 != val_14)
        {
            goto label_46;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(OSSubscriptionStateChanges stateChanges, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
