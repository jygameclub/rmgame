using UnityEngine;
private sealed class KingsCupGiftRewardView.<>c__DisplayClass15_0
{
    // Fields
    public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView <>4__this;
    public UnityEngine.GameObject hitParticles;
    
    // Methods
    public KingsCupGiftRewardView.<>c__DisplayClass15_0()
    {
    
    }
    internal void <PlayButtonHitAnimation>b__0()
    {
        this.<>4__this.audioManager.PlaySound(type:  23, offset:  0.04f);
    }
    internal void <PlayButtonHitAnimation>b__1()
    {
        UnityEngine.Object.Destroy(obj:  this.hitParticles);
    }

}
