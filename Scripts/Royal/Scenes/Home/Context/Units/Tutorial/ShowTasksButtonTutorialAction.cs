using UnityEngine;

namespace Royal.Scenes.Home.Context.Units.Tutorial
{
    public class ShowTasksButtonTutorialAction : FlowAction
    {
        // Fields
        private readonly Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private readonly Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager tutorialManager;
        
        // Methods
        public ShowTasksButtonTutorialAction()
        {
            this.tutorialManager = Royal.Scenes.Home.Context.HomeContext.Get<Royal.Scenes.Home.Context.Units.Tutorial.HomeTutorialManager>(id:  3);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            val_2.disabler.DisableTouch();
            throw new NullReferenceException();
        }
        public override void Execute()
        {
            .<>4__this = this;
            UnityEngine.Vector3 val_2 = Royal.Scenes.Home.Context.Units.Tutorial.ShowTasksButtonTutorialAction.BringTasksButtonFront();
            .arrowPosition = val_2;
            mem[1152921519563926540] = val_2.y;
            mem[1152921519563926544] = val_2.z;
            val_2.y = val_2.y + 3.8f;
            .dialogPosition = 0;
            mem[1152921519563926556] = 0;
            this.tutorialManager.CreateBlack(isBlocker:  false).Show(delay:  0f, fadeDuration:  0f, onComplete:  new System.Action(object:  new ShowTasksButtonTutorialAction.<>c__DisplayClass3_0(), method:  System.Void ShowTasksButtonTutorialAction.<>c__DisplayClass3_0::<Execute>b__0()), darkness:  0.7f);
            this.uiTouchListener.disabler.EnableTouch();
        }
        private static UnityEngine.Vector3 BringTasksButtonFront()
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.GetComponentInChildren<Royal.Infrastructure.UiComponents.Button.UiButton>().ZIndex = -15;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            int val_4 = val_2.layer >> 32;
            if(val_3.Length >= 1)
            {
                    var val_14 = 0;
                do
            {
                T val_13 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_14];
                val_13.sortingLayerID = val_2.layer;
                val_13.sortingOrder = val_13.sortingOrder + val_4;
                val_14 = val_14 + 1;
            }
            while(val_14 < val_3.Length);
            
            }
            
            if(val_7.Length >= 1)
            {
                    var val_16 = 0;
                do
            {
                T val_15 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.GetComponentsInChildren<TMPro.TextMeshPro>()[val_16];
                val_15.sortingLayerID = val_2.layer;
                val_15.sortingOrder = val_15.sortingOrder + val_4;
                val_16 = val_16 + 1;
            }
            while(val_16 < val_7.Length);
            
            }
            
            UnityEngine.Vector3 val_10 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  1.7f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        }
        private static void SendTasksButtonBack()
        {
            var val_10;
            T val_11;
            val_10 = null;
            val_10 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.GetComponentInChildren<Royal.Infrastructure.UiComponents.Button.UiButton>().ZIndex = 4;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialArrowSorting();
            val_11 = val_2.layer;
            int val_4 = val_11 >> 32;
            if(val_3.Length >= 1)
            {
                    var val_10 = 0;
                do
            {
                val_11 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.GetComponentsInChildren<UnityEngine.SpriteRenderer>()[val_10];
                val_11.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId;
                val_11.sortingOrder = val_11.sortingOrder - val_4;
                val_10 = val_10 + 1;
            }
            while(val_10 < val_3.Length);
            
            }
            
            if(val_7.Length < 1)
            {
                    return;
            }
            
            do
            {
                T val_11 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg + 152.GetComponentsInChildren<TMPro.TextMeshPro>()[0];
                val_11.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.UiLayerId;
                val_11.sortingOrder = val_11.sortingOrder - val_4;
                val_11 = 0 + 1;
            }
            while(val_11 < val_7.Length);
        
        }
        public override void Cancel(Royal.Scenes.Start.Context.Units.Flow.FlowAction interruptAction)
        {
            this.tutorialManager.DestroyArrow();
            this.tutorialManager.DestroyDialog();
            this.tutorialManager.DestroyBlack();
            Royal.Scenes.Home.Context.Units.Tutorial.ShowTasksButtonTutorialAction.SendTasksButtonBack();
            this.Complete();
        }
    
    }

}
