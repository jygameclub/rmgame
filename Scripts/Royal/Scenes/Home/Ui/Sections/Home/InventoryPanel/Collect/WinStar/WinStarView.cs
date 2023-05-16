using UnityEngine;

namespace Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.Collect.WinStar
{
    public class WinStarView : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject starObject;
        public UnityEngine.GameObject starImage;
        public UnityEngine.SpriteRenderer starShadow;
        public UnityEngine.ParticleSystem starHitParticles;
        public UnityEngine.ParticleSystem starAppearParticles;
        public UnityEngine.ParticleSystem starTrailParticles;
        private Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView starInfoView;
        
        // Methods
        public void Play(Royal.Scenes.Home.Ui.Sections.Home.InventoryPanel.StarInfoView starInfoView, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.starInfoView = starInfoView;
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.GetComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.PlayAnimation());
        }
        private System.Collections.IEnumerator PlayAnimation()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new WinStarView.<PlayAnimation>d__8();
        }
        private void PrepareStarToAnimation()
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.down;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  3.65f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            this.starObject.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.starObject.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0f);
            this.starImage.transform.rotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.ChangeAlpha(sprite:  this.starShadow, alpha:  0.8f);
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0f);
            this.starShadow.transform.rotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        }
        public WinStarView()
        {
        
        }
    
    }

}
