using UnityEngine;
private sealed class RoyalPassRewardRevealDialog.<PlayAnimations>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassRewardRevealDialog <>4__this;
    public DG.Tweening.Sequence lifeAppearSeq;
    public DG.Tweening.Sequence robertAppearSeq;
    public DG.Tweening.Sequence robertMoveSeq;
    public DG.Tweening.Sequence giftMoveSeq;
    public DG.Tweening.Sequence giftAppearSeq;
    private int <animState>5__2;
    private int <oldTapCount>5__3;
    private float <elapsed>5__4;
    private float <waitDelay>5__5;
    private float <robertAppearTime>5__6;
    private float <giftAppearTime>5__7;
    private float <lifeAppearTime>5__8;
    private float <dur>5__9;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RoyalPassRewardRevealDialog.<PlayAnimations>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_10;
        float val_11;
        float val_12;
        int val_13;
        float val_14;
        float val_15;
        DG.Tweening.Sequence val_16;
        int val_17;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<animState>5__2 = 0;
        val_10 = this;
        this.<elapsed>5__4 = ;
        this.<waitDelay>5__5 = ;
        this.<robertAppearTime>5__6 = 0f;
        this.<giftAppearTime>5__7 = 1.8f;
        mem[1152921519250175380] = this.<>4__this.tapCounter;
        mem[1152921519250175400] = 1080452710;
        float val_1 = DG.Tweening.TweenExtensions.Duration(t:  this.lifeAppearSeq, includeLoops:  true);
        val_11 = 1152921519250175404;
        val_1 = val_1 + 3.6f;
        mem[1152921519250175404] = val_1;
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Sequence>(t:  this.robertAppearSeq);
        goto label_4;
        label_1:
        val_10 = this.<elapsed>5__4;
        val_11 = this.<dur>5__9;
        this.<>1__state = 0;
        label_4:
        val_12 = mem[this.<elapsed>5__4];
        val_12 = val_10;
        if(val_12 < 0)
        {
            goto label_5;
        }
        
        this.<>4__this.AnimateTextToClaim();
        label_2:
        val_13 = 0;
        return (bool)val_13;
        label_5:
        val_14 = val_12 + UnityEngine.Time.deltaTime;
        this.<elapsed>5__4 = val_14;
        if((this.<oldTapCount>5__3) == (this.<>4__this.tapCounter))
        {
            goto label_11;
        }
        
        this.<oldTapCount>5__3 = this.<>4__this.tapCounter;
        if((this.<animState>5__2) == 3)
        {
            goto label_10;
        }
        
        if((this.<animState>5__2) != 1)
        {
            goto label_11;
        }
        
        this.robertMoveSeq = 1077936128;
        val_15 = this.<giftAppearTime>5__7;
        goto label_13;
        label_10:
        this.giftMoveSeq = 1077936128;
        val_15 = this.<lifeAppearTime>5__8;
        label_13:
        val_14 = val_15;
        val_10 = val_15;
        label_11:
        float val_10 = this.<robertAppearTime>5__6;
        if(val_14 >= val_10)
        {
                if((this.<animState>5__2) == 0)
        {
            goto label_16;
        }
        
        }
        
        float val_11 = this.<waitDelay>5__5;
        val_10 = val_10 + val_11;
        if((val_14 < val_10) || ((this.<animState>5__2) != 1))
        {
            goto label_18;
        }
        
        val_16 = this.robertMoveSeq;
        val_17 = 2;
        goto label_25;
        label_18:
        if((val_14 < (this.<giftAppearTime>5__7)) || ((this.<animState>5__2) != 2))
        {
            goto label_21;
        }
        
        val_16 = this.giftAppearSeq;
        val_17 = 3;
        goto label_25;
        label_21:
        val_11 = val_11 + (this.<giftAppearTime>5__7);
        if((val_14 < val_11) || ((this.<animState>5__2) != 3))
        {
            goto label_24;
        }
        
        val_16 = this.giftMoveSeq;
        val_17 = 4;
        goto label_25;
        label_24:
        if((val_14 < (this.<lifeAppearTime>5__8)) || ((this.<animState>5__2) != 4))
        {
            goto label_27;
        }
        
        this.<animState>5__2 = 5;
        if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != false)
        {
                UnityEngine.RectTransform val_4 = this.<>4__this.rewardInfoText.rectTransform;
            UnityEngine.Vector2 val_5 = val_4.sizeDelta;
            val_12 = val_5.x;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  0.7f);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12, y = val_5.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            val_4.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        
        val_16 = this.lifeAppearSeq;
        goto label_33;
        label_16:
        val_16 = this.robertAppearSeq;
        val_17 = 1;
        label_25:
        this.<animState>5__2 = val_17;
        label_33:
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Sequence>(t:  val_16);
        label_27:
        val_13 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_13;
        return (bool)val_13;
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
