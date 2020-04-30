using System;

namespace Laboratorio_6
{
    public class Tarea : IEvaluacion
    {
        private DateTime fechaEntrega;

        public Tarea(DateTime fechaEntrega, int porcentaje, string nombre)
        {
            this.fechaEntrega = fechaEntrega;
            Porcentaje = porcentaje;
            Nombre = nombre;
        }

        public int Porcentaje { get; set; }
        public string Nombre { get; set; }
        public void evaluacion(int num, string tet)
        {
            throw new NotImplementedException();
        }

        public DateTime FechaEntrega
        {
            get => fechaEntrega;
            set => fechaEntrega = value;
        }
    }
}