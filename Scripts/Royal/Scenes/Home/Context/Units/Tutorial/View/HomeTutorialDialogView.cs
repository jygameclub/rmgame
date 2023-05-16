using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial.View
{
    public class HomeTutorialDialogView : MonoBehaviour
    {
        // Fields
        public const float Height = 2;
        public UnityEngine.SpriteRenderer bgLeft;
        public UnityEngine.SpriteRenderer bgRight;
        public TMPro.TextMeshPro tutorialText;
        public UnityEngine.GameObject continueButton;
        private System.Action OnContinue;
        private float tutorialShownAt;
        
        // Methods
        public void add_OnContinue(System.Action value)
        {
            do
            {
                if((System.Delegate.Combine(a:  this.OnContinue, b:  value)) != null)
            {
                    if(null != null)
            {
                goto label_2;
            }
            
            }
            
            }
            while(this.OnContinue != 1152921519573901944);
            
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
            while(this.OnContinue != 1152921519574038520);
            
            return;
            label_2:
        }
        private void Awake()
        {
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSortingOverDialog();
            val_2.sortEverything = val_2.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything}, offset:  20);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_3.layer, order = val_3.order, sortEverything = val_3.sortEverything & 4294967295});
            this.tutorialShownAt = (float)Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs();
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView SetText(string text)
        {
            this.tutorialText.text = text;
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView EnableContinueButton()
        {
            this.continueButton.SetActive(value:  true);
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView SetPosition(UnityEngine.Vector3 position, Royal.Scenes.Home.Context.Units.Tutorial.View.DialogAnchor anchor = 0)
        {
            object val_7;
            float val_8;
            float val_9;
            val_7 = this;
            if(anchor == 2)
            {
                goto label_1;
            }
            
            if(anchor == 1)
            {
                goto label_2;
            }
            
            if(anchor == 0)
            {
                goto label_3;
            }
            
            val_7 = anchor;
            throw new System.ArgumentOutOfRangeException(paramName:  "anchor", actualValue:  anchor, message:  0);
            label_2:
            val_8 = 0f;
            val_9 = -1f;
            goto label_4;
            label_1:
            val_8 = 0f;
            val_9 = 1f;
            label_4:
            val_8 = val_8 + val_9;
            label_3:
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, b:  new UnityEngine.Vector3() {x = 0f, y = val_8, z = 0f});
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            Royal.Infrastructure.Contexts.Units.CameraManager val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.transform.SetParent(p:  val_4.camera.transform);
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)val_7;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView SetSize(float textWidth, float dialogWidth)
        {
            UnityEngine.Vector2 val_1 = this.bgLeft.size;
            this.bgLeft.size = new UnityEngine.Vector2() {x = dialogWidth, y = val_1.y};
            UnityEngine.Vector2 val_2 = this.bgRight.size;
            this.bgRight.size = new UnityEngine.Vector2() {x = dialogWidth, y = val_2.y};
            UnityEngine.Vector2 val_4 = this.tutorialText.rectTransform.sizeDelta;
            this.tutorialText.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = textWidth, y = val_4.y};
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this;
        }
        public Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView SetSize(float textWidth, float dialogWidth, float textHeight, float dialogHeight)
        {
            UnityEngine.Vector2 val_1 = this.bgLeft.size;
            this.bgLeft.size = new UnityEngine.Vector2() {x = dialogWidth, y = dialogHeight};
            UnityEngine.Vector2 val_2 = this.bgRight.size;
            this.bgRight.size = new UnityEngine.Vector2() {x = dialogWidth, y = dialogHeight};
            UnityEngine.Vector2 val_4 = this.tutorialText.rectTransform.sizeDelta;
            this.tutorialText.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = textWidth, y = textHeight};
            return (Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialDialogView)this;
        }
        public void ClickContinueButton()
        {
            float val_2 = this.tutorialShownAt;
            val_2 = (float)Royal.Infrastructure.Utils.Time.TimeUtil.CurrentTimeInMs() - val_2;
            if(val_2 < 0)
            {
                    return;
            }
            
            if(this.OnContinue == null)
            {
                    return;
            }
            
            this.OnContinue.Invoke();
        }
        public HomeTutorialDialogView()
        {
        
        }
    
    }

}
