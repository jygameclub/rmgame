using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.RockItem.View
{
    public class RockItemView : ItemView
    {
        // Fields
        public static int angle1;
        public static int angle2;
        public static int angle3;
        public static float dur1;
        public static float dur2;
        public static float dur3;
        public UnityEngine.SpriteRenderer baseView;
        public UnityEngine.Transform baseViewPivotRight;
        public UnityEngine.Transform baseViewPivotLeft;
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemAssets itemAssets;
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles particles;
        private Royal.Scenes.Game.Mechanics.Items.RockItem.View.IRockItemViewDelegate viewDelegate;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        
        // Methods
        private void Start()
        {
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
        }
        public void Init(Royal.Scenes.Game.Mechanics.Items.RockItem.View.IRockItemViewDelegate viewDelegate, UnityEngine.Vector3 position, int layer)
        {
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemAssets val_1 = 185636.Load<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemAssets>();
            this.itemAssets = val_1;
            this.viewDelegate = viewDelegate;
            this.baseView.sprite = val_1.GetSpriteForLayer(layer:  layer);
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
        public override int GetPoolId()
        {
            return 101;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.Recycle<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles>(go:  this.particles);
            this.particles = 0;
        }
        public void CollectToGoal()
        {
            PlaySfx(type:  SelectRandomClip(from:  232, to:  233), offset:  0.04f);
            this.PlayExplodeParticles(newLayer:  0);
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView>(go:  this);
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView val_2 = this.Spawn<Royal.Scenes.Game.Mechanics.Items.RockItem.View.GemGoalView>(poolId:  103, activate:  true);
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_2.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_2.Play(viewDelegate:  this.viewDelegate);
        }
        public void Damage(int damagedLayer, Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            X22.PlaySfx(type:  X22.SelectRandomClip(from:  230, to:  231), offset:  0.04f);
            this.baseView.sprite = this.itemAssets.GetSpriteForLayer(layer:  damagedLayer);
            this.PlayExplodeParticles(newLayer:  damagedLayer);
            this.PlayShakeAnimation(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id});
        }
        private void PlayExplodeParticles(int newLayer)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemExplodeParticles>(poolId:  102, activate:  true);
            this.particles = val_2;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_3:
            label_5:
            this.particles.Play(layer:  newLayer);
            UnityEngine.Vector3 val_5 = this.transform.position;
            this.particles.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            if(newLayer != 0)
            {
                    return;
            }
            
            this.particles = 0;
        }
        private void PlayShakeAnimation(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.ShakeCoroutine(data:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = data.point.x}, id = data.id}));
        }
        private System.Collections.IEnumerator ShakeCoroutine(Royal.Scenes.Game.Mechanics.Explode.ExplodeData data)
        {
            .<>1__state = 0;
            .<>4__this = this;
            mem[1152921520183164056] = data.id;
            .data = data.point.x;
            return (System.Collections.IEnumerator)new RockItemView.<ShakeCoroutine>d__22();
        }
        public RockItemView()
        {
        
        }
        private static RockItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView.angle1 = 9;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView.angle2 = 5;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView.angle3 = -2;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView.dur1 = 0.05f;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView.dur2 = 0.075f;
            Royal.Scenes.Game.Mechanics.Items.RockItem.View.RockItemView.dur3 = 0.1f;
        }
    
    }

}
