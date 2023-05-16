using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferPopupView : UiPopup, IBackable, ICounter
    {
        // Fields
        public TMPro.TextMeshPro subtitleText;
        public UnityEngine.RectTransform subtitleRect;
        public UnityEngine.GameObject header;
        public UnityEngine.SpriteRenderer mainBackground;
        public UnityEngine.BoxCollider2D mainBackgroundBoxCollider2D;
        public UnityEngine.Transform[] headerTransforms;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        public UnityEngine.TextAsset ladderOfferHeaderImageAsset;
        public UnityEngine.SpriteRenderer ladderOfferHeaderImage;
        private Royal.Infrastructure.UiComponents.Touch.UiTouchListener uiTouchListener;
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferScrollView ladderOfferScrollView;
        private Royal.Scenes.Home.Ui.Sections.Shop.PurchaseStrategy purchaseStrategy;
        private Royal.Player.Context.Units.LadderOfferManager ladderOfferManager;
        private bool timerTextFinished;
        private System.Collections.Generic.List<Royal.Infrastructure.Utils.Time.CountdownAnimation> itemCountdownAnimations;
        
        // Methods
        protected void Awake()
        {
            var val_31;
            var val_32;
            this.ladderOfferHeaderImage.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.ladderOfferHeaderImageAsset, width:  116, height:  102, format:  4);
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.uiTouchListener = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Touch.UiTouchListener>(id:  15);
            this.ladderOfferManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackgroundBoxCollider2D.size = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  this.camManager.cameraWidth, y:  this.camManager.cameraHeight);
            this.mainBackground.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            this.PrepareHeader();
            this.ArrangeSubtitle();
            this.ladderOfferScrollView = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferScrollView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferScrollView>(path:  "LadderOfferScroll"), parent:  this.transform);
            Royal.Scenes.Game.Mechanics.Sortings.SortingData val_10 = Royal.Scenes.Game.Mechanics.Sortings.Sorting.GetLadderOfferUiSorting();
            UnityEngine.Rendering.SortingGroup val_11 = this.ladderOfferScrollView.GetComponent<UnityEngine.Rendering.SortingGroup>();
            val_11.sortingLayerID = val_10.layer;
            val_11.sortingOrder = val_10.layer >> 32;
            UnityEngine.Transform val_13 = this.subtitleText.transform;
            UnityEngine.Vector3 val_14 = val_13.localPosition;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  (this.camManager.IsDeviceTall() != true) ? 0f : 0.2f);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_13.localPosition = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            float val_21 = (this.camManager.IsDeviceTall() != true) ? 0.4f : 0.3f;
            UnityEngine.Vector3 val_23 = this.subtitleText.transform.position;
            float val_31 = val_23.y;
            UnityEngine.Vector3 val_24 = this.camManager.GetBottomCenterOfCamera();
            val_21 = val_31 - val_21;
            val_31 = val_21 - val_24.y;
            this.ladderOfferScrollView.SetSize(width:  this.camManager.cameraWidth, height:  val_31);
            float val_32 = -0.5f;
            val_32 = val_31 * val_32;
            UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  0f, y:  val_21 + val_32);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            this.ladderOfferScrollView.transform.localPosition = new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z};
            this.UpdateSeconds();
            this.ladderOfferScrollView.PrepareContent(popupView:  this);
            this.itemCountdownAnimations = this.ladderOfferScrollView.content.GetCountDownAnimations();
            val_31 = null;
            val_31 = null;
            if((Royal.Scenes.Home.Context.HomeContext.<Controller>k__BackingField) == 0)
            {
                    return;
            }
            
            val_32 = null;
            val_32 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
        }
        private void PrepareHeader()
        {
            var val_10;
            if(this.camManager.IsDeviceTall() == true)
            {
                goto label_4;
            }
            
            val_10 = 0;
            label_15:
            if(val_10 >= this.headerTransforms.Length)
            {
                goto label_4;
            }
            
            UnityEngine.Transform val_10 = this.headerTransforms[val_10];
            UnityEngine.Vector3 val_2 = val_10.localPosition;
            if(val_10 != 0)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.5f);
            }
            else
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_10.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_10 = val_10 + 1;
            if(this.headerTransforms != null)
            {
                goto label_15;
            }
            
            throw new NullReferenceException();
            label_4:
            UnityEngine.Vector3 val_9 = this.transform.position;
            float val_11 = this.camManager.cameraHeight;
            val_11 = val_11 * 0.5f;
            this.header.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void ArrangeSubtitle()
        {
            UnityEngine.RectTransform val_3;
            float val_4;
            val_3 = this;
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isGerman == false)
            {
                    return;
            }
            
            val_3 = this.subtitleRect;
            if(this.camManager.IsDeviceTall() != false)
            {
                    val_4 = 0.95f;
            }
            else
            {
                    val_4 = 0.79f;
            }
            
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  8.778792f, y:  val_4);
            val_3.sizeDelta = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        public void Close()
        {
            if(this.ladderOfferManager != null)
            {
                    if(this.ladderOfferManager.isBuyAnimationsPlaying != false)
            {
                    return;
            }
            
                this.Hide();
                return;
            }
            
            throw new NullReferenceException();
        }
        public void Hide()
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.Destroy();
        }
        public void PressBack()
        {
            this.Close();
        }
        public void UpdateSeconds()
        {
            if(this.timerTextFinished != false)
            {
                    this.Close();
                return;
            }
            
            if(this.ladderOfferManager.RemainingTimeInMs < 1000)
            {
                    this.remainingText.alignment = 2;
                this.remainingText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this.timerTextFinished = true;
            }
            else
            {
                    this.remainingText.text = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if((this.remainingText.text.Chars[2] & 65535) == (':'))
            {
                    this.remainingText.alignment = 1;
            }
            
            }
            
            this.countdownAnimation.Rotate();
            if(this.itemCountdownAnimations == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_7 = this.itemCountdownAnimations.GetEnumerator();
            label_22:
            if((1932058856 & 1) == 0)
            {
                goto label_17;
            }
            
            if(0 == 0)
            {
                goto label_22;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.Rotate();
            goto label_22;
            label_17:
            0.Dispose();
        }
        public LadderOfferPopupView()
        {
        
        }
    
    }

}
