using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units.ItemCreation
{
    public class SpecialItemCreator
    {
        // Fields
        public static float ItemInitialScale;
        public static float SwellUpScale;
        public static float ItemInitialRotationDegrees;
        public static float SwellUpRotationDegrees;
        public static float SwellUpTime;
        public static float SwellDownTime;
        public static Royal.Infrastructure.Utils.Animation.ManualEasingType SwellUpEasing;
        public static Royal.Infrastructure.Utils.Animation.ManualEasingType SwellDownEasing;
        public static float CreationDelay;
        private readonly Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        public readonly System.Collections.Generic.HashSet<Royal.Scenes.Game.Mechanics.Matches.MatchType> RunningLightballTypes;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager stateManager;
        private Royal.Player.Context.Units.MadnessManager madnessManager;
        
        // Methods
        public SpecialItemCreator(Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            this.itemFactory = itemFactory;
            this.RunningLightballTypes = new System.Collections.Generic.HashSet<Royal.Scenes.Game.Mechanics.Matches.MatchType>();
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.stateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.madnessManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.MadnessManager>(id:  10);
        }
        public void Clear()
        {
            this.RunningLightballTypes.Clear();
        }
        public void CreateSpecialItemForMatchGroup(Royal.Scenes.Game.Mechanics.Matches.MatchGroup group, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell)
        {
            var val_9;
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel val_10;
            var val_11;
            val_9 = 1152921505120743424;
            val_10 = -1988881216;
            if(2306086078 > 5)
            {
                    return;
            }
            
            val_10 = this.itemFactory.itemCreator.CreateItemAtCell(tiledId:  mem[671008632], cell:  cell);
            val_10.SetSpecialItemActive(active:  false);
            val_10.gameObject.SetActive(value:  false);
            val_11 = null;
            val_11 = null;
            UnityEngine.Coroutine val_4 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.CreateItem(model:  val_10, group:  new Royal.Scenes.Game.Mechanics.Matches.MatchGroup() {cell14 = new Royal.Scenes.Game.Mechanics.Matches.Cell14(), explosionCalculated = false, canExplode = false, exists = false}, delay:  Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.CreationDelay));
            if(this.stateManager.IsPlaying() != false)
            {
                    Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemCounts.IncrementItemCreation(id:  val_10);
            }
            
            if(IsStart == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_7 = cell.GetViewPosition();
            SpecialItemCreated(createdItem:  val_10, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, animationDelayInFrames:  17);
            UnityEngine.Vector3 val_8 = cell.GetViewPosition();
            TryCollectMadness(matchType:  268435460, originPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, count:  -1988885408, animationDelayInFrames:  17, createdItem:  val_10, remainingMoves:  false);
        }
        private System.Collections.IEnumerator CreateItem(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel model, Royal.Scenes.Game.Mechanics.Matches.MatchGroup group, float delay)
        {
            .<>1__state = 0;
            .model = model;
            .<>4__this = this;
            .delay = delay;
            return (System.Collections.IEnumerator)new SpecialItemCreator.<CreateItem>d__18();
        }
        public void CreateSpecialItemForBooster(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            var val_6;
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_2 = true.NextItem;
            if(34656.CurrentItem != val_2)
            {
                    val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
                Royal.Infrastructure.Services.Logs.Log.Error(callerClass:  this, logTag:  5, log:  "Couldn\'t create special item for ego.", values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
                return;
            }
            
            Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_3 = val_2.CurrentItem;
            if(val_3 != null)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_4 = val_3.CurrentItem;
            }
            
            this.PlayBoosterAnimation(model:  this.itemFactory.itemCreator.CreateItemAtCell(tiledId:  tiledId, cell:  cell), tiledId:  tiledId);
        }
        public Royal.Scenes.Game.Utils.LevelParser.TiledId SelectSmartRocket(Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint point)
        {
            var val_5;
            point.x = point.x >> 32;
            int val_1 = this.CalculateHorizontalRocketScore(row:  point.x);
            int val_2 = this.CalculateVerticalRocketScore(column:  point.x);
            if(val_1 > val_2)
            {
                    val_5 = 30;
                return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(val_3.random == 1) ? 20 : 30;
            }
            
            if(val_2 > val_1)
            {
                    val_5 = 20;
                return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(val_3.random == 1) ? 20 : 30;
            }
            
            Royal.Scenes.Game.Levels.Units.LevelRandomManager val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)(val_3.random == 1) ? 20 : 30;
        }
        private int CalculateHorizontalRocketScore(int row)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  0, y:  row);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}];
            if(val_2 != null)
            {
                    do
            {
                val_5 = val_2.GetScore() + 0;
            }
            while((X8.Get(type:  3)) != null);
            
                return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        private int CalculateVerticalRocketScore(int column)
        {
            var val_5;
            Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_1 = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint(x:  column, y:  0);
            Royal.Scenes.Game.Mechanics.Board.Cell.CellModel val_2 = this.gridManager.Item[new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_1.x, y = val_1.x}];
            if(val_2 != null)
            {
                    do
            {
                val_5 = val_2.GetScore() + 0;
            }
            while((X8.Get(type:  1)) != null);
            
                return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        public static Royal.Scenes.Start.Context.Units.Audio.AudioClipType DecideSoundForPrelevelBooster(Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            if(tiledId != 10)
            {
                    return (Royal.Scenes.Start.Context.Units.Audio.AudioClipType)(tiledId == 40) ? 255 : 234;
            }
            
            return 216;
        }
        private void PlayBoosterAnimation(Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemModel model, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId)
        {
            var val_25;
            float val_26;
            SpecialItemCreator.<>c__DisplayClass24_0 val_1 = new SpecialItemCreator.<>c__DisplayClass24_0();
            .<>4__this = this;
            .model = model;
            .tiledId = tiledId;
            val_25 = null;
            val_26 = 3f;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  null);
            model.GetSpecialItemView().transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.SpecialItemView val_7 = (SpecialItemCreator.<>c__DisplayClass24_0)[1152921524094126256].model.GetSpecialItemView();
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  DG.Tweening.DOTween.Sequence(), t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (SpecialItemCreator.<>c__DisplayClass24_0)[1152921524094126256].model.transform, endValue:  0.6f, duration:  0.25f), ease:  2)), callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SpecialItemCreator.<>c__DisplayClass24_0::<PlayBoosterAnimation>b__0())), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (SpecialItemCreator.<>c__DisplayClass24_0)[1152921524094126256].model.transform, endValue:  1.3f, duration:  0.1666667f)), t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (SpecialItemCreator.<>c__DisplayClass24_0)[1152921524094126256].model.transform, endValue:  1f, duration:  0.08333334f)), atPosition:  0.25f, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SpecialItemCreator.<>c__DisplayClass24_0::<PlayBoosterAnimation>b__1())), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void SpecialItemCreator.<>c__DisplayClass24_0::<PlayBoosterAnimation>b__2()));
        }
        public void PlayBoosterParticle(UnityEngine.Transform specialItemTransform)
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.PrelevelBoosterHitParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.PrelevelBoosterHitParticles>(poolId:  6, activate:  true);
            val_1.Init(factory:  this.itemFactory, target:  specialItemTransform);
            UnityEngine.Vector3 val_3 = specialItemTransform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_1.Play();
        }
        private void PlayAppearParticle(UnityEngine.Transform specialItemTransform)
        {
            Royal.Scenes.Game.Mechanics.Items.MatchItem.View.SpecialItemCreationParticles val_1 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.MatchItem.View.SpecialItemCreationParticles>(poolId:  5, activate:  true);
            val_1.Init(factory:  this.itemFactory, target:  specialItemTransform);
            UnityEngine.Vector3 val_3 = specialItemTransform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_1.Play();
        }
        private static Royal.Scenes.Game.Utils.LevelParser.TiledId PatternToTiledId(Royal.Scenes.Game.Mechanics.Matches.PatternType type)
        {
            if((type - 2) > 5)
            {
                    return 0;
            }
            
            return (Royal.Scenes.Game.Utils.LevelParser.TiledId)36598912 + ((type - 2)) << 2;
        }
        private static SpecialItemCreator()
        {
            var val_1;
            var val_2;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.ItemInitialScale = 1f;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.SwellUpScale = 1.25f;
            val_1 = null;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.ItemInitialRotationDegrees = 20f;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.SwellUpRotationDegrees = -10f;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.SwellUpTime = 0.15f;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.SwellDownTime = 0.075f;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.SwellUpEasing = 3;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.SwellDownEasing = 2;
            val_2 = null;
            val_2 = null;
            val_1 = 1152921505120743608;
            float val_1 = Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.TargetSpecialItemExplodeTime;
            val_1 = val_1 * Royal.Scenes.Game.Mechanics.Items.MatchItem.View.MatchItemView.ExplodeCompleteRatio;
            Royal.Scenes.Game.Levels.Units.ItemCreation.SpecialItemCreator.CreationDelay = val_1;
        }
    
    }

}
