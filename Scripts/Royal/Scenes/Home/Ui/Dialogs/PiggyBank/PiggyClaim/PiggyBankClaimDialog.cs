using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyClaim
{
    public class PiggyBankClaimDialog : UiDialog
    {
        // Fields
        public UnityEngine.Transform background;
        public UnityEngine.SpriteRenderer animatingPiggy;
        public UnityEngine.Animator piggyAnimator;
        public TMPro.TextMeshPro coinText;
        
        // Methods
        private void Awake()
        {
            float val_6;
            if((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1).IsDeviceWide()) != false)
            {
                    val_6 = val_1.cameraWidth;
                float val_3 = Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.GetWidthScale(width:  val_6);
            }
            else
            {
                    val_6 = val_1.cameraHeight;
                float val_4 = Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.GetHeightScale(height:  val_6);
            }
            
            this.background.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.Invoke(methodName:  "PlayPiggyBreakSfx", time:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  8f));
        }
        public void OnClaimClicked()
        {
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Dialogs.PiggyBank.ShowPiggyBankStatusDialogAction(disableTouch:  true, newPiggy:  true, fromAnotherDialog:  true));
            val_1.Push(action:  new Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.PlayCoinCollectAnimationAction(type:  1, forceDisableTouch:  false));
            goto typeof(Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyClaim.PiggyBankClaimDialog).__il2cppRuntimeField_250;
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Transform val_2 = this.transform;
            val_2.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
            val_2.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        }
        public void SetCoinAmount(int coinAmount)
        {
            this.coinText.text = coinAmount.ToString();
        }
        public void PlayPiggyBreakSfx()
        {
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16).PlaySound(type:  225, offset:  0.04f);
        }
        public PiggyBankClaimDialog()
        {
        
        }
    
    }

}
