using UnityEngine;

namespace Royal.Scenes.Home.Ui
{
    public class HomeUi : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel userInfoPanel;
        public Royal.Scenes.Home.Ui.Sections.Home.Icons.IconsView iconsView;
        public Royal.Scenes.Home.Ui.Sections.SectionBar sectionBar;
        public Royal.Scenes.Home.Ui.Sections.Home.HomeSection homeSection;
        public UnityEngine.GameObject actionButtons;
        public Royal.Scenes.Home.Ui.Sections.SectionManager sectionManager;
        private UnityEngine.Vector3 originalUserInfoPosition;
        private UnityEngine.Vector3 originalSectionBarPosition;
        private UnityEngine.Vector3 originalActionButtonsPosition;
        private Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager sceneManager;
        private int previousScene;
        
        // Methods
        private void Awake()
        {
            int val_2;
            this.sceneManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            if((val_1.<WasForceLoad>k__BackingField) != false)
            {
                    val_2 = 1;
            }
            else
            {
                    val_2 = val_1.<PreviousScene>k__BackingField;
            }
            
            this.previousScene = val_2;
        }
        private System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new HomeUi.<Start>d__12();
        }
        public void HideHomeUiWithoutAnimation()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  6f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalUserInfoPosition, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.userInfoPanel.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  7f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalSectionBarPosition, y = V9.16B, z = this.originalUserInfoPosition}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.sectionBar.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  7f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.originalActionButtonsPosition, y = V9.16B, z = this.originalUserInfoPosition}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this.actionButtons.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            this.iconsView.HideWithoutAnimation();
        }
        public void PlayHomeUiAppearAnimation()
        {
            this.DisableTouch();
            this.Invoke(methodName:  "EnableTouch", time:  0.3f);
            UnityEngine.GameObject val_1 = this.userInfoPanel.gameObject;
            val_1.PrepareAppearAnimation(uiElement:  val_1, originalPosition:  new UnityEngine.Vector3() {x = this.originalUserInfoPosition}, verticalMoveDelta:  6);
            UnityEngine.GameObject val_2 = this.sectionBar.gameObject;
            val_2.PrepareAppearAnimation(uiElement:  val_2, originalPosition:  new UnityEngine.Vector3() {x = this.originalSectionBarPosition}, verticalMoveDelta:  -7);
            val_2.PrepareAppearAnimation(uiElement:  this.actionButtons, originalPosition:  new UnityEngine.Vector3() {x = this.originalActionButtonsPosition}, verticalMoveDelta:  -7);
            this.iconsView.AnimateIn();
        }
        public void PlayHomeUiHideAnimation()
        {
            this.DisableTouch();
            float val_2 = (this.iconsView.IsAnyIconVisible() != true) ? 0.17f : 0f;
            this.Invoke(methodName:  "EnableTouch", time:  0.3f);
            UnityEngine.GameObject val_3 = this.userInfoPanel.gameObject;
            val_3.PrepareHideAnimation(uiElement:  val_3, originalPosition:  new UnityEngine.Vector3() {x = this.originalUserInfoPosition, y = 0f}, verticalMoveDelta:  6, delay:  val_2);
            UnityEngine.GameObject val_4 = this.sectionBar.gameObject;
            val_4.PrepareHideAnimation(uiElement:  val_4, originalPosition:  new UnityEngine.Vector3() {x = this.originalSectionBarPosition, y = 0f}, verticalMoveDelta:  -7, delay:  val_2);
            val_4.PrepareHideAnimation(uiElement:  this.actionButtons, originalPosition:  new UnityEngine.Vector3() {x = this.originalActionButtonsPosition, y = 0f}, verticalMoveDelta:  -7, delay:  val_2);
            this.iconsView.AnimateOut();
        }
        private void PrepareAppearAnimation(UnityEngine.GameObject uiElement, UnityEngine.Vector3 originalPosition, long verticalMoveDelta)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  (float)verticalMoveDelta);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = originalPosition.x, y = originalPosition.y, z = originalPosition.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            uiElement.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  uiElement.transform, endValue:  new UnityEngine.Vector3() {x = originalPosition.x, y = originalPosition.y, z = originalPosition.z}, duration:  0.3f, snapping:  false), ease:  27);
        }
        private void PrepareHideAnimation(UnityEngine.GameObject uiElement, UnityEngine.Vector3 originalPosition, long verticalMoveDelta, float delay)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  (float)verticalMoveDelta);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = originalPosition.x, y = originalPosition.y, z = originalPosition.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  uiElement.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f, snapping:  false), ease:  26), delay:  delay);
        }
        public void DisableTouch()
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_1.disabler.DisableTouch();
            throw new NullReferenceException();
        }
        public void EnableTouch()
        {
            Royal.Scenes.Home.Ui.HomeUi.EnableTouchStatic();
        }
        public static void EnableTouchStatic()
        {
            Royal.Infrastructure.UiComponents.Touch.UiTouchListener val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_1.disabler.EnableTouch();
            throw new NullReferenceException();
        }
        public HomeUi()
        {
        
        }
    
    }

}
