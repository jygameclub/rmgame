using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public class KingsCupInfoDialogEnter : KingsCupInfoDialog
    {
        // Fields
        private const float TotalLeftBarSize = 3.198595;
        public TMPro.TextMeshPro progressText;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.Transform rightProgressBar;
        public UnityEngine.Transform heartTransform;
        private bool isUserAction;
        private bool playProgressBarAnimation;
        private bool canClose;
        private Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel kingsCupEnterRewardPanel;
        
        // Methods
        public void Show(bool userAction, bool animateProgressBar = False)
        {
            this.Show();
            bool val_1 = userAction;
            this.isUserAction = val_1;
            this.playProgressBarAnimation = animateProgressBar;
            if(animateProgressBar != false)
            {
                    this.canClose = false;
                this.UpdateBarSize(ratio:  0f);
                val_1 = false;
                mem[1] = 0;
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.ProgressBarCoroutine(startProgress:  0f, endProgress:  1f, duration:  0.8f, onComplete:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupInfoDialogEnter::OnProgressBarComplete())));
                return;
            }
            
            this.canClose = true;
            this.UpdateBarSize(ratio:  0f);
        }
        private void OnProgressBarComplete()
        {
            UnityEngine.Vector3 val_2 = this.heartTransform.transform.localScale;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            val_2.x = val_2.x * 1.1f;
            val_2.y = val_2.y / 1.1f;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.heartTransform.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            float val_9 = val_2.x / 1.1f;
            float val_10 = val_2.y * 1.1f;
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_3, t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.heartTransform.transform, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  4f)));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_3, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupInfoDialogEnter::<OnProgressBarComplete>b__10_0()));
        }
        public override void Close()
        {
            if(this.canClose == false)
            {
                    return;
            }
            
            this.Close();
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            bool val_3;
            float val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.shouldCloseOnTouch = this.isUserAction;
            val_0.backgroundFadeInDuration = val_4;
            val_0.shouldCloseOnSwipe = val_3;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            dialogClosed.Invoke();
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            if(this.playProgressBarAnimation == false)
            {
                goto typeof(UnityEngine.GameObject).__il2cppRuntimeField_1B0;
            }
        
        }
        public void OnPlayClicked()
        {
            if(this.playProgressBarAnimation != false)
            {
                    return;
            }
            
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(val_1.HasAutoActionInTheFlow != true)
            {
                    val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.Prelevel.ShowPrelevelDialogAction(clearBoosterSelectionData:  true));
            }
        
        }
        private void EnableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  true);
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
        }
        private void UpdateBarSize(float ratio)
        {
            float val_6 = ratio;
            if(val_6 > 0f)
            {
                    this.EnableBarSprites();
                val_6 = val_6 * 3.198595f;
                UnityEngine.Vector2 val_1 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_6, y:  val_1.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                UnityEngine.Vector3 val_3 = this.rightProgressBar.localPosition;
                float val_7 = 0.2f;
                val_7 = val_6 + val_7;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_7, y:  val_3.y);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                this.rightProgressBar.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                return;
            }
            
            this.DisableBarSprites();
        }
        private System.Collections.IEnumerator ProgressBarCoroutine(float startProgress, float endProgress, float duration, System.Action onComplete)
        {
            .<>1__state = 0;
            .duration = duration;
            .startProgress = startProgress;
            .endProgress = endProgress;
            .<>4__this = this;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new KingsCupInfoDialogEnter.<ProgressBarCoroutine>d__18();
        }
        public KingsCupInfoDialogEnter()
        {
            val_1 = new Royal.Infrastructure.UiComponents.Dialog.UiDialog();
        }
        private void <OnProgressBarComplete>b__10_0()
        {
            this.canClose = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupEnterRewardPanel>(path:  "KingsCupEnterReward"), position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}).Show(heartTransform:  this.heartTransform, onCompleteAction:  new System.Action(object:  X22, method:  X22 + 440));
        }
    
    }

}
