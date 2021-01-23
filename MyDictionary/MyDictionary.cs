using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, K>
    {
        T[] _Id;
        K[] _deger;

        public MyDictionary()
        {
            _Id = new T[0];
            _deger = new K[0];
        }



        public void Add(T deger1, K deger2)
        {
            T[] tempArray = _Id;
            K[] tempArray1 = _deger;

            _Id = new T[_Id.Length + 1];
            _deger = new K[_deger.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                _Id[i] = tempArray[i];
            }
            _Id[_Id.Length - 1] = deger1;

            for (int i = 0; i < tempArray1.Length; i++)
            {
                _deger[i] = tempArray1[i];
            }
            _deger[_deger.Length - 1] = deger2;


            Console.WriteLine("Yeni Değer Başarıyla Eklendi! " + deger1 + " " + deger2);
        }



        public int Count
        {
            get { return _Id.Length; }
        }
    }
}
