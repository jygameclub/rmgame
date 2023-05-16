using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassPurchaseSuccessDialog : UiDialog
    {
        // Fields
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.GoldNickName nickName;
        public UnityEngine.SpriteRenderer kingPicture;
        public UnityEngine.SpriteRenderer picture;
        public UnityEngine.GameObject personalAvatar;
        public TMPro.TextMeshPro infoText;
        public TMPro.TextMeshPro message;
        public UnityEngine.GameObject freeMovesTag;
        public UnityEngine.Transform[] tagObj;
        private Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle royalPassBundle;
        private UnityEngine.GameObject royalPassPurchaseBundledGo;
        
        // Methods
        public void Init(bool showFreeMoves)
        {
            this.LoadPurchaseSuccessBundledPrefab();
            showFreeMoves = showFreeMoves;
            this.freeMovesTag.SetActive(value:  showFreeMoves);
            this.ArrangePersonalInfo();
            this.ArrangeComponents();
        }
        private void LoadPurchaseSuccessBundledPrefab()
        {
            Royal.Scenes.Start.Context.Units.FeatureBundle.RoyalPassBundle val_7;
            Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.FeatureBundle.FeatureBundleManager>(id:  25);
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            Royal.Scenes.Start.Context.Units.FeatureBundle.AFeatureBundle val_2 = val_1.GetBundle(bundleType:  4);
            if(val_2 != null)
            {
                    this.royalPassBundle = val_2;
                val_7 = this.royalPassBundle;
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_7.RoyalPassPurchaseSuccessBundledPrefab, parent:  this.transform);
                this.royalPassPurchaseBundledGo = val_5;
                if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                if((val_5.GetComponent<Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassPurchaseBundledView>()) == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_6.tagObjects == null)
            {
                    throw new NullReferenceException();
            }
            
                if(val_6.tagObjects.Length < 1)
            {
                    return;
            }
            
                do
            {
                if(this.tagObj == null)
            {
                    throw new NullReferenceException();
            }
            
                val_7 = val_6.tagObjects[0];
                if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_7.SetParent(p:  this.tagObj[0]);
            }
            while(1 < val_6.tagObjects.Length);
            
                return;
            }
            
            this.royalPassBundle = new IndexOutOfRangeException();
            throw new NullReferenceException();
        }
        private void ArrangePersonalInfo()
        {
            UnityEngine.Object val_7;
            this.nickName.SetNickName(nickName:  Royal.Player.Context.Units.RoyalPassManager.GetEventNickName(), isGold:  true, borderType:  0);
            val_7 = 0;
            if((Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.IsConnectedFacebook()) != false)
            {
                    val_7 = Royal.Infrastructure.Services.Login.FacebookConnect.LoadProfilePicture(facebookId:  Royal.Player.Context.Data.UserId.__il2cppRuntimeField_byval_arg);
            }
            
            if(val_7 != 0)
            {
                    this.personalAvatar.SetActive(value:  true);
                this.kingPicture.gameObject.SetActive(value:  false);
                this.picture.sprite = val_7;
                return;
            }
            
            this.personalAvatar.SetActive(value:  false);
            this.kingPicture.gameObject.SetActive(value:  true);
        }
        private void ArrangeComponents()
        {
            if(Royal.Infrastructure.Services.Localization.LocalizationHelper.isJapanese == false)
            {
                    return;
            }
            
            this.infoText.enableAutoSizing = false;
            this.infoText.fontSize = 3.5f;
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            var val_2;
            this.OnShow(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            Royal.Infrastructure.Services.Logs.Log.Debug(callerClass:  this, logTag:  4, log:  this.message.text, values:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            float val_3;
            bool val_4;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldCloseOnEscape = true;
            val_0.shouldHideBackground = val_2;
            val_0.backgroundFadeInDuration = val_3;
            val_0.shouldCloseOnTouch = val_4;
            return val_0;
        }
        public override void OnClose(System.Action dialogClosed)
        {
            this.OnClose(dialogClosed:  dialogClosed);
            this.royalPassBundle = 0;
        }
        public RoyalPassPurchaseSuccessDialog()
        {
        
        }
    
    }

}
