using UnityEngine;

namespace Royal.Scenes.Home.Areas.Scripts
{
    public class AreaBackgroundView : MonoBehaviour
    {
        // Fields
        private static readonly int BlendColor;
        private const float PixelPerUnit = 140;
        private const float PixelHeight = 2894;
        private const float PixelWidth = 1736;
        private const float SafePixelWidth = 1302;
        private const float Height = 20.67143;
        private const float Width = 12.4;
        private const float SafeWidth = 9.3;
        public UnityEngine.Sprite gameBackground;
        public UnityEngine.GameObject[] objectsToHideInGame;
        public UnityEngine.Material saturationMaterial;
        private UnityEngine.Sprite areaBackground;
        private UnityEngine.SpriteRenderer[] sprites;
        public UnityEngine.SpriteRenderer background;
        private UnityEngine.Material defaultMaterial;
        private UnityEngine.Color originalBlendColor;
        private bool shouldUseGameBackground;
        
        // Methods
        public static float GetSafeWidthScale(float width)
        {
            width = width / 9.3f;
            return (float)width;
        }
        public static float GetWidthScale(float width)
        {
            width = width / 12.4f;
            return (float)width;
        }
        public static float GetHeightScale(float height)
        {
            height = height / 20.67143f;
            return (float)height;
        }
        public void Init(int areaId)
        {
            T[] val_1 = this.GetComponentsInChildren<UnityEngine.SpriteRenderer>(includeInactive:  true);
            this.sprites = val_1;
            T val_11 = val_1[0];
            this.background = val_11;
            if(val_11.sprite == 0)
            {
                    Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Home.Context.Units.AssetBundles.AssetBundleHelper>(id:  8).LoadAreaBackground(areaNo:  areaId, onComplete:  new System.Action<UnityEngine.Sprite>(object:  this, method:  System.Void Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView::SetBackground(UnityEngine.Sprite bg)));
            }
            
            this.defaultMaterial = this.background.sharedMaterial;
            UnityEngine.Color val_7 = this.saturationMaterial.GetColor(nameID:  Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.SafeWidth);
            this.originalBlendColor = val_7;
            mem[1152921519590683076] = val_7.g;
            mem[1152921519590683080] = val_7.b;
            mem[1152921519590683084] = val_7.a;
            this.areaBackground = this.background.sprite;
            this.shouldUseGameBackground = UnityEngine.Object.op_Inequality(x:  this.gameBackground, y:  0);
        }
        private void SetBackground(UnityEngine.Sprite bg)
        {
            this.background.sprite = bg;
            this.areaBackground = this.background.sprite;
        }
        private void UpdateColor()
        {
            var val_6 = 4;
            label_8:
            if((val_6 - 4) >= this.sprites.Length)
            {
                goto label_2;
            }
            
            UnityEngine.Color val_2 = this.sprites[0].color;
            this.sprites[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = val_2.a};
            val_6 = val_6 + 1;
            if(this.sprites != null)
            {
                goto label_8;
            }
            
            label_2:
            UnityEngine.Color val_3 = this.saturationMaterial.GetColor(nameID:  Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.SafeWidth);
            this.saturationMaterial.SetColor(nameID:  Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.SafeWidth, value:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = 0.2f});
            this.ChangeMaterial(customMaterial:  this.saturationMaterial);
        }
        public void UpdateSorting(int sortingLayer)
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.sprites.Length)
            {
                    return;
            }
            
                this.sprites[val_2].sortingLayerID = sortingLayer;
                val_2 = val_2 + 1;
            }
            while(this.sprites != null);
            
            throw new NullReferenceException();
        }
        public void PrepareForGame()
        {
            this.ShowGame();
            this.UpdateColor();
        }
        private void ShowGame()
        {
            this.ChangeMaterial(customMaterial:  this.saturationMaterial);
            var val_6 = 0;
            label_6:
            if(val_6 >= this.objectsToHideInGame.Length)
            {
                goto label_2;
            }
            
            this.objectsToHideInGame[val_6].gameObject.SetActive(value:  false);
            val_6 = val_6 + 1;
            if(this.objectsToHideInGame != null)
            {
                goto label_6;
            }
            
            label_2:
            if(this.shouldUseGameBackground == false)
            {
                    return;
            }
            
            if(IsLeague != true)
            {
                    if((Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.LevelManager>(id:  2).IsThereGrassInLevel()) == false)
            {
                    return;
            }
            
            }
            
            var val_8 = 0;
            label_22:
            if(val_8 >= this.sprites.Length)
            {
                goto label_19;
            }
            
            this.sprites[val_8].enabled = false;
            val_8 = val_8 + 1;
            if(this.sprites != null)
            {
                goto label_22;
            }
            
            return;
            label_19:
            this.background.sprite = this.gameBackground;
            this.background.enabled = true;
        }
        private void ShowHome()
        {
            this.ChangeMaterial(customMaterial:  this.defaultMaterial);
            var val_3 = 0;
            label_5:
            if(val_3 >= this.objectsToHideInGame.Length)
            {
                goto label_1;
            }
            
            this.objectsToHideInGame[val_3].gameObject.SetActive(value:  true);
            val_3 = val_3 + 1;
            if(this.objectsToHideInGame != null)
            {
                goto label_5;
            }
            
            label_1:
            var val_5 = 0;
            label_11:
            if(val_5 >= this.sprites.Length)
            {
                goto label_8;
            }
            
            this.sprites[val_5].enabled = true;
            val_5 = val_5 + 1;
            if(this.sprites != null)
            {
                goto label_11;
            }
            
            label_8:
            if(this.shouldUseGameBackground == false)
            {
                    return;
            }
            
            this.background.sprite = this.areaBackground;
        }
        private void Darken()
        {
            this.UpdateColor();
        }
        private void ChangeMaterial(UnityEngine.Material customMaterial)
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this.sprites.Length)
            {
                    return;
            }
            
                this.sprites[val_2].material = customMaterial;
                val_2 = val_2 + 1;
            }
            while(this.sprites != null);
            
            throw new NullReferenceException();
        }
        public void ResetView()
        {
            this.ShowHome();
            var val_3 = 0;
            do
            {
                if(val_3 >= this.sprites.Length)
            {
                    return;
            }
            
                UnityEngine.SpriteRenderer val_2 = this.sprites[val_3];
                UnityEngine.Color val_1 = val_2.color;
                val_2.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
                val_3 = val_3 + 1;
            }
            while(this.sprites != null);
            
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
        public AreaBackgroundView()
        {
        
        }
        private static AreaBackgroundView()
        {
            Royal.Scenes.Home.Areas.Scripts.AreaBackgroundView.SafeWidth = UnityEngine.Shader.PropertyToID(name:  "_BlendColor");
        }
    
    }

}
