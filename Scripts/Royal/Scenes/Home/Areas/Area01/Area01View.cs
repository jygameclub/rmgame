using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area01
{
    public class Area01View : AreaView
    {
        // Fields
        private static readonly int UseCustomTime;
        private static readonly int CustomTime;
        private static readonly int BlendColor;
        public UnityEngine.SpriteRenderer oceansCaustics;
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation oceanDistortion;
        public UnityEngine.Material defaultMaterial;
        public UnityEngine.Material saturationMaterial;
        public UnityEngine.Material oceanCausticsMat;
        private UnityEngine.Coroutine oceanCausticsRoutine;
        private float elapsedTime;
        
        // Methods
        public override void ShowCompletedTasks()
        {
            this.ShowCompletedTasks();
            this.ShowWaterDetails();
        }
        public override void InitPreviousArea(int areaId)
        {
            this.InitPreviousArea(areaId:  areaId);
            this.ShowWaterDetails();
        }
        public override void ShowOnlyBackground()
        {
            this.ShowOnlyBackground();
            this.StopCaustics();
            this.DarkenColor();
        }
        public override void BringBackgroundFront()
        {
            this.BringBackgroundFront();
            this.oceanDistortion.spriteRenderer.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId;
            this.oceansCaustics.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId;
        }
        public override void SendBackgroundBack()
        {
            this.SendBackgroundBack();
            this.oceanDistortion.spriteRenderer.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
            this.oceansCaustics.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
        }
        private void ShowWaterDetails()
        {
            this.oceansCaustics.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.oceanDistortion.ChangeMaterial(mat:  this.defaultMaterial, brightness:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.ShowOceanCaustics());
        }
        private UnityEngine.Color GetBrigColor()
        {
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private float GetSatValue()
        {
            return 0.8f;
        }
        private void DarkenColor()
        {
            UnityEngine.Color val_1 = this.saturationMaterial.GetColor(nameID:  Royal.Scenes.Home.Areas.Area01.Area01View.BlendColor);
            this.saturationMaterial.SetColor(nameID:  Royal.Scenes.Home.Areas.Area01.Area01View.BlendColor, value:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 0.2f});
            this.oceanDistortion.ChangeMaterial(mat:  this.saturationMaterial, brightness:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        }
        private void ChangeMaterial(UnityEngine.Material customMaterial, UnityEngine.Color brightness)
        {
            if(this.oceanDistortion != null)
            {
                    this.oceanDistortion.ChangeMaterial(mat:  customMaterial, brightness:  new UnityEngine.Color() {r = brightness.r, g = brightness.g, b = brightness.b, a = brightness.a});
                return;
            }
            
            throw new NullReferenceException();
        }
        private System.Collections.IEnumerator ShowOceanCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area01View.<ShowOceanCaustics>d__20();
        }
        private System.Collections.IEnumerator IncreaseOceanCausticsOpacitySmoothly()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area01View.<IncreaseOceanCausticsOpacitySmoothly>d__21();
        }
        private System.Collections.IEnumerator UpdateOceanCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area01View.<UpdateOceanCaustics>d__22();
        }
        private void StopCaustics()
        {
            if(this.oceanCausticsRoutine != null)
            {
                    this.StopCoroutine(routine:  this.oceanCausticsRoutine);
                this.oceanCausticsRoutine = 0;
            }
            
            this.oceanCausticsMat.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area01.Area01View.UseCustomTime, value:  1f);
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
        protected override System.Collections.IEnumerator PlayAreaSpecificBackgroundSounds()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area01View.<PlayAreaSpecificBackgroundSounds>d__25();
        }
        public Area01View()
        {
        
        }
        private static Area01View()
        {
            Royal.Scenes.Home.Areas.Area01.Area01View.UseCustomTime = UnityEngine.Shader.PropertyToID(name:  "_UseCustomTime");
            Royal.Scenes.Home.Areas.Area01.Area01View.CustomTime = UnityEngine.Shader.PropertyToID(name:  "_CustomTime");
            Royal.Scenes.Home.Areas.Area01.Area01View.BlendColor = UnityEngine.Shader.PropertyToID(name:  "_BlendColor");
        }
    
    }

}
