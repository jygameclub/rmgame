using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.RemainingMoves
{
    public class RemainingMovesItemReplacer
    {
        // Fields
        public const float Duration = 0.6;
        public const float MoveDelay = 0.25;
        private UnityEngine.Vector3 movesPosition;
        private TMPro.TextMeshPro movesText;
        private UnityEngine.Coroutine sendMovesRoutine;
        private System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.ReplaceData> moveRoutines;
        private int startMoves;
        private int replacedMoves;
        private UnityEngine.Transform topUiTransform;
        public static float startXOffset;
        public static float startYOffset;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator iterator;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private System.Action onComplete;
        private bool isCompleteCalled;
        private bool isSkipped;
        
        // Methods
        public RemainingMovesItemReplacer()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.startMoves = Royal.Player.Context.Data.Session.__il2cppRuntimeField_40;
        }
        public void SendMoves(float startDelay, System.Action onComplete)
        {
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_4;
            var val_5;
            var val_10;
            if(this.isSkipped == false)
            {
                goto label_1;
            }
            
            label_3:
            onComplete.Invoke();
            return;
            label_1:
            if(this.startMoves == 0)
            {
                goto label_3;
            }
            
            this.isCompleteCalled = false;
            this.onComplete = onComplete;
            val_10 = null;
            val_10 = null;
            this.movesText = null;
            val_10 = null;
            val_10 = null;
            this.topUiTransform = transform;
            this.moveRoutines = new System.Collections.Generic.Dictionary<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel, Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.ReplaceData>();
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_3 = this.gridManager.GetIterator(iteratorType:  0);
            this.iterator = val_4;
            mem[1152921519913036616] = val_5;
            UnityEngine.Vector3 val_7 = this.movesText.transform.position;
            this.movesPosition = val_7;
            mem[1152921519913036532] = val_7.y;
            mem[1152921519913036536] = val_7.z;
            this.sendMovesRoutine = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.SendAllMoves(startDelay:  startDelay));
        }
        public void SkipClicked()
        {
            this.isSkipped = true;
            if(this.isCompleteCalled == true)
            {
                    return;
            }
            
            if(this.onComplete == null)
            {
                    return;
            }
            
            Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  this.sendMovesRoutine);
            Dictionary.Enumerator<TKey, TValue> val_1 = this.moveRoutines.GetEnumerator();
            label_10:
            if(((-1873511192) & 1) == 0)
            {
                goto label_6;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Game.Context.GameContext.ManualStopCoroutine(coroutine:  11993091);
            goto label_10;
            label_6:
            0.Dispose();
            this.movesText.text = "0";
            this.isCompleteCalled = true;
            this.onComplete.Invoke();
        }
        public void SkipClickedImmediately()
        {
            null = null;
            this.movesText = null;
            goto Royal.Scenes.Game.Ui.__il2cppRuntimeField_38 + 1360;
        }
        private System.Collections.IEnumerator SendAllMoves(float startDelay)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .startDelay = startDelay;
            return (System.Collections.IEnumerator)new RemainingMovesItemReplacer.<SendAllMoves>d__23();
        }
        private System.Collections.IEnumerator SendMove(Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.ReplaceData replaceData, int index)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .replaceData = replaceData;
            .index = index;
            return (System.Collections.IEnumerator)new RemainingMovesItemReplacer.<SendMove>d__24();
        }
        public Royal.Scenes.Game.Mechanics.Board.Cell.CellModel GiveRandomCellWithMatchItem(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType)
        {
            System.Collections.Generic.List<T> val_11;
            var val_12;
            object val_13;
            object val_14;
            var val_15;
            var val_16;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> val_1 = null;
            val_11 = val_1;
            val_1 = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>();
            val_12 = 0;
            val_13 = 1;
            goto label_19;
            label_21:
            if((this.moveRoutines.ContainsKey(key:  X24)) == true)
            {
                goto label_19;
            }
            
            if(matchType == 0)
            {
                goto label_10;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = X24 + 32.CurrentItem;
            var val_4 = (val_3 == 0) ? 0 : (val_3);
            if(val_3 == null)
            {
                goto label_7;
            }
            
            if((((val_3 == null ? 0 : val_3 + 24) != matchType) ? 1 : 0) != 0)
            {
                goto label_19;
            }
            
            goto label_10;
            label_7:
            if(1 != 0)
            {
                goto label_19;
            }
            
            label_10:
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_6 = X24 + 32.CurrentItem;
            var val_7 = (val_6 == 0) ? (val_12) : (val_6);
            if(val_6 != null)
            {
                    val_14 = 0;
            }
            else
            {
                    val_14 = 0;
            }
            
            val_13 = 1;
            if((System.Object.Equals(objA:  val_13, objB:  val_14)) != false)
            {
                    if((X24 + 64.HasTouchBlockingItem()) != true)
            {
                    val_1.Add(item:  X24);
            }
            
            }
            
            label_19:
            if(this.iterator != 0)
            {
                goto label_21;
            }
            
            if((public System.Void System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>::Add(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel item)) != 0)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_10 = this.randomManager.GetRandomItemFromList<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(list:  val_1);
                return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_15;
            }
            
            val_11 = public static T[] System.Array::Empty<System.Object>();
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_16 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_16 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  5, log:  "There are no available cells to select random", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            val_15 = 0;
            return (Royal.Scenes.Game.Mechanics.Board.Cell.CellModel)val_15;
        }
        private void PlayMoveHitParticles(UnityEngine.Vector3 position)
        {
            Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesHitParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesHitParticles>(poolId:  71, activate:  true);
            val_1.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            val_1.Play();
        }
        private void ReplaceWithSpecialItem(Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.ReplaceData replaceData, int index)
        {
            int val_3 = this.replacedMoves;
            val_3 = val_3 + 1;
            this.replacedMoves = val_3;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = replaceData.cell.CurrentItem;
            val_1.itemMediator.ClearFromAllRegisteredCells();
            replaceData = this.CreateSpecialItemAtCell(cell:  replaceData.cell, index:  index);
        }
        protected Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel CreateSpecialItemAtCell(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, int index)
        {
            Royal.Scenes.Game.Utils.LevelParser.TiledId val_1 = this.SelectItem();
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_11 = this.itemFactory.itemCreator.CreateItemAt(tiledId:  val_1, position:  new UnityEngine.Vector3());
            if(val_11 == 3)
            {
                    UnityEngine.Vector3 val_3 = cell.GetViewPosition();
                SpecialItemCreated(createdItem:  val_11, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, animationDelayInFrames:  17);
                val_11 = 2;
            }
            
            UnityEngine.Vector3 val_5 = cell.GetViewPosition();
            TryCollectMadness(matchType:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 56.MatchTypeToCollect, originPosition:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, count:  5, animationDelayInFrames:  12, createdItem:  0, remainingMoves:  true);
            bool val_8 = SetCurrentItem(item:  val_11).SetNextItem(item:  val_11).SetTargetItem(item:  val_11);
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView val_9 = val_11.GetSpecialItemView();
            UnityEngine.Vector3 val_10 = cell.GetViewPosition();
            this.PlayMoveHitParticles(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            if(val_1 != 40)
            {
                    return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel)val_11;
            }
            
            return (Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel)val_11;
        }
        protected Royal.Scenes.Game.Utils.LevelParser.TiledId SelectItem()
        {
            var val_5;
            if((Royal.Player.Context.Data.Session.__il2cppRuntimeField_70 + 56.GetRemainingMoveReplaceItem()) == 3)
            {
                    val_5 = 10;
                return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(this.randomManager.NextBool() != true) ? 30 : 20;
            }
            
            if(this.randomManager.NextBool() == false)
            {
                    return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(this.randomManager.NextBool() != true) ? 30 : 20;
            }
            
            val_5 = 40;
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(this.randomManager.NextBool() != true) ? 30 : 20;
        }
        public int GetNotReplacedMovesCount()
        {
            return (int)this.startMoves - this.replacedMoves;
        }
        private static RemainingMovesItemReplacer()
        {
            Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer.startXOffset = 0.1f;
            Royal.Scenes.Game.Ui.Dialogs.RemainingMoves.RemainingMovesItemReplacer.startYOffset = 0.1f;
        }
    
    }

}
