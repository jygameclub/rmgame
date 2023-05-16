using UnityEngine;
private sealed class MetalCrusherItemView.<AnimatePipeHeat>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView <>4__this;
    public bool isEnabled;
    private float <startAlpha>5__2;
    private float <endAlpha>5__3;
    private float <elapsed>5__4;
    private Royal.Infrastructure.Utils.Animation.ManualEasing.Easer <easing>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MetalCrusherItemView.<AnimatePipeHeat>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_9;
        int val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Color val_1 = this.<>4__this.pipeHeat.color;
        val_9 = this;
        this.<elapsed>5__4 = 0f;
        mem[1152921520228514380] = val_1.a;
        mem[1152921520228514384] = (this.isEnabled == false) ? 0f : 1f;
        mem[1152921520228514392] = Royal.Infrastructure.Utils.Animation.ManualEasing.GetEase(easeType:  (this.isEnabled == false) ? 12 : 18);
        goto label_5;
        label_1:
        val_9 = this.<elapsed>5__4;
        this.<>1__state = 0;
        label_5:
        float val_9 = val_9;
        if(val_9 < 0)
        {
            goto label_6;
        }
        
        label_2:
        val_10 = 0;
        return (bool)val_10;
        label_6:
        float val_5 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_9 = val_9 + val_5;
        this.<elapsed>5__4 = val_9;
        val_5 = val_9 + val_9;
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.<>4__this.pipeHeat, alpha:  UnityEngine.Mathf.Lerp(a:  this.<startAlpha>5__2, b:  this.<endAlpha>5__3, t:  this.<easing>5__5.Invoke(t:  UnityEngine.Mathf.Clamp01(value:  val_5))));
        val_10 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_10;
        return (bool)val_10;
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
