using UnityEngine;

namespace Royal.Scenes.Game.Ui.Dialogs.LevelFail
{
    public class OutOfMovesBanner : UiDialog
    {
        // Fields
        private Royal.Infrastructure.Contexts.Units.CameraManager camManager;
        private Royal.Infrastructure.UiComponents.Dialog.DialogManager dialogManager;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private DG.Tweening.Sequence sequence;
        private bool isBannerLeavingScreen;
        private Royal.Scenes.Start.Context.Units.Audio.AudioManager audioManager;
        
        // Methods
        private void Awake()
        {
            this.camManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            this.dialogManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.UiComponents.Dialog.DialogManager>(id:  13);
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.audioManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Audio.AudioManager>(id:  16);
        }
        public override void OnShow(UnityEngine.Vector3 position)
        {
            UnityEngine.Vector2 val_1 = this.camManager.GetSafeCenterPosition();
            UnityEngine.Vector3 val_3 = this.camManager.GetTopCenterOfCamera();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.isBannerLeavingScreen = false;
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            this.sequence = val_6;
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_6, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner::<OnShow>b__7_0()));
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(d:  0.6f, a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  0.25f, snapping:  false), ease:  3));
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Multiply(d:  0.1f, a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  0.1666667f, snapping:  false), ease:  3));
            UnityEngine.Vector3 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, duration:  0.1f, snapping:  false), ease:  3));
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.sequence, interval:  1f);
            DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.sequence, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner::<OnShow>b__7_1()));
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.sequence, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner::<OnShow>b__7_2()));
            UnityEngine.Vector3 val_36 = this.camManager.GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.sequence, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, duration:  0.3333333f, snapping:  false), ease:  26, overshoot:  1f));
            DG.Tweening.Sequence val_42 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.sequence, interval:  0.1f);
            DG.Tweening.Sequence val_44 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  this.sequence, action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner).__il2cppRuntimeField_288));
        }
        protected override void AfterShowAnimation()
        {
            this.flowManager.Clear(alsoRunningAction:  false);
            this.flowManager.Push(action:  new Royal.Scenes.Game.Ui.Dialogs.LevelFail.ShowEgoDialogAction());
            goto typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner).__il2cppRuntimeField_250;
        }
        public override Royal.Infrastructure.UiComponents.Dialog.DialogConfig GetConfig()
        {
            bool val_2;
            bool val_3;
            bool val_4;
            var val_5;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_0;
            Royal.Infrastructure.UiComponents.Dialog.DialogConfig val_1 = this.GetConfig();
            val_0.shouldSkipFastOnTouch = true;
            val_0.shouldHideBackground = val_2;
            mem[1152921519929784087] = val_4;
            mem[1152921519929784085] = val_5;
            val_0.shouldHideBackgroundOnShow = val_3;
            val_0.backgroundFadeAlpha = 0f;
            return val_0;
        }
        public override void SkipFast()
        {
            if(this.sequence == null)
            {
                    return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            if(this.isBannerLeavingScreen != false)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.sequence, complete:  false);
            this.sequence = 0;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector3 val_3 = this.camManager.GetBottomCenterOfCamera();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.3f, snapping:  false), ease:  8));
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_1, interval:  0.1f);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  typeof(Royal.Scenes.Game.Ui.Dialogs.LevelFail.OutOfMovesBanner).__il2cppRuntimeField_288));
        }
        public OutOfMovesBanner()
        {
        
        }
        private void <OnShow>b__7_0()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  190, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
        private void <OnShow>b__7_1()
        {
            this.isBannerLeavingScreen = true;
        }
        private void <OnShow>b__7_2()
        {
            if(this.audioManager != null)
            {
                    this.audioManager.PlaySound(type:  191, offset:  0.04f);
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
