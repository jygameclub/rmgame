using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards
{
    public class MadnessRewardView : MonoBehaviour
    {
        // Fields
        public TMPro.TextMeshPro rewardText;
        public string rewardPrefix;
        public float claimRewardScale;
        protected Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        protected virtual void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void SetRewardText(string text)
        {
            var val_4;
            TMPro.TextMeshPro val_5;
            val_4 = this;
            val_5 = this.rewardText;
            val_5.text = this.rewardPrefix + text;
            T[] val_2 = this.GetComponentsInChildren<Royal.Infrastructure.Utils.Text.TextPositioner>();
            if(val_2 == null)
            {
                    return;
            }
            
            val_4 = val_2;
            if(val_2.Length < 1)
            {
                    return;
            }
            
            do
            {
                1152921506482711552.ArrangeTransformByCharCount(charCount:  (Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false) ? 2 : text.m_stringLength);
                val_5 = 0 + 1;
            }
            while(val_5 < val_2.Length);
        
        }
        public void IncreaseSorting(int multiplier)
        {
            TMPro.TextMeshPro val_7 = this.rewardText;
            if(val_7 != 0)
            {
                    val_7 = this.rewardText;
                val_7.sortingOrder = val_7.sortingOrder * multiplier;
            }
            
            if(val_4.Length < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                val_7 = this.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_7];
                val_7.sortingOrder = val_7.sortingOrder * multiplier;
                val_7 = val_7 + 1;
            }
            while(val_7 < val_4.Length);
        
        }
        public virtual void InitForClaim()
        {
        
        }
        public virtual void InitForNewReward()
        {
        
        }
        public virtual DG.Tweening.Sequence SendRewardToCenter(Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessClaimAnimation claimAnimation)
        {
            .<>4__this = this;
            .claimAnimation = claimAnimation;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = this.transform.parent.position;
            float val_6 = UnityEngine.Mathf.Lerp(a:  val_5.x, b:  (MadnessRewardView.<>c__DisplayClass9_0)[1152921519352800784].claimAnimation.targetRewardPosition, t:  0.3f);
            float val_7 = val_5.y + 0.5f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  0.3f);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.1f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.2f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (MadnessRewardView.<>c__DisplayClass9_0)[1152921519352800784].claimAnimation.targetRewardPosition, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Vector3[] val_23 = new UnityEngine.Vector3[6];
            val_23[0] = val_6;
            val_23[0] = val_7;
            val_23[1] = val_5.z;
            val_23[1] = val_13;
            val_23[2] = val_13.y;
            val_23[2] = val_13.z;
            val_23[3] = val_16;
            val_23[3] = val_16.y;
            val_23[4] = val_16.z;
            val_23[4] = (MadnessRewardView.<>c__DisplayClass9_0)[1152921519352800784].claimAnimation.targetRewardPosition;
            val_23[5] = val_10.y;
            val_23[5] = val_10.z;
            val_23[6] = val_18;
            val_23[6] = val_18.y;
            val_23[7] = val_18.z;
            val_23[7] = val_20;
            val_23[8] = val_20.y;
            val_23[8] = val_20.z;
            UnityEngine.Color val_24 = UnityEngine.Color.green;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform.parent, path:  val_23, duration:  0.75f, pathType:  2, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  (MadnessRewardView.<>c__DisplayClass9_0)[1152921519352800784].claimAnimation.claimCollectEasing));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform.parent, endValue:  new UnityEngine.Vector3() {x = (MadnessRewardView.<>c__DisplayClass9_0)[1152921519352800784].claimAnimation.targetRewardScale, y = val_24.g, z = val_24.b}, duration:  0.75f), ease:  1));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  new MadnessRewardView.<>c__DisplayClass9_0(), method:  System.Void MadnessRewardView.<>c__DisplayClass9_0::<SendRewardToCenter>b__0()));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.73f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView).__il2cppRuntimeField_1B8));
            return val_2;
        }
        public virtual void SquashStretchReward()
        {
            if(this.transform.childCount < 1)
            {
                    return;
            }
            
            if((this.transform.GetChild(index:  0).childCount) < 1)
            {
                    return;
            }
            
            this = this.transform.GetChild(index:  0).Find(n:  "Squash");
            if(this == 0)
            {
                    return;
            }
            
            DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.08f));
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_10, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.08f));
        }
        public virtual DG.Tweening.Sequence SendRewardToBar(Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessNewRewardAnimation newRewardAnimation)
        {
            .newRewardAnimation = newRewardAnimation;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = this.transform.parent.position;
            float val_6 = UnityEngine.Mathf.Lerp(a:  val_5.x, b:  (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].newRewardAnimation.targetRewardPosition, t:  0.8f);
            float val_7 = S11 + 0.5f;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            .wp1 = (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].newRewardAnimation.targetRewardPosition;
            mem[1152921519353337308] = val_5.y;
            mem[1152921519353337312] = val_5.z;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  0.3f);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].newRewardAnimation.targetRewardPosition, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  0.1f);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  0.2f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Vector3[] val_23 = new UnityEngine.Vector3[6];
            val_23[0] = val_6;
            val_23[0] = val_7;
            val_23[1] = new UnityEngine.Vector3();
            val_23[1] = val_9;
            val_23[2] = val_9.y;
            val_23[2] = val_9.z;
            val_23[3] = val_11;
            val_23[3] = val_11.y;
            val_23[4] = val_11.z;
            val_23[4] = (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].wp1;
            val_23[5] = new UnityEngine.Vector3();
            val_23[6] = val_20;
            val_23[6] = val_20.y;
            val_23[7] = val_20.z;
            val_23[7] = val_17;
            val_23[8] = val_17.y;
            val_23[8] = val_17.z;
            UnityEngine.Color val_24 = UnityEngine.Color.green;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform.parent, path:  val_23, duration:  0.75f, pathType:  2, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].newRewardAnimation.newRewardEasing));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform.parent, endValue:  new UnityEngine.Vector3() {x = (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].newRewardAnimation.targetRewardScale, y = val_24.g, z = val_24.b}, duration:  0.75f), ease:  2));
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (MadnessRewardView.<>c__DisplayClass11_0)[1152921519353337280].newRewardAnimation.rewardParticles.transform, endValue:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, duration:  0.3f), ease:  1));
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  new MadnessRewardView.<>c__DisplayClass11_0(), method:  System.Void MadnessRewardView.<>c__DisplayClass11_0::<SendRewardToBar>b__0()));
            return val_2;
        }
        public virtual DG.Tweening.Sequence PlayCollectAnimation(Royal.Player.Context.Units.MadnessStep stepConfig)
        {
            return DG.Tweening.DOTween.Sequence();
        }
        public MadnessRewardView()
        {
        
        }
    
    }

}
