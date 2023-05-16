using UnityEngine;

namespace Royal.Scenes.Game.Ui.Cloche
{
    public class ClocheView : MonoBehaviour
    {
        // Fields
        public const string ClochePrefab = "ClochePrefab";
        private static readonly int ClocheOpen;
        private static readonly int ClocheClose;
        public Royal.Scenes.Game.Ui.Cloche.ClocheItemView propeller;
        public Royal.Scenes.Game.Ui.Cloche.ClocheItemView rocket;
        public Royal.Scenes.Game.Ui.Cloche.ClocheItemView tnt;
        public Royal.Scenes.Game.Ui.Cloche.ClocheItemView lightball;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private UnityEngine.Animator clocheAnimator;
        
        // Methods
        public System.Collections.IEnumerator Play(int cloche, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellsToSelect, int cellsToSelectIndex, System.Action onComplete)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .cloche = cloche;
            .cellsToSelect = cellsToSelect;
            .cellsToSelectIndex = cellsToSelectIndex;
            .onComplete = onComplete;
            return (System.Collections.IEnumerator)new ClocheView.<Play>d__11();
        }
        private int SelectCellToThrow(System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellsToSelect, int selectIndex)
        {
            int val_4 = selectIndex;
            if((val_4 == 1) || (true <= val_4))
            {
                    return 0;
            }
            
            var val_4 = (long)val_4;
            val_4 = val_4 + 4;
            label_7:
            val_4 = val_4 - 4;
            if(true <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this.gridManager.IsCellReadyToThrowSpecialItem(cell:  true + (((long)(int)(selectIndex) + 4)) << 3)) == true)
            {
                goto label_6;
            }
            
            val_4 = val_4 + 1;
            if((val_4 - 4) < true)
            {
                goto label_7;
            }
            
            return 0;
            label_6:
            var val_3 = val_4 - 4;
            return 0;
        }
        private void PlayClipForCloche(int cloche, bool isEnter)
        {
            var val_2;
            if(cloche == 3)
            {
                goto label_0;
            }
            
            if(cloche == 2)
            {
                goto label_1;
            }
            
            if(cloche != 1)
            {
                    return;
            }
            
            val_2 = 61;
            goto label_6;
            label_1:
            val_2 = 63;
            goto label_6;
            label_0:
            val_2 = 65;
            label_6:
            this.audioManager.PlaySound(type:  ((isEnter & true) != 0) ? (65 + 1) : 65, offset:  0.04f);
        }
        private void PlayThrowClip(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            var val_1;
            if(tiledId > 20)
            {
                goto label_0;
            }
            
            if(tiledId == 10)
            {
                goto label_1;
            }
            
            if(tiledId == 20)
            {
                goto label_5;
            }
            
            return;
            label_0:
            if((tiledId == 30) || (tiledId == 40))
            {
                goto label_5;
            }
            
            if(tiledId != 50)
            {
                    return;
            }
            
            val_1 = 60;
            goto label_10;
            label_5:
            val_1 = 59;
            goto label_10;
            label_1:
            val_1 = 58;
            label_10:
            this.audioManager.PlaySound(type:  58, offset:  0.04f);
        }
        private System.Collections.IEnumerator Throw(Royal.Scenes.Game.Ui.Cloche.ClocheItemView item, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            .<>1__state = 0;
            .cell = cell;
            .<>4__this = this;
            .item = item;
            .tiledId = tiledId;
            return (System.Collections.IEnumerator)new ClocheView.<Throw>d__15();
        }
        private void OnReachedToCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            var val_21;
            var val_22;
            ClocheView.<>c__DisplayClass16_0 val_1 = new ClocheView.<>c__DisplayClass16_0();
            .<>4__this = this;
            cell.UnReserve();
            val_21 = cell;
            val_22 = cell;
            if(cell.HasCurrentItem() != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = cell.CurrentItem;
                val_22 = val_3.itemMediator.NextCell;
                val_21 = val_3.itemMediator.TargetCell;
                val_3.itemMediator.ClearFromAllRegisteredCells();
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = this.itemFactory.itemCreator.CreateItemAt(tiledId:  tiledId, position:  new UnityEngine.Vector3());
            .model = val_6;
            bool val_9 = val_6.SetCurrentItem(item:  val_6).SetNextItem(item:  (ClocheView.<>c__DisplayClass16_0)[1152921519939642976].model).SetTargetItem(item:  (ClocheView.<>c__DisplayClass16_0)[1152921519939642976].model);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  DG.Tweening.DOTween.Sequence(), callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ClocheView.<>c__DisplayClass16_0::<OnReachedToCell>b__0())), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (ClocheView.<>c__DisplayClass16_0)[1152921519939642976].model.transform, endValue:  1.3f, duration:  0.1666667f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (ClocheView.<>c__DisplayClass16_0)[1152921519939642976].model.transform, endValue:  1f, duration:  0.08333334f)), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void ClocheView.<>c__DisplayClass16_0::<OnReachedToCell>b__1()));
        }
        public ClocheView()
        {
        
        }
        private static ClocheView()
        {
            Royal.Scenes.Game.Ui.Cloche.ClocheView.ClocheOpen = UnityEngine.Animator.StringToHash(name:  "Base Layer.ClocheOpen");
            Royal.Scenes.Game.Ui.Cloche.ClocheView.ClocheClose = UnityEngine.Animator.StringToHash(name:  "Base Layer.ClocheClose");
        }
    
    }

}
