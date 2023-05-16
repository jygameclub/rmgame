using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area09.Tasks.Lighthouse
{
    public class Area09LighthouseView : AreaTaskViewAnimation
    {
        // Methods
        public override void Show()
        {
            this.Show();
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                this.GetComponentsInChildren<Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation>()[val_3].PlayDistortion();
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        public Area09LighthouseView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
