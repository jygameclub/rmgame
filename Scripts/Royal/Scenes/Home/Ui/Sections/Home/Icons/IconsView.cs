using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.Icons
{
    public class IconsView : MonoBehaviour, ICounter
    {
        // Fields
        private const float XOffset = 3.33;
        private const float AnimationOffset = 4.255;
        public Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.UserInfoPanel userInfoPanel;
        public UnityEngine.Transform leftColumn;
        public UnityEngine.Transform rightColumn;
        public Royal.Scenes.Home.Ui.Dialogs.KingsCup.KingsCupIcon kingsCup;
        public Royal.Scenes.Home.Ui.Dialogs.TeamBattle.TeamBattleIcon teamBattle;
        public Royal.Scenes.Home.Ui.Dialogs.PiggyBank.PiggyBankIcon piggyBank;
        public Royal.Scenes.Home.Ui.Dialogs.LadderOffer.LadderOfferIcon ladderOffer;
        public Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassIcon royalPass;
        private UnityEngine.Vector3 userInfoPosition;
        public Royal.Scenes.Home.Ui.Sections.Home.Buttons.LeagueInfoButton leagueInfoButton;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        
        // Methods
        public void ManualStart(Royal.Scenes.Home.Ui.Sections.Home.HomeSection homeSection)
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.leagueInfoButton = homeSection.leagueButton;
            homeSection.AddCounter(counter:  this, toBeginning:  false);
            this.UpdateSeconds();
        }
        public bool IsAnyIconVisible()
        {
            if((this.piggyBank & 1) != 0)
            {
                    return true;
            }
            
            if((this.kingsCup & 1) != 0)
            {
                    return true;
            }
            
            if((this.teamBattle & 1) != 0)
            {
                    return true;
            }
            
            if((this.ladderOffer & 1) != 0)
            {
                    return true;
            }
        
        }
        public void UpdateSeconds()
        {
            this.flowManager.DisableNextActionOnPush();
            if(this.leagueInfoButton.isActive != false)
            {
                    this.leagueInfoButton.UpdateTexts();
            }
            
            bool val_1 = this.userInfoPanel.madnessBarInfoView.UpdateIcon();
            this.flowManager.EnableNextActionOnPush();
            if(((this.teamBattle.UpdateIcon() | this.kingsCup.UpdateIcon()) == true) || ((this.royalPass.UpdateIcon() | this.ladderOffer.UpdateIcon()) == true))
            {
                goto label_11;
            }
            
            if(val_1 == false)
            {
                    return;
            }
            
            label_13:
            this.UpdatePosition();
            return;
            label_11:
            this.UpdateIconPositions();
            if(val_1 == true)
            {
                goto label_13;
            }
        
        }
        private void UpdatePosition()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  2f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.userInfoPosition, y = V9.16B, z = V8.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = this.userInfoPanel.GetOffsetForIcons();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            this.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public void PreparePosition(UnityEngine.Vector3 userInfoPosition, bool willAnimateIn)
        {
            this.userInfoPosition = userInfoPosition;
            mem[1152921519142379356] = userInfoPosition.y;
            mem[1152921519142379360] = userInfoPosition.z;
            this.UpdatePosition();
            float val_1 = (willAnimateIn != true) ? 7.585f : 3.33f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_1);
            this.leftColumn.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_1);
            this.rightColumn.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void UpdateIconPositions()
        {
            UnityEngine.Transform val_1 = this.teamBattle.transform;
            if((this.kingsCup & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  2.3f);
            if(val_1 != null)
            {
                goto label_6;
            }
            
            label_3:
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            label_6:
            val_1.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Transform val_5 = this.ladderOffer.transform;
            if((this.royalPass & 1) == 0)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  2.3f);
            if(val_5 != null)
            {
                goto label_16;
            }
            
            label_13:
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            label_16:
            val_5.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        public void AnimateIn()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
            Royal.Scenes.Home.Ui.Sections.Home.Icons.IconsView.AnimateColumnIn(transform1:  this.leftColumn, direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            Royal.Scenes.Home.Ui.Sections.Home.Icons.IconsView.AnimateColumnIn(transform1:  this.rightColumn, direction:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        private static void AnimateColumnIn(UnityEngine.Transform transform1, UnityEngine.Vector3 direction)
        {
            UnityEngine.Vector3 val_1 = transform1.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, d:  4.255f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  transform1, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f, snapping:  false), ease:  27), delay:  0.17f);
        }
        public void AnimateOut()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.left;
            Royal.Scenes.Home.Ui.Sections.Home.Icons.IconsView.AnimateColumnOut(transform1:  this.leftColumn, direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            Royal.Scenes.Home.Ui.Sections.Home.Icons.IconsView.AnimateColumnOut(transform1:  this.rightColumn, direction:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void HideWithoutAnimation()
        {
            UnityEngine.Vector3 val_1 = this.leftColumn.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  4.255f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.leftColumn.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = this.rightColumn.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  4.255f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            this.rightColumn.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        private static void AnimateColumnOut(UnityEngine.Transform transform1, UnityEngine.Vector3 direction)
        {
            UnityEngine.Vector3 val_1 = transform1.localPosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, d:  4.255f);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  transform1, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.3f, snapping:  false), ease:  26);
        }
        public IconsView()
        {
        
        }
    
    }

}
