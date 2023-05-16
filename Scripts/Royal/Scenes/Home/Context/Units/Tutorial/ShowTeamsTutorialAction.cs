using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial
{
    public class ShowTeamsTutorialAction : FlowAction
    {
        // Fields
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager tutorialManager;
        private readonly Royal.Player.Context.Units.SocialManager socialManager;
        private Royal.Scenes.Home.Context.Units.Tutorial.TeamTutorialStep teamTutorialStep;
        private DG.Tweening.Sequence showArrowSequence;
        
        // Methods
        public ShowTeamsTutorialAction()
        {
            var val_5;
            this.tutorialManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.socialManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.SocialManager>(id:  4);
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.add_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.ShowTeamsTutorialAction::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
            this.uiTouchListener.disabler.DisableTouch();
        }
        private void SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)
        {
            var val_2;
            if(this.teamTutorialStep != 1)
            {
                    return;
            }
            
            this.HideTutorialStep1();
            this.ShowTutorialStep2();
            val_2 = null;
            val_2 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.remove_OnSectionChange(value:  new System.Action<Royal.Scenes.Home.Ui.Sections.Section>(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.ShowTeamsTutorialAction::SectionChanged(Royal.Scenes.Home.Ui.Sections.Section section)));
        }
        public override void Execute()
        {
            this.MoveNextStep();
        }
        private void ShowTutorialStep1()
        {
            .<>4__this = this;
            this.uiTouchListener.disabler.EnableTouch();
            this.teamTutorialStep = 1;
            UnityEngine.Vector3 val_2 = Royal.Scenes.Home.Context.Units.Tutorial.ShowTeamsTutorialAction.BringSocialButtonFront();
            .arrowPosition = val_2;
            mem[1152921519565528572] = val_2.y;
            mem[1152921519565528576] = val_2.z;
            this.tutorialManager.CreateBlack(isBlocker:  false).Show(delay:  0f, fadeDuration:  0f, onComplete:  new System.Action(object:  new ShowTeamsTutorialAction.<>c__DisplayClass8_0(), method:  System.Void ShowTeamsTutorialAction.<>c__DisplayClass8_0::<ShowTutorialStep1>b__0()), darkness:  0.8f);
        }
        private void HideTutorialStep1()
        {
            this.tutorialManager.DestroyArrow();
            this.tutorialManager.DestroyDialog();
            Royal.Scenes.Home.Context.Units.Tutorial.ShowTeamsTutorialAction.SendSocialButtonBack();
        }
        private void MoveNextStep()
        {
            if(this.teamTutorialStep == 2)
            {
                    return;
            }
            
            if(this.teamTutorialStep != 1)
            {
                    if(this.teamTutorialStep != 0)
            {
                    throw new System.ArgumentOutOfRangeException();
            }
            
                this.ShowTutorialStep1();
                return;
            }
            
            this.ShowTutorialStep2();
        }
        private void ShowTutorialStep2()
        {
            var val_16;
            ShowTeamsTutorialAction.<>c__DisplayClass11_0 val_1 = new ShowTeamsTutorialAction.<>c__DisplayClass11_0();
            .<>4__this = this;
            val_16 = null;
            val_16 = null;
            Royal.Scenes.Home.Ui.Sections.Section val_2 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            UnityEngine.Vector3 val_4 = (Royal.Scenes.Home.Ui.Sections.Section.__il2cppRuntimeField_typeHierarchy + (Royal.Scenes.Home.Ui.Sections.Social.SocialSection.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 + 40.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            .arrowPosition = val_5;
            mem[1152921519565975164] = val_5.y;
            mem[1152921519565975168] = val_5.z;
            this.tutorialManager.HideBlack();
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            this.showArrowSequence = val_6;
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_6, interval:  2f);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.showArrowSequence, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ShowTeamsTutorialAction.<>c__DisplayClass11_0::<ShowTutorialStep2>b__0()));
            DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ShowTeamsTutorialAction.<>c__DisplayClass11_0::<ShowTutorialStep2>b__1());
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.showArrowSequence, action:  val_10);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_12 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            bool val_13 = val_12.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_14 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_12.layer, order = val_12.order, sortEverything = val_13}, offset:  10);
            val_10.add_OnJoinButtonClicked(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Context.Units.Tutorial.ShowTeamsTutorialAction::HideTutorialStep2()));
            val_10.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_12.layer, order = val_12.order, sortEverything = val_13});
        }
        private void HideTutorialStep2()
        {
            var val_1;
            this.socialManager = 0;
            this.tutorialManager.DestroyBlack();
            this.tutorialManager.DestroyArrow();
            val_1 = 0;
            if(this.showArrowSequence != null)
            {
                    val_1 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.showArrowSequence, complete:  false);
                this.showArrowSequence = 0;
            }
            
            this.Complete();
        }
        private static UnityEngine.Vector3 BringSocialButtonFront()
        {
            var val_9;
            var val_10;
            val_9 = null;
            val_9 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            val_10 = null;
            val_10 = null;
            typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 72.sortingLayerID = val_1.layer;
            typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 72.sortingOrder = (typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 72.sortingOrder) + (val_1.layer >> 32);
            UnityEngine.Vector3 val_6 = typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 80.transform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  1.7f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        private static void SendSocialButtonBack()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            val_6 = null;
            val_6 = null;
            typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 72.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId;
            typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 72.sortingOrder = (typeof(Royal.Scenes.Home.Ui.HomeUi).__il2cppRuntimeField_28 + 72.sortingOrder) - (val_1.layer >> 32);
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
        
        }
    
    }

}
