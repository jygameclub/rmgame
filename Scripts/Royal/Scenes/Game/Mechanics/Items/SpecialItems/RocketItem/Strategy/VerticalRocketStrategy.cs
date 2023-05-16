using UnityEngine;

namespace Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy
{
    public class VerticalRocketStrategy : RocketStrategy
    {
        // Fields
        private static readonly int VerticalRocketCreationStateId;
        
        // Methods
        public VerticalRocketStrategy(Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemView view, Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.View.RocketItemAssets itemAssets, Royal.Scenes.Game.Levels.Units.ItemCreation.ItemFactory itemFactory)
        {
        
        }
        public override void SetSprites()
        {
            169028.gameObject.SetActive(value:  false);
            UnityEngine.GameObject val_2 = 0.gameObject;
            val_2.SetActive(value:  false);
            0.sprite = val_2.GetVerticalSprite();
            1039068911.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            0.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            -1135280652.sprite = 0.GetRocketShadow();
            -1135280652.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Transform val_7 = -1135280652.transform;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  90f);
            val_7.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
            64.sprite = val_7.GetVerticalTopSprite();
            UnityEngine.Transform val_10 = 64.transform;
            val_10.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            -1.sprite = val_10.GetVerticalBottomSprite();
            -1.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            64.gameObject.SetActive(value:  false);
            -1.gameObject.SetActive(value:  false);
        }
        public override void PlayCreationAnimation(float startTime, bool playSound = True)
        {
            if(playSound != false)
            {
                    41799.PlaySfx(type:  234, offset:  0.04f);
            }
            
            32.gameObject.SetActive(value:  true);
            0.Play(stateNameHash:  Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy.VerticalRocketCreationStateId, layer:  0, normalizedTime:  startTime);
        }
        public override bool IsCreationAnimationPlaying()
        {
            float val_3;
            var val_6;
            var val_7;
            UnityEngine.AnimatorStateInfo val_1 = 169028.GetCurrentAnimatorStateInfo(layerIndex:  0);
            val_6 = null;
            val_6 = null;
            if( == Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy.VerticalRocketCreationStateId)
            {
                    var val_5 = (val_3 < 0) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public override void Play(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cell, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> firstList, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> secondList)
        {
            41801.PlaySfx(type:  235, offset:  0.04f);
            UnityEngine.Coroutine val_2 = Royal.Scenes.Game.Context.GameContext.ManualStartCoroutine(iEnumerator:  this.PlayVerticalRocket(exploder:  new Royal.Scenes.Game.Mechanics.Explode.ExplodeData() {point = new Royal.Scenes.Game.Mechanics.Board.Cell.CellPoint() {x = exploder.point.x}, id = exploder.id}, topList:  firstList, bottomList:  secondList));
        }
        private System.Collections.IEnumerator PlayVerticalRocket(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> topList, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> bottomList)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .topList = topList;
            .bottomList = bottomList;
            mem[1152921520097162760] = exploder.id;
            .exploder = exploder.point.x;
            return (System.Collections.IEnumerator)new VerticalRocketStrategy.<PlayVerticalRocket>d__6();
        }
        private void EnableFillMask(UnityEngine.GameObject particles)
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                particles.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>(includeInactive:  true)[val_3].maskInteraction = 2;
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        private void DisableFillMask(UnityEngine.GameObject particles)
        {
            if(val_1.Length < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                particles.GetComponentsInChildren<UnityEngine.ParticleSystemRenderer>(includeInactive:  true)[val_3].maskInteraction = 0;
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1.Length);
        
        }
        private System.Collections.IEnumerator MoveToGlobalAndDestroy(Royal.Scenes.Game.Mechanics.Explode.ExplodeData exploder, UnityEngine.Transform trans, UnityEngine.Vector3 targetPosition, System.Collections.Generic.List<Royal.Scenes.Game.Mechanics.Board.Cell.CellModel> cellList)
        {
            .<>1__state = 0;
            .<>4__this = this;
            .trans = trans;
            .targetPosition = targetPosition;
            mem[1152921520097712772] = targetPosition.y;
            mem[1152921520097712776] = targetPosition.z;
            mem[1152921520097712808] = exploder.id;
            .exploder = exploder.point.x;
            .cellList = cellList;
            return (System.Collections.IEnumerator)new VerticalRocketStrategy.<MoveToGlobalAndDestroy>d__9();
        }
        protected bool ShouldCallExplode(Royal.Scenes.Game.Mechanics.Board.Cell.CellModel cellModel, UnityEngine.Vector3 currentPos)
        {
            UnityEngine.Vector3 val_1 = cellModel.GetViewPosition();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = currentPos.x, y = currentPos.y, z = currentPos.z});
            return (bool)(System.Math.Abs(val_2.y) < 0) ? 1 : 0;
        }
        private static VerticalRocketStrategy()
        {
            Royal.Scenes.Game.Mechanics.Items.SpecialItems.RocketItem.Strategy.VerticalRocketStrategy.VerticalRocketCreationStateId = UnityEngine.Animator.StringToHash(name:  "Base Layer.VerticalRocketCreationAnimation");
        }
    
    }

}
