namespace ogrenci bilgi sistemi
{


    class program
    {



        static void Main(string[] args)
        {

            Console.WriteLine("**** Ogrenci Bilgi ****");
            Console.WriteLine();
            string isim, soyisim, numara;
            int sinav1, sinav2, proje,ort;






            isim = "Murad";
            soyisim = "Aghayev";
            numara = "12345678";



            Console.WriteLine("isim: "+ isim);
            Console.WriteLine("soyisim: " + soyisim);
            Console.WriteLine("numara: " + numara);

            Console.WriteLine();
            Console.WriteLine("**** Ogrenci Notu ****");
            Console.WriteLine();

            sinav1 = 45;
            sinav2 = 55;
            proje = 56;

            ort = (sinav1 + sinav2 + proje) / 2;


            Console.WriteLine("Sinav1 = " + sinav1);
            Console.WriteLine("Sinav2 = " + sinav2);
            Console.WriteLine("Proje Notu = " + proje);

            Console.WriteLine();
            Console.WriteLine("**** Ortalama ****");
            Console.WriteLine();

            Console.WriteLine("Ortalama = " +ort);






            Console.Read();

        }


    }




}