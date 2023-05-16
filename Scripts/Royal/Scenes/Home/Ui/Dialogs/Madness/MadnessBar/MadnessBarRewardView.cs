using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.MadnessBar
{
    public class MadnessBarRewardView : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform root;
        private Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView rewardView;
        
        // Methods
        public void CreateReward(Royal.Player.Context.Units.MadnessStep madnessStep)
        {
            UnityEngine.Transform val_7;
            this.DestroyReward();
            if(madnessStep == null)
            {
                    return;
            }
            
            string val_1 = madnessStep.GetPrefabName(prefix:  "BarReward");
            string val_2 = madnessStep.GetRewardText();
            if((System.String.IsNullOrEmpty(value:  val_1)) != false)
            {
                    this.DestroyReward();
                return;
            }
            
            val_7 = this.root;
            this.rewardView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards.MadnessRewardView>(path:  val_1), parent:  val_7);
            if((System.String.IsNullOrEmpty(value:  val_2)) != false)
            {
                    return;
            }
            
            this.rewardView.SetRewardText(text:  val_2);
        }
        public void HideReward()
        {
            this.root.gameObject.SetActive(value:  false);
        }
        public void ShowReward()
        {
            this.root.gameObject.SetActive(value:  true);
        }
        public void SquashStretchReward()
        {
            if(this.root.childCount < 1)
            {
                    return;
            }
            
            if((this.root.GetChild(index:  0).childCount) < 1)
            {
                    return;
            }
            
            this = this.root.GetChild(index:  0).GetChild(index:  0).Find(n:  "Squash");
            if(this == 0)
            {
                    return;
            }
            
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  0.1f));
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_8, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  0.1f));
        }
        public void SetupForInfoDialog(Royal.Player.Context.Units.MadnessStep madnessStep)
        {
            this.CreateReward(madnessStep:  madnessStep);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(madnessStep.GetRewardName() == 0)
            {
                    if(((System.Linq.Enumerable.First<Royal.Player.Context.Units.MadnessReward>(source:  madnessStep.r).GetRewardType()) & 4294967294) == 6)
            {
                
            }
            
            }
            
            UnityEngine.Transform val_6 = this.rewardView.transform;
            UnityEngine.Vector3 val_7 = val_6.localPosition;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_6.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        public void SetupForSmallDisplay(Royal.Player.Context.Units.MadnessStep madnessStep)
        {
            float val_12;
            float val_13;
            this.CreateReward(madnessStep:  madnessStep);
            this.rewardView.IncreaseSorting(multiplier:  10);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(madnessStep.GetRewardName() == 0)
            {
                goto label_5;
            }
            
            val_12 = -0.05f;
            val_13 = 0.05f;
            goto label_6;
            label_5:
            Royal.Player.Context.Units.RewardType val_4 = System.Linq.Enumerable.First<Royal.Player.Context.Units.MadnessReward>(source:  madnessStep.r).GetRewardType();
            if(val_4 != 1)
            {
                goto label_8;
            }
            
            val_12 = -0.023f;
            val_13 = 0.06f;
            label_6:
            label_13:
            UnityEngine.Transform val_5 = this.rewardView.transform;
            UnityEngine.Vector3 val_6 = val_5.localScale;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.8f);
            val_5.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = val_5.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_5.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            return;
            label_8:
            var val_11 = ((val_4 - 2) > 3) ? 1f : 0.8f;
            goto label_13;
        }
        private void IncreaseSorting(int multiplier)
        {
            if(this.rewardView != null)
            {
                    this.rewardView.IncreaseSorting(multiplier:  multiplier);
                return;
            }
            
            throw new NullReferenceException();
        }
        public void DestroyReward()
        {
            int val_2 = this.root.childCount - 1;
            if(<0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_3 = this.root.GetChild(index:  val_2);
                val_3.SetParent(p:  0);
                UnityEngine.Object.Destroy(obj:  val_3.gameObject);
                val_2 = val_2 - 1;
            }
            while(>=0);
        
        }
        public MadnessBarRewardView()
        {
        
        }
    
    }

}
