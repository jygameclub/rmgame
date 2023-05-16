using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatCoinCollectAnimation : MonoBehaviour
    {
        // Fields
        public UnityEngine.ParticleSystem hitParticles;
        public TMPro.TextMeshPro amountText;
        private int <CoinAmount>k__BackingField;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView> spawnedItems;
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper coinHelper;
        private int spawnCount;
        private const int AnimationAmount = 5;
        private Royal.Player.Context.Data.Session.BeforeAfterData coinData;
        
        // Properties
        public int CoinAmount { get; set; }
        
        // Methods
        public int get_CoinAmount()
        {
            return (int)this.<CoinAmount>k__BackingField;
        }
        private void set_CoinAmount(int value)
        {
            this.<CoinAmount>k__BackingField = value;
        }
        public void Play(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper coinHelper, int coinAmount, UnityEngine.Vector3 startPosition)
        {
            this.coinHelper = coinHelper;
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.<CoinAmount>k__BackingField = coinAmount;
            this.spawnCount = 0;
            this.spawnedItems = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(capacity:  0);
            .before = (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - coinAmount);
            .shouldConsume = true;
            .after = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name;
            this.coinData = new Royal.Player.Context.Data.Session.BeforeAfterData();
            this.PlayAmountAnimation(amount:  coinAmount, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            this.PlayCollectAnimation(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
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
        }
        private void PlayCollectAnimation(UnityEngine.Vector3 startPosition)
        {
            .<>4__this = this;
            UnityEngine.Vector3 val_3 = this.transform.position;
            .collectPosition = val_3;
            mem[1152921518996834836] = val_3.y;
            mem[1152921518996834840] = val_3.z;
            this.Invoke(methodName:  "PlayCoinAppearSound", time:  0.1f);
            if(Royal.Infrastructure.Utils.Native.DeviceHelper.IsLowEnd != false)
            {
                    this.itemFactory.InitializeItemSpecificPool<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemAssets>(amount:  1);
            }
            
            if(this.spawnCount < 1)
            {
                    return;
            }
            
            var val_33 = 0;
            do
            {
                ChatCoinCollectAnimation.<>c__DisplayClass15_1 val_5 = new ChatCoinCollectAnimation.<>c__DisplayClass15_1();
                .CS$<>8__locals1 = new ChatCoinCollectAnimation.<>c__DisplayClass15_0();
                int val_32 = this.spawnCount;
                val_32 = val_32 - 1;
                .isLast = (val_33 == val_32) ? 1 : 0;
                Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView val_7 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(poolId:  61, activate:  true);
                .itemView = val_7;
                this.spawnedItems.Add(item:  val_7);
                Royal.Scenes.Game.Mechanics.Sortings.SortingData val_8 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetHomeCoinCollectSorting(index:  0);
                (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.UpdateSortingForAnimation(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = val_8.layer, order = val_8.order, sortEverything = X21}, allowOtherSortingUpdates:  true);
                (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.PlayFlipAnimation(time:  UnityEngine.Random.Range(min:  0f, max:  0.1f));
                UnityEngine.Transform val_12 = (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.transform;
                val_12.position = new UnityEngine.Vector3() {x = startPosition.x + (UnityEngine.Random.Range(min:  -0.75f, max:  0.75f)), y = startPosition.y + (UnityEngine.Random.Range(min:  -0.4f, max:  0.4f)), z = startPosition.z};
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
                val_12.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.baseView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.shadowView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                DG.Tweening.Sequence val_16 = DG.Tweening.DOTween.Sequence();
                float val_17 = 0f * 0.1f;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
                DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_16, atPosition:  val_17, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.transform, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.4f), ease:  3));
                UnityEngine.Color val_23 = UnityEngine.Color.white;
                DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Insert(s:  val_16, atPosition:  val_17, t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  (ChatCoinCollectAnimation.<>c__DisplayClass15_1)[1152921518996847104].itemView.baseView, endValue:  new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a}, duration:  0.3f));
                DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_16, atPosition:  val_17 + 0.3f, callback:  new DG.Tweening.TweenCallback(object:  val_5, method:  System.Void ChatCoinCollectAnimation.<>c__DisplayClass15_1::<PlayCollectAnimation>b__0()));
                DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  val_16, atPosition:  val_17 + 0.4f, callback:  new DG.Tweening.TweenCallback(object:  val_5, method:  System.Void ChatCoinCollectAnimation.<>c__DisplayClass15_1::<PlayCollectAnimation>b__1()));
                val_33 = val_33 + 1;
            }
            while(val_33 < this.spawnCount);
        
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
            
            int val_4 = this.<CoinAmount>k__BackingField;
            val_4 = val_4 - 5;
            this.<CoinAmount>k__BackingField = val_4;
            if(isLast != false)
            {
                    this.<CoinAmount>k__BackingField = 0;
                this.coinData.Consume();
            }
            
            this.audioManager.PlaySound(type:  72, offset:  0.04f);
            this.hitParticles.Play();
            this.coinHelper.OnCoinReached(coinCollectAnimation:  this, isLast:  isLast);
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
        public void RecycleSpawnedItems()
        {
            bool val_1 = true;
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                val_1 = val_1 & 4294967295;
                if(val_2 >= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                this.itemFactory.Recycle<Royal.Scenes.Game.Mechanics.Items.CoinItem.View.CoinItemView>(go:  ((true & 4294967295) + 0) + 32);
                this.spawnedItems.set_Item(index:  0, value:  0);
                val_2 = val_2 + 1;
            }
            while(this.spawnedItems != null);
            
            throw new NullReferenceException();
        }
        public ChatCoinCollectAnimation()
        {
        
        }
    
    }

}
