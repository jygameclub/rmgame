using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area13.Tasks.Bamboo
{
    public class Area13BambooView : AreaTaskViewAnimation
    {
        // Fields
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation distortionAnimation;
        
        // Methods
        public override void Show()
        {
            this.Show();
            this.distortionAnimation.PlayDistortion();
        }
        public Area13BambooView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
