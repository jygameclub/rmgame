using UnityEngine;

namespace Royal.Infrastructure.Utils.Animation
{
    public struct ShakeAnimationConfig
    {
        // Fields
        public float delay;
        public float duration;
        public float minVibrate;
        public float midVibrate;
        public float maxVibrate;
        public bool shouldScale;
        public bool shouldVisitCenter;
        
        // Properties
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig TntConfig { get; }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig TntTntConfig { get; }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig BallBallConfig { get; }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig TntRocketConfig { get; }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig CannonConfig { get; }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig HammerConfig { get; }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig DrillConfig { get; }
        
        // Methods
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_TntConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = 0.05f;
            val_0.midVibrate = 0.1f;
            val_0.maxVibrate = 0.2f;
            val_0.shouldScale = true;
            val_0.shouldVisitCenter = true;
            mem[1152921527493461462] = 0;
            return val_0;
        }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_TntTntConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.maxVibrate = 0.2f;
            val_0.shouldScale = false;
            val_0.shouldVisitCenter = false;
            mem[1152921527493581462] = 0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = -0.2f;
            val_0.midVibrate = 0f;
            return val_0;
        }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_BallBallConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.maxVibrate = 0.2f;
            val_0.shouldScale = false;
            val_0.shouldVisitCenter = false;
            mem[1152921527493701462] = 0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = -0.2f;
            val_0.midVibrate = 0f;
            return val_0;
        }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_TntRocketConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = 0.05f;
            val_0.midVibrate = 0.1f;
            val_0.maxVibrate = 0.2f;
            val_0.shouldScale = true;
            val_0.shouldVisitCenter = true;
            mem[1152921527493821462] = 0;
            return val_0;
        }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_CannonConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = 0.05f;
            val_0.midVibrate = 0.1f;
            val_0.maxVibrate = 0.2f;
            val_0.shouldScale = true;
            val_0.shouldVisitCenter = true;
            mem[1152921527493941462] = 0;
            return val_0;
        }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_HammerConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = -0.3f;
            val_0.midVibrate = 0f;
            val_0.maxVibrate = 0.3f;
            val_0.shouldScale = true;
            val_0.shouldVisitCenter = false;
            mem[1152921527494061462] = 0;
            return val_0;
        }
        public static Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig get_DrillConfig()
        {
            Royal.Infrastructure.Utils.Animation.ShakeAnimationConfig val_0;
            val_0.maxVibrate = 0.03f;
            val_0.shouldScale = false;
            val_0.shouldVisitCenter = false;
            mem[1152921527494181462] = 0;
            val_0.delay = ;
            val_0.duration = ;
            val_0.minVibrate = -0.03f;
            val_0.midVibrate = 0f;
            return val_0;
        }
    
    }

}
