using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect
{
    public class CoinCollectAnimation : MonoBehaviour
    {
        // Fields
        private const int Count = 10;
        public UnityEngine.ParticleSystem hitParticles;
        public TMPro.TextMeshPro amountText;
        private Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView coinInfoView;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView> spawnedItems;
        private Royal.Player.Context.Data.Session.BeforeAfterData coinData;
        private int currentCoin;
        private int increment;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager sceneChangeManager;
        private bool isInGameScene;
        
        // Methods
        private void Awake()
        {
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public void Play(Royal.Player.Context.Data.Session.BeforeAfterData data, UnityEngine.Vector3 startPosition)
        {
            var val_10;
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            val_10 = null;
            val_10 = null;
            this.coinInfoView = null;
            UnityEngine.Vector3 val_3 = this.coinInfoView.coin.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.spawnedItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(capacity:  10);
            this.coinData = data;
            int val_10 = data.before;
            this.currentCoin = val_10;
            val_10 = val_10 >> 34;
            val_10 = val_10 + (val_10 >> 63);
            this.increment = val_10;
            this.PlayCollectAnimation(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            this.PlayAmountAnimation(amount:  data.after - val_10, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager val_7 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
            this.sceneChangeManager = val_7;
            val_7.remove_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation::SceneWillLoad(int obj)));
            this.sceneChangeManager.add_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation::SceneWillLoad(int obj)));
        }
        public void Play(Royal.Player.Context.Data.Session.BeforeAfterData data, UnityEngine.Vector3 startPosition, UnityEngine.Vector3 targetPosition, Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.CoinInfoView infoView)
        {
            this.coinInfoView = infoView;
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.isInGameScene = true;
            if(val_2.Length >= 1)
            {
                    var val_11 = 0;
                do
            {
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_4 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGameSceneRewardCoinCollectSorting(index:  232);
                Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.hitParticles.GetComponentsInChildren<UnityEngine.ParticleSystem>(includeInactive:  true)[val_11].GetComponent<UnityEngine.Renderer>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_4.layer, order = val_4.order, sortEverything = true});
                val_11 = val_11 + 1;
            }
            while(val_11 < val_2.Length);
            
            }
            
            this.transform.position = new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z};
            this.spawnedItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(capacity:  10);
            this.coinData = data;
            int val_12 = data.before;
            this.currentCoin = val_12;
            val_12 = val_12 >> 34;
            val_12 = val_12 + (val_12 >> 63);
            this.increment = val_12;
            this.PlayCollectAnimation(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            this.PlayAmountAnimation(amount:  data.after - val_12, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            this.sceneChangeManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Scene.SceneChangeManager>(id:  2);
        }
        private void SceneWillLoad(int obj)
        {
            var val_3;
            this.sceneChangeManager.remove_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation::SceneWillLoad(int obj)));
            this.CancelInvoke(methodName:  "Clear");
            val_3 = 0;
            do
            {
                if(val_3 >= "Clear")
            {
                    return;
            }
            
                if(val_3 >= 47901920)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(("PBEwithMD5andDES-CBC") != 0)
            {
                    this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  "PBEwithMD5andDES-CBC");
            }
            
                val_3 = val_3 + 1;
            }
            while(this.spawnedItems != null);
            
            throw new NullReferenceException();
        }
        private void PlayAmountAnimation(int amount, UnityEngine.Vector3 startPosition)
        {
            this.amountText.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.amountText.transform.position = new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.amountText.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.amountText.text = "<b>+</b>"("<b>+</b>") + amount;
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  1f, duration:  1f));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.25f);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.amountText.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.5f), ease:  3));
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMoveY(target:  this.amountText.transform, endValue:  startPosition.y + 2f, duration:  2f, snapping:  false), ease:  5));
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_5, atPosition:  1.5f, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.amountText, endValue:  0f, duration:  0.5f));
            if(this.isInGameScene == false)
            {
                    return;
            }
            
            this = this.amountText;
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_21 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGameSceneRewardCoinCollectSorting(index:  208);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(textMeshPro:  this, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_21.layer, order = val_21.order, sortEverything = val_21.sortEverything & 4294967295});
        }
        private void PlayCollectAnimation(UnityEngine.Vector3 startPosition)
        {
            var val_33;
            int val_34;
            bool val_35;
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.transform.position;
            .collectPosition = val_3;
            mem[1152921519137993932] = val_3.y;
            mem[1152921519137993936] = val_3.z;
            this.Invoke(methodName:  "PlayCoinAppearSound", time:  0.1f);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    this.itemFactory.InitializeItemSpecificPool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemAssets>(amount:  1);
            }
            
            var val_34 = 0;
            do
            {
                CoinCollectAnimation.<>c__DisplayClass17_1 val_5 = new CoinCollectAnimation.<>c__DisplayClass17_1();
                .CS$<>8__locals1 = new CoinCollectAnimation.<>c__DisplayClass17_0();
                .isLast = (val_34 == 8) ? 1 : 0;
                Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView val_7 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(poolId:  61, activate:  true);
                .itemView = val_7;
                int val_8 = val_34 + 1;
                this.spawnedItems.Add(item:  val_7);
                if(this.isInGameScene != false)
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_9 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetGameSceneRewardCoinCollectSorting(index:  val_8);
                val_33 = 1;
                val_34 = val_9.layer;
                val_35 = X21;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHomeCoinCollectSorting(index:  val_8);
                val_33 = 1;
                val_34 = val_10.layer;
                val_35 = X22;
            }
            
                (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_34, order = val_10.order, sortEverything = val_35}, allowOtherSortingUpdates:  true);
                (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.PlayFlipAnimation(time:  UnityEngine.Random.Range(min:  0f, max:  0.1f));
                UnityEngine.Transform val_14 = (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.transform;
                val_14.position = new UnityEngine.Vector3() {x = startPosition.x + (UnityEngine.Random.Range(min:  -0.75f, max:  0.75f)), y = startPosition.y + (UnityEngine.Random.Range(min:  -0.4f, max:  0.4f)), z = startPosition.z};
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
                val_14.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
                (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.baseView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.shadowView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                DG.Tweening.Sequence val_18 = DG.Tweening.DOTween.Sequence();
                float val_19 = (float)val_8 * 0.1f;
                UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
                DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_18, atPosition:  val_19, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.transform, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.4f), ease:  3));
                UnityEngine.Color val_25 = UnityEngine.Color.white;
                DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_18, atPosition:  val_19, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  (CoinCollectAnimation.<>c__DisplayClass17_1)[1152921519138006192].itemView.baseView, endValue:  new UnityEngine.Color() {r = val_25.r, g = val_25.g, b = val_25.b, a = val_25.a}, duration:  0.3f));
                DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_18, atPosition:  val_19 + 0.3f, callback:  new DG.Tweening.TweenCallback(object:  val_5, method:  System.Void CoinCollectAnimation.<>c__DisplayClass17_1::<PlayCollectAnimation>b__0()));
                DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_18, atPosition:  val_19 + 0.4f, callback:  new DG.Tweening.TweenCallback(object:  val_5, method:  System.Void CoinCollectAnimation.<>c__DisplayClass17_1::<PlayCollectAnimation>b__1()));
                val_34 = val_34 + 1;
            }
            while(val_34 < 9);
        
        }
        private void PlayCoinAppearSound()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  71, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnItemReached(Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView itemView, bool isLast)
        {
            if((this.spawnedItems.Remove(item:  itemView)) == false)
            {
                    return;
            }
            
            if(itemView != 0)
            {
                    this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  itemView);
            }
            
            int val_3 = this.currentCoin;
            val_3 = this.increment + val_3;
            this.currentCoin = val_3;
            if(isLast != false)
            {
                    this.currentCoin = this.coinData.after;
                this.coinData.Consume();
            }
            
            this.audioManager.PlaySound(type:  72, offset:  0.04f);
            this.hitParticles.Play();
            this.coinInfoView.PlayHitAnimation(amount:  this.currentCoin);
            if(isLast == false)
            {
                    return;
            }
            
            this.Invoke(methodName:  "Clear", time:  1f);
        }
        private void Clear()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void OnDestroy()
        {
            this.sceneChangeManager.remove_SceneWillLoad(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation::SceneWillLoad(int obj)));
        }
        public CoinCollectAnimation()
        {
        
        }
    
    }

}
