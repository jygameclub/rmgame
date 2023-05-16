using UnityEngine;

namespace Royal.Scenes.Home.Areas.Area09
{
    public class Area09View : AreaView
    {
        // Fields
        private static readonly int BlendColor;
        public Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation[] distortionAnimations;
        public UnityEngine.SpriteRenderer[] oceansCaustics;
        public UnityEngine.Material defaultMaterial;
        public UnityEngine.Material saturationMaterial;
        
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
        private void ShowWaterDetails()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.ChangeMaterial(customMaterial:  this.defaultMaterial, brightness:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8).LoadAreaBackground(areaNo:  9, onComplete:  new System.Action<UnityEngine.Sprite>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Area09.Area09View::SetCaustics(UnityEngine.Sprite sprite)));
            var val_9 = 0;
            label_9:
            if(val_9 >= this.oceansCaustics.Length)
            {
                goto label_5;
            }
            
            UnityEngine.SpriteRenderer val_8 = this.oceansCaustics[val_9];
            val_8.gameObject.SetActive(value:  true);
            UnityEngine.Color val_5 = UnityEngine.Color.black;
            val_8.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            val_9 = val_9 + 1;
            if(this.oceansCaustics != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_5:
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.ShowOceanCaustics());
        }
        private void SetCaustics(UnityEngine.Sprite sprite)
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.oceansCaustics.Length)
            {
                    return;
            }
            
                this.oceansCaustics[val_2].sprite = sprite;
                val_2 = val_2 + 1;
            }
            while(this.oceansCaustics != null);
            
            throw new NullReferenceException();
        }
        public override void ShowOnlyBackground()
        {
            this.ShowOnlyBackground();
            var val_3 = 0;
            label_5:
            if(val_3 >= this.oceansCaustics.Length)
            {
                goto label_1;
            }
            
            this.oceansCaustics[val_3].gameObject.SetActive(value:  false);
            val_3 = val_3 + 1;
            if(this.oceansCaustics != null)
            {
                goto label_5;
            }
            
            throw new NullReferenceException();
            label_1:
            this.DarkenColor();
        }
        public override void BringBackgroundFront()
        {
            var val_1;
            this.BringBackgroundFront();
            val_1 = 0;
            do
            {
                if(val_1 >= this.distortionAnimations.Length)
            {
                    return;
            }
            
                Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation val_1 = this.distortionAnimations[val_1];
                this.distortionAnimations[0x0][0].spriteRenderer.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DialogLayerId;
                val_1 = val_1 + 1;
            }
            while(this.distortionAnimations != null);
            
            throw new NullReferenceException();
        }
        public override void SendBackgroundBack()
        {
            var val_1;
            this.SendBackgroundBack();
            val_1 = 0;
            do
            {
                if(val_1 >= this.distortionAnimations.Length)
            {
                    return;
            }
            
                Royal.Scenes.Home.Areas.Area09.Idles.DistortionAnimation val_1 = this.distortionAnimations[val_1];
                this.distortionAnimations[0x0][0].spriteRenderer.sortingLayerID = Royal.Scenes.Game.Mechanics.Sortings.Sorting.DefaultLayerId;
                val_1 = val_1 + 1;
            }
            while(this.distortionAnimations != null);
            
            throw new NullReferenceException();
        }
        private void DarkenColor()
        {
            UnityEngine.Color val_1 = this.saturationMaterial.GetColor(nameID:  Royal.Scenes.Home.Areas.Area09.Area09View.BlendColor);
            this.saturationMaterial.SetColor(nameID:  Royal.Scenes.Home.Areas.Area09.Area09View.BlendColor, value:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = 0.2f});
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
        private UnityEngine.Color GetBrigColor()
        {
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private float GetSatValue()
        {
            return 0.8f;
        }
        private System.Collections.IEnumerator ShowOceanCaustics()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Area09View.<ShowOceanCaustics>d__16();
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
            return (System.Collections.IEnumerator)new Area09View.<PlayAreaSpecificBackgroundSounds>d__18();
        }
        public Area09View()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
        private static Area09View()
        {
            Royal.Scenes.Home.Areas.Area09.Area09View.BlendColor = UnityEngine.Shader.PropertyToID(name:  "_BlendColor");
        }
    
    }

}
