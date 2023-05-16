using UnityEngine;
private sealed class AudioManager.<ReleasePoolableAudioSourceWhenPlayIsOver>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Start.Context.Units.Audio.AudioManager <>4__this;
    public long key;
    private Royal.Infrastructure.Utils.Pooling.PoolableAudioSource <poolableAudioSource>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AudioManager.<ReleasePoolableAudioSourceWhenPlayIsOver>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Royal.Infrastructure.Utils.Pooling.PoolableAudioSource val_4;
        int val_5;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_6;
        }
        
        this.<>1__state = 0;
        val_4 = this.<poolableAudioSource>5__2;
        if((this.<>4__this.keyAudioSourceDictionary.TryGetValue(key:  this.key, value: out  val_4)) == true)
        {
            goto label_5;
        }
        
        goto label_6;
        label_1:
        val_4 = this.<poolableAudioSource>5__2;
        this.<>1__state = 0;
        label_5:
        if((mem[this.<poolableAudioSource>5__2] + 24.isPlaying) != false)
        {
                val_5 = 1;
            this.<>2__current = 0;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        this.<>4__this.StopSound(key:  this.key);
        label_6:
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
