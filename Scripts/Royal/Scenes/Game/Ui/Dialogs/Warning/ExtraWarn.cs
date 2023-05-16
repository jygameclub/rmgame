using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.Warning
{
    public class ExtraWarn : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform butler;
        public UnityEngine.Transform speechBubble;
        public UnityEngine.Transform madnessWarnSpeechBubble;
        public UnityEngine.Transform royalPassWarnSpeechBubble;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.ClocheWarn clocheWarn;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.MadnessWarn madnessWarn;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.ClocheAndMadnessWarn clocheAndMadnessWarn;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.MadnessClaimWarn madnessClaimWarn;
        public Royal.Scenes.Game.Ui.Dialogs.Warning.RoyalPassClaimWarn royalPassClaimWarn;
        public float madnessClaimTotalLeftBarSize;
        public float royalPassClaimTotalLeftBarSize;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private UnityEngine.Vector3 speechBubbleInitialScale;
        private UnityEngine.Vector3 madnessWarnSpeechBubbleInitialScale;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Warn(int clocheCount, int madnessCount, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType)
        {
            this.gameObject.SetActive(value:  true);
            if((clocheCount >= 1) && (madnessCount >= 1))
            {
                    this.clocheAndMadnessWarn.Show(clocheCount:  clocheCount, madnessCount:  madnessCount, madnessEventType:  eventType);
            }
            else
            {
                    if(clocheCount >= 1)
            {
                    this.clocheWarn.Show(clocheCount:  clocheCount);
            }
            else
            {
                    if(madnessCount >= 1)
            {
                    this.madnessWarn.Show(madnessCount:  madnessCount, madnessEventType:  eventType);
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_2 = this.butler.localScale;
            UnityEngine.Vector3 val_3 = this.speechBubble.localScale;
            this.speechBubbleInitialScale = val_3;
            mem[1152921519906948292] = val_3.y;
            mem[1152921519906948296] = val_3.z;
            UnityEngine.Vector3 val_4 = this.madnessWarnSpeechBubble.localScale;
            this.madnessWarnSpeechBubbleInitialScale = val_4;
            mem[1152921519906948304] = val_4.y;
            mem[1152921519906948308] = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.butler.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.speechBubble.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.madnessWarnSpeechBubble.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.madnessWarnSpeechBubble.gameObject.SetActive(value:  false);
            this.royalPassWarnSpeechBubble.gameObject.SetActive(value:  false);
            this.speechBubble.gameObject.SetActive(value:  true);
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.Warning.ExtraWarn::<Warn>b__15_0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.butler, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.Warning.ExtraWarn::<Warn>b__15_1()));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.speechBubble, endValue:  new UnityEngine.Vector3() {x = this.speechBubbleInitialScale, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
        }
        public void WarnMadnessClaim(Royal.Player.Context.Units.MadnessStep madnessStep, Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType)
        {
            .<>4__this = this;
            .madnessStep = madnessStep;
            .eventType = eventType;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.speechBubble, endValue:  0f, duration:  0.2f), ease:  26));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new ExtraWarn.<>c__DisplayClass16_0(), method:  System.Void ExtraWarn.<>c__DisplayClass16_0::<WarnMadnessClaim>b__0()));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.madnessWarnSpeechBubble, endValue:  new UnityEngine.Vector3() {x = this.madnessWarnSpeechBubbleInitialScale, y = 0.2f}, duration:  0.2f), ease:  27));
        }
        public void WarnRoyalPassClaim(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep royalPassStep, bool hasRoyalPass, bool didWarnForExtra)
        {
            IntPtr val_26;
            ExtraWarn.<>c__DisplayClass17_0 val_1 = new ExtraWarn.<>c__DisplayClass17_0();
            .<>4__this = this;
            .royalPassStep = royalPassStep;
            .hasRoyalPass = hasRoyalPass;
            UnityEngine.Vector3 val_3 = this.royalPassWarnSpeechBubble.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.royalPassWarnSpeechBubble.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            if(didWarnForExtra != false)
            {
                    DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.speechBubble, endValue:  0f, duration:  0.2f), ease:  26));
                val_26 = 1152921519907427728;
            }
            else
            {
                    this.gameObject.SetActive(value:  true);
                this.ActivateRoyalPassClaimWarn(royalPassStep:  (ExtraWarn.<>c__DisplayClass17_0)[1152921519907556432].royalPassStep, hasRoyalPass:  (ExtraWarn.<>c__DisplayClass17_0)[1152921519907556432].hasRoyalPass);
                UnityEngine.Vector3 val_10 = this.butler.localScale;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
                this.butler.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ExtraWarn.<>c__DisplayClass17_0::<WarnRoyalPassClaim>b__1()));
                DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.butler, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.2f), ease:  27));
                DG.Tweening.TweenCallback val_17 = null;
                val_26 = 1152921519907474832;
            }
            
            val_17 = new DG.Tweening.TweenCallback(object:  val_1, method:  val_26);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_5, callback:  val_17);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.royalPassWarnSpeechBubble, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.2f), ease:  27));
        }
        private void ActivateRoyalPassClaimWarn(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassStep royalPassStep, bool hasRoyalPass)
        {
            this.clocheAndMadnessWarn.gameObject.SetActive(value:  false);
            this.clocheWarn.gameObject.SetActive(value:  false);
            this.madnessWarn.gameObject.SetActive(value:  false);
            this.speechBubble.gameObject.SetActive(value:  false);
            this.madnessWarnSpeechBubble.gameObject.SetActive(value:  false);
            this.royalPassWarnSpeechBubble.gameObject.SetActive(value:  true);
            this.royalPassClaimWarn.Show(royalPassStep:  royalPassStep, hasRoyalPass:  hasRoyalPass, totalLeftBarSize:  this.royalPassClaimTotalLeftBarSize);
        }
        public ExtraWarn()
        {
        
        }
        private void <Warn>b__15_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  69, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <Warn>b__15_1()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  70, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
