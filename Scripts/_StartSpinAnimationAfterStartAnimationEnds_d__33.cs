using UnityEngine;
private sealed class DrillItemView.<StartSpinAnimationAfterStartAnimationEnds>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView <>4__this;
    private int <startHeadIndex>5__2;
    private int <loopIndex>5__3;
    private UnityEngine.AnimatorStateInfo <stateInfo>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DrillItemView.<StartSpinAnimationAfterStartAnimationEnds>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AnimatorStateInfo val_4;
        UnityEngine.AnimatorStateInfo val_5;
        UnityEngine.AnimatorStateInfo val_6;
        Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView val_11;
        int val_12;
        UnityEngine.AnimatorStateInfo val_13;
        var val_14;
        var val_15;
        val_11 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        val_11 = 1;
        this.<>4__this.headSprite.enabled = false;
        this.<>4__this.startHead.enabled = true;
        if((this.<>4__this.drillHitRoutine) != null)
        {
                val_11.StopCoroutine(routine:  this.<>4__this.drillHitRoutine);
            val_11 = 0;
        }
        
        int val_2 = val_11.CalculateStartHeadIndex() + 1;
        this.<startHeadIndex>5__2 = val_2;
        this.<>4__this.startHead.sprite = this.<>4__this.itemAssets.startSprites[val_2];
        val_12 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_12;
        return (bool)val_12;
        label_2:
        this.<>1__state = 0;
        this.<loopIndex>5__3 = 0;
        UnityEngine.AnimatorStateInfo val_3 = this.<>4__this.drillAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_13 = this.<stateInfo>5__4;
        mem[1152921520361574640] = val_4;
        this.<stateInfo>5__4 = val_5;
        mem[1152921520361574624] = val_6;
        goto label_15;
        label_1:
        val_13 = this.<stateInfo>5__4;
        this.<>1__state = 0;
        label_15:
        val_14 = null;
        val_14 = null;
        if(val_13 == Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillHitAnimation)
        {
            goto label_18;
        }
        
        val_15 = null;
        val_15 = null;
        if(val_13 != Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillStartAnimation)
        {
            goto label_21;
        }
        
        label_18:
        if(S0 <= 1f)
        {
            goto label_22;
        }
        
        label_21:
        val_11 = 0;
        this.<>4__this.headSprite.enabled = true;
        this.<>4__this.startHead.enabled = false;
        val_11 = this.<>4__this.drillAnimator;
        val_11.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DrillItem.View.DrillItemView.DrillSpinAnimation, layer:  0, normalizedTime:  0f);
        label_3:
        val_12 = 0;
        return (bool)val_12;
        label_22:
        UnityEngine.AnimatorStateInfo val_7 = this.<>4__this.drillAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        val_13 = val_4;
        val_13 = val_5;
        val_13 = val_6;
        int val_11 = this.<>4__this.itemAssets.startSprites.Length;
        int val_12 = this.<startHeadIndex>5__2;
        val_11 = val_11 - 1;
        if(val_12 >= val_11)
        {
            goto label_34;
        }
        
        val_12 = val_12 + 1;
        this.<startHeadIndex>5__2 = val_12;
        label_42:
        this.<>4__this.startHead.sprite = this.<>4__this.itemAssets.startSprites[val_12];
        if((val_5 > 0.95f) && ((this.<>4__this.playingStartAnimation) != false))
        {
                val_11 = 0;
        }
        
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_12 = 1;
        return (bool)val_12;
        label_34:
        int val_14 = this.<loopIndex>5__3;
        this.<loopIndex>5__3 = val_14 + 1;
        val_14 = val_14 - ((val_14 / (this.<>4__this.itemAssets.startLoop.Length)) * (this.<>4__this.itemAssets.startLoop.Length));
        if(val_14 < (this.<>4__this.itemAssets.startLoop.Length))
        {
            goto label_42;
        }
        
        throw new IndexOutOfRangeException();
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
