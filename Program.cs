using System;

namespace DataLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Read read = new Read(); 
            Console.WriteLine("Ingrese el enlace del documento");
             read.ReadFolder(@"C:\Users\Steve\Desktop\bdIcicor");  
            // var file = read.ReadTxt(Console.ReadLine());  
            // read.BuildTable(@"C:\Users\Steve\Desktop\bdIcicor\test.txt", Names.PDT01); 
        }
    }
}
