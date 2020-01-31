using System;
using System.IO;

namespace DataLoad
{
 public class Read {
        public void ReadFolder (string path) {

            for (int i = 0; i < Enum.GetNames (typeof (Names)).Length; i++) {

                Names CurrFile = (Names) i;
               
                var CurrPath = @$"{path}\{CurrFile}.txt";

                if (System.IO.File.Exists (CurrPath)) {
                    BuildTable (CurrPath, CurrFile);
                } else {
                    Console.WriteLine ($"No se encontro la ruta {CurrPath}");
                    //Save in logs
                }
            }
        }

        public void BuildTable (string path, Names tablename) {

            var ColumZise = VerifyColumns (tablename);

            using (StreamReader sr = File.OpenText (path)) {
                string s = String.Empty;
                while ((s = sr.ReadLine ()) != null) {
                    ///Mandamos a convertir linea por linea a columnas
                    var columns = GetColumns (s);

                    if (columns.Length == ColumZise) {
                        ///inset into database
                    } else {
                        Console.WriteLine ("Error");
                    }
                }
            }

        }
        public String[] GetColumns (string line) {

            try {

                var columns = line.Split (';');
                return columns;

            } catch (System.Exception) {
                ///
                return new string[0];
            }
        }

        private int VerifyColumns (Names tablename) {

            switch (tablename) {
                case Names.PDT01:
                    return 0;
                case Names.PDT02:
                    return 14;
                case Names.PFT01:
                    return 0;
                case Names.PFT02:
                    return 0;
                case Names.PFT03:
                    return 0;
                case Names.PFT04:
                    return 0;
                case Names.PFT05:
                    return 0;
                case Names.PPT01:
                    return 0;
                case Names.PGT01:
                    return 0;
                case Names.PGT02:
                    return 13;
                case Names.PGT03:
                    return 0;
                case Names.PHT02:
                    return 0;
                case Names.PITC03:
                    return 0;
                case Names.PITC04:
                    return 0;
                case Names.PITC05:
                    return 0;
                case Names.PITC08:
                    return 0;
                case Names.PITC09:
                    return 0;
                case Names.PITC10:
                    return 0;
                case Names.PITC11:
                    return 0;
                case Names.PITC12:
                    return 0;
                case Names.PITC13:
                    return 0;
                case Names.PITC15:
                    return 0;
                case Names.PIT01:
                    return 0;
                case Names.PIT04:
                    return 0;
                case Names.PDTC01:
                    return 0;
                case Names.PDTC12:
                    return 0;
                default:
                    return 0;
            }

        }

    }
}