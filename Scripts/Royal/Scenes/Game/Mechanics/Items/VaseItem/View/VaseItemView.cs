using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.VaseItem.View
{
    public class VaseItemView : ItemView
    {
        // Fields
        public static float tntExplodeTimeMultiplier;
        public static float tntExplodeAngleMultiplier;
        public static int angle1;
        public static int angle2;
        public static int angle3;
        public static float dur1;
        public static float dur2;
        public static float dur3;
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.Transform baseViewPivotRight;
        public UnityEngine.Transform baseViewPivotLeft;
        private Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemAssets itemAssets;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        
        // Methods
        private void Start()
        {
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer)
        {
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemAssets>();
            this.itemAssets = val_1;
            this.baseView.sprite = val_1.GetSpriteForLayer(layer:  layer);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 33;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
        
        }
        public void Explode()
        {
            PlaySfx(type:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  2)) != 0) ? (259 + 1) : 259, offset:  0.04f);
            this.SpawnParticle(particleLayer:  0);
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView>(go:  this);
        }
        public void Damage(int damagedLayer, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            PlaySfx(type:  ((Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  2)) != 0) ? (261 + 1) : 261, offset:  0.04f);
            this.baseView.sprite = this.itemAssets.GetSpriteForLayer(layer:  damagedLayer);
            this.SpawnParticle(particleLayer:  damagedLayer);
            this.PlayShakeAnimation(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        private void SpawnParticle(int particleLayer)
        {
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemExplodeParticles val_1 = 41656.Spawn<Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemExplodeParticles>(poolId:  34, activate:  true);
            val_1.Play(particleLayer:  particleLayer);
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            if(particleLayer != 0)
            {
                    return;
            }
            
            if(Royal.Player.Context.Units.LevelManager.IsStoryLevel == false)
            {
                    return;
            }
            
            StoryItemCollection val_7 = UnityEngine.Object.Instantiate<StoryItemCollection>(original:  UnityEngine.Resources.Load<StoryItemCollection>(path:  "StoryItemCollected"));
            UnityEngine.Vector3 val_10 = this.baseView.transform.position;
            val_7.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_7.Init();
        }
        private void PlayShakeAnimation(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ShakeCoroutine(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}));
        }
        private System.Collections.IEnumerator ShakeCoroutine(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            .<>1__state = 0;
            .<>4__this = this;
            mem[1152921520009492424] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new VaseItemView.<ShakeCoroutine>d__22();
        }
        public VaseItemView()
        {
        
        }
        private static VaseItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.tntExplodeTimeMultiplier = 1.3f;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.tntExplodeAngleMultiplier = 1.5f;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.angle1 = 9;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.angle2 = 5;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.angle3 = -2;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.dur1 = 0.05f;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.dur2 = 0.075f;
            Royal.Scenes.Game.Mechanics.Items.VaseItem.View.VaseItemView.dur3 = 0.1f;
        }
    
    }

}
