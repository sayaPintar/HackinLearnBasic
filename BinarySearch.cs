using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using System.Drawing;

namespace OCRSeeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //binary  search 
            int[] data = { 1, 2, 3, 4, 5, 6 };

            //bagian inputan
            Console.WriteLine("Masukkan data yang ingin dicari: ");
            int dicari = int.Parse(Console.ReadLine());

            //algoritma

            int first = 0;
            int end = data.Length - 1;

            //
           

            while(first <= end)
            {
                int tengah = (first + end) / 2;
                if(dicari == data[tengah])
                {
                    Console.WriteLine("Data Ditemukan di indeks - " + tengah);
                    Console.ReadLine();
                    break;
                }else if (dicari < data[tengah])
                {
                    end = tengah - 1;


                }
                else
                {
                    first = tengah + 1;
                }

              
            }


        }
}
