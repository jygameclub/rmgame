using UnityEngine;
private sealed class HammerBoosterView.<>c__DisplayClass13_0
{
    // Fields
    public System.Action onDestroy;
    public Royal.Scenes.Game.Mechanics.Boosters.Hammer.View.HammerBoosterView <>4__this;
    
    // Methods
    public HammerBoosterView.<>c__DisplayClass13_0()
    {
    
    }
    internal void <PlayInAnimation>b__0()
    {
        this.onDestroy.Invoke();
        UnityEngine.Object.Destroy(obj:  this.<>4__this.explodeParticles.gameObject);
        UnityEngine.Object.Destroy(obj:  this.<>4__this.gameObject);
    }

}
