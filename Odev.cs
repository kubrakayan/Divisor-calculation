using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev : MonoBehaviour
{
    void fonksiyonListe(int sayi1, int sayi2)
    {
            string sonuc = "";
            for (int a = sayi1; a <= sayi2; a++)
            {
            sonuc = sonuc + ", " + a;
            }
            print("Tüm liste elemanlarý: "+sonuc);
            string sonuc1 = "";
            for (int b = sayi1; b <= sayi2; b++)
            {
                if (b % 2 == 0)
                {
                sonuc1 = sonuc1 + ", " +b;
                }
            }
            print("Ýkinin katý olanlar: " + sonuc1);
            string sonuc2 = "";
            for (int a = sayi1; a<= sayi2; a++)
            {
                if (a % 3 == 0)
                {
                sonuc2 = sonuc2 + ", " + a;
                }
            }
            print("Üçün katý olanlar: " + sonuc2);
            string sonuc3 = "";
            for (int a = sayi1; a <= sayi2; a++)
            {
                if (a % 4 == 0)
                {
                sonuc3 = sonuc3 + ", " + a;
                }
            }
            print("Dördün katý olanlar: " + sonuc3);
            string sonuc4 = "";
            for (int a = sayi1; a <= sayi2; a++)
            {
                if (a % 5 == 0)
                {
                sonuc4 = sonuc4 + ", " + a;
                }
            }
            print("Beþin katý olanlar: " + sonuc4);
       
    }

    void Start()
    {
        fonksiyonListe(10, 32);
    }


    void Update()
    {

    }
}