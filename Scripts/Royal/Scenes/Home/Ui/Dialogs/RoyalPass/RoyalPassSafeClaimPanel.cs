using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassSafeClaimPanel : UiPanel
    {
        // Fields
        public UnityEngine.Transform reward;
        public UnityEngine.ParticleSystem rewardLightParticle;
        public UnityEngine.ParticleSystem rewardExplosionParticles;
        public UnityEngine.ParticleSystem rewardStableParticles;
        public UnityEngine.ParticleSystem rewardParticles;
        public UnityEngine.ParticleSystem startParticles;
        public UnityEngine.ParticleSystem safeParticles;
        public TMPro.TextMeshPro tapText;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public TMPro.TextMeshPro[] rewardTexts;
        public UnityEngine.AnimationCurve claimCollectEasing;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Vector3 targetRewardPosition;
        public UnityEngine.Vector3 targetRewardScale;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private UnityEngine.Coroutine jumpSfx;
        private long jumpSfxId;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool anyUnclaimed;
        private long coinCounterSoundKey;
        public TMPro.TextMeshPro amountText;
        public UnityEngine.SpriteRenderer coinRenderer;
        public UnityEngine.Transform coinsParent;
        public UnityEngine.Transform amountAndCoinScalePivot;
        public UnityEngine.ParticleSystem coinParticles;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle royalPassBundle;
        private UnityEngine.GameObject safeBundledGo;
        private UnityEngine.Animator safeAnimator;
        
        // Methods
        public void Show(System.Action onComplete, bool anyUnclaimed)
        {
            var val_24;
            this.onComplete = onComplete;
            this.anyUnclaimed = anyUnclaimed;
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_2 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            if(val_2 == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_3 = val_2.GetBundle(bundleType:  4);
            if(val_3 == null)
            {
                goto label_4;
            }
            
            this.royalPassBundle = val_3;
            if(this.royalPassBundle == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.royalPassBundle.SafeClaimPrefab, parent:  this.reward);
            this.safeBundledGo = val_5;
            if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_6 = val_5.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_6.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            if(this.safeBundledGo == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_8 = this.safeBundledGo.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            if(this.safeBundledGo == null)
            {
                    throw new NullReferenceException();
            }
            
            this.safeAnimator = this.safeBundledGo.GetComponent<UnityEngine.Animator>();
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            if(this.rewardTexts == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_23 = 0;
            label_21:
            if(val_23 >= this.rewardTexts.Length)
            {
                goto label_18;
            }
            
            TMPro.TextMeshPro val_22 = this.rewardTexts[val_23];
            if(val_22 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_22.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPassBonusBankTitle");
            val_23 = val_23 + 1;
            if(this.rewardTexts != null)
            {
                goto label_21;
            }
            
            throw new NullReferenceException();
            label_18:
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1)) == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13.cameraWidth, y:  val_13.cameraHeight);
            if(this.background == null)
            {
                    throw new NullReferenceException();
            }
            
            this.background.size = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            val_24 = null;
            val_24 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == null)
            {
                    throw new NullReferenceException();
            }
            
            if(null == 0)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Transform val_15 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 80.transform;
            if(val_15 == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.Vector3 val_16 = val_15.position;
            this.InitReward(initialPosition:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            DG.Tweening.Sequence val_17 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_17, t:  this.SendRewardToCenter());
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_17, t:  this.ShowBonusBankText());
            this.Invoke(methodName:  "AnimateTextToOpen", time:  1f);
            return;
            label_4:
            ??? = new IndexOutOfRangeException();
            throw new NullReferenceException();
        }
        private void InitReward(UnityEngine.Vector3 initialPosition)
        {
            this.reward.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.tapText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Open");
            this.isTapEnabled = false;
            UnityEngine.Transform val_5 = this.reward.transform;
            UnityEngine.Vector3 val_6 = val_5.position;
            this.targetRewardPosition = val_6;
            mem[1152921519262926356] = val_6.y;
            mem[1152921519262926360] = val_6.z;
            UnityEngine.Vector3 val_7 = val_5.localScale;
            this.targetRewardScale = val_7;
            mem[1152921519262926368] = val_7.y;
            mem[1152921519262926372] = val_7.z;
            val_5.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0f);
            val_5.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.startParticles.transform.position = new UnityEngine.Vector3() {x = initialPosition.x, y = initialPosition.y, z = initialPosition.z};
        }
        private void SquashStretchReward()
        {
            this.safeAnimator.Play(stateName:  "AppearAnimation", layer:  0, normalizedTime:  0f);
            this.jumpSfx = this.StartCoroutine(routine:  this.JumpSfx());
        }
        private System.Collections.IEnumerator JumpSfx()
        {
            .<>4__this = this;
            return (System.Collections.IEnumerator)new RoyalPassSafeClaimPanel.<JumpSfx>d__33(<>1__state:  0);
        }
        public DG.Tweening.Sequence SendRewardToCenter()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.safeAnimator.enabled = true;
            this.audioManager.PlaySound(type:  243, offset:  0.04f);
            UnityEngine.Vector3 val_2 = this.reward.position;
            float val_3 = UnityEngine.Mathf.Lerp(a:  val_2.x, b:  this.targetRewardPosition, t:  0.3f);
            float val_29 = 0.5f;
            val_29 = val_2.y + val_29;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.3f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  0.1f);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.2f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3, y = val_29, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3, y = val_29, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.targetRewardPosition, y = val_6.y, z = V14.16B}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3[] val_17 = new UnityEngine.Vector3[6];
            val_17[1] = val_2.z;
            val_17[0] = val_3;
            val_17[0] = val_29;
            val_17[1] = val_9;
            val_17[2] = val_9.y;
            val_17[2] = val_9.z;
            val_17[3] = val_12;
            val_17[3] = val_12.y;
            val_17[4] = val_12.z;
            val_17[4] = this.targetRewardPosition;
            val_17[5] = val_6.y;
            val_17[5] = new UnityEngine.Vector3();
            val_17[6] = val_14;
            val_17[6] = val_14.y;
            val_17[7] = val_14.z;
            val_17[7] = val_16;
            val_17[8] = val_16.y;
            val_17[8] = val_16.z;
            UnityEngine.Color val_18 = UnityEngine.Color.green;
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.reward, path:  val_17, duration:  0.75f, pathType:  2, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  this.claimCollectEasing));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward, endValue:  new UnityEngine.Vector3() {x = this.targetRewardScale, y = val_18.g, z = val_18.b}, duration:  0.75f), ease:  1));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<SendRewardToCenter>b__34_0()));
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.73f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::SquashStretchReward()));
            return val_1;
        }
        private void ClaimChest()
        {
            this.PlayHideAnimation();
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).ClaimFinalReward();
        }
        private DG.Tweening.Sequence ShowBonusBankText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<ShowBonusBankText>b__36_0()));
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.5f);
            return val_1;
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "TaptoClaim"));
        }
        private void AnimateTextToOpen()
        {
            this.tapState = 0;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Open"));
        }
        private void AnimateText(string text)
        {
            RoyalPassSafeClaimPanel.<>c__DisplayClass39_0 val_1 = new RoyalPassSafeClaimPanel.<>c__DisplayClass39_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassSafeClaimPanel.<>c__DisplayClass39_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassSafeClaimPanel.<>c__DisplayClass39_0::<AnimateText>b__1()));
        }
        private void HideText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<HideText>b__40_0()));
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            if(this.tapState != 1)
            {
                    if(this.tapState != 0)
            {
                    return;
            }
            
                this.isTapEnabled = false;
                this.PlayOpenAnimation();
                return;
            }
            
            this.isTapEnabled = false;
            this.ClaimChest();
        }
        public void PlayOpenAnimation()
        {
            this.StopCoroutine(routine:  this.jumpSfx);
            this.audioManager.StopSound(key:  this.jumpSfxId);
            this.safeAnimator.Play(stateName:  "OpenAnimation", layer:  0, normalizedTime:  0f);
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  25f), callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<PlayOpenAnimation>b__42_0()));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.5f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<PlayOpenAnimation>b__42_1()));
        }
        private void AnimateCoinTextShow()
        {
            RoyalPassSafeClaimPanel.<>c__DisplayClass43_0 val_1 = new RoyalPassSafeClaimPanel.<>c__DisplayClass43_0();
            .<>4__this = this;
            .coinAmount = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).GetSafeEarnedCoins();
            .animatedAmount = 0;
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0f, y:  3.25f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            this.coinsParent.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.coinCounterSoundKey = this.audioManager.PlayStoppableSound(audioClipType:  74, loop:  false, volume:  1f);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.amountAndCoinScalePivot, endValue:  1f, duration:  0.5f), ease:  27));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_4, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  1f, duration:  0.25f));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_4, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.coinRenderer, endValue:  1f, duration:  0.25f));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.OnKill<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<System.Int32, System.Int32, DG.Tweening.Plugins.Options.NoOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Int32>(object:  val_1, method:  System.Int32 RoyalPassSafeClaimPanel.<>c__DisplayClass43_0::<AnimateCoinTextShow>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Int32>(object:  val_1, method:  System.Void RoyalPassSafeClaimPanel.<>c__DisplayClass43_0::<AnimateCoinTextShow>b__1(int x)), endValue:  (RoyalPassSafeClaimPanel.<>c__DisplayClass43_0)[1152921519264965056].coinAmount, duration:  0.8f), delay:  0f)), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void RoyalPassSafeClaimPanel.<>c__DisplayClass43_0::<AnimateCoinTextShow>b__2()));
        }
        private DG.Tweening.Sequence AnimateCoinTextHide()
        {
            if(this.coinParticles != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.coinParticles.gameObject);
            }
            
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.amountAndCoinScalePivot, endValue:  0f, duration:  0.5f), ease:  26, overshoot:  0f));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  0f, duration:  0.25f));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.coinRenderer, endValue:  0f, duration:  0.25f));
            return val_3;
        }
        private void PlayHideAnimation()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.tapText, endValue:  0f, duration:  0.25f), ease:  26));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  0f, duration:  0.25f), ease:  26));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.AnimateCoinTextHide());
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.15f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0.15f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward, endValue:  0f, duration:  0.15f), ease:  26));
            float val_16 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f);
            val_16 = val_16 + 0.15f;
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  val_16, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<PlayHideAnimation>b__45_0()));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_1, atPosition:  0.1f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<PlayHideAnimation>b__45_1()));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.05f);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<PlayHideAnimation>b__45_2()));
            var val_24 = (this.anyUnclaimed == false) ? 1 : 0;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  36595916 + this.anyUnclaimed == false ? 1 : 0);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassSafeClaimPanel::<PlayHideAnimation>b__45_3()));
        }
        public RoyalPassSafeClaimPanel()
        {
        
        }
        private void <SendRewardToCenter>b__34_0()
        {
            this.startParticles.Play();
            this.rewardParticles.Play();
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0.9f, duration:  0.4f), delay:  0.2f);
        }
        private void <ShowBonusBankText>b__36_0()
        {
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  1);
            this.curvedTextAnimator.StartAnimation(isReversed:  Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic);
        }
        private void <HideText>b__40_0()
        {
            this.tapText.text = "";
        }
        private void <PlayOpenAnimation>b__42_0()
        {
            this.safeParticles.gameObject.SetActive(value:  true);
        }
        private void <PlayOpenAnimation>b__42_1()
        {
            this.AnimateTextToContinue();
            this.AnimateCoinTextShow();
            this.audioManager.PlaySound(type:  245, offset:  0.04f);
            this.rewardExplosionParticles.Play();
            this.rewardStableParticles.Play();
        }
        private void <PlayHideAnimation>b__45_0()
        {
            if(this.rewardLightParticle != null)
            {
                    this.rewardLightParticle.Stop(withChildren:  true, stopBehavior:  0);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <PlayHideAnimation>b__45_1()
        {
            UnityEngine.Object.Destroy(obj:  this.rewardStableParticles.gameObject);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.rewardParticles.transform, endValue:  0f, duration:  0.2f);
        }
        private void <PlayHideAnimation>b__45_2()
        {
            UnityEngine.Vector3 val_4 = this.reward.transform.position;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        private void <PlayHideAnimation>b__45_3()
        {
            UnityEngine.Object.Destroy(obj:  this.safeBundledGo);
            this.royalPassBundle = 0;
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
    
    }

}
