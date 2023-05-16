using UnityEngine;

namespace Coffee.UIExtensions
{
    [Serializable]
    public class EffectPlayer
    {
        // Fields
        public bool play;
        public bool loop;
        public float duration;
        public float loopDelay;
        public UnityEngine.AnimatorUpdateMode updateMode;
        private static System.Collections.Generic.List<System.Action> s_UpdateActions;
        private float _time;
        private System.Action<float> _callback;
        
        // Methods
        public void OnEnable(System.Action<float> callback)
        {
            System.Collections.Generic.List<System.Action> val_4;
            var val_5;
            Canvas.WillRenderCanvases val_7;
            val_4 = Coffee.UIExtensions.EffectPlayer.s_UpdateActions;
            if(val_4 == null)
            {
                    System.Collections.Generic.List<System.Action> val_1 = new System.Collections.Generic.List<System.Action>();
                Coffee.UIExtensions.EffectPlayer.s_UpdateActions = val_1;
                val_5 = null;
                val_5 = null;
                val_7 = EffectPlayer.<>c.<>9__6_0;
                if(val_7 == null)
            {
                    Canvas.WillRenderCanvases val_2 = null;
                val_7 = val_2;
                val_2 = new Canvas.WillRenderCanvases(object:  EffectPlayer.<>c.__il2cppRuntimeField_static_fields, method:  System.Void EffectPlayer.<>c::<OnEnable>b__6_0());
                EffectPlayer.<>c.<>9__6_0 = val_7;
            }
            
                UnityEngine.Canvas.add_willRenderCanvases(value:  val_2);
                val_4 = Coffee.UIExtensions.EffectPlayer.s_UpdateActions;
            }
            
            System.Action val_3 = static_value_02DC1B30;
            val_3 = new System.Action(object:  this, method:  System.Void Coffee.UIExtensions.EffectPlayer::OnWillRenderCanvases());
            val_1.Add(item:  val_3);
            this._time = 0f;
            this._callback = callback;
        }
        public void OnDisable()
        {
            this._callback = 0;
            System.Action val_1 = static_value_02DC1B30;
            val_1 = new System.Action(object:  this, method:  System.Void Coffee.UIExtensions.EffectPlayer::OnWillRenderCanvases());
            bool val_2 = Coffee.UIExtensions.EffectPlayer.s_UpdateActions.Remove(item:  val_1);
        }
        public void Play(System.Action<float> callback)
        {
            this._time = 0f;
            this.play = true;
            if(callback == null)
            {
                    return;
            }
            
            this._callback = callback;
        }
        public void Stop()
        {
            this.play = false;
        }
        private void OnWillRenderCanvases()
        {
            float val_5;
            if(this.play == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this._callback == null)
            {
                    return;
            }
            
            if(this.updateMode == 2)
            {
                    float val_2 = UnityEngine.Time.unscaledDeltaTime;
            }
            else
            {
                    float val_3 = UnityEngine.Time.deltaTime;
            }
            
            val_3 = this._time + val_3;
            this._time = val_3;
            if(this.duration <= val_3)
            {
                    this.play = this.loop;
                if(this.loop != false)
            {
                    val_5 = -this.loopDelay;
            }
            else
            {
                    val_5 = 0f;
            }
            
                this._time = val_5;
            }
            
            val_3 = val_3 / this.duration;
            this._callback.Invoke(obj:  val_3);
        }
        public EffectPlayer()
        {
            this.duration = 1f;
        }
    
    }

}
