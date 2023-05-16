using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Social.Chat
{
    public class ChatScroll : UiVerticalScroll
    {
        // Fields
        private static bool IsKeyboardOpenOnce;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            goto typeof(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScroll).__il2cppRuntimeField_270;
        }
        public void UpdateScrollArea(UnityEngine.Vector3 topPosition, UnityEngine.Vector3 bottomPosition)
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = bottomPosition.x, y = bottomPosition.y, z = bottomPosition.z}, b:  new UnityEngine.Vector3() {x = topPosition.x, y = topPosition.y, z = topPosition.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  2f);
            transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = topPosition.x, y = topPosition.y, z = topPosition.z}, b:  new UnityEngine.Vector3() {x = bottomPosition.x, y = bottomPosition.y, z = bottomPosition.z});
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_1.cameraWidth, y:  val_5.y);
            this.size = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        public float GetDistanceFromMax()
        {
            UnityEngine.Vector3 val_2 = this.transform.localPosition;
            return (float)S8 - val_2.y;
        }
        public void ScrollChatToNewestAnimated(float frameCount = 35, DG.Tweening.Ease easing = 18)
        {
            UnityEngine.Transform val_1 = 7887.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_7 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMove(target:  val_1, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = V8.16B, z = val_2.z}, duration:  Royal.Infrastructure.Utils.Time.TimeUtil.FramesToSeconds(frames:  frameCount), snapping:  false), ease:  easing), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScroll::<ScrollChatToNewestAnimated>b__3_0()));
            mem[1152921519011194400] = ???;
        }
        public void ScrollChatToNewest()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.localPosition;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = V8.16B, z = val_2.z};
            mem[1152921519011335072] = ???;
            goto typeof(UnityEngine.Transform).__il2cppRuntimeField_190;
        }
        public void AnimateScrollParentForKeyboard(UnityEngine.Vector3 keyboardTopPosition)
        {
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_31;
            float val_32;
            val_23 = keyboardTopPosition.z;
            UnityEngine.Vector2 val_1 = 7885.size;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_24 = val_2.y;
            UnityEngine.Vector3 val_4 = 0.transform.position;
            val_25 = val_4.y;
            val_26 = val_4.z;
            if(0f >= 0)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            val_23 = val_5.z;
            UnityEngine.Vector2 val_6 = 0.size;
            float val_23 = 0.5f;
            val_23 = val_6.y * val_23;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_23}, d:  val_23 - 0f);
            val_27 = val_25;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_27, z = val_26}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_31 = keyboardTopPosition.y;
            if(val_9.y >= 0)
            {
                goto label_11;
            }
            
            val_25 = val_9.x;
            val_32 = val_9.y;
            val_26 = val_9.z;
            val_23 = val_23;
            goto label_13;
            label_7:
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector2 val_11 = 0.size;
            val_11.y = val_11.y * 0.5f;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_11.y - (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 44));
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_25 = val_14.x;
            val_32 = val_14.y;
            val_26 = val_14.z;
            val_31 = keyboardTopPosition.y;
            label_13:
            val_27 = val_31;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = keyboardTopPosition.x, y = val_27, z = val_23}, b:  new UnityEngine.Vector3() {x = val_25, y = val_32, z = val_26});
            val_24 = val_15.y;
            label_11:
            UnityEngine.Transform val_17 = this.transform.parent;
            UnityEngine.Vector3 val_18 = val_17.localPosition;
            float val_19 = val_24 + val_18.y;
            if(Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScroll.IsKeyboardOpenOnce != false)
            {
                    DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_17, endValue:  val_19, duration:  0.3f, snapping:  false), ease:  3);
                return;
            }
            
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_22 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_17, endValue:  val_19, duration:  0.166f, snapping:  false);
            Royal.Scenes.Home.Ui.Sections.Social.Chat.ChatScroll.IsKeyboardOpenOnce = true;
        }
        public void ResetScrollParentForKeyboard()
        {
            UnityEngine.Vector3 val_3 = this.transform.parent.localPosition;
            if((Royal.Infrastructure.Utils.Math.NumberExtensions.Approximately(a:  val_3.y, b:  0f, precision:  0.001f)) != false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_8 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.transform.parent, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.2f, snapping:  false);
        }
        protected override void PrepareContent()
        {
            float val_2;
            UnityEngine.Vector2 val_1 = this.size;
            float val_3 = X8 + 44;
            float val_4 = X8 + 76;
            float val_2 = 0.5f;
            val_2 = val_1.y * val_2;
            val_3 = val_1.y - val_3;
            val_2 = val_2 + (X8 + 32);
            mem[1152921519011765272] = val_2;
            if(val_4 >= 0)
            {
                    val_4 = val_4 - val_2;
                val_2 = val_4 + (X8 + 44);
            }
            
            mem[1152921519011765276] = val_2;
        }
        public ChatScroll()
        {
        
        }
        private void <ScrollChatToNewestAnimated>b__3_0()
        {
            UnityEngine.Vector3 val_2 = X19.transform.localPosition;
            goto X19 + 400;
        }
    
    }

}
