using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MyDictonary
{
    
    class MyDictionary<T, K>
    {
        T[] plaques;
        K[] names;
        internal readonly bool Lenght;
        public MyDictionary()
        {
            plaques = new T[0];
            names = new K[0];
        }
        public void Add(T plaque, K name)
        {
            T[] tempArray = plaques;
            plaques = new T[plaques.Length + 1];

            K[] tempArray2 = names;
            names = new K[names.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                plaques[i] = tempArray[i];
            }
            plaques[plaques.Length - 1] = plaque;
            for (int i = 0; i < tempArray2.Length; i++)
            {
                names[i] = tempArray2[i];
            }


            names[names.Length - 1] = name;
        }
        

        public void ToDictionary()
        {
            for (int  i = 0;  i < plaques.Length;  i++)
            {
                Console.WriteLine(plaques[i]+ " " + names[i]);
            }
        }

        
    }
}
        
       

