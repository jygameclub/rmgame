using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy
{
    public class HorizontalRocketStrategy : RocketStrategy
    {
        // Fields
        private static readonly int HorizontalRocketCreationStateId;
        private int finishedPartCount;
        private readonly System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> explodedCells;
        
        // Methods
        public HorizontalRocketStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView view, Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets itemAssets, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
            this.explodedCells = new System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel>(capacity:  10);
        }
        public override void SetSprites()
        {
            169284.gameObject.SetActive(value:  false);
            UnityEngine.GameObject val_2 = 0.gameObject;
            val_2.SetActive(value:  false);
            0.sprite = val_2.GetHorizontalSprite();
            1039068911.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            1042983595.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            -1135280652.sprite = 1042983595.GetRocketShadow();
            -1135280652.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Transform val_7 = -1135280652.transform;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0f);
            val_7.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
            sprite = val_7.GetHorizontalLeftSprite();
            UnityEngine.Transform val_10 = transform;
            val_10.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            -1.sprite = val_10.GetHorizontalRightSprite();
            -1.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            64.gameObject.SetActive(value:  false);
            -1.gameObject.SetActive(value:  false);
        }
        public override void PlayCreationAnimation(float startTime = 0, bool playSound = True)
        {
            if(playSound != false)
            {
                    19037.PlaySfx(type:  234, offset:  0.04f);
            }
            
            48.gameObject.SetActive(value:  true);
            0.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy.HorizontalRocketCreationStateId, layer:  0, normalizedTime:  startTime);
        }
        public override bool IsCreationAnimationPlaying()
        {
            float val_3;
            var val_6;
            var val_7;
            UnityEngine.AnimatorStateInfo val_1 = 169028.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_6 = null;
            val_6 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy.HorizontalRocketCreationStateId)
            {
                    var val_5 = (val_3 < 0) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public override void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> leftList, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> rightList)
        {
            19039.PlaySfx(type:  235, offset:  0.04f);
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.PlayHorizontalRocket(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, cell:  cell, leftList:  leftList, rightList:  rightList));
        }
        private System.Collections.IEnumerator PlayHorizontalRocket(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> leftList, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> rightList)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .cell = cell;
            .leftList = leftList;
            .rightList = rightList;
            mem[1152921520093362024] = exploder.id;
            .exploder = exploder.point.x;
            return (System.Collections.IEnumerator)new HorizontalRocketStrategy.<PlayHorizontalRocket>d__8();
        }
        private float StartLeftPart(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> leftList, out Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles particles1)
        {
            169284.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = 169284.transform.position;
            float val_12 = -1.084202E-19f;
            val_12 = val_12 * (-0.5f);
            float val_4 = val_12 + (-1f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4, y = val_3.y, z = 0f});
            UnityEngine.Coroutine val_8 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MoveToGlobalAndDestroy(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, trans:  exploder.id + 144.transform, targetPosition:  new UnityEngine.Vector3() {x = val_4, y = val_3.y, z = 0f}, rocketCell:  cell, cellList:  leftList));
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.right;
            float val_13 = 13.5f;
            particles1 = this.GetParticles(parent:  transform, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_13 = val_5.x / val_13;
            return (float)val_13;
        }
        private float StartRightPart(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> rightList, out Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemParticles particles2)
        {
            16605.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = 16605.transform.position;
            float val_12 = -1.084202E-19f;
            val_12 = val_12 * 0.5f;
            float val_4 = val_12 + 1f;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4, y = val_3.y, z = 0f});
            UnityEngine.Coroutine val_8 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.MoveToGlobalAndDestroy(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, trans:  exploder.id + 152.transform, targetPosition:  new UnityEngine.Vector3() {x = val_4, y = val_3.y, z = 0f}, rocketCell:  cell, cellList:  rightList));
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            float val_13 = 13.5f;
            particles2 = this.GetParticles(parent:  Royal.Scenes.Game.Context.GameContext.__il2cppRuntimeField_methods.transform, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_13 = val_5.x / val_13;
            return (float)val_13;
        }
        private System.Collections.IEnumerator MoveToGlobalAndDestroy(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, UnityEngine.Transform trans, UnityEngine.Vector3 targetPosition, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel rocketCell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellList)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .targetPosition = targetPosition;
            mem[1152921520093968228] = targetPosition.y;
            mem[1152921520093968232] = targetPosition.z;
            .trans = trans;
            .rocketCell = rocketCell;
            mem[1152921520093968272] = exploder.id;
            .exploder = exploder.point.x;
            .cellList = cellList;
            return (System.Collections.IEnumerator)new HorizontalRocketStrategy.<MoveToGlobalAndDestroy>d__11();
        }
        private void TryUnfreezeAll()
        {
            int val_1 = this.finishedPartCount;
            val_1 = val_1 + 1;
            this.finishedPartCount = val_1;
            if(val_1 < 2)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                if(val_2 >= val_1)
            {
                    return;
            }
            
                if(val_1 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_1 = val_1 + 0;
                ((this.finishedPartCount + 1) + 0) + 32.UnFreezeFall();
                val_2 = val_2 + 1;
            }
            while(this.explodedCells != null);
            
            throw new NullReferenceException();
        }
        private bool ShouldCallExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, UnityEngine.Vector3 currentPos)
        {
            UnityEngine.Vector3 val_1 = cellModel.GetViewPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = currentPos.x, y = currentPos.y, z = currentPos.z});
            return (bool)(System.Math.Abs(val_2.x) < 0) ? 1 : 0;
        }
        private static HorizontalRocketStrategy()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.HorizontalRocketStrategy.HorizontalRocketCreationStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.HorizontalRocketCreationAnimation");
        }
    
    }

}
