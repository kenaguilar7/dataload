using System;
using DataLoad.Data;

namespace DataLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Read read = new Read(); 
            Console.WriteLine("Ingrese el enlace del documento");
            var folderDataPath = Console.ReadLine(); 

            Console.WriteLine("Ingrese el enlace del documento con el nombre de las tablas y sus columnas");
            var folderTablePath = Console.ReadLine(); 
            
            read.ReadFolder(@folderDataPath,@folderTablePath);  
            
        }
    }
}
