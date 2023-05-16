using UnityEngine;
public sealed class GoalManager.GoalUpdatedUi : MulticastDelegate
{
    // Methods
    public GoalManager.GoalUpdatedUi(object object, IntPtr method)
    {
        mem[1152921523960389824] = object;
        mem[1152921523960389832] = method;
        mem[1152921523960389808] = method;
    }
    public virtual void Invoke(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int uiCount, bool hasPrerequisite, bool forStart, bool isGoalCompleted)
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(X8 != 0)
        {
                val_19 = mem[X8 + 24];
            val_19 = X8 + 24;
            if(val_19 == 0)
        {
                return;
        }
        
            val_20 = X8 + 32;
        }
        else
        {
                val_19 = 1;
        }
        
        var val_25 = 0;
        goto label_29;
        label_21:
        val_21 = mem[X26 + 72];
        val_21 = X26 + 72;
        if((this & 1) == 0)
        {
            goto label_4;
        }
        
        var val_22 = X25;
        if((X25 + 294) == 0)
        {
            goto label_8;
        }
        
        var val_17 = X25 + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_7:
        if(((X25 + 176 + 8) + -8) == X26.ByteBuffer)
        {
            goto label_6;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (X25 + 294))
        {
            goto label_7;
        }
        
        goto label_8;
        label_22:
        var val_2 = X25 + ((goalType + 72) << 4);
        val_23 = mem[(X25 + (goalType + 72) << 4) + 312];
        val_23 = (X25 + (goalType + 72) << 4) + 312;
        goto label_9;
        label_4:
        var val_19 = X25;
        hasPrerequisite = hasPrerequisite;
        forStart = forStart;
        val_19 = val_19 + val_21;
        isGoalCompleted = isGoalCompleted;
        goto label_27;
        label_24:
        var val_20 = X11;
        val_20 = val_20 + uiCount;
        val_19 = val_19 + val_20;
        int val_3 = val_19 + 304;
        label_26:
        val_23 = mem[(((X25 + X26 + 72) + (X11 + uiCount)) + 304) + 8];
        val_23 = (((X25 + X26 + 72) + (X11 + uiCount)) + 304) + 8;
        label_9:
        bool val_4 = hasPrerequisite;
        bool val_5 = forStart;
        bool val_6 = isGoalCompleted;
        goto label_27;
        label_6:
        var val_21 = val_17;
        val_21 = val_21 + val_21;
        val_22 = val_22 + val_21;
        val_22 = val_22 + 304;
        label_8:
        hasPrerequisite = hasPrerequisite;
        forStart = forStart;
        isGoalCompleted = isGoalCompleted;
        goto label_27;
        label_29:
        if((mem[1152921523960518216] & 1) == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921523960518216] + 74) != 5)
        {
            goto label_20;
        }
        
        bool val_7 = hasPrerequisite;
        bool val_8 = forStart;
        bool val_9 = isGoalCompleted;
        goto label_27;
        label_14:
        if(mem[1152921523960518208] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921523960518216] + 72) == 1) || (((mem[1152921523960518208] + 273) & 1) != 0)) || (mem[1152921523960518200] == 0))
        {
            goto label_20;
        }
        
        if((mem[1152921523960518216] & 1) == 0)
        {
            goto label_21;
        }
        
        if((mem[1152921523960518216] & 1) == 0)
        {
            goto label_22;
        }
        
        if((mem[1152921523960518208] + 294) == 0)
        {
            goto label_26;
        }
        
        var val_23 = mem[1152921523960518208] + 176;
        var val_24 = 0;
        val_23 = val_23 + 8;
        label_25:
        if(((mem[1152921523960518208] + 176 + 8) + -8) == (mem[1152921523960518216] + 24))
        {
            goto label_24;
        }
        
        val_24 = val_24 + 1;
        val_23 = val_23 + 16;
        if(val_24 < (mem[1152921523960518208] + 294))
        {
            goto label_25;
        }
        
        goto label_26;
        label_20:
        hasPrerequisite = hasPrerequisite;
        forStart = forStart;
        isGoalCompleted = isGoalCompleted;
        goto label_27;
        label_17:
        if((mem[1152921523960518216].ByteBuffer & 1) != 0)
        {
                bool val_11 = hasPrerequisite;
            bool val_12 = forStart;
            bool val_13 = isGoalCompleted;
        }
        
        bool val_14 = hasPrerequisite;
        bool val_15 = forStart;
        bool val_16 = isGoalCompleted;
        label_27:
        val_25 = val_25 + 1;
        if(val_25 != val_19)
        {
            goto label_29;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(Royal.Scenes.Game.Mechanics.Goal.GoalType goalType, int uiCount, bool hasPrerequisite, bool forStart, bool isGoalCompleted, System.AsyncCallback callback, object object)
    {
        bool val_1 = hasPrerequisite;
        bool val_2 = forStart;
        bool val_3 = isGoalCompleted;
        return (System.IAsyncResult)this;
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
