using UnityEngine;

namespace Royal.Scenes.Game.Story
{
    public class KingDrillProgress : MonoBehaviour
    {
        // Fields
        private const float TotalLeftBarSize = 3.266;
        private const float ProgressBarMaxThreshold = 0.9;
        private const float ProgressBarMinThreshold = 0.08;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.SpriteRenderer rightProgressBar;
        public UnityEngine.SpriteRenderer stopBgLeft;
        public UnityEngine.Transform stopButton;
        public UnityEngine.Transform collector;
        public TMPro.TextMeshPro barText;
        public UnityEngine.BoxCollider2D stopBox;
        public UnityEngine.SpriteRenderer stopHighlight;
        public TMPro.TextMeshPro stopPressText;
        public UnityEngine.AnimationCurve stopButtonEasing;
        private bool <IsStopEnabled>k__BackingField;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameState;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private Royal.Scenes.Game.Story.KingDrillRoom drillRoom;
        private System.Action onButtonClicked;
        private int progress;
        private int maxProgress;
        private float partialProgress;
        private float progressSpeedDefault;
        private float progressSpeed;
        private float progressSpeedMultiplier;
        private float progressAcceleration;
        private float progressSpeedMax;
        
        // Properties
        public bool IsStopEnabled { get; set; }
        
        // Methods
        public bool get_IsStopEnabled()
        {
            return (bool)this.<IsStopEnabled>k__BackingField;
        }
        private void set_IsStopEnabled(bool value)
        {
            this.<IsStopEnabled>k__BackingField = value;
        }
        public void Init(Royal.Scenes.Game.Story.KingDrillRoom drillRoom)
        {
            this.gameState = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            this.drillRoom = drillRoom;
            Royal.Scenes.Game.Mechanics.Goal.GoalTuple val_6 = val_2.goals[0];
            this.maxProgress = val_2.goals[0].<LeftCount>k__BackingField;
            this.partialProgress = 0f;
            this.progress = 0;
            this.progressSpeed = this.progressSpeedDefault;
            this.UpdateBarSize(ratio:  0f);
            this.<IsStopEnabled>k__BackingField = false;
            this.stopBox.enabled = true;
            this.collector = this.rightProgressBar.transform;
            this.SetBarText(collected:  0, total:  this.maxProgress);
            this.stopHighlight.gameObject.SetActive(value:  false);
            this.stopButton.GetComponent<UnityEngine.Rendering.SortingGroup>().enabled = false;
        }
        private void Update()
        {
            this.IncrementBarIfPossible();
        }
        public void AnimateStopButton(System.Action onButtonClicked)
        {
            this.onButtonClicked = onButtonClicked;
            this.stopBox.enabled = false;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WaitForAllParticles());
        }
        private void SetBarText(int collected, int total)
        {
            this.barText.text = System.String.Format(format:  "{0} / {1}", arg0:  collected, arg1:  total);
        }
        private System.Collections.IEnumerator WaitForAllParticles()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new KingDrillProgress.<WaitForAllParticles>d__33();
        }
        public void OnStopButtonClick()
        {
            string val_6;
            string val_7;
            if((this.<IsStopEnabled>k__BackingField) != false)
            {
                    this.<IsStopEnabled>k__BackingField = false;
                Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).StopGameMusic();
                this.Invoke(methodName:  "HideStopButton", time:  0.1f);
                this.Invoke(methodName:  "CallButtonActionAndReset", time:  1.5f);
                return;
            }
            
            if(this.gameState.IsWin() != false)
            {
                    return;
            }
            
            val_6 = "StoryLevelTooltip";
            val_7 = "3";
            val_6 = val_6 + ;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_6), position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, width:  9f, speed:  2f);
        }
        private void HideStopButton()
        {
            this.drillRoom.Win();
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.stopButton, endValue:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  0.15f), ease:  2);
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_4 = DG.Tweening.DOTweenModuleSprite.DOFade(target:  this.stopHighlight, endValue:  0f, duration:  0.15f);
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOScale(target:  this.stopPressText, endValue:  0f, duration:  0.15f), ease:  2);
        }
        private void CallButtonActionAndReset()
        {
            this.onButtonClicked.Invoke();
            this.onButtonClicked = 0;
        }
        private void UpdateBarSize(float ratio)
        {
            var val_23;
            float val_24;
            val_23 = this;
            if(ratio > 0f)
            {
                    this.leftProgressBar.gameObject.SetActive(value:  true);
                val_24 = (UnityEngine.Mathf.Min(a:  1f, b:  ratio)) * 3.266f;
                UnityEngine.Vector2 val_3 = this.leftProgressBar.size;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_24, y:  val_3.y);
                this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                UnityEngine.Vector2 val_6 = this.rightProgressBar.size;
                UnityEngine.Vector3 val_8 = this.rightProgressBar.transform.localPosition;
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_24 + val_6.x, y:  val_8.y);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
                this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                val_23 = this.rightProgressBar.gameObject;
                UnityEngine.Vector2 val_13 = this.rightProgressBar.size;
                val_23.SetActive(value:  (val_24 > val_13.x) ? 1 : 0);
                return;
            }
            
            UnityEngine.Vector2 val_15 = this.leftProgressBar.size;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  0f, y:  val_15.y);
            this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
            UnityEngine.Vector2 val_18 = this.rightProgressBar.size;
            val_24 = val_18.x;
            UnityEngine.Vector3 val_20 = this.rightProgressBar.transform.localPosition;
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_24, y:  val_20.y);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            this.rightProgressBar.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            this.DisableBarSprites();
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
        }
        public void Increment()
        {
            int val_1 = this.progress;
            float val_2 = this.progressSpeed;
            val_1 = val_1 + 1;
            this.progress = val_1;
            if(val_2 >= 0)
            {
                    return;
            }
            
            val_2 = val_2 + this.progressAcceleration;
            this.progressSpeed = val_2;
        }
        public void IncrementBarIfPossible()
        {
            float val_7;
            int val_8;
            float val_9;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  this.partialProgress);
            if(val_1 < this.progress)
            {
                    float val_2 = UnityEngine.Time.deltaTime;
                val_2 = (this.progressSpeed * this.progressSpeedMultiplier) * val_2;
                val_7 = this.partialProgress + val_2;
                this.partialProgress = val_7;
                val_8 = this.progress;
                val_9 = (float)val_8;
                float val_4 = UnityEngine.Mathf.Min(a:  val_7, b:  val_9);
                this.partialProgress = val_4;
                int val_5 = UnityEngine.Mathf.FloorToInt(f:  val_4);
                if(val_1 < val_5)
            {
                    val_8 = val_5;
                val_7 = this.progressSpeed;
                val_9 = 1f;
                this.progressSpeed = UnityEngine.Mathf.Max(a:  val_7, b:  val_9);
                this.SetBarText(collected:  val_8, total:  this.maxProgress);
            }
            
                float val_7 = (float)this.maxProgress;
                val_7 = this.partialProgress / val_7;
                this.SetBarProgress(ratio:  val_7);
                return;
            }
            
            this.progressSpeed = this.progressSpeedDefault;
        }
        private void SetBarProgress(float ratio)
        {
            if(ratio < 0)
            {
                    ratio = ratio * 0.82f;
                ratio = ratio + 0.08f;
                this.UpdateBarSize(ratio:  ratio);
                return;
            }
            
            this.UpdateBarSize(ratio:  1f);
        }
        private float GetProgress()
        {
            float val_1 = (float)this.progress;
            val_1 = val_1 / (float)this.maxProgress;
            return (float)val_1;
        }
        public KingDrillProgress()
        {
            this.progressSpeedMax = 3f;
            this.progressSpeedDefault = ;
            this.progressSpeed = ;
            this.progressSpeedMultiplier = 3f;
            this.progressAcceleration = 1f;
        }
    
    }

}
