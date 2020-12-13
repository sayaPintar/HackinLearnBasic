using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //bagian inputan

                Console.WriteLine("Masukkan Angka Bulat Yang Ingin dikonversi: ");
                int dec = int.Parse(Console.ReadLine());

                //bagian algoritma

                int x = 0;
                var ced = dec % 2;
                Console.WriteLine("Hasil Binary:");
                Console.WriteLine(ced);
                while (x < 99999999)
                {

                    x++;
                    
                    dec = dec / 2;
                    var deca = dec % 2;
                    
                    Console.WriteLine(deca);
                   if(dec == 1)
                    {
                        break;
                    }
                 
                }
                Console.ReadLine();
                

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
