using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect
{
    public class PiggyBankCollectAnimation : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem hitParticles;
        public TMPro.TextMeshPro amountText;
        public UnityEngine.Transform coinBlock;
        public UnityEngine.AnimationCurve throwCurve;
        private Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankIcon piggyBankIcon;
        private Royal.Player.Context.Data.Session.BeforeAfterData piggyData;
        private int currentCoin;
        private int increment;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private UnityEngine.Vector3 originalCoinScale;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Play()
        {
            null = null;
            this.piggyBankIcon = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 64;
            UnityEngine.Vector3 val_3 = this.piggyBankIcon.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.piggyData = null;
            this.currentCoin = Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20;
            this.amountText.text = "<b>+</b>"("<b>+</b>") + (Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 24 - Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20)((Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 24 - Royal.Player.Context.Data.Session.__il2cppRuntimeField_68 + 20));
            UnityEngine.Vector3 val_5 = this.coinBlock.localScale;
            this.originalCoinScale = val_5;
            mem[1152921519120841948] = val_5.y;
            mem[1152921519120841952] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.coinBlock.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.PlayCollectAnimation();
        }
        private void PlayCollectAnimation()
        {
            this.amountText.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.amountText.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coinBlock, endValue:  new UnityEngine.Vector3() {x = this.originalCoinScale, y = val_2.y, z = val_2.z}, duration:  0.3f), ease:  27));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_3, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect.PiggyBankCollectAnimation::PlayAmountAnimation()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_3, interval:  0.25f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  this.AnimateToIcon());
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect.PiggyBankCollectAnimation::OnReach()));
        }
        private DG.Tweening.Sequence AnimateToIcon()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.PiggyBankCollect.PiggyBankCollectAnimation::PlayCoinSound()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coinBlock, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coinBlock, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)));
            float val_10 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  val_10, t:  DG.Tweening.ShortcutExtensions.DOLocalMoveX(target:  this.coinBlock, endValue:  0f, duration:  0.32f, snapping:  false));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.coinBlock, endValue:  0.75f, duration:  0.32f, snapping:  false), animCurve:  this.throwCurve));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  12f), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coinBlock, endValue:  new UnityEngine.Vector3() {x = this.originalCoinScale, y = val_10, z = 0.32f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)));
            return val_1;
        }
        private void PlayAmountAnimation()
        {
            UnityEngine.Vector3 val_2 = this.amountText.transform.localPosition;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  1f, duration:  0.3f));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.amountText, endValue:  1f, duration:  0.4f), ease:  27));
            float val_15 = 2f;
            val_15 = val_2.y + val_15;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0.5f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.amountText.transform, endValue:  val_15, duration:  1.3f, snapping:  false), ease:  5));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_3, atPosition:  0.6f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  0f, duration:  0.4f));
        }
        private void PlayCoinSound()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  73, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnReach()
        {
            this.hitParticles.Play();
            this.coinBlock.gameObject.SetActive(value:  false);
            this.currentCoin = this.piggyData.after;
            this.piggyData.Consume();
            this.hitParticles.Play();
            this.piggyBankIcon.PlayHitAnimation(amount:  this.currentCoin);
            this.Invoke(methodName:  "Clear", time:  1f);
        }
        private void Clear()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public PiggyBankCollectAnimation()
        {
        
        }
    
    }

}
