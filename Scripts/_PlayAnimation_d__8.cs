using UnityEngine;
private sealed class WinStarView.<PlayAnimation>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar.WinStarView <>4__this;
    private float <elapsed>5__2;
    private float <duration>5__3;
    private UnityEngine.Vector3 <end>5__4;
    private UnityEngine.Vector3 <starObjectPositionAtStart>5__5;
    private bool <isHitAnimationPlayed>5__6;
    private UnityEngine.Vector3 <start>5__7;
    private float <totalRotate>5__8;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WinStarView.<PlayAnimation>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_91;
        int val_104;
        val_91 = this;
        if((this.<>1__state) <= 8)
        {
                var val_91 = 36598144 + (this.<>1__state) << 2;
            val_91 = val_91 + 36598144;
        }
        else
        {
                val_104 = 0;
            return (bool);
        }
    
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
