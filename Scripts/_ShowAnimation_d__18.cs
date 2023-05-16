using UnityEngine;
private sealed class ContributionItemView.<ShowAnimation>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView <>4__this;
    private UnityEngine.Vector3 <startScale>5__2;
    private UnityEngine.Vector3 <endScale>5__3;
    private UnityEngine.Vector3 <startShadow>5__4;
    private UnityEngine.Vector3 <endShadow>5__5;
    private float <elapsed>5__6;
    private float <duration>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ContributionItemView.<ShowAnimation>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Scenes.Home.Ui.Sections.Home.RewardedItem.ContributionItemView val_43;
        int val_57;
        if((this.<>1__state) <= 4)
        {
                var val_43 = 36597628 + (this.<>1__state) << 2;
            val_43 = this.<>4__this;
            val_43 = val_43 + 36597628;
        }
        else
        {
                val_57 = 0;
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
