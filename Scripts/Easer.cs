using UnityEngine;
public sealed class ManualEasing.Easer : MulticastDelegate
{
    // Methods
    public ManualEasing.Easer(object object, IntPtr method)
    {
        mem[1152921527486516576] = object;
        mem[1152921527486516584] = method;
        mem[1152921527486516560] = method;
    }
    public virtual float Invoke(float t)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(X8 != 0)
        {
                val_7 = mem[X8 + 24];
            val_7 = X8 + 24;
            if(val_7 == 0)
        {
                return 0f;
        }
        
            val_8 = X8 + 32;
        }
        else
        {
                val_7 = 1;
        }
        
        var val_13 = 0;
        goto label_28;
        label_21:
        val_9 = mem[X22 + 72];
        val_9 = X22 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_10 = X21;
        if((X21 + 294) == 0)
        {
            goto label_16;
        }
        
        var val_5 = X21 + 176;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_7:
        if(((X21 + 176 + 8) + -8) == X22.ByteBuffer)
        {
            goto label_6;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (X21 + 294))
        {
            goto label_7;
        }
        
        goto label_16;
        label_22:
        var val_2 = X21 + ((X22 + 72) << 4);
        val_11 = mem[(X21 + (X22 + 72) << 4) + 312];
        val_11 = (X21 + (X22 + 72) << 4) + 312;
        goto label_16;
        label_4:
        var val_7 = X21;
        val_7 = val_7 + val_9;
        goto label_16;
        label_24:
        var val_8 = X11;
        val_8 = val_8 + W2;
        val_7 = val_7 + val_8;
        var val_3 = val_7 + 304;
        label_26:
        val_11 = mem[(((X21 + X22 + 72) + (X11 + W2)) + 304) + 8];
        val_11 = (((X21 + X22 + 72) + (X11 + W2)) + 304) + 8;
        goto label_16;
        label_6:
        var val_9 = val_5;
        val_9 = val_9 + val_9;
        val_10 = val_10 + val_9;
        val_10 = val_10 + 304;
        goto label_16;
        label_28:
        if((mem[1152921527486640872] & 1) == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921527486640872] + 74) != 1)
        {
            goto label_27;
        }
        
        goto label_16;
        label_14:
        if(mem[1152921527486640864] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921527486640872] + 72) == 1) || (((mem[1152921527486640864] + 273) & 1) != 0)) || ((mem[1152921527486640864] + 273) == 0))
        {
            goto label_27;
        }
        
        if((mem[1152921527486640872] & 1) == 0)
        {
            goto label_21;
        }
        
        if((mem[1152921527486640872] & 1) == 0)
        {
            goto label_22;
        }
        
        if((mem[1152921527486640864] + 294) == 0)
        {
            goto label_26;
        }
        
        var val_11 = mem[1152921527486640864] + 176;
        var val_12 = 0;
        val_11 = val_11 + 8;
        label_25:
        if(((mem[1152921527486640864] + 176 + 8) + -8) == (mem[1152921527486640872] + 24))
        {
            goto label_24;
        }
        
        val_12 = val_12 + 1;
        val_11 = val_11 + 16;
        if(val_12 < (mem[1152921527486640864] + 294))
        {
            goto label_25;
        }
        
        goto label_26;
        label_17:
        if((mem[1152921527486640872].ByteBuffer & 1) != 0)
        {
            
        }
        
        label_27:
        label_16:
        val_13 = val_13 + 1;
        if(val_13 != val_7)
        {
            goto label_28;
        }
        
        return 0f;
    }
    public virtual System.IAsyncResult BeginInvoke(float t, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual float EndInvoke(System.IAsyncResult result)
    {
        result.System.IDisposable.Dispose();
        return (float)null;
    }

}
