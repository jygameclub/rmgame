using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards
{
    public class LadderRewardView : MonoBehaviour
    {
        // Fields
        public float claimRewardScale;
        public UnityEngine.Rendering.SortingGroup rewardParticlesSortingGroup;
        public UnityEngine.ParticleSystem hardGlow;
        public UnityEngine.ParticleSystem lightBeam;
        public TMPro.TextMeshPro tntAmountText;
        public TMPro.TextMeshPro rocketAmountText;
        public TMPro.TextMeshPro lightballAmountText;
        public TMPro.TextMeshPro hammerAmountText;
        public TMPro.TextMeshPro cannonAmountText;
        public TMPro.TextMeshPro arrowAmountText;
        public TMPro.TextMeshPro jesterAmountText;
        protected Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        protected int coinAmount;
        private System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, string> rewardsAndAmountTexts;
        
        // Methods
        protected virtual void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public virtual void InitForClaim(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep ladderOfferStep)
        {
            this.coinAmount = ladderOfferStep.GetCoinAmountInChestInventory();
            this.rewardsAndAmountTexts = ladderOfferStep.GetChestGiftboxRewards();
            this.SetAmountText(amountText:  this.tntAmountText, rewardType:  11);
            this.SetAmountText(amountText:  this.rocketAmountText, rewardType:  13);
            this.SetAmountText(amountText:  this.lightballAmountText, rewardType:  12);
            this.SetAmountText(amountText:  this.hammerAmountText, rewardType:  6);
            this.SetAmountText(amountText:  this.cannonAmountText, rewardType:  8);
            this.SetAmountText(amountText:  this.arrowAmountText, rewardType:  7);
            this.SetAmountText(amountText:  this.jesterAmountText, rewardType:  9);
        }
        private void SetAmountText(TMPro.TextMeshPro amountText, Royal.Player.Context.Units.RewardType rewardType)
        {
            string val_6;
            if(amountText == 0)
            {
                    return;
            }
            
            if((this.rewardsAndAmountTexts.ContainsKey(key:  rewardType)) == false)
            {
                goto label_5;
            }
            
            val_6 = 0;
            if((System.String.op_Inequality(a:  this.rewardsAndAmountTexts.Item[rewardType], b:  "x1")) == false)
            {
                goto label_7;
            }
            
            val_6 = this.rewardsAndAmountTexts.Item[rewardType];
            if(amountText != null)
            {
                goto label_9;
            }
            
            return;
            label_5:
            val_6 = 0;
            label_7:
            label_9:
            amountText.text = val_6;
        }
        public virtual DG.Tweening.Sequence SendRewardToCenter(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Animations.LadderClaimAnimation claimAnimation)
        {
            .<>4__this = this;
            .claimAnimation = claimAnimation;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_5 = this.transform.parent.position;
            float val_6 = UnityEngine.Mathf.Lerp(a:  val_5.x, b:  (LadderRewardView.<>c__DisplayClass17_0)[1152921519436363424].claimAnimation.targetRewardPosition, t:  0.3f);
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
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (LadderRewardView.<>c__DisplayClass17_0)[1152921519436363424].claimAnimation.targetRewardPosition, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
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
            val_23[4] = (LadderRewardView.<>c__DisplayClass17_0)[1152921519436363424].claimAnimation.targetRewardPosition;
            val_23[5] = val_10.y;
            val_23[5] = val_10.z;
            val_23[6] = val_18;
            val_23[6] = val_18.y;
            val_23[7] = val_18.z;
            val_23[7] = val_20;
            val_23[8] = val_20.y;
            val_23[8] = val_20.z;
            UnityEngine.Color val_24 = UnityEngine.Color.green;
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.transform.parent, path:  val_23, duration:  0.75f, pathType:  2, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  (LadderRewardView.<>c__DisplayClass17_0)[1152921519436363424].claimAnimation.claimCollectEasing));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform.parent, endValue:  new UnityEngine.Vector3() {x = (LadderRewardView.<>c__DisplayClass17_0)[1152921519436363424].claimAnimation.targetRewardScale, y = val_24.g, z = val_24.b}, duration:  0.75f), ease:  1));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0f, callback:  new DG.Tweening.TweenCallback(object:  new LadderRewardView.<>c__DisplayClass17_0(), method:  System.Void LadderRewardView.<>c__DisplayClass17_0::<SendRewardToCenter>b__0()));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_2, atPosition:  0.73f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.Rewards.LadderRewardView).__il2cppRuntimeField_1A8));
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
        public virtual DG.Tweening.Sequence PlayCollectAnimation()
        {
            return DG.Tweening.DOTween.Sequence();
        }
        public LadderRewardView()
        {
        
        }
    
    }

}
