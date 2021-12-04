using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] numara;
        V[] isim;
        public MyDictionary()
        {
            numara = new K[0];      //constructor çalıştığında dizi tanımlanıcak
            isim = new V[0];
        }

        public void Add(K _numara, V _isim)
        {
            K[] tempKey = numara;       //key için geçici dizi tanımlandı
            numara = new K[numara.Length + 1];        //eklenecek anahtar için eleman sayısı 1 arttırıldı
            for (int i = 0; i < tempKey.Length; i++)        //anahtarlar geçici diziden alındı
            {
                numara[i] = tempKey[i];
            }
            numara[numara.Length - 1] = _numara;        //son elemana istenilen değer eklendi

            V[] tempValue = isim;
            isim = new V[isim.Length + 1];
            for (int j = 0; j < tempValue.Length; j++)
            {
                isim[j] = tempValue[j];
            }
            isim[isim.Length - 1] = _isim;
        }

        public void Yazdır()        //anahtar ve değerleri birleştirip görüntülemek içiin yazdır metodu 
        {
            for (int i = 0; i < numara.Length; i++)
            {
                Console.WriteLine(numara[i] + "-" + isim[i]);
            }

        }
    }
}
