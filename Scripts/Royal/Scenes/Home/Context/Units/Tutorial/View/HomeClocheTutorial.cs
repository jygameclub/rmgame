using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial.View
{
    public class HomeClocheTutorial
    {
        // Fields
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager tutorialManager;
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialHighlightHelper homeTutorialHighlightHelper;
        private readonly Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog prelevelDialog;
        
        // Methods
        public HomeClocheTutorial(Royal.Scenes.Home.Ui.Dialogs.Prelevel.PrelevelDialog dialog, Royal.Scenes.Home.Context.Units.Tutorial.View.HomeTutorialViewAssets homeTutorialViewAssets)
        {
            this.prelevelDialog = dialog;
            this.tutorialManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3);
            .assets = homeTutorialViewAssets;
            this.homeTutorialHighlightHelper = new Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialHighlightHelper();
        }
        public void StartTutorial()
        {
            UnityEngine.Vector3 val_1 = this.prelevelDialog.GetBoostersCenterPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  3.13f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.homeTutorialHighlightHelper.HighlightArea(centerPos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, width:  5.9f, height:  2.6f);
            UnityEngine.Coroutine val_6 = Royal.Scenes.Home.Context.HomeContext.ManualStartCoroutine(iEnumerator:  this.MoveClocheButtonToTopZIndex());
        }
        private System.Collections.IEnumerator MoveClocheButtonToTopZIndex()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new HomeClocheTutorial.<MoveClocheButtonToTopZIndex>d__5();
        }
        public void CloseClocheTutorial()
        {
            this.homeTutorialHighlightHelper.DisableHighlight();
            this.tutorialManager.DestroyArrow();
        }
    
    }

}
