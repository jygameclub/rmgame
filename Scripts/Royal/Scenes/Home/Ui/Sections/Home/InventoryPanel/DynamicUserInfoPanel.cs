using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel
{
    public class DynamicUserInfoPanel : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicCoinInfoView coinInfoView;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.LifeInfoView lifeInfoView;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView starInfoView;
        public DG.Tweening.Sequence fadeSeq;
        
        // Methods
        public void Awake()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese != true)
            {
                    if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isKorean == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.RectTransform val_1 = this.lifeInfoView.fullText.rectTransform;
            this = val_1;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  val_2.y);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector2 val_5 = this.sizeDelta;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  1.57936f, y:  val_5.y);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        public DG.Tweening.Sequence FadeIn(float delay)
        {
            var val_10;
            var val_11;
            var val_12;
            if(this.fadeSeq != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.fadeSeq, complete:  false);
            }
            else
            {
                    this.SetAlphaToZeroImmediately();
            }
            
            this.fadeSeq = DG.Tweening.DOTween.Sequence();
            int val_10 = val_2.Length;
            if(val_10 >= 1)
            {
                    val_10 = val_10 & 4294967295;
                do
            {
                val_10 = null;
                val_10 = null;
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.fadeSeq, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  1152921506482587264, endValue:  1f, duration:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration));
                val_11 = 0 + 1;
            }
            while(val_11 < (val_2.Length << ));
            
            }
            
            int val_11 = val_5.Length;
            if(val_11 >= 1)
            {
                    val_11 = val_11 & 4294967295;
                do
            {
                val_12 = null;
                val_12 = null;
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.fadeSeq, atPosition:  delay, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  1152921506482587264, endValue:  1f, duration:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration));
                val_11 = 0 + 1;
            }
            while(val_11 < (val_5.Length << ));
            
            }
            
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.fadeSeq, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicUserInfoPanel::<FadeIn>b__5_0()));
            return (DG.Tweening.Sequence)this.fadeSeq;
        }
        private void SetAlphaToZeroImmediately()
        {
            T val_4;
            if(val_1.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                val_4 = this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true)[val_4];
                UnityEngine.Color val_2 = val_4.color;
                val_4.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = 0f};
                val_4 = val_4 + 1;
            }
            while(val_4 < val_1.Length);
            
            }
            
            if(val_3.Length < 1)
            {
                    return;
            }
            
            do
            {
                T val_5 = this.GetComponentsInChildren<TMPro.TextMeshPro>(includeInactive:  true)[0];
                val_4 = 0 + 1;
            }
            while(val_4 < val_3.Length);
        
        }
        public DG.Tweening.Sequence FadeOut(float delay)
        {
            var val_10;
            var val_11;
            var val_12;
            if(this.fadeSeq != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.fadeSeq, complete:  false);
            }
            
            this.fadeSeq = DG.Tweening.DOTween.Sequence();
            int val_10 = val_2.Length;
            if(val_10 >= 1)
            {
                    val_10 = val_10 & 4294967295;
                do
            {
                val_10 = null;
                val_10 = null;
                DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.fadeSeq, atPosition:  delay, t:  DG.Tweening.DOTweenModuleSprite.DOFade(target:  1152921506482587264, endValue:  0f, duration:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration));
                val_11 = 0 + 1;
            }
            while(val_11 < (val_2.Length << ));
            
            }
            
            int val_11 = val_5.Length;
            if(val_11 >= 1)
            {
                    val_11 = val_11 & 4294967295;
                do
            {
                val_12 = null;
                val_12 = null;
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.fadeSeq, atPosition:  delay, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  1152921506482587264, endValue:  0f, duration:  Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatCoinCollectHelper.FadeDuration));
                val_11 = 0 + 1;
            }
            while(val_11 < (val_5.Length << ));
            
            }
            
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.fadeSeq, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.DynamicUserInfoPanel::<FadeOut>b__7_0()));
            return (DG.Tweening.Sequence)this.fadeSeq;
        }
        public DynamicUserInfoPanel()
        {
        
        }
        private void <FadeIn>b__5_0()
        {
            this.fadeSeq = 0;
        }
        private void <FadeOut>b__7_0()
        {
            this.fadeSeq = 0;
        }
    
    }

}
