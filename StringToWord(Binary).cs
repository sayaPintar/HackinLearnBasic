using System;
using System.Net.Http;
using System.Net;
using System.Linq;
using System.Text.RegularExpressions;


public class Program
{
   
    static void Main(string[] args)
    {
        //data penampung konversi
      int[] number = {0,1};
      
        //bagian inputan
        Console.WriteLine("Masukkan Kalimat:");
        
        string[] konversi = new string[4];
        for(int i = 0; i < konversi.Length; i++){
            konversi[i] = Console.ReadLine();
        }
        
        
        
        //algoritma konversi
        
        for(int x = 0; x < konversi.Length; x++){
            
            if(konversi[x] == "zero"){
                
              Console.Write(number[0]+"\r");
            }else if(konversi[x] == "one"){
                Console.Write(number[1]+"\r");
            }
            
        }
     
         
         
    }
}
