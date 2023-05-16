using UnityEngine;
public sealed class GoogleTranslation.fnOnTranslationReady : MulticastDelegate
{
    // Methods
    public GoogleTranslation.fnOnTranslationReady(object object, IntPtr method)
    {
        mem[1152921528734161552] = object;
        mem[1152921528734161560] = method;
        mem[1152921528734161536] = method;
    }
    public virtual void Invoke(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string error)
    {
        var val_16;
        var val_17;
        var val_18;
        var val_20;
        var val_21;
        var val_22;
        if(X8 != 0)
        {
                val_16 = mem[X8 + 24];
            val_16 = X8 + 24;
            if(val_16 == 0)
        {
                return;
        }
        
            val_17 = X8 + 32;
        }
        else
        {
                val_16 = 1;
        }
        
        var val_26 = 0;
        System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_1 = dict - 16;
        string val_2 = error - 16;
        goto label_49;
        label_39:
        val_18 = mem[X24 + 72];
        val_18 = X24 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_14 = 0;
        if(mem[1152921504683028480] == X24.ByteBuffer)
        {
            goto label_6;
        }
        
        val_14 = val_14 + 1;
        goto label_25;
        label_40:
        System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_4 = 1152921504682991616 + ((X24 + 72) << 4);
        val_20 = mem[(1152921504682991616 + (X24 + 72) << 4) + 312];
        goto label_25;
        label_4:
        System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_5 = 1152921504682991616 + val_18;
        goto label_25;
        label_31:
        if((dict.Equals(obj:  error)) == false)
        {
            goto label_11;
        }
        
        var val_22 = val_18;
        if((X24 + 72 + 294) == 0)
        {
            goto label_25;
        }
        
        var val_15 = X24 + 72 + 176;
        var val_16 = 0;
        val_15 = val_15 + 8;
        label_14:
        if(((X24 + 72 + 176 + 8) + -8) == X24.ByteBuffer)
        {
            goto label_13;
        }
        
        val_16 = val_16 + 1;
        val_15 = val_15 + 16;
        if(val_16 < (X24 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_25;
        label_32:
        var val_8 = val_18 + ((X24 + 72) << 4);
        val_22 = mem[(X24 + 72 + (X24 + 72) << 4) + 312];
        val_22 = (X24 + 72 + (X24 + 72) << 4) + 312;
        goto label_25;
        label_42:
        var val_17 = val_15;
        val_17 = val_17 + (X24 + 72);
        val_8 = val_8 + val_17;
        var val_9 = val_8 + 304;
        label_44:
        val_20 = mem[(((X24 + 72 + (X24 + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8];
        val_20 = (((X24 + 72 + (X24 + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8;
        goto label_25;
        label_6:
        var val_18 = mem[1152921504683028488];
        val_18 = val_18 + val_18;
        System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_10 = 1152921504682991616 + val_18;
        goto label_25;
        label_11:
        var val_19 = val_18;
        val_19 = val_19 + (X24 + 72);
        goto label_25;
        label_34:
        var val_20 = X11;
        val_20 = val_20 + error;
        val_19 = val_19 + val_20;
        string val_11 = val_19 + 304;
        goto label_25;
        label_13:
        var val_21 = val_15;
        val_21 = val_21 + (X24 + 72);
        val_22 = val_22 + val_21;
        val_21 = val_22 + 304;
        goto label_25;
        label_49:
        val_18 = mem[1152921528734302224];
        if((mem[1152921528734302232] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921528734302232] + 74) == 2)
        {
            goto label_48;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921528734302232] + 74) != 2)
        {
            goto label_26;
        }
        
        if(val_18 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921528734302232] + 72) == 1) || (((mem[1152921528734302224] + 273) & 1) != 0)) || ((mem[1152921528734302224] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921528734302232] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921528734302232] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921528734302224] + 294) == 0)
        {
            goto label_25;
        }
        
        var val_23 = mem[1152921528734302224] + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_35:
        if(((mem[1152921528734302224] + 176 + 8) + -8) == (mem[1152921528734302232] + 24))
        {
            goto label_34;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (mem[1152921528734302224] + 294))
        {
            goto label_35;
        }
        
        goto label_25;
        label_26:
        if(((mem[1152921528734302232] + 72) == 1) || ((mem[1152921528734302232] + 72) == 0))
        {
            goto label_38;
        }
        
        if((mem[1152921528734302232] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921528734302232] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_25 = 0;
        if(mem[1152921504683028480] == (mem[1152921528734302232] + 24))
        {
            goto label_42;
        }
        
        val_25 = val_25 + 1;
        goto label_44;
        label_38:
        if((val_18 != 0) || ((mem[1152921528734302232].ByteBuffer & 1) == 0))
        {
            goto label_48;
        }
        
        goto label_48;
        label_27:
        FlatBuffers.ByteBuffer val_13 = mem[1152921528734302232].ByteBuffer;
        label_48:
        label_25:
        val_26 = val_26 + 1;
        if(val_26 != val_16)
        {
            goto label_49;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> dict, string error, System.AsyncCallback callback, object object)
    {
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
