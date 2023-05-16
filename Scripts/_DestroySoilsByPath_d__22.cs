using UnityEngine;
private sealed class SoilItemHelper.<DestroySoilsByPath>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public sbyte[] depths;
    public Royal.Scenes.Game.Mechanics.Items.SoilItem.SoilItemHelper <>4__this;
    public int soilGroupId;
    private int <maxDepth>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SoilItemHelper.<DestroySoilsByPath>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        var val_3;
        int val_4;
        var val_5;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return false;
        }
        
            this.<>1__state = 0;
            val_2 = this.depths.Length;
            val_3 = this;
            this.<i>5__3 = 0;
            val_4 = 0;
            mem[1152921520155556948] = val_2;
        }
        else
        {
                val_3 = this;
            val_2 = mem[1152921520155556948];
            val_4 = (this.<i>5__3) + 1;
            this.<>1__state = 0;
            this.<i>5__3 = val_4;
        }
        
        if(val_4 >= val_2)
        {
                return false;
        }
        
        var val_6 = 0;
        val_5 = 1;
        label_22:
        if(val_6 >= (this.depths.Length << ))
        {
            goto label_7;
        }
        
        sbyte val_2 = this.depths[val_6];
        if((this.<i>5__3) == val_2)
        {
                if(val_2 <= this.soilGroupId)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_2 = val_2 + ((this.soilGroupId) << 3);
            var val_3 = (this.depths[0x0][0] + (this.soilGroupId) << 3) + 32;
            val_3 = val_3 + 0;
            var val_4 = ((this.depths[0x0][0] + (this.soilGroupId) << 3) + 32 + 0) + 32;
            if(((((this.depths[0x0][0] + (this.soilGroupId) << 3) + 32 + 0) + 32) & 1) != 0)
        {
                if(val_4 <= this.soilGroupId)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_4 = val_4 + ((this.soilGroupId) << 3);
            var val_5 = (((this.depths[0x0][0] + (this.soilGroupId) << 3) + 32 + 0) + 32 + (this.soilGroupId) << 3) + 32;
            val_5 = val_5 + 0;
            ((((this.depths[0x0][0] + (this.soilGroupId) << 3) + 32 + 0) + 32 + (this.soilGroupId) << 3) + 32 + 0) + 32.Destroy();
            val_5 = 0;
        }
        
        }
        
        val_6 = val_6 + 1;
        if(this.depths != null)
        {
            goto label_22;
        }
        
        throw new NullReferenceException();
        label_7:
        if((val_5 & 1) != 0)
        {
                return false;
        }
        
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = 1;
        return false;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
