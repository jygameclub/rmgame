using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Episodes
{
    public class EpisodeRow : UiScrollContentItem
    {
        // Fields
        private const float TotalLeftBarSize = 3.74;
        public UnityEngine.Material grayImageMaterial;
        public UnityEngine.Material spritesDefaultMaterial;
        public UnityEngine.Sprite grayBanner;
        public UnityEngine.Sprite grayBorder;
        public UnityEngine.Sprite coloredBanner;
        public UnityEngine.Sprite coloredBorder;
        public UnityEngine.Sprite leagueBanner;
        public UnityEngine.Sprite leagueBorder;
        public UnityEngine.SpriteRenderer[] banners;
        public UnityEngine.SpriteRenderer[] borders;
        public UnityEngine.GameObject completedContainer;
        public UnityEngine.GameObject progressContainer;
        public UnityEngine.GameObject lockImage;
        public TMPro.TextMeshPro progressText;
        public UnityEngine.GameObject infoTextArea;
        public TMPro.TextMeshPro infoText;
        public UnityEngine.SpriteRenderer leftProgressBar;
        public UnityEngine.Transform rightProgressBar;
        public Royal.Infrastructure.Utils.Text.CurvedTitle leagueTitle;
        public Royal.Infrastructure.Utils.Text.CurvedTitle coloredTitle;
        public Royal.Infrastructure.Utils.Text.CurvedTitle grayTitle;
        public UnityEngine.SpriteRenderer areaImage;
        public UnityEngine.GameObject separator;
        public Royal.Infrastructure.UiComponents.UiSpinner spinner;
        private Royal.Infrastructure.Utils.Text.CurvedTitle currentTitle;
        private Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRowData episodeRowData;
        private Royal.Scenes.Start.Context.Units.Flow.FlowManager flowManager;
        private bool showAreaClicked;
        
        // Methods
        public override void Prepare(Royal.Infrastructure.UiComponents.Scroll.Content.IUiScrollContentData data, UnityEngine.Bounds maskBounds)
        {
            this.flowManager = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Scenes.Start.Context.Units.Flow.FlowManager>(id:  12);
            this.episodeRowData = data;
            this.Reset();
            this.PrepareState();
            this.FixTitleAccordingToArea();
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(renderer:  this.areaImage, data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {sortEverything = false});
            this.separator.SetActive(value:  (this.episodeRowData.areaId != 1) ? 1 : 0);
        }
        private void Reset()
        {
            this.completedContainer.SetActive(value:  false);
            this.progressContainer.SetActive(value:  false);
            this.lockImage.SetActive(value:  false);
            this.infoTextArea.SetActive(value:  false);
            this.SetImagesToColored();
        }
        private void PrepareState()
        {
            Royal.Infrastructure.Utils.Text.CurvedTitle val_22;
            if(this.episodeRowData.episodeState <= 4)
            {
                    var val_19 = 36598048 + (this.episodeRowData.episodeState) << 2;
                val_19 = val_19 + 36598048;
            }
            else
            {
                    val_22 = this.currentTitle;
                mem[this.currentTitle].EnableUpdateForCurvedTexts();
            }
        
        }
        private void FixTitleAccordingToArea()
        {
            float val_1 = (this.episodeRowData.fontSizeMax == 0f) ? 13f : this.episodeRowData.fontSizeMax;
            this.grayTitle.texts[0].fontSizeMax = val_1;
            this.coloredTitle.texts[0].fontSizeMax = val_1;
        }
        private UnityEngine.Sprite GetInProgressSprite()
        {
            Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary val_1 = Royal.Scenes.Home.Episodes.Scripts.EpisodeAssetsLibrary.Instance;
            if(this.episodeRowData.areaId != 1)
            {
                    return val_1.GetFullSpriteForEpisode(episodeNo:  this.episodeRowData.areaId);
            }
            
            return val_1.GetEmptySpriteForEpisode(episodeNo:  this.episodeRowData.areaId);
        }
        private void SetImagesToGray()
        {
            this.coloredTitle.gameObject.SetActive(value:  false);
            this.grayTitle.gameObject.SetActive(value:  true);
            this.leagueTitle.gameObject.SetActive(value:  false);
            this.areaImage.material = this.grayImageMaterial;
            var val_5 = 0;
            label_11:
            if(val_5 >= this.banners.Length)
            {
                goto label_8;
            }
            
            this.banners[val_5].sprite = this.grayBanner;
            val_5 = val_5 + 1;
            if(this.banners != null)
            {
                goto label_11;
            }
            
            label_8:
            var val_7 = 0;
            do
            {
                if(val_7 >= this.borders.Length)
            {
                    return;
            }
            
                this.borders[val_7].sprite = this.grayBorder;
                val_7 = val_7 + 1;
            }
            while(this.borders != null);
            
            throw new NullReferenceException();
        }
        private void SetImagesToColored()
        {
            this.coloredTitle.gameObject.SetActive(value:  true);
            this.grayTitle.gameObject.SetActive(value:  false);
            this.leagueTitle.gameObject.SetActive(value:  false);
            this.areaImage.material = this.spritesDefaultMaterial;
            var val_5 = 0;
            label_11:
            if(val_5 >= this.banners.Length)
            {
                goto label_8;
            }
            
            this.banners[val_5].sprite = this.coloredBanner;
            val_5 = val_5 + 1;
            if(this.banners != null)
            {
                goto label_11;
            }
            
            label_8:
            var val_7 = 0;
            do
            {
                if(val_7 >= this.borders.Length)
            {
                    return;
            }
            
                this.borders[val_7].sprite = this.coloredBorder;
                val_7 = val_7 + 1;
            }
            while(this.borders != null);
            
            throw new NullReferenceException();
        }
        private void SetImagesToLeague()
        {
            this.coloredTitle.gameObject.SetActive(value:  false);
            this.grayTitle.gameObject.SetActive(value:  false);
            this.leagueTitle.gameObject.SetActive(value:  true);
            this.areaImage.material = this.spritesDefaultMaterial;
            var val_5 = 0;
            label_11:
            if(val_5 >= this.banners.Length)
            {
                goto label_8;
            }
            
            this.banners[val_5].sprite = this.leagueBanner;
            val_5 = val_5 + 1;
            if(this.banners != null)
            {
                goto label_11;
            }
            
            label_8:
            var val_7 = 0;
            do
            {
                if(val_7 >= this.borders.Length)
            {
                    return;
            }
            
                this.borders[val_7].sprite = this.leagueBorder;
                val_7 = val_7 + 1;
            }
            while(this.borders != null);
            
            throw new NullReferenceException();
        }
        public void ShowArea()
        {
            if(this.showAreaClicked != false)
            {
                    return;
            }
            
            this.showAreaClicked = true;
            this.Invoke(methodName:  "ShowSpinner", time:  0.05f);
            Royal.Scenes.Home.Ui.Dialogs.PreviousArea.ShowPreviousAreaDialogAction val_1 = new Royal.Scenes.Home.Ui.Dialogs.PreviousArea.ShowPreviousAreaDialogAction(areaId:  this.episodeRowData.areaId);
            val_1.add_OnComplete(value:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Home.Ui.Sections.Episodes.EpisodeRow::OnShowPreviousAreaDialogActionCompleted()));
            this.flowManager.Push(action:  val_1);
        }
        private void OnShowPreviousAreaDialogActionCompleted()
        {
            this.HideSpinner();
            this.showAreaClicked = false;
        }
        private void ShowSpinner()
        {
            if(this.spinner != null)
            {
                    this.spinner.Show();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void HideSpinner()
        {
            this.CancelInvoke(methodName:  "ShowSpinner");
            this.spinner.Hide();
        }
        private void PrepareProgressBar()
        {
            if(GetCompletedTaskCount() != 0)
            {
                    float val_3 = (float)GetCompletedTaskCount() / ((float)Royal.Player.Context.Data.Persistent.UserAreaData.__il2cppRuntimeField_byval_arg + 24);
                this.UpdateBarSize(ratio:  val_3);
                this.UpdateBarText(ratio:  val_3);
                this.EnableBarSprites();
                return;
            }
            
            this.DisableBarSprites();
        }
        private void DisableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  false);
            this.rightProgressBar.gameObject.SetActive(value:  false);
            this.progressText.text = "0%";
        }
        private void EnableBarSprites()
        {
            this.leftProgressBar.gameObject.SetActive(value:  true);
            this.rightProgressBar.gameObject.SetActive(value:  true);
        }
        private void UpdateBarSize(float ratio)
        {
            float val_6 = ratio;
            val_6 = val_6 * 3.74f;
            UnityEngine.Vector2 val_1 = this.leftProgressBar.size;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_6, y:  val_1.y);
            this.leftProgressBar.size = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector3 val_3 = this.rightProgressBar.localPosition;
            float val_7 = 0.2f;
            val_7 = val_6 + val_7;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_7, y:  val_3.y);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            this.rightProgressBar.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void UpdateBarText(float ratio)
        {
            float val_3 = 100f;
            val_3 = ratio * val_3;
            this.progressText.text = val_3.ToString(format:  "N0")(val_3.ToString(format:  "N0")) + "%"("%");
        }
        public EpisodeRow()
        {
        
        }
    
    }

}
