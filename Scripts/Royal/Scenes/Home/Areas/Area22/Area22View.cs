using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area22
{
    public class Area22View : AreaView
    {
        // Fields
        private static readonly int UseCustomTime;
        private static readonly int CustomTime;
        public UnityEngine.SpriteRenderer waterCaustics;
        public UnityEngine.SpriteMask waterCausticsMask;
        public UnityEngine.SpriteRenderer pathsOverWater;
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation distortionAnimation;
        public UnityEngine.Material waterCausticsMaterial;
        private float elapsedTime;
        private UnityEngine.Coroutine waterCausticsRoutine;
        
        // Methods
        protected override System.Collections.IEnumerator PlayAreaSpecificBackgroundSounds()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area22View.<PlayAreaSpecificBackgroundSounds>d__9();
        }
        public override void ShowCompletedTasks()
        {
            this.ShowCompletedTasks();
            this.ShowWaterDetails();
        }
        public override void InitPreviousArea(int areaId)
        {
            this.Init(areaId:  areaId);
            this.ShowWaterDetails();
        }
        public override void ShowOnlyBackground()
        {
            this.ShowOnlyBackground();
            this.RemoveWaterDetails();
        }
        public override void BringBackgroundFront()
        {
            var val_1;
            this.BringBackgroundFront();
            val_1 = null;
            val_1 = null;
            this.SetCausticsRelatedObjectsSorting(sortingId:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId);
        }
        public override void SendBackgroundBack()
        {
            var val_1;
            this.SendBackgroundBack();
            val_1 = null;
            val_1 = null;
            this.SetCausticsRelatedObjectsSorting(sortingId:  Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId);
        }
        private void SetCausticsRelatedObjectsSorting(int sortingId)
        {
            this.waterCausticsMask.backSortingLayerID = sortingId;
            this.waterCausticsMask.frontSortingLayerID = sortingId;
            this.pathsOverWater.sortingLayerID = sortingId;
            this.distortionAnimation.spriteRenderer.sortingLayerID = sortingId;
            this.waterCaustics.sortingLayerID = sortingId;
        }
        private void ShowWaterDetails()
        {
            this.SetWaterCausticsToTransparent();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ShowWaterCaustics());
        }
        private void SetWaterCausticsToTransparent()
        {
            this.waterCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private System.Collections.IEnumerator IncreaseWaterCausticsOpacitySmoothly()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area22View.<IncreaseWaterCausticsOpacitySmoothly>d__18();
        }
        private UnityEngine.Color GetBrigColor()
        {
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private float GetSatValue()
        {
            return 0.8f;
        }
        private System.Collections.IEnumerator ShowWaterCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area22View.<ShowWaterCaustics>d__21();
        }
        private System.Collections.IEnumerator UpdateWaterCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area22View.<UpdateWaterCaustics>d__22();
        }
        private float GetAverageOfDeltaTimes(float[] lastFloats)
        {
            float val_3;
            int val_1 = lastFloats.Length & 4294967295;
            if((val_1 << 32) >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_3 = val_3 + 1;
                val_3 = 0f + null;
            }
            while(val_3 < (long)val_1);
            
            }
            else
            {
                    val_3 = 0f;
            }
            
            val_3 = val_3 / (float)lastFloats.Length;
            return (float)val_3;
        }
        private void RemoveWaterDetails()
        {
            this.StopCaustics();
            this.distortionAnimation.StopDistortion();
        }
        private void StopCaustics()
        {
            if(this.waterCausticsRoutine != null)
            {
                    this.StopCoroutine(routine:  this.waterCausticsRoutine);
                this.waterCausticsRoutine = 0;
                this.waterCausticsMaterial.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area22.Area22View.UseCustomTime, value:  1f);
            }
            
            this.distortionAnimation.StopDistortion();
        }
        public Area22View()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static Area22View()
        {
            Royal.Scenes.Home.Areas.Area22.Area22View.UseCustomTime = UnityEngine.Shader.PropertyToID(name:  "_UseCustomTime");
            Royal.Scenes.Home.Areas.Area22.Area22View.CustomTime = UnityEngine.Shader.PropertyToID(name:  "_CustomTime");
        }
    
    }

}
