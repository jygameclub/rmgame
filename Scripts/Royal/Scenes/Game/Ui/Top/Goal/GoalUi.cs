using UnityEngine;

namespace Royal.Scenes.Game.Ui.Top.Goal
{
    public class GoalUi : MonoBehaviour
    {
        // Fields
        public UnityEngine.SpriteRenderer goalImage;
        public UnityEngine.SpriteRenderer shadowImage;
        public UnityEngine.SpriteRenderer checkImage;
        public TMPro.TextMeshPro countText;
        public UnityEngine.ParticleSystem goalCheckParticles;
        public UnityEngine.ParticleSystem goalHitCircle;
        public UnityEngine.ParticleSystem goalHitParticles;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private bool checkImageAnimationWorking;
        private UnityEngine.Vector3 originalImageScale;
        private Royal.Scenes.Game.Mechanics.Goal.GoalType goalType;
        private bool shouldPlayParticle;
        private DG.Tweening.Sequence goalShakeSequence;
        
        // Methods
        protected virtual void Awake()
        {
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Init(Royal.Scenes.Game.Mechanics.Goal.GoalTuple goalTuple, Royal.Scenes.Game.Mechanics.Goal.GoalAsset goalAsset)
        {
            this.goalType = goalTuple.<GoalType>k__BackingField;
            this.countText.text = goalTuple.<LeftCount>k__BackingField.ToString();
            this.goalImage.sprite = goalAsset.iconSprite;
            this.shadowImage.sprite = goalAsset.shadowSprite;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = goalAsset.shadowPosition, y = V8.16B});
            this.shadowImage.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.shadowImage.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = goalAsset.shadowScale, y = 0f});
            this.shadowImage.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  goalAsset.iconScale);
            this.goalImage.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = goalAsset.iconOffset, y = val_8.y});
            this.goalImage.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_12 = this.goalImage.transform.localScale;
            this.originalImageScale = val_12;
            mem[1152921519893792648] = val_12.y;
            mem[1152921519893792652] = val_12.z;
            this.countText.gameObject.SetActive(value:  true);
            this.checkImage.gameObject.SetActive(value:  false);
            this.shouldPlayParticle = Royal.Scenes.Game.Mechanics.Items.Config.ItemExtensions.ShouldPlayParticleOnCollect(goalType:  this.goalType);
        }
        public void Reset()
        {
            this.countText.gameObject.SetActive(value:  true);
            this.checkImage.gameObject.SetActive(value:  false);
        }
        public void OnGoalUpdated(Royal.Scenes.Game.Mechanics.Goal.GoalType type, int count, bool hasPrerequisite, bool isUpdatedForStartValue, bool isGoalCompleted)
        {
            TMPro.TextMeshPro val_20;
            UnityEngine.Transform val_21;
            TMPro.TextMeshPro val_22;
            string val_24;
            val_20 = isUpdatedForStartValue;
            val_21 = hasPrerequisite;
            val_22 = this;
            if(this.goalType != type)
            {
                    return;
            }
            
            if(val_20 != false)
            {
                    this.countText.enabled = true;
                val_22 = this.countText;
                val_22.text = count.ToString();
                return;
            }
            
            val_20 = this.countText;
            if(count == 0)
            {
                goto label_6;
            }
            
            val_24 = count.ToString();
            goto label_8;
            label_6:
            if((isGoalCompleted == false) || (val_21 == true))
            {
                goto label_11;
            }
            
            val_20.enabled = false;
            goto label_12;
            label_11:
            val_24 = "0";
            label_8:
            val_20.text = val_24;
            label_12:
            bool val_3 = this.goalManager.HaveAnyFlyingMatchItemsToCollect(goalType:  type);
            if(this.shouldPlayParticle != false)
            {
                    if(this.goalHitCircle.isPlaying != true)
            {
                    this.goalHitCircle.Play();
            }
            
                if(val_3 != false)
            {
                    if(this.goalShakeSequence != null)
            {
                    if((DG.Tweening.TweenExtensions.IsActive(t:  this.goalShakeSequence)) == true)
            {
                    return;
            }
            
            }
            
                DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
                this.goalShakeSequence = val_6;
                UnityEngine.Vector3 val_20 = this.originalImageScale;
                val_21 = this.goalImage.transform;
                val_20 = val_20 * 1.1f;
                float val_8 = S1 * 0.9f;
                DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_6, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_21, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.08f));
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.goalShakeSequence, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.goalImage.transform, endValue:  new UnityEngine.Vector3() {x = this.originalImageScale, y = 0f, z = 0f}, duration:  0.11f));
                DG.Tweening.Sequence val_14 = DG.Tweening.TweenExtensions.Play<DG.Tweening.Sequence>(t:  this.goalShakeSequence);
                return;
            }
            
                float val_22 = 0.8f;
                UnityEngine.Vector3 val_21 = this.originalImageScale;
                val_21 = val_21 * val_22;
                val_22 = S2 * val_22;
                val_20 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.goalImage.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f);
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_18 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_20, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Top.Goal.GoalUi::<OnGoalUpdated>b__17_0()));
                this.goalHitParticles.Play();
            }
            
            if(val_21 == true)
            {
                    return;
            }
            
            if(isGoalCompleted == false)
            {
                    return;
            }
            
            if(val_3 ^ 1 == false)
            {
                    return;
            }
            
            this.ShowCheckImage();
        }
        private void ShowCheckImage()
        {
            GoalUi.<>c__DisplayClass18_0 val_1 = new GoalUi.<>c__DisplayClass18_0();
            .<>4__this = this;
            if(this.checkImage.gameObject.activeInHierarchy == true)
            {
                    return;
            }
            
            if(this.checkImageAnimationWorking != false)
            {
                    return;
            }
            
            this.countText.gameObject.SetActive(value:  false);
            this.checkImageAnimationWorking = true;
            UnityEngine.Vector3 val_6 = this.checkImage.transform.localScale;
            .originalScale = val_6;
            mem[1152921519894667452] = val_6.y;
            mem[1152921519894667456] = val_6.z;
            DG.Tweening.Sequence val_7 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_7, delay:  0.2f);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void GoalUi.<>c__DisplayClass18_0::<ShowCheckImage>b__0()));
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (GoalUi.<>c__DisplayClass18_0)[1152921519894667424].originalScale, y = V9.16B, z = V8.16B}, d:  1f);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.checkImage.transform, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  0.15f));
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (GoalUi.<>c__DisplayClass18_0)[1152921519894667424].originalScale, y = val_12.y, z = val_12.z}, d:  0.77f);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.checkImage.transform, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  0.0155f));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  this.goalCheckParticles, method:  public System.Void UnityEngine.ParticleSystem::Play()));
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (GoalUi.<>c__DisplayClass18_0)[1152921519894667424].originalScale, y = val_16.y, z = val_16.z}, d:  1.1f);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.checkImage.transform, endValue:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, duration:  0.1f));
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (GoalUi.<>c__DisplayClass18_0)[1152921519894667424].originalScale, y = val_22.y, z = val_22.z}, d:  1f);
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_7, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.checkImage.transform, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.17f));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_7, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void GoalUi.<>c__DisplayClass18_0::<ShowCheckImage>b__1()));
        }
        public void SetCountPosition(UnityEngine.Vector2 position)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = position.x, y = position.y});
            this.countText.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public GoalUi()
        {
        
        }
        private void <OnGoalUpdated>b__17_0()
        {
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.goalImage.transform, endValue:  new UnityEngine.Vector3() {x = this.originalImageScale}, duration:  0.1f);
        }
    
    }

}
