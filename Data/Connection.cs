using System;
using System.Collections.Generic;
using System.Data;

namespace DataLoad.Data {

    public class Connection {

        public void InserRow (string[] row, Names tableName) {

            var sqlString = GetSql (tableName);
            var sqlParams = BuildParams (tableName);
            ControllerData ctda = new ControllerData ();
            try {

                var rSaved = ctda.Ejecutar (sqlString, CommandType.Text, sqlParams);
                
            } catch (Exception) {
                // Save log
            }

        }

        public string GetSql (Names tableName) {

            var _sqlString = $"INSERT INTO {tableName.ToString()} VALUES ({GetSqlInsert(tableName)})";
            return _sqlString;
        }

        public string GetSqlInsert (Names tableName) {

            switch (tableName) {
                case Names.PDT01:
                    return "";
                case Names.PDT02:
                    return "";
                case Names.PFT01:
                    return "";
                case Names.PFT02:
                    return "";
                case Names.PFT03:
                    return "";
                case Names.PFT04:
                    return "";
                case Names.PFT05:
                    return "";
                case Names.PPT01:
                    return "";
                case Names.PGT01:
                    return "";
                case Names.PGT02:
                    return "";
                case Names.PGT03:
                    return "";
                case Names.PHT02:
                    return "";
                case Names.PITC03:
                    return "";
                case Names.PITC04:
                    return "";
                case Names.PITC05:
                    return "";
                case Names.PITC08:
                    return "";
                case Names.PITC09:
                    return "";
                case Names.PITC10:
                    return "";
                case Names.PITC11:
                    return "";
                case Names.PITC12:
                    return "";
                case Names.PITC13:
                    return "";
                case Names.PITC15:
                    return "";
                case Names.PIT01:
                    return "";
                case Names.PIT04:
                    return "";
                case Names.PDTC01:
                    return "";
                case Names.PDTC12:
                    return "";
                default:
                    return "";
            }
        }
        private IEnumerable<Parametro> BuildParams (Names tableName) {

            switch (tableName) {
                case Names.PDT01:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };

                case Names.PDT02:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PFT01:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PFT02:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PFT03:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PFT04:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PFT05:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PPT01:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PGT01:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PGT02:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PGT03:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PHT02:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC03:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC04:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC05:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC08:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC09:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC10:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC11:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC12:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC13:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PITC15:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PIT01:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PIT04:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PDTC01:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                case Names.PDTC12:
                    return new List<Parametro> {
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                        new Parametro ("@od", 3),
                    };
                default:
                    return new List<Parametro> {
                        new Parametro ("@od", 3)
                    };
            }

        }
    }
}