using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.TeamBattle
{
    public class TeamBattleContributionClaimPanel : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro tapText;
        public UnityEngine.SpriteRenderer background;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTextAnimator;
        public UnityEngine.Transform center;
        public UnityEngine.SpriteRenderer image;
        public UnityEngine.SpriteRenderer shadow;
        public UnityEngine.Transform reward;
        public UnityEngine.ParticleSystem appearParticles;
        public TMPro.TextMeshPro amountText;
        private Royal.Scenes.Home.Ui.Dialogs.EpisodeChest.TapState tapState;
        private bool isTapEnabled;
        private System.Action onComplete;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType;
        
        // Methods
        public void Show(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType, int amount, System.Action onComplete)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.ChangeSection(type:  0);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            this.curvedTextAnimator.Init(frameDelayBetweenChars:  1);
            this.curvedTextAnimator.StartAnimation(isReversed:  false);
            this.onComplete = onComplete;
            this.boosterType = boosterType;
            this.amountText.text = amount.ToString();
            this.Invoke(methodName:  "AnimateTextToContinue", time:  1f);
            this.ShowReward();
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            if(this.tapState != 1)
            {
                    return;
            }
            
            this.ContinueClicked();
        }
        private void ContinueClicked()
        {
            this.isTapEnabled = false;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetRewardedItemSorting(count:  0);
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  99);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.curvedTextAnimator.EnableUpdateForCurvedTexts();
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.15f), ease:  1));
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f));
            var val_27 = 0;
            label_15:
            if(val_27 >= this.curvedTextAnimator.texts.Length)
            {
                goto label_12;
            }
            
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.curvedTextAnimator.texts[val_27].GetComponent<TMPro.TextMeshPro>(), endValue:  0f, duration:  0.15f));
            val_27 = val_27 + 1;
            if(this.curvedTextAnimator != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_12:
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  0f, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTextAnimator.transform, endValue:  1.1f, duration:  0.15f));
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_5, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleContributionClaimPanel::<ContinueClicked>b__18_0()));
        }
        private void AnimateTextToContinue()
        {
            this.tapState = 1;
            this.AnimateText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Tap to Continue"));
        }
        private void AnimateText(string text)
        {
            TeamBattleContributionClaimPanel.<>c__DisplayClass20_0 val_1 = new TeamBattleContributionClaimPanel.<>c__DisplayClass20_0();
            .<>4__this = this;
            .text = text;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.isTapEnabled = false;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TeamBattleContributionClaimPanel.<>c__DisplayClass20_0::<AnimateText>b__0()));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.2f), ease:  27));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void TeamBattleContributionClaimPanel.<>c__DisplayClass20_0::<AnimateText>b__1()));
        }
        public void ShowReward()
        {
            this.image.sprite = this.GetSpriteForBooster(boosterType:  this.boosterType);
            this.shadow.sprite = this.image.GetShadowForBooster(boosterType:  this.boosterType);
            this.shadow.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_5 = this.reward.transform.localScale;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  1.2f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.9f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  1.05f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.reward.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
            Royal.Infrastructure.Utils.Text.CurvedSingleText val_37 = this.curvedTextAnimator.texts[0];
            float val_13 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  (float)(this.curvedTextAnimator.texts[0].<CharCount>k__BackingField) - 1);
            val_13 = val_13 * 2.3f;
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_11, interval:  val_13);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_11, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleContributionClaimPanel::<ShowReward>b__21_0()));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  6f)), ease:  3));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_11, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.reward.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
        }
        private UnityEngine.Sprite GetSpriteForBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_3;
            if((boosterType - 1) <= 6)
            {
                    UnityEngine.Sprite val_2 = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  45230320 + ((boosterType - 1)) << 3);
                return (UnityEngine.Sprite)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.Sprite)val_3;
        }
        private UnityEngine.Sprite GetShadowForBooster(Royal.Scenes.Game.Mechanics.Boosters.BoosterType boosterType)
        {
            var val_3;
            if((boosterType - 1) <= 6)
            {
                    UnityEngine.Sprite val_2 = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  45230384 + ((boosterType - 1)) << 3);
                return (UnityEngine.Sprite)val_3;
            }
            
            val_3 = 0;
            return (UnityEngine.Sprite)val_3;
        }
        public TeamBattleContributionClaimPanel()
        {
        
        }
        private void <ContinueClicked>b__18_0()
        {
            if(this.onComplete != null)
            {
                    this.onComplete.Invoke();
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void <ShowReward>b__21_0()
        {
            this.audioManager.PlaySound(type:  22, offset:  0.04f);
            this.appearParticles.Play();
        }
    
    }

}
