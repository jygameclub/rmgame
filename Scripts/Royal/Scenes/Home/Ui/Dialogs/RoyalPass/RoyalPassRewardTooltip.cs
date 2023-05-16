using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassRewardTooltip : UiPanel
    {
        // Fields
        public TMPro.TextMeshPro tooltipText;
        public UnityEngine.GameObject upArrow;
        public UnityEngine.GameObject downArrow;
        public UnityEngine.SpriteRenderer[] containerBackgrounds;
        public UnityEngine.RectTransform infoText;
        public UnityEngine.Transform container;
        public UnityEngine.BoxCollider2D tooltipCollider;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.TooltipType tooltipType;
        
        // Methods
        public void PrepareFromFrame()
        {
            this.tooltipType = 3;
            this.SetColliderSize(isFree:  false);
            this.SetTooltipVerticalDirection();
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_1.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = this.container.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.container.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.tooltipText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPassTooltipLockedStageNumber");
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  6.6f, y:  2.197585f);
            this.infoText.sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            var val_10 = 0;
            do
            {
                if(val_10 >= this.containerBackgrounds.Length)
            {
                    return;
            }
            
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  2.3f, y:  1.934401f);
                this.containerBackgrounds[val_10].size = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
                val_10 = val_10 + 1;
            }
            while(this.containerBackgrounds != null);
            
            throw new NullReferenceException();
        }
        public void Prepare(bool isClaimed, bool isCompletedStep, bool isFree, bool hasRoyalPass)
        {
            UnityEngine.RectTransform val_18;
            var val_19;
            bool val_20;
            float val_21;
            val_18 = this;
            if(isClaimed == false)
            {
                goto label_1;
            }
            
            val_19 = 4;
            if(this != null)
            {
                goto label_5;
            }
            
            label_1:
            if(isCompletedStep == false)
            {
                goto label_4;
            }
            
            var val_1 = (hasRoyalPass != true) ? 2 : 0;
            if(this != null)
            {
                goto label_5;
            }
            
            label_4:
            label_5:
            val_20 = isFree;
            this.tooltipType = ((isFree | hasRoyalPass) != true) ? (1 + 1) : 1;
            this.SetColliderSize(isFree:  val_20);
            this.SetTooltipVerticalDirection();
            this.SetHorizontalPosition(isFree:  val_20);
            if(this.tooltipType > 4)
            {
                    return;
            }
            
            var val_17 = 36595852 + (this.tooltipType) << 2;
            val_17 = val_17 + 36595852;
            goto (36595852 + (this.tooltipType) << 2 + 36595852);
            label_14:
            if( >= this.containerBackgrounds.Length)
            {
                goto label_11;
            }
            
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  null, y:  1.934401f);
            this.containerBackgrounds[].size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
             =  + 1;
            if(this.containerBackgrounds != null)
            {
                goto label_14;
            }
            
            this.tooltipText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPassTooltipUnpurchasedLocked");
            val_21 = 1.934401f;
            val_20 = 0;
            label_21:
            if(val_20 >= this.containerBackgrounds.Length)
            {
                goto label_18;
            }
            
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  3.5f, y:  val_21);
            this.containerBackgrounds[val_20].size = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            val_20 = val_20 + 1;
            if(this.containerBackgrounds != null)
            {
                goto label_21;
            }
            
            this.tooltipText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPassTooltipPurchasedLocked");
            val_21 = 3.479099f;
            val_20 = 0;
            do
            {
                if(val_20 >= this.containerBackgrounds.Length)
            {
                    return;
            }
            
                UnityEngine.SpriteRenderer val_20 = this.containerBackgrounds[val_20];
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_21, y:  1.934401f);
                val_20.size = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
                val_20 = val_20 + 1;
            }
            while(this.containerBackgrounds != null);
            
            this.tooltipText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "RoyalPassTooltipClaimed");
            var val_22 = 0;
            label_35:
            if(val_22 >= this.containerBackgrounds.Length)
            {
                goto label_32;
            }
            
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  2.62f, y:  1.934401f);
            this.containerBackgrounds[val_22].size = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
            val_22 = val_22 + 1;
            if(this.containerBackgrounds != null)
            {
                goto label_35;
            }
            
            label_11:
            val_18 = this.infoText;
            goto label_37;
            label_18:
            val_18 = this.infoText;
            label_37:
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  10.6f, y:  2.197585f);
            val_18.sizeDelta = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            return;
            label_32:
            val_20 = this.infoText;
            UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  7.5f, y:  2.197585f);
            val_20.sizeDelta = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
            val_18 = this.container;
            var val_14 = (val_20 != 1) ? -0.72f : 0.72f;
            UnityEngine.Vector3 val_15 = val_18.localPosition;
            val_21 = val_15.x;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_18.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        public void SetTooltipVerticalDirection()
        {
            float val_17;
            UnityEngine.Transform val_18;
            float val_19;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).GetSafeTopCenterOfCamera();
            float val_17 = -11f;
            val_17 = val_4.y + val_17;
            if(val_3.y <= val_17)
            {
                goto label_6;
            }
            
            this.upArrow.SetActive(value:  true);
            this.downArrow.SetActive(value:  false);
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = val_5.localPosition;
            val_17 = val_6.z;
            if(this.tooltipType != 3)
            {
                goto label_9;
            }
            
            goto label_10;
            label_6:
            this.upArrow.SetActive(value:  false);
            this.downArrow.SetActive(value:  true);
            UnityEngine.Transform val_7 = this.transform;
            UnityEngine.Vector3 val_8 = val_7.localPosition;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            val_18 = this.container;
            UnityEngine.Vector3 val_10 = val_18.localPosition;
            val_19 = val_10.x;
            val_17 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19, y = val_10.y, z = val_17}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_18.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            return;
            label_9:
            label_10:
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_17}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_5.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_18 = this.tooltipCollider;
            UnityEngine.Vector2 val_13 = val_18.offset;
            val_19 = val_13.x;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, d:  1.3f);
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_19, y = val_13.y}, b:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_18.offset = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        }
        public void SetHorizontalPosition(bool isFree)
        {
            bool val_3 = isFree;
            if(val_3 == false)
            {
                    return;
            }
            
            val_3 = this.container;
            UnityEngine.Vector3 val_1 = val_3.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        private void SetColliderSize(bool isFree)
        {
            if(this.tooltipType > 4)
            {
                    return;
            }
            
            var val_8 = 36595888 + (this.tooltipType) << 2;
            val_8 = val_8 + 36595888;
            goto (36595888 + (this.tooltipType) << 2 + 36595888);
        }
        public RoyalPassRewardTooltip()
        {
        
        }
    
    }

}
