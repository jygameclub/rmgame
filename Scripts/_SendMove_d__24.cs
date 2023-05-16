using UnityEngine;
private sealed class RemainingMovesItemReplacer.<SendMove>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer <>4__this;
    public Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.ReplaceData replaceData;
    public int index;
    private Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles <newMove>5__2;
    private float <elapsed>5__3;
    private UnityEngine.Vector3 <start>5__4;
    private UnityEngine.Vector3 <end>5__5;
    private UnityEngine.Vector3 <firstReferencePoint>5__6;
    private UnityEngine.Vector3 <secondReferencePoint>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemainingMovesItemReplacer.<SendMove>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_17;
        float val_18;
        var val_19;
        float val_20;
        float val_21;
        if((this.<>1__state) != 1)
        {
                val_17 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
            this.<>1__state = 0;
            Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles val_1 = this.<>4__this.itemFactory.Spawn<Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles>(poolId:  70, activate:  true);
            this.<newMove>5__2 = val_1;
            val_1.transform.position = new UnityEngine.Vector3() {x = this.<>4__this.movesPosition};
            val_18 = this;
            this.<elapsed>5__3 = 0f;
            val_19 = null;
            val_19 = null;
            float val_17 = Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer.startXOffset;
            float val_3 = UnityEngine.Random.value;
            val_3 = val_3 + val_3;
            val_3 = val_3 + (-1f);
            val_17 = val_17 * val_3;
            float val_4 = UnityEngine.Random.value;
            val_4 = val_4 + val_4;
            val_4 = val_4 + (-1f);
            float val_5 = Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer.startYOffset * val_4;
            val_20 = 0f;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<>4__this.movesPosition, y = Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer.startYOffset, z = V13.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = val_20, z = 0f});
            this.<start>5__4 = val_6;
            mem[1152921519915789704] = val_6.y;
            mem[1152921519915789708] = val_6.z;
            UnityEngine.Vector3 val_7 = this.replaceData.cell.GetViewPosition();
            this.<end>5__5 = val_7;
            mem[1152921519915789716] = val_7.y;
            mem[1152921519915789720] = val_7.z;
            this.<firstReferencePoint>5__6 = this.<start>5__4;
            mem[1152921519915789728] = val_7.y;
            mem[1152921519915789732] = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.<start>5__4, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  2f);
            this.<secondReferencePoint>5__7 = val_9;
            mem[1152921519915789740] = val_9.y;
            mem[1152921519915789744] = val_9.z;
        }
        else
        {
                val_18 = this.<elapsed>5__3;
            this.<>1__state = 0;
        }
        
        val_21 = mem[this.<elapsed>5__3];
        val_21 = val_18;
        if(val_21 >= 0)
        {
                val_18 = this.<>4__this.audioManager;
            val_18.PlaySound(type:  ((this.<>4__this.randomManager.Next(min:  0, max:  2)) != 1) ? (226 + 1) : 226, offset:  0.04f);
            this.<>4__this.ReplaceWithSpecialItem(replaceData:  this.replaceData, index:  this.index);
            this.<>4__this.itemFactory.Recycle<Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesParticles>(go:  this.<newMove>5__2);
            val_17 = 0;
            return (bool)val_17;
        }
        
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = val_21 + val_12;
        val_18 = val_12;
        val_12 = val_12 / 0.6f;
        UnityEngine.Vector3 val_15 = Royal.Infrastructure.Utils.Animation.CubicBezierCurve.GetValue(t:  UnityEngine.Mathf.Clamp(value:  ManualEasing.Sine.Out(t:  val_12), min:  0f, max:  1f), p0:  new UnityEngine.Vector3() {x = this.<start>5__4, y = 1f}, p1:  new UnityEngine.Vector3() {x = this.<firstReferencePoint>5__6}, p2:  new UnityEngine.Vector3() {x = this.<secondReferencePoint>5__7, y = ???, z = this.<end>5__5}, p3:  new UnityEngine.Vector3() {x = ???, y = 0f, z = 0f});
        val_21 = val_15.x;
        val_20 = val_15.z;
        this.<newMove>5__2.transform.position = new UnityEngine.Vector3() {x = val_21, y = val_15.y, z = val_20};
        val_17 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_17;
        return (bool)val_17;
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
