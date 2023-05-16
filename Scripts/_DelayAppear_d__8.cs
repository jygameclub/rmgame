using UnityEngine;
private sealed class BirdNestCrack.<DelayAppear>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int index;
    public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack <>4__this;
    public UnityEngine.GameObject egg;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BirdNestCrack.<DelayAppear>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        float val_5 = 0.06f;
        val_5 = (float)this.index * val_5;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  val_5);
        val_5 = 1;
        this.<>2__current = val_1;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.birdAnimator.gameObject.SetActive(value:  true);
        float val_4 = UnityEngine.Random.value;
        float val_6 = 1f;
        val_4 = val_4 + val_4;
        val_6 = Royal.Scenes.Game.Levels.LevelContext.Time + val_6;
        val_4 = val_6 + val_4;
        this.<>4__this = val_4;
        this.<>4__this.birdAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack.CrackAppear, layer:  0, normalizedTime:  0f);
        this.egg.SetActive(value:  false);
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
