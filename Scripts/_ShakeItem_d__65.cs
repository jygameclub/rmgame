using UnityEngine;
private sealed class LightballStrategy.<ShakeItem>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy <>4__this;
    public Royal.Scenes.Game.Mechanics.Items.Config.RootTransform trans;
    private float <scaleSpeed>5__2;
    private UnityEngine.Vector3 <initialPosition>5__3;
    private UnityEngine.Vector3 <startPosition>5__4;
    private UnityEngine.Vector3 <targetPosition>5__5;
    private float <elapsed>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LightballStrategy.<ShakeItem>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        var val_12;
        float val_13;
        float val_14;
        float val_15;
        int val_16;
        float val_17;
        var val_18;
        UnityEngine.Vector3 val_22;
        var val_23;
        var val_24;
        float val_25;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_11 = this;
        mem[1152921520149206192] = ???;
        UnityEngine.Vector3 val_1 = this.trans.GetPosition();
        this.<initialPosition>5__3 = val_1;
        mem[1152921520149206200] = val_1.y;
        mem[1152921520149206204] = val_1.z;
        this.<startPosition>5__4 = val_1;
        mem[1152921520149206212] = val_1.y;
        mem[1152921520149206216] = val_1.z;
        UnityEngine.Vector3 val_2 = Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.GetRandomPositionWithOffset(initialPosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, offset:  val_1.x);
        val_12 = this;
        this.<elapsed>5__6 = 0f;
        val_13 = 0f;
        mem[1152921520149206220] = val_2.x;
        mem[1152921520149206224] = val_2.y;
        mem[1152921520149206228] = val_2.z;
        goto label_7;
        label_1:
        val_12 = this;
        val_13 = this.<elapsed>5__6;
        this.<>1__state = 0;
        val_11 = 1152921520149206184;
        label_7:
        val_14 = val_13 + Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        this.<elapsed>5__6 = val_14;
        UnityEngine.Vector3 val_4 = val_11.GetScale();
        if(val_4.x <= val_4.x)
        {
            goto label_10;
        }
        
        val_14 = this.<scaleSpeed>5__2;
        val_15 = -val_14;
        this.<scaleSpeed>5__2 = val_15;
        goto label_14;
        label_2:
        val_16 = 0;
        return (bool)val_16;
        label_10:
        if(val_4.x < 0)
        {
                val_15 = val_4.x;
            this.<scaleSpeed>5__2 = val_4.x;
        }
        else
        {
                val_15 = this.<scaleSpeed>5__2;
        }
        
        label_14:
        float val_5 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_5 = val_15 * val_5;
        val_17 = val_4.x + val_5;
        this.trans.SetScale(vector:  new UnityEngine.Vector3() {x = val_17, y = val_17, z = val_4.z});
        val_18 = 0;
        UnityEngine.Vector3 val_6 = this.trans.GetPosition();
        if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(v1:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, v2:  new UnityEngine.Vector3() {x = this.<targetPosition>5__5})) != false)
        {
                this.<startPosition>5__4 = this.<targetPosition>5__5;
            mem[1152921520149206216] = typeof(Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy).__il2cppRuntimeField_200;
            val_17 = this.<initialPosition>5__3;
            UnityEngine.Vector3 val_8 = Royal.Scenes.Game.Mechanics.Items.SpecialItems.LightballItem.Strategy.LightballStrategy.GetRandomPositionWithOffset(initialPosition:  new UnityEngine.Vector3() {x = val_17, y = val_4.x, z = val_4.z}, offset:  val_6.x);
            val_22 = val_8.x;
            val_23 = val_8.y;
            val_24 = val_8.z;
            val_25 = 0f;
            this.<targetPosition>5__5 = val_8;
            mem[1152921520149206224] = val_8.y;
            mem[1152921520149206228] = val_8.z;
            this.<elapsed>5__6 = 0f;
        }
        else
        {
                val_22 = this.<targetPosition>5__5;
            val_25 = this.<elapsed>5__6;
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<startPosition>5__4, y = V12.16B, z = V11.16B}, b:  new UnityEngine.Vector3() {x = val_22, y = val_4.x, z = val_15}, t:  val_25 / val_6.x);
        this.trans.SetPosition(vector:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_16 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_16;
        return (bool)val_16;
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
