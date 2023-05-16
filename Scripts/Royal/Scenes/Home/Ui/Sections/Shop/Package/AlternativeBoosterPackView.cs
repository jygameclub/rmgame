using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Shop.Package
{
    public class AlternativeBoosterPackView : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject inGameBoosters;
        public UnityEngine.GameObject prelevelBoosters;
        public UnityEngine.GameObject hammer;
        public UnityEngine.GameObject cannon;
        public UnityEngine.GameObject arrow;
        public UnityEngine.GameObject jesterHat;
        public UnityEngine.GameObject lightball;
        public UnityEngine.GameObject tnt;
        public UnityEngine.GameObject rocket;
        public UnityEngine.GameObject timer;
        public UnityEngine.SpriteRenderer inGameBoostersDefaultBackground;
        public UnityEngine.SpriteRenderer inGameBoostersSpecialOfferBackground;
        public UnityEngine.SpriteRenderer preLevelBoostersDefaultBackground;
        public UnityEngine.SpriteRenderer preLevelBoostersSpecialOfferBackground;
        public TMPro.TextMeshPro alternativeBoosterPackPrelevelDurationText;
        public UnityEngine.Transform hammerXSign;
        public UnityEngine.Transform cannonXSign;
        public UnityEngine.Transform arrowXSign;
        public UnityEngine.Transform jesterHatXSign;
        public TMPro.TextMeshPro hammerCountText;
        public TMPro.TextMeshPro cannonCountText;
        public TMPro.TextMeshPro arrowCountText;
        public TMPro.TextMeshPro jesterHatCountText;
        private bool hasUnlimitedLives;
        
        // Methods
        public void Prepare(Royal.Scenes.Home.Ui.Sections.Shop.Package.ShopPackageConfig config)
        {
            this.gameObject.SetActive(value:  true);
            this.hasUnlimitedLives = (mem[1152921519034611500] > 0) ? 1 : 0;
            this.PrepareBooster(boosterText:  this.hammerCountText, boosterCount:  config.arrowAmount, xSign:  this.hammerXSign);
            this.PrepareBooster(boosterText:  this.cannonCountText, boosterCount:  config.jesterHatAmount, xSign:  this.cannonXSign);
            this.PrepareBooster(boosterText:  this.arrowCountText, boosterCount:  config.rocketAmount, xSign:  this.arrowXSign);
            this.PrepareBooster(boosterText:  this.jesterHatCountText, boosterCount:  config.rocketMinutes, xSign:  this.jesterHatXSign);
            this.alternativeBoosterPackPrelevelDurationText.text = this.GetLocalizedTimeText(timeInMinutes:  config.isSpecialItemAlternative);
            if(this.hasUnlimitedLives != true)
            {
                    this.SetBoostersPositionForLargeBackgrounds();
            }
            
            this.inGameBoostersDefaultBackground.gameObject.SetActive(value:  (135 == 0) ? 1 : 0);
            this.inGameBoostersSpecialOfferBackground.gameObject.SetActive(value:  (135 != 0) ? 1 : 0);
            this.preLevelBoostersDefaultBackground.gameObject.SetActive(value:  (135 == 0) ? 1 : 0);
            this.preLevelBoostersSpecialOfferBackground.gameObject.SetActive(value:  (135 != 0) ? 1 : 0);
        }
        private void PrepareBooster(TMPro.TextMeshPro boosterText, int boosterCount, UnityEngine.Transform xSign)
        {
            var val_21;
            float val_22;
            float val_23;
            val_21 = boosterCount;
            if(this.hasUnlimitedLives != false)
            {
                    UnityEngine.Transform val_1 = boosterText.transform;
                UnityEngine.Vector3 val_2 = val_1.localPosition;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.left;
                val_22 = 0.1f;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  val_22);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                val_1.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Vector3 val_6 = xSign.localPosition;
                val_23 = val_6.y;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_22);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_23, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                xSign.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            }
            
            if(val_21 >= 10)
            {
                    boosterText.fontSize = 4f;
                UnityEngine.Transform val_10 = boosterText.transform;
                val_21 = val_10;
                UnityEngine.Vector3 val_11 = val_10.localPosition;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.left;
                val_22 = 0.175f;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_22);
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                val_21.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                UnityEngine.Vector3 val_15 = xSign.localPosition;
                val_23 = val_15.y;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.left;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  val_22);
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_23, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
                xSign.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
                string val_19 = boosterCount.ToString();
            }
            
            boosterText.text = boosterCount.ToString();
        }
        public void Start()
        {
            this.AdjustTimerPosition();
        }
        private bool HasUnlimitedLives(int lifeTime)
        {
            return (bool)(lifeTime > 0) ? 1 : 0;
        }
        private string GetLocalizedTimeText(int timeInMinutes)
        {
            object val_6;
            object val_7;
            object val_8;
            val_6 = timeInMinutes;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isArabic != false)
            {
                    int val_6 = 0;
                val_6 = val_6 + val_6;
                val_6 = (val_6 >> 5) + (val_6 >> 31);
                val_7 = val_6;
                val_8 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h");
                return (string)val_7 + val_7;
            }
            
            int val_7 = 0;
            val_7 = val_7 + val_6;
            val_7 = (val_7 >> 5) + (val_7 >> 31);
            val_6 = val_7;
            val_7 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "h");
            val_8 = val_6;
            return (string)val_7 + val_7;
        }
        private void SetBoostersPositionForLargeBackgrounds()
        {
            this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.inGameBoosters.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.prelevelBoosters.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.jesterHat.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.arrow.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.cannon.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.hammer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.lightball.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.tnt.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.rocket.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.timer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  2.08f, y:  0.7425f);
            this.alternativeBoosterPackPrelevelDurationText.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            this.alternativeBoosterPackPrelevelDurationText.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.inGameBoostersDefaultBackground.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.inGameBoostersSpecialOfferBackground.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.preLevelBoostersDefaultBackground.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.preLevelBoostersSpecialOfferBackground.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  0.62f, y:  0f);
            UnityEngine.Vector2 val_21 = this.inGameBoostersDefaultBackground.size;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            this.inGameBoostersDefaultBackground.size = new UnityEngine.Vector2() {x = val_22.x, y = val_22.y};
            UnityEngine.Vector2 val_23 = this.inGameBoostersSpecialOfferBackground.size;
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            this.inGameBoostersSpecialOfferBackground.size = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  0.69f, y:  0f);
            UnityEngine.Vector2 val_26 = this.preLevelBoostersDefaultBackground.size;
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            this.preLevelBoostersDefaultBackground.size = new UnityEngine.Vector2() {x = val_27.x, y = val_27.y};
            UnityEngine.Vector2 val_28 = this.preLevelBoostersSpecialOfferBackground.size;
            UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            this.preLevelBoostersSpecialOfferBackground.size = new UnityEngine.Vector2() {x = val_29.x, y = val_29.y};
        }
        private void AdjustTimerPosition()
        {
            var val_14;
            float val_15;
            val_14 = this;
            val_15 = this.alternativeBoosterPackPrelevelDurationText.renderedWidth;
            UnityEngine.Rect val_3 = this.alternativeBoosterPackPrelevelDurationText.rectTransform.rect;
            if(val_15 >= 0)
            {
                    return;
            }
            
            UnityEngine.Rect val_5 = this.alternativeBoosterPackPrelevelDurationText.rectTransform.rect;
            UnityEngine.Transform val_7 = this.timer.transform;
            val_14 = val_7;
            UnityEngine.Vector3 val_9 = val_7.localPosition;
            val_15 = val_9.x;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_5.m_XMin - this.alternativeBoosterPackPrelevelDurationText.renderedWidth);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  2f);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_14.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        public AlternativeBoosterPackView()
        {
        
        }
    
    }

}
