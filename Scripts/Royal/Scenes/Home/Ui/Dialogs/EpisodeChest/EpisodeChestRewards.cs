using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.EpisodeChest
{
    public class EpisodeChestRewards : MonoBehaviour
    {
        // Fields
        private static readonly int RewardAnimation;
        private static readonly int Area1RewardAnimation;
        public UnityEngine.Transform hammer;
        public UnityEngine.Transform rocket;
        public UnityEngine.Transform tnt;
        public UnityEngine.Transform lightball;
        public UnityEngine.Transform arrow;
        public UnityEngine.Transform cannon;
        public UnityEngine.Transform jester;
        public UnityEngine.Transform coin;
        public UnityEngine.GameObject hitParticlesPrefab;
        public UnityEngine.Animator rewardsAnimator;
        public TMPro.TextMeshPro coinText;
        public UnityEngine.ParticleSystem coinParticles;
        private int coinAmount;
        private UnityEngine.Transform levelButtonFrame;
        private DG.Tweening.Sequence textSeq;
        private DG.Tweening.Tween textTween;
        private bool isArea1;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private long coinCounterSoundKey;
        
        // Methods
        private void Awake()
        {
            var val_5;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            val_5 = null;
            val_5 = null;
            this.levelButtonFrame = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 136.transform.parent;
            this.rewardsAnimator.gameObject.SetActive(value:  false);
            this.coinText.enabled = false;
            this.coinText.text = "";
        }
        public void PlayAnimation(bool isArea1, int coinAmount)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            this.coinAmount = coinAmount;
            this.isArea1 = isArea1;
            val_2 = null;
            if(isArea1 == false)
            {
                goto label_1;
            }
            
            val_3 = null;
            val_4 = 1152921505053442052;
            if(this.rewardsAnimator != null)
            {
                goto label_4;
            }
            
            label_1:
            val_5 = null;
            label_4:
            this.rewardsAnimator.Play(stateNameHash:  Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards.__il2cppRuntimeField_static_fields);
        }
        public void PlayCoinTextAnimation()
        {
            EpisodeChestRewards.<>c__DisplayClass23_0 val_1 = new EpisodeChestRewards.<>c__DisplayClass23_0();
            .<>4__this = this;
            this.coinText.enabled = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.7f);
            .startScale = val_3;
            mem[1152921519500540976] = val_3.y;
            mem[1152921519500540980] = val_3.z;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  1.2f);
            .firstTargetScale = val_5;
            mem[1152921519500540988] = val_5.y;
            mem[1152921519500540992] = val_5.z;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.9f);
            .finalScale = val_7;
            mem[1152921519500540964] = val_7.y;
            mem[1152921519500540968] = val_7.z;
            this.coinText.transform.localScale = new UnityEngine.Vector3() {x = (EpisodeChestRewards.<>c__DisplayClass23_0)[1152921519500540928].startScale, y = val_7.y, z = val_7.z};
            .balance = 0;
            .to = 100;
            this.coinCounterSoundKey = this.audioManager.PlayStoppableSound(audioClipType:  74, loop:  false, volume:  1f);
            this.textTween = DG.Tweening.TweenSettingsExtensions.OnKill<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 EpisodeChestRewards.<>c__DisplayClass23_0::<PlayCoinTextAnimation>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void EpisodeChestRewards.<>c__DisplayClass23_0::<PlayCoinTextAnimation>b__1(int x)), endValue:  this.coinAmount, duration:  0.8f), ease:  6), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void EpisodeChestRewards.<>c__DisplayClass23_0::<PlayCoinTextAnimation>b__2()));
        }
        public void SendRewardsToButton(DG.Tweening.Sequence seq, float insertAt)
        {
            float val_23;
            UnityEngine.Transform val_24;
            DG.Tweening.Sequence val_25;
            float val_26;
            if((this.textTween != null) && ((DG.Tweening.TweenExtensions.IsPlaying(t:  this.textTween)) != false))
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.textTween, complete:  false);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.2f);
                this.coinText.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.9f);
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coinText.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.3f), ease:  28);
                this.coinText.text = this.coinAmount.ToString();
                if(this.coinParticles != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.coinParticles.gameObject);
            }
            
            }
            
            float val_19 = 0f;
            val_19 = insertAt + val_19;
            this.AddAnimation(seq:  seq, reward:  this.hammer, insertAt:  val_19, duration:  0.65f);
            float val_20 = 0.05f;
            val_20 = insertAt + val_20;
            if(this.isArea1 != false)
            {
                    this.AddAnimation(seq:  seq, reward:  this.rocket, insertAt:  val_20, duration:  0.65f);
                val_23 = insertAt + 0.1f;
                this.AddAnimation(seq:  seq, reward:  this.tnt, insertAt:  val_23, duration:  0.65f);
                val_24 = this.lightball;
                val_25 = seq;
                val_26 = insertAt + 0.15f;
            }
            else
            {
                    this.AddAnimation(seq:  seq, reward:  this.rocket, insertAt:  val_20, duration:  0.67f);
                val_23 = insertAt + 0.1f;
                this.AddAnimation(seq:  seq, reward:  this.arrow, insertAt:  val_23, duration:  0.69f);
                val_26 = insertAt + 0.15f;
                this.AddAnimation(seq:  seq, reward:  this.tnt, insertAt:  val_26, duration:  0.71f);
                float val_21 = 0.2f;
                val_21 = insertAt + val_21;
                this.AddAnimation(seq:  seq, reward:  this.lightball, insertAt:  val_21, duration:  0.73f);
                float val_22 = 0.25f;
                val_22 = insertAt + val_22;
                this.AddAnimation(seq:  seq, reward:  this.cannon, insertAt:  val_22, duration:  0.75f);
                float val_23 = 0.3f;
                val_24 = this.jester;
                val_23 = insertAt + val_23;
                val_25 = seq;
            }
            
            this.AddAnimation(seq:  val_25, reward:  val_24, insertAt:  val_23, duration:  0.77f);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_23, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards::<SendRewardsToButton>b__24_0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  seq, atPosition:  val_26, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards::<SendRewardsToButton>b__24_1()));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  seq, interval:  2f);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  seq, updateType:  1);
        }
        private void AddAnimation(DG.Tweening.Sequence seq, UnityEngine.Transform reward, float insertAt, float duration)
        {
            .<>4__this = this;
            .reward = reward;
            UnityEngine.Vector3 val_3 = this.levelButtonFrame.transform.position;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Insert(s:  seq, atPosition:  insertAt, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  reward, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  duration, snapping:  false), ease:  26), action:  new DG.Tweening.TweenCallback(object:  new EpisodeChestRewards.<>c__DisplayClass25_0(), method:  System.Void EpisodeChestRewards.<>c__DisplayClass25_0::<AddAnimation>b__0())));
        }
        private void PlayButtonHitAnimation()
        {
            EpisodeChestRewards.<>c__DisplayClass26_0 val_1 = new EpisodeChestRewards.<>c__DisplayClass26_0();
            .<>4__this = this;
            UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.hitParticlesPrefab);
            .hitParticles = val_2;
            UnityEngine.Vector3 val_5 = this.levelButtonFrame.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(val_6.Length >= 1)
            {
                    var val_35 = 0;
                do
            {
                (EpisodeChestRewards.<>c__DisplayClass26_0)[1152921519501386880].hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>()[val_35].Play();
                val_35 = val_35 + 1;
            }
            while(val_35 < val_6.Length);
            
            }
            
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  1.04f, y:  0.97f);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.05f));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void EpisodeChestRewards.<>c__DisplayClass26_0::<PlayButtonHitAnimation>b__0()));
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  0.98f, y:  1.02f);
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  0.075f));
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  1.01f, y:  0.99f);
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.06f));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.levelButtonFrame, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  0.05f));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_7, interval:  2f);
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_7, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void EpisodeChestRewards.<>c__DisplayClass26_0::<PlayButtonHitAnimation>b__1()));
        }
        public EpisodeChestRewards()
        {
        
        }
        private static EpisodeChestRewards()
        {
            Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards.RewardAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.EpisodeChestRewardAnimation");
            Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards.Area1RewardAnimation = UnityEngine.Animator.StringToHash(name:  "Base Layer.EpisodeChestArea1RewardAnimation");
        }
        private void <SendRewardsToButton>b__24_0()
        {
            UnityEngine.Vector3 val_4 = this.coin.transform.position;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        private void <SendRewardsToButton>b__24_1()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.coin, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.15f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.EpisodeChestRewards::<SendRewardsToButton>b__24_2()));
        }
        private void <SendRewardsToButton>b__24_2()
        {
            UnityEngine.Object.Destroy(obj:  this.coin.gameObject);
        }
    
    }

}
