using UnityEngine;
private sealed class ShopUnlimitedBoosterItemView.<PlayAnimation>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.ShopRewardItem.ShopUnlimitedBoosterItemView <>4__this;
    public int delayCount;
    private UnityEngine.Vector3 <startScale>5__2;
    private UnityEngine.Vector3 <endScale>5__3;
    private UnityEngine.Vector3 <startShadow>5__4;
    private UnityEngine.Vector3 <endShadow>5__5;
    private float <elapsed>5__6;
    private float <duration>5__7;
    private bool <isHitAnimationPlayed>5__8;
    private UnityEngine.Vector3 <start>5__9;
    private float <scaleDuration>5__10;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopUnlimitedBoosterItemView.<PlayAnimation>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_74;
        int val_91;
        val_74 = this;
        if((this.<>1__state) <= 9)
        {
                var val_74 = 36597804 + (this.<>1__state) << 2;
            val_74 = val_74 + 36597804;
        }
        else
        {
                val_91 = 0;
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
