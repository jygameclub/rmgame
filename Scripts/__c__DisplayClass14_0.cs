using UnityEngine;
private sealed class KingsCupGiftRewardView.<>c__DisplayClass14_0
{
    // Fields
    public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupGiftClaim.KingsCupGiftRewardView <>4__this;
    public UnityEngine.Vector3 secondPos;
    public UnityEngine.Vector3 firstPos;
    
    // Methods
    public KingsCupGiftRewardView.<>c__DisplayClass14_0()
    {
    
    }
    internal void <Hover>b__0()
    {
        this.<>4__this = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.<>4__this.hoverSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>4__this.transform, endValue:  new UnityEngine.Vector3() {x = this.secondPos}, duration:  2f, snapping:  false), ease:  4));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.<>4__this.hoverSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>4__this.transform, endValue:  new UnityEngine.Vector3() {x = this.firstPos}, duration:  2f, snapping:  false), ease:  4));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  this.<>4__this.hoverSequence, loops:  0);
    }

}
