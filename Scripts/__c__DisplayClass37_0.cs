using UnityEngine;
private sealed class Area03FireplaceView.<>c__DisplayClass37_0
{
    // Fields
    public UnityEngine.Transform side;
    public Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace.Area03FireplaceView <>4__this;
    
    // Methods
    public Area03FireplaceView.<>c__DisplayClass37_0()
    {
    
    }
    internal void <AnimateFireplaceSide>b__0()
    {
        this.side.gameObject.SetActive(value:  true);
    }
    internal void <AnimateFireplaceSide>b__1()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(trans:  this.side, xScale:  1.03f, yScale:  0.95f, duration:  0.1f);
            return;
        }
        
        throw new NullReferenceException();
    }

}
