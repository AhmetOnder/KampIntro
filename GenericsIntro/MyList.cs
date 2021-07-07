using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // Buradaki T type i ifade ediyor. A b de olabilir.
                    // dışarıdan T yi belirliyoruz o buraya göre çalışıyor.
    {
        T[] items; // aşağıdaki constraktor için. ctor yazdık ve tab tab yaptık .constraktor yaptı.
        public MyList()
        {
            items = new T[0]; // MyList new lendiğinde burası çalışır.
        }
        public void Add(T item) // item ismi. a b veya eleman olabilir
        {
            T[] tempArray = items; // aşağıda newlendiğinden eskiler silinir. Silinen referans numarasıdır aslında. burada referans numarasını tutuyoruz
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        } 
    }
}
