using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelWin
{
    public class LevelEndBottomPanel : MonoBehaviour
    {
        // Fields
        private const float DialogPanelHeight = 6.3;
        private const float ClochePanelHeight = 3.4;
        public Royal.Scenes.Game.Ui.Cloche.ClocheProgress clocheProgress;
        private UnityEngine.Vector3 clochePanelTargetPosition;
        
        // Methods
        public void Prepare(UnityEngine.Transform topPanel)
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector3 val_2 = val_1.GetSafeBottomCenterOfCamera();
            mem[1152921519916668900] = val_2.y;
            val_2.y = val_2.y + 3.4f;
            mem[1152921519916668904] = 0;
            this.clochePanelTargetPosition = 0;
            if(val_2.y <= (-6.3f))
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_3.y = val_3.y + 3.4f;
            val_3.y = val_3.y + 6.3f;
            topPanel.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            if(val_1.IsDeviceTall() != false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = topPanel.localPosition;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.3f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            topPanel.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        }
        public void Show(float delay)
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.clochePanelTargetPosition, y = V10.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Sequence>(t:  val_5, delay:  delay);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  0.4f, a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.clochePanelTargetPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.2f, snapping:  false), ease:  3));
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(d:  0.1f, a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.clochePanelTargetPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, duration:  0.13f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_5, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = this.clochePanelTargetPosition, y = val_17.y, z = val_17.z}, duration:  0.08f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_5, action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelWin.LevelEndBottomPanel::<Show>b__5_0()));
        }
        public LevelEndBottomPanel()
        {
        
        }
        private void <Show>b__5_0()
        {
            if(this.clocheProgress != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
    
    }

}
