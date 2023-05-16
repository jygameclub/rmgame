using UnityEngine;

namespace Royal.Infrastructure.Utils.Randoming
{
    public class RandomManager : IContextUnit
    {
        // Properties
        public int Id { get; }
        
        // Methods
        public int get_Id()
        {
            return 5;
        }
        public void Bind()
        {
            System.DateTime val_1 = System.DateTime.Now;
            UnityEngine.Random.InitState(seed:  val_1.dateData.Millisecond);
        }
        public int Next(int min, int max)
        {
            return UnityEngine.Random.Range(min:  min, max:  max);
        }
        public bool NextBool()
        {
            return (bool)((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? 1 : 0;
        }
        public float Next(float min, float max)
        {
            return UnityEngine.Random.Range(min:  min, max:  max);
        }
        public T RandomFromList<T>(System.Collections.Generic.List<T> list)
        {
            int val_1 = this.Next(min:  0, max:  X19);
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public T RandomFromArray<T>(T[] array)
        {
            return (object)array[this.Next(min:  0, max:  array.Length)];
        }
        public float SymmetricNext(float min, float max)
        {
            float val_1 = UnityEngine.Random.Range(min:  min, max:  max);
            return (float)((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? (val_1) : (-val_1);
        }
        public RandomManager()
        {
        
        }
    
    }

}
