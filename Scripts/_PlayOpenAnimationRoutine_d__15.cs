using UnityEngine;
private sealed class EpisodeChestView.<PlayOpenAnimationRoutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestView <>4__this;
    public bool isArea1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EpisodeChestView.<PlayOpenAnimationRoutine>d__15(int <>1__state)
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
        this.<>4__this.audioManager.PlaySound(type:  56, offset:  0.04f);
        val_5 = 1;
        this.<>4__this.chestSkeleton.state.SetAnimation(trackIndex:  1, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.<>4__this.chestOpenReference), loop:  false) = 0;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.openParticles.Play();
        this.<>4__this.rewardExplosionParticles.Play();
        this.<>4__this.chestRewards.gameObject.SetActive(value:  true);
        this.<>4__this.PlayBoosterRevealSounds();
        this.<>4__this.chestRewards.PlayAnimation(isArea1:  this.isArea1, coinAmount:  250);
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
