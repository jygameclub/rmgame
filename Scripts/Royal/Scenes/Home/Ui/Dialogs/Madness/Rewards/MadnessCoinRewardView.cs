using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.Madness.Rewards
{
    public class MadnessCoinRewardView : MadnessRewardView
    {
        // Methods
        public override DG.Tweening.Sequence PlayCollectAnimation(Royal.Player.Context.Units.MadnessStep stepConfig)
        {
            .<>4__this = this;
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            .reward = stepConfig.r[0];
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  0f, duration:  0.2f), ease:  26));
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  new MadnessCoinRewardView.<>c__DisplayClass0_0(), method:  System.Void MadnessCoinRewardView.<>c__DisplayClass0_0::<PlayCollectAnimation>b__0()));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  2.5f);
            return val_2;
        }
        private void PlayCoinCollectAnimation(int coins)
        {
            Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg.AddCoin(coins:  coins);
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(original:  UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.CoinCollect.CoinCollectAnimation>(path:  "CoinCollectAnimation")).Play(data:  Royal.Player.Context.Data.Session.UserSessionData.__il2cppRuntimeField_byval_arg + 40, startPosition:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public MadnessCoinRewardView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
