using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinalDB.Data.Models
{
    internal class Consola
    {
        public int Id { get; set; }
        public string NombreConsola { get; set; }
        public string Compania { get; set; }
        public int AnioLanzamiento { get; set; }
        public int Generacion { get; set; }


        //Constructor sin parametros
        public Consola() { }


        //Constructor con parametros
        public Consola(int id, string nombreConsola, string compania, int anioLanzamiento, int generacion)
        {
            Id = id;
            NombreConsola = nombreConsola;
            Compania = compania;
            AnioLanzamiento = anioLanzamiento;
            Generacion = generacion;
        }
    }
}