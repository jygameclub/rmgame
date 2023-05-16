using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.LevelTutorials.View
{
    public class TutorialDialogView : MonoBehaviour
    {
        // Fields
        public const float MinShowSeconds = 0.5;
        public const float Height = 2;
        public UnityEngine.SpriteRenderer bgLeft;
        public UnityEngine.SpriteRenderer bgRight;
        public TMPro.TextMeshPro tutorialText;
        private System.Action OnContinue;
        private bool isTutorialOptional;
        private float tutorialShownAt;
        private UnityEngine.Vector3 topPositionLimit;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private int mouseDownFrame;
        
        // Methods
        public void add_OnContinue(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnContinue, b:  value)) != null)
            {
                    if(null != "replace")
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnContinue != 1152921524038578352);
            
            return;
            label_2:
        }
        public void remove_OnContinue(System.Action value)
        {
            do
            {
                if((System.Delegate.Remove(source:  this.OnContinue, value:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnContinue != 1152921524038714928);
            
            return;
            label_2:
        }
        private void Awake()
        {
            null = null;
            UnityEngine.Vector3 val_1 = GetBottomOfTopUi();
            this.topPositionLimit = val_1;
            mem[1152921524038861764] = val_1.y;
            mem[1152921524038861768] = val_1.z;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_3.sortEverything = val_3.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything}, offset:  20);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = val_4.sortEverything & 4294967295});
            this.tutorialShownAt = Royal.Scenes.Game.Levels.LevelContext.Time;
            this.isTutorialOptional = true;
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.uiTouchListener = val_7;
            val_7.add_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView::MouseDown(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)));
            this.uiTouchListener.add_OnMouseUp(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView::MouseUp()));
        }
        private void MouseDown(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)
        {
            this.mouseDownFrame = UnityEngine.Time.frameCount;
        }
        private void MouseUp()
        {
            int val_6;
            if(this.isTutorialOptional == false)
            {
                    return;
            }
            
            float val_1 = Royal.Scenes.Game.Levels.LevelContext.Time;
            val_1 = val_1 - this.tutorialShownAt;
            if(val_1 < 0.5f)
            {
                    return;
            }
            
            int val_5 = this.mouseDownFrame;
            val_5 = UnityEngine.Time.frameCount - val_5;
            if(val_5 > 3)
            {
                    val_6 = 1;
            }
            else
            {
                    val_6 = 4 - val_5;
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.ClickContinueDelayed(delay:  val_6));
        }
        private System.Collections.IEnumerator ClickContinueDelayed(int delay)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .delay = delay;
            return (System.Collections.IEnumerator)new TutorialDialogView.<ClickContinueDelayed>d__16();
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView SetText(string text)
        {
            if((Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != true) && (Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean != true))
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic == false)
            {
                goto label_6;
            }
            
            }
            
            this.tutorialText.enableWordWrapping = false;
            label_6:
            this.tutorialText.text = text;
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView SetPosition(UnityEngine.Vector3 position, Royal.Scenes.Game.Levels.Units.LevelTutorials.View.DialogAnchor anchor = 0)
        {
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            if(anchor == 2)
            {
                goto label_1;
            }
            
            if(anchor == 1)
            {
                goto label_2;
            }
            
            if(anchor != 0)
            {
                goto label_3;
            }
            
            val_7 = 0f;
            goto label_4;
            label_2:
            val_8 = 0f;
            val_9 = -1f;
            goto label_5;
            label_1:
            val_8 = 0f;
            val_9 = 1f;
            label_5:
            val_7 = val_8 + val_9;
            label_4:
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_7, z = 0f});
            val_10 = val_1.x;
            val_11 = val_1.y;
            val_12 = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.topPositionLimit, y = val_1.y, z = 0f}, b:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
            if(val_2.y < 0)
            {
                    val_10 = this.topPositionLimit;
                val_11 = 1.1f + (-1.1f);
            }
            
            this.transform.position = new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
            label_3:
            System.ArgumentOutOfRangeException val_4 = 1152921504614621184;
            val_4 = new System.ArgumentOutOfRangeException(paramName:  "anchor", actualValue:  anchor, message:  0);
            throw val_4;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView SetSize(float textWidth, float dialogWidth)
        {
            UnityEngine.Vector2 val_1 = this.bgLeft.size;
            this.bgLeft.size = new UnityEngine.Vector2() {x = dialogWidth, y = val_1.y};
            UnityEngine.Vector2 val_2 = this.bgRight.size;
            this.bgRight.size = new UnityEngine.Vector2() {x = dialogWidth, y = val_2.y};
            UnityEngine.Vector2 val_4 = this.tutorialText.rectTransform.sizeDelta;
            this.tutorialText.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = textWidth, y = val_4.y};
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView SetSize(UnityEngine.Vector2 textSize, UnityEngine.Vector2 dialogSize)
        {
            UnityEngine.Vector2 val_1 = this.bgLeft.size;
            this.bgLeft.size = new UnityEngine.Vector2() {x = dialogSize.x, y = dialogSize.y};
            UnityEngine.Vector2 val_2 = this.bgRight.size;
            this.bgRight.size = new UnityEngine.Vector2() {x = dialogSize.x, y = dialogSize.y};
            UnityEngine.Vector2 val_4 = this.tutorialText.rectTransform.sizeDelta;
            this.tutorialText.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = textSize.x, y = textSize.y};
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView SetFontSize(float fontSize)
        {
            this.tutorialText.enableAutoSizing = false;
            this.tutorialText.fontSize = fontSize;
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
        }
        public Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView SetOptional(bool optional, float delay = 0)
        {
            string val_2;
            if(delay <= 0f)
            {
                goto label_1;
            }
            
            if(optional == false)
            {
                goto label_2;
            }
            
            val_2 = "EnableOptional";
            goto label_3;
            label_1:
            this.isTutorialOptional = optional;
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
            label_2:
            val_2 = "DisableOptional";
            label_3:
            this.Invoke(methodName:  val_2, time:  delay);
            return (Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView)this;
        }
        private void EnableOptional()
        {
            this.isTutorialOptional = true;
        }
        private void DisableOptional()
        {
            this.isTutorialOptional = false;
        }
        public void ContinueButtonClicked()
        {
            this.isTutorialOptional = false;
            if(this.OnContinue == null)
            {
                    return;
            }
            
            this.OnContinue.Invoke();
        }
        private void OnDestroy()
        {
            this.Clear();
        }
        public void Clear()
        {
            this.uiTouchListener.remove_OnMouseUp(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView::MouseUp()));
            this.uiTouchListener.remove_OnMouseDown(value:  new System.Action<Royal.Infrastructure.UiComponents.Touch.ITouchable>(object:  this, method:  System.Void Royal.Scenes.Game.Levels.Units.LevelTutorials.View.TutorialDialogView::MouseDown(Royal.Infrastructure.UiComponents.Touch.ITouchable obj)));
            this.StopAllCoroutines();
        }
        public TutorialDialogView()
        {
        
        }
    
    }

}
