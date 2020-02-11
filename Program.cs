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
            // var folderDataPath = @"C:\Users\Steve\Documents\Proyectos\ICICOR\datos"; 

            Console.WriteLine("Ingrese el enlace del documento con el nombre de las tablas y sus columnas");
            var folderTablePath = Console.ReadLine(); 
            // var folderTablePath = @"C:\Users\Steve\Documents\Proyectos\ICICOR\datos\table.txt"; 
            
            read.ReadFolder(@folderDataPath,@folderTablePath);  
            
        }
    }
}
