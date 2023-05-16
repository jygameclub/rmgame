using UnityEngine;
public sealed class LanguageSource.fnOnSourceUpdated : MulticastDelegate
{
    // Methods
    public LanguageSource.fnOnSourceUpdated(object object, IntPtr method)
    {
        mem[1152921528742531680] = object;
        mem[1152921528742531688] = method;
        mem[1152921528742531664] = method;
    }
    public virtual void Invoke(I2.Loc.LanguageSourceData source, bool ReceivedNewData, string errorMsg)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_24;
        var val_25;
        var val_26;
        bool val_1 = ReceivedNewData;
        if(val_1 != false)
        {
                val_20 = mem[(ReceivedNewData & 1) + 24];
            val_20 = (ReceivedNewData & 1) + 24;
            if(val_20 == 0)
        {
                return;
        }
        
            val_21 = val_1 + 32;
        }
        else
        {
                val_20 = 1;
        }
        
        var val_30 = 0;
        I2.Loc.LanguageSourceData val_2 = source - 16;
        goto label_49;
        label_39:
        val_22 = mem[X24 + 72];
        val_22 = X24 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_18 = 0;
        if(mem[1152921505148575744] == X24.ByteBuffer)
        {
            goto label_6;
        }
        
        val_18 = val_18 + 1;
        goto label_8;
        label_40:
        I2.Loc.LanguageSourceData val_4 = 1152921505148538880 + (((ReceivedNewData & 1) + 72) << 4);
        val_24 = mem[(1152921505148538880 + ((ReceivedNewData & 1) + 72) << 4) + 312];
        goto label_9;
        label_4:
        I2.Loc.LanguageSourceData val_5 = 1152921505148538880 + val_22;
        goto label_25;
        label_31:
        if((source.Equals(obj:  val_1)) == false)
        {
            goto label_11;
        }
        
        var val_26 = val_22;
        if((X24 + 72 + 294) == 0)
        {
            goto label_15;
        }
        
        var val_19 = X24 + 72 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_14:
        if(((X24 + 72 + 176 + 8) + -8) == X24.ByteBuffer)
        {
            goto label_13;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X24 + 72 + 294))
        {
            goto label_14;
        }
        
        goto label_15;
        label_32:
        var val_8 = val_22 + (((ReceivedNewData & 1) + 72) << 4);
        val_26 = mem[(X24 + 72 + ((ReceivedNewData & 1) + 72) << 4) + 312];
        val_26 = (X24 + 72 + ((ReceivedNewData & 1) + 72) << 4) + 312;
        goto label_16;
        label_42:
        var val_21 = val_19;
        val_21 = val_21 + (X24 + 72);
        val_8 = val_8 + val_21;
        var val_9 = val_8 + 304;
        label_44:
        val_24 = mem[(((X24 + 72 + ((ReceivedNewData & 1) + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8];
        val_24 = (((X24 + 72 + ((ReceivedNewData & 1) + 72) << 4) + (((X24 + 72 + 176 + 8) + 16) + X24 + 72)) + 304) + 8;
        label_9:
        var val_10 = (val_22 != 0) ? 1 : 0;
        goto label_25;
        label_6:
        var val_22 = mem[1152921505148575752];
        val_22 = val_22 + val_22;
        I2.Loc.LanguageSourceData val_11 = 1152921505148538880 + val_22;
        label_8:
        var val_12 = (val_1 == true) ? 1 : 0;
        goto label_25;
        label_11:
        var val_23 = val_22;
        val_23 = val_23 + (X24 + 72);
        goto label_25;
        label_34:
        var val_24 = X11;
        val_24 = val_24 + val_1;
        val_23 = val_23 + val_24;
        bool val_13 = val_23 + 304;
        label_36:
        val_26 = mem[(((X24 + 72 + X24 + 72) + (X11 + (ReceivedNewData & 1))) + 304) + 8];
        val_26 = (((X24 + 72 + X24 + 72) + (X11 + (ReceivedNewData & 1))) + 304) + 8;
        label_16:
        var val_14 = ((X24 + 72) != 0) ? 1 : 0;
        goto label_25;
        label_13:
        var val_25 = val_19;
        val_25 = val_25 + (X24 + 72);
        val_26 = val_26 + val_25;
        val_25 = val_26 + 304;
        label_15:
        var val_15 = (val_1 == true) ? 1 : 0;
        goto label_25;
        label_49:
        val_22 = mem[1152921528742672352];
        if((mem[1152921528742672360] & 1) == 0)
        {
            goto label_23;
        }
        
        if((mem[1152921528742672360] + 74) == 3)
        {
            goto label_48;
        }
        
        goto label_25;
        label_23:
        if((mem[1152921528742672360] + 74) != 3)
        {
            goto label_26;
        }
        
        if(val_22 == 0)
        {
            goto label_27;
        }
        
        if((((mem[1152921528742672360] + 72) == 1) || (((mem[1152921528742672352] + 273) & 1) != 0)) || ((mem[1152921528742672352] + 273) == 0))
        {
            goto label_25;
        }
        
        if((mem[1152921528742672360] & 1) == 0)
        {
            goto label_31;
        }
        
        if((mem[1152921528742672360] & 1) == 0)
        {
            goto label_32;
        }
        
        if((mem[1152921528742672352] + 294) == 0)
        {
            goto label_36;
        }
        
        var val_27 = mem[1152921528742672352] + 176;
        var val_28 = 0;
        val_27 = val_27 + 8;
        label_35:
        if(((mem[1152921528742672352] + 176 + 8) + -8) == (mem[1152921528742672360] + 24))
        {
            goto label_34;
        }
        
        val_28 = val_28 + 1;
        val_27 = val_27 + 16;
        if(val_28 < (mem[1152921528742672352] + 294))
        {
            goto label_35;
        }
        
        goto label_36;
        label_26:
        if(((mem[1152921528742672360] + 72) == 1) || ((mem[1152921528742672360] + 72) == 0))
        {
            goto label_38;
        }
        
        if((mem[1152921528742672360] & 1) == 0)
        {
            goto label_39;
        }
        
        if((mem[1152921528742672360] & 1) == 0)
        {
            goto label_40;
        }
        
        var val_29 = 0;
        if(mem[1152921505148575744] == (mem[1152921528742672360] + 24))
        {
            goto label_42;
        }
        
        val_29 = val_29 + 1;
        goto label_44;
        label_38:
        if((val_22 != 0) || ((mem[1152921528742672360].ByteBuffer & 1) == 0))
        {
            goto label_48;
        }
        
        goto label_48;
        label_27:
        FlatBuffers.ByteBuffer val_17 = mem[1152921528742672360].ByteBuffer;
        label_48:
        label_25:
        val_30 = val_30 + 1;
        if(val_30 != val_20)
        {
            goto label_49;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(I2.Loc.LanguageSourceData source, bool ReceivedNewData, string errorMsg, System.AsyncCallback callback, object object)
    {
        bool val_1 = ReceivedNewData;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
