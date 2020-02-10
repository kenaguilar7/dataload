using System;
using System.Data;

namespace DataLoad.Data {
    public class Parametro {

        public String nombre { get; set; }
        public Object valor { get; set; }
        public SqlDbType tipoDato { get; set; }
        public int tamanyo { get; set; }
        public ParameterDirection direction { get; set; }
        public Parametro (String nombre) {
            this.nombre = nombre;
            this.direction = ParameterDirection.Input;
        }
        public Parametro (String nombre, object valor) {
            this.nombre = nombre;
            this.valor = valor;
            this.direction = ParameterDirection.Input;
        }
        public Parametro (String nombre, SqlDbType tipoDato, int tamanyo) {
            this.nombre = nombre;
            this.tipoDato = tipoDato;
            this.tamanyo = tamanyo;
            this.direction = ParameterDirection.Output;
        }

    }
}