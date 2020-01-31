using System;
using DataLoad.Data;

namespace DataLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            
           ControllerData controller = new ControllerData(); 
// TestConnection
            // controller.IsServerConnected(); 
            Console.WriteLine(controller.IsServerConnected());

            // Read read = new Read(); 
            // Console.WriteLine("Ingrese el enlace del documento");
            //  read.ReadFolder(@"C:\Users\Steve\Desktop\bdIcicor");  
            // var file = read.ReadTxt(Console.ReadLine());  
            // read.BuildTable(@"C:\Users\Steve\Desktop\bdIcicor\test.txt", Names.PDT01); 



        }
    }
}
