using UnityEngine;
private sealed class Area03FireplaceView.<>c__DisplayClass46_0
{
    // Fields
    public UnityEngine.Transform vase;
    public Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace.Area03FireplaceView <>4__this;
    
    // Methods
    public Area03FireplaceView.<>c__DisplayClass46_0()
    {
    
    }
    internal void <PlayVase>b__0()
    {
        this.vase.gameObject.SetActive(value:  true);
    }
    internal void <PlayVase>b__1()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(trans:  this.<>4__this.leftVase, xScale:  1.01f, yScale:  0.98f, duration:  0.1f);
            return;
        }
        
        throw new NullReferenceException();
    }

}
