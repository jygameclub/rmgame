using UnityEngine;

namespace Royal.Scenes.Game.Levels.Units
{
    public class LevelRandomManager : IGameContextUnit, IContextUnit
    {
        // Fields
        private int seed;
        private System.Random random;
        
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 0;
        }
        public void ResetSeed()
        {
            this.SetSeed(seed:  Royal.Scenes.Start.Context.ApplicationContext.Get<Royal.Infrastructure.Utils.Randoming.RandomManager>(id:  5).Next(min:  0, max:  20000000));
        }
        public void SetSeed(int seed)
        {
            this.seed = seed;
            this.random = new System.Random(Seed:  seed);
        }
        public int GetSeed()
        {
            return (int)this.seed;
        }
        public int Next(int min, int max)
        {
            if(this.random != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public bool NextBool()
        {
            return (bool)(this.random == 0) ? 1 : 0;
        }
        public T GetRandomItemFromList<T>(System.Collections.Generic.List<T> list)
        {
            int val_1 = this.Next(min:  0, max:  list);
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public Royal.Scenes.Game.Mechanics.Matches.Cell14 ShuffleCells(Royal.Scenes.Game.Mechanics.Matches.Cell14 list)
        {
            int val_1 = (list.<Count>k__BackingField) - 1;
            if(val_1 < 1)
            {
                    throw new NullReferenceException();
            }
            
            var val_2 = 0;
            do
            {
                val_2 = val_2 + 1;
            }
            while(val_2 < val_1);
            
            throw new NullReferenceException();
        }
        public void ShuffleList<T>(System.Collections.Generic.List<T> list)
        {
            System.Collections.Generic.List<T> val_1 = list - 1;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                val_2 = val_2 + 1;
            }
            while(val_2 < val_1);
        
        }
        public void ShuffleArray<T>(T[] array)
        {
            int val_4 = array.Length;
            if(val_4 < 2)
            {
                    return;
            }
            
            var val_1 = (long)val_4 + 3;
            do
            {
                var val_2 = val_1 - 4;
                array = array[this.random];
                mem2[0] = null;
                val_1 = val_1 - 1;
                val_4 = val_4 - 1;
            }
            while((val_1 - 3) > 2);
        
        }
        public void ShuffleArray<T>(T[] array, int length)
        {
            if(length < 2)
            {
                    return;
            }
            
            int val_5 = length;
            var val_1 = (long)val_5 + 3;
            do
            {
                var val_2 = val_1 - 4;
                array = array[this.random];
                mem2[0] = null;
                val_1 = val_1 - 1;
                val_5 = val_5 - 1;
            }
            while((val_1 - 3) > 2);
        
        }
        public T RandomFromEnum<T>()
        {
            var val_6;
            System.Array val_2 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
            System.Random val_3 = new System.Random();
            int val_4 = val_2.Length;
            if((val_2.GetValue(index:  -2118263008)) != null)
            {
                    if(X0 == true)
            {
                    return (object)val_6;
            }
            
            }
            
            val_6 = 0;
            return (object)val_6;
        }
        public void Bind()
        {
        
        }
        public void Clear(bool gameExit)
        {
        
        }
        public LevelRandomManager()
        {
        
        }
    
    }

}
