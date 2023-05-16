using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatCoinCollectHelper
    {
        // Fields
        private readonly System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation> coinAnimations;
        private Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicUserInfoPanel userInfoPanel;
        public static float FadeDuration;
        public static float FadeDiff;
        public static float FadeOutDelay;
        
        // Methods
        public void PlayCoinCollectAnimation(UnityEngine.Vector3 startPosition, int coinAmount)
        {
            if(this.coinAnimations == null)
            {
                    if(this.userInfoPanel == 0)
            {
                    this.CreateUserInfoPanel();
            }
            
                this.FadeOutSocialSection(fadeSeq:  this.userInfoPanel.FadeIn(delay:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDiff), delay:  0f);
                this.userInfoPanel.coinInfoView.coinsText.text = Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name.ToString();
            }
            
            AddCoins(delta:  coinAmount);
            this.coinAnimations.Add(item:  this.CreateCoinCollect(startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z}, coinAmount:  coinAmount));
        }
        public Royal.Scenes.Home.Ui.Sections.Social.SocialSection GetSocialSection()
        {
            null = null;
            Royal.Scenes.Home.Ui.Sections.Section val_1 = Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_element_class.GetSectionFromType(type:  1);
            if(val_1 == null)
            {
                    return (Royal.Scenes.Home.Ui.Sections.Social.SocialSection)val_1;
            }
            
            return (Royal.Scenes.Home.Ui.Sections.Social.SocialSection)val_1;
        }
        private void CreateUserInfoPanel()
        {
            Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicUserInfoPanel val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicUserInfoPanel>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicUserInfoPanel>(path:  "DynamicUserInfoPanel"));
            this.userInfoPanel = val_2;
            UnityEngine.Transform val_3 = val_2.transform;
            UnityEngine.Vector3 val_6 = val_3.GetSocialSection().transform.position;
            val_3.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation CreateCoinCollect(UnityEngine.Vector3 startPosition, int coinAmount)
        {
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation val_2 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation>(path:  "ChatCoinCollectAnimation"));
            UnityEngine.Vector3 val_5 = this.userInfoPanel.coinInfoView.coin.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_2.Play(coinHelper:  this, coinAmount:  coinAmount, startPosition:  new UnityEngine.Vector3() {x = startPosition.x, y = startPosition.y, z = startPosition.z});
            return val_2;
        }
        public void ClearCoinCollectAnimations()
        {
            System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation> val_1;
            bool val_1 = true;
            val_1 = this.coinAnimations;
            var val_2 = 0;
            label_5:
            if(val_2 >= val_1)
            {
                goto label_2;
            }
            
            if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (true + 0) + 32.RecycleSpawnedItems();
            val_1 = this.coinAnimations;
            val_2 = val_2 + 1;
            if(val_1 != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_2:
            val_1.Clear();
        }
        public void OnCoinReached(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation coinCollectAnimation, bool isLast)
        {
            if(isLast != false)
            {
                    bool val_1 = this.coinAnimations.Remove(item:  coinCollectAnimation);
            }
            
            int val_2 = this.CalculateIncomingCoinAmount();
            this.userInfoPanel.coinInfoView.PlayHitAnimation(amount:  (Royal.Player.Context.Data.Persistent.UserInventory.__il2cppRuntimeField_name - val_2)>>0&0xFFFFFFFF);
            if(this.coinAnimations != null)
            {
                    return;
            }
            
            float val_5 = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDiff;
            val_5 = Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeOutDelay + val_5;
            this.FadeInSocialSection(fadeSeq:  this.userInfoPanel.FadeOut(delay:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeOutDelay), delay:  val_5);
        }
        private UnityEngine.GameObject GetSocialSectionTitle()
        {
            Royal.Scenes.Home.Ui.Sections.Social.SocialSection val_1 = this.GetSocialSection();
            return (UnityEngine.GameObject)val_1.socialSectionTitle;
        }
        private int CalculateIncomingCoinAmount()
        {
            var val_1;
            var val_2;
            bool val_1 = true;
            val_1 = 0;
            val_2 = 0;
            do
            {
                if(val_1 >= val_1)
            {
                    return (int)val_2;
            }
            
                if(val_1 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                val_1 = val_1 + 1;
                val_2 = ((true + 0) + 32 + 40) + val_2;
            }
            while(this.coinAnimations != null);
            
            throw new NullReferenceException();
        }
        private void FadeInSocialSection(DG.Tweening.Sequence fadeSeq, float delay)
        {
            var val_5;
            Royal.Scenes.Home.Ui.Sections.Social.SocialSection val_1 = this.GetSocialSection();
            int val_5 = val_2.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                val_5 = null;
                val_5 = null;
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  fadeSeq, atPosition:  delay, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  1152921506484806832, endValue:  1f, duration:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration));
                val_6 = val_6 + 1;
            }
            while(val_6 < (val_2.Length << ));
        
        }
        private void FadeOutSocialSection(DG.Tweening.Sequence fadeSeq, float delay)
        {
            var val_5;
            Royal.Scenes.Home.Ui.Sections.Social.SocialSection val_1 = this.GetSocialSection();
            int val_5 = val_2.Length;
            if(val_5 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                val_5 = null;
                val_5 = null;
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  fadeSeq, atPosition:  delay, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  1152921506484806832, endValue:  0f, duration:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration));
                val_6 = val_6 + 1;
            }
            while(val_6 < (val_2.Length << ));
        
        }
        public ChatCoinCollectHelper()
        {
            this.coinAnimations = new System.Collections.Generic.List<Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectAnimation>();
        }
        private static ChatCoinCollectHelper()
        {
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration = 0.15f;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDiff = 0.075f;
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeOutDelay = 0.5f;
        }
    
    }

}
