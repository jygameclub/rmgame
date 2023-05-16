using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Animations
{
    public class MadnessCollectAnimation : MonoBehaviour
    {
        // Fields
        public UnityEngine.AnimationCurve animationCurve;
        public UnityEngine.SpriteRenderer background;
        public UnityEngine.Transform miniEventTypeIconsRoot;
        public UnityEngine.ParticleSystem appearParticles;
        public TMPro.TextMeshPro countText;
        private UnityEngine.Transform eventTypeIcon;
        private UnityEngine.Rendering.SortingGroup[] miniEventTypeIcons;
        private UnityEngine.Transform targetIcon;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Infrastructure.Utils.Randoming.RandomManager randomManager;
        private Royal.Infrastructure.Contexts.Units.CameraManager cameraManager;
        private UnityEngine.Vector3 initialCollectScale;
        private int count;
        private System.Action onComplete;
        private Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType;
        
        // Methods
        public void Play(Royal.Infrastructure.Services.Backend.Protocol.MadnessEventType eventType, int count, System.Action onComplete)
        {
            var val_27;
            MadnessCollectAnimation.<>c__DisplayClass15_0 val_1 = new MadnessCollectAnimation.<>c__DisplayClass15_0();
            .onComplete = onComplete;
            .<>4__this = this;
            this.eventType = eventType;
            this.count = System.Math.Min(val1:  10, val2:  count);
            this.onComplete = (MadnessCollectAnimation.<>c__DisplayClass15_0)[1152921519374221440].onComplete;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<System.Object>(id:  16);
            this.randomManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5);
            this.cameraManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.cameraWidth, y:  val_5.cameraHeight);
            this.background.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            val_27 = null;
            val_27 = null;
            this.targetIcon = Royal.Scenes.Home.Ui.__il2cppRuntimeField_50 + 64;
            UnityEngine.Vector3 val_9 = this.targetIcon.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  0.1f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.countText.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.countText.text = count.ToString();
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            this.countText.transform.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            this.InitEventTypeIcon();
            this.InitMiniEventTypeIcons();
            DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  this.ShowEventTypeIcon());
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_16, interval:  0.5f);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_16, t:  this.SendMiniEventTypeIconsToBar());
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_16, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessCollectAnimation.<>c__DisplayClass15_0::<Play>b__0()));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_16, interval:  1f);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_16, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessCollectAnimation.<>c__DisplayClass15_0::<Play>b__1()));
        }
        private void InitEventTypeIcon()
        {
            UnityEngine.Transform val_4 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  (this.eventType == 3) ? "MainBookCollect" : "MainPropellerCollect"), parent:  this.transform);
            this.eventTypeIcon = val_4;
            UnityEngine.Vector3 val_6 = val_4.transform.localScale;
            this.initialCollectScale = val_6;
            mem[1152921519374434900] = val_6.y;
            mem[1152921519374434904] = val_6.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.eventTypeIcon.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private void InitMiniEventTypeIcons()
        {
            UnityEngine.Rendering.SortingGroup[] val_8;
            var val_9;
            int val_2 = this.count - 1;
            UnityEngine.Rendering.SortingGroup[] val_3 = new UnityEngine.Rendering.SortingGroup[0];
            int val_12 = this.count;
            this.miniEventTypeIcons = val_3;
            val_12 = val_12 - 1;
            if(val_12 < 1)
            {
                    return;
            }
            
            val_8 = val_3;
            val_9 = 4;
            goto label_2;
            label_18:
            val_8 = this.miniEventTypeIcons;
            val_9 = 5;
            label_2:
            val_8 = UnityEngine.Object.Instantiate<UnityEngine.Rendering.SortingGroup>(original:  UnityEngine.Resources.Load<UnityEngine.Rendering.SortingGroup>(path:  (this.eventType == 3) ? "MiniBookCollect" : "MiniPropellerCollect"), parent:  this.miniEventTypeIconsRoot);
            int val_7 = (val_9 - 4) + 300;
            this.miniEventTypeIcons[1].sortingOrder = val_7;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.miniEventTypeIcons[1].transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            int val_15 = this.count;
            val_15 = val_15 - 1;
            if(((val_7 - 300) + 1) < val_15)
            {
                goto label_18;
            }
        
        }
        private DG.Tweening.Sequence ShowEventTypeIcon()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialCollectScale, y = V8.16B, z = V9.16B}, d:  1.2f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialCollectScale, y = val_1.y, z = V4.16B}, d:  0.9f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.initialCollectScale, y = val_2.y, z = V4.16B}, d:  1.05f);
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.eventTypeIcon.transform, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f)), ease:  3));
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessCollectAnimation::<ShowEventTypeIcon>b__18_0()));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.eventTypeIcon.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f)), ease:  3));
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.eventTypeIcon.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)), ease:  3));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_4, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.eventTypeIcon.transform, endValue:  new UnityEngine.Vector3() {x = this.initialCollectScale, y = this.initialCollectScale, z = this.initialCollectScale}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  2f)), ease:  3));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_4, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0.8f, duration:  0.2f), ease:  9));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_4, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.Madness.Animations.MadnessCollectAnimation::<ShowEventTypeIcon>b__18_1()));
            return val_4;
        }
        private DG.Tweening.Sequence SendMiniEventTypeIconsToBar()
        {
            var val_48;
            float val_49;
            float val_50;
            DG.Tweening.TweenCallback val_51;
            DG.Tweening.TweenCallback val_52;
            MadnessCollectAnimation.<>c__DisplayClass19_0 val_1 = new MadnessCollectAnimation.<>c__DisplayClass19_0();
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            .reverseSortingIndex = System.Math.Max(val1:  0, val2:  this.miniEventTypeIcons.Length - 4);
            float val_46 = (float)this.miniEventTypeIcons.Length;
            val_46 = val_46 / (-9f);
            float val_6 = UnityEngine.Mathf.Lerp(a:  0.11f, b:  0.225f, t:  val_46 + 1f);
            float val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  45f);
            float val_47 = 0.3f;
            val_47 = val_7 * val_47;
            val_7 = val_7 * 0.9f;
            val_48 = 0;
            val_49 = 0f;
            label_36:
            if(val_48 >= this.miniEventTypeIcons.Length)
            {
                goto label_13;
            }
            
            UnityEngine.Rendering.SortingGroup val_48 = this.miniEventTypeIcons[val_48];
            UnityEngine.Vector3 val_11 = val_48.transform.position;
            UnityEngine.Vector3 val_12 = this.targetIcon.position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, t:  0.5f);
            if(this.randomManager.NextBool() != false)
            {
                    val_50 = -0.15f;
            }
            else
            {
                    val_50 = 0.15f;
            }
            
            float val_15 = UnityEngine.Random.Range(min:  val_50, max:  0.25f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3[] val_17 = new UnityEngine.Vector3[3];
            val_17[0] = val_11;
            val_17[0] = val_11.y;
            val_17[1] = val_11.z;
            val_17[1] = val_16;
            val_17[2] = val_16.y;
            val_17[2] = val_16.z;
            val_17[3] = val_12;
            val_17[3] = val_12.y;
            val_17[4] = val_12.z;
            DG.Tweening.Sequence val_18 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Color val_21 = UnityEngine.Color.blue;
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_18, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  val_48.transform, path:  val_17, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  45f), pathType:  1, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), animCurve:  this.animationCurve));
            val_51 = (MadnessCollectAnimation.<>c__DisplayClass19_0)[1152921519375645792].<>9__1;
            if(val_51 == null)
            {
                    DG.Tweening.TweenCallback val_26 = null;
                val_51 = val_26;
                val_26 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessCollectAnimation.<>c__DisplayClass19_0::<SendMiniEventTypeIconsToBar>b__1());
                .<>9__1 = val_51;
            }
            
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_18, atPosition:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  5f), callback:  val_26);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_18, atPosition:  val_7 * 0.6f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_48.transform, endValue:  0.8f, duration:  val_47), ease:  1));
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_18, atPosition:  val_7, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_48.transform, endValue:  0f, duration:  val_7 * 0.4f), ease:  1));
            if(val_48 == ((MadnessCollectAnimation.<>c__DisplayClass19_0)[1152921519375645792].reverseSortingIndex))
            {
                    val_52 = (MadnessCollectAnimation.<>c__DisplayClass19_0)[1152921519375645792].<>9__2;
                if(val_52 == null)
            {
                    DG.Tweening.TweenCallback val_37 = null;
                val_52 = val_37;
                val_37 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessCollectAnimation.<>c__DisplayClass19_0::<SendMiniEventTypeIconsToBar>b__2());
                .<>9__2 = val_52;
            }
            
                DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_18, atPosition:  val_49 + 0.6f, callback:  val_37);
            }
            
            DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  val_49, t:  val_18);
            val_48 = val_48 + 1;
            val_49 = val_6 + val_49;
            if(this.miniEventTypeIcons != null)
            {
                goto label_36;
            }
            
            throw new NullReferenceException();
            label_13:
            DG.Tweening.Sequence val_43 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_2, atPosition:  UnityEngine.Mathf.Max(a:  val_6, b:  val_49 * 0.8f), t:  this.SendEventTypeIconToBar());
            DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MadnessCollectAnimation.<>c__DisplayClass19_0::<SendMiniEventTypeIconsToBar>b__0()));
            return val_2;
        }
        private DG.Tweening.Sequence SendEventTypeIconToBar()
        {
            UnityEngine.Vector3 val_2 = this.eventTypeIcon.transform.position;
            UnityEngine.Vector3 val_3 = this.targetIcon.position;
            float val_5 = (UnityEngine.Mathf.Lerp(a:  val_2.x, b:  val_3.x, t:  0.6f)) + (-0.3f);
            float val_6 = UnityEngine.Mathf.Lerp(a:  val_2.y, b:  val_3.y, t:  0.35f);
            UnityEngine.Vector3[] val_7 = new UnityEngine.Vector3[3];
            val_7[0] = val_2;
            val_7[0] = val_2.y;
            val_7[1] = val_2.z;
            val_7[1] = 0;
            val_7[2] = 0;
            val_7[3] = val_3;
            val_7[3] = val_3.y;
            val_7[4] = val_3.z;
            DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.eventTypeIcon.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.9f), ease:  2));
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  0.8f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.background, endValue:  0f, duration:  0.3f), ease:  9));
            UnityEngine.Color val_18 = UnityEngine.Color.blue;
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  0.2f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.eventTypeIcon.transform, path:  val_7, duration:  0.6f, pathType:  1, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  2));
            float val_22 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f);
            val_22 = 0.9f - val_22;
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_8, atPosition:  val_22, t:  this.ShowAndHideText());
            return val_8;
        }
        private DG.Tweening.Sequence ShowAndHideText()
        {
            UnityEngine.Vector3 val_2 = this.countText.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3[] val_5 = new UnityEngine.Vector3[3];
            val_5[0] = val_2;
            val_5[0] = val_2.y;
            val_5[1] = val_2.z;
            val_5[1] = val_3;
            val_5[2] = val_3.y;
            val_5[2] = val_3.z;
            val_5[3] = val_4;
            val_5[3] = val_4.y;
            val_5[4] = val_4.z;
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            float val_7 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  13f);
            float val_26 = 1f;
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.countText, endValue:  val_26, duration:  val_7), ease:  4));
            UnityEngine.Color val_12 = UnityEngine.Color.blue;
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.countText.transform, path:  val_5, duration:  val_7, pathType:  1, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  3));
            val_26 = val_7 + val_26;
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_26, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.countText, endValue:  0f, duration:  val_7), ease:  4));
            UnityEngine.Color val_22 = UnityEngine.Color.blue;
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_6, atPosition:  val_26, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>>(t:  DG.Tweening.ShortcutExtensions.DOPath(target:  this.countText.transform, path:  System.Linq.Enumerable.ToArray<UnityEngine.Vector3>(source:  System.Linq.Enumerable.Reverse<UnityEngine.Vector3>(source:  val_5)), duration:  val_7, pathType:  1, pathMode:  1, resolution:  50, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true}), ease:  3));
            return val_6;
        }
        public MadnessCollectAnimation()
        {
        
        }
        private void <ShowEventTypeIcon>b__18_0()
        {
            this.appearParticles.Play();
            this.audioManager.PlaySound(type:  22, offset:  0.04f);
        }
        private void <ShowEventTypeIcon>b__18_1()
        {
            if(this.miniEventTypeIcons.Length < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                this = this.miniEventTypeIcons[val_5].transform;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  1.25f);
                this.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
                val_5 = val_5 + 1;
            }
            while(val_5 < this.miniEventTypeIcons.Length);
        
        }
    
    }

}
