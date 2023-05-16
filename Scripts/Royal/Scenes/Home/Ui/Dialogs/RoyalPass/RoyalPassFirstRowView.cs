using UnityEngine;

namespace Royal.Scenes.Home.Ui.Dialogs.RoyalPass
{
    public class RoyalPassFirstRowView : RoyalPassView
    {
        // Fields
        public UnityEngine.Transform freeParent;
        public UnityEngine.Transform goldParent;
        public UnityEngine.SpriteRenderer freeHighlightLeft;
        public UnityEngine.SpriteRenderer freeHighlightRight;
        public UnityEngine.SpriteRenderer goldHighlightLeft;
        public UnityEngine.SpriteRenderer goldHighlightRight;
        public UnityEngine.SpriteRenderer fleur;
        public UnityEngine.SpriteRenderer backgroundPatch;
        public Royal.Infrastructure.UiComponents.Button.UiScrollButton goldTicketButton;
        public UnityEngine.BoxCollider2D goldTicketCollider;
        private Royal.Scenes.Home.Ui.Dialogs.RoyalPass.RoyalPassFirstRowGoldTicketParticleView goldTicketParticleView;
        private System.Action showRoyalPassPurchase;
        
        // Methods
        public void Init(UnityEngine.Bounds maskBounds, System.Action showRoyalPassPurchase)
        {
            this.showRoyalPassPurchase = showRoyalPassPurchase;
            this.goldTicketButton = maskBounds.m_Extents.y;
            this.goldTicketButton = maskBounds.m_Center.x;
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            float val_11 = val_1.cameraWidth;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_11 * (-0.25f), y:  -0.056f);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            val_11 = val_11 * 0.25f;
            this.freeParent.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_11, y:  -0.056f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            this.goldParent.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            this.SetFleur();
            float val_12 = val_1.cameraWidth;
            val_12 = val_12 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.freeHighlightLeft, xPosition:  val_12 * (-0.25f), targetSize:  val_12);
            float val_13 = val_1.cameraWidth;
            val_13 = val_13 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.freeHighlightRight, xPosition:  val_13 * (-0.25f), targetSize:  val_13);
            float val_14 = val_1.cameraWidth;
            val_14 = val_14 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.goldHighlightLeft, xPosition:  val_14, targetSize:  val_14);
            float val_15 = val_1.cameraWidth;
            val_15 = val_15 * 0.25f;
            this.SetXPositionTransformAndXScale(spriteRenderer:  this.goldHighlightRight, xPosition:  val_15, targetSize:  val_15);
            float val_16 = 1.011f;
            val_16 = val_1.cameraWidth * val_16;
            this.SetXPositionTransformAndXSize(spriteRenderer:  this.backgroundPatch, xPosition:  0f, xSize:  val_16);
            this.SetGoldTicketParticle();
            this.goldTicketCollider.enabled = (~(Royal.Player.Context.Units.UserManager.<CurrentUser>k__BackingField.HasRoyalPass)) & 1;
        }
        public void OnRoyalPassClicked()
        {
            if(this.showRoyalPassPurchase == null)
            {
                    return;
            }
            
            this.showRoyalPassPurchase.Invoke();
        }
        private void SetFleur()
        {
            Royal.Infrastructure.Contexts.Units.CameraManager val_1 = Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Contexts.Units.CameraManager>(id:  1);
            float val_6 = val_1.cameraWidth;
            val_6 = (val_6 * 0.5f) + (val_6 * 0.5f);
            val_6 = val_6 / 1.257143f;
            int val_3 = UnityEngine.Mathf.CeilToInt(f:  val_6);
            var val_4 = (val_3 < 0) ? (val_3 + 1) : (val_3);
            val_4 = val_4 & 4294967294;
            val_4 = val_3 - val_4;
            var val_5 = (val_4 != 1) ? (2 + 1) : 2;
            val_5 = val_5 + val_3;
            float val_7 = (float)val_5;
            val_7 = val_7 * 1.257143f;
            this.SetXPositionTransformAndXSize(spriteRenderer:  this.fleur, xPosition:  -0.9970143f, xSize:  val_7);
        }
        private void SetGoldTicketParticle()
        {
            if(this.goldTicketParticleView != 0)
            {
                    return;
            }
            
            this.goldTicketParticleView = Royal.Player.Context.UserContext.Get<Royal.Player.Context.Units.RoyalPassManager>(id:  12).Spawn(poolId:  10, parent:  this.goldParent, setParent:  true);
        }
        public override int GetPoolId()
        {
            return 0;
        }
        public RoyalPassFirstRowView()
        {
        
        }
    
    }

}
