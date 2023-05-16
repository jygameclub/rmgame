using UnityEngine;
private sealed class HorizontalDrillStrategy.<PlayHorizontalDrill>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DrillItem.Strategy.HorizontalDrillStrategy <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell;
    public Royal.Scenes.Game.Mechanics.Matches.Cell14 list;
    public Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles particles;
    private float <duration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HorizontalDrillStrategy.<PlayHorizontalDrill>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_10;
        int val_11;
        float val_12;
        val_10 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_11 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
        this.<>1__state = 0;
        float val_1 = (W9 == 0) ? 1f : -1f;
        UnityEngine.Vector3 val_3 = 64.transform.position;
        float val_10 = 0f;
        val_12 = val_3.y;
        val_10 = val_10 * 0.5f;
        val_10 = val_10 + 1.5f;
        val_1 = val_1 * val_10;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_12, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_1, y = val_12, z = 0f});
        val_4.x = val_4.x / 13.5f;
        this.<duration>5__2 = val_4.x;
        UnityEngine.Coroutine val_7 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.<>4__this.MoveToGlobalAndDestroy(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder, y = this.exploder}, trigger = this.exploder, id = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished}, trans:  UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 32.transform, targetPosition:  new UnityEngine.Vector3() {x = val_1, y = val_12, z = 0f}, drillCell:  this.cell, cellOnPath:  new Royal.Scenes.Game.Mechanics.Matches.Cell14()));
        this.<>4__this.explodedCells.Clear();
        val_11 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  0.15f);
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        39433.Recycle<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView>(go:  null);
        39433.Recycle<Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillTracerParticles>(go:  this.particles);
        val_11 = 0;
        return (bool)val_11;
        label_2:
        this.<>1__state = 0;
        65536.TryExplodeWaitingDrill();
        val_12 = this.<duration>5__2;
        Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds val_9 = null;
        float val_11 = 0.85f;
        val_11 = val_12 + val_11;
        val_9 = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  val_11);
        this.<>2__current = val_9;
        this.<>1__state = 2;
        val_11 = 1;
        return (bool)val_11;
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
