using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.Touch
{
    public class FrogSwapAction : SwapAction
    {
        // Methods
        public FrogSwapAction(Royal.Scenes.Game.Mechanics.Matches.MatchManager matchManager, Royal.Scenes.Game.Levels.Units.Combo.ComboManager comboManager, Royal.Scenes.Game.Levels.Units.MoveManager moveManager, Royal.Scenes.Game.Levels.Units.Touch.LevelTouchManager levelTouchManager)
        {
        
        }
        public void StartFrogSwapAnimation(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel from, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel to, System.Action postSwapAction, Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView frogItemView)
        {
            mem[1152921523972862296] = from;
            mem[1152921523972862304] = to;
            if((this.ShouldPlaySwapAnimation(ignoreMatchRequirement:  true)) == false)
            {
                    return;
            }
            
            this.PlayFrogSwapAnimation(postSwapAction:  postSwapAction, frogItemView:  frogItemView);
        }
        private void PlayFrogSwapAnimation(System.Action postSwapAction, Royal.Scenes.Game.Mechanics.Items.FrogItem.View.FrogItemView frogItemView)
        {
            Royal.Scenes.Game.Levels.Units.Touch.FrogSwapAction val_12;
            int val_14;
            val_12 = this;
            .<>4__this = val_12;
            .postSwapAction = postSwapAction;
            bool val_2 = HasTouchBlockingItem();
            if(val_2 != false)
            {
                    if(HasTouchBlockingItem() != false)
            {
                    this.DoInstantFrogSwap(postSwapAction:  (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].postSwapAction);
                return;
            }
            
            }
            
            val_2.PlaySfx(type:  186, offset:  0.04f);
            .fromItem = mem[68719476760] + 24;
            .toItem = mem[68719476760] + 24 + 32 + 16 + 24;
            mem[1152921523973048976] = 1;
            .fromCellTransform = mem[68719476760] + 24 + 32 + 16 + 24 + 56.transform;
            .toCellTransform = mem[68719476760] + 24 + 32 + 16 + 24 + 56.transform;
            .fromItemView = (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItem;
            (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItem.FreezeFall();
            (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItem.FreezeFall();
            .topItem = 0;
            .fromSorting = (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItemView;
            mem[1152921523973089208] = typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_208;
            if(((FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].toItem) != null)
            {
                    if(((FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItemView) != null)
            {
                goto label_25;
            }
            
            }
            
            label_25:
            if(((FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].toItem) != null)
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromSorting, order = (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromSorting, sortEverything = X23}, offset:  -2);
                bool val_7 = val_6.sortEverything & 4294967295;
                val_14 = val_6.layer;
                if(( & 1) != 0)
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItemView, order = (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].fromItemView, sortEverything = (typeof(Royal.Scenes.Game.Mechanics.Items.Config.ItemView).__il2cppRuntimeField_208 & 4294967295)}, offset:  -2);
                val_14 = val_8.layer;
                (FrogSwapAction.<>c__DisplayClass2_0)[1152921523973089152].toItem.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_14, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295}, allowOtherSortingUpdates:  false);
            }
            
            }
            
            System.Action val_10 = null;
            val_12 = val_10;
            val_10 = new System.Action(object:  new FrogSwapAction.<>c__DisplayClass2_0(), method:  System.Void FrogSwapAction.<>c__DisplayClass2_0::<PlayFrogSwapAnimation>b__0());
            frogItemView.AutoSwapStarted(onFrogReadyToJump:  val_10);
        }
        private void DoInstantFrogSwap(System.Action postSwapAction)
        {
            var val_8 = mem[-6917529027641081840] + 24;
            UnityEngine.Vector3 val_3 = mem[-6917529027641081840] + 24 + 32 + 16 + 24 + 56.transform.localPosition;
            val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_6 = mem[-6917529027641081840] + 24 + 32 + 16 + 24 + 56.transform.localPosition;
            mem[-6917529027641081840] + 24 + 32 + 16 + 24.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            var val_7 = mem[-6917529027641081840] + 24 + 184;
            val_7 = val_7 - 1;
            val_8 = val_7;
            if(postSwapAction == null)
            {
                    return;
            }
            
            postSwapAction.Invoke();
        }
    
    }

}
