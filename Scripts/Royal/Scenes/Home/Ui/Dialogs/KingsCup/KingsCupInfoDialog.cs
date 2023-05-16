using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.KingsCup
{
    public abstract class KingsCupInfoDialog : UiDialog, ICounter
    {
        // Fields
        public UnityEngine.TextAsset kingWithCupAsset;
        public UnityEngine.SpriteRenderer kingWithCup;
        public TMPro.TextMeshPro buttonText;
        public TMPro.TextMeshPro remainingText;
        public Royal.Infrastructure.Utils.Time.CountdownAnimation countdownAnimation;
        protected bool timerTextFinished;
        protected Royal.Player.Context.Units.KingsCupManager kingsCupManager;
        
        // Methods
        private void Awake()
        {
            var val_3;
            this.kingWithCup.sprite = Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ToSprite(textAsset:  this.kingWithCupAsset, width:  9, height:  244, format:  4);
            this.kingsCupManager = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.KingsCupManager>(id:  7);
            this.UpdateSeconds();
            val_3 = null;
            val_3 = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.AddCounter(counter:  this, toBeginning:  false);
        }
        private void Start()
        {
            string val_5;
            Royal.Scenes.Start.Context.Units.Flow.FlowManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            if(val_1.HasAutoActionInTheFlow != true)
            {
                    if(val_1.IsInnerFlowExecuting() == false)
            {
                goto label_5;
            }
            
            }
            
            val_5 = "Continue";
            goto label_6;
            label_5:
            val_5 = "Play";
            label_6:
            this.buttonText.text = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  val_5);
        }
        public void UpdateSeconds()
        {
            if(this.timerTextFinished != false)
            {
                    this = ???;
            }
            else
            {
                    if((val_11 + 88.RemainingTimeInMs) < 1000)
            {
                    val_11 + 64.alignment = 2;
                string val_2 = Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  "Finished");
                this = 1;
            }
            else
            {
                    string val_3 = Royal.Infrastructure.Utils.Time.TimeUtil.GetRemainingTimeInFormatWithHours(totalSeconds:  18446744073709551);
                if(((val_11 + 64.Chars[2]) & 65535) == (':'))
            {
                    val_11 + 64.alignment = 1;
            }
            
            }
            
                val_11 + 72.Rotate();
            }
        
        }
        public override void OnClose(System.Action dialogClosed)
        {
            null = null;
            Royal.Scenes.Home.Ui.HomeUi.__il2cppRuntimeField_this_arg.RemoveCounter(counter:  this);
            this.OnClose(dialogClosed:  dialogClosed);
        }
        protected KingsCupInfoDialog()
        {
        
        }
    
    }

}
