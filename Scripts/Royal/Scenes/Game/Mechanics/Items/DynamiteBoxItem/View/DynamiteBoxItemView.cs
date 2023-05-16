using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View
{
    public class DynamiteBoxItemView : ItemView
    {
        // Fields
        private static readonly int DynamiteBoxIdle;
        private static readonly int DynamiteBoxShake;
        private static readonly int DynamiteBoxExplode;
        private static readonly int DynamiteArkaIdle;
        private static readonly int DynamiteArkaKisalma;
        private static readonly int DynamiteArkaSallanma;
        private static readonly int DynamiteArkaSallanma2;
        private static readonly int DynamiteOnIdle;
        private static readonly int DynamiteOnKisalma;
        private static readonly int DynamiteOnSallanma;
        private static readonly int DynamiteOnSallanma2;
        public UnityEngine.Animator dynamiteBoxAnimator;
        public UnityEngine.Animator[] dynamiteAnimators;
        public UnityEngine.SpriteRenderer[] wicks;
        private Royal.Scenes.Game.Mechanics.Matches.MatchType[] dynamiteTypes;
        private readonly Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles[] sparkParticles;
        private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.IDynamiteBoxItemDelegate viewDelegate;
        private readonly UnityEngine.Vector3[] originalWickPositions;
        private readonly UnityEngine.Vector3[] originalWickScales;
        private Royal.Scenes.Game.Levels.Units.MoveManager moveManager;
        
        // Methods
        public void Init(Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.IDynamiteBoxItemDelegate viewDelegate, UnityEngine.Vector3 position, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Matches.MatchType> items)
        {
            var val_7;
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            this.InitTransform(viewDelegate:  viewDelegate, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
            this.dynamiteTypes = items.ToArray();
            this.viewDelegate = viewDelegate;
            this.moveManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10);
            var val_9 = 0;
            label_13:
            if(val_9 >= this.dynamiteAnimators.Length)
            {
                goto label_3;
            }
            
            val_7 = null;
            UnityEngine.Animator val_8 = this.dynamiteAnimators[val_9];
            if((val_9 & 1) != 0)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_9 = 1152921505102270492;
            if(val_8 != null)
            {
                goto label_8;
            }
            
            label_5:
            val_10 = null;
            val_9 = 1152921505102270476;
            label_8:
            val_8.Play(stateNameHash:  val_9, layer:  0, normalizedTime:  0f);
            val_9 = val_9 + 1;
            if(this.dynamiteAnimators != null)
            {
                goto label_13;
            }
            
            label_3:
            this.dynamiteBoxAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteBoxIdle, layer:  0, normalizedTime:  0f);
            var val_12 = 0;
            val_11 = 40;
            do
            {
                if(val_12 >= this.wicks.Length)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_4 = this.wicks[val_12].transform.localPosition;
                mem2[0] = val_4.x;
                mem2[0] = val_4.y;
                mem2[0] = val_4.z;
                UnityEngine.Vector3 val_6 = this.wicks[val_12].transform.localScale;
                val_12 = val_12 + 1;
                var val_7 = val_12 - 1;
                mem2[0] = val_6.x;
                mem2[0] = val_6.y;
                mem2[0] = val_6.z;
                val_11 = 40 + 12;
            }
            while(this.wicks != null);
            
            throw new NullReferenceException();
        }
        public override bool IsOneCellItem()
        {
            return false;
        }
        private bool IsBack(int index)
        {
            var val_1 = (index < 0) ? (index + 1) : index;
            val_1 = val_1 & 4294967294;
            val_1 = index - val_1;
            return (bool)(val_1 == 1) ? 1 : 0;
        }
        private int GetRandomShake(int index)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_1 = (index < 0) ? (index + 1) : index;
            val_1 = val_1 & 4294967294;
            float val_3 = UnityEngine.Random.value;
            val_4 = null;
            if((index - val_1) != 1)
            {
                goto label_1;
            }
            
            if(val_3 < 0)
            {
                goto label_2;
            }
            
            val_5 = null;
            val_6 = 1152921505102270488;
            return (int)val_6;
            label_1:
            if(val_3 < 0)
            {
                goto label_6;
            }
            
            val_7 = null;
            val_6 = 1152921505102270504;
            return (int)val_6;
            label_2:
            val_8 = null;
            val_6 = 1152921505102270484;
            return (int)val_6;
            label_6:
            val_9 = null;
            val_6 = 1152921505102270500;
            return (int)val_6;
        }
        private int GetIndexForColor(Royal.Scenes.Game.Mechanics.Matches.MatchType color)
        {
            if(color >= 5)
            {
                    throw new System.ArgumentOutOfRangeException(paramName:  "color", actualValue:  color, message:  0);
            }
            
            return (int)36597344 + (color) << 2;
        }
        public override int GetPoolId()
        {
            return 90;
        }
        public override void OnSpawn()
        {
        
        }
        public override void OnRecycle()
        {
            var val_4;
            var val_9 = 0;
            label_14:
            if(val_9 >= this.wicks.Length)
            {
                goto label_2;
            }
            
            this.wicks[val_9].transform.localPosition = new UnityEngine.Vector3() {x = 3.175237E+35f, y = 3.175237E+35f, z = 3.175237E+35f};
            val_9 = val_9 + 1;
            var val_3 = val_9 - 1;
            var val_4 = 40 + 12;
            this.wicks[val_9].transform.localScale = new UnityEngine.Vector3() {x = 3.175237E+35f, y = 3.175237E+35f, z = 3.175237E+35f};
            if(this.wicks != null)
            {
                goto label_14;
            }
            
            label_2:
            val_4 = 4;
            do
            {
                if((val_4 - 4) >= (this.sparkParticles.Length << ))
            {
                    return;
            }
            
                if(this.sparkParticles[0] != 0)
            {
                    Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles val_11 = this.sparkParticles[0];
                this.sparkParticles = 0;
            }
            
                val_4 = val_4 + 1;
            }
            while(this.sparkParticles != null);
            
            throw new NullReferenceException();
        }
        public override UnityEngine.Vector3 GetMasterViewCenterPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public void Damage(Royal.Scenes.Game.Mechanics.Matches.MatchType matchType, int layer, bool isNearMatch)
        {
            int val_1 = this.GetIndexForColor(color:  matchType);
            int val_2 = ((this.dynamiteTypes[val_1 << 2]) == 0) ? (val_1 + 1) : (val_1);
            this.PlayShakeAnimation();
            this.PlayShakeForDynamites();
            isNearMatch = isNearMatch;
            this.dynamiteTypes[val_2 << 2] = 0;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.DamageWithDelay(dynamiteIndex:  val_2, layer:  layer, isNearMatch:  isNearMatch));
        }
        private System.Collections.IEnumerator DamageWithDelay(int dynamiteIndex, int layer, bool isNearMatch)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .dynamiteIndex = dynamiteIndex;
            .layer = layer;
            .isNearMatch = isNearMatch;
            return (System.Collections.IEnumerator)new DynamiteBoxItemView.<DamageWithDelay>d__30();
        }
        private System.Collections.IEnumerator PlayBigParticles()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DynamiteBoxItemView.<PlayBigParticles>d__31();
        }
        private System.Collections.IEnumerator PlaySparkWithDelay(int dynamiteIndex)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .dynamiteIndex = dynamiteIndex;
            return (System.Collections.IEnumerator)new DynamiteBoxItemView.<PlaySparkWithDelay>d__32();
        }
        private System.Collections.IEnumerator ExplodeWithDelay()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new DynamiteBoxItemView.<ExplodeWithDelay>d__33();
        }
        private System.Collections.IEnumerator ShrinkWick(int dynamiteIndex)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .dynamiteIndex = dynamiteIndex;
            return (System.Collections.IEnumerator)new DynamiteBoxItemView.<ShrinkWick>d__34();
        }
        private void PlayShakeForDynamites()
        {
            Royal.Scenes.Game.Mechanics.Matches.MatchType[] val_2 = this.dynamiteTypes;
            var val_4 = 0;
            do
            {
                if(val_4 >= (this.dynamiteTypes.Length << ))
            {
                    return;
            }
            
                if(val_2[0] != 0)
            {
                    this.dynamiteAnimators[val_4].Play(stateNameHash:  this.GetRandomShake(index:  0), layer:  0, normalizedTime:  0f);
                val_2 = this.dynamiteTypes;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_2 != null);
            
            throw new NullReferenceException();
        }
        private Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles PlaySparks(UnityEngine.Transform wickParent, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles val_1 = 13228.Spawn<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles>(poolId:  91, activate:  true);
            val_1.transform.SetParent(p:  wickParent);
            val_1.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_1.Play(sortingData:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
            return val_1;
        }
        private void PlayShakeAnimation()
        {
            PlaySfx(type:  SelectRandomClip(from:  106, to:  107), offset:  0.04f);
            this.dynamiteBoxAnimator.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteBoxShake, layer:  0, normalizedTime:  0f);
        }
        public void Explode()
        {
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemExplodeParticles val_1 = 13219.Spawn<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemExplodeParticles>(poolId:  92, activate:  true);
            val_1.Play();
            UnityEngine.Transform val_2 = val_1.transform;
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_2.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_2.Recycle<Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView>(go:  this);
        }
        public override bool IsReverseSorted()
        {
            return true;
        }
        public DynamiteBoxItemView()
        {
            this.dynamiteTypes = new Royal.Scenes.Game.Mechanics.Matches.MatchType[8];
            this.sparkParticles = new Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteSparkParticles[8];
            this.originalWickPositions = new UnityEngine.Vector3[8];
            this.originalWickScales = new UnityEngine.Vector3[8];
        }
        private static DynamiteBoxItemView()
        {
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteBoxIdle = UnityEngine.Animator.StringToHash(name:  "Base Layer.DynamiteBoxIdle");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteBoxShake = UnityEngine.Animator.StringToHash(name:  "Base Layer.DynamiteBoxShake");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteBoxExplode = UnityEngine.Animator.StringToHash(name:  "Base Layer.DynamiteBoxExplode");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteArkaIdle = UnityEngine.Animator.StringToHash(name:  "Base Layer.ArkaIdle");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteArkaKisalma = UnityEngine.Animator.StringToHash(name:  "Base Layer.ArkaKisalma");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteArkaSallanma = UnityEngine.Animator.StringToHash(name:  "Base Layer.ArkaSallanma");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteArkaSallanma2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.ArkaSallanma2");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteOnIdle = UnityEngine.Animator.StringToHash(name:  "Base Layer.OnIdle");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteOnKisalma = UnityEngine.Animator.StringToHash(name:  "Base Layer.OnKisalma");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteOnSallanma = UnityEngine.Animator.StringToHash(name:  "Base Layer.OnSallanma");
            Royal.Scenes.Game.Mechanics.Items.DynamiteBoxItem.View.DynamiteBoxItemView.DynamiteOnSallanma2 = UnityEngine.Animator.StringToHash(name:  "Base Layer.OnSallanma2");
        }
    
    }

}
