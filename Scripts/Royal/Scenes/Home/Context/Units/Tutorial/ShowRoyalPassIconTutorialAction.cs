using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial
{
    public class ShowRoyalPassIconTutorialAction : FlowAction
    {
        // Fields
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager tutorialManager;
        private readonly Royal.Player.Context.Units.RoyalPassManager royalPassManager;
        private Royal.Scenes.Home.Context.Units.Tutorial.RoyalPassTutorialStep royalPassTutorialStep;
        private readonly Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassIcon royalPassIcon;
        private readonly Royal.Scenes.Game.Mechanics.Sortings.SortingData tutorialArrowSorting;
        
        // Properties
        public override int Type { get; }
        
        // Methods
        public override int get_Type()
        {
            return 3;
        }
        public ShowRoyalPassIconTutorialAction()
        {
            var val_5;
            this.tutorialManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3);
            this.royalPassManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12);
            val_5 = null;
            val_5 = null;
            this.royalPassIcon = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_byval_arg + 80;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_3 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            this.tutorialArrowSorting = val_3;
            mem[1152921519561064608] = val_3.sortEverything;
            this.royalPassIcon.add_OnRoyalPassIconClick(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.ShowRoyalPassIconTutorialAction::OnRoyalPassIconClick()));
        }
        public override void Execute()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  28, log:  "Royal pass icon tutorial is active", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            this.royalPassManager.SetFirstTimeTutorialAsSeen();
            this.MoveNextStep();
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
        private void ShowTutorialStep1()
        {
            .<>4__this = this;
            this.royalPassManager.StartRoyalPassDialogTutorials();
            this.royalPassTutorialStep = 1;
            UnityEngine.Vector3 val_2 = this.BringRoyalPassIConFront();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            .arrowPosition = val_3;
            mem[1152921519561495180] = val_3.y;
            mem[1152921519561495184] = val_3.z;
            UnityEngine.Coroutine val_5 = Royal.Scenes.Start.Context.ApplicationContext.ManualStartCoroutine(iEnumerator:  Royal.Scenes.Home.Context.Units.Tutorial.ShowRoyalPassIconTutorialAction.DisableAndEnableTouches());
            this.tutorialManager.CreateBlack(isBlocker:  true).Show(delay:  0f, fadeDuration:  0f, onComplete:  new System.Action(object:  new ShowRoyalPassIconTutorialAction.<>c__DisplayClass10_0(), method:  System.Void ShowRoyalPassIconTutorialAction.<>c__DisplayClass10_0::<ShowTutorialStep1>b__0()), darkness:  0.9f);
        }
        private static System.Collections.IEnumerator DisableAndEnableTouches()
        {
            .<>1__state = 0;
            return (System.Collections.IEnumerator)new ShowRoyalPassIconTutorialAction.<DisableAndEnableTouches>d__11();
        }
        private void OnRoyalPassIconClick()
        {
            if(this.royalPassTutorialStep != 1)
            {
                    return;
            }
            
            this.HideTutorialStep1();
            this.royalPassIcon.remove_OnRoyalPassIconClick(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.ShowRoyalPassIconTutorialAction::OnRoyalPassIconClick()));
        }
        private void HideTutorialStep1()
        {
            this.tutorialManager.DestroyBlack();
            this.tutorialManager.DestroyArrow();
            this.SendRoyalPassIconBack();
            this.Complete();
        }
        private void MoveNextStep()
        {
            if(this.royalPassTutorialStep != 0)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
            this.ShowTutorialStep1();
        }
        private UnityEngine.Vector3 BringRoyalPassIConFront()
        {
            this.royalPassIcon.royalPassButton.ZIndex = -15;
            this.UpdateRoyalPassIconChildrenSorting(sortingLayerId:  this.tutorialArrowSorting, sortingOrder:  public System.Void Royal.Infrastructure.UiComponents.Touch.UiTouchComponent::set_ZIndex(Royal.Infrastructure.UiComponents.Touch.ZIndex value));
            return this.royalPassIcon.icon.transform.position;
        }
        private void SendRoyalPassIconBack()
        {
            var val_1;
            this.royalPassIcon.royalPassButton.ZIndex = 1;
            val_1 = null;
            val_1 = null;
            this.UpdateRoyalPassIconChildrenSorting(sortingLayerId:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId, sortingOrder:  -15585212);
        }
        private void UpdateRoyalPassIconChildrenSorting(int sortingLayerId, int sortingOrder)
        {
            var val_7;
            if(val_1.Length >= 1)
            {
                    var val_8 = 0;
                do
            {
                this.royalPassIcon.icon.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_8].sortingLayerID = sortingLayerId;
                val_7 = mem[val_1[0x0] + 32];
                val_7 = val_1[0x0] + 32;
                val_7.sortingOrder = val_7.sortingOrder + sortingOrder;
                val_8 = val_8 + 1;
            }
            while(val_8 < val_1.Length);
            
            }
            
            if(val_2.Length < 1)
            {
                    return;
            }
            
            do
            {
                this.royalPassIcon.icon.GetComponentsInChildren<TMPro.TextMeshPro>()[0].sortingLayerID = sortingLayerId;
                val_2[0x0] + 32.sortingOrder = (val_2[0x0] + 32.sortingOrder) + sortingOrder;
                val_7 = 0 + 1;
            }
            while(val_7 < val_2.Length);
        
        }
    
    }

}
