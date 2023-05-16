using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View
{
    public class CookieJarCollectHelper : IGameContextUnit, IContextUnit, ILateContextUnit
    {
        // Fields
        private Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory;
        private UnityEngine.Vector3 goalPosition;
        private Royal.Scenes.Game.Levels.Units.GoalManager goalManager;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData> collectList;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.CookieJarItemModel> cookieJars;
        private readonly Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectSorter sorter;
        private const int RunInterval = 2;
        private const float MaxCollectDelay = 0.15;
        private int collectAccumulationStartFrame;
        private bool shouldExplodeAll;
        private bool isParticlesPlayed;
        
        // Properties
        public int Id { get; }
        private UnityEngine.Vector3 GoalPosition { get; }
        
        // Methods
        public int get_Id()
        {
            return 36;
        }
        private UnityEngine.Vector3 get_GoalPosition()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.goalPosition, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return new UnityEngine.Vector3() {x = this.goalPosition, y = V8.16B, z = V9.16B};
            }
            
            UnityEngine.Vector3 val_3 = this.goalManager.GetGoalPosition(goalType:  39);
            this.goalPosition = val_3;
            mem[1152921523771274172] = val_3.y;
            mem[1152921523771274176] = val_3.z;
            return new UnityEngine.Vector3() {x = this.goalPosition, y = V8.16B, z = V9.16B};
        }
        public void Bind()
        {
            this.itemFactory = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory>(contextId:  1);
            this.goalManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.GoalManager>(contextId:  11);
            Royal.Scenes.Game.Context.GameContext.RegisterToLateUpdate(lateUpdate:  new System.Action(object:  this, method:  System.Void Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieJarCollectHelper::ManualLateUpdate()));
        }
        private void ManualLateUpdate()
        {
            var val_2;
            var val_3;
            var val_9;
            System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData> val_10;
            if((this.shouldExplodeAll == false) || (this.isParticlesPlayed == false))
            {
                goto label_29;
            }
            
            this.shouldExplodeAll = false;
            List.Enumerator<T> val_1 = this.cookieJars.GetEnumerator();
            label_11:
            val_9 = public System.Boolean List.Enumerator<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.CookieJarItemModel>::MoveNext();
            if((1984828272 & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_9 = mem[val_2 + 600];
            val_9 = val_2 + 600;
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            FinalViewExplode();
            goto label_11;
            label_4:
            val_3.Dispose();
            label_29:
            if(this.collectList == null)
            {
                    return;
            }
            
            int val_8 = this.collectAccumulationStartFrame;
            val_8 = Royal.Scenes.Game.Levels.LevelContext.FrameCount - val_8;
            if(val_8 < 2)
            {
                    return;
            }
            
            if(val_8 == 2)
            {
                    this.collectList.Sort(comparer:  this.sorter);
                val_10 = this.collectList;
                if(1152921515850692096 >= 1)
            {
                    var val_10 = 0;
                if(1152921515850692096 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_9 = 0f;
                val_9 = (0.15f / (4.798072E+07f)) * val_9;
                mem2[0] = val_9;
                val_10 = this.collectList;
                val_10 = val_10 + 1;
            }
            
                val_10.Clear();
                return;
            }
            
            this.collectAccumulationStartFrame = Royal.Scenes.Game.Levels.LevelContext.FrameCount;
        }
        public void AddCookieJar(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.CookieJarItemModel cookieJar)
        {
            this.cookieJars.Add(item:  cookieJar);
        }
        public void Clear(bool gameExit)
        {
            this.shouldExplodeAll = false;
            this.isParticlesPlayed = false;
            this.collectAccumulationStartFrame = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.goalPosition = val_1;
            mem[1152921523771831740] = val_1.y;
            mem[1152921523771831744] = val_1.z;
            this.collectList.Clear();
            this.cookieJars.Clear();
        }
        public void MarkForExplode()
        {
            this.shouldExplodeAll = true;
        }
        public void Collect(Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData mailCollectData, Royal.Scenes.Game.Mechanics.Explode.Trigger trigger)
        {
            this.goalManager.FlyingToBeCollected(goalType:  39);
            Royal.Scenes.Game.Levels.Units.GoalManager val_9 = this.goalManager;
            val_9 = (this.goalManager.GetGoalUiLeftCount(goalType:  39)) - (val_9.GetFlyingGoalCount(goalType:  39));
            if((val_9 <= 0) && (this.shouldExplodeAll != true))
            {
                    if(trigger == 14)
            {
                    UnityEngine.Coroutine val_4 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.StartPlayingParticlesDelayed(delay:  0.06f));
            }
            else
            {
                    this.StartPlayingParticles();
            }
            
                this.shouldExplodeAll = true;
            }
            
            Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView val_5 = this.itemFactory.Spawn<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieGoalView>(poolId:  116, activate:  true);
            UnityEngine.Vector3 val_6 = this.GoalPosition;
            var val_10 = 0;
            if(mem[1152921505105551360] != null)
            {
                    val_10 = val_10 + 1;
            }
            else
            {
                    Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate val_7 = 1152921505105514496 + ((mem[1152921505105551368]) << 4);
            }
            
            new System.Action() = new System.Action(object:  mailCollectData.itemView.itemViewDelegate, method:  public System.Void Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.ICookieJarItemViewDelegate::OnGoalReached());
            val_5.InitAndMove(parent:  mailCollectData.itemView, targetPosition:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, onComplete:  new System.Action());
            mailCollectData = val_5;
            this.collectList.Add(item:  mailCollectData);
        }
        private void StartPlayingParticles()
        {
            List.Enumerator<T> val_1 = this.cookieJars.GetEnumerator();
            label_4:
            if((1985560360 & 1) == 0)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.OnGoalStartedReaching();
            goto label_4;
            label_2:
            0.Dispose();
            this.isParticlesPlayed = true;
        }
        private System.Collections.IEnumerator StartPlayingParticlesDelayed(float delay)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .delay = delay;
            return (System.Collections.IEnumerator)new CookieJarCollectHelper.<StartPlayingParticlesDelayed>d__22();
        }
        public int GetFlyingGoalCount()
        {
            if(this.goalManager != null)
            {
                    return this.goalManager.GetFlyingGoalCount(goalType:  39);
            }
            
            throw new NullReferenceException();
        }
        public int GetExpectedCollectCount()
        {
            var val_4;
            var val_5;
            bool val_4 = true;
            var val_5 = 0;
            val_4 = 0;
            val_5 = 0;
            label_6:
            if(val_5 >= val_4)
            {
                goto label_2;
            }
            
            if(val_4 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            val_4 = ((true + 0) + 32 + 96.GetIncomingCount()) + val_4;
            val_5 = ((true + 0) + 32) + val_5;
            val_5 = val_5 + 1;
            if(this.cookieJars != null)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_2:
            int val_2 = this.GetFlyingGoalCount();
            val_2 = (val_4 + val_5) + val_2;
            return (int)val_2;
        }
        public CookieJarCollectHelper()
        {
            this.collectList = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectData>(capacity:  20);
            this.cookieJars = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Items.CookieJarItem.CookieJarItemModel>(capacity:  20);
            this.sorter = new Royal.Scenes.Game.Mechanics.Items.CookieJarItem.View.CookieCollectSorter();
        }
    
    }

}
