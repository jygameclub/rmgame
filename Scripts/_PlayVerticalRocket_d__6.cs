using UnityEngine;
private sealed class VerticalRocketStrategy.<PlayVerticalRocket>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy <>4__this;
    public Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> topList;
    public System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> bottomList;
    private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles <particles1>5__2;
    private Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles <particles2>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VerticalRocketStrategy.<PlayVerticalRocket>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_37;
        int val_38;
        val_37 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_38 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_38;
        }
        
        this.<>1__state = 0;
        0.gameObject.SetActive(value:  false);
        43271312.gameObject.SetActive(value:  false);
        43336848.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_5 = 43336848.transform.position;
        float val_36 = 8.96831E-44f;
        val_36 = val_36 * 0.5f;
        float val_6 = val_36 + 2f;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_6, z = 0f});
        UnityEngine.Coroutine val_10 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.<>4__this.MoveToGlobalAndDestroy(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder, y = this.exploder}, trigger = this.exploder, id = UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished}, trans:  UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 144.transform, targetPosition:  new UnityEngine.Vector3() {x = val_5.x, y = val_6, z = 0f}, cellList:  this.topList));
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.down;
        this.<particles1>5__2 = this.<>4__this.GetParticles(parent:  transform, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_methods.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_16 = Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_methods.transform.position;
        Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_byval_arg = Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_byval_arg * (-0.5f);
        float val_17 = Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_byval_arg + (-2f);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_17, z = 0f});
        UnityEngine.Coroutine val_21 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.<>4__this.MoveToGlobalAndDestroy(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = this.exploder.point, y = this.exploder.point}, trigger = this.exploder.point, id = this.exploder.matchType}, trans:  this.exploder.matchType + 152.transform, targetPosition:  new UnityEngine.Vector3() {x = val_16.x, y = val_17, z = 0f}, cellList:  this.bottomList));
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.up;
        this.<particles2>5__3 = this.<>4__this.GetParticles(parent:  this.exploder.matchType + 152.transform, position:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        if(Royal.Player.Context.Units.LevelManager.IsStoryLevel != false)
        {
                UnityEngine.GameObject val_26 = this.<particles1>5__2.gameObject;
            val_26.EnableFillMask(particles:  val_26);
            UnityEngine.GameObject val_27 = this.<particles2>5__3.gameObject;
            val_27.EnableFillMask(particles:  val_27);
        }
        
        val_38 = 1;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  UnityEngine.Mathf.Max(a:  val_7.x / 13.5f, b:  val_18.x / 13.5f));
        this.<>1__state = val_38;
        return (bool)val_38;
        label_1:
        this.<>1__state = 0;
        bool val_32 = Royal.Player.Context.Units.LevelManager.IsStoryLevel;
        if(val_32 == false)
        {
            goto label_44;
        }
        
        UnityEngine.GameObject val_33 = this.<particles1>5__2.gameObject;
        val_33.DisableFillMask(particles:  val_33);
        UnityEngine.GameObject val_34 = this.<particles2>5__3.gameObject;
        val_34.DisableFillMask(particles:  val_34);
        goto label_49;
        label_2:
        this.<>1__state = 0;
        this.<>2__current = new Royal.Scenes.Game.Mechanics.Replay.WaitForGameplaySeconds(targetSeconds:  1f);
        this.<>1__state = 2;
        val_38 = 1;
        return (bool)val_38;
        label_44:
        label_49:
        val_32.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView>(go:  null);
        val_32.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(go:  this.<particles1>5__2);
        val_32.Recycle<Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles>(go:  this.<particles2>5__3);
        val_38 = 0;
        return (bool)val_38;
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
