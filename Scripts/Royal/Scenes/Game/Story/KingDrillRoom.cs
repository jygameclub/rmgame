using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class KingDrillRoom : MonoBehaviour
    {
        // Fields
        public const float DrillVeryCloseSeconds = 10;
        private static readonly int KingLoopAnim;
        private static readonly int KingWalkAnim;
        private static readonly int KingLoop2Anim;
        private static readonly int KingFailAnim;
        private static readonly int KingWinAnim;
        private static readonly int KingFailWinAnim;
        public UnityEngine.GameObject stopText;
        public UnityEngine.Transform quitLevelButton;
        public UnityEngine.Sprite homePageTopInfoContainerSprite;
        public UnityEngine.Sprite timerMovingColorSprite;
        public UnityEngine.SpriteRenderer stopHighlight;
        public TMPro.TextMeshPro stopPressText;
        public TMPro.TextMeshPro barText;
        public TMPro.TextMeshPro timeUiCountText;
        public Royal.Infrastructure.Utils.Text.CurvedTextAnimator kingsSpeech;
        public UnityEngine.AnimationCurve wallCurve;
        public UnityEngine.Material drillLightningMat;
        public Royal.Scenes.Game.Story.KingDrillRoomBundledSubPrefabView bundle;
        private UnityEngine.Vector3 wallFirstMaxLeftPos;
        private UnityEngine.Vector3 wallMaxLeftPosition;
        private UnityEngine.Vector3 wallStartPos;
        private float wallDistance;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private int drillStep;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.KingDrillBundle kingDrillBundle;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private long wallSoundKey;
        private System.Action waitingAction;
        private UnityEngine.AudioClip storyWallMovementClip;
        
        // Methods
        private void Awake()
        {
            this.kingDrillBundle = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25).GetBundle(bundleType:  3);
            this.SetBundledPrefabInstance();
            this.SetSoundsReference();
        }
        public void Init()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.wallSoundKey = 0;
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.bundle.kingAnimator.Play(stateNameHash:  Royal.Scenes.Game.Story.KingDrillRoom.KingLoopAnim, layer:  0, normalizedTime:  0f);
            this.bundle.kingAnimator.speed = 0f;
            this.ArrangeForDevice();
            UnityEngine.Vector3 val_4 = this.bundle.room.position;
            this.bundle.boardBackground.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = this.bundle.room.localScale;
            this.bundle.boardBackground.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_8 = this.bundle.wall.transform.position;
            this.wallStartPos = val_8;
            mem[1152921519963868660] = val_8.y;
            mem[1152921519963868664] = val_8.z;
            float val_15 = this.camManager.cameraWidth;
            val_15 = val_15 * 0.5f;
            val_15 = val_15 + (-0.45f);
            this.wallStartPos = val_15;
            this.bundle.wall.position = new UnityEngine.Vector3() {x = val_15, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_9 = this.bundle.room.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.wallMaxLeftPosition = val_9;
            mem[1152921519963868648] = val_9.y;
            mem[1152921519963868652] = val_9.z;
            UnityEngine.Vector3 val_10 = this.bundle.room.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.wallFirstMaxLeftPos = val_10;
            mem[1152921519963868636] = val_10.y;
            mem[1152921519963868640] = val_10.z;
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            UnityEngine.Vector3 val_12 = this.bundle.wall.position;
            this.wallDistance = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = this.wallMaxLeftPosition, y = V11.16B, z = V10.16B});
            this.bundle.timer.Init(seconds:  this.moveManager.<MaxSeconds>k__BackingField);
            this.bundle.timer.HighlightTimer();
            this.bundle.progress.Init(drillRoom:  this);
            this.bundle.progress.stopButton.GetComponentInChildren<UnityEngine.BoxCollider2D>().enabled = true;
            this.InitQuitButton();
            this.InitDrills();
            this.bundle.kingDrillRedFrame.Init();
            this.bundle.kingDrillRedFrame.Hide();
            this.waitingAction = 0;
        }
        private void ArrangeForDevice()
        {
            float val_39;
            float val_40;
            UnityEngine.Vector2 val_2 = this.camManager.GetPositionVector2();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_5 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).GetGridTopCenterPosition();
            float val_38 = this.camManager.GetAspect();
            if(this.camManager.IsDeviceTall() != false)
            {
                    val_39 = 1.4f;
                val_40 = 1f;
            }
            else
            {
                    if(this.camManager.IsDeviceWide() != false)
            {
                    val_38 = (UnityEngine.Mathf.Max(a:  0f, b:  val_38 + (-0.7f))) / 0.07f;
                val_39 = UnityEngine.Mathf.Lerp(a:  1.32f, b:  1.12f, t:  val_38);
                float val_12 = UnityEngine.Mathf.Lerp(a:  0.82f, b:  0.77f, t:  val_38);
                val_40 = UnityEngine.Mathf.Lerp(a:  1.05f, b:  0.87f, t:  val_38);
                float val_14 = UnityEngine.Mathf.Lerp(a:  4.67f, b:  4.55f, t:  val_38);
            }
            else
            {
                    val_39 = 1.12f;
                val_40 = 0.9f;
            }
            
            }
            
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.bundle.ui.transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            this.bundle.progress.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.bundle.timeUi.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  val_40);
            this.bundle.progress.transform.localScale = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_40);
            this.bundle.timeUi.transform.localScale = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  val_39);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            this.bundle.roomBottomCenter.position = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector3 val_28 = this.bundle.room.position;
            float val_39 = this.camManager.cameraWidth;
            val_39 = val_39 * (-0.5f);
            this.bundle.room.position = new UnityEngine.Vector3() {x = val_39, y = val_28.y, z = val_28.z};
            UnityEngine.Vector2 val_30 = this.bundle.room.GetComponent<UnityEngine.SpriteRenderer>().size;
            UnityEngine.Vector3 val_31 = this.camManager.GetTopCenterOfCamera();
            float val_40 = 0.77f;
            float val_32 = val_31.y - val_28.y;
            val_40 = val_40 * val_30.y;
            val_32 = val_32 / val_40;
            float val_34 = UnityEngine.Mathf.Max(a:  val_32, b:  this.camManager.cameraWidth / val_30.x);
            this.bundle.room.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  1f);
            this.bundle.wall.transform.localScale = new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
        }
        private void CreateDevButton()
        {
        
        }
        public void StartLevel()
        {
            this.bundle.kingAnimator.speed = 1f;
            this.StartDrills();
            UnityEngine.Coroutine val_2 = this.bundle.StartCoroutine(routine:  this.CountDownAnim());
            this.bundle.timer.DisableHighlight();
            this.wallSoundKey = this.audioManager.PlayStoppableSound(audioClip:  this.storyWallMovementClip, loop:  true, volume:  1f);
        }
        private void InitQuitButton()
        {
            float val_17;
            UnityEngine.Vector3 val_1 = this.camManager.GetSafeTopCenterOfCamera();
            float val_16 = val_1.x;
            if(this.camManager.IsDeviceTall() != false)
            {
                    val_17 = 0.95f;
            }
            else
            {
                    if(this.camManager.IsDeviceWide() != false)
            {
                    float val_14 = this.camManager.GetAspect();
                val_14 = (UnityEngine.Mathf.Max(a:  0f, b:  val_14 + (-0.7f))) / 0.07f;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  val_14);
                val_17 = UnityEngine.Mathf.Lerp(a:  1f, b:  0.85f, t:  val_14);
            }
            else
            {
                    val_17 = 0.85f;
            }
            
            }
            
            float val_15 = 0.5f;
            val_15 = this.camManager.cameraWidth * val_15;
            val_16 = val_16 + val_15;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = val_1.y, z = 0f}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.quitLevelButton.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_17);
            this.quitLevelButton.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        private System.Collections.IEnumerator CountDownAnim()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new KingDrillRoom.<CountDownAnim>d__37();
        }
        private void PlaySpeechForRemainingSeconds()
        {
            int val_3 = this.moveManager.<Seconds>k__BackingField;
            val_3 = (this.moveManager.<MaxSeconds>k__BackingField) - val_3;
            if(val_3 == 7)
            {
                goto label_2;
            }
            
            if(val_3 != 5)
            {
                goto label_4;
            }
            
            this.PlaySpeech(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "StoryLevelHelpMe"));
            goto label_4;
            label_2:
            this.bundle.kingAnimator.CrossFade(stateHashName:  Royal.Scenes.Game.Story.KingDrillRoom.KingWalkAnim, normalizedTransitionDuration:  0.1f);
            label_4:
            if((this.moveManager.<Seconds>k__BackingField) != 5)
            {
                    if((this.moveManager.<Seconds>k__BackingField) != 10)
            {
                    return;
            }
            
                this.bundle.kingAnimator.Play(stateNameHash:  Royal.Scenes.Game.Story.KingDrillRoom.KingFailAnim, layer:  0, normalizedTime:  0f);
                this.PlaySpeech(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "StoryLevelHurryUp"));
                this.bundle.kingDrillRedFrame.Animate(modifier:  0.6f);
                return;
            }
            
            this.bundle.kingDrillRedFrame = 1065353216;
            if(this.bundle.kingDrillRedFrame.redSequence == null)
            {
                    return;
            }
            
            this.bundle.kingDrillRedFrame.redSequence = 1065353216;
        }
        private void PlaySpeech(string text)
        {
            if(val_1.Length >= 1)
            {
                    var val_15 = 0;
                do
            {
                T val_14 = this.kingsSpeech.GetComponentsInChildren<TMPro.TextMeshPro>()[val_15];
                val_15 = val_15 + 1;
            }
            while(val_15 < val_1.Length);
            
            }
            
            var val_3 = (this.camManager.IsDeviceTall() != true) ? 0.2f : -0.1f;
            UnityEngine.Vector3 val_6 = this.bundle.kingHead.transform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.kingsSpeech.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            this.kingsSpeech.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            this.kingsSpeech.Init(frameDelayBetweenChars:  2);
            this.kingsSpeech.StartAnimation(isReversed:  Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.kingsSpeech.transform, endValue:  0f, duration:  0.5f), ease:  26), delay:  3f);
        }
        private void StartDrills()
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.GetComponentsInChildren<Royal.Scenes.Game.Story.WallDrill.WallDrillView>(includeInactive:  true)[val_3].StartAnimation();
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        private void InitDrills()
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.GetComponentsInChildren<Royal.Scenes.Game.Story.WallDrill.WallDrillView>(includeInactive:  true)[val_3].Init();
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        public void Win()
        {
            var val_5;
            int val_6;
            UnityEngine.AnimatorStateInfo val_1 = this.bundle.kingAnimator.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_5 = null;
            val_5 = null;
            if( == Royal.Scenes.Game.Story.KingDrillRoom.KingFailAnim)
            {
                    val_6 = Royal.Scenes.Game.Story.KingDrillRoom.KingFailWinAnim;
            }
            else
            {
                    val_6 = Royal.Scenes.Game.Story.KingDrillRoom.KingWinAnim;
            }
            
            this.bundle.kingAnimator.CrossFade(stateHashName:  val_6, normalizedTransitionDuration:  0.05f);
            this.StopDrills(slowly:  true);
            this.StopWallSound();
            this.EndRedFrame(onCycleComplete:  0, delay:  0f);
        }
        public void Fail(float failDelay = 0, System.Action onCycleStop)
        {
            this.bundle.progress.stopButton.GetComponentInChildren<UnityEngine.BoxCollider2D>().enabled = false;
            this.StopDrills(slowly:  false);
            if(this.bundle.kingDrillRedFrame.redSequence != null)
            {
                    this.EndRedFrame(onCycleComplete:  onCycleStop, delay:  failDelay);
            }
            else
            {
                    UnityEngine.Debug.LogWarning(message:  "Are you here?");
                System.Delegate val_2 = System.Delegate.Combine(a:  this.waitingAction, b:  onCycleStop);
                if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_12;
            }
            
            }
            
                this.waitingAction = val_2;
                this.Invoke(methodName:  "CallAndResetWaitingAction", time:  failDelay);
            }
            
            this.StopAllCoroutines();
            return;
            label_12:
        }
        private void CallAndResetWaitingAction()
        {
            if(this.waitingAction != null)
            {
                    this.waitingAction.Invoke();
            }
            
            this.waitingAction = 0;
        }
        public void StopDrills(bool slowly = True)
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                T val_2 = this.GetComponentsInChildren<Royal.Scenes.Game.Story.WallDrill.WallDrillView>(includeInactive:  true)[val_3];
                if(slowly != false)
            {
                    val_2.StopAnimation();
            }
            else
            {
                    val_2.CutAnimation();
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        public void StopCountdown()
        {
            this.StopAllCoroutines();
            this.EndRedFrame(onCycleComplete:  0, delay:  0f);
        }
        private void EndRedFrame(System.Action onCycleComplete, float delay = 0)
        {
            this.bundle.kingDrillRedFrame.EndAfterLoop(onComplete:  onCycleComplete, minDelay:  delay);
        }
        public void QuitLevel()
        {
            var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  7, log:  "Game Quit flow started.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            Quit(moveManager:  this.moveManager);
            Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).LevelEnd();
            Royal.Scenes.Game.Context.GameContext.Get<Royal.Scenes.Game.Context.Units.GameManager>(id:  1).ExitGameWhenPossible();
            this.StopAllRelatedSound();
        }
        public void StopAllRelatedSound()
        {
            if(val_1.Length >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.GetComponentsInChildren<Royal.Scenes.Game.Story.WallDrill.WallDrillView>(includeInactive:  true)[val_3].StopAllRelatedSound();
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
            
            }
            
            this.StopWallSound();
        }
        private void StopWallSound()
        {
            if(this.wallSoundKey < 1)
            {
                    return;
            }
            
            this.audioManager.StopSound(key:  this.wallSoundKey);
            this.wallSoundKey = 0;
        }
        private void SetBundledPrefabInstance()
        {
            Royal.Scenes.Game.Story.KingDrillRoomBundledSubPrefabView val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.kingDrillBundle.KingDrillRoomBundledSubPrefab, parent:  this.gameObject.transform).GetComponent<Royal.Scenes.Game.Story.KingDrillRoomBundledSubPrefabView>();
            this.bundle = val_5;
            val_5.UpdateLightningMaterials(lightningMat:  this.drillLightningMat);
            this.barText.transform.SetParent(p:  this.bundle.progressUi);
            this.stopText.transform.SetParent(p:  this.bundle.progress.stopBox.transform);
            this.timeUiCountText.transform.SetParent(p:  this.bundle.timeUi);
            this.bundle.progress = this.stopHighlight;
            this.bundle.progress = this.stopPressText;
            this.bundle.progress = this.barText;
            this.bundle.timer = this.timeUiCountText;
            this.bundle.timer.movingColor.sprite = this.timerMovingColorSprite;
            this.bundle.timeUiBackground.sprite = this.homePageTopInfoContainerSprite;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  1.560274f, y:  0.9175628f);
            this.bundle.timeUiBackground.size = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        }
        private void RemoveBundledPrefabReference()
        {
            if(this.kingDrillBundle != null)
            {
                    this.kingDrillBundle.RemoveKingDrillRoomBundledSubPrefabReference();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void SetSoundsReference()
        {
            this.storyWallMovementClip = this.kingDrillBundle;
        }
        private void OnDestroy()
        {
            if(this.kingDrillBundle != null)
            {
                    this.kingDrillBundle.RemoveKingDrillRoomBundledSubPrefabReference();
                return;
            }
            
            throw new NullReferenceException();
        }
        public KingDrillRoom()
        {
        
        }
        private static KingDrillRoom()
        {
            Royal.Scenes.Game.Story.KingDrillRoom.KingLoopAnim = UnityEngine.Animator.StringToHash(name:  "Base Layer.KingLoopAnim");
            Royal.Scenes.Game.Story.KingDrillRoom.KingWalkAnim = UnityEngine.Animator.StringToHash(name:  "Base Layer.KingWalkAnim");
            Royal.Scenes.Game.Story.KingDrillRoom.KingLoop2Anim = UnityEngine.Animator.StringToHash(name:  "Base Layer.KingLoop2Anim");
            Royal.Scenes.Game.Story.KingDrillRoom.KingFailAnim = UnityEngine.Animator.StringToHash(name:  "Base Layer.KingFailAnim");
            Royal.Scenes.Game.Story.KingDrillRoom.KingWinAnim = UnityEngine.Animator.StringToHash(name:  "Base Layer.KingWinAnim");
            Royal.Scenes.Game.Story.KingDrillRoom.KingFailWinAnim = UnityEngine.Animator.StringToHash(name:  "Base Layer.KingFailWin");
        }
    
    }

}
