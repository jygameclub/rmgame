using UnityEngine;
private sealed class RoyalPassRewardContainerView.<>c__DisplayClass28_0
{
    // Fields
    public bool isSilent;
    
    // Methods
    public RoyalPassRewardContainerView.<>c__DisplayClass28_0()
    {
    
    }
    internal void <PlayLockedAnimation>b__0()
    {
        if(this.isSilent != false)
        {
                return;
        }
        
        Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  145, offset:  0.04f);
    }

}
