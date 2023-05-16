using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View
{
    public class BirdNestItemView : ItemView
    {
        // Fields
        public UnityEngine.Animator birdNestAnimator;
        public UnityEngine.Transform[] birdParents;
        public UnityEngine.GameObject[] eggs;
        public Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Crack.BirdNestCrack[] cracks;
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird[] birds;
        private Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles particles;
        private bool isPreparedForThrow;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.Config.IItemViewDelegate birdBoxItemModel, UnityEngine.Vector3 position)
        {
            this.InitTransform(viewDelegate:  birdBoxItemModel, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.birds = new Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird[0];
            this.birdNestAnimator.Play(stateName:  "state_1", layer:  0, normalizedTime:  0f);
            Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestItemHelper>(contextId:  29).Init();
            this.ShowEggs(show:  true);
            this.ShowCracks(show:  false);
        }
        public void ShowEggs(bool show)
        {
            var val_3 = 0;
            do
            {
                if(val_3 >= this.eggs.Length)
            {
                    return;
            }
            
                this.eggs[val_3].SetActive(value:  show);
                val_3 = val_3 + 1;
            }
            while(this.eggs != null);
            
            throw new NullReferenceException();
        }
        public void ShowCracks(bool show)
        {
            var val_3 = 4;
            do
            {
                if((val_3 - 4) >= this.cracks.Length)
            {
                    return;
            }
            
                this.cracks[0].gameObject.SetActive(value:  show);
                if(show != false)
            {
                    this.cracks[0].ForceShow();
            }
            
                val_3 = val_3 + 1;
            }
            while(this.cracks != null);
            
            throw new NullReferenceException();
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = this.GetCenterPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        public override int GetPoolId()
        {
            return 98;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            this.isPreparedForThrow = false;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.particles, y:  0);
            if(val_1 != false)
            {
                    val_1.Recycle<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles>(go:  this.particles);
                this.particles = 0;
            }
            
            if(this.birds == null)
            {
                    return;
            }
            
            var val_4 = 0;
            label_12:
            if(val_4 >= (this.birds.Length << ))
            {
                goto label_6;
            }
            
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird val_3 = this.birds[val_4];
            bool val_2 = UnityEngine.Object.op_Inequality(x:  val_3, y:  0);
            if(val_2 != false)
            {
                    val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird>(go:  val_3);
            }
            
            val_4 = val_4 + 1;
            if(this.birds != null)
            {
                goto label_12;
            }
            
            throw new NullReferenceException();
            label_6:
            this.birds = 0;
        }
        public void Damage(int newLayer)
        {
            Royal.Scenes.Start.Context.Units.Audio.AudioClipType val_7;
            if(newLayer > 4)
            {
                goto label_10;
            }
            
            var val_5 = 36608388 + (newLayer) << 2;
            val_5 = val_5 + 36608388;
            goto (36608388 + (newLayer) << 2 + 36608388);
            label_15:
            int val_3 =  - 4;
            if(val_3 >= this.cracks.Length)
            {
                goto label_10;
            }
            
            this.cracks[0].PlayAppearAnimation(index:  val_3, egg:  this.eggs[0]);
             =  + 1;
            if(this.cracks != null)
            {
                goto label_15;
            }
            
            this.birdNestAnimator.Play(stateName:  "state_3", layer:  0, normalizedTime:  0f);
            val_7 = SelectRandomClip(from:  14, to:  15);
            this.birdNestAnimator.PlaySfx(type:  null, offset:  0.04f);
            label_10:
            this.PlayExplodeParticles(newLayer:  newLayer);
        }
        private void PlayExplodeParticles(int newLayer)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.particles, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles val_2 = val_1.Spawn<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestDestroyParticles>(poolId:  100, activate:  true);
            this.particles = val_2;
            if(val_2 != null)
            {
                goto label_5;
            }
            
            label_3:
            label_5:
            UnityEngine.Vector3 val_5 = this.transform.position;
            this.particles.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            this.particles.Play(layer:  newLayer);
            if(newLayer != 0)
            {
                    return;
            }
            
            this.particles = 0;
        }
        private void PrepareBirdsForThrow()
        {
            if(this.isPreparedForThrow == true)
            {
                    return;
            }
            
            this.isPreparedForThrow = true;
            var val_14 = 4;
            do
            {
                int val_1 = val_14 - 4;
                if(val_1 >= this.birdParents.Length)
            {
                    return;
            }
            
                this.birds = 6205.Spawn<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.Bird.BirdNestBird>(poolId:  99, activate:  true);
                this.birds[0].transform.SetParent(p:  this.birdParents[0]);
                this.birds[0].PlayAppearAnimation(index:  val_1, crack:  this.cracks[0]);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                this.birds[0].transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
                this.birds[0].transform.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
                val_14 = val_14 + 1;
            }
            while(this.birdParents != null);
            
            throw new NullReferenceException();
        }
        public void PlayThrowAnimations(Royal.Scenes.Game.Mechanics.Matches.Cell14 cells)
        {
            var val_2;
            if((cells.<Count>k__BackingField) >= 1)
            {
                    var val_5 = 4;
                do
            {
                this.birds[0].Move(cell:  cells.<Count>k__BackingField, index:  0);
                this.birds = 0;
                val_5 = val_5 + 1;
            }
            while((val_5 - 4) < (cells.<Count>k__BackingField));
            
            }
            
            val_2 = 4;
            do
            {
                if((val_2 - 4) >= (this.birds.Length << ))
            {
                    return;
            }
            
                if(this.birds[0] != 0)
            {
                    this.birds[0].CollectImmediately();
                this.birds = 0;
            }
            
                val_2 = val_2 + 1;
            }
            while(this.birds != null);
            
            throw new NullReferenceException();
        }
        public void Explode()
        {
            Royal.Scenes.Game.Mechanics.Matches.Cell14 val_2 = Royal.Scenes.Game.Levels.LevelContext.GetLate<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.BirdNestItemHelper>(contextId:  29).FindCells();
            this.PlayThrowAnimations(cells:  new Royal.Scenes.Game.Mechanics.Matches.Cell14());
            this.Recycle<Royal.Scenes.Game.Mechanics.Items.BirdNestItem.View.BirdNestItemView>(go:  this);
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public BirdNestItemView()
        {
        
        }
    
    }

}
