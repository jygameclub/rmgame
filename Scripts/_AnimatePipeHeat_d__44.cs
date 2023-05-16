using UnityEngine;
private sealed class MetalCrusherItemView.<AnimatePipeHeat>d__44 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView <>4__this;
    private float <elapsed>5__2;
    private float <heatStartSize>5__3;
    private float <heatStartPos>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MetalCrusherItemView.<AnimatePipeHeat>d__44(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_20;
        float val_21;
        int val_22;
        float val_23;
        float val_24;
        float val_25;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        val_20 = this;
        this.<elapsed>5__2 = 0f;
        this.<>1__state = 0;
        mem[1152921520230020172] = 0;
        mem[1152921520230020176] = 0;
        Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherDirection val_17 = this.<>4__this.metalCrusherDirection;
        if((val_17 - 1) < 2)
        {
            goto label_3;
        }
        
        val_17 = val_17 - 3;
        if(val_17 > 1)
        {
            goto label_9;
        }
        
        UnityEngine.Vector2 val_2 = this.<>4__this.pipeHeat.size;
        this.<heatStartSize>5__3 = val_2.x;
        UnityEngine.Vector3 val_4 = this.<>4__this.pipeHeat.transform.position;
        this.<heatStartPos>5__4 = val_4.y;
        goto label_9;
        label_0:
        val_20 = this.<elapsed>5__2;
        this.<>1__state = 0;
        goto label_9;
        label_3:
        UnityEngine.Vector2 val_5 = this.<>4__this.pipeHeat.size;
        this.<heatStartSize>5__3 = val_5.x;
        UnityEngine.Vector3 val_7 = this.<>4__this.pipeHeat.transform.position;
        this.<heatStartPos>5__4 = val_7.x;
        label_9:
        val_21 = this.<elapsed>5__2;
        if(val_21 < 0)
        {
            goto label_13;
        }
        
        label_1:
        val_22 = 0;
        return (bool)val_22;
        label_13:
        float val_8 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_8 = val_21 + val_8;
        this.<elapsed>5__2 = val_8;
        UnityEngine.Vector3 val_10 = this.<>4__this.metal.transform.position;
        if((this.<>4__this.metalCrusherDirection) == 3)
        {
            goto label_18;
        }
        
        if((this.<>4__this.metalCrusherDirection) == 2)
        {
            goto label_19;
        }
        
        if((this.<>4__this.metalCrusherDirection) != 1)
        {
            goto label_20;
        }
        
        UnityEngine.Vector2 val_11 = this.<>4__this.metal.size;
        val_23 = this.<heatStartPos>5__4;
        val_11.x = val_11.x * 0.5f;
        val_24 = val_10.x + val_11.x;
        goto label_26;
        label_19:
        UnityEngine.Vector2 val_12 = this.<>4__this.metal.size;
        val_24 = this.<heatStartPos>5__4;
        val_25 = -0.5f;
        val_12.x = val_12.x * val_25;
        val_23 = val_10.x + val_12.x;
        goto label_26;
        label_18:
        UnityEngine.Vector2 val_13 = this.<>4__this.metal.size;
        float val_18 = -0.5f;
        val_24 = this.<heatStartPos>5__4;
        val_18 = val_13.y * val_18;
        val_18 = val_10.y + val_18;
        val_23 = val_18 + 0.02f;
        goto label_26;
        label_20:
        UnityEngine.Vector2 val_14 = this.<>4__this.metal.size;
        val_23 = this.<heatStartPos>5__4;
        val_14.y = val_14.y * 0.5f;
        val_25 = val_10.y + val_14.y;
        val_24 = val_25 + (-0.01f);
        label_26:
        val_21 = val_24 - val_23;
        if(val_21 <= (this.<heatStartSize>5__3))
        {
                UnityEngine.Vector2 val_15 = this.<>4__this.pipeHeat.size;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_21, y:  val_15.y);
            this.<>4__this.pipeHeat.size = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        }
        
        val_22 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_22;
        return (bool)val_22;
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
