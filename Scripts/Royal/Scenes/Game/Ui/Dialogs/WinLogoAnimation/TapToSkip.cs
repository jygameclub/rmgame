using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation
{
    public class TapToSkip : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform root;
        public TMPro.TextMeshPro tapToSkipText;
        public UnityEngine.BoxCollider2D tapCollider;
        private Royal.Scenes.Game.Ui.Dialogs.WinLogoAnimation.TapToSkip.TapToSkipState tapToSkipState;
        private bool didClickSkip;
        private Royal.Player.Context.Data.Session.UserActiveLevelData levelData;
        
        // Methods
        public void Hide()
        {
            this.tapToSkipState = 1;
            this.tapCollider.enabled = false;
            this.tapToSkipText.enabled = false;
        }
        public void EnableSkipWithoutText()
        {
            this.levelData = Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_namespaze;
            this.EnableTapCollider();
        }
        public void ShowSkipText()
        {
            this.ArrangeTapTextPosition();
            int val_12 = this.levelData.number;
            if(val_12 > 30)
            {
                    return;
            }
            
            val_12 = val_12 - 1;
            if(val_12 < 2)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.root.transform.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.tapToSkipText.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.tapToSkipText.enabled = true;
            I2.Loc.LocalizedString val_5 = I2.Loc.LocalizedString.op_Implicit(term:  "Tap to skip");
            this.tapToSkipText.text = I2.Loc.LocalizedString.op_Implicit(s:  new I2.Loc.LocalizedString() {mRTL_IgnoreArabicFix = false, mRTL_ConvertNumbers = false, m_DontLocalizeParameters = false});
            UnityEngine.Color val_9 = this.tapToSkipText.color;
            this.tapToSkipText.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = 0f};
            this.AnimateTapToSkipText();
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  this.tapToSkipText, endValue:  1f, duration:  0.33f), ease:  1);
        }
        private void AnimateTapToSkipText()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.1f);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapToSkipText.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.7f), ease:  4));
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.tapToSkipText.transform, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0.7f), ease:  4));
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Sequence>(t:  val_1, loops:  0);
        }
        private void ArrangeTapTextPosition()
        {
            null = null;
            UnityEngine.Vector3 val_1 = Royal.Scenes.Game.Ui.GameUi.__il2cppRuntimeField_byval_arg.GetTopCenterPosition();
            UnityEngine.Vector3 val_3 = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.CellGridManager>(contextId:  2).GetGridBottomCenterPosition();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
            this.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private bool IsInFirstTwoLevels()
        {
            if(this.levelData != null)
            {
                    int val_2 = this.levelData.number;
                val_2 = val_2 - 1;
                return (bool)(val_2 < 2) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        private bool ShouldShowTapToSkipText()
        {
            if(this.levelData != null)
            {
                    return (bool)(((this.levelData.number - 1) > 1) ? 1 : 0) & ((this.levelData.number < 31) ? 1 : 0);
            }
            
            throw new NullReferenceException();
        }
        private void EnableTapCollider()
        {
            this.tapToSkipState = 0;
            if(this.tapCollider != null)
            {
                    this.tapCollider.enabled = true;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void TapToSkipClicked()
        {
            if(this.tapToSkipState != 0)
            {
                    return;
            }
            
            if((Royal.Scenes.Game.Levels.LevelContext.Has(contextId:  33)) != false)
            {
                    Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.RemainingMoves.RemainingMovesManager>(contextId:  33).TriggerTapToSkipClick();
            }
            
            this.tapToSkipState = 2;
        }
        public TapToSkip()
        {
        
        }
    
    }

}
