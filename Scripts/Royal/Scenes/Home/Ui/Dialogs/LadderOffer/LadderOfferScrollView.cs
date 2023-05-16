using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.LadderOffer
{
    public class LadderOfferScrollView : MonoBehaviour
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferUiScrollContent content;
        public Royal.Infrastructure.UiComponents.Scroll.UiVerticalScroll scroll;
        
        // Methods
        public void PrepareContent(Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPopupView popupView)
        {
            Royal.Player.Context.Units.LadderOfferManager val_14;
            int val_15;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            Royal.Player.Context.Units.LadderOfferManager val_2 = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LadderOfferManager>(id:  11);
            val_14 = val_2;
            Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferStep[] val_3 = val_2.GetStepsToShow();
            if(val_3 == null)
            {
                    return;
            }
            
            this.scroll = 0;
            this.content = (val_1.IsDeviceTall() != true) ? -0.07f : -0.01f;
            this.content = -1082130432;
            if(val_3.Length >= 1)
            {
                    var val_15 = 0;
                val_15 = val_3.Length & 4294967295;
                do
            {
                if(null != null)
            {
                    Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView val_8 = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView>(path:  "LadderOfferPackage"), parent:  this.content.transform);
                Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferPackageView val_14 = val_8;
                val_14 = val_8.ToString();
                val_14 = (val_1.IsDeviceTall() != true) ? 0.2f : 0.1f;
                val_14 = popupView;
                if(val_15 == 3)
            {
                    val_14.gameObject.SetActive(value:  false);
            }
            
                .ladderOfferStep = null;
                .ladderOfferScrollView = this;
                this.content.AddData(item:  val_14, data:  new Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferRowData());
                this.content.PlayItemPopupAnimation(item:  val_14, order:  0);
                val_15 = val_3.Length;
            }
            
                val_15 = val_15 + 1;
            }
            while(val_15 < (val_15 << ));
            
            }
            
            val_14 = 1;
            this.content.PlayBuyAnimations();
        }
        public void SetSize(float width, float height)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  width, y:  height);
            X19.size = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public LadderOfferScrollView()
        {
        
        }
    
    }

}
