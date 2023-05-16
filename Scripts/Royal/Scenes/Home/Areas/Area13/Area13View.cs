using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area13
{
    public class Area13View : AreaView
    {
        // Fields
        private static readonly int UseCustomTime;
        private static readonly int CustomTime;
        private static readonly int BlendColor;
        public UnityEngine.SpriteRenderer oceansCaustics;
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation[] distortionAnimations;
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
            this.Init(areaId:  areaId);
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
            var val_2 = 0;
            label_8:
            if(val_2 >= this.distortionAnimations.Length)
            {
                goto label_2;
            }
            
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation val_1 = this.distortionAnimations[val_2];
            this.distortionAnimations[0x0][0].spriteRenderer.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId;
            val_2 = val_2 + 1;
            if(this.distortionAnimations != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_2:
            this.oceansCaustics.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId;
        }
        public override void SendBackgroundBack()
        {
            this.SendBackgroundBack();
            var val_2 = 0;
            label_8:
            if(val_2 >= this.distortionAnimations.Length)
            {
                goto label_2;
            }
            
            Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation val_1 = this.distortionAnimations[val_2];
            this.distortionAnimations[0x0][0].spriteRenderer.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
            val_2 = val_2 + 1;
            if(this.distortionAnimations != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_2:
            this.oceansCaustics.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
        }
        private void ShowWaterDetails()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.ChangeMaterial(customMaterial:  this.defaultMaterial, brightness:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
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
            UnityEngine.Color val_1 = this.saturationMaterial.GetColor(nameID:  Royal.Scenes.Home.Areas.Area13.Area13View.BlendColor);
            this.saturationMaterial.SetColor(nameID:  Royal.Scenes.Home.Areas.Area13.Area13View.BlendColor, value:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 0.2f});
            this.ChangeMaterial(customMaterial:  this.saturationMaterial, brightness:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        }
        private void ChangeMaterial(UnityEngine.Material customMaterial, UnityEngine.Color brightness)
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.distortionAnimations.Length)
            {
                    return;
            }
            
                this.distortionAnimations[val_2].ChangeMaterial(mat:  customMaterial, brightness:  new UnityEngine.Color() {r = brightness.r, g = brightness.g, b = brightness.b, a = brightness.a});
                val_2 = val_2 + 1;
            }
            while(this.distortionAnimations != null);
            
            throw new NullReferenceException();
        }
        private System.Collections.IEnumerator ShowOceanCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area13View.<ShowOceanCaustics>d__20();
        }
        private System.Collections.IEnumerator UpdateOceanCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area13View.<UpdateOceanCaustics>d__21();
        }
        private void StopCaustics()
        {
            if(this.oceanCausticsRoutine != null)
            {
                    this.StopCoroutine(routine:  this.oceanCausticsRoutine);
                this.oceanCausticsRoutine = 0;
            }
            
            this.oceanCausticsMat.SetFloat(nameID:  Royal.Scenes.Home.Areas.Area13.Area13View.UseCustomTime, value:  1f);
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
            return (System.Collections.IEnumerator)new Area13View.<PlayAreaSpecificBackgroundSounds>d__24();
        }
        public Area13View()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static Area13View()
        {
            Royal.Scenes.Home.Areas.Area13.Area13View.UseCustomTime = UnityEngine.Shader.PropertyToID(name:  "_UseCustomTime");
            Royal.Scenes.Home.Areas.Area13.Area13View.CustomTime = UnityEngine.Shader.PropertyToID(name:  "_CustomTime");
            Royal.Scenes.Home.Areas.Area13.Area13View.BlendColor = UnityEngine.Shader.PropertyToID(name:  "_BlendColor");
        }
    
    }

}
