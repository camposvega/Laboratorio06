using System;

namespace Laboratorio_6
{
    public class Laboratorio : IEvaluacion
    {
        private String tipo;
        
        public int Porcentaje { get; set; }
        public string Nombre { get; set; }

        public Laboratorio(string tipo, int porcentaje, string nombre)
        {
            this.tipo = tipo;
            Porcentaje = porcentaje;
            Nombre = nombre;
        }

        public void evaluacion(int num, string tet)
        {
           
        }

        
    }
}