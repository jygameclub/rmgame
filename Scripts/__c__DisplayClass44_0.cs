using UnityEngine;
private sealed class Area03FireplaceView.<>c__DisplayClass44_0
{
    // Fields
    public Royal.Scenes.Home.Areas.Area03.Tasks.Fireplace.Area03FireplaceView <>4__this;
    public float xSquash;
    public float ySquash;
    
    // Methods
    public Area03FireplaceView.<>c__DisplayClass44_0()
    {
    
    }
    internal void <PlayRightCandles>b__0()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(trans:  this.<>4__this.rightCandle3, xScale:  this.xSquash, yScale:  this.ySquash, duration:  0.1f);
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <PlayRightCandles>b__1()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(trans:  this.<>4__this.rightCandle2, xScale:  this.xSquash, yScale:  this.ySquash, duration:  0.1f);
            return;
        }
        
        throw new NullReferenceException();
    }
    internal void <PlayRightCandles>b__2()
    {
        if((this.<>4__this) != null)
        {
                this.SquashStretch(trans:  this.<>4__this.rightCandle1, xScale:  this.xSquash, yScale:  this.ySquash, duration:  0.1f);
            return;
        }
        
        throw new NullReferenceException();
    }

}
