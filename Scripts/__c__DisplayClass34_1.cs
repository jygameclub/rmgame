using UnityEngine;
private sealed class CurtainManager.<>c__DisplayClass34_1
{
    // Fields
    public Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemView bottomCurtain;
    
    // Methods
    public CurtainManager.<>c__DisplayClass34_1()
    {
    
    }
    internal void <MoveCurtain>b__4()
    {
        if(this.bottomCurtain != null)
        {
                this.bottomCurtain.PlayRevealParticles();
            return;
        }
        
        throw new NullReferenceException();
    }

}
