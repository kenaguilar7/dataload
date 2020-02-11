using System;
using System.Linq; 
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataLoad.Data {

    public class Connection {

        public void InserRow (Names tableName,IEnumerable<Parametro> lstParams) {

            var sqlString = GetSql (tableName, lstParams.ToList());
            ControllerData ctda = new ControllerData ();
            try {
                
                Console.WriteLine("|");
                ctda.Ejecutar (sqlString, CommandType.Text, lstParams);
                
            } catch (Exception ex) {
                throw ex; 
            }

        }
        public void SaveLog(String data, DataTable tableName){
            string createText = $"{data} + {Environment.NewLine}";

            File.WriteAllText(data, createText);
        }

        private string GetSql (Names tableName, List<Parametro> lstParams) {

            var _sqlString = $"INSERT INTO {tableName.ToString()} ({GetSqlString(lstParams)}) VALUES ({GetSqlString(lstParams, useAt: true)})";
            return _sqlString;
        }

        public string GetSqlString(List<Parametro> lstParams, bool useAt = false){
            var delimeter = (useAt)? ",@":","; 
            // var lst = from n in lstParams select  n.nombre.Remove(0,1);
            var lst = from n in lstParams select  GetValueString(lstParams.FirstOrDefault(), n);

            string GetValueString(Parametro firstInList, Parametro curr){
                    if (firstInList.Equals(curr) && useAt)
                        return curr.nombre; 
                    else
                        return curr.nombre.Remove(0,1); 
            }; 

            return string.Join(delimeter, lst); 
        }
        // public string GetSqlStringAndParamsAt(List<Parametro> lstParams)=>GetSqlString(lstParams, useAt: true);
      
    }
}