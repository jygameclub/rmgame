using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem
{
    public class CurtainManager : ICollectManager
    {
        // Fields
        public readonly int id;
        public readonly Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId;
        public readonly Royal.Scenes.Game.Mechanics.Matches.MatchType color;
        public readonly int order;
        public readonly int initialTarget;
        public readonly int width;
        public readonly int height;
        public int leftTarget;
        public int incomingCount;
        public int extraIncomingCount;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemToken itemToken;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private Royal.Scenes.Game.Levels.Units.CellGridManager gridManager;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper curtainHelper;
        private Royal.Scenes.Game.Levels.Units.State.GameStateManager gameStateManager;
        private bool didExplode;
        private Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel[,] curtains;
        private float centerX;
        private float maxY;
        private int minX;
        private int minY;
        private Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager sfxManager;
        
        // Methods
        public CurtainManager(int id, Royal.Scenes.Game.Utils.LevelParser.TiledId tiledId, int order, int initialTarget, int width, int height, int minX, int minY)
        {
            this.id = id;
            this.tiledId = tiledId;
            this.color = Royal.Scenes.Game.Utils.LevelParser.TiledToTypeConverter.GetColorForTiledId(tileId:  tiledId);
            this.order = order;
            this.height = height;
            this.leftTarget = initialTarget;
            this.initialTarget = initialTarget;
            this.width = width;
            this.minX = minX;
            this.minY = minY;
            float val_5 = 0.5f;
            float val_6 = (float)minX;
            val_5 = ((float)width - 1) * val_5;
            val_6 = val_5 + val_6;
            this.curtains = null;
            this.centerX = val_6;
            this.maxY = (float)(height + minY) - 1;
        }
        public void Init()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.gridManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2);
            this.curtainHelper = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainHelper>(contextId:  26);
            this.gameStateManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.State.GameStateManager>(contextId:  14);
            this.sfxManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.Sfx.GameSfxManager>(contextId:  22);
            this.InitCurtainModels();
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemToken val_8 = UnityEngine.Object.Instantiate<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemToken>(original:  this.itemFactory.assetsLibrary.Load<Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.View.CurtainItemAssets>().GetTokenForCurtainLength(length:  this.height), parent:  this.itemFactory.<ItemParent>k__BackingField);
            this.itemToken = val_8;
            val_8.UpdateTokenCount(count:  this.leftTarget, damageDirection:  0);
            this.itemToken.UpdateTokenSprite(matchType:  this.color);
            float val_10 = this.maxY;
            val_10 = val_10 + 0.43f;
            this.itemToken.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void InitCurtainModels()
        {
            var val_3;
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_1 = this.gridManager.GetIterator(iteratorType:  1);
            if(val_3 == 0)
            {
                    return;
            }
            
            do
            {
                Royal.Scenes.Game.Mechanics.Items.Config.StaticItemModel val_4 = val_2 + 64.GetStaticItem(itemType:  3);
                if(val_4 != null)
            {
                    Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint val_6 = val_4.<CurrentCell>k__BackingField.point;
                val_6 = val_6 - this.minX;
                var val_7 = X11 + 16;
                val_7 = ((long)this.minX - this.minY) + (val_7 * (long)val_6);
                this.curtains[val_7] = val_4;
            }
            
            }
            while(val_3 != 0);
        
        }
        public UnityEngine.Vector3 GetCollectPosition()
        {
            UnityEngine.Vector3 val_2 = this.itemToken.token.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public void RecycleTokenView()
        {
            if(this.itemToken == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.itemToken.gameObject);
            this.itemToken = 0;
        }
        public void DecrementTarget()
        {
            int val_2 = this.leftTarget;
            if(val_2 != 0)
            {
                    val_2 = val_2 - 1;
                this.leftTarget = val_2;
                this.incomingCount = this.incomingCount + 1;
                return;
            }
            
            int val_3 = this.extraIncomingCount;
            val_3 = val_3 + 1;
            this.extraIncomingCount = val_3;
        }
        public void ItemReached(bool hitFromLeft)
        {
            int val_4 = this.incomingCount - 1;
            if()
            {
                    this.incomingCount = val_4;
            }
            else
            {
                    int val_3 = this.extraIncomingCount;
                val_3 = val_3 - 1;
                this.extraIncomingCount = val_3;
                val_4 = this.incomingCount;
            }
            
            this.itemToken.UpdateTokenCount(count:  this.leftTarget + val_4, damageDirection:  (hitFromLeft != true) ? 0 : 2);
            if(this.leftTarget != 0)
            {
                    return;
            }
            
            if(this.incomingCount != 0)
            {
                    return;
            }
            
            if(this.extraIncomingCount != 0)
            {
                    return;
            }
            
            this.Hide();
        }
        private int GetDamageDirectionFromHitAngle(float hitAngle)
        {
            if((hitAngle >= (-45f)) && (hitAngle < 0))
            {
                    return 2;
            }
            
            if((hitAngle < 45f) || (hitAngle >= 0))
            {
                    return (int)(hitAngle < 0) ? 4 : 0;
            }
            
            return 3;
        }
        public bool HasTargetLeftVisual()
        {
            int val_2 = this.leftTarget;
            val_2 = this.incomingCount + val_2;
            return (bool)(val_2 > 0) ? 1 : 0;
        }
        public bool HasTargetLeftLogic()
        {
            return (bool)(this.leftTarget > 0) ? 1 : 0;
        }
        private void Explode()
        {
            int val_4;
            int val_5;
            int val_7;
            int val_8;
            this.gameStateManager.OperationFinish(animationId:  11);
            if(this.width >= 1)
            {
                    var val_17 = 0;
                do
            {
                int val_11 = this.height;
                var val_12 = X9 + 16;
                val_11 = val_11 - 1;
                val_12 = (long)val_11 + (val_12 * val_17);
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_13 = this.curtains[val_12];
                this.curtains[(X9 + 16 * 0) + (long)(int)((this.height - 1))][0].<ItemView>k__BackingField.PlayExplodeParticles();
                int val_14 = this.height;
                var val_15 = (X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16;
                val_14 = val_14 - 2;
                val_15 = (long)val_14 + (val_15 * val_17);
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_16 = this.curtains[val_15];
                Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = this.curtains[(X9 + 16 * 0) + (long)(int)((this.height - 1))][0].<ItemView>k__BackingField.CurrentItem;
                if(val_1 != null)
            {
                    val_1.ShowHead();
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 < this.width);
            
            }
            
            this.sfxManager.PlaySfx(type:  97, offset:  0.04f);
            if(this.curtainHelper.OnCurtainReveal != null)
            {
                    this.curtainHelper.OnCurtainReveal.Invoke();
            }
            
            Royal.Scenes.Game.Mechanics.Explode.ExplodeData val_3 = Royal.Scenes.Game.Mechanics.Explode.Exploder.Next(trigger:  22);
            Royal.Scenes.Game.Mechanics.Board.Grid.Iterator.GridIterator val_6 = this.gridManager.GetIterator(iteratorType:  2);
            if(val_8 == 0)
            {
                    return;
            }
            
            do
            {
                if((val_7 + 64.GetStaticItem(itemType:  3)) != null)
            {
                    val_7 = val_4;
                val_8 = val_5;
                bool val_10 = val_7 + 64.ExplodeTopMostAboveItem(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = val_8, y = val_8}, trigger = val_8, id = val_7});
            }
            
            }
            while(val_8 != 0);
        
        }
        public void Hide()
        {
            this.gameStateManager.OperationStart(animationId:  11);
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.sfxManager.PlaySfx(type:  98, offset:  0.04f);
            float val_5 = UnityEngine.Mathf.Lerp(a:  0.2f, b:  0.5f, t:  (float)this.height / 11f);
            float val_7 = ((float)this.height - 1) / val_5;
            val_7 = 0.5f / val_7;
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  this.itemToken.PlayTokenExplode());
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager::<Hide>b__33_0()));
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.MoveCurtain(toHeight:  0f, duration:  val_5, easing:  2));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.HideBottomOfCurtain(duration:  val_7));
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager::<Hide>b__33_1()));
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainManager::Explode()));
        }
        private DG.Tweening.Sequence MoveCurtain(float toHeight, float duration, DG.Tweening.Ease easing)
        {
            var val_22;
            Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_23;
            DG.Tweening.Core.DOGetter<System.Single> val_24;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(this.width < 1)
            {
                    return val_1;
            }
            
            val_22 = 1152921519006167248;
            var val_24 = 0;
            do
            {
                CurtainManager.<>c__DisplayClass34_0 val_2 = new CurtainManager.<>c__DisplayClass34_0();
                int val_22 = this.height;
                var val_23 = X9 + 16;
                val_22 = val_22 - 1;
                val_23 = (long)val_22 + (val_23 * val_24);
                val_23 = this.curtains[val_23];
                .blPart = this.curtains[(X9 + 16 * 0) + (long)(int)((this.height - 1))][0].<ItemView>k__BackingField.curtainBL;
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_2, method:  System.Single CurtainManager.<>c__DisplayClass34_0::<MoveCurtain>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_2, method:  System.Void CurtainManager.<>c__DisplayClass34_0::<MoveCurtain>b__1(float newHeight)), endValue:  toHeight, duration:  duration), ease:  easing));
                .brPart = this.curtains[(X9 + 16 * 0) + (long)(int)((this.height - 1))][0].<ItemView>k__BackingField.curtainBR;
                DG.Tweening.Core.DOGetter<System.Single> val_8 = null;
                val_24 = val_8;
                val_8 = new DG.Tweening.Core.DOGetter<System.Single>(object:  val_2, method:  System.Single CurtainManager.<>c__DisplayClass34_0::<MoveCurtain>b__2());
                DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  val_8, setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_2, method:  System.Void CurtainManager.<>c__DisplayClass34_0::<MoveCurtain>b__3(float newHeight)), endValue:  toHeight, duration:  duration), ease:  easing));
                val_24 = val_24 + 1;
            }
            while(val_24 < this.width);
            
            if(this.width < 1)
            {
                    return val_1;
            }
            
            val_22 = 1152921520048806864;
            do
            {
                int val_25 = this.height;
                var val_26 = (X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16;
                val_25 = val_25 - 1;
                val_26 = (long)val_25 + (val_26 * 0);
                UnityEngine.Vector3 val_14 = this.curtains[val_26].GetViewPosition();
                var val_28 = ((X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16 * 0) + (long)(int)((this.height - 1)) + 16;
                val_28 = val_28 * 0;
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_29 = this.curtains[val_28];
                .bottomCurtain = this.curtains[(((X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16 * 0) + (long)(int)((this.height - 1)) + 16 * 0)][0].<ItemView>k__BackingField;
                val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.curtains[(((X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16 * 0) + (long)(int)((this.height - 1)) + 16 * 0)][0].<ItemView>k__BackingField.transform, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y - toHeight, z = val_14.z}, duration:  duration, snapping:  false), ease:  easing);
                DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  val_24, action:  new DG.Tweening.TweenCallback(object:  new CurtainManager.<>c__DisplayClass34_1(), method:  System.Void CurtainManager.<>c__DisplayClass34_1::<MoveCurtain>b__4())));
                val_23 = 0 + 1;
            }
            while(val_23 < this.width);
            
            return val_1;
        }
        private DG.Tweening.Sequence HideBottomOfCurtain(float duration)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(this.width < 1)
            {
                    return val_1;
            }
            
            var val_13 = 0;
            do
            {
                int val_8 = this.height;
                var val_9 = X9 + 16;
                val_8 = val_8 - 1;
                val_9 = (long)val_8 + (val_9 * val_13);
                UnityEngine.Vector3 val_2 = this.curtains[val_9].GetViewPosition();
                var val_11 = (X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16;
                val_11 = val_11 * val_13;
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_12 = this.curtains[val_11];
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_1, atPosition:  0f, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.curtains[((X9 + 16 * 0) + (long)(int)((this.height - 1)) + 16 * 0)][0].<ItemView>k__BackingField.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y + 0.5f, z = val_2.z}, duration:  duration, snapping:  false), ease:  1));
                val_13 = val_13 + 1;
            }
            while(val_13 < this.width);
            
            return val_1;
        }
        private float GetOriginalSpriteHeight()
        {
            int val_1 = this.height;
            val_1 = val_1 - 1;
            return (float)(float)val_1;
        }
        public void ArrangeSortingForTutorial()
        {
            int val_10 = this.width;
            if(val_10 >= 1)
            {
                    var val_13 = 0;
                do
            {
                if(val_10 >= 1)
            {
                    var val_12 = 0;
                do
            {
                var val_10 = X9 + 16;
                val_10 = val_12 + (val_13 * val_10);
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_11 = this.curtains[val_10];
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X22, y = X22});
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = false}, offset:  val_1.layer >> 32);
                this.curtains[(0 * X9 + 16) + 0][0].<ItemView>k__BackingField.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = X21});
                val_10 = this.width;
                val_12 = val_12 + 1;
            }
            while(val_12 < val_10);
            
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < (val_10 << ));
            
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_5 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainTokenSorting();
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_6 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetTutorialBlackSorting();
            val_6.sortEverything = val_6.sortEverything & 4294967295;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetSortingWithOffset(data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_6.layer, order = val_6.order, sortEverything = val_6.sortEverything}, offset:  val_5.layer >> 32);
            this.itemToken.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = val_8.sortEverything & 4294967295});
        }
        public void ResetSortingAfterTutorial()
        {
            int val_4 = this.width;
            if(val_4 >= 1)
            {
                    var val_7 = 0;
                do
            {
                if(val_4 >= 1)
            {
                    var val_6 = 0;
                do
            {
                var val_4 = X9 + 16;
                val_4 = val_6 + (val_7 * val_4);
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_5 = this.curtains[val_4];
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_1 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainSorting(point:  new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = X21, y = X21});
                this.curtains[(0 * X9 + 16) + 0][0].<ItemView>k__BackingField.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_1.layer, order = val_1.order, sortEverything = false});
                val_4 = this.width;
                val_6 = val_6 + 1;
            }
            while(val_6 < val_4);
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < (val_4 << ));
            
            }
            
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_2 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetCurtainTokenSorting();
            this.itemToken.UpdateSorting(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_2.layer, order = val_2.order, sortEverything = val_2.sortEverything & 4294967295});
        }
        public Royal.Scenes.Start.Context.Units.Audio.AudioClipType GetCollectAudioClipType()
        {
            return 96;
        }
        private void <Hide>b__33_0()
        {
            int val_3;
            this.itemToken.PlayCurtainTokenExplodeParticles();
            this.RecycleTokenView();
            this.sfxManager.PlaySfxInLoop(type:  99);
            val_3 = this.width;
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                if(this.height >= 1)
            {
                    var val_6 = 0;
                do
            {
                var val_3 = this.width + 16;
                val_3 = val_6 + (val_7 * val_3);
                Royal.Scenes.Game.Mechanics.Items.StaticItems.CurtainItem.CurtainItemModel val_4 = this.curtains[val_3];
                this.curtains[(0 * this.width + 16) + 0][0].<ItemView>k__BackingField.ArrangeSortingForRevealAnimation();
                val_4.RevealItemsUnder();
                int val_5 = this.height;
                val_5 = val_5 - 2;
                if(val_6 == val_5)
            {
                    Royal.Scenes.Game.Mechanics.Items.Config.ItemModel val_1 = val_4.CurrentItem;
                if(val_1 != null)
            {
                    val_1.HideHead();
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < this.height);
            
                val_3 = this.width;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < (val_3 << ));
        
        }
        private void <Hide>b__33_1()
        {
            if(this.sfxManager != null)
            {
                    this.sfxManager.StopSoundInLoop(type:  99);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
