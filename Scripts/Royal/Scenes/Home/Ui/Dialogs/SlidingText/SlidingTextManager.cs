using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.SlidingText
{
    public static class SlidingTextManager
    {
        // Fields
        public const float DefaultWidth = 7;
        private static Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView SlidingText;
        private static DG.Tweening.Sequence TextSequence;
        
        // Methods
        public static void ShowConnectionProblem()
        {
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.ShowText(text:  Royal.Infrastructure.Utils.String.StringExtensions.Localize(text:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Services.Backend.Http.BackendHttpService>(id:  7).IsInMaintenance(checkAgain:  true)) != true) ? "MaintenanceText" : "Connection Problem"), position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, width:  7f, speed:  1f);
        }
        public static void ShowText(string text, UnityEngine.Vector3 position, float width = 7, float speed = 1)
        {
            float val_38;
            float val_39;
            TMPro.TextMeshPro val_40;
            var val_41;
            DG.Tweening.TweenCallback val_43;
            var val_44;
            DG.Tweening.TweenCallback val_46;
            val_38 = position.y;
            val_39 = position.x;
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView val_1 = Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.LoadSlidingText();
            val_1.UpdateText(text:  text, width:  width);
            if(Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, complete:  false);
            }
            
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_39, y = val_38, z = position.z}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) != false)
            {
                    Royal.Infrastructure.Contexts.Units.CameraManager val_3 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
                UnityEngine.Vector3 val_5 = val_3.camera.transform.position;
                val_39 = val_5.x;
                float val_37 = val_3.cameraHeight;
                val_37 = val_37 * (-0.125f);
                val_38 = val_5.y + val_37;
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            val_1.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            val_1.transform.position = new UnityEngine.Vector3() {x = val_39, y = val_38, z = 0f};
            UnityEngine.Color val_9 = UnityEngine.Color.white;
            val_1.textView.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
            val_1.shadowView.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_39, y = val_38, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_1.transform, endValue:  1f, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  7f)), ease:  3));
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  val_1.transform, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  (Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  100f)) / speed, snapping:  false), ease:  3));
            float val_23 = Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  50f);
            val_23 = val_23 / speed;
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, interval:  val_23);
            val_40 = val_1.textView;
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  val_40, endValue:  0f, duration:  (Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  28f)) / speed));
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Join(s:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, t:  DG.Tweening.ShortcutExtensionsTMPText.DOFade(target:  val_1.shadowView, endValue:  0f, duration:  (Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  28f)) / speed));
            val_41 = null;
            val_41 = null;
            val_43 = SlidingTextManager.<>c.<>9__4_0;
            if(val_43 == null)
            {
                    DG.Tweening.TweenCallback val_33 = null;
                val_43 = val_33;
                val_33 = new DG.Tweening.TweenCallback(object:  SlidingTextManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SlidingTextManager.<>c::<ShowText>b__4_0());
                SlidingTextManager.<>c.<>9__4_0 = val_43;
            }
            
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, action:  val_33);
            val_44 = null;
            val_44 = null;
            val_46 = SlidingTextManager.<>c.<>9__4_1;
            if(val_46 == null)
            {
                    DG.Tweening.TweenCallback val_35 = null;
                val_46 = val_35;
                val_35 = new DG.Tweening.TweenCallback(object:  SlidingTextManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SlidingTextManager.<>c::<ShowText>b__4_1());
                SlidingTextManager.<>c.<>9__4_1 = val_46;
            }
            
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, action:  val_35);
        }
        public static void HideText()
        {
            if(Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.SlidingText == 0)
            {
                    return;
            }
            
            if(Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence != null)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.TextSequence, complete:  false);
            }
            
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.__il2cppRuntimeField_static_fields.gameObject.SetActive(value:  false);
        }
        private static Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView LoadSlidingText()
        {
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView val_5 = Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.SlidingText;
            if(val_5 != 0)
            {
                    Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.SlidingText.gameObject.SetActive(value:  true);
                return (Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView)Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.SlidingText;
            }
            
            val_5 = UnityEngine.Resources.Load<Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView>(path:  "SlidingTextPrefab");
            Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.SlidingText = UnityEngine.Object.Instantiate<Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView>(original:  val_5);
            return (Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextView)Royal.Scenes.Home.Ui.Dialogs.SlidingText.SlidingTextManager.SlidingText;
        }
    
    }

}
