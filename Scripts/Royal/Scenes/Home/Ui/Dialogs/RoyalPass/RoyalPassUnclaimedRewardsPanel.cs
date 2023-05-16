using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassUnclaimedRewardsPanel : UiPanel
    {
        // Fields
        public static float maxPos;
        public UnityEngine.GameObject root;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.BoxCollider2D blockerCollider;
        public UnityEngine.BoxCollider2D panelCollider;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator curvedTitle;
        public UnityEngine.Transform description;
        public TMPro.TextMeshPro tapText;
        public UnityEngine.Transform rewardContainer;
        public UnityEngine.Rendering.SortingGroup rewardContainerSortingGroup;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private bool isTapEnabled;
        private System.Action onComplete;
        private System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> rewardCounts;
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, int>> sortedRewards;
        private System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward> rewardViews;
        private float fadeDuration;
        
        // Methods
        public void Show(System.Action onComplete, System.Collections.Generic.Dictionary<Royal.Player.Context.Units.RewardType, int> rewardCounts)
        {
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.onComplete = onComplete;
            this.rewardCounts = rewardCounts;
            this.isTapEnabled = false;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.cameraManager.cameraWidth, y:  this.cameraManager.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            this.background.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            UnityEngine.Vector2 val_5 = this.background.size;
            this.panelCollider.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = this.background.size;
            this.blockerCollider.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            this.curvedTitle.Init(frameDelayBetweenChars:  1);
            if(this.cameraManager.IsDeviceTall() != true)
            {
                    this.SetupForShortDevice();
            }
            
            this.ShowTexts();
            this.Claim();
        }
        private void Claim()
        {
            var val_3;
            if((this.rewardCounts.ContainsKey(key:  1)) == false)
            {
                    return;
            }
            
            float val_3 = this.fadeDuration;
            val_3 = val_3 + 1.9f;
            this.fadeDuration = val_3;
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  this.rewardCounts.Item[1]);
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.__il2cppRuntimeField_30.PrepareCoinTextForAnimation();
        }
        private void CreateRewards()
        {
            Royal.Player.Context.Units.RewardType val_14;
            var val_15;
            System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, System.Int32>>(source:  this.rewardCounts);
            this.sortedRewards = val_1;
            val_1.Sort(comparison:  new System.Comparison<System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, System.Int32>>(object:  this, method:  System.Int32 Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<CreateRewards>b__20_0(System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, int> x, System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, int> y)));
            this.rewardViews = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward>();
            val_15 = null;
            val_15 = null;
            float val_16 = 1.152922E+18f;
            val_16 = val_16 / 3f;
            float val_17 = (float)Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.__il2cppRuntimeField_cctor_finished;
            val_17 = val_17 / 3f;
            float val_18 = 0.5f;
            val_18 = ((float)W11 - 1) * val_18;
            var val_20 = 0;
            do
            {
                var val_19 = 0;
                val_19 = val_19 * 2863311531;
                val_19 = val_19 >> 33;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_14 = mem[(Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.__il2cppRuntimeField_cctor_finished + 0) + 32];
                val_14 = (Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.__il2cppRuntimeField_cctor_finished + 0) + 32;
                float val_8 = 0f / 3f;
                UnityEngine.Vector3 val_11 = new UnityEngine.Mathf().GetPosition(row:  1792167984, column:  val_20 + (val_19 - (val_19 << 2)), columnMax:  (val_20 < 1301606400) ? 3 : ((Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.__il2cppRuntimeField_cctor_finished - 1152921505908453376)), yOffset:  val_18 * Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.maxPos);
                Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward val_12 = this.CreateReward(rewardType:  val_14, count:  (Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.__il2cppRuntimeField_cctor_finished + 0) + 32 + 4);
                val_12.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                float val_14 = 0f * 0.03f;
                float val_15 = 0f * 0.01f;
                this.rewardViews.Add(item:  val_12);
                val_20 = val_20 + 1;
            }
            while(val_20 < null);
        
        }
        private UnityEngine.Vector3 GetPosition(int row, int column, int columnMax, float yOffset)
        {
            var val_6;
            float val_7;
            float val_8;
            float val_9;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_6 = null;
            val_6 = null;
            val_7 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.maxPos;
            float val_2 = val_7 * ((float)-row);
            if(columnMax == 2)
            {
                goto label_5;
            }
            
            if(columnMax != 3)
            {
                goto label_6;
            }
            
            val_8 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.maxPos;
            val_8 = val_8 * ((float)column - 1);
            goto label_9;
            label_5:
            val_9 = Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.maxPos;
            val_9 = val_9 * 0.5f;
            val_9 = ((column == 0) ? -1f : 1f) * val_9;
            label_9:
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y + yOffset, z = val_1.z};
            label_6:
            return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y + yOffset, z = val_1.z};
        }
        private void ShowTexts()
        {
            this.curvedTitle.StartAnimation(isReversed:  false);
            UnityEngine.Vector3 val_2 = this.description.transform.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.description.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = this.tapText.transform.localScale;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.tapText.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_9, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.description, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  27));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_9, atPosition:  0.4f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<ShowTexts>b__22_0()));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_9, atPosition:  1f, t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  0.2f), ease:  27), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<ShowTexts>b__22_1())));
        }
        public override void TouchUp(UnityEngine.Vector2 position)
        {
            if(this.isTapEnabled == false)
            {
                    return;
            }
            
            this.isTapEnabled = false;
            this.PlayRewardAnimations();
        }
        private void PlayRewardAnimations()
        {
            var val_9 = 0;
            var val_8 = 0;
            label_8:
            if(val_8 >= 36585472)
            {
                goto label_2;
            }
            
            if(36585472 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_5 = 0f;
            val_5 = val_5 * (-0.075f);
            float val_2 = UnityEngine.Mathf.Max(a:  0.4f, b:  val_5 + 0.7f);
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward> val_6 = this.rewardViews;
            val_6 = val_9 + val_6;
            float val_7 = (float)val_6;
            val_7 = val_7 * 0.04f;
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  3, delay:  val_7);
            val_8 = val_8 + 1;
            val_9 = val_9 - 1;
            if(this.rewardViews != null)
            {
                goto label_8;
            }
            
            label_2:
            this.rewardContainer.SetParent(p:  this.transform);
            this.HideTexts();
        }
        private void HideTexts()
        {
            this.background.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.TweenSettingsExtensions.Insert(s:  DG.Tweening.DOTween.Sequence(), atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.curvedTitle.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.15f), ease:  1)), atPosition:  0.02f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.description.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.15f), ease:  1)), atPosition:  0.04f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  0.15f), ease:  1)), atPosition:  0f, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.2f)), atPosition:  0.2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<HideTexts>b__25_0())), atPosition:  this.fadeDuration, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<HideTexts>b__25_1())), atPosition:  2f, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<HideTexts>b__25_2()));
        }
        private void SetupForShortDevice()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.rewardContainer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_4 = val_1.GetSafeTopCenterOfCamera();
            float val_9 = -1.2f;
            val_9 = val_4.y + val_9;
            val_1.SetLocalYPosition(transform:  this.curvedTitle.transform, y:  val_9);
            UnityEngine.Vector3 val_6 = val_1.GetSafeTopCenterOfCamera();
            float val_10 = -2.7f;
            val_10 = val_6.y + val_10;
            val_1.SetLocalYPosition(transform:  this.description.transform, y:  val_10);
            UnityEngine.Vector3 val_8 = val_1.GetSafeBottomCenterOfCamera();
            float val_11 = 1.5f;
            val_11 = val_8.y + val_11;
            val_1.SetLocalYPosition(transform:  this.tapText.transform, y:  val_11);
        }
        private void SetLocalYPosition(UnityEngine.Transform transform, float y)
        {
            UnityEngine.Vector3 val_1 = transform.localPosition;
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void HideText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapText.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.15f), ease:  1));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel::<HideText>b__28_0()));
        }
        private int GetRewardSorting(Royal.Player.Context.Units.RewardType rewardType)
        {
            if((rewardType - 1) > 12)
            {
                    return 0;
            }
            
            return (int)36595248 + ((rewardType - 1)) << 2;
        }
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward CreateReward(Royal.Player.Context.Units.RewardType rewardType, int count)
        {
            int val_8;
            object[] val_1 = new object[4];
            val_1[0] = "Create Reward: ";
            val_8 = val_1.Length;
            val_1[1] = rewardType;
            val_8 = val_1.Length;
            val_1[2] = " - ";
            val_1[3] = count;
            UnityEngine.Debug.Log(message:  +val_1);
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward val_7 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedReward>(path:  "UnclaimedRewards/"("UnclaimedRewards/") + "RoyalPassUnclaimed" + rewardType("RoyalPassUnclaimed" + rewardType)), parent:  this.rewardContainer.transform);
            if(rewardType == 2)
            {
                    val_7.SetLife(minutes:  count, prepareTextForAnimation:  true);
                return val_7;
            }
            
            val_7.SetAmount(amount:  count);
            return val_7;
        }
        public RoyalPassUnclaimedRewardsPanel()
        {
            this.fadeDuration = 1.1f;
        }
        private static RoyalPassUnclaimedRewardsPanel()
        {
            Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassUnclaimedRewardsPanel.maxPos = 2.775f;
        }
        private int <CreateRewards>b__20_0(System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, int> x, System.Collections.Generic.KeyValuePair<Royal.Player.Context.Units.RewardType, int> y)
        {
            var val_4;
            var val_5;
            if((x.Value - 1) <= 12)
            {
                    val_4 = mem[36595248 + ((x.Value - 1)) << 2];
                val_4 = 36595248 + ((x.Value - 1)) << 2;
            }
            else
            {
                    val_4 = 0;
            }
            
            val_5 = 0;
            if((y.Value - 1) > 12)
            {
                    return (int)(val_4 >= val_5) ? (-0) : 0;
            }
            
            val_5 = mem[36595248 + ((y.Value - 1)) << 2];
            val_5 = 36595248 + ((y.Value - 1)) << 2;
            return (int)(val_4 >= val_5) ? (-0) : 0;
        }
        private void <ShowTexts>b__22_0()
        {
            this.CreateRewards();
        }
        private void <ShowTexts>b__22_1()
        {
            this.isTapEnabled = true;
        }
        private void <HideTexts>b__25_0()
        {
            this.root.SetActive(value:  false);
            this.rewardContainerSortingGroup.enabled = true;
            this.rewardContainer.SetParent(p:  0);
        }
        private void <HideTexts>b__25_1()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            if(this.onComplete == null)
            {
                    return;
            }
            
            this.onComplete.Invoke();
        }
        private void <HideTexts>b__25_2()
        {
            UnityEngine.Object.Destroy(obj:  this.rewardContainer.gameObject);
        }
        private void <HideText>b__28_0()
        {
            this.tapText.text = "";
        }
    
    }

}
