using System;
using System.Collections.Generic;
using System.IO;
using DataLoad.Data;

namespace DataLoad {
    public class Read {

        private readonly Connection connection = new Connection ();

        public void ReadFolder (string filePath, string tableFilePath) {

            for (int i = 0; i < Enum.GetNames (typeof (Names)).Length; i++) {

                Names CurrFile = (Names) i;

                var CurrPath = @$"{filePath}\{CurrFile}.txt";

                if (System.IO.File.Exists (CurrPath)) {

                    BuildTable (CurrPath,tableFilePath, CurrFile);

                } else {
                    Console.WriteLine ($"No se encontro la ruta {CurrPath}");
                    LogWriter log = new LogWriter ($"no se encontro el archivo {(i)}");
                }
            }
        }

        public void BuildTable (string dataFilePath,string tableFilePath,  Names tablename) {

            var lstParam = BuildParams (tablename,tableFilePath);

            using (StreamReader sr = File.OpenText (dataFilePath)) {
                string line = String.Empty;
                while ((line = sr.ReadLine ()) != null) {
                    
                    var columns = GetColumns (line, lstParam);

                    if (columns.Length == lstParam.Count) {
                        connection.InserRow (tablename, FillParams(lstParam, columns));
                    } else {
                        LogWriter log = new LogWriter ($"columna:{tablename.ToString()}:{line}");
                    }
                }
            }

        }

        public IEnumerable<Parametro> FillParams (List<Parametro> lstParam, string[] lstValues) {
            
            lstParam.ForEach (x => {
                x.valor = lstValues[lstParam.IndexOf (x)];
            });
            return lstParam;
        }

        public String[] GetColumns (string line, IEnumerable<Parametro> List = null) {

            try {

                var columns = line.Split (';');
                return columns;

            } catch (System.Exception) {
                ///
                return new string[0];
            }
        }
        public List<Parametro> BuildParams (Names tableName, string tableFilePath) {

            var retorno = new List<Parametro> ();
            
            using (StreamReader sr = File.OpenText ($"{tableFilePath}")) {
                string s = String.Empty;
                while ((s = sr.ReadLine ()) != null) {

                    var line = GetColumns (s);
                    if (line != null && line[0] == tableName.ToString ()) {
                        for (int i = 1; i < line.Length; i++) {
                            retorno.Add (new Parametro ($"@{line[i].ToString()}"));
                        }
                        return retorno;
                    }
                }
            }
            return retorno;
        }

    }
}