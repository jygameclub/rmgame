using UnityEngine;

namespace Royal.Scenes.Game.Ui.Top.King
{
    public class KingUi : MonoBehaviour
    {
        // Fields
        private const int StartWorryMoveCount = 3;
        public Spine.Unity.SkeletonAnimation kingAnim;
        public Spine.Unity.AnimationReferenceAsset[] idleConnects;
        public Spine.Unity.AnimationReferenceAsset[] idleLoops;
        public Spine.Unity.AnimationReferenceAsset sad;
        public Spine.Unity.AnimationReferenceAsset happy;
        public Spine.Unity.AnimationReferenceAsset worryStart;
        public Spine.Unity.AnimationReferenceAsset worryLoop;
        private int movesLeft;
        private bool stopAnimationsCycle;
        private Royal.Scenes.Game.Levels.Units.LevelRandomManager randomManager;
        private bool isBonusLevel;
        
        // Methods
        private void Awake()
        {
            this.randomManager = Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.LevelRandomManager>(contextId:  0);
            this.isBonusLevel = Royal.Player.Context.Data.Session.__il2cppRuntimeField_24;
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimationsCycle(shouldSetFirstAnimation:  false));
            Royal.Scenes.Game.Levels.LevelContext.Get<Royal.Scenes.Game.Levels.Units.MoveManager>(contextId:  10).add_OnMoveChanged(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Royal.Scenes.Game.Ui.Top.King.KingUi::MoveChanged(int moves)));
        }
        private void MoveChanged(int moves)
        {
            if(moves == 0)
            {
                    return;
            }
            
            if(this.movesLeft == 0)
            {
                goto label_1;
            }
            
            if(this.movesLeft >= moves)
            {
                goto label_6;
            }
            
            label_5:
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.AnimationsCycle(shouldSetFirstAnimation:  (this.movesLeft == 0) ? 1 : 0));
            label_6:
            this.movesLeft = moves;
            if(moves != 3)
            {
                    return;
            }
            
            if(this.isBonusLevel == true)
            {
                    return;
            }
            
            this.BeWorry();
            return;
            label_1:
            if(this.stopAnimationsCycle == true)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        public void PrepareForLeagueLevel()
        {
            21351.SetAttachment(slotName:  "sag frame", attachmentName:  "red frame");
            21351.SetAttachment(slotName:  "sol frame", attachmentName:  "red frame");
        }
        public void PrepareForHardLevel(sbyte difficulty)
        {
            string val_2;
            if((difficulty & 255) == 1)
            {
                    val_2 = "red2 frame";
            }
            else
            {
                    val_2 = "purple frame";
            }
            
            21350.SetAttachment(slotName:  "sag frame", attachmentName:  val_2);
            21350.SetAttachment(slotName:  "sol frame", attachmentName:  "purple frame");
        }
        public void ChangeKingPanelParent(UnityEngine.Transform parent, Royal.Scenes.Game.Mechanics.Sortings.SortingData sortingData)
        {
            this.transform.SetParent(p:  parent);
            Royal.Infrastructure.Utils.Sprite.SpriteExtensions.SetSorting(group:  this.gameObject.AddComponent<UnityEngine.Rendering.SortingGroup>(), data:  new Royal.Scenes.Game.Mechanics.Sortings.SortingData() {layer = sortingData.layer, order = sortingData.order, sortEverything = sortingData.sortEverything & 4294967295});
        }
        public void ResetKingPanelParent(UnityEngine.Transform parent)
        {
            UnityEngine.Object.Destroy(obj:  this.GetComponent<UnityEngine.Rendering.SortingGroup>());
            this.transform.SetParent(p:  parent);
        }
        private System.Collections.IEnumerator AnimationsCycle(bool shouldSetFirstAnimation)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .shouldSetFirstAnimation = shouldSetFirstAnimation;
            return (System.Collections.IEnumerator)new KingUi.<AnimationsCycle>d__19();
        }
        private void BeWorry()
        {
            this.stopAnimationsCycle = true;
            Spine.TrackEntry val_2 = this.kingAnim.state.SetAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.worryStart), loop:  false);
            Spine.TrackEntry val_4 = this.kingAnim.state.AddAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.worryLoop), loop:  true, delay:  0f);
        }
        public void StopWorry()
        {
            if(this.isBonusLevel != false)
            {
                    return;
            }
            
            if(this.stopAnimationsCycle == false)
            {
                    return;
            }
            
            if(this.movesLeft > 3)
            {
                    return;
            }
            
            Spine.TrackEntry val_2 = this.kingAnim.state.SetAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.idleConnects[0]), loop:  false);
            Spine.TrackEntry val_4 = this.kingAnim.state.AddAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.idleConnects[1]), loop:  true, delay:  0f);
        }
        public void BeHappy()
        {
            this.stopAnimationsCycle = true;
            Spine.TrackEntry val_2 = this.kingAnim.state.SetAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.happy), loop:  false);
            Spine.TrackEntry val_4 = this.kingAnim.state.AddAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.idleConnects[1]), loop:  false, delay:  0f);
            Spine.TrackEntry val_6 = this.kingAnim.state.AddAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.idleConnects[0]), loop:  true, delay:  0f);
        }
        public void BeSad()
        {
            this.movesLeft = 0;
            this.stopAnimationsCycle = true;
            Spine.TrackEntry val_2 = this.kingAnim.state.SetAnimation(trackIndex:  0, animation:  Spine.Unity.AnimationReferenceAsset.op_Implicit(asset:  this.sad), loop:  false);
        }
        public KingUi()
        {
        
        }
    
    }

}
