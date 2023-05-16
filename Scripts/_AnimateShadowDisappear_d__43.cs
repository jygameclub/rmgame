using UnityEngine;
private sealed class MetalCrusherItemView.<AnimateShadowDisappear>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.MetalCrusherItem.View.MetalCrusherItemView <>4__this;
    private float <startAlpha>5__2;
    private float <elapsed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MetalCrusherItemView.<AnimateShadowDisappear>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        float val_6;
        float val_7;
        int val_8;
        float val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.Color val_1 = this.<>4__this.furnaceExtraShadow.color;
        val_5 = this;
        this.<elapsed>5__3 = 0f;
        val_6 = 0f;
        mem[1152921520229244744] = val_1.a;
        goto label_6;
        label_1:
        val_5 = this;
        val_7 = this.<elapsed>5__3;
        this.<>1__state = 0;
        if(val_7 < 0)
        {
            goto label_6;
        }
        
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_6:
        float val_2 = Royal.Scenes.Game.Levels.LevelContext.DeltaTime;
        val_2 = val_6 + val_2;
        this.<elapsed>5__3 = val_2;
        val_9 = this.<startAlpha>5__2;
        Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.<>4__this.furnaceExtraShadow, alpha:  UnityEngine.Mathf.Lerp(a:  val_9, b:  0f, t:  val_2 * 4f));
        val_8 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_8;
        return (bool)val_8;
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
